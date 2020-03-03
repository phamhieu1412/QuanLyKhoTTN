using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLyKho.Model;
using System.Data;

namespace AppQuanLyKho.Controller
{
    class NhaCungCapController
    {
        dataProvider data = new dataProvider();
        /*
        public bool InsertNhaCungCap(NhaCungCap nhaCungCap) {

            string query = string.Format("exec THEMNHACUNGCAP '{0}', '{1}', {2}, '{3}', ", nhaCungCap.MaNhaCungCap, nhaCungCap.TenNhaCungCap, nhaCungCap.DiaChi, nhaCungCap.SoDienThoai);
            return data.ExcutiveNonQuery(query);
        }
        */
        public DataTable XemTatCaNhaCungCap()
        {
            string query = string.Format("exec XEMNHACUNGCAP ");

            return data.ExcutiveQuery(query);
        }


    }
}