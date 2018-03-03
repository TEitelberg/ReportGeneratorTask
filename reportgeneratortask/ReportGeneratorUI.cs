using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using System.Xml;
using System.Net;
using SSISComponents.ReportGenerator.Properties;
using SSISComponents.ReportGenerator.ReportExecution2005;
using SSISComponents.ReportGenerator.ReportService2010;
using Extension = SSISComponents.ReportGenerator.ReportExecution2005.Extension;

namespace SSISComponents.ReportGenerator
{
    public partial class ReportGeneratorUi : Form
    {
       
        #region Private Variables
        
        private readonly TaskHost _taskHost;
        private readonly RenderExtensions _renderExtensions;
        
        private string _recordset;
        private string _reportType = "SQL Server Report";
        private string _prefixFilename;
        private DataTable _variable;
        private DataTable _reportparameter;
        private string _param;
        private Boolean _snapshot;


        private string Username
        {
            get { return txtUsername.Text; }
        }

        private string Password
        {
            get { return txtPassword.Text; }
        }

        private bool WindowsAuthorization
        {
            get { return cbWindowsAuthorization.Checked ; }
        }

        private Connections Connections { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskHost"></param>
        /// <param name="connections"></param>
        public ReportGeneratorUi(TaskHost taskHost, Connections connections)
        {
            InitializeComponent();
            _taskHost = taskHost;
            Connections = connections;
            _renderExtensions = new RenderExtensions();
        }
        #endregion

        #region Form Event Handlers
       
        /// <summary>
        /// set all task properties to local vaariables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportGeneratorUI_Load(object sender, EventArgs e)
        {
            //dgvReportParameter.VirtualMode = true;
            BuildDataTable();
           
            _prefixFilename = _taskHost.Properties["PrefixFilename"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["PrefixFilename"].GetValue(_taskHost).ToString();
            _snapshot = _taskHost.Properties["Snapshot"].GetValue(_taskHost) != null && (bool)_taskHost.Properties["Snapshot"].GetValue(_taskHost);
            _recordset = _taskHost.Properties["Recordset"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Recordset"].GetValue(_taskHost).ToString();

            cbWindowsAuthorization.Checked = _taskHost.Properties["WindowsAuthorization"].GetValue(_taskHost) == null || (bool)_taskHost.Properties["WindowsAuthorization"].GetValue(_taskHost);
            txtReports.Text = _taskHost.Properties["Reportname"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Reportname"].GetValue(_taskHost).ToString();
            txtDatasetname.Text = _taskHost.Properties["Datasetname"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Datasetname"].GetValue(_taskHost).ToString();
            txtLocation.Text = _taskHost.Properties["Filename"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Filename"].GetValue(_taskHost).ToString();
            cbAddPrefix.Checked = _taskHost.Properties["Prefix"].GetValue(_taskHost) != null && (bool)_taskHost.Properties["Prefix"].GetValue(_taskHost);
            cbShowInDebug.Checked = _taskHost.Properties["DebugMode"].GetValue(_taskHost) != null && (bool)_taskHost.Properties["DebugMode"].GetValue(_taskHost);
            txtReportServer.Text = _taskHost.Properties["ReportServer"].GetValue(_taskHost) == null ? @"http://localhost/reportserver" : _taskHost.Properties["ReportServer"].GetValue(_taskHost).ToString();
            _reportType = _taskHost.Properties["ReportType"].GetValue(_taskHost) == null ? "SQL Server Report" : _taskHost.Properties["ReportType"].GetValue(_taskHost).ToString();
            txtUsername.Text = _taskHost.Properties["Username"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Username"].GetValue(_taskHost).ToString();
            txtDomain.Text = _taskHost.Properties["Domain"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Domain"].GetValue(_taskHost).ToString();
            txtPassword.Text = _taskHost.Properties["Password"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Password"].GetValue(_taskHost).ToString();

            var reportparameterObjectValue = _taskHost.Properties["Reportparameter"].GetValue(_taskHost);
            if (reportparameterObjectValue != null)
            {
                _reportparameter = ReportGenerator.GetParameterDataTable(reportparameterObjectValue.ToString());
            }

            cbReportType.SelectedItem = _reportType;

            cbxPrefixFilename.BeginUpdate();

            AddVariableToRow("Choose a Variable");

            //foreach (var var in _taskHost.Variables.Cast<Variable>().Where(var => !var.ReadOnly))
            foreach (var var in _taskHost.Variables)
            {
                if (!var.ReadOnly)
                {
                    cbxPrefixFilename.Items.Add(var.QualifiedName);
                    AddVariableToRow(var.QualifiedName);
                }
            }

            cbExpirationDateTime.DataSource = _variable.Copy();
            cbExpirationDateTime.ValueMember = "Variable";
            cbExpirationDateTime.DisplayMember = "Variable";
            cbExpirationDateTime.SelectedValue = _taskHost.Properties["ExpirationDateTime"].GetValue(_taskHost) == null ? "Choose a Variable" : _taskHost.Properties["ExpirationDateTime"].GetValue(_taskHost).ToString();

            cbExecutionDateTime.DataSource = _variable.Copy();
            cbExecutionDateTime.ValueMember = "Variable";
            cbExecutionDateTime.DisplayMember = "Variable";
            cbExecutionDateTime.SelectedValue = _taskHost.Properties["ExecutionDateTime"].GetValue(_taskHost) == null ? "Choose a Variable" : _taskHost.Properties["ExecutionDateTime"].GetValue(_taskHost).ToString();

            cbExecutionId.DataSource = _variable.Copy();
            cbExecutionId.ValueMember = "Variable";
            cbExecutionId.DisplayMember = "Variable";
            cbExecutionId.SelectedValue = _taskHost.Properties["ExecutionId"].GetValue(_taskHost) == null ? "Choose a Variable" : _taskHost.Properties["ExecutionId"].GetValue(_taskHost).ToString();

            cbHistoryId.DataSource = _variable.Copy();
            cbHistoryId.ValueMember = "Variable";
            cbHistoryId.DisplayMember = "Variable";
            cbHistoryId.SelectedValue = _taskHost.Properties["HistoryId"].GetValue(_taskHost) == null ? "Choose a Variable" : _taskHost.Properties["HistoryId"].GetValue(_taskHost).ToString();

            cbNumPages.DataSource = _variable.Copy();
            cbNumPages.ValueMember = "Variable";
            cbNumPages.DisplayMember = "Variable";
            cbNumPages.SelectedValue = _taskHost.Properties["NumPages"].GetValue(_taskHost) == null ? "Choose a Variable" : _taskHost.Properties["NumPages"].GetValue(_taskHost).ToString();

            numTimeOut.Value = _taskHost.Properties["TimeOut"].GetValue(_taskHost) == null ? 30000 : Convert.ToInt32(_taskHost.Properties["TimeOut"].GetValue(_taskHost));


            if (_reportparameter != null)
            {
                SetParameter(_reportparameter);
            }
            
            //Set the selected variable
            if (_prefixFilename != null)
            {
                cbxPrefixFilename.SelectedItem = _prefixFilename;
            }

            cbxPrefixFilename.EndUpdate();

            cbxRecordset.BeginUpdate();

            //foreach (var var in _taskHost.Variables.Cast<Variable>().Where(var => !var.ReadOnly))
            foreach (var var in _taskHost.Variables)
            {
                if (!var.ReadOnly)
                {
                    cbxRecordset.Items.Add(var.QualifiedName);
                }
            }

            if (_recordset != null)
            {
                cbxRecordset.SelectedItem = _recordset;
            }



            cbxRecordset.EndUpdate();
            
            ChangeUi();
            //AddComboBoxColumns();
        }

        #endregion

        #region Control Event Handlers
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLocation.Text))
            {
                var fi = new FileInfo(txtLocation.Text);

                if (fi.DirectoryName != null && !Directory.Exists(fi.DirectoryName))
                {
                    MessageBox.Show(Resources.The_specified_report_folder_does_not_exist_,
                        Resources.ReportGeneratorTask_, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    try
                    {
                        _taskHost.Properties["Recordset"].SetValue(_taskHost, cbxRecordset.SelectedItem.ToString());
                    }
                    catch
                    {
                        _taskHost.Properties["Recordset"].SetValue(_taskHost, null);
                    }

                    try
                    {
                        _taskHost.Properties["PrefixFilename"].SetValue(_taskHost,
                            cbxPrefixFilename.SelectedItem.ToString());
                    }
                    catch
                    {
                        _taskHost.Properties["PrefixFilename"].SetValue(_taskHost, null);
                    }

                    try
                    {
                        //_Param = ReportGenerator.SerializeObject(GetDataTable());
                        _param = ReportGenerator.GetParameterString(GetDataTable());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        _param = null;
                    }
                }


                _taskHost.Properties["TimeOut"].SetValue(_taskHost, Convert.ToInt32(numTimeOut.Value));

                _taskHost.Properties["ExecutionDateTime"].SetValue(_taskHost, cbExecutionDateTime.SelectedValue);
                _taskHost.Properties["ExpirationDateTime"].SetValue(_taskHost, cbExpirationDateTime.SelectedValue);
                _taskHost.Properties["ExecutionId"].SetValue(_taskHost, cbExecutionId.SelectedValue);
                _taskHost.Properties["HistoryId"].SetValue(_taskHost, cbHistoryId.SelectedValue);
                _taskHost.Properties["NumPages"].SetValue(_taskHost, cbNumPages.SelectedValue);

                _taskHost.Properties["Reportparameter"].SetValue(_taskHost, _param);
                _taskHost.Properties["Reportname"].SetValue(_taskHost, txtReports.Text);
                _taskHost.Properties["Filename"].SetValue(_taskHost, txtLocation.Text);
                _taskHost.Properties["Datasetname"].SetValue(_taskHost, txtDatasetname.Text);
                _taskHost.Properties["Prefix"].SetValue(_taskHost, cbAddPrefix.Checked);
                _taskHost.Properties["DebugMode"].SetValue(_taskHost, cbShowInDebug.Checked);
                _taskHost.Properties["Snapshot"].SetValue(_taskHost, cbSnapshot.Checked);
                _taskHost.Properties["ReportType"].SetValue(_taskHost, cbReportType.Items[cbReportType.SelectedIndex].ToString());
                _taskHost.Properties["ReportServer"].SetValue(_taskHost, txtReportServer.Text);
                _taskHost.Properties["Username"].SetValue(_taskHost, txtUsername.Text);
                _taskHost.Properties["Domain"].SetValue(_taskHost, txtDomain.Text);
                _taskHost.Properties["Password"].SetValue(_taskHost, txtPassword.Text);
                _taskHost.Properties["WindowsAuthorization"].SetValue(_taskHost, cbWindowsAuthorization.Checked);
                DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show(Resources.There_was_no_filename_specified_, Resources.ReportGeneratorTask_, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private void btnReports_Click_1(object sender, EventArgs e)
        {
            if (_reportType == "Dataset Report")
            {
                if (ofdReport.ShowDialog() == DialogResult.OK)
                {
                    txtReports.Text = ofdReport.FileName;
                    GetDataSet();
                }
            }
            else 
            {
                if (txtReportServer.Text != null)
                {
                    if (cbWindowsAuthorization.Checked == false &&
                        (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text)))
                    {
                        MessageBox.Show(Resources.Please_provide_a_password_and_or_username_);
                    }
                    else
                    {
                        try
                        {
                            var frmReportServer = new ReportServerUi
                            {
                                Username = txtUsername.Text,
                                Password = txtPassword.Text,
                                Domain = txtDomain.Text,
                                WindowsAuthorization = cbWindowsAuthorization.Checked,
                                Reportname = txtReports.Text,
                                ReportServer = txtReportServer.Text
                            };

                            if (frmReportServer.ShowDialog() != DialogResult.OK) return;
                            txtReports.Text = frmReportServer.Reportname;
                            GetReportParameter();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Resources.The_report_server_could_not_be_reached__Exception__ + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Resources.Please_define_a_ReportServer);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Click_1(object sender, EventArgs e)
        {
            // Always retrieve the Extensions again, because the report server can be changed!

            var rs = new ReportExecutionService {Url = txtReportServer.Text + "/ReportExecution2005.asmx"};
            if (WindowsAuthorization)
            {
                rs.Credentials = CredentialCache.DefaultCredentials;
            }
            else
            {
                rs.CookieContainer = new CookieContainer();
                rs.LogonUser(Username, Password, txtReportServer.Text);
            }
            

            Extension[] extensions;
            // Retrieve a list of all renderingextensions. 
            extensions = rs.ListRenderingExtensions();

            if (extensions != null)
            {
                var filter = "";
                foreach (var extension in extensions)
                {
                    // only add supporter extensions
                    if (!_renderExtensions.Contains(extension.Name)) continue;
                    var supportedExtension = (RenderExtension)_renderExtensions[extension.Name];
                    //build filter like: Acrobat (*.pdf)|*.pdf|Microsoft Excel (*.xls)|*.xls
                    if (filter.Length > 0) filter += "|";
                    filter += supportedExtension.FullName + " (" + supportedExtension.Extension + ")|" + supportedExtension.Extension;
                }
                sfdReport.Filter = filter;
            }
            if (sfdReport.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = sfdReport.FileName;
            }
        }

        #endregion

        #region UI Link

        /// <summary>
        /// open project homepage on codeplex when link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkCodeplex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TEitelberg/ReportGeneratorTask");
        }

        /// <summary>
        /// open oh22.is when link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkoh22is_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.oh22.is");
        }

        /// <summary>
        /// open sssis-components.net  when link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkSsisComponents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.ssis-components.net");
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _reportType = cbReportType.SelectedItem.ToString();
            ChangeUi();
        }

        /// <summary>
        /// changes the ui when the task execution is change between and local and server report
        /// </summary>
        private void ChangeUi()
        {
            if (_reportType == "Dataset Report")
            {
                lblRecordset.Text = Resources.Variable_;
                lblDatasetname.Enabled = true;
                txtDatasetname.Enabled = true;
                cbSnapshot.Enabled = false;
                gbAuthorization.Enabled = false;
                cbxRecordset.Visible = true;
                txtReportServer.Visible = false;
                tabControl1.TabPages["tpParameter"].IsAccessible = false;
            }
            else 
            {
                lblRecordset.Text = Resources.Reportserver_;
                lblDatasetname.Enabled = false;
                txtDatasetname.Enabled = false;
                cbSnapshot.Enabled = true;
                gbAuthorization.Enabled = true;
                cbxRecordset.Visible = false;
                txtReportServer.Visible = true;
                cbWindowsAuthorization.Checked = true;
                tabControl1.TabPages["tpParameter"].IsAccessible = true;
            }
        }

        /// <summary>
        /// enables the username and password textbox when windowsauthorizatuion check changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbWindowsAuthorization_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = !cbWindowsAuthorization.Checked;
            txtPassword.Enabled = !cbWindowsAuthorization.Checked;
            txtDomain.Enabled = !cbWindowsAuthorization.Checked;
        }

        /// <summary>
        /// enables the filename textbox when prefix is used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAddPrefix_CheckedChanged(object sender, EventArgs e)
        {
            cbxPrefixFilename.Enabled = cbAddPrefix.Checked;
        }

        /// <summary>
        /// get the dataset name from a local report
        /// </summary>
        private void GetDataSet()
        {
            try
            {  
                var doc = new XmlDocument();
                doc.Load(txtReports.Text);
                var nl1 = doc.GetElementsByTagName("DataSet");
                var xmlNode = nl1.Item(0);
                if (xmlNode == null) return;
                if (xmlNode.Attributes != null) txtDatasetname.Text = xmlNode.Attributes.Item(0).Value;
            }
            catch(Exception ex ) { }
        }

        /// <summary>
        /// Get parameters from the server report and set them to the datagrid.
        /// </summary>
        private void GetReportParameter()
        {
            try
            {
                var rs = new ReportingService2010 {Url = txtReportServer.Text + "/ReportService2010.asmx"};
                if (WindowsAuthorization)
                {
                    rs.Credentials = CredentialCache.DefaultCredentials;
                }
                else
                {
                    rs.CookieContainer = new CookieContainer();
                    rs.LogonUser(Username, Password, txtReportServer.Text);
                }
                
                var param = rs.GetItemParameters(txtReports.Text, null, false, null, null);

                dgvReportParameter.Rows.Clear();


                //foreach (var parameter in param.Where(parameter => parameter.PromptUser))
                foreach (var parameter in param)
                {
                    if (parameter.PromptUser)
                    {
                        AddRow(parameter.Name, parameter.MultiValue);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.When_you_retrieve_the_report_parameter__an_error_has_occurred__ + ex.Message);
            }
         }

        /// <summary>
        /// Add Report Parameter
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="multiValueParameter"></param>
        private void AddRow(string parameter, bool multiValueParameter)
        {
            try
            {
                var dgv = new DataGridViewRow();
                               
                var cbc = new DataGridViewComboBoxCell
                {
                    DataSource = _variable,
                    ValueMember = "Variable",
                    DisplayMember = "Variable"
                };

                dgv.Cells.Add(cbc);

                var txt = new DataGridViewTextBoxCell {Value = parameter};

                dgv.Cells.Add(txt);

                var multi = new DataGridViewCheckBoxCell {Value = multiValueParameter};

                dgv.Cells.Add(multi);

                dgvReportParameter.Rows.Add(dgv);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="value"></param>
        /// <param name="multiValueParameter"></param>
        private void AddRow(string parameter, string value, bool multiValueParameter)
        {
            try
            {
                var dgv = new DataGridViewRow();
                               
                var cbc = new DataGridViewComboBoxCell
                {
                    DataSource = _variable,
                    ValueMember = "Variable",
                    DisplayMember = "Variable"
                };

                foreach (DataRow row in _variable.Rows)
                {
                    if (row["Variable"].ToString() == value)
                    {
                        cbc.Value = value;   
                    }
                }
                                
                dgv.Cells.Add(cbc);
                var txt = new DataGridViewTextBoxCell {Value = parameter};
                dgv.Cells.Add(txt);

                var multi = new DataGridViewCheckBoxCell { Value = multiValueParameter };
                dgv.Cells.Add(multi);

                dgvReportParameter.Rows.Add(dgv);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Builds a datatable with one column
        /// </summary>
        private void BuildDataTable()
        {
            _variable = new DataTable();
            _variable.Columns.Add("Variable", Type.GetType("System.String"));
        }

        /// <summary>
        /// adds a package variable to the local datatable
        /// </summary>
        /// <param name="variable"></param>
        private void AddVariableToRow(string variable)
        {
            DataRow dr = _variable.NewRow();
            dr["Variable"] = variable;
            _variable.Rows.Add(dr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataTable GetDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("Variable");
            dt.Columns.Add("Parameter");
            dt.Columns.Add("MultiValue");
            foreach (DataGridViewRow row in dgvReportParameter.Rows)
            {
                DataRow r = dt.NewRow();
                r[0] = row.Cells[0].Value;
                r[1] = row.Cells[1].Value;
                r[2] = row.Cells[2].Value;
                dt.Rows.Add(r);
            }

            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        private void SetParameter(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                AddRow(row[1].ToString(), row[0].ToString(), Convert.ToBoolean(row[2]));
            }
        }

     }
}
