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
using System.Text.RegularExpressions;
using AppQuanLyKho.Controller;
using AppQuanLyKho.Model;


//using PagedList;

namespace AppQuanLyKho.View
{
    public partial class NhaCungCap : Form
    {
        dataProvider provider;

        NhaCungCapController nhaCCcontroller = new NhaCungCapController();
        public NhaCungCap()
        {

            provider = new dataProvider();
            InitializeComponent();
        }

        private void XoaData()
        {
            textBoxMaNCC.Text = "";
            textBoxTenNCC.Text = "";
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
            dGVNCC.DataSource = nhaCCcontroller.XemTatCaNhaCungCap();
        }
        
     
        private void LoadDataFromDataGridToTextBox()
        {
            //Bindings
            //xoa du lieu co san trong Textbox.
            //load lai du lieu tu datagridview
            textBoxMaNCC.DataBindings.Clear();
            textBoxMaNCC.DataBindings.Add("Text", dGVNCC.DataSource, "MaNCC");
            // Text: kieu chuoi 
            textBoxTenNCC.DataBindings.Clear();
            textBoxTenNCC.DataBindings.Add("Text", dGVNCC.DataSource, "TenNCC");

            textBoxDiaChi.DataBindings.Clear();
            textBoxDiaChi.DataBindings.Add("Text", dGVNCC.DataSource, "DiaChi");

            textBoxSDT.DataBindings.Clear();
            textBoxSDT.DataBindings.Add("Text", dGVNCC.DataSource, "DienThoai");
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dGVNCC.DataSource = nhaCCcontroller.XemTatCaNhaCungCap();
            LoadDataFromDataGridToTextBox();
        }

        public string XoaKiTuTrangOGiua(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf("  ") >= 0)
                {
                    s = s.Replace("  ", " ");
                }
            }
            return s;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            bool matchMANCC = Regex.IsMatch(textBoxMaNCC.Text, @"^\s");
            bool matchTENNCC = Regex.IsMatch(textBoxTenNCC.Text, @"^\s");
            bool matchDIACHI = Regex.IsMatch(textBoxDiaChi.Text, @"^\s");
            bool matchSDT = Regex.IsMatch(textBoxSDT.Text, @"^\s");

            textBoxMaNCC.Text = textBoxMaNCC.Text.Trim();
            textBoxTenNCC.Text = textBoxTenNCC.Text.Trim();
            textBoxDiaChi.Text = textBoxDiaChi.Text.Trim();
            textBoxSDT.Text = textBoxSDT.Text.Trim();

