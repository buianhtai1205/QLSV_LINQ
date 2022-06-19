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
    internal class BLLop
    {
        public List<ClassLop> LayLop(string strSearch = "")
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var query = (from l in qlSV.Lops
                         where l.status == 0
                         where (l.maLop.ToString().Contains(strSearch)
                                    || l.tenLop.Contains(strSearch))
                         select new ClassLop
                         {
                             MaLop = l.maLop,
                             MaKhoa = (int)l.maKhoa,
                             TenNganh = l.tenNganh,
                             TenLop = l.tenLop
                         }).ToList();
            return query;
        }

        public bool ThemLop(string MaLop, string MaKhoa, string TenNganh,
            string TenLop, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();

                Lop l = new Lop();
                l.maLop = Int32.Parse(MaLop);
                l.maKhoa = Int32.Parse(MaKhoa);
                l.tenLop = TenLop;
                l.tenNganh = TenNganh;
                l.status = 0;

                qlSV.Lops.InsertOnSubmit(l);
                qlSV.Lops.Context.SubmitChanges();

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }

        public bool CapNhatLop(string MaLop, string MaKhoa, string TenNganh,
            string TenLop, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var lQuery = (from l in qlSV.Lops
                               where l.maLop == Int32.Parse(MaLop)
                               select l).SingleOrDefault();
                if (lQuery != null)
                {
                    lQuery.maKhoa = Int32.Parse(MaKhoa);
                    lQuery.tenNganh = TenNganh;
                    lQuery.tenLop = TenLop;
                    qlSV.Lops.Context.SubmitChanges();
                }

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }

        public bool XoaLop(string MaLop, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var lQuery = (from l in qlSV.Lops
                              where l.maLop == Int32.Parse(MaLop)
                              select l).SingleOrDefault();
                if (lQuery != null)
                {
                    lQuery.status = 1;
                    qlSV.Lops.Context.SubmitChanges();
                }

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }
    }
}
