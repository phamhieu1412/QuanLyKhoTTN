using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyKho.Model
{
    class PhieuNhap
    {
        private string mapn;
        private string ngaynhap;
        private decimal tongtien;
        private string ghichu;
        private string mancc;
        private int id;

        public PhieuNhap(string mapn, string ngaynhap, decimal tongtien, string ghichu, string mancc, int id)
        {
            this.mapn = mapn;
            this.ngaynhap = ngaynhap;
            this.tongtien = tongtien;
            this.ghichu = ghichu;
            this.mancc = mancc;
            this.id = id;
        }

        public string Mapn { get => mapn; set => mapn = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public decimal Tongtien { get => tongtien; set => tongtien = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public int Id { get => id; set => id = value; }
    }
}