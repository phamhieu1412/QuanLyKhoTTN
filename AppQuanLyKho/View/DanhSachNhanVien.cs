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
    public partial class DanhSachNhanVien : Form
    {
        dataProvider provider;

        public DanhSachNhanVien()
        {
            InitializeComponent();
            dTPNgaySinh.CustomFormat = "yyyy-MM-dd";

            cbbGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbGT.Items.Add("Nam");
            cbbGT.Items.Add("Nữ");

            cbbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbQuyen.Items.Add("Admin");
            cbbQuyen.Items.Add("Nhân viên");

            cbbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbIsActive.Items.Add("True");
            cbbIsActive.Items.Add("False");

            btnLuu.Enabled = false;
        }
        NhanVienController ctrl = new NhanVienController();
        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewDSNV.DataSource = ctrl.XemTatCaNV();
            dataGridViewDSNV.Refresh();

            this.KeyPreview = true;
        }

        private void DataGridViewDSNV_DoubleClick(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;

            int index = dataGridViewDSNV.SelectedRows[0].Index;

            txtId.Text = dataGridViewDSNV.Rows[index].Cells["Id"].Value.ToString();
            txtTK.Text = dataGridViewDSNV.Rows[index].Cells["TenDN"].Value.ToString();
            txtMK.Text = dataGridViewDSNV.Rows[index].Cells["MatKhau"].Value.ToString();
            txtTen.Text = dataGridViewDSNV.Rows[index].Cells["HoTen"].Value.ToString();
            txtSDT.Text = dataGridViewDSNV.Rows[index].Cells["SDT"].Value.ToString();
            cbbGT.Text = dataGridViewDSNV.Rows[index].Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = dataGridViewDSNV.Rows[index].Cells["DiaChi"].Value.ToString(); 
            txtEmail.Text = dataGridViewDSNV.Rows[index].Cells["Email"].Value.ToString();
            cbbQuyen.Text = dataGridViewDSNV.Rows[index].Cells["isAdmin"].Value.ToString();
            cbbIsActive.Text = dataGridViewDSNV.Rows[index].Cells["isActive"].Value.ToString();

            try
            { 
                dTPNgaySinh.Value = DateTime.Parse(dataGridViewDSNV.Rows[index].Cells["NgaySinh"].Value.ToString()); 
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh của nhân viên có vấn đề! Mời sửa lại."); 
                dTPNgaySinh.Value = DateTime.Now; 
            }

           
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            bool matchTK = Regex.IsMatch(txtTK.Text, @"^\s");
            bool matchMK = Regex.IsMatch(txtMK.Text, @"^\s");
            bool matchTen = Regex.IsMatch(txtTen.Text, @"^\s");
            bool matchSDT = Regex.IsMatch(txtSDT.Text, @"^\s");
            bool matchDiaChi = Regex.IsMatch(txtDiaChi.Text, @"^\s");
            bool matchGT = Regex.IsMatch(cbbGT.Text, @"^\s");
            bool matchEmail = Regex.IsMatch(txtEmail.Text, @"^\s");
            bool matchQuyen = Regex.IsMatch(cbbQuyen.Text, @"^\s");
            bool matchActive = Regex.IsMatch(cbbIsActive.Text, @"^\s");

            txtTK.Text = txtTK.Text.Trim();
            txtMK.Text = txtMK.Text.Trim();
            txtTen.Text = txtTen.Text.Trim();
            txtSDT.Text = txtSDT.Text.Trim();
            cbbGT.Text = cbbGT.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtEmail.Text = txtEmail.Text.Trim();
            cbbQuyen.Text = cbbQuyen.Text.Trim();
            cbbIsActive.Text = cbbIsActive.Text.Trim();

            if (txtTK.Text == "")
            {
                MessageBox.Show("Tên tài khoản không Được Để Trống");
                txtTK.Focus();
            }
            else if (txtMK.Text == "")
            {
                MessageBox.Show("Mật khẩu không Được Để Trống");
                txtMK.Focus();
            }
            else if (txtTen.Text == "")
            {
                MessageBox.Show("Tên người dùng không Được Để Trống");
                txtTen.Focus();
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không Được Để Trống");
                txtSDT.Focus();
            }
            else if (cbbGT.Text == "")
            {
                MessageBox.Show("Giới tính không Được Để Trống");
                cbbGT.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không Được Để Trống");
                txtDiaChi.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email không Được Để Trống");
                txtEmail.Focus();
            }
            else if (cbbQuyen.Text == "")
            {
                MessageBox.Show("Quyền không Được Để Trống");
                cbbQuyen.Focus();
            }
            else if (cbbIsActive.Text == "")
            {
                MessageBox.Show("Trạng thái không Được Để Trống");
                cbbIsActive.Focus();
            }
            else
            {
                if (matchTK)
                {
                    MessageBox.Show("Tài khoản không Được Để Tất Cả Là Khoảng Trắng");
                    txtTK.Focus();
                }
                else if (matchMK)
                {
                    MessageBox.Show("Mật khẩu không Được Để Tất Cả Là Khoảng Trắng");
                    txtMK.Focus();
                }
                else if (matchTen)
                {
                    MessageBox.Show("Tên người dùng không Được Để Tất Cả Là Khoảng Trắng");
                    txtTen.Focus();
                }
                else if (matchSDT)
                {
                    MessageBox.Show("Số điện thoại không Được Để Tất Cả Là Khoảng Trắng");
                    txtSDT.Focus();
                }
                else if (matchDiaChi)
                {
                    MessageBox.Show("Địa chỉ không Được Để Tất Cả Là Khoảng Trắng");
                    txtDiaChi.Focus();
                }
                else if (matchGT)
                {
                    MessageBox.Show("Giới tính không Được Để Tất Cả Là Khoảng Trắng");
                    cbbGT.Focus();
                }
                else if (matchEmail)
                {
                    MessageBox.Show("Email không Được Để Tất Cả Là Khoảng Trắng");
                    txtEmail.Focus();
                }
                else if (matchQuyen)
                {
                    MessageBox.Show("Quyền không Được Để Tất Cả Là Khoảng Trắng");
                    cbbQuyen.Focus();
                }
                else if (matchActive)
                {
                    MessageBox.Show("Trạng thái người dùng không Được Để Tất Cả Là Khoảng Trắng");
                    cbbIsActive.Focus();
                }
                else if (txtSDT.Text.Length > 11)
                {
                    MessageBox.Show("SDT tối đa chỉ 11 số ");
                    txtSDT.Focus();
                }
                else
                {
                    bool GioiTinh = true;
                    bool isAdmin = false;
                    if (cbbGT.SelectedItem.ToString() == "Nam")
                    {
                        GioiTinh = true;
                    }
                    else
                    {
                        GioiTinh = false;
                    }

                    if (cbbQuyen.SelectedItem.ToString() == "Admin")
                    {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }

                    NhanVien nv = new NhanVien(txtTK.Text, txtMK.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text, dTPNgaySinh.Value, GioiTinh, txtEmail.Text, bool.Parse(cbbIsActive.Text), isAdmin);

                    if (ctrl.Them(nv))
                    {
                        MessageBox.Show("Thêm mới thành công");

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
                        dTPNgaySinh.Value = DateTime.Now;
                    }
                    else MessageBox.Show("Thêm mới thất bại");

                    dataGridViewDSNV.DataSource = ctrl.XemTatCaNV();
                    dataGridViewDSNV.Refresh();
                }
            }
            
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
                dTPNgaySinh.Value = DateTime.Now;
            }
            else MessageBox.Show("Sửa thất bại");

            dataGridViewDSNV.DataSource = ctrl.XemTatCaNV();
            dataGridViewDSNV.Refresh();
        }

        private void DanhSachNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TroGiup.FormName = "GDC_TK_QuanLy";
                TroGiup troGiup = new TroGiup();
                troGiup.ShowDialog();
            }
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text != "")
            {
                provider = new dataProvider();
                dataGridViewDSNV.DataSource = provider.TimKiemNV(tbTimKiem.Text);
            }
        }
    }
}
