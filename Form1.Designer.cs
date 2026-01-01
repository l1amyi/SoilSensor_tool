namespace SoilSensorTool
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
            deviceInfo = new GroupBox();
            textBetteryLevel = new TextBox();
            textSensorNum = new TextBox();
            textSerialNumber = new TextBox();
            textVersion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btSetDevInfo = new Button();
            btQueryDevInfo = new Button();
            btRestart = new Button();
            btDevReset = new Button();
            groupBox1 = new GroupBox();
            comboBoxDevAdd = new ComboBox();
            connect_button = new Button();
            com = new ComboBox();
            label1 = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            btClearSensorData = new Button();
            btClearTableData = new Button();
            dataGridViewSensor = new DataGridView();
            datetime = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            tempture = new DataGridViewTextBoxColumn();
            humidity = new DataGridViewTextBoxColumn();
            conductivity = new DataGridViewTextBoxColumn();
            btExportData = new Button();
            btQueryAllData = new Button();
            btQuerySensorData = new Button();
            textRecordCount = new TextBox();
            textStartTime = new TextBox();
            btQueryStartTimeCount = new Button();
            comboboxSensorIdx = new ComboBox();
            label6 = new Label();
            btSetTimeIntval = new Button();
            textTimeIntval = new TextBox();
            btRequestTimeIntval = new Button();
            lbRtc = new Label();
            lbCurrentTime = new Label();
            btSetRtc = new Button();
            btRequestRtc = new Button();
            tabPage2 = new TabPage();
            textBoxTime10 = new TextBox();
            textBoxTime9 = new TextBox();
            textBoxTime8 = new TextBox();
            textBoxTime7 = new TextBox();
            textBoxTime5 = new TextBox();
            textBoxTime4 = new TextBox();
            textBoxTime3 = new TextBox();
            textBoxTime2 = new TextBox();
            textBoxTime6 = new TextBox();
            label24 = new Label();
            textBoxTime1 = new TextBox();
            label23 = new Label();
            textBoxConductivity10 = new TextBox();
            textBoxHumidity10 = new TextBox();
            textBoxTemp10 = new TextBox();
            label15 = new Label();
            textBoxConductivity9 = new TextBox();
            textBoxHumidity9 = new TextBox();
            textBoxTemp9 = new TextBox();
            label16 = new Label();
            textBoxConductivity8 = new TextBox();
            textBoxHumidity8 = new TextBox();
            textBoxTemp8 = new TextBox();
            label17 = new Label();
            textBoxConductivity7 = new TextBox();
            textBoxHumidity7 = new TextBox();
            textBoxTemp7 = new TextBox();
            label18 = new Label();
            textBoxConductivity6 = new TextBox();
            textBoxHumidity6 = new TextBox();
            textBoxTemp6 = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            textBoxConductivity5 = new TextBox();
            textBoxHumidity5 = new TextBox();
            textBoxTemp5 = new TextBox();
            label14 = new Label();
            textBoxConductivity4 = new TextBox();
            textBoxHumidity4 = new TextBox();
            textBoxTemp4 = new TextBox();
            label13 = new Label();
            textBoxConductivity3 = new TextBox();
            textBoxHumidity3 = new TextBox();
            textBoxTemp3 = new TextBox();
            label12 = new Label();
            textBoxConductivity2 = new TextBox();
            textBoxHumidity2 = new TextBox();
            textBoxTemp2 = new TextBox();
            label11 = new Label();
            textBoxConductivity1 = new TextBox();
            textBoxHumidity1 = new TextBox();
            textBoxTemp1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btQueryRealTimeData = new Button();
            label7 = new Label();
            tabPage3 = new TabPage();
            comboBoxSensorModel10 = new ComboBox();
            comboBoxSensorModel9 = new ComboBox();
            comboBoxSensorModel8 = new ComboBox();
            comboBoxSensorModel7 = new ComboBox();
            comboBoxSensorModel6 = new ComboBox();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            comboBoxSensorModel5 = new ComboBox();
            comboBoxSensorModel4 = new ComboBox();
            comboBoxSensorModel3 = new ComboBox();
            comboBoxSensorModel2 = new ComboBox();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            comboBoxSensorModel1 = new ComboBox();
            btSetSensorModel = new Button();
            btQuerySensorModel = new Button();
            tabPage4 = new TabPage();
            stopUpgradeBt = new Button();
            upgradeFileNameLb = new Label();
            upgradeProgressBar = new ProgressBar();
            startUpgradeBt = new Button();
            openUpgradeFileBt = new Button();
            Onenet = new TabPage();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            productKeyTextBox = new TextBox();
            deviceNameTextBox = new TextBox();
            productIdTextBox = new TextBox();
            setOnenetBt = new Button();
            queryOnenetBt = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            textBoxLog = new TextBox();
            btSaveLog = new Button();
            btClearLog = new Button();
            deviceInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSensor).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            Onenet.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // deviceInfo
            // 
            deviceInfo.Controls.Add(textBetteryLevel);
            deviceInfo.Controls.Add(textSensorNum);
            deviceInfo.Controls.Add(textSerialNumber);
            deviceInfo.Controls.Add(textVersion);
            deviceInfo.Controls.Add(label5);
            deviceInfo.Controls.Add(label4);
            deviceInfo.Controls.Add(label3);
            deviceInfo.Controls.Add(label2);
            deviceInfo.Controls.Add(btSetDevInfo);
            deviceInfo.Controls.Add(btQueryDevInfo);
            deviceInfo.Controls.Add(btRestart);
            deviceInfo.Controls.Add(btDevReset);
            deviceInfo.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            deviceInfo.Location = new Point(24, 22);
            deviceInfo.Margin = new Padding(2);
            deviceInfo.Name = "deviceInfo";
            deviceInfo.Padding = new Padding(2);
            deviceInfo.Size = new Size(646, 222);
            deviceInfo.TabIndex = 1;
            deviceInfo.TabStop = false;
            deviceInfo.Text = "设备信息";
            // 
            // textBetteryLevel
            // 
            textBetteryLevel.Location = new Point(342, 181);
            textBetteryLevel.Margin = new Padding(2);
            textBetteryLevel.Name = "textBetteryLevel";
            textBetteryLevel.Size = new Size(202, 30);
            textBetteryLevel.TabIndex = 12;
            // 
            // textSensorNum
            // 
            textSensorNum.Location = new Point(342, 148);
            textSensorNum.Margin = new Padding(2);
            textSensorNum.Name = "textSensorNum";
            textSensorNum.Size = new Size(202, 30);
            textSensorNum.TabIndex = 11;
            // 
            // textSerialNumber
            // 
            textSerialNumber.Location = new Point(342, 115);
            textSerialNumber.Margin = new Padding(2);
            textSerialNumber.Name = "textSerialNumber";
            textSerialNumber.Size = new Size(202, 30);
            textSerialNumber.TabIndex = 10;
            // 
            // textVersion
            // 
            textVersion.Location = new Point(342, 82);
            textVersion.Margin = new Padding(2);
            textVersion.Name = "textVersion";
            textVersion.Size = new Size(202, 30);
            textVersion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 191);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 8;
            label5.Text = "电池电量：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 158);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 7;
            label4.Text = "传感器数量：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 6;
            label3.Text = "序列号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "版本号：";
            // 
            // btSetDevInfo
            // 
            btSetDevInfo.Location = new Point(390, 28);
            btSetDevInfo.Margin = new Padding(2);
            btSetDevInfo.Name = "btSetDevInfo";
            btSetDevInfo.Size = new Size(154, 40);
            btSetDevInfo.TabIndex = 4;
            btSetDevInfo.Text = "设置设备信息";
            btSetDevInfo.UseVisualStyleBackColor = true;
            btSetDevInfo.Click += btSetDevInfo_Click;
            // 
            // btQueryDevInfo
            // 
            btQueryDevInfo.Location = new Point(187, 28);
            btQueryDevInfo.Margin = new Padding(2);
            btQueryDevInfo.Name = "btQueryDevInfo";
            btQueryDevInfo.Size = new Size(178, 40);
            btQueryDevInfo.TabIndex = 3;
            btQueryDevInfo.Text = "查询设备信息";
            btQueryDevInfo.UseVisualStyleBackColor = true;
            btQueryDevInfo.Click += btQueryDevInfo_Click;
            // 
            // btRestart
            // 
            btRestart.Location = new Point(18, 158);
            btRestart.Margin = new Padding(2);
            btRestart.Name = "btRestart";
            btRestart.Size = new Size(150, 38);
            btRestart.TabIndex = 1;
            btRestart.Text = "重新开始采集";
            btRestart.UseVisualStyleBackColor = true;
            btRestart.Click += btRestart_Click;
            // 
            // btDevReset
            // 
            btDevReset.Location = new Point(18, 82);
            btDevReset.Margin = new Padding(2);
            btDevReset.Name = "btDevReset";
            btDevReset.Size = new Size(150, 40);
            btDevReset.TabIndex = 0;
            btDevReset.Text = "恢复出厂设置";
            btDevReset.UseVisualStyleBackColor = true;
            btDevReset.Click += btDevReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxDevAdd);
            groupBox1.Controls.Add(connect_button);
            groupBox1.Controls.Add(com);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(674, 22);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(583, 222);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "系统设置";
            // 
            // comboBoxDevAdd
            // 
            comboBoxDevAdd.FormattingEnabled = true;
            comboBoxDevAdd.Location = new Point(244, 137);
            comboBoxDevAdd.Margin = new Padding(2);
            comboBoxDevAdd.Name = "comboBoxDevAdd";
            comboBoxDevAdd.Size = new Size(140, 28);
            comboBoxDevAdd.TabIndex = 3;
            // 
            // connect_button
            // 
            connect_button.Location = new Point(30, 120);
            connect_button.Margin = new Padding(2);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(180, 56);
            connect_button.TabIndex = 2;
            connect_button.Text = "连接端口";
            connect_button.UseVisualStyleBackColor = true;
            connect_button.Click += connect_button_Click;
            // 
            // com
            // 
            com.FormattingEnabled = true;
            com.Location = new Point(244, 65);
            com.Margin = new Padding(2);
            com.Name = "com";
            com.Size = new Size(140, 28);
            com.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "选择端口：";
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Left;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(Onenet);
            tabControl.ItemSize = new Size(12, 42);
            tabControl.Location = new Point(25, 248);
            tabControl.Margin = new Padding(2);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1232, 429);
            tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Linen;
            tabPage1.Controls.Add(btClearSensorData);
            tabPage1.Controls.Add(btClearTableData);
            tabPage1.Controls.Add(dataGridViewSensor);
            tabPage1.Controls.Add(btExportData);
            tabPage1.Controls.Add(btQueryAllData);
            tabPage1.Controls.Add(btQuerySensorData);
            tabPage1.Controls.Add(textRecordCount);
            tabPage1.Controls.Add(textStartTime);
            tabPage1.Controls.Add(btQueryStartTimeCount);
            tabPage1.Controls.Add(comboboxSensorIdx);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btSetTimeIntval);
            tabPage1.Controls.Add(textTimeIntval);
            tabPage1.Controls.Add(btRequestTimeIntval);
            tabPage1.Controls.Add(lbRtc);
            tabPage1.Controls.Add(lbCurrentTime);
            tabPage1.Controls.Add(btSetRtc);
            tabPage1.Controls.Add(btRequestRtc);
            tabPage1.Location = new Point(46, 4);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1182, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "基本信息";
            // 
            // btClearSensorData
            // 
            btClearSensorData.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btClearSensorData.Location = new Point(313, 316);
            btClearSensorData.Name = "btClearSensorData";
            btClearSensorData.Size = new Size(169, 35);
            btClearSensorData.TabIndex = 26;
            btClearSensorData.Text = "清除传感器数据";
            btClearSensorData.UseVisualStyleBackColor = true;
            btClearSensorData.Click += btClearSensorData_Click;
            // 
            // btClearTableData
            // 
            btClearTableData.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btClearTableData.Location = new Point(158, 316);
            btClearTableData.Name = "btClearTableData";
            btClearTableData.Size = new Size(144, 35);
            btClearTableData.TabIndex = 25;
            btClearTableData.Text = "清除表格数据";
            btClearTableData.UseVisualStyleBackColor = true;
            btClearTableData.Click += btClearTableData_Click;
            // 
            // dataGridViewSensor
            // 
            dataGridViewSensor.AllowUserToOrderColumns = true;
            dataGridViewSensor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSensor.Columns.AddRange(new DataGridViewColumn[] { datetime, id, tempture, humidity, conductivity });
            dataGridViewSensor.Dock = DockStyle.Right;
            dataGridViewSensor.Location = new Point(603, 2);
            dataGridViewSensor.Name = "dataGridViewSensor";
            dataGridViewSensor.RowHeadersWidth = 51;
            dataGridViewSensor.RowTemplate.Height = 27;
            dataGridViewSensor.Size = new Size(577, 417);
            dataGridViewSensor.TabIndex = 24;
            // 
            // datetime
            // 
            datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datetime.HeaderText = "日期时间";
            datetime.MinimumWidth = 6;
            datetime.Name = "datetime";
            datetime.Width = 88;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "传感器序号";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 105;
            // 
            // tempture
            // 
            tempture.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tempture.HeaderText = "温度（°C）";
            tempture.MinimumWidth = 6;
            tempture.Name = "tempture";
            tempture.Width = 105;
            // 
            // humidity
            // 
            humidity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            humidity.HeaderText = "湿度（%）";
            humidity.MinimumWidth = 6;
            humidity.Name = "humidity";
            humidity.Width = 97;
            // 
            // conductivity
            // 
            conductivity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            conductivity.HeaderText = "导电率（μS/cm）";
            conductivity.MinimumWidth = 6;
            conductivity.Name = "conductivity";
            conductivity.Width = 122;
            // 
            // btExportData
            // 
            btExportData.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btExportData.Location = new Point(4, 316);
            btExportData.Margin = new Padding(2);
            btExportData.Name = "btExportData";
            btExportData.Size = new Size(142, 35);
            btExportData.TabIndex = 23;
            btExportData.Text = "导出数据";
            btExportData.UseVisualStyleBackColor = true;
            btExportData.Click += btExportData_Click;
            // 
            // btQueryAllData
            // 
            btQueryAllData.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btQueryAllData.Location = new Point(260, 264);
            btQueryAllData.Margin = new Padding(2);
            btQueryAllData.Name = "btQueryAllData";
            btQueryAllData.Size = new Size(225, 35);
            btQueryAllData.TabIndex = 22;
            btQueryAllData.Text = "查询全部传感器数据";
            btQueryAllData.UseVisualStyleBackColor = true;
            btQueryAllData.Click += btQueryAllData_Click;
            // 
            // btQuerySensorData
            // 
            btQuerySensorData.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btQuerySensorData.Location = new Point(4, 264);
            btQuerySensorData.Margin = new Padding(2);
            btQuerySensorData.Name = "btQuerySensorData";
            btQuerySensorData.Size = new Size(248, 35);
            btQuerySensorData.TabIndex = 21;
            btQuerySensorData.Text = "查询传感器数据";
            btQuerySensorData.UseVisualStyleBackColor = true;
            btQuerySensorData.Click += btQuerySensorData_Click;
            // 
            // textRecordCount
            // 
            textRecordCount.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textRecordCount.Location = new Point(414, 211);
            textRecordCount.Margin = new Padding(2);
            textRecordCount.Name = "textRecordCount";
            textRecordCount.Size = new Size(68, 30);
            textRecordCount.TabIndex = 19;
            // 
            // textStartTime
            // 
            textStartTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textStartTime.Location = new Point(260, 211);
            textStartTime.Margin = new Padding(2);
            textStartTime.Name = "textStartTime";
            textStartTime.Size = new Size(150, 30);
            textStartTime.TabIndex = 18;
            // 
            // btQueryStartTimeCount
            // 
            btQueryStartTimeCount.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btQueryStartTimeCount.Location = new Point(4, 211);
            btQueryStartTimeCount.Margin = new Padding(2);
            btQueryStartTimeCount.Name = "btQueryStartTimeCount";
            btQueryStartTimeCount.Size = new Size(248, 35);
            btQueryStartTimeCount.TabIndex = 17;
            btQueryStartTimeCount.Text = "请求采集开始时间和总数";
            btQueryStartTimeCount.UseVisualStyleBackColor = true;
            btQueryStartTimeCount.Click += btQueryStartTimeCount_Click;
            // 
            // comboboxSensorIdx
            // 
            comboboxSensorIdx.FormattingEnabled = true;
            comboboxSensorIdx.Location = new Point(131, 175);
            comboboxSensorIdx.Name = "comboboxSensorIdx";
            comboboxSensorIdx.Size = new Size(121, 26);
            comboboxSensorIdx.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(1, 176);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 15;
            label6.Text = "传感器序号：";
            // 
            // btSetTimeIntval
            // 
            btSetTimeIntval.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btSetTimeIntval.Location = new Point(292, 121);
            btSetTimeIntval.Margin = new Padding(2);
            btSetTimeIntval.Name = "btSetTimeIntval";
            btSetTimeIntval.Size = new Size(193, 35);
            btSetTimeIntval.TabIndex = 14;
            btSetTimeIntval.Text = "设置采集间隔时间";
            btSetTimeIntval.UseVisualStyleBackColor = true;
            btSetTimeIntval.Click += btSetTimeIntval_Click;
            // 
            // textTimeIntval
            // 
            textTimeIntval.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textTimeIntval.Location = new Point(202, 121);
            textTimeIntval.Margin = new Padding(2);
            textTimeIntval.Name = "textTimeIntval";
            textTimeIntval.Size = new Size(86, 30);
            textTimeIntval.TabIndex = 13;
            // 
            // btRequestTimeIntval
            // 
            btRequestTimeIntval.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btRequestTimeIntval.Location = new Point(4, 121);
            btRequestTimeIntval.Margin = new Padding(2);
            btRequestTimeIntval.Name = "btRequestTimeIntval";
            btRequestTimeIntval.Size = new Size(194, 35);
            btRequestTimeIntval.TabIndex = 5;
            btRequestTimeIntval.Text = "请求采集间隔时间";
            btRequestTimeIntval.UseVisualStyleBackColor = true;
            btRequestTimeIntval.Click += btRequestTimeIntval_Click;
            // 
            // lbRtc
            // 
            lbRtc.AutoSize = true;
            lbRtc.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbRtc.Location = new Point(186, 30);
            lbRtc.Margin = new Padding(2, 0, 2, 0);
            lbRtc.Name = "lbRtc";
            lbRtc.Size = new Size(299, 20);
            lbRtc.TabIndex = 4;
            lbRtc.Text = "000000000 1970-01-01 00:00:00";
            // 
            // lbCurrentTime
            // 
            lbCurrentTime.AutoSize = true;
            lbCurrentTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbCurrentTime.Location = new Point(186, 78);
            lbCurrentTime.Margin = new Padding(2, 0, 2, 0);
            lbCurrentTime.Name = "lbCurrentTime";
            lbCurrentTime.Size = new Size(299, 20);
            lbCurrentTime.TabIndex = 3;
            lbCurrentTime.Text = "000000000 1971-01-01 00:00:00";
            // 
            // btSetRtc
            // 
            btSetRtc.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btSetRtc.Location = new Point(5, 71);
            btSetRtc.Margin = new Padding(2);
            btSetRtc.Name = "btSetRtc";
            btSetRtc.Size = new Size(134, 35);
            btSetRtc.TabIndex = 2;
            btSetRtc.Text = "设置RTC时间";
            btSetRtc.UseVisualStyleBackColor = true;
            btSetRtc.Click += btSetRtc_Click;
            // 
            // btRequestRtc
            // 
            btRequestRtc.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btRequestRtc.Location = new Point(5, 23);
            btRequestRtc.Margin = new Padding(2);
            btRequestRtc.Name = "btRequestRtc";
            btRequestRtc.Size = new Size(134, 35);
            btRequestRtc.TabIndex = 0;
            btRequestRtc.Text = "请求RTC时间";
            btRequestRtc.UseVisualStyleBackColor = true;
            btRequestRtc.Click += btRequestRtc_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Linen;
            tabPage2.Controls.Add(textBoxTime10);
            tabPage2.Controls.Add(textBoxTime9);
            tabPage2.Controls.Add(textBoxTime8);
            tabPage2.Controls.Add(textBoxTime7);
            tabPage2.Controls.Add(textBoxTime5);
            tabPage2.Controls.Add(textBoxTime4);
            tabPage2.Controls.Add(textBoxTime3);
            tabPage2.Controls.Add(textBoxTime2);
            tabPage2.Controls.Add(textBoxTime6);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(textBoxTime1);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(textBoxConductivity10);
            tabPage2.Controls.Add(textBoxHumidity10);
            tabPage2.Controls.Add(textBoxTemp10);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBoxConductivity9);
            tabPage2.Controls.Add(textBoxHumidity9);
            tabPage2.Controls.Add(textBoxTemp9);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(textBoxConductivity8);
            tabPage2.Controls.Add(textBoxHumidity8);
            tabPage2.Controls.Add(textBoxTemp8);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(textBoxConductivity7);
            tabPage2.Controls.Add(textBoxHumidity7);
            tabPage2.Controls.Add(textBoxTemp7);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(textBoxConductivity6);
            tabPage2.Controls.Add(textBoxHumidity6);
            tabPage2.Controls.Add(textBoxTemp6);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(textBoxConductivity5);
            tabPage2.Controls.Add(textBoxHumidity5);
            tabPage2.Controls.Add(textBoxTemp5);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBoxConductivity4);
            tabPage2.Controls.Add(textBoxHumidity4);
            tabPage2.Controls.Add(textBoxTemp4);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBoxConductivity3);
            tabPage2.Controls.Add(textBoxHumidity3);
            tabPage2.Controls.Add(textBoxTemp3);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBoxConductivity2);
            tabPage2.Controls.Add(textBoxHumidity2);
            tabPage2.Controls.Add(textBoxTemp2);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBoxConductivity1);
            tabPage2.Controls.Add(textBoxHumidity1);
            tabPage2.Controls.Add(textBoxTemp1);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(btQueryRealTimeData);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(46, 4);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1182, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "实时数据";
            // 
            // textBoxTime10
            // 
            textBoxTime10.Location = new Point(628, 312);
            textBoxTime10.Name = "textBoxTime10";
            textBoxTime10.Size = new Size(176, 28);
            textBoxTime10.TabIndex = 58;
            // 
            // textBoxTime9
            // 
            textBoxTime9.Location = new Point(628, 264);
            textBoxTime9.Name = "textBoxTime9";
            textBoxTime9.Size = new Size(176, 28);
            textBoxTime9.TabIndex = 57;
            // 
            // textBoxTime8
            // 
            textBoxTime8.Location = new Point(628, 216);
            textBoxTime8.Name = "textBoxTime8";
            textBoxTime8.Size = new Size(176, 28);
            textBoxTime8.TabIndex = 56;
            // 
            // textBoxTime7
            // 
            textBoxTime7.Location = new Point(628, 168);
            textBoxTime7.Name = "textBoxTime7";
            textBoxTime7.Size = new Size(176, 28);
            textBoxTime7.TabIndex = 55;
            // 
            // textBoxTime5
            // 
            textBoxTime5.Location = new Point(100, 314);
            textBoxTime5.Name = "textBoxTime5";
            textBoxTime5.Size = new Size(176, 28);
            textBoxTime5.TabIndex = 54;
            // 
            // textBoxTime4
            // 
            textBoxTime4.Location = new Point(100, 265);
            textBoxTime4.Name = "textBoxTime4";
            textBoxTime4.Size = new Size(176, 28);
            textBoxTime4.TabIndex = 53;
            // 
            // textBoxTime3
            // 
            textBoxTime3.Location = new Point(100, 216);
            textBoxTime3.Name = "textBoxTime3";
            textBoxTime3.Size = new Size(176, 28);
            textBoxTime3.TabIndex = 52;
            // 
            // textBoxTime2
            // 
            textBoxTime2.Location = new Point(100, 167);
            textBoxTime2.Name = "textBoxTime2";
            textBoxTime2.Size = new Size(176, 28);
            textBoxTime2.TabIndex = 51;
            // 
            // textBoxTime6
            // 
            textBoxTime6.Location = new Point(628, 120);
            textBoxTime6.Name = "textBoxTime6";
            textBoxTime6.Size = new Size(176, 28);
            textBoxTime6.TabIndex = 50;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label24.Location = new Point(684, 85);
            label24.Name = "label24";
            label24.Size = new Size(60, 24);
            label24.TabIndex = 49;
            label24.Text = "时间";
            // 
            // textBoxTime1
            // 
            textBoxTime1.Location = new Point(100, 120);
            textBoxTime1.Name = "textBoxTime1";
            textBoxTime1.Size = new Size(176, 28);
            textBoxTime1.TabIndex = 48;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label23.Location = new Point(154, 85);
            label23.Name = "label23";
            label23.Size = new Size(60, 24);
            label23.TabIndex = 47;
            label23.Text = "时间";
            // 
            // textBoxConductivity10
            // 
            textBoxConductivity10.Location = new Point(946, 312);
            textBoxConductivity10.Name = "textBoxConductivity10";
            textBoxConductivity10.Size = new Size(54, 28);
            textBoxConductivity10.TabIndex = 46;
            // 
            // textBoxHumidity10
            // 
            textBoxHumidity10.Location = new Point(880, 312);
            textBoxHumidity10.Name = "textBoxHumidity10";
            textBoxHumidity10.Size = new Size(54, 28);
            textBoxHumidity10.TabIndex = 45;
            // 
            // textBoxTemp10
            // 
            textBoxTemp10.Location = new Point(814, 312);
            textBoxTemp10.Name = "textBoxTemp10";
            textBoxTemp10.Size = new Size(54, 28);
            textBoxTemp10.TabIndex = 44;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label15.Location = new Point(529, 314);
            label15.Name = "label15";
            label15.Size = new Size(92, 22);
            label15.TabIndex = 43;
            label15.Text = "10#通道";
            // 
            // textBoxConductivity9
            // 
            textBoxConductivity9.Location = new Point(946, 264);
            textBoxConductivity9.Name = "textBoxConductivity9";
            textBoxConductivity9.Size = new Size(54, 28);
            textBoxConductivity9.TabIndex = 42;
            // 
            // textBoxHumidity9
            // 
            textBoxHumidity9.Location = new Point(880, 264);
            textBoxHumidity9.Name = "textBoxHumidity9";
            textBoxHumidity9.Size = new Size(54, 28);
            textBoxHumidity9.TabIndex = 41;
            // 
            // textBoxTemp9
            // 
            textBoxTemp9.Location = new Point(814, 264);
            textBoxTemp9.Name = "textBoxTemp9";
            textBoxTemp9.Size = new Size(54, 28);
            textBoxTemp9.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label16.Location = new Point(542, 268);
            label16.Name = "label16";
            label16.Size = new Size(80, 22);
            label16.TabIndex = 39;
            label16.Text = "9#通道";
            // 
            // textBoxConductivity8
            // 
            textBoxConductivity8.Location = new Point(946, 216);
            textBoxConductivity8.Name = "textBoxConductivity8";
            textBoxConductivity8.Size = new Size(54, 28);
            textBoxConductivity8.TabIndex = 38;
            // 
            // textBoxHumidity8
            // 
            textBoxHumidity8.Location = new Point(880, 216);
            textBoxHumidity8.Name = "textBoxHumidity8";
            textBoxHumidity8.Size = new Size(54, 28);
            textBoxHumidity8.TabIndex = 37;
            // 
            // textBoxTemp8
            // 
            textBoxTemp8.Location = new Point(814, 216);
            textBoxTemp8.Name = "textBoxTemp8";
            textBoxTemp8.Size = new Size(54, 28);
            textBoxTemp8.TabIndex = 36;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label17.Location = new Point(542, 220);
            label17.Name = "label17";
            label17.Size = new Size(80, 22);
            label17.TabIndex = 35;
            label17.Text = "8#通道";
            // 
            // textBoxConductivity7
            // 
            textBoxConductivity7.Location = new Point(946, 168);
            textBoxConductivity7.Name = "textBoxConductivity7";
            textBoxConductivity7.Size = new Size(54, 28);
            textBoxConductivity7.TabIndex = 34;
            // 
            // textBoxHumidity7
            // 
            textBoxHumidity7.Location = new Point(880, 168);
            textBoxHumidity7.Name = "textBoxHumidity7";
            textBoxHumidity7.Size = new Size(54, 28);
            textBoxHumidity7.TabIndex = 33;
            // 
            // textBoxTemp7
            // 
            textBoxTemp7.Location = new Point(814, 168);
            textBoxTemp7.Name = "textBoxTemp7";
            textBoxTemp7.Size = new Size(54, 28);
            textBoxTemp7.TabIndex = 32;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label18.Location = new Point(542, 172);
            label18.Name = "label18";
            label18.Size = new Size(80, 22);
            label18.TabIndex = 31;
            label18.Text = "7#通道";
            // 
            // textBoxConductivity6
            // 
            textBoxConductivity6.Location = new Point(946, 120);
            textBoxConductivity6.Name = "textBoxConductivity6";
            textBoxConductivity6.Size = new Size(54, 28);
            textBoxConductivity6.TabIndex = 30;
            // 
            // textBoxHumidity6
            // 
            textBoxHumidity6.Location = new Point(880, 120);
            textBoxHumidity6.Name = "textBoxHumidity6";
            textBoxHumidity6.Size = new Size(54, 28);
            textBoxHumidity6.TabIndex = 29;
            // 
            // textBoxTemp6
            // 
            textBoxTemp6.Location = new Point(814, 120);
            textBoxTemp6.Name = "textBoxTemp6";
            textBoxTemp6.Size = new Size(54, 28);
            textBoxTemp6.TabIndex = 28;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label19.Location = new Point(928, 85);
            label19.Name = "label19";
            label19.Size = new Size(85, 24);
            label19.TabIndex = 27;
            label19.Text = "导电率";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label20.Location = new Point(875, 85);
            label20.Name = "label20";
            label20.Size = new Size(60, 24);
            label20.TabIndex = 26;
            label20.Text = "湿度";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label21.Location = new Point(810, 85);
            label21.Name = "label21";
            label21.Size = new Size(60, 24);
            label21.TabIndex = 25;
            label21.Text = "温度";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label22.Location = new Point(542, 124);
            label22.Name = "label22";
            label22.Size = new Size(80, 22);
            label22.TabIndex = 24;
            label22.Text = "6#通道";
            // 
            // textBoxConductivity5
            // 
            textBoxConductivity5.Location = new Point(425, 314);
            textBoxConductivity5.Name = "textBoxConductivity5";
            textBoxConductivity5.Size = new Size(54, 28);
            textBoxConductivity5.TabIndex = 23;
            // 
            // textBoxHumidity5
            // 
            textBoxHumidity5.Location = new Point(351, 314);
            textBoxHumidity5.Name = "textBoxHumidity5";
            textBoxHumidity5.Size = new Size(54, 28);
            textBoxHumidity5.TabIndex = 22;
            // 
            // textBoxTemp5
            // 
            textBoxTemp5.Location = new Point(284, 314);
            textBoxTemp5.Name = "textBoxTemp5";
            textBoxTemp5.Size = new Size(54, 28);
            textBoxTemp5.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label14.Location = new Point(14, 318);
            label14.Name = "label14";
            label14.Size = new Size(80, 22);
            label14.TabIndex = 20;
            label14.Text = "5#通道";
            // 
            // textBoxConductivity4
            // 
            textBoxConductivity4.Location = new Point(425, 266);
            textBoxConductivity4.Name = "textBoxConductivity4";
            textBoxConductivity4.Size = new Size(54, 28);
            textBoxConductivity4.TabIndex = 19;
            // 
            // textBoxHumidity4
            // 
            textBoxHumidity4.Location = new Point(351, 266);
            textBoxHumidity4.Name = "textBoxHumidity4";
            textBoxHumidity4.Size = new Size(54, 28);
            textBoxHumidity4.TabIndex = 18;
            // 
            // textBoxTemp4
            // 
            textBoxTemp4.Location = new Point(284, 266);
            textBoxTemp4.Name = "textBoxTemp4";
            textBoxTemp4.Size = new Size(54, 28);
            textBoxTemp4.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label13.Location = new Point(14, 270);
            label13.Name = "label13";
            label13.Size = new Size(80, 22);
            label13.TabIndex = 16;
            label13.Text = "4#通道";
            // 
            // textBoxConductivity3
            // 
            textBoxConductivity3.Location = new Point(425, 218);
            textBoxConductivity3.Name = "textBoxConductivity3";
            textBoxConductivity3.Size = new Size(54, 28);
            textBoxConductivity3.TabIndex = 15;
            // 
            // textBoxHumidity3
            // 
            textBoxHumidity3.Location = new Point(351, 218);
            textBoxHumidity3.Name = "textBoxHumidity3";
            textBoxHumidity3.Size = new Size(54, 28);
            textBoxHumidity3.TabIndex = 14;
            // 
            // textBoxTemp3
            // 
            textBoxTemp3.Location = new Point(284, 218);
            textBoxTemp3.Name = "textBoxTemp3";
            textBoxTemp3.Size = new Size(54, 28);
            textBoxTemp3.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label12.Location = new Point(14, 222);
            label12.Name = "label12";
            label12.Size = new Size(80, 22);
            label12.TabIndex = 12;
            label12.Text = "3#通道";
            // 
            // textBoxConductivity2
            // 
            textBoxConductivity2.Location = new Point(425, 170);
            textBoxConductivity2.Name = "textBoxConductivity2";
            textBoxConductivity2.Size = new Size(54, 28);
            textBoxConductivity2.TabIndex = 11;
            // 
            // textBoxHumidity2
            // 
            textBoxHumidity2.Location = new Point(351, 170);
            textBoxHumidity2.Name = "textBoxHumidity2";
            textBoxHumidity2.Size = new Size(54, 28);
            textBoxHumidity2.TabIndex = 10;
            // 
            // textBoxTemp2
            // 
            textBoxTemp2.Location = new Point(284, 170);
            textBoxTemp2.Name = "textBoxTemp2";
            textBoxTemp2.Size = new Size(54, 28);
            textBoxTemp2.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label11.Location = new Point(14, 174);
            label11.Name = "label11";
            label11.Size = new Size(80, 22);
            label11.TabIndex = 8;
            label11.Text = "2#通道";
            // 
            // textBoxConductivity1
            // 
            textBoxConductivity1.Location = new Point(425, 120);
            textBoxConductivity1.Name = "textBoxConductivity1";
            textBoxConductivity1.Size = new Size(54, 28);
            textBoxConductivity1.TabIndex = 7;
            // 
            // textBoxHumidity1
            // 
            textBoxHumidity1.Location = new Point(351, 120);
            textBoxHumidity1.Name = "textBoxHumidity1";
            textBoxHumidity1.Size = new Size(54, 28);
            textBoxHumidity1.TabIndex = 6;
            // 
            // textBoxTemp1
            // 
            textBoxTemp1.Location = new Point(284, 120);
            textBoxTemp1.Name = "textBoxTemp1";
            textBoxTemp1.Size = new Size(54, 28);
            textBoxTemp1.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label10.Location = new Point(411, 87);
            label10.Name = "label10";
            label10.Size = new Size(85, 24);
            label10.TabIndex = 4;
            label10.Text = "导电率";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.Location = new Point(350, 87);
            label9.Name = "label9";
            label9.Size = new Size(60, 24);
            label9.TabIndex = 3;
            label9.Text = "湿度";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(284, 87);
            label8.Name = "label8";
            label8.Size = new Size(60, 24);
            label8.TabIndex = 2;
            label8.Text = "温度";
            // 
            // btQueryRealTimeData
            // 
            btQueryRealTimeData.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btQueryRealTimeData.Location = new Point(18, 18);
            btQueryRealTimeData.Name = "btQueryRealTimeData";
            btQueryRealTimeData.Size = new Size(190, 52);
            btQueryRealTimeData.TabIndex = 1;
            btQueryRealTimeData.Text = "请求实时数据";
            btQueryRealTimeData.UseVisualStyleBackColor = true;
            btQueryRealTimeData.Click += btQueryRealTimeData_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.Location = new Point(14, 126);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 0;
            label7.Text = "1#通道";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Linen;
            tabPage3.Controls.Add(comboBoxSensorModel10);
            tabPage3.Controls.Add(comboBoxSensorModel9);
            tabPage3.Controls.Add(comboBoxSensorModel8);
            tabPage3.Controls.Add(comboBoxSensorModel7);
            tabPage3.Controls.Add(comboBoxSensorModel6);
            tabPage3.Controls.Add(label34);
            tabPage3.Controls.Add(label33);
            tabPage3.Controls.Add(label32);
            tabPage3.Controls.Add(label31);
            tabPage3.Controls.Add(label30);
            tabPage3.Controls.Add(comboBoxSensorModel5);
            tabPage3.Controls.Add(comboBoxSensorModel4);
            tabPage3.Controls.Add(comboBoxSensorModel3);
            tabPage3.Controls.Add(comboBoxSensorModel2);
            tabPage3.Controls.Add(label29);
            tabPage3.Controls.Add(label28);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(comboBoxSensorModel1);
            tabPage3.Controls.Add(btSetSensorModel);
            tabPage3.Controls.Add(btQuerySensorModel);
            tabPage3.Location = new Point(46, 4);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(1182, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "配置传感器";
            // 
            // comboBoxSensorModel10
            // 
            comboBoxSensorModel10.FormattingEnabled = true;
            comboBoxSensorModel10.Location = new Point(567, 279);
            comboBoxSensorModel10.Name = "comboBoxSensorModel10";
            comboBoxSensorModel10.Size = new Size(200, 26);
            comboBoxSensorModel10.TabIndex = 21;
            // 
            // comboBoxSensorModel9
            // 
            comboBoxSensorModel9.FormattingEnabled = true;
            comboBoxSensorModel9.Location = new Point(567, 231);
            comboBoxSensorModel9.Name = "comboBoxSensorModel9";
            comboBoxSensorModel9.Size = new Size(200, 26);
            comboBoxSensorModel9.TabIndex = 20;
            // 
            // comboBoxSensorModel8
            // 
            comboBoxSensorModel8.FormattingEnabled = true;
            comboBoxSensorModel8.Location = new Point(567, 182);
            comboBoxSensorModel8.Name = "comboBoxSensorModel8";
            comboBoxSensorModel8.Size = new Size(200, 26);
            comboBoxSensorModel8.TabIndex = 19;
            // 
            // comboBoxSensorModel7
            // 
            comboBoxSensorModel7.FormattingEnabled = true;
            comboBoxSensorModel7.Location = new Point(567, 135);
            comboBoxSensorModel7.Name = "comboBoxSensorModel7";
            comboBoxSensorModel7.Size = new Size(200, 26);
            comboBoxSensorModel7.TabIndex = 18;
            // 
            // comboBoxSensorModel6
            // 
            comboBoxSensorModel6.FormattingEnabled = true;
            comboBoxSensorModel6.Location = new Point(567, 83);
            comboBoxSensorModel6.Name = "comboBoxSensorModel6";
            comboBoxSensorModel6.Size = new Size(200, 26);
            comboBoxSensorModel6.TabIndex = 17;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label34.Location = new Point(439, 282);
            label34.Name = "label34";
            label34.Size = new Size(92, 22);
            label34.TabIndex = 16;
            label34.Text = "10#通道";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label33.Location = new Point(451, 229);
            label33.Name = "label33";
            label33.Size = new Size(80, 22);
            label33.TabIndex = 15;
            label33.Text = "9#通道";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label32.Location = new Point(451, 181);
            label32.Name = "label32";
            label32.Size = new Size(80, 22);
            label32.TabIndex = 14;
            label32.Text = "8#通道";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label31.Location = new Point(451, 134);
            label31.Name = "label31";
            label31.Size = new Size(80, 22);
            label31.TabIndex = 13;
            label31.Text = "7#通道";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label30.Location = new Point(451, 86);
            label30.Name = "label30";
            label30.Size = new Size(80, 22);
            label30.TabIndex = 12;
            label30.Text = "6#通道";
            // 
            // comboBoxSensorModel5
            // 
            comboBoxSensorModel5.FormattingEnabled = true;
            comboBoxSensorModel5.Location = new Point(127, 278);
            comboBoxSensorModel5.Name = "comboBoxSensorModel5";
            comboBoxSensorModel5.Size = new Size(200, 26);
            comboBoxSensorModel5.TabIndex = 11;
            // 
            // comboBoxSensorModel4
            // 
            comboBoxSensorModel4.FormattingEnabled = true;
            comboBoxSensorModel4.Location = new Point(127, 230);
            comboBoxSensorModel4.Name = "comboBoxSensorModel4";
            comboBoxSensorModel4.Size = new Size(200, 26);
            comboBoxSensorModel4.TabIndex = 10;
            // 
            // comboBoxSensorModel3
            // 
            comboBoxSensorModel3.FormattingEnabled = true;
            comboBoxSensorModel3.Location = new Point(127, 181);
            comboBoxSensorModel3.Name = "comboBoxSensorModel3";
            comboBoxSensorModel3.Size = new Size(200, 26);
            comboBoxSensorModel3.TabIndex = 9;
            // 
            // comboBoxSensorModel2
            // 
            comboBoxSensorModel2.FormattingEnabled = true;
            comboBoxSensorModel2.Location = new Point(127, 134);
            comboBoxSensorModel2.Name = "comboBoxSensorModel2";
            comboBoxSensorModel2.Size = new Size(200, 26);
            comboBoxSensorModel2.TabIndex = 8;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label29.Location = new Point(23, 277);
            label29.Name = "label29";
            label29.Size = new Size(80, 22);
            label29.TabIndex = 7;
            label29.Text = "5#通道";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label28.Location = new Point(23, 229);
            label28.Name = "label28";
            label28.Size = new Size(80, 22);
            label28.TabIndex = 6;
            label28.Text = "4#通道";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label27.Location = new Point(23, 181);
            label27.Name = "label27";
            label27.Size = new Size(80, 22);
            label27.TabIndex = 5;
            label27.Text = "3#通道";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label26.Location = new Point(23, 133);
            label26.Name = "label26";
            label26.Size = new Size(80, 22);
            label26.TabIndex = 4;
            label26.Text = "2#通道";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label25.Location = new Point(23, 85);
            label25.Name = "label25";
            label25.Size = new Size(80, 22);
            label25.TabIndex = 3;
            label25.Text = "1#通道";
            // 
            // comboBoxSensorModel1
            // 
            comboBoxSensorModel1.FormattingEnabled = true;
            comboBoxSensorModel1.Location = new Point(127, 82);
            comboBoxSensorModel1.Name = "comboBoxSensorModel1";
            comboBoxSensorModel1.Size = new Size(200, 26);
            comboBoxSensorModel1.TabIndex = 2;
            // 
            // btSetSensorModel
            // 
            btSetSensorModel.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btSetSensorModel.Location = new Point(216, 6);
            btSetSensorModel.Name = "btSetSensorModel";
            btSetSensorModel.Size = new Size(178, 42);
            btSetSensorModel.TabIndex = 1;
            btSetSensorModel.Text = "设置传感器";
            btSetSensorModel.UseVisualStyleBackColor = true;
            btSetSensorModel.Click += btSetSensorModel_Click;
            // 
            // btQuerySensorModel
            // 
            btQuerySensorModel.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btQuerySensorModel.Location = new Point(23, 6);
            btQuerySensorModel.Name = "btQuerySensorModel";
            btQuerySensorModel.Size = new Size(178, 42);
            btQuerySensorModel.TabIndex = 0;
            btQuerySensorModel.Text = "查询传感器";
            btQuerySensorModel.UseVisualStyleBackColor = true;
            btQuerySensorModel.Click += btQuerySensorModel_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(stopUpgradeBt);
            tabPage4.Controls.Add(upgradeFileNameLb);
            tabPage4.Controls.Add(upgradeProgressBar);
            tabPage4.Controls.Add(startUpgradeBt);
            tabPage4.Controls.Add(openUpgradeFileBt);
            tabPage4.Location = new Point(46, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1182, 421);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "更新设备";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // stopUpgradeBt
            // 
            stopUpgradeBt.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            stopUpgradeBt.Location = new Point(17, 126);
            stopUpgradeBt.Name = "stopUpgradeBt";
            stopUpgradeBt.Size = new Size(151, 38);
            stopUpgradeBt.TabIndex = 4;
            stopUpgradeBt.Text = "停止更新";
            stopUpgradeBt.UseVisualStyleBackColor = true;
            stopUpgradeBt.Click += stopUpgradeBt_Click;
            // 
            // upgradeFileNameLb
            // 
            upgradeFileNameLb.AutoSize = true;
            upgradeFileNameLb.Location = new Point(193, 32);
            upgradeFileNameLb.Name = "upgradeFileNameLb";
            upgradeFileNameLb.Size = new Size(125, 19);
            upgradeFileNameLb.TabIndex = 3;
            upgradeFileNameLb.Text = "更新文件.bin";
            // 
            // upgradeProgressBar
            // 
            upgradeProgressBar.Location = new Point(193, 82);
            upgradeProgressBar.Name = "upgradeProgressBar";
            upgradeProgressBar.Size = new Size(958, 29);
            upgradeProgressBar.TabIndex = 2;
            // 
            // startUpgradeBt
            // 
            startUpgradeBt.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            startUpgradeBt.Location = new Point(17, 73);
            startUpgradeBt.Name = "startUpgradeBt";
            startUpgradeBt.Size = new Size(151, 38);
            startUpgradeBt.TabIndex = 1;
            startUpgradeBt.Text = "开始更新";
            startUpgradeBt.UseVisualStyleBackColor = true;
            startUpgradeBt.Click += startUpgradeBt_Click;
            // 
            // openUpgradeFileBt
            // 
            openUpgradeFileBt.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            openUpgradeFileBt.Location = new Point(17, 21);
            openUpgradeFileBt.Name = "openUpgradeFileBt";
            openUpgradeFileBt.Size = new Size(151, 38);
            openUpgradeFileBt.TabIndex = 0;
            openUpgradeFileBt.Text = "打开更新文件";
            openUpgradeFileBt.UseVisualStyleBackColor = true;
            openUpgradeFileBt.Click += openUpgradeFileBt_Click;
            // 
            // Onenet
            // 
            Onenet.Controls.Add(label37);
            Onenet.Controls.Add(label36);
            Onenet.Controls.Add(label35);
            Onenet.Controls.Add(productKeyTextBox);
            Onenet.Controls.Add(deviceNameTextBox);
            Onenet.Controls.Add(productIdTextBox);
            Onenet.Controls.Add(setOnenetBt);
            Onenet.Controls.Add(queryOnenetBt);
            Onenet.Location = new Point(46, 4);
            Onenet.Name = "Onenet";
            Onenet.Padding = new Padding(3);
            Onenet.Size = new Size(1182, 421);
            Onenet.TabIndex = 4;
            Onenet.Text = "Onenet";
            Onenet.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(213, 127);
            label37.Name = "label37";
            label37.Size = new Size(87, 19);
            label37.TabIndex = 23;
            label37.Text = "产品Key:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(221, 77);
            label36.Name = "label36";
            label36.Size = new Size(76, 19);
            label36.TabIndex = 22;
            label36.Text = "设备名:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(198, 24);
            label35.Name = "label35";
            label35.Size = new Size(119, 19);
            label35.TabIndex = 21;
            label35.Text = "Product ID:";
            // 
            // productKeyTextBox
            // 
            productKeyTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            productKeyTextBox.Location = new Point(322, 122);
            productKeyTextBox.Margin = new Padding(2);
            productKeyTextBox.Name = "productKeyTextBox";
            productKeyTextBox.Size = new Size(470, 30);
            productKeyTextBox.TabIndex = 20;
            // 
            // deviceNameTextBox
            // 
            deviceNameTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            deviceNameTextBox.Location = new Point(322, 72);
            deviceNameTextBox.Margin = new Padding(2);
            deviceNameTextBox.Name = "deviceNameTextBox";
            deviceNameTextBox.Size = new Size(470, 30);
            deviceNameTextBox.TabIndex = 17;
            // 
            // productIdTextBox
            // 
            productIdTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            productIdTextBox.Location = new Point(322, 19);
            productIdTextBox.Margin = new Padding(2);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.Size = new Size(470, 30);
            productIdTextBox.TabIndex = 14;
            // 
            // setOnenetBt
            // 
            setOnenetBt.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            setOnenetBt.Location = new Point(822, 19);
            setOnenetBt.Name = "setOnenetBt";
            setOnenetBt.Size = new Size(246, 138);
            setOnenetBt.TabIndex = 1;
            setOnenetBt.Text = "设置Onenet Info";
            setOnenetBt.UseVisualStyleBackColor = true;
            setOnenetBt.Click += setOnenetBt_Click;
            // 
            // queryOnenetBt
            // 
            queryOnenetBt.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            queryOnenetBt.Location = new Point(12, 19);
            queryOnenetBt.Name = "queryOnenetBt";
            queryOnenetBt.Size = new Size(180, 138);
            queryOnenetBt.TabIndex = 0;
            queryOnenetBt.Text = "请求Onenet Info";
            queryOnenetBt.UseVisualStyleBackColor = true;
            queryOnenetBt.Click += queryOnenetBt_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxLog);
            panel1.Controls.Add(btSaveLog);
            panel1.Controls.Add(btClearLog);
            panel1.Location = new Point(24, 682);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 166);
            panel1.TabIndex = 4;
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(133, 3);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = ScrollBars.Vertical;
            textBoxLog.Size = new Size(969, 160);
            textBoxLog.TabIndex = 2;
            // 
            // btSaveLog
            // 
            btSaveLog.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btSaveLog.Location = new Point(3, 93);
            btSaveLog.Name = "btSaveLog";
            btSaveLog.Size = new Size(124, 52);
            btSaveLog.TabIndex = 1;
            btSaveLog.Text = "保存日志";
            btSaveLog.UseVisualStyleBackColor = true;
            btSaveLog.Click += btSaveLog_Click;
            // 
            // btClearLog
            // 
            btClearLog.Font = new Font("宋体", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btClearLog.Location = new Point(3, 17);
            btClearLog.Name = "btClearLog";
            btClearLog.Size = new Size(124, 52);
            btClearLog.TabIndex = 0;
            btClearLog.Text = "清空日志";
            btClearLog.UseVisualStyleBackColor = true;
            btClearLog.Click += btClearLog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 860);
            Controls.Add(panel1);
            Controls.Add(tabControl);
            Controls.Add(groupBox1);
            Controls.Add(deviceInfo);
            Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            deviceInfo.ResumeLayout(false);
            deviceInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSensor).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            Onenet.ResumeLayout(false);
            Onenet.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox deviceInfo;
        private System.Windows.Forms.Button btSetDevInfo;
        private System.Windows.Forms.Button btQueryDevInfo;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btDevReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ComboBox com;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDevAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBetteryLevel;
        private System.Windows.Forms.TextBox textSensorNum;
        private System.Windows.Forms.TextBox textSerialNumber;
        private System.Windows.Forms.TextBox textVersion;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btSetRtc;
        private System.Windows.Forms.Button btRequestRtc;
        private System.Windows.Forms.Label lbRtc;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Button btSetTimeIntval;
        private System.Windows.Forms.TextBox textTimeIntval;
        private System.Windows.Forms.Button btRequestTimeIntval;
        private System.Windows.Forms.ComboBox comboboxSensorIdx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btQueryStartTimeCount;
        private System.Windows.Forms.TextBox textRecordCount;
        private System.Windows.Forms.TextBox textStartTime;
        private System.Windows.Forms.Button btExportData;
        private System.Windows.Forms.Button btQueryAllData;
        private System.Windows.Forms.Button btQuerySensorData;
        private System.Windows.Forms.DataGridView dataGridViewSensor;
        private System.Windows.Forms.Button btClearTableData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btQueryRealTimeData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxConductivity5;
        private System.Windows.Forms.TextBox textBoxHumidity5;
        private System.Windows.Forms.TextBox textBoxTemp5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxConductivity4;
        private System.Windows.Forms.TextBox textBoxHumidity4;
        private System.Windows.Forms.TextBox textBoxTemp4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxConductivity3;
        private System.Windows.Forms.TextBox textBoxHumidity3;
        private System.Windows.Forms.TextBox textBoxTemp3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxConductivity2;
        private System.Windows.Forms.TextBox textBoxHumidity2;
        private System.Windows.Forms.TextBox textBoxTemp2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxConductivity1;
        private System.Windows.Forms.TextBox textBoxHumidity1;
        private System.Windows.Forms.TextBox textBoxTemp1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxConductivity10;
        private System.Windows.Forms.TextBox textBoxHumidity10;
        private System.Windows.Forms.TextBox textBoxTemp10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxConductivity9;
        private System.Windows.Forms.TextBox textBoxHumidity9;
        private System.Windows.Forms.TextBox textBoxTemp9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxConductivity8;
        private System.Windows.Forms.TextBox textBoxHumidity8;
        private System.Windows.Forms.TextBox textBoxTemp8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxConductivity7;
        private System.Windows.Forms.TextBox textBoxHumidity7;
        private System.Windows.Forms.TextBox textBoxTemp7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxConductivity6;
        private System.Windows.Forms.TextBox textBoxHumidity6;
        private System.Windows.Forms.TextBox textBoxTemp6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxTime1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxTime10;
        private System.Windows.Forms.TextBox textBoxTime9;
        private System.Windows.Forms.TextBox textBoxTime8;
        private System.Windows.Forms.TextBox textBoxTime7;
        private System.Windows.Forms.TextBox textBoxTime5;
        private System.Windows.Forms.TextBox textBoxTime4;
        private System.Windows.Forms.TextBox textBoxTime3;
        private System.Windows.Forms.TextBox textBoxTime2;
        private System.Windows.Forms.TextBox textBoxTime6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempture;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn conductivity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxSensorModel1;
        private System.Windows.Forms.Button btSetSensorModel;
        private System.Windows.Forms.Button btQuerySensorModel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBoxSensorModel5;
        private System.Windows.Forms.ComboBox comboBoxSensorModel4;
        private System.Windows.Forms.ComboBox comboBoxSensorModel3;
        private System.Windows.Forms.ComboBox comboBoxSensorModel2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBoxSensorModel10;
        private System.Windows.Forms.ComboBox comboBoxSensorModel9;
        private System.Windows.Forms.ComboBox comboBoxSensorModel8;
        private System.Windows.Forms.ComboBox comboBoxSensorModel7;
        private System.Windows.Forms.ComboBox comboBoxSensorModel6;
        private System.Windows.Forms.Button btClearSensorData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button btSaveLog;
        private System.Windows.Forms.Button btClearLog;
        private TabPage tabPage4;
        private ProgressBar upgradeProgressBar;
        private Button startUpgradeBt;
        private Button openUpgradeFileBt;
        private Label upgradeFileNameLb;
        private Button stopUpgradeBt;
        private TabPage Onenet;
        private Button setOnenetBt;
        private Button queryOnenetBt;
        private TextBox productKeyTextBox;
        private TextBox deviceNameTextBox;
        private TextBox productIdTextBox;
        private Label label37;
        private Label label36;
        private Label label35;
    }
}

