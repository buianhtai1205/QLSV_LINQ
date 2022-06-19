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
    internal class BLDiem
    {
        public List<ClassDiem> LayDiem(string strSearch = "")
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var query = (from d in qlSV.Diems
                         join sv in qlSV.SinhViens on d.maSV equals sv.maSV
                         join l in qlSV.Lops on sv.maLop equals l.maLop
                         join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                         where d.status == 0
                         where (d.maSV.ToString().Contains(strSearch)
                                    || sv.hoTen.Contains(strSearch))
                         select new ClassDiem
                         {
                             MaSV = (int)d.maSV,
                             HotenSV = sv.hoTen,
                             TenLop = l.tenLop,
                             TenMonHoc = mh.tenMH,
                             DiemQuaTrinh = (double)d.diemQT,
                             DiemThi = (double)d.diemThi,
                         }).ToList();
            return query;
        }

        public bool ThemDiem(string MaSV, string HotenSV, string TenLop, string TenMH,
            string DiemQT, string DiemThi, ref string err)
        {
            bool f = false;
            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var mhQuery = (from mh in qlSV.MonHocs
                               where mh.tenMH == TenMH
                               select mh).SingleOrDefault();
                var lQuery = (from l in qlSV.Lops
                              where l.tenLop == TenLop
                              select l).SingleOrDefault();
                if (mhQuery != null && lQuery != null)
                {
                    int MaMH = mhQuery.maMH;
                    int MaKhoa = (int)lQuery.maKhoa;

                    Diem d = new Diem();
                    d.maMH = MaMH;
                    d.maSV = Int32.Parse(MaSV);
                    d.maKhoa = MaKhoa;
                    d.diemQT = Double.Parse(DiemQT);
                    d.diemThi = Double.Parse(DiemThi);
                    d.status = 0;

                    // Bug
                    qlSV.Diems.InsertOnSubmit(d);
                    qlSV.Diems.Context.SubmitChanges();

                    f = true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            
            return f;
        }

        public bool CapNhatDiem(string MaSV, string TenMH,
            string DiemQT, string DiemThi, ref string err)
        {
            bool f = false;
            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var mhQuery = (from mh in qlSV.MonHocs
                               where mh.tenMH == TenMH
                               select mh).SingleOrDefault();
                if (mhQuery != null)
                {
                    var dQuery = (from d in qlSV.Diems
                                  where d.maSV == Int32.Parse(MaSV)
                                  where d.maMH == mhQuery.maMH
                               select d).SingleOrDefault();
                    if (dQuery != null)
                    {
                        dQuery.diemQT = Double.Parse(DiemQT);
                        dQuery.diemThi = Double.Parse(DiemThi);
                        qlSV.SinhViens.Context.SubmitChanges();
                    }

                    f = true;
                }
                
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }


            return f;
        }

        public bool XoaDiem(string MaSV, string TenMH, ref string err)
        {
            bool f = false;
            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var mhQuery = (from mh in qlSV.MonHocs
                               where mh.tenMH == TenMH
                               select mh).SingleOrDefault();
                if (mhQuery != null)
                {
                    var dQuery = (from d in qlSV.Diems
                                  where d.maSV == Int32.Parse(MaSV)
                                  where d.maMH == mhQuery.maMH
                                  select d).SingleOrDefault();
                    if (dQuery != null)
                    {
                        dQuery.status = 1;
                        qlSV.SinhViens.Context.SubmitChanges();
                    }

                    f = true;
                }

            }
            catch (Exception ex)
            {
                err = ex.Message;
            }


            return f;
        }

        public List<ClassDiem> LayDataReportD(string mssv)
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var query = (from d in qlSV.Diems
                         join sv in qlSV.SinhViens on d.maSV equals sv.maSV
                         join l in qlSV.Lops on sv.maLop equals l.maLop
                         join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                         where d.status == 0
                         where (d.maSV == Int32.Parse(mssv))
                         select new ClassDiem
                         {
                             MaSV = (int)d.maSV,
                             HotenSV = sv.hoTen,
                             TenMonHoc = mh.tenMH,
                             DiemQuaTrinh = (double)d.diemQT,
                             DiemThi = (double)d.diemThi,
                         }).ToList();
            return query;
        }

        public ClassTKD LayDataTkD1(string tenKhoa, string tenMonHoc)
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var count1 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemQT >= 0 && d.diemQT < 3)
                          select d).Count();
            var count2 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemQT >= 3 && d.diemQT < 5)
                          select d).Count();
            var count3 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemQT >= 5 && d.diemQT < 7)
                          select d).Count();
            var count4 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemQT >= 7 && d.diemQT < 8)
                          select d).Count();
            var count5 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemQT >= 8 && d.diemQT < 9)
                          select d).Count();
            var count6 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemQT >= 9 && d.diemQT <= 10)
                          select d).Count();
            ClassTKD tk = new ClassTKD();
            tk.DiemMuc0_3 = count1;
            tk.DiemMuc3_5 = count2;
            tk.DiemMuc5_7 = count3;
            tk.DiemMuc7_8 = count4;
            tk.DiemMuc8_9 = count5;
            tk.DiemMuc9_10 = count6;
            return tk;
        }

        public ClassTKD LayDataTkD2(string tenKhoa, string tenMonHoc)
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var count1 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemThi >= 0 && d.diemThi < 3)
                          select d).Count();
            var count2 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemThi >= 3 && d.diemThi < 5)
                          select d).Count();
            var count3 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemThi >= 5 && d.diemThi < 7)
                          select d).Count();
            var count4 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemThi >= 7 && d.diemThi < 8)
                          select d).Count();
            var count5 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemThi >= 8 && d.diemThi < 9)
                          select d).Count();
            var count6 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemThi >= 9 && d.diemThi <= 10)
                          select d).Count();
            ClassTKD tk = new ClassTKD();
            tk.DiemMuc0_3 = count1;
            tk.DiemMuc3_5 = count2;
            tk.DiemMuc5_7 = count3;
            tk.DiemMuc7_8 = count4;
            tk.DiemMuc8_9 = count5;
            tk.DiemMuc9_10 = count6;
            return tk;
        }

        public ClassTKTL LayDataTkTL(string tenKhoa, string tenMonHoc)
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var count1 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          where (d.diemThi + d.diemQT)/2 >= 5 && d.diemThi >= 3
                          select d).Count();
            var count2 = (from d in qlSV.Diems
                          join kh in qlSV.Khoas on d.maKhoa equals kh.maKhoa
                          join mh in qlSV.MonHocs on d.maMH equals mh.maMH
                          where d.status == 0
                          where kh.tenKhoa == tenKhoa
                          where mh.tenMH == tenMonHoc
                          select d).Count();
            ClassTKTL tk = new ClassTKTL();
            tk.QuaMon = count1;
            tk.RotMon = count2 - count1;
            return tk;
        }
    }
}
