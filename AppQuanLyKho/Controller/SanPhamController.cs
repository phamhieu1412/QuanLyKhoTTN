using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLyKho.Model;
using System.Data;


namespace AppQuanLyKho.Controller
{
    class SanPhamController
    {
        dataProvider data = new dataProvider();

        public bool KiemSanPham(string masp)
        {
            string query = string.Format("select * from SanPham where MaSP = '{0}'", masp);

            return data.CheckMa(query) == masp;

        }
        public bool ThemSanPham(SanPham sp)
        {
            string query = string.Format("exec THEMSANPHAM '{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}' ", sp.MaSanPham, sp.TenSanPham, sp.HamMucDuTru, sp.NuocSanXuat, sp.DonVi, sp.DonGia, sp.PhanLoai);

            return data.ExcutiveNonQuery(query);
        }

    }
}