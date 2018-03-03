namespace SSISComponents.ReportGenerator
{
    partial class ReportProperties
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProperties));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAllgemein = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.cbVersteckt = new System.Windows.Forms.CheckBox();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.txtGeaendertVon = new System.Windows.Forms.Label();
            this.txtGeaendertAm = new System.Windows.Forms.Label();
            this.txtErstelltVon = new System.Windows.Forms.Label();
            this.txtErstelltAm = new System.Windows.Forms.Label();
            this.txtGroesse = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.tpSicherheit = new System.Windows.Forms.TabPage();
            this.lvSecurity = new System.Windows.Forms.ListView();
            this.Benutzername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilEigenschaften = new System.Windows.Forms.ImageList(this.components);
            this.tpSnapshots = new System.Windows.Forms.TabPage();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.lvSnapshots = new System.Windows.Forms.ListView();
            this.cDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDataSource = new System.Windows.Forms.TabPage();
            this.lvDataSource = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpParameter = new System.Windows.Forms.TabPage();
            this.lvParameter = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNullable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpAllgemein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.tpSicherheit.SuspendLayout();
            this.tpSnapshots.SuspendLayout();
            this.tpDataSource.SuspendLayout();
            this.tpParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAllgemein);
            this.tabControl1.Controls.Add(this.tpSicherheit);
            this.tabControl1.Controls.Add(this.tpSnapshots);
            this.tabControl1.Controls.Add(this.tpDataSource);
            this.tabControl1.Controls.Add(this.tpParameter);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(380, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAllgemein
            // 
            this.tpAllgemein.Controls.Add(this.txtName);
            this.tpAllgemein.Controls.Add(this.txtID);
            this.tpAllgemein.Controls.Add(this.cbVersteckt);
            this.tpAllgemein.Controls.Add(this.txtBeschreibung);
            this.tpAllgemein.Controls.Add(this.txtGeaendertVon);
            this.tpAllgemein.Controls.Add(this.txtGeaendertAm);
            this.tpAllgemein.Controls.Add(this.txtErstelltVon);
            this.tpAllgemein.Controls.Add(this.txtErstelltAm);
            this.tpAllgemein.Controls.Add(this.txtGroesse);
            this.tpAllgemein.Controls.Add(this.Label11);
            this.tpAllgemein.Controls.Add(this.Label10);
            this.tpAllgemein.Controls.Add(this.Label9);
            this.tpAllgemein.Controls.Add(this.Label8);
            this.tpAllgemein.Controls.Add(this.Label7);
            this.tpAllgemein.Controls.Add(this.Label6);
            this.tpAllgemein.Controls.Add(this.Label5);
            this.tpAllgemein.Controls.Add(this.PictureBox);
            this.tpAllgemein.Location = new System.Drawing.Point(4, 22);
            this.tpAllgemein.Name = "tpAllgemein";
            this.tpAllgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tpAllgemein.Size = new System.Drawing.Size(372, 363);
            this.tpAllgemein.TabIndex = 0;
            this.tpAllgemein.Text = "General";
            this.tpAllgemein.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(94, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 13);
            this.txtName.TabIndex = 42;
            this.txtName.Text = "Report Name";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(95, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 13);
            this.txtID.TabIndex = 41;
            this.txtID.Text = "OBJECT ID";
            // 
            // cbVersteckt
            // 
            this.cbVersteckt.AutoSize = true;
            this.cbVersteckt.Enabled = false;
            this.cbVersteckt.Location = new System.Drawing.Point(97, 335);
            this.cbVersteckt.Name = "cbVersteckt";
            this.cbVersteckt.Size = new System.Drawing.Size(60, 17);
            this.cbVersteckt.TabIndex = 40;
            this.cbVersteckt.Text = "Hidden";
            this.cbVersteckt.UseVisualStyleBackColor = true;
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(97, 203);
            this.txtBeschreibung.Multiline = true;
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBeschreibung.Size = new System.Drawing.Size(269, 121);
            this.txtBeschreibung.TabIndex = 39;
            // 
            // txtGeaendertVon
            // 
            this.txtGeaendertVon.AutoSize = true;
            this.txtGeaendertVon.Location = new System.Drawing.Point(96, 180);
            this.txtGeaendertVon.Name = "txtGeaendertVon";
            this.txtGeaendertVon.Size = new System.Drawing.Size(0, 13);
            this.txtGeaendertVon.TabIndex = 38;
            // 
            // txtGeaendertAm
            // 
            this.txtGeaendertAm.AutoSize = true;
            this.txtGeaendertAm.Location = new System.Drawing.Point(96, 159);
            this.txtGeaendertAm.Name = "txtGeaendertAm";
            this.txtGeaendertAm.Size = new System.Drawing.Size(0, 13);
            this.txtGeaendertAm.TabIndex = 37;
            // 
            // txtErstelltVon
            // 
            this.txtErstelltVon.AutoSize = true;
            this.txtErstelltVon.Location = new System.Drawing.Point(96, 138);
            this.txtErstelltVon.Name = "txtErstelltVon";
            this.txtErstelltVon.Size = new System.Drawing.Size(0, 13);
            this.txtErstelltVon.TabIndex = 36;
            // 
            // txtErstelltAm
            // 
            this.txtErstelltAm.AutoSize = true;
            this.txtErstelltAm.Location = new System.Drawing.Point(96, 117);
            this.txtErstelltAm.Name = "txtErstelltAm";
            this.txtErstelltAm.Size = new System.Drawing.Size(0, 13);
            this.txtErstelltAm.TabIndex = 35;
            // 
            // txtGroesse
            // 
            this.txtGroesse.AutoSize = true;
            this.txtGroesse.Location = new System.Drawing.Point(96, 96);
            this.txtGroesse.Name = "txtGroesse";
            this.txtGroesse.Size = new System.Drawing.Size(0, 13);
            this.txtGroesse.TabIndex = 34;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(4, 335);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(49, 13);
            this.Label11.TabIndex = 32;
            this.Label11.Text = "Attribute:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(4, 203);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(63, 13);
            this.Label10.TabIndex = 31;
            this.Label10.Text = "Description:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(4, 180);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 13);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Modified by:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(4, 159);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(65, 13);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Modified on:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(4, 138);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(61, 13);
            this.Label7.TabIndex = 28;
            this.Label7.Text = "Created by:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(4, 117);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(62, 13);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Created on:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(4, 96);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(30, 13);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Size:";
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::SSISComponents.ReportGenerator.Properties.Resources.Export;
            this.PictureBox.Location = new System.Drawing.Point(4, 11);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(61, 57);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 23;
            this.PictureBox.TabStop = false;
            // 
            // tpSicherheit
            // 
            this.tpSicherheit.Controls.Add(this.lvSecurity);
            this.tpSicherheit.Location = new System.Drawing.Point(4, 22);
            this.tpSicherheit.Name = "tpSicherheit";
            this.tpSicherheit.Padding = new System.Windows.Forms.Padding(3);
            this.tpSicherheit.Size = new System.Drawing.Size(372, 363);
            this.tpSicherheit.TabIndex = 1;
            this.tpSicherheit.Text = "Security";
            this.tpSicherheit.UseVisualStyleBackColor = true;
            // 
            // lvSecurity
            // 
            this.lvSecurity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Benutzername});
            this.lvSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSecurity.Location = new System.Drawing.Point(3, 3);
            this.lvSecurity.Name = "lvSecurity";
            this.lvSecurity.Size = new System.Drawing.Size(366, 357);
            this.lvSecurity.SmallImageList = this.ilEigenschaften;
            this.lvSecurity.TabIndex = 5;
            this.lvSecurity.UseCompatibleStateImageBehavior = false;
            this.lvSecurity.View = System.Windows.Forms.View.Details;
            // 
            // Benutzername
            // 
            this.Benutzername.Text = "User";
            this.Benutzername.Width = 348;
            // 
            // ilEigenschaften
            // 
            this.ilEigenschaften.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilEigenschaften.ImageStream")));
            this.ilEigenschaften.TransparentColor = System.Drawing.Color.Transparent;
            this.ilEigenschaften.Images.SetKeyName(0, "User");
            this.ilEigenschaften.Images.SetKeyName(1, "DBRole");
            this.ilEigenschaften.Images.SetKeyName(2, "Snapshot");
            this.ilEigenschaften.Images.SetKeyName(3, "Database");
            this.ilEigenschaften.Images.SetKeyName(4, "Parameter");
            this.ilEigenschaften.Images.SetKeyName(5, "Property");
            // 
            // tpSnapshots
            // 
            this.tpSnapshots.Controls.Add(this.Button4);
            this.tpSnapshots.Controls.Add(this.Button3);
            this.tpSnapshots.Controls.Add(this.lvSnapshots);
            this.tpSnapshots.Location = new System.Drawing.Point(4, 22);
            this.tpSnapshots.Name = "tpSnapshots";
            this.tpSnapshots.Padding = new System.Windows.Forms.Padding(3);
            this.tpSnapshots.Size = new System.Drawing.Size(372, 363);
            this.tpSnapshots.TabIndex = 2;
            this.tpSnapshots.Text = "Snapshots";
            this.tpSnapshots.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(170, 334);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(104, 23);
            this.Button4.TabIndex = 8;
            this.Button4.Text = "New Snapshot";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(280, 334);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(86, 23);
            this.Button3.TabIndex = 7;
            this.Button3.Text = "Delete";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lvSnapshots
            // 
            this.lvSnapshots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDatum,
            this.cSize,
            this.cID});
            this.lvSnapshots.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvSnapshots.Location = new System.Drawing.Point(3, 3);
            this.lvSnapshots.Name = "lvSnapshots";
            this.lvSnapshots.Size = new System.Drawing.Size(366, 325);
            this.lvSnapshots.SmallImageList = this.ilEigenschaften;
            this.lvSnapshots.TabIndex = 6;
            this.lvSnapshots.UseCompatibleStateImageBehavior = false;
            this.lvSnapshots.View = System.Windows.Forms.View.Details;
            // 
            // cDatum
            // 
            this.cDatum.Text = "Date";
            this.cDatum.Width = 134;
            // 
            // cSize
            // 
            this.cSize.Text = "Size";
            this.cSize.Width = 79;
            // 
            // cID
            // 
            this.cID.Text = "Snapshot ID";
            this.cID.Width = 140;
            // 
            // tpDataSource
            // 
            this.tpDataSource.Controls.Add(this.lvDataSource);
            this.tpDataSource.Location = new System.Drawing.Point(4, 22);
            this.tpDataSource.Name = "tpDataSource";
            this.tpDataSource.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataSource.Size = new System.Drawing.Size(372, 363);
            this.tpDataSource.TabIndex = 3;
            this.tpDataSource.Text = "DataSource";
            this.tpDataSource.UseVisualStyleBackColor = true;
            // 
            // lvDataSource
            // 
            this.lvDataSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chReference});
            this.lvDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDataSource.Location = new System.Drawing.Point(3, 3);
            this.lvDataSource.Name = "lvDataSource";
            this.lvDataSource.Size = new System.Drawing.Size(366, 357);
            this.lvDataSource.SmallImageList = this.ilEigenschaften;
            this.lvDataSource.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvDataSource.TabIndex = 9;
            this.lvDataSource.UseCompatibleStateImageBehavior = false;
            this.lvDataSource.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 169;
            // 
            // chReference
            // 
            this.chReference.Text = "Reference";
            this.chReference.Width = 183;
            // 
            // tpParameter
            // 
            this.tpParameter.Controls.Add(this.lvParameter);
            this.tpParameter.Location = new System.Drawing.Point(4, 22);
            this.tpParameter.Name = "tpParameter";
            this.tpParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tpParameter.Size = new System.Drawing.Size(372, 363);
            this.tpParameter.TabIndex = 4;
            this.tpParameter.Text = "Parameter";
            this.tpParameter.UseVisualStyleBackColor = true;
            // 
            // lvParameter
            // 
            this.lvParameter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.chType,
            this.cNullable,
            this.cState});
            this.lvParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvParameter.Location = new System.Drawing.Point(3, 3);
            this.lvParameter.Name = "lvParameter";
            this.lvParameter.Size = new System.Drawing.Size(366, 357);
            this.lvParameter.SmallImageList = this.ilEigenschaften;
            this.lvParameter.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvParameter.TabIndex = 9;
            this.lvParameter.UseCompatibleStateImageBehavior = false;
            this.lvParameter.View = System.Windows.Forms.View.Details;
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 102;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 95;
            // 
            // cNullable
            // 
            this.cNullable.Text = "Nullable";
            this.cNullable.Width = 97;
            // 
            // cState
            // 
            this.cState.Text = "State";
            this.cState.Width = 61;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(317, 407);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ReportProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 441);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 480);
            this.MinimumSize = new System.Drawing.Size(420, 480);
            this.Name = "ReportProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Properties";
            this.Load += new System.EventHandler(this.ReportProperties_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAllgemein.ResumeLayout(false);
            this.tpAllgemein.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.tpSicherheit.ResumeLayout(false);
            this.tpSnapshots.ResumeLayout(false);
            this.tpDataSource.ResumeLayout(false);
            this.tpParameter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAllgemein;
        private System.Windows.Forms.TabPage tpSicherheit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabPage tpSnapshots;
        private System.Windows.Forms.TabPage tpDataSource;
        private System.Windows.Forms.TabPage tpParameter;
        internal System.Windows.Forms.Label txtID;
        internal System.Windows.Forms.CheckBox cbVersteckt;
        internal System.Windows.Forms.TextBox txtBeschreibung;
        internal System.Windows.Forms.Label txtGeaendertVon;
        internal System.Windows.Forms.Label txtGeaendertAm;
        internal System.Windows.Forms.Label txtErstelltVon;
        internal System.Windows.Forms.Label txtErstelltAm;
        internal System.Windows.Forms.Label txtGroesse;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.PictureBox PictureBox;
        internal System.Windows.Forms.ListView lvSecurity;
        internal System.Windows.Forms.ColumnHeader Benutzername;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.ListView lvSnapshots;
        internal System.Windows.Forms.ColumnHeader cDatum;
        internal System.Windows.Forms.ColumnHeader cSize;
        internal System.Windows.Forms.ColumnHeader cID;
        internal System.Windows.Forms.ListView lvDataSource;
        internal System.Windows.Forms.ColumnHeader chName;
        internal System.Windows.Forms.ColumnHeader chReference;
        internal System.Windows.Forms.ListView lvParameter;
        internal System.Windows.Forms.ColumnHeader cName;
        internal System.Windows.Forms.ColumnHeader chType;
        internal System.Windows.Forms.ColumnHeader cNullable;
        internal System.Windows.Forms.ColumnHeader cState;
        private System.Windows.Forms.Label txtName;
        internal System.Windows.Forms.ImageList ilEigenschaften;
    }
}