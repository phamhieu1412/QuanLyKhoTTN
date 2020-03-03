using AppQuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
            string query = string.Format("exec THEMNHANVIEN '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', {8}, {9}  ", nhanVien.TenDangNhap, nhanVien.MatKhau, nhanVien.HoTen, nhanVien.DiaChi, nhanVien.Sdt, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.Email, nhanVien.IsActive, nhanVien.IsAdmin);

            return data.ExcutiveNonQuery(query);
        }

        public bool Sua(NhanVien nhanVien)
        {
            string query = string.Format("exec SUATHONGTINNHANVIEN {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10} ", nhanVien.Id, nhanVien.TenDangNhap, nhanVien.MatKhau, nhanVien.HoTen, nhanVien.DiaChi, nhanVien.Sdt, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.Email, nhanVien.IsActive, nhanVien.IsAdmin);

            return data.ExcutiveNonQuery(query);
        }

        public bool Xoa(int id)
        {
            string query = string.Format(" update NhanVien set isActive = 0 where Id = {0} ", id);

            return data.ExcutiveNonQuery(query);
        }

        public DataTable XemTatCaNV()
        {
            string query = string.Format("exec XEMTATCANHANVIEN ");

            return data.ExcutiveQuery(query);
        }

        public NhanVien XemMotNV(int id)
        {
            string query = string.Format("exec XEMCHITIETNHANVIEN {0} ", id);

            DataTable dt = data.ExcutiveQuery(query);

            NhanVien nv = new NhanVien();

            //lay ra thong tin nhan vien o 1 dong do so voi 1 dong trong datatable
            nv.Id = Int16.Parse(dt.Rows[0]["Id"].ToString());
            nv.TenDangNhap = dt.Rows[0]["TenDN"].ToString();
            nv.MatKhau = dt.Rows[0]["MatKhau"].ToString();
            nv.HoTen = dt.Rows[0]["HoTen"].ToString();
            nv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            nv.Sdt = dt.Rows[0]["SDT"].ToString();
            nv.NgaySinh = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            nv.GioiTinh = bool.Parse(dt.Rows[0]["GioiTinh"].ToString());
            nv.Email = dt.Rows[0]["Email"].ToString();
            nv.IsActive = bool.Parse(dt.Rows[0]["isActive"].ToString());
            nv.IsAdmin = bool.Parse(dt.Rows[0]["isAdmin"].ToString());

            return nv;
        }

    }
}