            if (textBoxMaNCC.Text == "")
            {
                MessageBox.Show("Mã Nhà Cung Cấp không Được Để Trống");
                textBoxMaNCC.Focus();
            }
            else if (textBoxTenNCC.Text == "")
            {
                MessageBox.Show("Tên Nhà Cung Cấp không Được Để Trống");
                textBoxTenNCC.Focus();
            }
            else if (textBoxDiaChi.Text == "")
            {
                MessageBox.Show("Địa Chỉ Nhà Cung Cấp không Được Để Trống");
                textBoxDiaChi.Focus();
            }
            else if (textBoxSDT.Text == "")
            {
                MessageBox.Show("Số Điện Thoại Nhà Cung Cấp không Được Để Trống");
                textBoxSDT.Focus();
            }
            else
            {
                if (matchMANCC)
                {
                    MessageBox.Show("Mã Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxMaNCC.Focus();
                }
                else if (matchTENNCC)
                {
                    MessageBox.Show("Tên Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxTenNCC.Focus();
                }
                else if (matchDIACHI)
                {
                    MessageBox.Show("Địa Chỉ Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxDiaChi.Focus();
                }
                else if (matchSDT)
                {
                    MessageBox.Show("Số Điện Thoại Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxSDT.Focus();
                }
                else if (textBoxMaNCC.Text.Length > 8)
                {
                    MessageBox.Show("Mã Nhà Cung cấp Tối Đa 8 Kí Tự ");
                    textBoxMaNCC.Focus();
                }

                else if (textBoxSDT.Text.Length > 11)
                {
                    MessageBox.Show("SDT Tối Đa 11 Kí Tự ");
                    textBoxSDT.Focus();
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thêm Nhà Cung Cấp Này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            textBoxMaNCC.Text = XoaKiTuTrangOGiua(textBoxMaNCC.Text);
                            textBoxTenNCC.Text = XoaKiTuTrangOGiua(textBoxTenNCC.Text);
                            textBoxDiaChi.Text = XoaKiTuTrangOGiua(textBoxDiaChi.Text);
                            textBoxSDT.Text = XoaKiTuTrangOGiua(textBoxSDT.Text);

                            provider.InsertNhaCungCap(textBoxMaNCC.Text, textBoxTenNCC.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                            XoaData();
                            dGVNCC.DataSource = nhaCCcontroller.XemTatCaNhaCungCap();
                            LoadDataFromDataGridToTextBox();
                            MessageBox.Show("Thêm Bản Ghi Mới Thành Công!!");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Trùng Mã Nhà Cung Cấp");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lần Sau Cân Nhắc Kĩ Nha Bạn!!");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            bool matchMANCC = Regex.IsMatch(textBoxMaNCC.Text, @"^\s");
            bool matchTENNCC = Regex.IsMatch(textBoxTenNCC.Text, @"^\s");
            bool matchDIACHI = Regex.IsMatch(textBoxDiaChi.Text, @"^\s");
            bool matchSDT = Regex.IsMatch(textBoxSDT.Text, @"^\s");

            textBoxMaNCC.Text = textBoxMaNCC.Text.Trim();
            textBoxTenNCC.Text = textBoxTenNCC.Text.Trim();
            textBoxDiaChi.Text = textBoxDiaChi.Text.Trim();
            textBoxSDT.Text = textBoxSDT.Text.Trim();

            if (textBoxMaNCC.Text == "")
            {
                MessageBox.Show("Mã Nhà Cung Cấp không Được Để Trống");
                textBoxMaNCC.Focus();
            }
            else if (textBoxTenNCC.Text == "")
            {
                MessageBox.Show("Tên Nhà Cung Cấp không Được Để Trống");
                textBoxTenNCC.Focus();
            }
            else if (textBoxDiaChi.Text == "")
            {
                MessageBox.Show("Địa Chỉ Nhà Cung Cấp không Được Để Trống");
                textBoxDiaChi.Focus();
            }
            else if (textBoxSDT.Text == "")
            {
                MessageBox.Show("Số Điện Thoại Nhà Cung Cấp không Được Để Trống");
                textBoxSDT.Focus();
            }
            else
            {
                if (matchMANCC)
                {
                    MessageBox.Show("Mã Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxMaNCC.Focus();
                }
                else if (matchTENNCC)
                {
                    MessageBox.Show("Tên Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxTenNCC.Focus();
                }
                else if (matchDIACHI)
                {
                    MessageBox.Show("Địa Chỉ Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxDiaChi.Focus();
                }
                else if (matchSDT)
                {
                    MessageBox.Show("Số Điện Thoại Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxSDT.Focus();
                }
                else if (textBoxMaNCC.Text.Length > 8)
                {
                    MessageBox.Show("Mã Nhà Cung Cấp Tối Đa 8 Kí Tự ");
                    textBoxMaNCC.Focus();
                }

                else if (textBoxSDT.Text.Length > 11)
                {
                    MessageBox.Show("SDT Tối Đa 11 Kí Tự ");
                    textBoxSDT.Focus();
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Nhà Cung Cấp Này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        textBoxMaNCC.Text = XoaKiTuTrangOGiua(textBoxMaNCC.Text);
                        textBoxTenNCC.Text = XoaKiTuTrangOGiua(textBoxTenNCC.Text);
                        textBoxDiaChi.Text = XoaKiTuTrangOGiua(textBoxDiaChi.Text);
                        textBoxSDT.Text = XoaKiTuTrangOGiua(textBoxSDT.Text);

                        provider.UpdateNhaCungCap(textBoxMaNCC.Text, textBoxTenNCC.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                        XoaData();
                        dGVNCC.DataSource = nhaCCcontroller.XemTatCaNhaCungCap();
                        LoadDataFromDataGridToTextBox();
                        MessageBox.Show("Cập Nhật bản ghi thành công");

                    }
                    else
                    {
                        MessageBox.Show("Lần Sau Cân Nhắc Kĩ Nha Bạn!!");
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool matchMANCC = Regex.IsMatch(textBoxMaNCC.Text, @"^\s");

            if (textBoxMaNCC.Text == "")
            {
                MessageBox.Show("Mã Nhà Cung Cấp không Được Để Trống");
                textBoxMaNCC.Focus();
            }
            else
            {
                if (matchMANCC)
                {
                    MessageBox.Show("Mã Nhà Cung Cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxMaNCC.Focus();
                }
                else
                {
                    dGVNCC.DataSource = provider.SearchNhaCungCap(textBoxMaNCC.Text);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Nhà Cung Cấp Này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                provider.DeleteNhaCungCap(textBoxMaNCC.Text);
                dGVNCC.DataSource = nhaCCcontroller.XemTatCaNhaCungCap();
                LoadDataFromDataGridToTextBox();
                MessageBox.Show("Xóa Bản Ghi Thành Công");

            }
            else
            {
                MessageBox.Show("Lần Sau Cân Nhắc Kĩ Nha Bạn!!");
            }
        }

        private void btnXoaTam_Click(object sender, EventArgs e)
        {
            XoaData();
        }

        private void NhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                TroGiup.FormName = "GDC_NV" + this.Name;
                TroGiup troGiup = new TroGiup();
                troGiup.ShowDialog();
            }
        }
    }

}
