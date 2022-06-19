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
    internal class BLMonHoc
    {
        public List<ClassMH> LayMonHoc(string strSearch = "")
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var query = (from mh in qlSV.MonHocs
                         where mh.status == 0
                         where (mh.maMH.ToString().Contains(strSearch)
                                    || mh.tenMH.Contains(strSearch))
                         select new ClassMH
                         {
                             MaMonHoc = mh.maMH,
                             TenMonHoc = mh.tenMH,
                             SoTinChi = (int)mh.soTinChi
                         }).ToList();
            return query;
        }

        public bool ThemMonHoc(string MaMH, string TenMH, string SoTinChi, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();

                MonHoc mh = new MonHoc();
                mh.maMH = Int32.Parse(MaMH);
                mh.tenMH = TenMH;
                mh.soTinChi = Int32.Parse(SoTinChi);
                mh.status = 0;

                qlSV.MonHocs.InsertOnSubmit(mh);
                qlSV.MonHocs.Context.SubmitChanges();

                f = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return f;
        }

        public bool CapNhatMonHoc(string MaMH, string TenMH, string SoTinChi, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var mhQuery = (from mh in qlSV.MonHocs
                               where mh.maMH == Int32.Parse(MaMH)
                               select mh).SingleOrDefault();
                if (mhQuery != null)
                {
                    mhQuery.tenMH = TenMH;
                    mhQuery.soTinChi = Int32.Parse(SoTinChi);
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

        public bool XoaMonHoc(string MaMH, ref string err)
        {
            bool f = false;

            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var mhQuery = (from mh in qlSV.MonHocs
                               where mh.maMH == Int32.Parse(MaMH)
                               select mh).SingleOrDefault();
                if (mhQuery != null)
                {
                    mhQuery.status = 1;
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

        public List<MonHoc> LayDataReportMH(string strSearch = "")
        {
            QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
            var query = (from mh in qlSV.MonHocs
                         where mh.status == 0
                         where (mh.maMH.ToString().Contains(strSearch)
                                    || mh.tenMH.Contains(strSearch))
                         select mh).ToList();
                         
            return query;
        }
    }
}
