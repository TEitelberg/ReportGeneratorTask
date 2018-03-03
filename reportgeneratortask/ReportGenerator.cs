using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.SqlServer.Dts.Runtime;
using System.Data;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using SSISComponents.ReportGenerator.ReportExecution2005;
using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;
using Warning = Microsoft.Reporting.WinForms.Warning;

namespace SSISComponents.ReportGenerator
{
#if SQL2008
    // This attribute tells SSIS about your Task.
    [DtsTask(
        DisplayName = "ReportGenerator Task",
        IconResource = "SSISComponents.ReportGenerator.SSISComponents.ReportGenerator.ico",
        Description = "The task generates reports from a given recordset or generate reports from SSRS 2008 to 2017 and Sharepoint.",
        UITypeName = "SSISComponents.ReportGenerator.ReportGeneratorUiInterface, SSISComponents.DTS.Tasks.ReportGeneratorTask2008, Version=1.8.5.0, Culture=neutral, PublicKeyToken=0ee497b3fc52b917")]
#elif SQL2012
    // This attribute tells SSIS about your Task.
    [DtsTask(
        DisplayName = "ReportGenerator Task",
        IconResource = "SSISComponents.ReportGenerator.SSISComponents.ReportGenerator.ico",
        Description = "The task generates reports from a given recordset or generate reports from SSRS 2008 to 2017 and Sharepoint.",
        UITypeName = "SSISComponents.ReportGenerator.ReportGeneratorUiInterface, SSISComponents.DTS.Tasks.ReportGeneratorTask2012, Version=1.8.5.0, Culture=neutral, PublicKeyToken=0ee497b3fc52b917")]
#elif SQL2014
        // This attribute tells SSIS about your Task.
    [DtsTask(
        DisplayName = "ReportGenerator Task",
        IconResource = "SSISComponents.ReportGenerator.SSISComponents.ReportGenerator.ico",
        Description = "The task generates reports from a given recordset or generate reports from SSRS 2008 to 2017 and Sharepoint.",
        UITypeName = "SSISComponents.ReportGenerator.ReportGeneratorUiInterface, SSISComponents.DTS.Tasks.ReportGeneratorTask2014, Version=1.8.5.0, Culture=neutral, PublicKeyToken=0ee497b3fc52b917")]
#elif SQL2016
    // This attribute tells SSIS about your Task.
    [DtsTask(
        DisplayName = "ReportGenerator Task",
        IconResource = "SSISComponents.ReportGenerator.SSISComponents.ReportGenerator.ico",
        Description = "The task generates reports from a given recordset or generate reports from SSRS 2008 to 2017 and Sharepoint.",
        UITypeName = "SSISComponents.ReportGenerator.ReportGeneratorUiInterface, SSISComponents.DTS.Tasks.ReportGeneratorTask2016, Version=1.8.5.0, Culture=neutral, PublicKeyToken=0ee497b3fc52b917")]
#elif SQL2017
    // This attribute tells SSIS about your Task.
    [DtsTask(
        DisplayName = "ReportGenerator Task",
        IconResource = "SSISComponents.ReportGenerator.SSISComponents.ReportGenerator.ico",
        Description = "The task generates reports from a given recordset or generate reports from SSRS 2008 to 2017 and Sharepoint.",
        UITypeName = "SSISComponents.ReportGenerator.ReportGeneratorUiInterface, SSISComponents.DTS.Tasks.ReportGeneratorTask2017, Version=1.8.5.0, Culture=neutral, PublicKeyToken=0ee497b3fc52b917")]
#endif
    public class ReportGenerator : Task
    {
        #region Private Variables

        
        private string _localname;
        private IList<Stream> _mStreams;
        private bool _refire;
        Stream _stream;

