using AppQuanLyKho.Controller;
using AppQuanLyKho.Model;
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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        NhanVienController nvCtrl = new NhanVienController();
        DangNhapController dnCtrl = new DangNhapController();

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv = nvCtrl.XemMotNV(DangNhap.ID);

            txtTenDN.Text = nv.TenDangNhap;
            txtMKHienTai.Text = nv.MatKhau;
            this.KeyPreview = true;
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv = nvCtrl.XemMotNV(DangNhap.ID);

            if (txtMKMoi.Text == txtMKMoi1.Text)
            {
                nv.MatKhau = txtMKMoi.Text;

                if (dnCtrl.DoiMatKhau(nv))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Hide();
                }
                else MessageBox.Show("Sửa thất bại");
            }
            else
                MessageBox.Show("Mật khẩu mới không trùng nhau !");
           
        }

        private void DoiMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TroGiup.FormName = "GDC_TK_" + this.Name;
                TroGiup troGiup = new TroGiup();
                troGiup.ShowDialog();
            }
        }
    }

}
