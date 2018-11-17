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

namespace programs
{
    public partial class Adddata : Form
    {
        public int ProjectCode, DeviceCode;
        public string isOnline, ProjectName;
        public DateTime StartDate, EndDate;

        BindingSource mySourceQueryData = new BindingSource();
        const String serverConnectionString = "Data Source=101.200.45.217;Initial Catalog=dustmonitor_sh;Persist Security Info=True;User ID=root;Password=c9ra@86hhd; characterset=utf8;sslmode=none";
        
        bool inputError = false;
        public Adddata()
        {
            InitializeComponent();
        }

        private void Adddata_Load(object sender, EventArgs e)
        {
            txtProjectDoTime.Value= DateTime.Today;
            txtProjectStopTime.Value= DateTime.Today.AddYears(1);
        }

        private void Adddata_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inputError == true)
            {
                e.Cancel = true;
                inputError = false;
            }
        }

        private void inputErrorHandle(string aa)
        {
            inputError = true;
            MessageBox.Show(aa + "数据格式错误！");
        }

        private void button1_Click(object sender, EventArgs e)
        {//确认保存
            try
            {
                ProjectCode = Int32.Parse(txtProjectCode.Text);
            }
            catch (Exception e1)
            {
                inputErrorHandle("工地编号");
                return;
            }
            try
            {
                DeviceCode = Int32.Parse(txtDeviceCode.Text);
            }
            catch (Exception e1)
            {
                inputErrorHandle("设备编号");
                return;
            }
            try
            {
                StartDate = txtProjectDoTime.Value;
                EndDate = txtProjectStopTime.Value;
            }
            catch (Exception e1)
            {
                inputErrorHandle("日期");
                return;
            }
            try
            {
                isOnline = txtProjectisOnline.Text;
            }
            catch (Exception e1)
            {
                inputErrorHandle("设备编号");
                return;
            }
            try
            {
                ProjectName = txtProjectName.Text;
            }
            catch (Exception e1)
            {
                inputErrorHandle("工程名字");
                return;
            }

            string sql = string.Format("INSERT INTO tb_project SET Project_Code = '"+ ProjectCode + "', Device_Code = '"+ DeviceCode + "',Project_beginDate='"+ StartDate + "',Project_endDate='"+ EndDate + "',Project_isOnline="+ isOnline + ",Project_Name='"+ ProjectName + "',Project_Address='1111',Project_Type=1,Project_Linkman='123456',Project_Phone='111111'");
            try
            {
                MySqlConnection connPi = new MySqlConnection(serverConnectionString);
                connPi.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connPi);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "table1");
                
                MessageBox.Show("添加成功");
                this.Visible = false;
            }
            catch
            {
                MessageBox.Show("添加失败");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {//取消
         this.Visible = false;

        }
    }
}
