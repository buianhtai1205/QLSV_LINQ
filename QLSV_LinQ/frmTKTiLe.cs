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

        public frmTKTiLe()
        {
            InitializeComponent();
            cbbKhoa.Items.Add("Khóa 2018");
            cbbKhoa.Items.Add("Khóa 2019");
            cbbKhoa.Items.Add("Khóa 2020");
            cbbKhoa.Items.Add("Khóa 2021");
            cbbKhoa.SelectedIndex = cbbKhoa.FindStringExact("Khóa 2018");

            cbbMH.Items.Add("Lập trình OOP");
            cbbMH.Items.Add("Lập trình Windows");
            cbbMH.Items.Add("Anh Văn");
            cbbMH.Items.Add("Toán cao cấp");
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
