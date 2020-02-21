using AppQuanLyKho.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKho.View
{
    public partial class SuaSanPham : Form
    {
        dataProvider provider;
        public SuaSanPham()
        {
            InitializeComponent();
        }
        public SuaSanPham(string masp, string tensp, string nuocsx, int dongia, string donvi)
        {
            InitializeComponent();
            provider = new dataProvider();
            maSPTb.Text = masp;
            tenSPTb.Text = tensp;
            nuocSXTb.Text = nuocsx;
            donGiaTb.Text = dongia.ToString();
            donViTb.Text = donvi;
            maSPTb.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            provider.UpdateSanPham(maSPTb.Text, tenSPTb.Text, nuocSXTb.Text, donGiaTb.Text, donViTb.Text);
            this.Close();
        }
    }
}
