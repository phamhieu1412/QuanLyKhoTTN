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
using System.Data.SqlClient;

namespace AppQuanLyKho.View
{
    public partial class  PhieuXuat: Form
    {
        List<SanPham> danhSachSanPham;
        List<string> danhSachLoai;
        dataProvider provider;
        public PhieuXuat()
        {
            //
            danhSachSanPham = new List<SanPham>();
            danhSachLoai = new List<string>();
            provider = new dataProvider();
            InitializeComponent();
            dTNgayBan.CustomFormat = "yyyy-MM-dd";
        }

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            dataGridViewDSSP.DataSource = provider.GetSanPham(1, "Tất cả");
            tbMaPN.Text = provider.MaPhieuXuatMoi();
            
        }

        private void PhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TroGiup.FormName = "GDC_NV_XuatKho";
                TroGiup troGiup = new TroGiup();
                troGiup.ShowDialog();
            }
        }
       

        private void dataGridViewDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow current = dataGridViewDSSP.CurrentRow;
            tbMaSP.Text = current.Cells[0].Value.ToString();
            tbTenSP.Text = current.Cells[1].Value.ToString();
            tbDonGia.Text = current.Cells[4].Value.ToString(); 
        }

        private void tbSL_TextChanged(object sender, EventArgs e)
        {
            /*  DataGridViewRow current = dataGridViewDSSP.CurrentRow;
              if(tbSL.Text != "")
              {
                  if (Convert.ToInt32(tbSL.Text) > Convert.ToInt32(current.Cells[2].Value.ToString()))
                  {
                      MessageBox.Show("Vượt quá số lượng hiện có ");
                  }
              }

              tbSL.Text = "";*/
            if (tbSL.Text != "" && tbDonGia.Text != "")
            {
                //DataGridViewRow current = dataGridViewDSSP.CurrentRow;
                tbThanhToan.Text = (Convert.ToInt32(tbSL.Text) * Convert.ToInt32(tbDonGia.Text)).ToString();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if(provider.KiemTraMaKH(tbMaKH.Text) == false && tbMaKH.Text != "" && tbTen.Text != "")
            {
                provider.ThemKH(tbMaKH.Text, tbTen.Text);
            }
        }

        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbTen_Click(object sender, EventArgs e)
        {
            if(tbMaKH.Text != "")
                tbTen.Text = provider.TenKhachHang(tbMaKH.Text);
        }

        private void tbThanhToan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbDonGia_TextChanged(object sender, EventArgs e)
        {
            if (tbSL.Text != "" && tbDonGia.Text != "")
            {
                //DataGridViewRow current = dataGridViewDSSP.CurrentRow;
                tbThanhToan.Text = (Convert.ToInt32(tbSL.Text) * Convert.ToInt32(tbDonGia.Text)).ToString();
            }
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(provider.KiemTraMaKH(tbMaKH.Text) == false)
            {
                MessageBox.Show("khach hang chua ton tai \n them khach hang truoc");
            }
            else if(tbThanhToan.Text == "")
            {
                MessageBox.Show("Chọn sản phẩm và nhập số lượng sản phẩm");
            }
            else if(tbMaKH.Text != "" && tbThanhToan.Text  != "" && provider.KiemTraMaKH(tbMaKH.Text) == true)
            {
                dTNgayBan.CustomFormat = "yyyy-MM-dd";
                int TT = Convert.ToInt32(tbThanhToan.Text);
                int SL = Convert.ToInt32(tbSL.Text); 
                provider.ThemPhieuXuat(tbMaPN.Text, dTNgayBan.Value, TT, tbGhiChu.Text,  DangNhap.ID, tbMaSP.Text, SL,tbMaKH.Text);
            }
        }

        private void tbMaSP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn thông tin sản phẩm ở mục danh sách sản phẩm");
        }
    }
}
