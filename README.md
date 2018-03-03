# ReportGeneratorTask

SSIS Task for SQL Server 2012 - 2017 to render SSRS Reports or to render local reports from a recordset data source.

Latest Release: [ReportGeneratorTask 1.85](https://ssiswp.blob.core.windows.net/downloads/ReportGeneratorTask.msi) (2,59 MB)

Functions:

* Render local reports (recordset)
* Render remote reports (SQL Server Reporting Services 2008 and 2012)
* Render remote reports from SharePoint 2010
* Reports can save with date and time as prefix
* Render reports as
  * XML file with report data (XML)
  * Comma Delimited (CSV)
  * Acrobat (PDF)
  * HTML 4.0 (HTM)
  * Web Archive (HTM)
  * Office Excel (XLS)
  * TIFF file (TIFF)
  * Office Word (DOC)
* Show reports during execution
* Generate snapshots
* View server report properties during configuration
* Set report parameter via SSIS variables
* You can use Multi-Value Parameter
* ExecutionInformation such as NumPages or ExecutionDate can be stored in variables for further processing

To connect to a <b>SharePoint Server</b>, use the following URL:

http://<YOUR SERVER>/_vti_bin/ReportServer
  
