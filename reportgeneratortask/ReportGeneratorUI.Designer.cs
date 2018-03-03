namespace SSISComponents.ReportGenerator
{
    partial class ReportGeneratorUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGeneratorUi));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ofdReport = new System.Windows.Forms.OpenFileDialog();
            this.sfdReport = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProperties = new System.Windows.Forms.TabPage();
            this.cbxPrefixFilename = new System.Windows.Forms.ComboBox();
            this.cbPrefixFilename = new System.Windows.Forms.Label();
            this.gbAuthorization = new System.Windows.Forms.GroupBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWindowsAuthorization = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.lblDatasetname = new System.Windows.Forms.Label();
            this.txtDatasetname = new System.Windows.Forms.TextBox();
            this.txtReportServer = new System.Windows.Forms.TextBox();
            this.cbAddPrefix = new System.Windows.Forms.CheckBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.txtReports = new System.Windows.Forms.TextBox();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblRecordset = new System.Windows.Forms.Label();
            this.cbxRecordset = new System.Windows.Forms.ComboBox();
            this.tpParameter = new System.Windows.Forms.TabPage();
            this.dgvReportParameter = new System.Windows.Forms.DataGridView();
            this.cVariable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MultiValue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.gbExecutionInfo = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNumPages = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHistoryId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbExpirationDateTime = new System.Windows.Forms.ComboBox();
            this.cbExecutionDateTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbExecutionId = new System.Windows.Forms.ComboBox();
            this.gbAdvancedProperties = new System.Windows.Forms.GroupBox();
            this.cbSnapshot = new System.Windows.Forms.CheckBox();
            this.cbShowInDebug = new System.Windows.Forms.CheckBox();
            this.numTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCodeplex = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkoh22is = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCodeplex = new System.Windows.Forms.Label();
            this.linkCodeplex = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tpProperties.SuspendLayout();
            this.gbAuthorization.SuspendLayout();
            this.tpParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportParameter)).BeginInit();
            this.tpAdvanced.SuspendLayout();
            this.gbExecutionInfo.SuspendLayout();
            this.gbAdvancedProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).BeginInit();
            this.tpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodeplex)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(266, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(347, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ofdReport
            // 
            this.ofdReport.Filter = "Microsoft Report Datei (*.rdlc)|*.rdlc";
            // 
            // sfdReport
            // 
            this.sfdReport.Filter = "Acrobat-Datei (*.pdf)|*.pdf|Microsoft Excel (*.xls)|*.xls";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpProperties);
            this.tabControl1.Controls.Add(this.tpParameter);
            this.tabControl1.Controls.Add(this.tpAdvanced);
            this.tabControl1.Controls.Add(this.tpInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 409);
            this.tabControl1.TabIndex = 22;
            // 
            // tpProperties
            // 
            this.tpProperties.Controls.Add(this.cbxPrefixFilename);
            this.tpProperties.Controls.Add(this.cbPrefixFilename);
            this.tpProperties.Controls.Add(this.gbAuthorization);
            this.tpProperties.Controls.Add(this.label1);
            this.tpProperties.Controls.Add(this.cbReportType);
            this.tpProperties.Controls.Add(this.lblDatasetname);
            this.tpProperties.Controls.Add(this.txtDatasetname);
            this.tpProperties.Controls.Add(this.txtReportServer);
            this.tpProperties.Controls.Add(this.cbAddPrefix);
            this.tpProperties.Controls.Add(this.btnLocation);
            this.tpProperties.Controls.Add(this.txtLocation);
            this.tpProperties.Controls.Add(this.lblLocation);
            this.tpProperties.Controls.Add(this.btnReports);
            this.tpProperties.Controls.Add(this.txtReports);
            this.tpProperties.Controls.Add(this.lblReports);
            this.tpProperties.Controls.Add(this.lblRecordset);
            this.tpProperties.Controls.Add(this.cbxRecordset);
            this.tpProperties.Location = new System.Drawing.Point(4, 22);
            this.tpProperties.Name = "tpProperties";
            this.tpProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tpProperties.Size = new System.Drawing.Size(402, 383);
            this.tpProperties.TabIndex = 0;
            this.tpProperties.Text = "Properties";
            this.tpProperties.UseVisualStyleBackColor = true;
            // 
            // cbxPrefixFilename
            // 
            this.cbxPrefixFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPrefixFilename.AutoCompleteCustomSource.AddRange(new string[] {
            "Choose a Variable"});
            this.cbxPrefixFilename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrefixFilename.FormattingEnabled = true;
            this.cbxPrefixFilename.Location = new System.Drawing.Point(91, 292);
            this.cbxPrefixFilename.Name = "cbxPrefixFilename";
            this.cbxPrefixFilename.Size = new System.Drawing.Size(267, 21);
            this.cbxPrefixFilename.TabIndex = 42;
            // 
            // cbPrefixFilename
            // 
            this.cbPrefixFilename.AutoSize = true;
            this.cbPrefixFilename.Location = new System.Drawing.Point(9, 295);
            this.cbPrefixFilename.Name = "cbPrefixFilename";
            this.cbPrefixFilename.Size = new System.Drawing.Size(81, 13);
            this.cbPrefixFilename.TabIndex = 41;
            this.cbPrefixFilename.Text = "Prefix Filename:";
            // 
            // gbAuthorization
            // 
            this.gbAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAuthorization.Controls.Add(this.txtDomain);
            this.gbAuthorization.Controls.Add(this.label2);
            this.gbAuthorization.Controls.Add(this.cbWindowsAuthorization);
            this.gbAuthorization.Controls.Add(this.txtPassword);
            this.gbAuthorization.Controls.Add(this.txtUsername);
            this.gbAuthorization.Controls.Add(this.lblPassword);
            this.gbAuthorization.Controls.Add(this.lblUsername);
            this.gbAuthorization.Enabled = false;
            this.gbAuthorization.Location = new System.Drawing.Point(6, 59);
            this.gbAuthorization.Name = "gbAuthorization";
            this.gbAuthorization.Size = new System.Drawing.Size(390, 126);
            this.gbAuthorization.TabIndex = 40;
            this.gbAuthorization.TabStop = false;
            this.gbAuthorization.Text = "Authorization";
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomain.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomain.Enabled = false;
            this.txtDomain.Location = new System.Drawing.Point(85, 71);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(299, 20);
            this.txtDomain.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Domain:";
            // 
            // cbWindowsAuthorization
            // 
            this.cbWindowsAuthorization.AutoSize = true;
            this.cbWindowsAuthorization.Checked = true;
            this.cbWindowsAuthorization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWindowsAuthorization.Location = new System.Drawing.Point(85, 97);
            this.cbWindowsAuthorization.Name = "cbWindowsAuthorization";
            this.cbWindowsAuthorization.Size = new System.Drawing.Size(184, 17);
            this.cbWindowsAuthorization.TabIndex = 4;
            this.cbWindowsAuthorization.Text = "Use Windows Integrated Security";
            this.cbWindowsAuthorization.UseVisualStyleBackColor = true;
            this.cbWindowsAuthorization.CheckedChanged += new System.EventHandler(this.cbWindowsAuthorization_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(85, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(299, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(85, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(299, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(2, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(2, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Report:";
            // 
            // cbReportType
            // 
            this.cbReportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "Dataset Report",
            "SQL Server Report"});
            this.cbReportType.Location = new System.Drawing.Point(91, 6);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(305, 21);
            this.cbReportType.TabIndex = 37;
            this.cbReportType.SelectedIndexChanged += new System.EventHandler(this.cbReportType_SelectedIndexChanged);
            // 
            // lblDatasetname
            // 
            this.lblDatasetname.AutoSize = true;
            this.lblDatasetname.Location = new System.Drawing.Point(10, 220);
            this.lblDatasetname.Name = "lblDatasetname";
            this.lblDatasetname.Size = new System.Drawing.Size(78, 13);
            this.lblDatasetname.TabIndex = 36;
            this.lblDatasetname.Text = "Dataset Name:";
            // 
            // txtDatasetname
            // 
            this.txtDatasetname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatasetname.Location = new System.Drawing.Point(91, 217);
            this.txtDatasetname.Name = "txtDatasetname";
            this.txtDatasetname.Size = new System.Drawing.Size(267, 20);
            this.txtDatasetname.TabIndex = 35;
            // 
            // txtReportServer
            // 
            this.txtReportServer.Location = new System.Drawing.Point(90, 30);
            this.txtReportServer.Name = "txtReportServer";
            this.txtReportServer.Size = new System.Drawing.Size(306, 20);
            this.txtReportServer.TabIndex = 34;
            // 
            // cbAddPrefix
            // 
            this.cbAddPrefix.AutoSize = true;
            this.cbAddPrefix.Checked = true;
            this.cbAddPrefix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddPrefix.Location = new System.Drawing.Point(91, 269);
            this.cbAddPrefix.Name = "cbAddPrefix";
            this.cbAddPrefix.Size = new System.Drawing.Size(165, 17);
            this.cbAddPrefix.TabIndex = 32;
            this.cbAddPrefix.Text = "Add date as prefix to filename";
            this.cbAddPrefix.UseVisualStyleBackColor = true;
            this.cbAddPrefix.CheckedChanged += new System.EventHandler(this.cbAddPrefix_CheckedChanged);
            // 
            // btnLocation
            // 
            this.btnLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocation.Location = new System.Drawing.Point(363, 241);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(33, 23);
            this.btnLocation.TabIndex = 31;
            this.btnLocation.Text = "...";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click_1);
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(91, 243);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(266, 20);
            this.txtLocation.TabIndex = 30;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(10, 246);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(49, 13);
            this.lblLocation.TabIndex = 29;
            this.lblLocation.Text = "Save as:";
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.Location = new System.Drawing.Point(363, 189);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(33, 23);
            this.btnReports.TabIndex = 28;
            this.btnReports.Text = "...";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // txtReports
            // 
            this.txtReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReports.Location = new System.Drawing.Point(91, 191);
            this.txtReports.Name = "txtReports";
            this.txtReports.Size = new System.Drawing.Size(267, 20);
            this.txtReports.TabIndex = 27;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(10, 194);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(42, 13);
            this.lblReports.TabIndex = 26;
            this.lblReports.Text = "Report:";
            // 
            // lblRecordset
            // 
            this.lblRecordset.AutoSize = true;
            this.lblRecordset.Location = new System.Drawing.Point(8, 33);
            this.lblRecordset.Name = "lblRecordset";
            this.lblRecordset.Size = new System.Drawing.Size(48, 13);
            this.lblRecordset.TabIndex = 25;
            this.lblRecordset.Text = "Variable:";
            // 
            // cbxRecordset
            // 
            this.cbxRecordset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRecordset.AutoCompleteCustomSource.AddRange(new string[] {
            "Choose a Variable"});
            this.cbxRecordset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecordset.FormattingEnabled = true;
            this.cbxRecordset.Location = new System.Drawing.Point(90, 30);
            this.cbxRecordset.Name = "cbxRecordset";
            this.cbxRecordset.Size = new System.Drawing.Size(306, 21);
            this.cbxRecordset.TabIndex = 45;
            this.cbxRecordset.Visible = false;
            // 
            // tpParameter
            // 
            this.tpParameter.Controls.Add(this.dgvReportParameter);
            this.tpParameter.Location = new System.Drawing.Point(4, 22);
            this.tpParameter.Name = "tpParameter";
            this.tpParameter.Size = new System.Drawing.Size(402, 383);
            this.tpParameter.TabIndex = 2;
            this.tpParameter.Text = "Report Parameter";
            this.tpParameter.UseVisualStyleBackColor = true;
            // 
            // dgvReportParameter
            // 
            this.dgvReportParameter.AllowUserToAddRows = false;
            this.dgvReportParameter.AllowUserToDeleteRows = false;
            this.dgvReportParameter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportParameter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cVariable,
            this.cParameter,
            this.MultiValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportParameter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportParameter.Location = new System.Drawing.Point(0, 0);
            this.dgvReportParameter.MultiSelect = false;
            this.dgvReportParameter.Name = "dgvReportParameter";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportParameter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReportParameter.RowHeadersVisible = false;
            this.dgvReportParameter.RowHeadersWidth = 10;
            this.dgvReportParameter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReportParameter.Size = new System.Drawing.Size(402, 383);
            this.dgvReportParameter.TabIndex = 0;
            // 
            // cVariable
            // 
            this.cVariable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cVariable.HeaderText = "Variable";
            this.cVariable.MinimumWidth = 162;
            this.cVariable.Name = "cVariable";
            // 
            // cParameter
            // 
            this.cParameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cParameter.HeaderText = "Parameter";
            this.cParameter.MinimumWidth = 162;
            this.cParameter.Name = "cParameter";
            this.cParameter.ReadOnly = true;
            // 
            // MultiValue
            // 
            this.MultiValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MultiValue.FillWeight = 50F;
            this.MultiValue.HeaderText = "Multi Value";
            this.MultiValue.Name = "MultiValue";
            this.MultiValue.ReadOnly = true;
            this.MultiValue.Width = 65;
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.gbExecutionInfo);
            this.tpAdvanced.Controls.Add(this.gbAdvancedProperties);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(402, 383);
            this.tpAdvanced.TabIndex = 3;
            this.tpAdvanced.Text = "Advanced";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // gbExecutionInfo
            // 
            this.gbExecutionInfo.Controls.Add(this.label11);
            this.gbExecutionInfo.Controls.Add(this.cbNumPages);
            this.gbExecutionInfo.Controls.Add(this.label10);
            this.gbExecutionInfo.Controls.Add(this.cbHistoryId);
            this.gbExecutionInfo.Controls.Add(this.label7);
            this.gbExecutionInfo.Controls.Add(this.cbExpirationDateTime);
            this.gbExecutionInfo.Controls.Add(this.cbExecutionDateTime);
            this.gbExecutionInfo.Controls.Add(this.label5);
            this.gbExecutionInfo.Controls.Add(this.label6);
            this.gbExecutionInfo.Controls.Add(this.cbExecutionId);
            this.gbExecutionInfo.Location = new System.Drawing.Point(6, 103);
            this.gbExecutionInfo.Name = "gbExecutionInfo";
            this.gbExecutionInfo.Size = new System.Drawing.Size(390, 165);
            this.gbExecutionInfo.TabIndex = 10;
            this.gbExecutionInfo.TabStop = false;
            this.gbExecutionInfo.Text = "Execution Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "NumPages:";
            // 
            // cbNumPages
            // 
            this.cbNumPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumPages.FormattingEnabled = true;
            this.cbNumPages.Location = new System.Drawing.Point(115, 127);
            this.cbNumPages.Name = "cbNumPages";
            this.cbNumPages.Size = new System.Drawing.Size(269, 21);
            this.cbNumPages.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "HistoryID:";
            // 
            // cbHistoryId
            // 
            this.cbHistoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHistoryId.FormattingEnabled = true;
            this.cbHistoryId.Location = new System.Drawing.Point(115, 100);
            this.cbHistoryId.Name = "cbHistoryId";
            this.cbHistoryId.Size = new System.Drawing.Size(269, 21);
            this.cbHistoryId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ExpirationDateTime:";
            // 
            // cbExpirationDateTime
            // 
            this.cbExpirationDateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExpirationDateTime.FormattingEnabled = true;
            this.cbExpirationDateTime.Location = new System.Drawing.Point(115, 73);
            this.cbExpirationDateTime.Name = "cbExpirationDateTime";
            this.cbExpirationDateTime.Size = new System.Drawing.Size(269, 21);
            this.cbExpirationDateTime.TabIndex = 9;
            // 
            // cbExecutionDateTime
            // 
            this.cbExecutionDateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExecutionDateTime.FormattingEnabled = true;
            this.cbExecutionDateTime.Location = new System.Drawing.Point(115, 19);
            this.cbExecutionDateTime.Name = "cbExecutionDateTime";
            this.cbExecutionDateTime.Size = new System.Drawing.Size(269, 21);
            this.cbExecutionDateTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ExecutionDateTime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ExecutionID:";
            // 
            // cbExecutionId
            // 
            this.cbExecutionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExecutionId.FormattingEnabled = true;
            this.cbExecutionId.Location = new System.Drawing.Point(115, 46);
            this.cbExecutionId.Name = "cbExecutionId";
            this.cbExecutionId.Size = new System.Drawing.Size(269, 21);
            this.cbExecutionId.TabIndex = 7;
            // 
            // gbAdvancedProperties
            // 
            this.gbAdvancedProperties.Controls.Add(this.cbSnapshot);
            this.gbAdvancedProperties.Controls.Add(this.cbShowInDebug);
            this.gbAdvancedProperties.Controls.Add(this.numTimeOut);
            this.gbAdvancedProperties.Controls.Add(this.label4);
            this.gbAdvancedProperties.Location = new System.Drawing.Point(6, 6);
            this.gbAdvancedProperties.Name = "gbAdvancedProperties";
            this.gbAdvancedProperties.Size = new System.Drawing.Size(390, 91);
            this.gbAdvancedProperties.TabIndex = 9;
            this.gbAdvancedProperties.TabStop = false;
            this.gbAdvancedProperties.Text = "Advanced Properties";
            // 
            // cbSnapshot
            // 
            this.cbSnapshot.AutoSize = true;
            this.cbSnapshot.Enabled = false;
            this.cbSnapshot.Location = new System.Drawing.Point(115, 68);
            this.cbSnapshot.Name = "cbSnapshot";
            this.cbSnapshot.Size = new System.Drawing.Size(105, 17);
            this.cbSnapshot.TabIndex = 46;
            this.cbSnapshot.Text = "Create Snapshot";
            this.cbSnapshot.UseVisualStyleBackColor = true;
            // 
            // cbShowInDebug
            // 
            this.cbShowInDebug.AutoSize = true;
            this.cbShowInDebug.Location = new System.Drawing.Point(115, 45);
            this.cbShowInDebug.Name = "cbShowInDebug";
            this.cbShowInDebug.Size = new System.Drawing.Size(164, 17);
            this.cbShowInDebug.TabIndex = 45;
            this.cbShowInDebug.Text = "Show report during execution";
            this.cbShowInDebug.UseVisualStyleBackColor = true;
            // 
            // numTimeOut
            // 
            this.numTimeOut.Location = new System.Drawing.Point(115, 19);
            this.numTimeOut.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTimeOut.Name = "numTimeOut";
            this.numTimeOut.Size = new System.Drawing.Size(269, 20);
            this.numTimeOut.TabIndex = 4;
            this.numTimeOut.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TimeOut:";
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.pictureBox2);
            this.tpInfo.Controls.Add(this.pictureBox1);
            this.tpInfo.Controls.Add(this.label3);
            this.tpInfo.Controls.Add(this.pbCodeplex);
            this.tpInfo.Controls.Add(this.linkLabel1);
            this.tpInfo.Controls.Add(this.linkoh22is);
            this.tpInfo.Controls.Add(this.lblAuthor);
            this.tpInfo.Controls.Add(this.lblVersion);
            this.tpInfo.Controls.Add(this.lblCodeplex);
            this.tpInfo.Controls.Add(this.linkCodeplex);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(402, 383);
            this.tpInfo.TabIndex = 1;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SSISComponents.ReportGenerator.Properties.Resources.oh22is;
            this.pictureBox2.Location = new System.Drawing.Point(7, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSISComponents.ReportGenerator.Properties.Resources.GitHub;
            this.pictureBox1.Location = new System.Drawing.Point(7, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "SSIS ReportGenerator Task";
            // 
            // pbCodeplex
            // 
            this.pbCodeplex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCodeplex.Image = global::SSISComponents.ReportGenerator.Properties.Resources.Export;
            this.pbCodeplex.Location = new System.Drawing.Point(345, 3);
            this.pbCodeplex.Name = "pbCodeplex";
            this.pbCodeplex.Size = new System.Drawing.Size(54, 74);
            this.pbCodeplex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCodeplex.TabIndex = 17;
            this.pbCodeplex.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.ssis-components.net";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSsisComponents_LinkClicked);
            // 
            // linkoh22is
            // 
            this.linkoh22is.AutoSize = true;
            this.linkoh22is.Location = new System.Drawing.Point(6, 254);
            this.linkoh22is.Name = "linkoh22is";
            this.linkoh22is.Size = new System.Drawing.Size(99, 13);
            this.linkoh22is.TabIndex = 15;
            this.linkoh22is.TabStop = true;
            this.linkoh22is.Text = "http://www.oh22.is";
            this.linkoh22is.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkoh22is_LinkClicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 217);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(104, 13);
            this.lblAuthor.TabIndex = 14;
            this.lblAuthor.Text = "by Tillmann Eitelberg";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(6, 196);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(102, 13);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Version 1.8.5.0 beta";
            // 
            // lblCodeplex
            // 
            this.lblCodeplex.AutoSize = true;
            this.lblCodeplex.Location = new System.Drawing.Point(5, 35);
            this.lblCodeplex.Name = "lblCodeplex";
            this.lblCodeplex.Size = new System.Drawing.Size(289, 13);
            this.lblCodeplex.TabIndex = 12;
            this.lblCodeplex.Text = "This project is hosted on GitHub and licensed under MS-PL.";
            // 
            // linkCodeplex
            // 
            this.linkCodeplex.AutoSize = true;
            this.linkCodeplex.Location = new System.Drawing.Point(5, 53);
            this.linkCodeplex.Name = "linkCodeplex";
            this.linkCodeplex.Size = new System.Drawing.Size(256, 13);
            this.linkCodeplex.TabIndex = 11;
            this.linkCodeplex.TabStop = true;
            this.linkCodeplex.Text = "https://github.com/TEitelberg/ReportGeneratorTask";
            this.linkCodeplex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCodeplex_LinkClicked);
            // 
            // ReportGeneratorUi
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "ReportGeneratorUi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSIS ReportGenerator Task";
            this.Load += new System.EventHandler(this.ReportGeneratorUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpProperties.ResumeLayout(false);
            this.tpProperties.PerformLayout();
            this.gbAuthorization.ResumeLayout(false);
            this.gbAuthorization.PerformLayout();
            this.tpParameter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportParameter)).EndInit();
            this.tpAdvanced.ResumeLayout(false);
            this.gbExecutionInfo.ResumeLayout(false);
            this.gbExecutionInfo.PerformLayout();
            this.gbAdvancedProperties.ResumeLayout(false);
            this.gbAdvancedProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).EndInit();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodeplex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog ofdReport;
        private System.Windows.Forms.SaveFileDialog sfdReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProperties;
        internal System.Windows.Forms.Label lblDatasetname;
        internal System.Windows.Forms.TextBox txtDatasetname;
        internal System.Windows.Forms.TextBox txtReportServer;
        internal System.Windows.Forms.CheckBox cbAddPrefix;
        internal System.Windows.Forms.Button btnLocation;
        internal System.Windows.Forms.TextBox txtLocation;
        internal System.Windows.Forms.Label lblLocation;
        internal System.Windows.Forms.Button btnReports;
        internal System.Windows.Forms.TextBox txtReports;
        internal System.Windows.Forms.Label lblReports;
        internal System.Windows.Forms.Label lblRecordset;
        private System.Windows.Forms.TabPage tpInfo;
        internal System.Windows.Forms.LinkLabel linkoh22is;
        internal System.Windows.Forms.Label lblAuthor;
        internal System.Windows.Forms.Label lblVersion;
        internal System.Windows.Forms.Label lblCodeplex;
        internal System.Windows.Forms.LinkLabel linkCodeplex;
        internal System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbReportType;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAuthorization;
        private System.Windows.Forms.CheckBox cbWindowsAuthorization;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbxPrefixFilename;
        internal System.Windows.Forms.Label cbPrefixFilename;
        private System.Windows.Forms.TabPage tpParameter;
        private System.Windows.Forms.DataGridView dgvReportParameter;
        private System.Windows.Forms.ComboBox cbxRecordset;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cParameter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MultiValue;
        private System.Windows.Forms.PictureBox pbCodeplex;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTimeOut;
        private System.Windows.Forms.ComboBox cbExecutionDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbExecutionId;
        private System.Windows.Forms.GroupBox gbExecutionInfo;
        private System.Windows.Forms.GroupBox gbAdvancedProperties;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbExpirationDateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbHistoryId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNumPages;
        internal System.Windows.Forms.CheckBox cbSnapshot;
        internal System.Windows.Forms.CheckBox cbShowInDebug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}