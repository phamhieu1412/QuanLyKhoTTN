using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyKho
{
    class SanPham
    {
        private string maSanPham;
        private string tenSanPham;
        private int hamMucDuTru;
        private string nuocSanXuat;
        private int donGia;
        private string phanLoai;
        public SanPham()
        {

        }

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int HamMucDuTru { get => hamMucDuTru; set => hamMucDuTru = value; }
        public string NuocSanXuat { get => nuocSanXuat; set => nuocSanXuat = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
    }
}
