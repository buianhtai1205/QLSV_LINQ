using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLSV_LinQ.BS_layer;
using QLSV_LinQ.ClassQuanLy;

namespace QLSV_LinQ
{
    public partial class frmTKTiLe : Form
    {
        BLDiem dbD = new BLDiem();
        string tenKhoa = "Khóa 2018";
        string tenMonHoc = "Lập trình OOP";
        BLKhoa dbKhoa = new BLKhoa();
        BLMonHoc dbMH = new BLMonHoc();

        public frmTKTiLe()
        {
            InitializeComponent();
            string[] khoa = dbKhoa.LayTenKhoa();
            for (int i = 0; i < khoa.Length; i++)
                cbbKhoa.Items.Add(khoa[i]);
            cbbKhoa.SelectedIndex = cbbKhoa.FindStringExact("Khóa 2018");

            string[] monhoc = dbMH.LayTenMonHoc();
            for (int i = 0; i < monhoc.Length; i++)
                cbbMH.Items.Add(monhoc[i]);
            cbbMH.SelectedIndex = cbbMH.FindStringExact("Lập trình OOP");
        }

        private void frmTKTiLe_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        //fillChart method  
        private void fillChart()
        {
            ClassTKTL tl = new ClassTKTL();
            tl = dbD.LayDataTkTL(tenKhoa, tenMonHoc);
            chart1.Series["TiLe"].IsValueShownAsLabel = true;
            chart1.Series["TiLe"].Points.AddXY("Đậu", tl.QuaMon);
            chart1.Series["TiLe"].Points.AddXY("Rớt", tl.RotMon);
            //chart title  
            chart1.Titles.Add("Thống kê tỉ lệ Đậu/Rớt");
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            tenKhoa = cbbKhoa.Text;
            tenMonHoc = cbbMH.Text;
            chart1.Series["TiLe"].Points.Clear();
            chart1.Titles.Clear();
            frmTKTiLe_Load(null, null);
        }
    }
}
