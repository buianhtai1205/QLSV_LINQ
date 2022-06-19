using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_LinQ
{
    public partial class GetMSSV : Form
    {
        public static string mssv;
        public GetMSSV()
        {
            InitializeComponent();
        }

        private void GetMSSV_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOKE_Click(object sender, EventArgs e)
        {
            mssv = txtGetMssv.Text.Trim();
            frmReportDiem fRPD = new frmReportDiem();
            fRPD.ShowDialog();
        }
    }
}