        public ReportGenerator()
        {
            TimeOut = 30000;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Name and apth to the server report
        /// </summary>
        public int TimeOut { get; set; }

        /// <summary>
        /// Name and apth to the server report
        /// </summary>
        public string Reportname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Reportparameter { get; set; }

        /// <summary>
        /// name of dataset defined in the local report
        /// </summary>
        public string Datasetname { get; set; }
        
        /// <summary>
        /// recordset to be displayed on the report
        /// </summary>
        public string Recordset { get; set; }

        /// <summary>
        /// filename
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// address/url of the report server
        /// </summary>
        public string ReportServer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// filename with datetime as prefix
        /// </summary>
        public string PrefixFilename { get; set; }

        /// <summary>
        /// Get or set value for windows integrated security
        /// </summary>
        public Boolean WindowsAuthorization { get; set; }

        /// <summary>
        /// get or set the value for the local prefix
        /// </summary>
        public Boolean Prefix { get; set; }

        /// <summary>
        /// show report in debugmode
        /// </summary>
        public Boolean DebugMode { get; set; }

        /// <summary>
        /// create snapshot
        /// </summary>
        public Boolean Snapshot { get; set; }

        public string ExecutionDateTime { get; set; }
        public string ExecutionId { get; set; }
        public string ExpirationDateTime { get; set; }
        public string HistoryId { get; set; }
        public string NumPages { get; set; }


        #endregion

        #region Task Implementation
        
        #region Validate
        
        /// <summary>
        /// Validate local parameter
        /// </summary>
        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            var isBaseValid = true;

            if (base.Validate(connections, variableDispenser, componentEvents, log) != DTSExecResult.Success)
            {
                componentEvents.FireError(0, "ReportGeneratorTask", "Base validation failed", "", 0);
                isBaseValid = false;
            }
            if (string.IsNullOrEmpty(Filename))
            {
                componentEvents.FireError(0, "ReportGeneratorTask", "A file name is required.", "", 0);
                isBaseValid = false;
            }
            if (string.IsNullOrEmpty(Recordset) && ReportType == "Dataset Report")
            {
                componentEvents.FireError(0, "ReportGeneratorTask", "A recordset is required.", "", 0);
                isBaseValid = false;
            }
            if (string.IsNullOrEmpty(Reportname))
            {
                componentEvents.FireError(0, "ReportGeneratorTask", "A Reportname is required.", "", 0);
                isBaseValid = false;
            }
            if (string.IsNullOrEmpty(Datasetname) && ReportType == "Dataset Report")
            {
                componentEvents.FireError(0, "ReportGeneratorTask", "A Datasetname is required.", "", 0);
                isBaseValid = false;
            }
            if (ReportType != "Dataset Report")
            {
                if (!WindowsAuthorization)
                {
                    if (string.IsNullOrEmpty(Username))
                    {
                        componentEvents.FireError(0, "ReportGeneratorTask", "A Username is required.", "", 0);
                        isBaseValid = false;
                    }
                    if (string.IsNullOrEmpty(Password))
                    {
                        componentEvents.FireError(0, "ReportGeneratorTask", "A Password is required.", "", 0);
                        isBaseValid = false;
                    }
                }
            }

            return isBaseValid ? DTSExecResult.Success : DTSExecResult.Failure;
        }
        
        #endregion

        #region Execute

