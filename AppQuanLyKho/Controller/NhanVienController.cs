using AppQuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyKho.Controller
{
    class NhanVienController
    {
        dataProvider data = new dataProvider();
        public bool Them(NhanVien nhanVien)
        {
            string query = string.Format("exec THEMNHANVIEN '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', {8}  ", nhanVien.TenDangNhap, nhanVien.MatKhau, nhanVien.HoTen, nhanVien.DiaChi, nhanVien.Sdt, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.Email, nhanVien.IsActive);

            return data.ExcutiveNonQuery(query);
        }

        public bool Sua(NhanVien nhanVien)
        {
            string query = string.Format("exec SUATHONGTINNHANVIEN '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', {8}  ", nhanVien.TenDangNhap, nhanVien.MatKhau, nhanVien.HoTen, nhanVien.DiaChi, nhanVien.Sdt, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.Email, nhanVien.IsActive);

            return data.ExcutiveNonQuery(query);
        }

        public bool Xoa(NhanVien nhanVien)
        {
            string query = string.Format(" update NhanVien set isActive = 1");

            return data.ExcutiveNonQuery(query);
        }

        //public bool TimKiem(NhanVien nhanVien)
        //{

        //}
    }
}
