using System;
using System.Collections;
using System.Linq;

namespace SSISComponents.ReportGenerator
{
    public sealed class RenderExtensions: Hashtable
    {
        public RenderExtensions()
        {

            Add("ATOM", new RenderExtension("ATOM", "*.atom", "Atom"));
            Add("PDF", new RenderExtension("PDF", "*.pdf", "Acrobat"));
            Add("CSV", new RenderExtension("CSV", "*.csv", "Comma Delimited"));
            Add("EMF", new RenderExtension("EMF", "*.emf", "EMF file"));
            Add("EXCEL", new RenderExtension("EXCEL", "*.xls", "Excel"));
            Add("EXCELOPENXML", new RenderExtension("EXCELOPENXML", "*.xlsx", "Excel Open XML"));
            Add("HTML4.0", new RenderExtension("HTML4.0", "*.html", "HTML 4.0"));
            Add("JPEG", new RenderExtension("IMAGE", "*.jpeg", "JPEG file"));
            Add("PNG", new RenderExtension("IMAGE", "*.png", "PNG file"));         
            Add("IMAGE", new RenderExtension("IMAGE", "*.tiff", "TIFF file"));
            Add("WORD", new RenderExtension("WORD", "*.docx", "Word"));
            Add("WORDOPENXML", new RenderExtension("WORDOPENXML", "*.docx", "Word Open XML"));
            Add("XML", new RenderExtension("XML", "*.xml", "XML file"));
            //Add("ACXLS", new RenderExtension("ACXLS", "*.xls", "Excel Workbook via Aspose.Cells"));
            //Add("ACXLSX", new RenderExtension("ACXLSX", "", "Excel 2007 via Aspose.Cells"));
            //Add("ACXLSX(Data Only)", new RenderExtension("ACXLSX(Data Only)", "*.xlsx", "Excel 2007 (Data Only) via Aspose.Cells"));
            //Add("ACXLSB", new RenderExtension("ACXLSB", "*.xlsb", "Excel (XLSB) via Aspose.Cells"));
            //Add("ACXLSM", new RenderExtension("ACXLSM", "*.xlsm", "Excel (XSLM) 2007 via Aspose.Cells"));
            //Add("ACXML", new RenderExtension("ACXML", "*.xml", "SpreadsheetML via Aspose.Cells"));
            //Add("ACHTML", new RenderExtension("ACHTML", "*.html", "HTML via Aspose.Cells"));
            //Add("ACCSV", new RenderExtension("ACCSV", "*.csv", "CSV via Aspose.cells"));
            //Add("ACODS", new RenderExtension("ACODS", "*.ods", "OpenDocument via Aspose.Cells"));
            //Add("ACTXT", new RenderExtension("ACTXT", "*.txt", "TabDelimited text via Aspose.Cells"));
            //Add("ASPPT", new RenderExtension("ASPPT", "*.ppt", "PowerPoint 97-2003 Presentation via Aspose.Slides"));
            //Add("ASPPS", new RenderExtension("ASPPS", "*.pps", "PowerPoint 97-2003 Show via Aspose.Slides"));
            //Add("ASPPTX", new RenderExtension("ASPPTX", "*.pptx", "PowerPoint Presentation via Aspose.Slides"));
            //Add("ASPPSX", new RenderExtension("ASPPSX", "*.ppsx", "PowerPoint Show via Aspose.Slides"));

        }

        public RenderExtension Get(string extension)
        {
            //RenderExtension item = null;
            //foreach (DictionaryEntry de in this)
            //{

            //    item = (RenderExtension) de.Value;
            //    if (item.Extension.ToString() == extension)
            //    {
            //        break;
            //    }
            //}
            //return item;
            
            return (from DictionaryEntry de in this select (RenderExtension) de.Value).FirstOrDefault(re => re.Extension.ToLower().Contains(extension.ToLower()));

        }
    }
}
