using System;
using System.Windows.Forms;
using SSISComponents.ReportGenerator.Properties;
using SSISComponents.ReportGenerator.ReportService2010;
using Microsoft.VisualBasic;
using System.Net;

namespace SSISComponents.ReportGenerator
{
    public partial class ReportProperties : Form
    {
        ReportingService2010 _rs;

        /// <summary>
        /// 
        /// </summary>
        public CatalogItem Item { private get; set; }

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

        /// <summary>
        /// 
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool WindowsAuthorization { get; set; }

        public ReportProperties()
        {
            WindowsAuthorization = false;
            Password = null;
            Domain = null;
            Username = null;
            ReportServer = null;
            Reportname = null;
            Item = null;
            InitializeComponent();
        }

        private void ReportProperties_Load(object sender, EventArgs e)
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

            txtErstelltVon.Text = IsNull(Item.CreatedBy);
            txtErstelltAm.Text = IsNull(Item.CreationDate);
            txtBeschreibung.Text = IsNull(Item.Description);
            txtID.Text = @"{" + IsNull(Item.ID) + @"}";
            txtGeaendertVon.Text = IsNull(Item.ModifiedBy);
            txtGeaendertAm.Text = IsNull(Item.ModifiedDate);
            txtName.Text = IsNull(Item.Name);
            //txtOrt.Text = IsNull(_Item.Path);
            cbVersteckt.Checked = IsNull(Item.Hidden) == "True";

            if (Information.IsNumeric(IsNull(Item.Size)))
            {
                txtGroesse.Text = Strings.FormatNumber((Item.Size / 1024), 2) + @" KB";
            }
            else
            {
                txtGroesse.Text = IsNull(Item.Size);
            }

            switch (Item.TypeName)
            {
                case "Folder":
                    tabControl1.TabPages.Remove(tabControl1.TabPages["tpSnapshots"]);
                    tabControl1.TabPages.Remove(tabControl1.TabPages["tpDatasource"]);
                    tabControl1.TabPages.Remove(tabControl1.TabPages["tpParameter"]);
                    tabControl1.TabPages.Remove(tabControl1.TabPages["tpSicherheit"]);
                    break;
                case "Report":
                    FillSecurity();
                    FillParameter();
                    FillDataSource();
                    FillSnapshots();
                    break;
                case "DataSource":
                    break;
                case "LinkedReport":
                    break;
                case "Model":
                    break;
                case "Resource":
                    break;
                case "Unknown":
                    break;
            }
        }

        /// <summary>
        /// get report data source
        /// </summary>
        private void FillDataSource()
        {
            try
            {
                lvDataSource.Items.Clear();
                //string[] strPermissions = rs.GetPermissions(_Item.Path.ToString());
                var ds = _rs.GetItemDataSources(Item.Path);
                foreach (var t in ds)
                {
                    var dsref = (DataSourceReference)t.Item;
                    var li = new ListViewItem {Text = t.Name, Tag = t};
                    li.SubItems.Add(dsref.Reference);
                    li.ImageKey = @"Database";
                    lvDataSource.Items.Add(li);
                }
            }
            catch(Exception ex) { }
        }

        /// <summary>
        /// get report parameter
        /// </summary>
        private void FillParameter()
        {
            try
            {
                var parameter = _rs.GetItemParameters(Item.Path, null, false, null, null);
                foreach (var t in parameter)
                {
                    var li = new ListViewItem {Name = t.Name, Text = t.Name};
                    li.SubItems.Add(t.ParameterTypeName);
                    li.SubItems.Add(t.Nullable.ToString());
                    li.SubItems.Add(t.ParameterStateName);
                    li.ImageKey = @"Parameter";
                    lvParameter.Items.Add(li);
                }
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// get security information
        /// </summary>
        private void FillSecurity()
        {
            try
            {
                bool wahr;
                lvSecurity.Items.Clear();
                //string[] strPermissions = rs.GetPermissions(_Item.Path);
                var policies = _rs.GetPolicies(Item.Path, out wahr);
                foreach (var t in policies)
                {
                    var li = new ListViewItem
                    {
                        Name = t.GroupUserName,
                        Text = t.GroupUserName,
                        ImageKey = @"User"
                    };
                    lvSecurity.Items.Add(li);
                }
            }
            catch { }
        }

        private void FillSnapshots()
        {
            lvSnapshots.Items.Clear();
            if (_rs.ListItemHistory(Item.Path).Length > 0)
            {
                foreach (var x in _rs.ListItemHistory(Item.Path))
	            {
		            var li = new ListViewItem {Text = x.CreationDate.ToLongDateString(), Tag = x};
	                li.SubItems.Add(Strings.FormatNumber((x.Size / 1024), 2) + " KB");
                    li.SubItems.Add(x.HistoryID);
                    li.ImageKey = @"Snapshot";
                    lvSnapshots.Items.Add(li);
	            }    
            }
            else 
            {
                lvSnapshots.Items.Add("No Snapshots available.");
            }
        }
        
        private static string IsNull(Object value) 
        {
            string returnValue;
            try
            {
                returnValue = !String.IsNullOrEmpty(value.ToString()) ? value.ToString() : "n/a";
            }
            catch (Exception ex)
            {
                returnValue = "n/a";
            }
            return returnValue;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Warning[] warn;
                _rs.CreateItemHistorySnapshot(Item.Path, out warn);
                FillSnapshots();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.The_report_snapsoht_could_not_been_created_, Resources.ReportGeneratorTask_, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem n in lvSnapshots.SelectedItems)
                {
                    var x = (ItemHistorySnapshot)n.Tag;
                    _rs.DeleteItemHistorySnapshot(Item.Path, x.HistoryID);
                }
                FillSnapshots();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
