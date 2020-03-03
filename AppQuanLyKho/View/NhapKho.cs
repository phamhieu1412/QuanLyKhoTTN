using AppQuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppQuanLyKho.Controller;

namespace AppQuanLyKho.View
{
    public partial class NhapKho : Form
    {
        List<DanhSachSP_PN> ds = new List<DanhSachSP_PN>();
        dataProvider data = new dataProvider();
        List<string> ncc, sp;
        NhanVienController ctrlNV = new NhanVienController();

        private string maNCC;
        private int soluongnhap;
        private decimal dongia;
        private string maDVT;
        private string maPN;
        private string maSP;
        private string tenSP;
        private string NuocSX;
        private string ngaynhap;
        private string ghichu;
        private decimal tongtien;
        private int id;

        private bool suaSP = false;
        private int index;

        public NhapKho()
        {
            InitializeComponent();

            getNCC();
            getSP();
            //==============================
            //maPN = tbMaPN.Text.ToString();

            //==============================
            //tenDN = tbTenNV.Text.ToString();
            NhanVien infoNV = new NhanVien();

            //static -> goi vao duoc class(lay ID tu form dang nhap)
            infoNV = ctrlNV.XemMotNV(DangNhap.ID);

            id = infoNV.Id;
            //tenDN = "1";
            ngaynhap = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(ngaynhap);
        }

        public void getNCC()
        {
            ncc = data.GetDanhSachNhaCungCap();
            ncc.Add("Thêm mới");
            comboBoxTenNCC.DataSource = ncc;
        }
        public void getSP()
        {
            sp = data.GetDanhSachSanPham();
            sp.Add("Thêm mới");
            comboBoxTenSP.DataSource = sp;
        }
        public void getdata()
        {
            tenSP = comboBoxTenSP.Text.ToString();
            string s = "select * from SanPham where TenSP = '" + tenSP + "'";
            maSP = data.CheckMa(s);
            try
            {
                soluongnhap = Convert.ToInt32(textBoxSoLuong.Text);
            }
            catch
            {
                soluongnhap = 0;
            }
            try
            {
                dongia = Convert.ToDecimal(textBoxDonGia.Text);
            }
            catch
            {
                dongia = 0;
            }

        }
        public void updateGRV()
        {
            dataGridViewSanPham.DataSource = null;
            dataGridViewSanPham.DataSource = ds;
            dataGridViewSanPham.Columns.Remove("Mapn");
            dataGridViewSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridViewSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridViewSanPham.Columns[2].HeaderText = "Số lượng";
            dataGridViewSanPham.Columns[3].HeaderText = "Đơn giá";
        }
        public decimal tinhtien()
        {
            tongtien = 0;
            foreach(DanhSachSP_PN item in ds)
            {
                tongtien = tongtien + (item.Dongia * item.Soluong);
            }
            return tongtien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            maPN = tbMaPN.Text;

            getdata();
            if (comboBoxTenSP.Text.ToString() == "Chọn sản phẩm" || comboBoxTenNCC.Text.ToString() == "Chọn nhà cung cấp" || comboBoxTenSP.Text.ToString() == "Thêm mới" || comboBoxTenNCC.Text.ToString() == "Thêm mới")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ nhà cung cấp và sản phẩm");
            }
            else
            {
                if (suaSP == false)
                {
                    DanhSachSP_PN pN = new DanhSachSP_PN(maSP, tenSP, maPN, soluongnhap, dongia);
                    ds.Add(pN);
                }
                else
                {
                    DanhSachSP_PN pN = new DanhSachSP_PN(maSP, tenSP, maPN, soluongnhap, dongia);
                    ds[index] = pN;
                    btnSua.Enabled = false;
                    suaSP = false;
                }
                comboBoxTenSP.SelectedItem = "Chọn sản phẩm";
                comboBoxTenNCC.SelectedItem = "Chọn nhà cung cấp";
                textBoxSoLuong.Text = "";
                textBoxDonGia.Text = "";
            }
            updateGRV();
            tbTongTien.Text = tinhtien().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            string query = string.Format("THEMPHIEUNHAP '{0}', '{1}', '{2}', N'{3}', '{4}', '{5}'", maPN, ngaynhap, tongtien, ghichu, maNCC, id);
            data.ExcutiveNonQuery(query);
            foreach (DanhSachSP_PN item in ds)
            {
                string s = string.Format("THEMCTPHIEUNHAP '{0}', '{1}', '{2}', '{3}'", item.Masp, item.Mapn, item.Soluong, item.Dongia);
                data.ExcutiveNonQuery(s);
            }

        }

        private void comboBoxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            if (senderComboBox.Text.ToString() == "Thêm mới")
            {
                this.Enabled = false;
                //NhaCungCap nhaCungCap = new NhaCungCap(this);
                //nhaCungCap.FormClosed += NhaCungCap_FormClosed;
                //nhaCungCap.Show();
                textBoxMaNCC.Text = "";
            }else if (senderComboBox.Text.ToString() == "Chọn nhà cung cấp"){
                textBoxMaNCC.Text = "";
            }
            else
            {
                string s = "select * from NhaCungCap where TenNCC = N'" + senderComboBox.Text.ToString() + "'";
                textBoxMaNCC.Text = data.CheckMa(s);
                maNCC = data.CheckMa(s);
            }
        }

        private void NhaCungCap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void comboBoxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            if (senderComboBox.Text.ToString() == "Thêm mới")
            {
                this.Enabled = false;
                NhapSanPham nhapSanPham = new NhapSanPham(this);
                nhapSanPham.Closed += NhapSanPham_Closed;
                nhapSanPham.Show();
                textBoxLoai.Text = "";
                textBoxNSX.Text = "";
                textBoxDVT.Text = "";
            }
            else if (senderComboBox.Text.ToString() == "Chọn sản phẩm"){
                textBoxLoai.Text = "";
                textBoxNSX.Text = "";
                textBoxDVT.Text = "";
            }
            else
            {
                List<SanPham> temp;
                string s = senderComboBox.Text.ToString();
                temp = data.GetSanPham(s);
                textBoxLoai.Text = temp[0].PhanLoai;
                textBoxNSX.Text = temp[0].NuocSanXuat;
                textBoxDVT.Text = temp[0].DonVi;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaSP = true;
            btXoa.Enabled = false;
            btnSua.Enabled = false;
            index = dataGridViewSanPham.SelectedRows[0].Index;
            comboBoxTenSP.SelectedItem = ds[index].Tensp;
            textBoxSoLuong.Text = ds[index].Soluong.ToString();
            textBoxDonGia.Text = ds[index].Dongia.ToString();
        }

        private void dataGridViewSanPham_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            suaSP = false;
            index = dataGridViewSanPham.SelectedRows[0].Index;
            ds.RemoveAt(index);
            btXoa.Enabled = false;
            updateGRV();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            NhanVien infoNV = new NhanVien();

            //static -> goi vao duoc class(lay ID tu form dang nhap)
            infoNV = ctrlNV.XemMotNV(DangNhap.ID);

            tbTenNV.Text = infoNV.HoTen;
        }

        private void NhapKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TroGiup.FormName = "GDC_NV_" + this.Name;
                TroGiup troGiup = new TroGiup();
                troGiup.ShowDialog();
            }
        }

        private void NhapSanPham_Closed(object sender, EventArgs e)
        {
            this.Enabled = true;
        }
    }
}
