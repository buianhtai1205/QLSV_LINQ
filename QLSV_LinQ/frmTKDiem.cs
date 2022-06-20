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
    public partial class frmTKDiem : Form
    {
        BLDiem dbD = new BLDiem();
        string tenKhoa = "Khóa 2018";
        string tenMonHoc = "Lập trình OOP";
        string tenDiem = "Điểm quá trình";
        BLKhoa dbKhoa = new BLKhoa();
        BLMonHoc dbMH = new BLMonHoc();

        public frmTKDiem()
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

            cbbDiem.Items.Add("Điểm quá trình");
            cbbDiem.Items.Add("Điểm thi");
            cbbDiem.SelectedIndex = cbbDiem.FindStringExact("Điểm quá trình");
        }

        private void frmTKDiem_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        //fillChart method  
        private void fillChart()
        {
            ClassTKD tk = new ClassTKD();
            if (tenDiem == "Điểm quá trình")
                tk = dbD.LayDataTkD1(tenKhoa, tenMonHoc);
            else 
                tk = dbD.LayDataTkD2(tenKhoa, tenMonHoc);
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Diem"].Points.AddXY("0->3", tk.DiemMuc0_3);
            chart1.Series["Diem"].Points.AddXY("3->5", tk.DiemMuc3_5);
            chart1.Series["Diem"].Points.AddXY("5->7", tk.DiemMuc5_7);
            chart1.Series["Diem"].Points.AddXY("7->8", tk.DiemMuc7_8);
            chart1.Series["Diem"].Points.AddXY("8->9", tk.DiemMuc8_9);
            chart1.Series["Diem"].Points.AddXY("9->10", tk.DiemMuc9_10);
            //chart title  
            chart1.Titles.Add("Thống kê số lượng điểm");
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            tenKhoa = cbbKhoa.Text;
            tenMonHoc = cbbMH.Text;
            tenDiem = cbbDiem.Text;
            chart1.Series["Diem"].Points.Clear();
            chart1.Titles.Clear();
            frmTKDiem_Load(null, null);
        }
    }
}
