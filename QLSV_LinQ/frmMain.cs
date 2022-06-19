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
    public partial class frmMain : Form
    {
        public static bool isLogin = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DangNhap.Enabled = true;
            quanlyTK.Enabled = false;
            DangXuat.Enabled = false;
            quanliMain.Enabled = false;
            xuatDSMH.Enabled = false;
            xuatDSSV.Enabled = false;
            xemDiem.Enabled = false;
            thongkeDiem.Enabled = false;
            thongkeTiLe.Enabled = false;
        }

        private void quanliMain_Click(object sender, EventArgs e)
        {
            frmQuanLy frmQuanLy = new frmQuanLy();
            frmQuanLy.Show();
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frmDangNhap = new frmLogin();
            frmDangNhap.ShowDialog();

            if (frmMain.isLogin == true)
            {
                DangNhap.Enabled = false;
                DangXuat.Enabled = true;
                quanlyTK.Enabled = true;
                quanliMain.Enabled = true;
                xuatDSMH.Enabled = true;
                xuatDSSV.Enabled = true;
                xemDiem.Enabled = true;
                thongkeDiem.Enabled = true;
                thongkeTiLe.Enabled = true;
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Close();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            isLogin = false;
            frmMain_Load(null, null);
        }

        private void pan_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuatDSMH_Click(object sender, EventArgs e)
        {
            frmReportMH fRPMH = new frmReportMH();
            fRPMH.ShowDialog();
        }

        private void xuatDSSV_Click(object sender, EventArgs e)
        {
            frmReportSV fRPSV = new frmReportSV();
            fRPSV.ShowDialog();
        }

        private void xemDiem_Click(object sender, EventArgs e)
        {
            GetMSSV gMSSV = new GetMSSV();
            gMSSV.ShowDialog();
        }

        private void thongkeDiem_Click(object sender, EventArgs e)
        {
            frmTKDiem fTKD = new frmTKDiem();
            fTKD.ShowDialog();
        }

        private void thongkeTiLe_Click(object sender, EventArgs e)
        {
            frmTKTiLe fTKTiLe = new frmTKTiLe();
            fTKTiLe.ShowDialog();
        }
    }
}
