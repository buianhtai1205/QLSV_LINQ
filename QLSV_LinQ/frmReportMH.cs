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
    public partial class frmReportMH : Form
    {
        BLMonHoc dbMH = new BLMonHoc();
        public frmReportMH()
        {
            InitializeComponent();
        }

        private void frmReportMH_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV_LinQ.ReportMH.rdlc";
                ReportDataSource reportDTS = new ReportDataSource();
                reportDTS.Name = "DataSet1";
                reportDTS.Value = dbMH.LayDataReportMH();
                reportViewer1.LocalReport.DataSources.Add(reportDTS);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
