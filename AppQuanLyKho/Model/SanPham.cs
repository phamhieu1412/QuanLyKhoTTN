using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyKho.Model
{
    class SanPham
    {
        private string maSanPham;
        private string tenSanPham;
        private int hamMucDuTru;
        private string nuocSanXuat;
        private int donGia;
        private string donVi;
        private string phanLoai;
        public SanPham(string maSanPham, string tenSanPham, int hamMucDuTru, string nuocSanXuat, int donGia, string donVi, string phanLoai)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.hamMucDuTru = hamMucDuTru;
            this.nuocSanXuat = nuocSanXuat;
            this.donGia = donGia;
            this.donVi = donVi;
            this.phanLoai = phanLoai;
        }

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int HamMucDuTru { get => hamMucDuTru; set => hamMucDuTru = value; }
        public string NuocSanXuat { get => nuocSanXuat; set => nuocSanXuat = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
    }
}
