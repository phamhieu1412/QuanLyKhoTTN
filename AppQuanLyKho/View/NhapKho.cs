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
using AppQuanLyKho.Model;

namespace AppQuanLyKho.View
{
    public partial class NhapKho : Form
    {
        List<DanhSachSP_PN> ds = new List<DanhSachSP_PN>();
        dataProvider data = new dataProvider();
        List<string> ncc, sp;

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

        private bool xoaColumn = true;
        private bool suaSP = false;
        private int index;


        public NhapKho()
        {
            InitializeComponent();
            getNCC();
            getSP();
            //==============================
            //maPN = tbMaPN.Text.ToString();
            maPN = "PN016";
            //==============================
            //tenDN = tbTenNV.Text.ToString();
            id = 1;
            ngaynhap = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(ngaynhap);

        }

        NhanVienController ctrl = new NhanVienController();
        private void NhapKho_Load(object sender, EventArgs e)
        {
            NhanVien infoNV = new NhanVien();

            //static -> goi vao duoc class(lay ID tu form dang nhap)
            infoNV = ctrl.XemMotNV(DangNhap.ID);

            tbTenNV.Text = infoNV.HoTen;
        }

        public void getNCC()
        {
            ncc = data.GetDanhSachNhaCungCap();
            ncc.Add("Thêm mới");
            comboBoxNCC.DataSource = ncc;
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
            if (xoaColumn == true)
            {
                dataGridViewSanPham.Columns.Remove("Mapn");
                xoaColumn = false;
            }
            dataGridViewSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridViewSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridViewSanPham.Columns[2].HeaderText = "Số lượng";
            dataGridViewSanPham.Columns[3].HeaderText = "Đơn giá";
        }

        public decimal tinhtien()
        {
            tongtien = 0;
            foreach (DanhSachSP_PN item in ds)
            {
                tongtien = tongtien + (item.Dongia * item.Soluong);
            }
            return tongtien;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            getdata();
            if (comboBoxTenSP.Text.ToString() == "Chọn sản phẩm" || comboBoxNCC.Text.ToString() == "Chọn nhà cung cấp" || comboBoxTenSP.Text.ToString() == "Thêm mới" || comboBoxNCC.Text.ToString() == "Thêm mới")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ nhà cung cấp và sản phẩm");
            }
            else
            {
                if (suaSP == false)
                {
                    DanhSachSP_PN pN = new DanhSachSP_PN(maSP, tenSP, maPN, soluongnhap, dongia);
                    ds.Add(pN);
                    updateGRV();
                }
                else
                {
                    DanhSachSP_PN pN = new DanhSachSP_PN(maSP, tenSP, maPN, soluongnhap, dongia);
                    ds[index] = pN;
                    updateGRV();
                    btnSua.Enabled = false;
                    suaSP = false;
                }
            }
            tbTongTien.Text = tinhtien().ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            suaSP = true;
            index = dataGridViewSanPham.SelectedRows[0].Index;
            comboBoxTenSP.SelectedItem = ds[index].Tensp;
            textBoxSoLuong.Text = ds[index].Soluong.ToString();
            textBoxDonGia.Text = ds[index].Dongia.ToString();
        }

        private void ComboBoxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            if (senderComboBox.Text.ToString() == "Thêm mới")
            {
                this.Enabled = false;
                //NhaCungCap nhaCungCap = new NhaCungCap(this);
                //nhaCungCap.FormClosed += NhaCungCap_FormClosed;
                //nhaCungCap.Show();
                textBoxMaNCC.Text = "";
            }
            else if (senderComboBox.Text.ToString() == "Chọn nhà cung cấp")
            {
                textBoxMaNCC.Text = "";
            }
            else
            {
                string s = "select * from NhaCungCap where TenNCC = '" + senderComboBox.Text.ToString() + "'";
                textBoxMaNCC.Text = data.CheckMa(s);
                maNCC = data.CheckMa(s);
            }
        }
        private void NhaCungCap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void ComboBoxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            if (senderComboBox.Text.ToString() == "Thêm mới")
            {
                this.Enabled = false;
                //NhapSanPham nhapsanpham = new NhapSanPham(this);
                //nhapsanpham.closed += nhapsanpham_closed;
                //nhapsanpham.show();
                textBoxLoai.Text = "";
                textBoxNSX.Text = "";
                textBoxDVT.Text = "";
            }
            else if (senderComboBox.Text.ToString() == "Chọn sản phẩm")
            {
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
        private void NhapSanPham_Closed(object sender, EventArgs e)
        {
            this.Enabled = true;
        }
        private void DataGridViewSanPham_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSua.Enabled = true;
        }


        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string query = string.Format("exec THEMPHIEUNHAP '{0}', '{1}', {2}, N'{3}', '{4}', {5} ", maPN, ngaynhap, tongtien, ghichu, maNCC, id);
            data.ExcutiveNonQuery(query);
            foreach (DanhSachSP_PN item in ds)
            {
                string s = string.Format("exec THEMCTPHIEUNHAP '{0}', '{1}', {2}, {3}", item.Masp, item.Mapn, item.Soluong, item.Dongia);
                data.ExcutiveNonQuery(s);
            }
        }




    }
}
