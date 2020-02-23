using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyKho.Controller;
using AppQuanLyKho.Model;
using System.Text.RegularExpressions;

namespace AppQuanLyKho.View
{
    public partial class Loai : Form
    {
        dataProvider data = new dataProvider();
        NhapSanPham frmsp;
        string maloai;
        string tenloai;
        string mota;
        public Loai(NhapSanPham fsp)
        {
            InitializeComponent();
            frmsp = fsp;
        }

        private void getdata()
        {
            maloai = textBoxMaLoai.Text.ToString();
            tenloai = textBoxTenLoai.Text.ToString();
            mota = textBoxMota.Text.ToString();
            maloai.Trim();
            tenloai.Trim();
            mota.Trim();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            getdata();
            if (maloai == "" || tenloai == "" || Regex.IsMatch(maloai, @"^\s") || Regex.IsMatch(tenloai, @"^\s"))
            {
                MessageBox.Show("Mã loại và tên loại không được bỏ trống");
                textBoxMaLoai.Text = "";
                textBoxTenLoai.Text = "";
                textBoxMota.Text = "";
            }
            else
            {
                string str = string.Format("select * from Loai where maloai = '{0}'", maloai);
                string check = data.CheckMa(str);
                if (check == maloai)
                {
                    MessageBox.Show("Mã loại đã tồn tại!");
                }
                else
                {
                    string str1 = string.Format("THEMLOAI '{0}', '{1}', '{2}'", maloai, tenloai, mota);
                    data.ExcutiveNonQuery(str1);
                    this.Close();
                    //frmsp.getDS_Loai();
                    frmsp.Enabled = true;
                }
            }
        }
    }
}
