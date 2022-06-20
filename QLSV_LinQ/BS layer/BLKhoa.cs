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
    internal class BLKhoa
    {
        public List<ClassKhoa> LayKhoa(string strSearch = "")
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var query = (from k in qlSV.Khoas
                         where k.status == 0
                         where (k.maKhoa.ToString().Contains(strSearch)
                                    || k.tenKhoa.Contains(strSearch))
                         select new ClassKhoa
                         {
                             MaKhoa = k.maKhoa,
                             TenKhoa = k.tenKhoa,
                             NamBatDau = (int)k.namBatDau,
                             NamKetThuc = (int)k.namKetThuc,
                         }).ToList();
            return query;
        }

        public bool ThemKhoa(string MaKhoa, string TenKhoa, string NamBatDau,
            string NamKetThuc, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();

                Khoa k = new Khoa();
                k.maKhoa = Int32.Parse(MaKhoa);
                k.tenKhoa = TenKhoa;
                k.namBatDau = Int32.Parse(NamBatDau);
                k.namKetThuc = Int32.Parse(NamKetThuc);
                k.status = 0;
                qlSV.Khoas.InsertOnSubmit(k);
                qlSV.Khoas.Context.SubmitChanges();

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }

        public bool CapNhatKhoa(string MaKhoa, string TenKhoa, string NamBatDau,
            string NamKetThuc, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var kQuery = (from k in qlSV.Khoas
                               where k.maKhoa == Int32.Parse(MaKhoa)
                               select k).SingleOrDefault();
                if (kQuery != null)
                {
                    kQuery.tenKhoa = TenKhoa;
                    kQuery.namBatDau = Int32.Parse(NamBatDau);
                    kQuery.namKetThuc = Int32.Parse(NamKetThuc);
                    qlSV.Khoas.Context.SubmitChanges();
                }

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }

        public bool XoaKhoa(string MaKhoa, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var kQuery = (from k in qlSV.Khoas
                              where k.maKhoa == Int32.Parse(MaKhoa)
                              select k).SingleOrDefault();
                if (kQuery != null)
                {
                    kQuery.status = 1;
                    qlSV.Khoas.Context.SubmitChanges();
                }

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }

        public string[] LayTenKhoa()
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var query = (from k in qlSV.Khoas
                         where k.status == 0
                         select k.tenKhoa).ToArray();
            return query;
        }
    }
}
