using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace datenfabrik.ReportGenerator
{
    public partial class ReportViewer : Form
    {

        private string _Reportname = null;
        private DataTable _Data = null;
        private string _Datasetname = null;
        private string _Reportserver = null;
        private bool _WindowsAuthorization = true;
        private string _Username = null;
        private string _Password = null;
        private string _ReportType = null;

        public string ReportType
        {
            get { return this._ReportType; }
            set { this._ReportType = value; }
        }

        public string Reportserver
        {
            get { return this._Reportserver; }
            set { this._Reportserver = value; }
        }

        public string Username
        {
            get { return this._Username; }
            set { this._Username = value; }
        }

        public string Password
        {
            get { return this._Password; }
            set { this._Password = value; }
        }

        public bool WindowsAuthorization
        {
            get { return this._WindowsAuthorization; }
            set { this._WindowsAuthorization = value; }
        }

        public string Reportname
        {
            get { return this._Reportname; }
            set { this._Reportname = value; }
        }

        public string Datasetname
        {
            get { return this._Datasetname; }
            set { this._Datasetname = value; }
        }

        public DataTable Data
        {
            get { return this._Data; }
            set { this._Data = value; }
        }

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (ReportType == "Dataset Report")
            {
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = Reportname;
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Datasetname, Data));
                this.reportViewer1.RefreshReport();
            }
            else
            {
                reportViewer1.ProcessingMode = ProcessingMode.Remote;
                ServerReport serverReport = reportViewer1.ServerReport;
                
                // Get a reference to the default credentials
                System.Net.ICredentials credentials = System.Net.CredentialCache.DefaultCredentials;

                // Get a reference to the report server credentials
                ReportServerCredentials rsCredentials = serverReport.ReportServerCredentials;

                // Set the credentials for the server report
                rsCredentials.NetworkCredentials = credentials;

                // Set the report server URL and report path
                serverReport.ReportServerUrl = new Uri(Reportserver);
                serverReport.ReportPath = Reportname;

                // Create the sales order number report parameter
                //ReportParameter salesOrderNumber = new ReportParameter();
                //salesOrderNumber.Name = "SalesOrderNumber";
                //salesOrderNumber.Values.Add("SO43661");

                // Set the report parameters for the report
                //reportViewer1.ServerReport.SetParameters( new ReportParameter[] { salesOrderNumber });

                // Refresh the report
                reportViewer1.RefreshReport();

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
