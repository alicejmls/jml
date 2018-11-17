using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LXGuardianCheck
{

    public partial class FormMain : Form
    {
        private bool editDataGridViewDateTime = false;

        const String serverConnectionString = "Data Source=115.29.114.54;Initial Catalog=JYInforDB;Persist Security Info=True;User ID=jyinfor;Password=jyinfor;characterset=utf8";

        BindingSource mySourceQueryData = new BindingSource();

        public FormMain()
        {
            InitializeComponent();
        }

        private void beginEdit()
        {
            if (dataGridView2.ReadOnly == true)
            {
                dataGridView2.ReadOnly = false;
                //dataGridView2.AllowUserToAddRows = true;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
                //this.deviceUseHistTableAdapter.Connection.Open();
                //this.deviceUseHistTableAdapter.Transaction = this.deviceUseHistTableAdapter.Connection.BeginTransaction();
            }
        }

        private void EndEdit(bool cancel)
        {
            if (dataGridView2.ReadOnly == false)
            {
                if (cancel == false)
                {
                    if (this.deviceUseHistTableAdapter.Transaction != null)
                    {
                        this.deviceUseHistTableAdapter.Transaction.Commit();
                        this.deviceUseHistTableAdapter.Transaction = null;
                    }
                    try
                    {
                        this.deviceUseHistTableAdapter.Update(this.deviceUseHistDataSet.DeviceUseHist);
                        this.deviceUseHistTableAdapter.Fill(this.deviceUseHistDataSet.DeviceUseHist);
                        dataGridView2.Columns[0].Visible = false;
                        dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        //dataGridView2.AllowUserToAddRows = false;
                        dataGridView2.ReadOnly = true;
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("保存失败！失败原因：" + e1.Message);
                    }
                }
                else
                {
                    if (this.deviceUseHistTableAdapter.Transaction != null)
                    {
                        this.deviceUseHistTableAdapter.Transaction.Rollback();
                        this.deviceUseHistTableAdapter.Transaction = null;
                    }

                    this.deviceUseHistTableAdapter.Fill(this.deviceUseHistDataSet.DeviceUseHist);
                    dataGridView2.Columns[0].Visible = false;
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //dataGridView2.AllowUserToAddRows = false;
                    dataGridView2.ReadOnly = true;
                }
            }
            dataGridView2.Focus();
            dataGridView2.CurrentCell = dataGridView2[1, 0];
        }

        /// <summary>
        /// 根据数据改变数据框的背景颜色
        /// </summary>
        private void dataGridView_BackColorChange(DataGridView myDataView)
        {
            int countOnLine, countNotOnLine, countDustError, countNoiseError, CountWeatherError, countApexError;
            countOnLine = countNotOnLine = countDustError = countNoiseError = CountWeatherError = countApexError = 0;

            for (int i = 0; i < myDataView.RowCount; i++)
            {
                DateTime dataTime = Convert.ToDateTime(myDataView.Rows[i].Cells[1].Value);
                if (dataTime < System.DateTime.Now.AddHours(-1))
                {
                    myDataView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                    countNotOnLine += 1;
                }
                else
                {
                    myDataView.Rows[i].Cells[1].Style.BackColor = Color.White;
                    //myDataView.Rows[i].Cells[1].Style.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                    countOnLine += 1;
                }

                if (0 > Convert.ToSingle(myDataView.Rows[i].Cells[3].Value))
                {
                    myDataView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                    countDustError += 1;
                }
                else
                    myDataView.Rows[i].Cells[3].Style.BackColor = Color.White;

                if (0 > Convert.ToSingle(myDataView.Rows[i].Cells[4].Value))
                {
                    myDataView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                    countNoiseError += 1;
                }
                else
                    myDataView.Rows[i].Cells[4].Style.BackColor = Color.White;

                if (0 > Convert.ToSingle(myDataView.Rows[i].Cells[5].Value))
                {
                    myDataView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                    countApexError += 1;
                }
                else
                    myDataView.Rows[i].Cells[5].Style.BackColor = Color.White;
                if (0 > Convert.ToSingle(myDataView.Rows[i].Cells[6].Value))
                    myDataView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                else
                    myDataView.Rows[i].Cells[6].Style.BackColor = Color.White;
                if (0 > Convert.ToSingle(myDataView.Rows[i].Cells[7].Value))
                {
                    myDataView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                    CountWeatherError += 1;
                }
                else
                    myDataView.Rows[i].Cells[7].Style.BackColor = Color.White;
                if (0 > Convert.ToSingle(myDataView.Rows[i].Cells[8].Value))
                    myDataView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                else
                    myDataView.Rows[i].Cells[8].Style.BackColor = Color.White;
                if (0 > Convert.ToSingle(myDataView.Rows[i].Cells[9].Value))
                    myDataView.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                else
                    myDataView.Rows[i].Cells[9].Style.BackColor = Color.White;
            }

            toolStripStatusLabel1.Text = "在线设备数量：" + countOnLine.ToString() + "    ";
            toolStripStatusLabel2.Text = "断线设备数量：" + countNotOnLine.ToString() + "    ";
            toolStripStatusLabel3.Text = "粉尘仪故障数量：" + countDustError.ToString() + "    ";
            toolStripStatusLabel4.Text = "声级计故障数量：" + countNoiseError.ToString() + "    ";
            toolStripStatusLabel5.Text = "采样泵故障数量：" + countApexError.ToString() + "    ";
            toolStripStatusLabel6.Text = "小型气象站故障数量：" + CountWeatherError.ToString() + "    ";
        }

        /// <summary>
        /// 更新最新数据
        /// </summary>
        private void LatestDataRefresh()
        {
            this.getLatestDataTableAdapter.Fill(this.getLatestDataDataSet.GetLatestData);
            dataGridView_BackColorChange(dataGridView1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            LatestDataRefresh();
            dateTimePicker1.Value = System.DateTime.Today;
            dateTimePicker2.Value = System.DateTime.Now.AddSeconds(0 - System.DateTime.Now.Second).AddMinutes(60 - System.DateTime.Now.Minute);
            radioButton4.Checked = true;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabControl1.TabIndex == 0)
            {
                LatestDataRefresh();
                toolStripStatusLabel1.Text = "数据更新于：" + System.DateTime.Now.ToLongTimeString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndEdit(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beginEdit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EndEdit(true);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            this.deviceUseHistTableAdapter.Fill(this.deviceUseHistDataSet.DeviceUseHist);
            dataGridView2.Columns[0].Visible = false;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            LatestDataRefresh();
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string data = e.FormattedValue.ToString();
            string oldData;
            switch (e.ColumnIndex)
            {
                case 3:
                    oldData = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
                    if ((data.Length > 3) &&　(data.Substring(data.Length - 4) != oldData))
                    {
                        if (MessageBox.Show("MN码与设备编号不匹配，确定这样修改吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                            e.Cancel = true;
                    }
                    break;
                case 4:
                case 5:
                    oldData = "";
                    try
                    {
                        oldData = deviceUseHistDataSet.DeviceUseHist.Rows[e.RowIndex][e.ColumnIndex].ToString();
                    }
                    catch (Exception e1)
                    {
                    }


                    if (oldData != data)
                    {
                        try
                        {
                            MySql.Data.Types.MySqlDateTime aa = new MySql.Data.Types.MySqlDateTime(data);
                            deviceUseHistDataSet.DeviceUseHist.Rows[e.RowIndex][e.ColumnIndex] = aa;
                        }
                        catch (Exception e1)
                        {
                            //deviceUseHistDataSet.DeviceUseHist.Rows[e.RowIndex][e.ColumnIndex] = new MySql.Data.Types.MySqlDateTime();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            beginEdit();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex != 2)
            {
                if (dataGridView2.ReadOnly == false)
                {
                    MessageBox.Show("修改尚未完成，请保存修改或取消修改后再退出！");
                    e.Cancel = true;
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView2.ReadOnly == false)
            {
                MessageBox.Show("修改尚未完成，请保存修改或取消修改后再退出！");
                e.Cancel = true;
            }
        }

        private void QueryData()
        {
            string sqlString = "";
            string whereString = "";

            if (radioButton1.Checked == true)
            {
                whereString = " Where DataTime < '" + dateTimePicker1.Value.ToShortDateString() + " " + dateTimePicker2.Value.ToShortTimeString() + "'";
                if (checkBox2.Checked == false)
                {
                    whereString += " And DeviceID = " + comboBox1.SelectedValue.ToString();
                }
                sqlString = "SELECT * FROM data_minuteNew " + whereString + " ORDER BY DataTime DESC LIMIT " + numericUpDown1.Value.ToString();
            }
            else
            {
                System.DateTime startTime = dateTimePicker1.Value;
                System.DateTime endTime = startTime.AddDays(1);
                if (radioButton4.Checked == true)
                {
                    startTime = startTime.AddHours(dateTimePicker2.Value.Hour);
                    endTime = startTime.AddHours(1);
                }
                whereString = " WHERE InUsing > 0  And DataTime >= '" + startTime.ToString("yyyy-MM-dd hh:mm:ss") + "' And DataTime < '" + endTime.ToString("yyyy-MM-dd hh:mm:ss") + "'";
                

                if (checkBox2.Checked == false)
                    whereString += " And data_minuteNew.DeviceID = " + comboBox1.SelectedValue.ToString();

                sqlString = "SELECT data_minuteNew.DeviceID, DeviceUseHist.Description as '工地名称', COUNT(*) as '总数据', COUNT(IF(Dust>0,1, NULL)) as '粉尘数据', "
                            + "COUNT(IF(Noise>0,1, NULL)) as '噪声数据',COUNT(IF(Humidity>0,1, NULL)) as '气象数据' "
                            + " FROM data_minuteNew Inner Join DeviceUseHist On data_minuteNew.DeviceID = DeviceUseHist.DeviceID "
                            + whereString
                            + " GROUP BY data_minuteNew.DeviceID";
                
            }

            if (sqlString.Length == 0)
                return;

            try
            {
                using (MySqlConnection connPi = new MySqlConnection(serverConnectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connPi);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                    dataGridView3.DataSource = mySourceQueryData;
                    mySourceQueryData.DataSource = table;
                    dataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.deviceUseHistTableAdapter.FillBy(this.deviceUseHistDataSet.DeviceUseHist);
            //comboBox1.Items.Insert(0, "全部设备");
            //comboBox2.Items.Insert(0, "全部工地");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                label2.Visible = true;
                label3.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label4.Visible = false;
                numericUpDown1.Visible = false;
                checkBox2.Checked = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
            }
            else
            {
                label4.Visible = true;
                numericUpDown1.Visible = true;
                dateTimePicker2.Visible = true;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                dateTimePicker2.Visible = false;
            else
                dateTimePicker2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton4.Checked = true;
                dateTimePicker2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LatestDataRefresh();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView_BackColorChange(dataGridView1);

        }

        private void dataGridView2_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            EndEdit(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormInsertProject myForm = new FormInsertProject();
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                this.deviceUseHistTableAdapter.InsertQuery(myForm.ProjID, myForm.DeviceID, myForm.MNCode, 
                    myForm.StartDate, myForm.EndDate, 1, myForm.ProjName);

                this.deviceUseHistTableAdapter.Fill(this.deviceUseHistDataSet.DeviceUseHist);
                dataGridView2.CurrentCell = dataGridView2[1, dataGridView2.Rows.Count - 1];
            }
        }

    }
}
