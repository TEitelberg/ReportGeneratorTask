using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SSISComponents.ReportGenerator
{
    public partial class ReportViewerUi : Form
    {
        public string ReportType { private get; set; }

        public ReportParameter[] Reportparameter { private get; set; }

        public string Reportserver { private get; set; }

        public string Username { private get; set; }

        public string Domain { private get; set; }

        public string Password { private get; set; }

        public bool WindowsAuthorization { private get; set; }

        public string Reportname { private get; set; }

        public string Datasetname { private get; set; }

        public DataTable Data { private get; set; }

        public ReportViewerUi()
        {
            WindowsAuthorization = true;
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ReportType))
            {
                ReportType = "Dataset Report";
            }

            if (ReportType == "Dataset Report")
            {
                try
                {
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportPath = Reportname;
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Datasetname, Data));
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    reportViewer1.ProcessingMode = ProcessingMode.Remote;
                    var serverReport = reportViewer1.ServerReport;
                    
                    // Get a reference to the default credentials
                    var credentials = System.Net.CredentialCache.DefaultCredentials;
                                     
                    
                    // Get a reference to the report server credentials
                    var rsCredentials = serverReport.ReportServerCredentials;

                    // Set the credentials for the server report
                    rsCredentials.NetworkCredentials = credentials;

                    if (WindowsAuthorization)
                    {
                        reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = System.Net.CredentialCache.DefaultCredentials;
                    }
                    else
                    {
                        reportViewer1.ServerReport.ReportServerCredentials.SetFormsCredentials(null, Username, Password, Domain);
                    }


                    // Set the report server URL and report path
                    serverReport.ReportServerUrl = new Uri(Reportserver);
                    serverReport.ReportPath = Reportname;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                // Set the report parameters for the report
                if (Reportparameter != null)
                {
                    reportViewer1.ServerReport.SetParameters(Reportparameter);
                }

                // Refresh the report
                try
                {
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
