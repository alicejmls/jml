using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace programs
{
    public partial class graph : Form
    {
        BindingSource mySourceQueryData = new BindingSource();
        const String serverConnectionString = "Data Source=101.200.45.217;Initial Catalog=dustmonitor_sh;Persist Security Info=True;User ID=root;Password=c9ra@86hhd; characterset=utf8;sslmode=none";

        //横坐标数组
        List<string> x = new List<string>() { };
        //纵坐标数组
        List<double> y = new List<double>() { };

        public graph()
        {
            InitializeComponent();
            // 设置曲线的样式
            Series series = chart1.Series[0];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.Spline;
            // 线宽2个像素
            series.BorderWidth = 2;
            // 线的颜色：红色
            series.Color = System.Drawing.Color.Red;
            //图示上的文字
            //series.LegendText = "演示曲线";

            //// 在chart中显示数据
            //int x = 0;

          

        }

        private void comboBox1()
        {//工地
            string sql = string.Format("SELECT Project_ID, Project_Name FROM tb_project  LIMIT 20;");
            MySqlConnection connPi = new MySqlConnection(serverConnectionString);
            connPi.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "table1");
            comboBox2.DataSource = ds.Tables["table1"];
            comboBox2.DisplayMember = "Project_Name";
            comboBox2.ValueMember = "Project_ID";
        }

        private void graph_Load(object sender, EventArgs e)
        {
            
            comboBox1();
            this.radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {//噪音
            if (radioButton1.Checked)
            {
                chart1.Series.Clear();
            }
            chart1.Series.Add("噪音");
            x.Clear();
            y.Clear();
            bindnose();


        }

        private void bindnose()
        {
            List<double> y = new List<double>() { };
            chart1.Series["噪音"].Points.DataBindXY(x, y);
            chart1.Series["噪音"].Color = Color.Red;
            Series series = chart1.Series["噪音"];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.Line;


            using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
            {
                //建立DataSet对象(相当于建立前台的虚拟数据库)
                DataSet ds = new DataSet();
                //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
                DataTable dtable;
                //建立DataRowCollection对象(相当于表的行的集合)
                DataRowCollection coldrow;
                //建立DataRow对象(相当于表的列的集合)
                DataRow drow;
                //打开连接
                connPi.Open();
                //建立DataAdapter对象  
                string sql = string.Format("SELECT a.`Noise` AS '噪音',a.`Date` AS '时间' FROM tb_monitordata01 a INNER JOIN tb_project b ON a.Project_ID=b.Project_ID RIGHT JOIN (SELECT Device_Code, MAX(`Date`) AS DataTime FROM tb_monitordata01 WHERE `Date` > DATE(NOW()) GROUP BY Project_ID) AS M ON a.`Device_Code`=M.Device_Code AND a.Date = M.DataTime ORDER BY a.`Device_Code`");//重点，重点，重点，编写符合你查询条件的sql语句
                MySqlCommand sqlCmd = new MySqlCommand(sql, connPi);
                MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
                //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
                msda.Fill(ds, "tabuser");
                //将数据表tabuser的数据复制到DataTable对象（取数据）
                dtable = ds.Tables["tabuser"];
                //用DataRowCollection对象获取这个数据表的所有数据行
                coldrow = dtable.Rows;
                //逐行遍历，取出各行的数据
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    y.Add(Convert.ToDouble(drow[0]));
                    x.Add(drow[1].ToString());
                }
            }
            chart1.Series["噪音"].Points.DataBindXY(x, y);
        }

        private void bindDust()
        {
            string projectName = comboBox2.Text;
            Series series = chart1.Series["粉尘"];
            series.ChartType = SeriesChartType.Line;

            try
            {
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    //建立DataSet对象(相当于建立前台的虚拟数据库)
                    DataSet ds = new DataSet();
                    //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
                    DataTable dtable;
                    //建立DataRowCollection对象(相当于表的行的集合)
                    DataRowCollection coldrow;
                    //建立DataRow对象(相当于表的列的集合)
                    DataRow drow;
                    //打开连接
                    connPi.Open();
                    //建立DataAdapter对象
                    string sql = "SELECT a.dust,a.date FROM `tb_project` b INNER JOIN `tb_monitordata01` a ON a.Project_ID=b.Project_ID WHERE b.Project_Name='" + projectName + "' ORDER BY a.date DESC  LIMIT 10;	 ";
                    MySqlCommand sqlCmd = new MySqlCommand(sql, connPi);
                    MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
                    //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
                    msda.Fill(ds, "tabuser");
                    //将数据表tabuser的数据复制到DataTable对象（取数据）
                    dtable = ds.Tables["tabuser"];
                    //用DataRowCollection对象获取这个数据表的所有数据行
                    coldrow = dtable.Rows;
                    //逐行遍历，取出各行的数据
                    for (int inti = 0; inti < coldrow.Count; inti++)
                    {
                        drow = coldrow[inti];
                        y.Add(Convert.ToDouble(drow[0]));

                        x.Add(Convert.ToDateTime(drow[1]).ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                }
                chart1.Series["粉尘"].Points.DataBindXY(x, y);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //连接数据库 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {//粉尘
            if (radioButton2.Checked)
            {
                chart1.Series.Clear();
            }
            chart1.Series.Add("粉尘");
            x.Clear();
            y.Clear();
            bindDust();
        }


    }
}
