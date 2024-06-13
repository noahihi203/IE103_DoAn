using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.ReportControls;
using Stimulsoft.Report.Components;

namespace DoAnIE103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StiReport report = new StiReport();
            report.Load("path_to_your_report_file.mrt");
            var dataSet = new DataSet();
            report.RegData("DataSetName", dataSet);
            report.Render();
            report.ExportDocument(StiExportFormat.Pdf, "report.pdf");
        }

    }
}
