PATH "C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools\"

del "C:\Program Files (x86)\Microsoft SQL Server\100\DTS\Tasks\SSISComponents.DTS.Tasks.ReportGeneratorTask2008.dll"
del "C:\Program Files (x86)\Microsoft SQL Server\110\DTS\Tasks\SSISComponents.DTS.Tasks.ReportGeneratorTask2012.dll"
del "C:\Program Files (x86)\Microsoft SQL Server\120\DTS\Tasks\SSISComponents.DTS.Tasks.ReportGeneratorTask2014.dll"
del "C:\Program Files (x86)\Microsoft SQL Server\130\DTS\Tasks\SSISComponents.DTS.Tasks.ReportGeneratorTask2016.dll"

copy "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2008\SSISComponents.DTS.Tasks.ReportGeneratorTask2008.dll" "C:\Program Files (x86)\Microsoft SQL Server\100\DTS\Tasks" /Y
copy "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2012\SSISComponents.DTS.Tasks.ReportGeneratorTask2012.dll" "C:\Program Files (x86)\Microsoft SQL Server\110\DTS\Tasks" /Y
copy "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2014\SSISComponents.DTS.Tasks.ReportGeneratorTask2014.dll" "C:\Program Files (x86)\Microsoft SQL Server\120\DTS\Tasks" /Y
copy "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2016\SSISComponents.DTS.Tasks.ReportGeneratorTask2016.dll" "C:\Program Files (x86)\Microsoft SQL Server\130\DTS\Tasks" /Y


gacutil -u SSISComponents.DTS.Tasks.ReportGeneratorTask2008
gacutil -u SSISComponents.DTS.Tasks.ReportGeneratorTask2012
gacutil -u SSISComponents.DTS.Tasks.ReportGeneratorTask2014
gacutil -u SSISComponents.DTS.Tasks.ReportGeneratorTask2016

gacutil -i "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2008\SSISComponents.DTS.Tasks.ReportGeneratorTask2008.dll"
gacutil -i "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2012\SSISComponents.DTS.Tasks.ReportGeneratorTask2012.dll"
gacutil -i "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2014\SSISComponents.DTS.Tasks.ReportGeneratorTask2014.dll"
gacutil -i "C:\Projects\ssiscomponents.visualstudio.com\SSIS ReportGeneratorTask\SSIS ReportGeneratorTask\reportgeneratortask\bin\Debug\SQL Server 2016\SSISComponents.DTS.Tasks.ReportGeneratorTask2016.dll"