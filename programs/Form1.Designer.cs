namespace programs
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.刷新 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvsssj = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panlHour = new System.Windows.Forms.Panel();
            this.datehours = new System.Windows.Forms.DateTimePicker();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.query = new System.Windows.Forms.Button();
            this.panelTime = new System.Windows.Forms.Panel();
            this.radTime = new System.Windows.Forms.RadioButton();
            this.radDay = new System.Windows.Forms.RadioButton();
            this.panleData = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.plCondition = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxDeviceCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxAll = new System.Windows.Forms.CheckBox();
            this.rdtjdata = new System.Windows.Forms.RadioButton();
            this.rbssdata = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.insertdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvgjqd = new System.Windows.Forms.DataGridView();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ExportExcels = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsssj)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panlHour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelTime.SuspendLayout();
            this.panleData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.plCondition.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgjqd)).BeginInit();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "是否在线";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 34);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(889, 358);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ExportExcels);
            this.tabPage1.Controls.Add(this.刷新);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgvsssj);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "实时数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // 刷新
            // 
            this.刷新.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.刷新.Location = new System.Drawing.Point(33, 301);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(75, 23);
            this.刷新.TabIndex = 4;
            this.刷新.Text = "刷  新";
            this.刷新.UseVisualStyleBackColor = true;
            this.刷新.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(24, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "刷 新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvsssj
            // 
            this.dgvsssj.AllowUserToAddRows = false;
            this.dgvsssj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsssj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsssj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsssj.Location = new System.Drawing.Point(3, 6);
            this.dgvsssj.MultiSelect = false;
            this.dgvsssj.Name = "dgvsssj";
            this.dgvsssj.ReadOnly = true;
            this.dgvsssj.RowTemplate.Height = 23;
            this.dgvsssj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsssj.Size = new System.Drawing.Size(875, 289);
            this.dgvsssj.TabIndex = 0;
            this.dgvsssj.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvsssj_CellPainting);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panlHour);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.query);
            this.tabPage2.Controls.Add(this.panelTime);
            this.tabPage2.Controls.Add(this.panleData);
            this.tabPage2.Controls.Add(this.DatePicker);
            this.tabPage2.Controls.Add(this.plCondition);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cboxAll);
            this.tabPage2.Controls.Add(this.rdtjdata);
            this.tabPage2.Controls.Add(this.rbssdata);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "统计数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panlHour
            // 
            this.panlHour.Controls.Add(this.datehours);
            this.panlHour.Location = new System.Drawing.Point(289, 2);
            this.panlHour.Name = "panlHour";
            this.panlHour.Size = new System.Drawing.Size(92, 26);
            this.panlHour.TabIndex = 2;
            // 
            // datehours
            // 
            this.datehours.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datehours.Location = new System.Drawing.Point(3, 3);
            this.datehours.Name = "datehours";
            this.datehours.ShowUpDown = true;
            this.datehours.Size = new System.Drawing.Size(83, 21);
            this.datehours.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(13, 65);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(865, 267);
            this.dataGridView3.TabIndex = 10;
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(753, 3);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 9;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.radTime);
            this.panelTime.Controls.Add(this.radDay);
            this.panelTime.Location = new System.Drawing.Point(582, 2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(149, 24);
            this.panelTime.TabIndex = 8;
            // 
            // radTime
            // 
            this.radTime.AutoSize = true;
            this.radTime.Location = new System.Drawing.Point(67, 4);
            this.radTime.Name = "radTime";
            this.radTime.Size = new System.Drawing.Size(59, 16);
            this.radTime.TabIndex = 1;
            this.radTime.TabStop = true;
            this.radTime.Text = "按小时";
            this.radTime.UseVisualStyleBackColor = true;
            this.radTime.CheckedChanged += new System.EventHandler(this.radTime_CheckedChanged_1);
            // 
            // radDay
            // 
            this.radDay.AutoSize = true;
            this.radDay.Location = new System.Drawing.Point(14, 3);
            this.radDay.Name = "radDay";
            this.radDay.Size = new System.Drawing.Size(47, 16);
            this.radDay.TabIndex = 0;
            this.radDay.TabStop = true;
            this.radDay.Text = "按日";
            this.radDay.UseVisualStyleBackColor = true;
            this.radDay.CheckedChanged += new System.EventHandler(this.radDay_CheckedChanged_1);
            // 
            // panleData
            // 
            this.panleData.Controls.Add(this.numericUpDown1);
            this.panleData.Controls.Add(this.label4);
            this.panleData.Location = new System.Drawing.Point(403, 3);
            this.panleData.Name = "panleData";
            this.panleData.Size = new System.Drawing.Size(173, 24);
            this.panleData.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "最大数据：";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(134, 3);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(134, 21);
            this.DatePicker.TabIndex = 5;
            // 
            // plCondition
            // 
            this.plCondition.Controls.Add(this.comboBox1);
            this.plCondition.Controls.Add(this.label3);
            this.plCondition.Controls.Add(this.cBoxDeviceCode);
            this.plCondition.Controls.Add(this.label2);
            this.plCondition.Location = new System.Drawing.Point(179, 28);
            this.plCondition.Name = "plCondition";
            this.plCondition.Size = new System.Drawing.Size(646, 25);
            this.plCondition.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(283, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "工地名称：";
            // 
            // cBoxDeviceCode
            // 
            this.cBoxDeviceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDeviceCode.FormattingEnabled = true;
            this.cBoxDeviceCode.Location = new System.Drawing.Point(60, 5);
            this.cBoxDeviceCode.Name = "cBoxDeviceCode";
            this.cBoxDeviceCode.Size = new System.Drawing.Size(121, 20);
            this.cBoxDeviceCode.TabIndex = 5;
            this.cBoxDeviceCode.SelectedIndexChanged += new System.EventHandler(this.cBoxDeviceCode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设备编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "时间：";
            // 
            // cboxAll
            // 
            this.cboxAll.AutoSize = true;
            this.cboxAll.Location = new System.Drawing.Point(101, 35);
            this.cboxAll.Name = "cboxAll";
            this.cboxAll.Size = new System.Drawing.Size(72, 16);
            this.cboxAll.TabIndex = 2;
            this.cboxAll.Text = "所有设备";
            this.cboxAll.UseVisualStyleBackColor = true;
            this.cboxAll.CheckedChanged += new System.EventHandler(this.cboxAll_CheckedChanged);
            // 
            // rdtjdata
            // 
            this.rdtjdata.AutoSize = true;
            this.rdtjdata.Location = new System.Drawing.Point(6, 34);
            this.rdtjdata.Name = "rdtjdata";
            this.rdtjdata.Size = new System.Drawing.Size(71, 16);
            this.rdtjdata.TabIndex = 1;
            this.rdtjdata.Text = "统计数据";
            this.rdtjdata.UseVisualStyleBackColor = true;
            this.rdtjdata.CheckedChanged += new System.EventHandler(this.rdtjdata_CheckedChanged);
            // 
            // rbssdata
            // 
            this.rbssdata.AutoSize = true;
            this.rbssdata.Checked = true;
            this.rbssdata.Location = new System.Drawing.Point(6, 6);
            this.rbssdata.Name = "rbssdata";
            this.rbssdata.Size = new System.Drawing.Size(71, 16);
            this.rbssdata.TabIndex = 0;
            this.rbssdata.TabStop = true;
            this.rbssdata.Text = "实时数据";
            this.rbssdata.UseVisualStyleBackColor = true;
            this.rbssdata.CheckedChanged += new System.EventHandler(this.rbssdata_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.insertdate);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dgvgjqd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(881, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "工地清单";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.Location = new System.Drawing.Point(326, 306);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "保存修改";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(175, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "增加数据";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.insertdate_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(21, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "修改数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Location = new System.Drawing.Point(310, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "取消修改";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(229, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "保存修改";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // insertdate
            // 
            this.insertdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertdate.Location = new System.Drawing.Point(148, 401);
            this.insertdate.Name = "insertdate";
            this.insertdate.Size = new System.Drawing.Size(75, 23);
            this.insertdate.TabIndex = 2;
            this.insertdate.Text = "增加数据";
            this.insertdate.UseVisualStyleBackColor = true;
            this.insertdate.Click += new System.EventHandler(this.insertdate_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(67, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "修改数据";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvgjqd
            // 
            this.dgvgjqd.AllowUserToAddRows = false;
            this.dgvgjqd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvgjqd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgjqd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgjqd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvgjqd.Location = new System.Drawing.Point(4, 3);
            this.dgvgjqd.MultiSelect = false;
            this.dgvgjqd.Name = "dgvgjqd";
            this.dgvgjqd.ReadOnly = true;
            this.dgvgjqd.RowTemplate.Height = 23;
            this.dgvgjqd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvgjqd.Size = new System.Drawing.Size(881, 300);
            this.dgvgjqd.TabIndex = 0;
            this.dgvgjqd.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dgvgjqd_CancelRowEdit);
            this.dgvgjqd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgjqd_CellContentClick);
            this.dgvgjqd.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgjqd_CellEndEdit);
            this.dgvgjqd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgjqd_CellValueChanged);
            this.dgvgjqd.DoubleClick += new System.EventHandler(this.dgvgjqd_DoubleClick);
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(913, 13);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 391);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(913, 38);
            this.toolStripContainer2.TabIndex = 3;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(31, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(396, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel3.Text = "toolStripLabel3";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(96, 17);
            this.toolStripLabel4.Text = "toolStripLabel4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExportExcels
            // 
            this.ExportExcels.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExportExcels.Location = new System.Drawing.Point(146, 301);
            this.ExportExcels.Name = "ExportExcels";
            this.ExportExcels.Size = new System.Drawing.Size(75, 23);
            this.ExportExcels.TabIndex = 4;
            this.ExportExcels.Text = "导出excel";
            this.ExportExcels.UseVisualStyleBackColor = true;
            this.ExportExcels.Click += new System.EventHandler(this.ExportExcels_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(822, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 429);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsssj)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panlHour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panleData.ResumeLayout(false);
            this.panleData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.plCondition.ResumeLayout(false);
            this.plCondition.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgjqd)).EndInit();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvsssj;
        private System.Windows.Forms.RadioButton rbssdata;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvgjqd;
        private System.Windows.Forms.RadioButton rdtjdata;
        private System.Windows.Forms.CheckBox cboxAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxDeviceCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Panel panleData;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.RadioButton radDay;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button insertdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panlHour;
        private System.Windows.Forms.RadioButton radTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker datehours;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button 刷新;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ExportExcels;
        private System.Windows.Forms.Button button7;
    }
}

