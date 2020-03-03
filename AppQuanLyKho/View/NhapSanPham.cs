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
    public partial class NhapSanPham : Form
    {
        SanPhamController controller = new SanPhamController();
        dataProvider data = new dataProvider();
        NhapKho frmN;


        string masp;
        string tensp;
        string nsx;
        decimal dongia;
        int hanmucdutru;
        string loai;
        string donvi;
        List<string> loais;


        public NhapSanPham(NhapKho frm)
        {
            InitializeComponent();
            frmN = frm;
            getDS_Loai();
        }

        private void getdata()
        {
            masp = textBoxMaSP.Text.ToString();
            masp.Trim();
            tensp = textBoxTensp.Text.ToString();
            tensp.Trim();
            hanmucdutru = 0;
            nsx = textBoxNSX.Text.ToString();
            nsx.Trim();
            donvi = textBoxDonViTinh.Text.ToString();
            donvi.Trim();
            string s = string.Format("select * from Loai where TenLoai = N'{0}'", comboBoxPhanLoai.Text.ToString());
            loai = data.CheckMa(s);
            try
            {
                dongia = Convert.ToDecimal(textBoxDonGia.Text);
            }
            catch
            {
                dongia = 0;
            }
        }
        public void getDS_Loai()
        {
            loais = data.GetDanhSachLoai();
            loais.Add("Thêm mới");
            loais.RemoveAt(0);
            comboBoxPhanLoai.DataSource = loais;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
            if ( masp == "" || tensp == "" || Regex.IsMatch(masp,@"^\s") || Regex.IsMatch(tensp, @"^\s"))
            {
                MessageBox.Show("Mã sản phẩm và tên sản phẩm không được bỏ trống");
                textBoxMaSP.Text = "";
                textBoxTensp.Text = "";
            }
            else
            {
                if (controller.KiemSanPham(masp))
                {
                    MessageBox.Show("mã sản phẩm đã tồn tại !");
                }
                else
                {
                    SanPham sp = new SanPham(masp, tensp, hanmucdutru, nsx, dongia, donvi, loai);
                    controller.ThemSanPham(sp);
                    this.Close();
                    frmN.getSP();
                    frmN.Enabled = true;
                    GiaoDienChinh.Dtb.DataSource = data.GetSanPham(1, "Tất cả");
                    GiaoDienChinh.Dtb.Refresh();
                }
            }
        }

        private void comboBoxPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            if(senderComboBox.Text.ToString() == "Thêm mới")
            {
                this.Enabled = false;
                Loai loai = new Loai(this);
                loai.FormClosed += Loai_FormClosed;
                loai.Show();
            }

        }

        private void Loai_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
