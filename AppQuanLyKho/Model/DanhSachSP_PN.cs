using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyKho.Model
{
    class DanhSachSP_PN
    {
        private string masp;
        private string tensp;
        private string mapn;
        private int soluong;
        private decimal dongia;

        public DanhSachSP_PN(string masp, string tensp, string mapn, int soluong, decimal dongia)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.mapn = mapn;
            this.soluong = soluong;
            this.dongia = dongia;
        }

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Mapn { get => mapn; set => mapn = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
    }
}