using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
using QLSV_LinQ.BS_layer;

namespace QLSV_LinQ
{
    public partial class frmReportDiem : Form
    {
        BLDiem dbD = new BLDiem();
        public frmReportDiem()
        {
            InitializeComponent();
        }

        private void frmReportDiem_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV_LinQ.ReportDiem.rdlc";
            ReportDataSource reportDTS = new ReportDataSource();
            reportDTS.Name = "DataSet1";
            string mssv = GetMSSV.mssv;
            reportDTS.Value = dbD.LayDataReportD(mssv);
            reportViewer1.LocalReport.DataSources.Add(reportDTS);
            this.reportViewer1.RefreshReport();
        }
    }
}
