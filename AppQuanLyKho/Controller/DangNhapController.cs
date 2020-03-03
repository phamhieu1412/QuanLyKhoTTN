using AppQuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyKho.Controller
{
    class DangNhapController
    {
        NhanVien nv = new NhanVien();

        dataProvider data = new dataProvider();

        public int KtraDN(string tenDN, string matKhau)
        {
            string query = string.Format("select isAdmin from NhanVien where TenDN = '{0}' and MatKhau= '{1}' ", tenDN, matKhau);

            DataTable ktra = data.ExcutiveQuery(query);

            if (ktra.Rows.Count == 0)
            {
                return 0;
            }
            else
            {

                string s = ktra.Rows[0]["isAdmin"].ToString();

                if (s == "True")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        //lay id theo tenDN
        public int LayID(string tenDN)
        {
            string query = string.Format("select Id from NhanVien where TenDN = '{0}' ", tenDN);

            DataTable id = data.ExcutiveQuery(query);
            return int.Parse(id.Rows[0]["Id"].ToString());
        }

        public bool DoiMatKhau(NhanVien nhanVien)
        {
            string query = string.Format("update NhanVien set MatKhau = '{0}' where Id = {1}", nhanVien.MatKhau, nhanVien.Id);

            return data.ExcutiveNonQuery(query);
        }
    }
}
