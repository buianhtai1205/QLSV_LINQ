using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using QLSV_LinQ.ClassQuanLy;
using System.Data.SqlClient;

namespace QLSV_LinQ.BS_layer
{
    internal class BLSinhVien
    {
        public List<ClassSV> LaySinhVien(string strSearch = "")
        {
            DataSet ds = new DataSet();
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            //return qlSV.SinhViens;
            var query = (from sv in qlSV.SinhViens
                         join lop in qlSV.Lops on sv.maLop equals lop.maLop 
                         where sv.status == 0
                         where (sv.maSV.ToString().Contains(strSearch)
                                    || sv.hoTen.Contains(strSearch))
                         select new ClassSV {
                             MaSinhVien = sv.maSV,
                             HoTen = sv.hoTen,
                             Email = sv.email,
                             MatKhau = sv.matKhau,
                             GioiTinh = sv.gioiTinh,
                             DiaChi = sv.diachi,
                             DienThoai = sv.soDT,
                             MaLop = (int)sv.maLop,
                             TenLop = lop.tenLop,
                         }).ToList();
            return query;
        }

        public bool ThemSinhVien(string MaSV, string MaLop, string Email, string MatKhau,
             string HoTen, string GioiTinh, string SoDT, string DiaChi, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();

                SinhVien sv = new SinhVien();
                sv.maSV = Int32.Parse(MaSV);
                sv.maLop = Int32.Parse(MaLop);
                sv.email = Email;
                sv.matKhau = MatKhau;
                sv.hoTen = HoTen;
                sv.gioiTinh = GioiTinh;
                sv.soDT = SoDT;
                sv.diachi = DiaChi;
                sv.status = 0;

                qlSV.SinhViens.InsertOnSubmit(sv);
                qlSV.SinhViens.Context.SubmitChanges();

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            
            return f;
        }

        public bool CapNhatSinhVien(string MaSV, string MaLop, string Email, string MatKhau,
             string HoTen, string GioiTinh, string SoDT, string DiaChi, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var svQuery = (from s in qlSV.SinhViens
                               where s.maSV == Int32.Parse(MaSV)
                               select s).SingleOrDefault();
                if (svQuery != null)
                {
                    svQuery.maLop = Int32.Parse(MaLop);
                    svQuery.email = Email;
                    svQuery.matKhau = MatKhau;
                    svQuery.hoTen = HoTen;
                    svQuery.gioiTinh = GioiTinh;
                    svQuery.soDT = SoDT;
                    svQuery.diachi = DiaChi;
                    qlSV.SinhViens.Context.SubmitChanges();
                }
                
                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }

        public bool XoaSinhVien(string MaSV, ref string err)
        {
            bool f = false;
            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var svQuery = (from s in qlSV.SinhViens
                               where s.maSV == Int32.Parse(MaSV)
                               select s).SingleOrDefault();
                if (svQuery != null)
                {
                    svQuery.status = 1;
                    qlSV.SinhViens.Context.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return f;
        }

        public List<SinhVien> LayDataReportSV()
        {
            DataSet ds = new DataSet();
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            //return qlSV.SinhViens;
            var query = (from sv in qlSV.SinhViens
                         join lop in qlSV.Lops on sv.maLop equals lop.maLop
                         where sv.status == 0
                         select sv).ToList();
            return query;
        }
    }
}