        /// <summary>
        /// This method is called at runtime, and does all the "work".
        /// </summary>
        public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
        {
            _localname = Localname();

            if (ReportType == "Dataset Report")
            {
                Variables vars = null;
                var oleda = new System.Data.OleDb.OleDbDataAdapter();
                var dt = new DataTable(Datasetname);
                variableDispenser.LockForRead(Recordset);
                variableDispenser.GetVariables(ref vars);
                componentEvents.FireInformation(0, "ReportGenerator", "Filename: " + _localname, string.Empty, 0, ref _refire);
                try
                {
                    //var rv = new ReportViewer {ProcessingMode = ProcessingMode.Local};
                    var val = vars[Recordset].Value;
                    oleda.Fill(dt, val);
                    componentEvents.FireInformation(0, "ReportGenerator", "Starts report generation with " + dt.Rows.Count + " rows", string.Empty, 0, ref _refire);
                    Run(Reportname, Datasetname, dt, _localname);
                    componentEvents.FireInformation(0, "ReportGenerator", "The report was created.", string.Empty, 0, ref _refire);

                    //Warning: debugmode is a user defined option.
                    if (DebugMode)
                    {
                        componentEvents.FireInformation(0, "ReportGenerator", "Satrts local report generation", string.Empty, 0, ref _refire);
                        var localReport = new ReportViewerUi
                        {
                            Datasetname = Datasetname,
                            Data = dt,
                            Reportname = Reportname
                        };
                        localReport.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    componentEvents.FireError(0, "ReportGeneratorTask", ex.ToString(), "", 0);
                }
                finally
                {
                    if (vars.Locked)
                    {
                        vars.Unlock();
                    }
                }
            }
            else
            {
                GenerateServerReport(variableDispenser, componentEvents);
            }


            // set prefixfilename to variable
            if (!string.IsNullOrEmpty(PrefixFilename) && PrefixFilename != "Choose a Variable")
            {
                SetPrefixFilename(variableDispenser, componentEvents);
            }

            return base.Execute(connections, variableDispenser, componentEvents, log, transaction);
        }
        
        #endregion
       
        /// <summary>
        /// Routine to provide to the report renderer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fileNameExtension"></param>
        /// <param name="encoding"></param>
        /// <param name="mimeType"></param>
        /// <param name="willSeek"></param>
        /// <returns></returns>
        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            _stream = new FileStream(_localname, FileMode.Create);
            _mStreams.Add(_stream);
            return _stream;
        }

        /// <summary>
        /// Export the local Report
        /// </summary>
        /// <param name="report"></param>
        /// <param name="localname"></param>
        private void Export(LocalReport report, string localname)
        {
            var fi = new FileInfo(localname);
            Warning[] warnings;
            _mStreams = new List<Stream>();

            var renderExtensions = new RenderExtensions();
            var renderExtension = renderExtensions.Get(fi.Extension);
            if (renderExtension == null) throw new Exception("Not supported render type (Export): " + fi.Extension);
            report.Render(renderExtension.Name, DeviceInfo(fi.Extension), CreateStream, out warnings);

            foreach (Stream stream in _mStreams)
            {
                stream.Position = 0;
            }
            _stream.Close();
            _stream.Dispose();
        }

        /// <summary>
        /// Start report generation
        /// </summary>
        /// <param name="reportname">path to the rpeort</param>
        /// <param name="datasetname">datasetname inside the rpeort</param>
        /// <param name="data">data to render</param>
        /// <param name="localname">save the report as...</param>
        private void Run(string reportname, string datasetname, DataTable data, string localname)
        {
            var report = new LocalReport {ReportPath = reportname};
            report.DataSources.Add(new ReportDataSource(datasetname, data));
            Export(report, localname);
        }

