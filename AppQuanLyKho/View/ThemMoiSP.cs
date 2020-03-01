using AppQuanLyKho.Controller;
using AppQuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKho.View
{
    public partial class ThemMoiSP : Form
    {
        SanPhamController spCtrl = new SanPhamController();
        dataProvider data = new dataProvider();

        List<string> loais;

        public ThemMoiSP()
        {
            InitializeComponent();
            getDS_Loai();
        }

        private void BtnThemSP_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();

            sp.MaSanPham = textBoxMaSP.Text;
            sp.TenSanPham = textBoxTensp.Text;
            sp.NuocSanXuat = textBoxNSX.Text;
            sp.DonGia = decimal.Parse(textBoxDonGia.Text);
            sp.PhanLoai = comboBoxPhanLoai.SelectedItem.ToString();
            sp.DonVi = textBoxDonViTinh.Text;
            sp.HamMucDuTru = 0;

            if (sp.MaSanPham == "" || sp.TenSanPham == "" || Regex.IsMatch(sp.MaSanPham, @"^\s") || Regex.IsMatch(sp.TenSanPham, @"^\s"))
            {
                MessageBox.Show("Mã sản phẩm và tên sản phẩm không được bỏ trống");
                textBoxMaSP.Text = "";
                textBoxTensp.Text = "";
            }
            else
            {
                if (spCtrl.KiemSanPham(sp.MaSanPham))
                {
                    MessageBox.Show("mã sản phẩm đã tồn tại !");
                    textBoxMaSP.Text = "";
                }
                else
                {
                    spCtrl.ThemSanPham(sp);
                    GiaoDienChinh.Dgv.DataSource = data.GetSanPham(1, "Tất cả");
                    GiaoDienChinh.Dgv.Refresh();
                }
            }
        }
        public void getDS_Loai()
        {
            loais = data.GetMaLoai();
            comboBoxPhanLoai.DataSource = loais;
        }
    }
}
