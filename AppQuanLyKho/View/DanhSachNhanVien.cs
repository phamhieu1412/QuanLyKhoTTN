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
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
            dTPNgaySinh.CustomFormat = "yyyy-MM-dd";

            cbbGT.Items.Add("True");
            cbbGT.Items.Add("False");
            cbbQuyen.Items.Add("True");
            cbbQuyen.Items.Add("False");
            cbbIsActive.Items.Add("True");
            cbbIsActive.Items.Add("False");

        }
        NhanVienController ctrl = new NhanVienController();
        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewDSNV.DataSource = ctrl.XemTatCaNV();
            dataGridViewDSNV.Refresh();
        }

        private void DataGridViewDSNV_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridViewDSNV.SelectedRows[0].Index;

            txtId.Text = dataGridViewDSNV.Rows[index].Cells["Id"].Value.ToString();
            txtTK.Text = dataGridViewDSNV.Rows[index].Cells["TenDN"].Value.ToString();
            txtMK.Text = dataGridViewDSNV.Rows[index].Cells["MatKhau"].Value.ToString();
            txtTen.Text = dataGridViewDSNV.Rows[index].Cells["HoTen"].Value.ToString();
            txtSDT.Text = dataGridViewDSNV.Rows[index].Cells["SDT"].Value.ToString();
            cbbGT.Text = dataGridViewDSNV.Rows[index].Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = dataGridViewDSNV.Rows[index].Cells["DiaChi"].Value.ToString();
            dTPNgaySinh.Value = DateTime.Parse(dataGridViewDSNV.Rows[index].Cells["NgaySinh"].Value.ToString());
            txtEmail.Text = dataGridViewDSNV.Rows[index].Cells["Email"].Value.ToString();
            cbbQuyen.Text = dataGridViewDSNV.Rows[index].Cells["isAdmin"].Value.ToString();
            cbbIsActive.Text = dataGridViewDSNV.Rows[index].Cells["isActive"].Value.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtTK.Text = "";
            txtMK.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            cbbGT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            cbbQuyen.Text = "";
            cbbIsActive.Text = "";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int index = dataGridViewDSNV.SelectedRows[0].Index;
            if (ctrl.Xoa(Int16.Parse(dataGridViewDSNV.Rows[index].Cells["Id"].Value.ToString())))
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");

            dataGridViewDSNV.DataSource = ctrl.XemTatCaNV();
            dataGridViewDSNV.Refresh();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            nv.Id = Int16.Parse(txtId.Text);
            nv.TenDangNhap = txtTK.Text;
            nv.MatKhau = txtMK.Text;
            nv.HoTen = txtTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Sdt = txtSDT.Text;
            nv.NgaySinh = dTPNgaySinh.Value;
            nv.GioiTinh = bool.Parse(cbbGT.SelectedItem.ToString());
            nv.Email = txtEmail.Text;
            nv.IsAdmin = bool.Parse(cbbQuyen.SelectedItem.ToString());
            nv.IsActive = bool.Parse(cbbIsActive.SelectedItem.ToString());


            if (ctrl.Sua(nv))
            {
                MessageBox.Show("Sửa thành công");

                txtId.Text = "";
                txtTK.Text = "";
                txtMK.Text = "";
                txtTen.Text = "";
                txtSDT.Text = "";
                cbbGT.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                cbbQuyen.Text = "";
                cbbIsActive.Text = "";
            }
            else MessageBox.Show("Sửa thất bại");

            dataGridViewDSNV.DataSource = ctrl.XemTatCaNV();
            dataGridViewDSNV.Refresh();
        }
    }
}
