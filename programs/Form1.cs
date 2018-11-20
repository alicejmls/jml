using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace programs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static bool timer=false;
        BindingSource mySourceQueryData = new BindingSource();
        const String serverConnectionString = "Data Source=101.200.45.217;Initial Catalog=dustmonitor_sh;Persist Security Info=True;User ID=root;Password=c9ra@86hhd; characterset=utf8;sslmode=none";

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshLatestData();
            if (this.rbssdata.Checked == true)
            {
                panelTime.Visible = false;
            }
            this.radTime.Checked = true;
            this.cboxAll.Checked = true;

            cBoxDeviceCodes();
            comboBox2();

        }
    
        private void cBoxDeviceCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxDeviceCode.SelectedIndex > -1)
            {
                DataRowView drv = (DataRowView)cBoxDeviceCode.SelectedItem;
                int id = Convert.ToInt32(drv.Row["Project_ID"].ToString());
                string sql = string.Format("SELECT Project_ID, Project_Name FROM tb_project where Project_ID='" + id + " ' LIMIT 20;");
                MySqlConnection connPi = new MySqlConnection(serverConnectionString);
                connPi.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "table1");
                comboBox1.DataSource = ds.Tables["table1"];
                comboBox1.DisplayMember = "Project_Name";
                comboBox1.ValueMember = "Project_ID";
            }
            return;
        }
        private void cBoxDeviceCodes()
        {
            string sql = string.Format("SELECT Project_ID, Device_Code FROM tb_monitordata01  LIMIT 20;");
            MySqlConnection connPi = new MySqlConnection(serverConnectionString);
            connPi.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "table1");
            cBoxDeviceCode.DataSource = ds.Tables["table1"];
            cBoxDeviceCode.DisplayMember = "Device_Code";
            cBoxDeviceCode.ValueMember = "Project_ID";
            connPi.Close();
        }
        private void comboBox2()
        {
            string sql = string.Format("SELECT Project_ID, Project_Name FROM tb_project  LIMIT 20;");
            MySqlConnection connPi = new MySqlConnection(serverConnectionString);
            connPi.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "table1");
            comboBox1.DataSource = ds.Tables["table1"];
            comboBox1.DisplayMember = "Project_Name";
            comboBox1.ValueMember = "Project_ID";
        }
        void RefreshLatestData()
        {
            string sql = "SELECT m.Device_Code AS 工地编号,m.Date AS DataTime,m.Dust AS 粉尘," +
                "m.Noise AS 噪音,p.Project_Name AS 工程名称 FROM tb_monitordata01 m " +
                "INNER JOIN tb_project p ON m.Project_ID=p.Project_ID " +
                "RIGHT JOIN (SELECT Device_Code, MAX(`Date`) AS DataTime " +
                "FROM tb_monitordata01 WHERE `Date` > DATE(NOW()) GROUP BY Project_ID) AS T2 " +
                "ON m.Device_Code = T2.Device_Code AND m.Date = T2.DataTime ORDER BY 工地编号; ";
            try
            {
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    connPi.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    dgvsssj.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    dgvsssj.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    connPi.Close();
                }
            }
            catch (MySqlException et)
            {
                MessageBox.Show(et.Message);
            }
        }
        void statisticalData()
        {

        }
        void ProjectData()
        {

            string Gdsql = " SELECT Project_Code , Device_Code  ,Project_beginDate ,Project_endDate ,Project_isOnline , Project_Name   FROM tb_project ORDER BY Project_beginDate DESC LIMIT 100 ";
            try
            {

                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    connPi.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(Gdsql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    dgvgjqd.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    //dgvgjqd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    connPi.Close();
                }
            }
            catch (MySqlException et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    RefreshLatestData();
                    break;
                case 1:
                    statisticalData();
                    break;
                case 2:
                    ProjectData();
                    break;

            }
        }
        private void query_Click(object sender, EventArgs e)
        {//查询
            string sql = "";
            string whereString = "";

            if (rbssdata.Checked == true)
            {
                whereString = " Where `Date` < '" + DatePicker.Value.ToShortDateString() + " " + datehours.Value.ToShortTimeString() + "'";
                if (cboxAll.Checked == false)
                {
                    whereString += " And Project_ID = '" + cBoxDeviceCode.SelectedValue.ToString() + "'";
                }
                sql = "SELECT * FROM tb_monitordata01 " + whereString + " ORDER BY `Date` DESC LIMIT " + numericUpDown1.Value.ToString();
            }
            if (rdtjdata.Checked == true)
            {
                whereString = "WHERE `Date`<'" + DatePicker.Value.ToShortDateString() + "'";
                if (radTime.Checked == true)
                {
                    whereString += "'" + datehours.Value.ToShortTimeString() + "'";
                }
                if (cboxAll.Checked == false)
                {
                    whereString += "AND m.`Project_ID` = '" + cBoxDeviceCode.SelectedValue.ToString() + "'";
                }
                sql = "SELECT m.`Device_Code` AS 设备编号,p.Project_Name AS 工程名称 , COUNT(*) AS 总数据, COUNT(IF(Dust>0,1, NULL)) AS 粉尘数据 , COUNT(IF(Noise>0,1, NULL)) AS 噪声数据 FROM tb_monitordata01 m LEFT JOIN tb_project p ON m.Project_ID=p.Project_ID " + whereString;

            }
            try
            {
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    connPi.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    dataGridView3.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    dataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    connPi.Close();
                }
            }
            catch (MySqlException et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void cboxAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
            {
                plCondition.Visible = false;
            }
            else
            {
                plCondition.Visible = true;
            }


        }
        private void rbssdata_CheckedChanged(object sender, EventArgs e)
        {
            if (rbssdata.Checked == true)
            {
                panelTime.Visible = false;
            }
            else
            {
                panelTime.Visible = true;
            }

        }
        private void rdtjdata_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtjdata.Checked == true)
            {
                panleData.Visible = false;
            }
            else
            {
                panleData.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {//刷新
            RefreshLatestData();
        }
        private void radTime_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTime.Checked == true)
            {
                panlHour.Visible = true;
            }
            else
            {
                panlHour.Visible = false;
            }
        }
        private void radDay_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radDay.Checked == true)
            {
                panlHour.Visible = false;
            }
            else
            {
                panlHour.Visible = true;
            }
        }

        private void dgvgjqd_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            // EndEdit(false);
            ProjectData();
        }

        private void dgvgjqd_DoubleClick(object sender, EventArgs e)
        {
            beginEdit();
        }

        private void beginEdit()
        {//可编辑
            if (dgvgjqd.ReadOnly == true)
            {
                dgvgjqd.ReadOnly = false;
                dgvgjqd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private void dgvgjqd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        //更新数据库
        private void dgvgjqd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dgvgjqd.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dgvgjqd.Rows[e.RowIndex].Cells[0].Value.ToString();//获取焦点触发行的第一个值
            string value = dgvgjqd.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
            string strcomm = "update tb_project set " + strcolumn + "='" + value + "'where Project_Code ='" + strrow + "'";
            //UPDATE tb_project SET Project_isOnline="0"  WHERE Project_Code='2222'
            MySqlConnection connPi = new MySqlConnection(serverConnectionString);
            try
            {
                connPi.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strcomm, connPi);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                dgvgjqd.DataSource = mySourceQueryData;
                mySourceQueryData.DataSource = table;
                //dgvgjqd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                connPi.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());

            }
            finally
            {
                connPi.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//修改数据
            beginEdit();
        }

        private void button5_Click(object sender, EventArgs e)
        {//保存修改
            ProjectData();
            dgvgjqd.ReadOnly = true;
            dgvgjqd.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            //EndEdit(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {//取消修改
            ProjectData();
            dgvgjqd.ReadOnly = true;
            dgvgjqd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            return;
        }

        private void insertdate_Click(object sender, EventArgs e)
        {//增加数据
            Adddata sj = new Adddata();
            sj.Show();
            //this.Visible = false;
        }

        private void dgvgjqd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {//在为当前选定的单元格停止编辑模式时发生
            //string strData = (string)dgvgjqd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            // 更改数据到数据库4
            // DbClass.GetInstance().Add(strData);


        }

        /// <summary>
        /// 根据数据改变数据框的背景颜色
        /// </summary>
        private void dgvsssj_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int countOnLine, countNotOnLine, countDustError, countNoiseError;
            countOnLine = countNotOnLine = countDustError = countNoiseError = 0;

            for (int i = 0; i < this.dgvsssj.RowCount; i++)
            {
                DateTime dataTime = Convert.ToDateTime(dgvsssj.Rows[i].Cells[1].Value);
                if (dataTime < System.DateTime.Now.AddHours(-1))
                {
                    dgvsssj.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    countNotOnLine += 1;
                }
                else
                {
                    dgvsssj.Rows[i].Cells[1].Style.BackColor = Color.White;
                    //myDataView.Rows[i].Cells[1].Style.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                    countOnLine += 1;
                }
                if (0 > Convert.ToSingle(dgvsssj.Rows[i].Cells[2].Value))
                {
                    dgvsssj.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    countDustError += 1;
                }
                else
                    dgvsssj.Rows[i].Cells[2].Style.BackColor = Color.White;

                if (0 > Convert.ToSingle(dgvsssj.Rows[i].Cells[3].Value))
                {
                    dgvsssj.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    countNoiseError += 1;
                }
                else
                    dgvsssj.Rows[i].Cells[4].Style.BackColor = Color.White;

            }

            toolStripLabel1.Text = "在线设备数量：" + countOnLine.ToString() + "    ";
            toolStripLabel2.Text = "断线设备数量：" + countNotOnLine.ToString() + "    ";
            toolStripLabel3.Text = "粉尘仪故障数量：" + countDustError.ToString() + "    ";
            toolStripLabel4.Text = "声级计故障数量：" + countNoiseError.ToString() + "    ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer == true)
            {
                RefreshLatestData();
                ProjectData();
            }
        }
        //导出excel
        private void ExportExcels_Click(object sender, EventArgs e)
        {
            string fileName = "E:" + "\\KKHMD.xls";
            ExportExcel(fileName, dataGridView3);
        }
        //导出excel
        private void ExportExcel(string fileName, DataGridView dataGridView3)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
                                                                                                                                  //写入标题
            for (int i = 0; i < dataGridView3.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView3.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < dataGridView3.Rows.Count; r++)
            {
                for (int i = 0; i < dataGridView3.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dataGridView3.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
            MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button7_Click(object sender, EventArgs e)
        {//曲线图
            graph gh = new graph();
            gh.Show();
        }
        
    }

}