        /// <summary>
        /// Reporting Services Device Information Settings
        /// http://msdn.microsoft.com/en-us/library/ms155397.aspx
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        private string DeviceInfo(string extension)
        {
            string deviceinfo = null;
            switch (extension)
            {
                case ".pdf":
                    deviceinfo = "<DeviceInfo>" +
                                "  <OutputFormat>PDF</OutputFormat>" +
                                "  <PageWidth>8.5in</PageWidth>" +
                                "  <PageHeight>11in</PageHeight>" +
                                "  <MarginTop>0.5in</MarginTop>" +
                                "  <MarginLeft>1in</MarginLeft>" +
                                "  <MarginRight>1in</MarginRight>" +
                                "  <MarginBottom>0.5in</MarginBottom>" +
                                "</DeviceInfo>";
                    break;
                case ".xls":
                    deviceinfo = "<DeviceInfo>" +
                                "  <OutputFormat>Excel</OutputFormat>" +
                                "  <PageWidth>8.5in</PageWidth>" +
                                "  <PageHeight>11in</PageHeight>" +
                                "  <MarginTop>0.5in</MarginTop>" +
                                "  <MarginLeft>1in</MarginLeft>" +
                                "  <MarginRight>1in</MarginRight>" +
                                "  <MarginBottom>0.5in</MarginBottom>" +
                                "</DeviceInfo>";
                    break;
            }
            return deviceinfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string TwoChar(string value)
        {
            if (value.Length == 1)
            {
                value = "0" + value;
            }
            return value;
        }

        /// <summary>
        /// Generate SSRS Report
        /// </summary>
        /// <param name="variableDispenser"></param>
        /// <param name="componentEvents"></param>
        private void GenerateServerReport(VariableDispenser variableDispenser, IDTSComponentEvents componentEvents)
        {
            var fi = new FileInfo(Filename);
            Variables vars = null;

            // Create a new proxy to the web service
            var rs = new ReportService2010.ReportingService2010();
            var rsExec = new ReportExecution2005.ReportExecutionService();

            // Assign the URL of the Web service
            rs.Url = ReportServer + "/ReportService2010.asmx";
            rsExec.Url = ReportServer + "/ReportExecution2005.asmx";

            // Authenticate to the Web service using Windows credentials
            if (WindowsAuthorization)
            {
                rs.Credentials = CredentialCache.DefaultCredentials;
                rsExec.Credentials = CredentialCache.DefaultCredentials;
            }
            else
            {
                rs.CookieContainer = new CookieContainer();
                rs.LogonUser(String.Format("{0}\\{1}", Domain, Username), Password, ReportServer);
                rsExec.CookieContainer = new CookieContainer();
                rsExec.LogonUser(String.Format("{0}\\{1}", Domain, Username), Password, ReportServer);
            }
            
            rs.Timeout = TimeOut;
            rsExec.Timeout = TimeOut;

            componentEvents.FireInformation(0, "ReportGenerator", String.Format("WebService timeout is set to {0} milliseconds.", TimeOut), string.Empty, 0, ref _refire);
            componentEvents.FireInformation(0, "ReportGenerator", "Report Server:" + ReportServer, string.Empty, 0, ref _refire);

            if (Snapshot)
            {
                try
                {
                    ReportService2010.Warning[] warn;
                    rs.CreateItemHistorySnapshot(Reportname, out warn);
                    componentEvents.FireInformation(0, "ReportGenerator", "A snapshot was created.", string.Empty, 0, ref _refire);
                }
                catch (Exception ex)
                {
                    componentEvents.FireWarning(0, "ReportGeneratorTask", "A snapshot could not be created. Exception: " + ex.Message, "", 0);
                }
            }

            // Prepare Render arguments

            var renderExtensions = new RenderExtensions();
            var renderExtension = renderExtensions.Get(fi.Extension);
            if (renderExtension == null) throw new Exception("Not supported render type (GenerateServerReport): " + fi.Extension);
            string format = renderExtension.Name;

            // fire render arguments
            componentEvents.FireInformation(0, "ReportGenerator", "Reportname: " + Reportname, string.Empty, 0, ref _refire);
            componentEvents.FireInformation(0, "ReportGenerator", "Filename: " + _localname, string.Empty, 0, ref _refire);
            componentEvents.FireInformation(0, "ReportGenerator", "Format: " + format, string.Empty, 0, ref _refire);

            try
            {
                // Prepare report parameter.
                //DataTable dt = (DataTable)ReportGenerator.DeserializeObject(_Reportparameter.ToString());
                var dt = GetParameterDataTable(Reportparameter);
                var param = new List<ParameterValue>();

                // set paramter for server report
                //foreach (var row in dt.Rows.Cast<DataRow>().Where(row => !string.IsNullOrEmpty(row[0].ToString()) && row[0].ToString() != "Choose a Variable"))
                foreach (DataRow row in dt.Rows)
                {
                    if (!string.IsNullOrEmpty(row[0].ToString()) && row[0].ToString() != "Choose a Variable")
                    {
                        variableDispenser.LockForRead(row[0].ToString());
                        variableDispenser.GetVariables(ref vars);
                        var variableValue = vars[row[0].ToString()].Value.ToString();
                        var multiValue = Convert.ToBoolean(row[2]) ? variableValue.Split(';') : new[] {variableValue};
                        foreach (var value in multiValue)
                        {
                            param.Add(new ReportExecution2005.ParameterValue
                            {
                                Name = row[1].ToString(),
                                Value = value
                            });
                            componentEvents.FireInformation(0, "ReportGenerator",
                                row[1] + " --> " + row[0] + " --> " + value, string.Empty, 0, ref _refire);
                        }
                    }
                }

                //componentEvents.FireInformation(0, "ReportGenerator", iParams.ToString(), string.Empty, 0, ref _refire);
                // Load the selected report
                var ei = rsExec.LoadReport(Reportname, null);

                // Set the parameters
                if (param.Count > 0)
                {
                    rsExec.SetExecutionParameters(param.ToArray(), "en-EN");
                }

                // Render the report
                string[] streamIDs;
                ReportExecution2005.Warning[] warnings;
                string encoding;
                string mimeType;
                string extension;
                var results = rsExec.Render(format, null, out extension, out encoding, out mimeType, out warnings, out streamIDs);

                var execInfo = rsExec.GetExecutionInfo();

                componentEvents.FireInformation(0, "ReportGenerator", string.Format("ExecutionDateTime: {0}", execInfo.ExecutionDateTime.ToLongDateString()), string.Empty, 0, ref _refire);
                if (!string.IsNullOrEmpty(ExecutionDateTime) && ExecutionDateTime != "Choose a Variable")
                {
                    variableDispenser.LockOneForWrite(ExecutionDateTime, ref vars);
                    if (vars[ExecutionDateTime].DataType == TypeCode.DateTime)
                    {
                        vars[ExecutionDateTime].Value = execInfo.ExecutionDateTime;
                        vars.Unlock();
                        componentEvents.FireInformation(0, "ReportGenerator", String.Format("ExecutionDateTime: {0}", execInfo.ExecutionDateTime.ToLongDateString()), string.Empty, 0, ref _refire);
                    }
                    else
                    {
                        componentEvents.FireWarning(0, "ReportGenerator", "Incorrect DataType for ExecutionDateTime", null, 0);
                    }
                }

                if (!string.IsNullOrEmpty(ExecutionId) && ExecutionId != "Choose a Variable")
                {
                    variableDispenser.LockOneForWrite(ExecutionId, ref vars);
                    if (vars[ExecutionId].DataType == TypeCode.String)
                    {
                        vars[ExecutionId].Value = String.IsNullOrEmpty(execInfo.ExecutionID) ? "" : execInfo.ExecutionID;
                        vars.Unlock();
                        componentEvents.FireInformation(0, "ReportGenerator", string.Format("ExecutionId: {0}", execInfo.ExecutionID), string.Empty, 0, ref _refire);
                    }
                    else
                    {
                        componentEvents.FireWarning(0, "ReportGenerator", "Incorrect DataType for ExecutionId", null, 0);
                    }
                }

                if (!string.IsNullOrEmpty(ExpirationDateTime) && ExpirationDateTime != "Choose a Variable")
                {
                    variableDispenser.LockOneForWrite(ExpirationDateTime, ref vars);
                    if (vars[ExpirationDateTime].DataType == TypeCode.DateTime)
                    {
                        vars[ExpirationDateTime].Value = execInfo.ExpirationDateTime;
                        vars.Unlock();
                        componentEvents.FireInformation(0, "ReportGenerator",
                            String.Format("ExpirationDateTime: {0}", execInfo.ExpirationDateTime.ToLongDateString()),
                            string.Empty, 0, ref _refire);
                    }
                    else
                    {
                        componentEvents.FireWarning(0, "ReportGenerator", "Incorrect DataType for ExpirationDateTime", null, 0);
                    }
                }

                if (!string.IsNullOrEmpty(HistoryId) && HistoryId != "Choose a Variable")
                {
                    variableDispenser.LockOneForWrite(HistoryId, ref vars);
                    if (vars[HistoryId].DataType == TypeCode.String)
                    {
                        vars[HistoryId].Value = String.IsNullOrEmpty(execInfo.HistoryID) ? "" : execInfo.HistoryID;
                        vars.Unlock();
                        componentEvents.FireInformation(0, "ReportGenerator", String.Format("HistoryId: {0}", execInfo.HistoryID), string.Empty, 0, ref _refire);
                    }
                    else
                    {
                        componentEvents.FireWarning(0, "ReportGenerator", "Incorrect DataType for HistoryId", null, 0);
                    }
                }

                if (!string.IsNullOrEmpty(NumPages) && NumPages != "Choose a Variable")
                {
                    variableDispenser.LockOneForWrite(NumPages, ref vars);
                    if (vars[NumPages].DataType == TypeCode.Int16 || vars[NumPages].DataType == TypeCode.Int32 ||
                        vars[NumPages].DataType == TypeCode.Int64)
                    {
                        vars[NumPages].Value = execInfo.NumPages;
                        vars.Unlock();
                        componentEvents.FireInformation(0, "ReportGenerator",
                            String.Format("NumPages: {0}", execInfo.NumPages), string.Empty, 0, ref _refire);
                    }
                    else
                    {
                        componentEvents.FireWarning(0, "ReportGenerator", "Incorrect DataType for NumPages", null, 0);
                    }
                }


                if (File.Exists(_localname))
                {
                    File.Delete(_localname);
                }

                //// Create a file stream and write the report to it
                using (var stream = File.OpenWrite(_localname))
                {
                    stream.Write(results, 0, results.Length);
                }

                componentEvents.FireInformation(0, "ReportGenerator", "Report was generated.", string.Empty, 0, ref _refire);

                // open ReportViewerUI in debugmode
                
                if (DebugMode)
                {
                    componentEvents.FireInformation(0, "ReportGenerator", "Show Report in Debugmode.", string.Empty, 0, ref _refire);
                    var localReport = new ReportViewerUi
                    {
                        Reportserver = ReportServer,
                        Reportname = Reportname,
                        WindowsAuthorization = WindowsAuthorization,
                        Username = Username,
                        Password = Password,
                        Domain = Domain,
                        ReportType = ReportType
                    };

                    //set parameter for localreport
                    if (param.Count > 0)
                    {
                        var parameter = new List<ReportParameter>(); //[iParams];

                        //foreach (var row in dt.Rows.Cast<DataRow>().Where(row => !String.IsNullOrEmpty(row[0].ToString())))
                        foreach (DataRow row in dt.Rows)
                        {
                            if(!string.IsNullOrEmpty(row[0].ToString()))
                            {
                                variableDispenser.LockForRead(row[0].ToString());
                                variableDispenser.GetVariables(ref vars);
                                var varValue = vars[row[0].ToString()].Value.ToString();
                                var multiValue = Convert.ToBoolean(row[2]) ? varValue.Split(';') : new[] {varValue};

                                foreach (var value in multiValue)
                                {
                                    var localparam = new ReportParameter {Name = row[1].ToString()};
                                    localparam.Values.Add(value);
                                    parameter.Add(localparam);
                                }
                            }
                        }

                        localReport.Reportparameter = parameter.ToArray();
                    }

                    localReport.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                componentEvents.FireError(0, "ReportGenerator", ex.ToString(), "", 0);
                componentEvents.FireError(0, "ReportGenerator", fi.Extension.ToString(), "", 0);
            }
        }

        /// <summary>
        /// Set filename with prefix to local variable
        /// </summary>
        /// <param name="variableDispenser"></param>
        /// <param name="componentEvents"></param>
        private void SetPrefixFilename(VariableDispenser variableDispenser, IDTSComponentEvents componentEvents)
        {
            try
            {
                if (PrefixFilename != null && PrefixFilename != "Choose a Variable")
                {
                    Variables vars = null;
                    variableDispenser.LockOneForWrite(PrefixFilename, ref vars);
                    vars[PrefixFilename].Value = TypeConverter(_localname, vars[0].DataType);
                    vars.Unlock();
                    variableDispenser.Reset();
                    componentEvents.FireInformation(0, "ReportGenerator", "Variable " + PrefixFilename + " set to " + _localname, string.Empty, 0, ref _refire);
                }
            }
            catch (Exception exc)
            {
                componentEvents.FireError(0, "ReportGenerator", "Task Errored: " + exc, "", -1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private object TypeConverter(string value, TypeCode type)
        {
            switch (type)
            {
                case TypeCode.Boolean:
                    return bool.Parse(value);
                case TypeCode.Byte:
                    return byte.Parse(value);
                case TypeCode.Char:
                    return char.Parse(value);
                case TypeCode.DBNull:
                    return null;
                case TypeCode.DateTime:
                    return DateTime.Parse(value);
                case TypeCode.Decimal:
                    return decimal.Parse(value);
                case TypeCode.Double:
                    return double.Parse(value);
                case TypeCode.Empty:
                    return null;
                case TypeCode.Int16:
                    return Int16.Parse(value);
                case TypeCode.Int32:
                    return Int32.Parse(value);
                case TypeCode.Int64:
                    return Int64.Parse(value);
                case TypeCode.Object:
                    return value;
                case TypeCode.SByte:
                    return SByte.Parse(value);
                case TypeCode.Single:
                    return Single.Parse(value);
                case TypeCode.String:
                    return value;
                case TypeCode.UInt16:
                    return UInt16.Parse(value);
                case TypeCode.UInt32:
                    return UInt32.Parse(value);
                case TypeCode.UInt64:
                    return UInt64.Parse(value);
                default:
                    return value;
            }
        }

        /// <summary>
        /// Generates the Filename with prefix
        /// </summary>
        /// <returns></returns>
        private string Localname()
        {
            string file;
            if (Prefix)
            {
                var fi = new FileInfo(Filename);
                string localPrefix = DateTime.Now.Year +
                                    TwoChar(DateTime.Now.Month.ToString(CultureInfo.InvariantCulture)) +
                                    TwoChar(DateTime.Now.Day.ToString(CultureInfo.InvariantCulture)) +
                                    TwoChar(DateTime.Now.Hour.ToString(CultureInfo.InvariantCulture)) +
                                    TwoChar(DateTime.Now.Minute.ToString(CultureInfo.InvariantCulture)) +
                                    TwoChar(DateTime.Now.Second.ToString(CultureInfo.InvariantCulture)) + "_";
                file = fi.DirectoryName + "\\" + localPrefix + fi.Name;
            }
            else
            {
                file = Filename;
            }
            return file;
        }

        /// <summary>
        /// Serialize parameter settings
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static string SerializeObject(object parameter)
        {
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            formatter.Serialize(stream, parameter);
            string text = Convert.ToBase64String(stream.GetBuffer());
            stream.Close();
            return text;
        }

        public static string GetParameterString(DataTable parameter)
        {
            var current = string.Empty;
            foreach (DataRow row in parameter.Rows)
            {
                current += $"{row[0].ToString()};{row[1].ToString()};{row[2].ToString()}|";
            }
            return current;
            //return parameter.Rows.Cast<DataRow>().Aggregate<DataRow, string>(null, (current, row) => current + String.Format("{0};{1};{2}|", row[0].ToString(), row[1].ToString(), row[2].ToString()));
        }

        /// <summary>
        /// Deserialize parameter settings
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static object DeserializeObject(string parameter)
        {
            var formatter = new BinaryFormatter();
            Byte[] str = Convert.FromBase64String(parameter);
            var stream = new MemoryStream(str);
            object objParam = formatter.Deserialize(stream);
            return objParam;
        }

        public static DataTable GetParameterDataTable(string parameter)
        {
            var dt = new DataTable();
            dt.Columns.Add("Variable");
            dt.Columns.Add("Parameter");
            dt.Columns.Add("MultiValue");

            var rows = parameter.Split('|');
            foreach (var t in rows)
            {
                var data = t.Split(';');
                if (data.Length == 3)
                {
                    var row = dt.NewRow();
                    row[0] = data[0];
                    row[1] = data[1];
                    row[2] = data[2];
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

        #endregion
    }
}

