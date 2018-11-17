using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LXGuardianCheck
{
    public partial class FormInsertProject : Form
    {
        public int ProjID, DeviceID;
        public String MNCode, ProjName;
        public DateTime StartDate, EndDate;

        bool inputError = false;

        public FormInsertProject()
        {
            InitializeComponent();
        }

        private void inputErrorHandle(string aa)
        {
            inputError = true;
            MessageBox.Show(aa + "数据格式错误！");                                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProjID = Int32.Parse(textBox1.Text);
            }
            catch (Exception e1)
            {
                inputErrorHandle("工程编号");
                return;
            }

            try
            {
                DeviceID = Int32.Parse(textBox2.Text);
            }
            catch (Exception e1)
            {
                inputErrorHandle("设备编号");
                return;
            }

            try
            {
                MNCode = textBox3.Text;
            }
            catch (Exception e1)
            {
                inputErrorHandle("MN码");
                return;
            }
            try
            {
                ProjName = textBox4.Text;
            }
            catch (Exception e1)
            {
                inputErrorHandle("工程名称");
                return;
            }
            try
            {
                StartDate = dateTimePicker1.Value;
                EndDate = dateTimePicker2.Value;
            }
            catch (Exception e1)
            {
                inputErrorHandle("日期");
                return;
            }
        }

        private void FormInsertProject_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddYears(1);
        }

        private void FormInsertProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inputError == true)
            {
                e.Cancel = true;
                inputError = false;
            }
        }
    }
}
