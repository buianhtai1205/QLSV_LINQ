using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace QLSV_LinQ.BS_layer
{
    internal class BLLogin
    {
        public bool CheckLogin(string username, string passw)
        {
            bool f = false;
            try
            {
                QLSinhVienDataContext qlSV = new QLSinhVienDataContext();
                var count = (from a in qlSV.Admins
                             where a.tenDangNhap == username
                             where a.matKhau == passw
                             select a).Count();
                if (count > 0)
                {
                    f = true;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!");
            }
            //var purchCount = (from purchase in myBlaContext.purchases select purchase).Count();

            return f;
        }
    }
}
