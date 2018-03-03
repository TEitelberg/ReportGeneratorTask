using System;
using System.Windows.Forms;
using System.Net;
using SSISComponents.ReportGenerator.Properties;
using SSISComponents.ReportGenerator.ReportService2010;

namespace SSISComponents.ReportGenerator
{
    public partial class ReportServerUi : Form
    {
        ReportingService2010 _rs;
        private Boolean _isSharepoint;

        /// <summary>
        /// 
        /// </summary>
        public string Reportname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ReportServer { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Username { private get; set; }

        public string Domain { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool WindowsAuthorization { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ReportServerUi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tvReportServer.SelectedNode != null)
            {
                var item = (CatalogItem)tvReportServer.SelectedNode.Tag;
                if (item.TypeName == "Report")
                {
                    Reportname = item.Path;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(Resources.Please_select_a_Report_);
                }
            }
            else
            {
                MessageBox.Show(Resources.Please_select_a_Report_);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportServer_Load(object sender, EventArgs e)
        {
            _rs = new ReportingService2010 {Url = ReportServer + "/ReportService2010.asmx"};

            if (WindowsAuthorization)
            {
                _rs.Credentials = CredentialCache.DefaultCredentials;
            }
            else
            {
                _rs.CookieContainer = new CookieContainer();
                _rs.LogonUser(Username, Password, ReportServer);
            }

            tvReportServer.BeginUpdate();
            tvReportServer.Nodes.Clear();

            tvReportServer.Nodes.Add(GetFolderAsNodes());
            tvReportServer.ExpandAll();

            tvReportServer.EndUpdate();
            
        }

        /// <summary>
        /// build root element and load folders and reports
        /// </summary>
        /// <returns></returns>
        private TreeNode GetFolderAsNodes()
        {
            var xRoot = new TreeNode(ReportServer) {Tag = _rs.Url, ImageIndex = 2};
            return (FillTreeView("/", xRoot));
        }

        /// <summary>
        /// get all folders and reports as nodes
        /// </summary>
        /// <param name="path"></param>
        /// <param name="parentNode"></param>
        /// <returns></returns>
        private TreeNode FillTreeView(string path, TreeNode parentNode)
        {
            try
            {
                var cItems = _rs.ListChildren(path, false);
                foreach (var item in cItems)
                {
                    switch (item.TypeName)
                    {
                        case "Folder":
                            var subNode = new TreeNode(item.Name) {ImageIndex = 1, Tag = item, Name = item.Path};
                            subNode.SelectedImageIndex = subNode.ImageIndex;
                            parentNode.Nodes.Add(FillTreeView(item.Path, subNode));
                            break;
                        case "Site":
                            _isSharepoint = true;
                            var siteNode = new TreeNode(item.Name) {ImageIndex = 1, Tag = item, Name = item.Path};
                            siteNode.SelectedImageIndex = siteNode.ImageIndex;
                            parentNode.Nodes.Add(FillTreeView(item.Path, siteNode));
                            break;
                        case "Report":
                            var reportNode = new TreeNode(item.Name) {ImageIndex = 0, Tag = item, Name = item.Path};
                            reportNode.SelectedImageIndex = reportNode.ImageIndex;
                            parentNode.Nodes.Add(reportNode);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                if (!_isSharepoint)
                {
                    MessageBox.Show(ex.ToString(), Resources.ReportGeneratorTask_, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return parentNode;
        }

        /// <summary>
        /// Set the selected report as current report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvReportServer_AfterSelect(object sender, EventArgs e)
        {
            var item = (CatalogItem)tvReportServer.SelectedNode.Tag;
            if (item.TypeName != "Report") return;
            Reportname = item.Path;
            DialogResult = DialogResult.OK;
        }

        private void previewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (CatalogItem)tvReportServer.SelectedNode.Tag;
            if (item != null)
            {
                if (item.TypeName != "Report") return;
                var localReport = new ReportViewerUi
                {
                    Reportserver = ReportServer,
                    ReportType = "SQL Server Report",
                    Reportname = item.Path,
                    WindowsAuthorization = WindowsAuthorization,
                    Username = Username,
                    Password = Password,
                    Domain = Domain
                };
                localReport.ShowDialog();
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (CatalogItem)tvReportServer.SelectedNode.Tag;
                if (item != null)
                {
                    if (item.TypeName != "Report") return;
                    var repProperties = new ReportProperties
                    {
                        Item = item,
                        ReportServer = ReportServer,
                        Reportname = Reportname,
                        Username = Username,
                        Password = Password,
                        Domain = Domain,
                        WindowsAuthorization = WindowsAuthorization
                    };
                    repProperties.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.An_unknown_error_has_occurred_, Resources.ReportGeneratorTask_);
            }
        }

        private void tvReportServer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvReportServer.SelectedNode = e.Node;
        }
        
    }
}
