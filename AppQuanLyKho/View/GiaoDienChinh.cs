using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using AppQuanLyKho.Model;
using AppQuanLyKho.Controller;
using System.Diagnostics;

namespace AppQuanLyKho.View
{
    public partial class GiaoDienChinh : Form
    {
        List<SanPham> danhSachSanPham;
        List<string> danhSachLoai;
        private bool tsql;
        private static DataGridView dtb;
        //form khac dung duoc datagridview
        public static DataGridView Dtb { get => dtb; set => dtb = value; }
        public bool Tsql { get => tsql; set => tsql = value; }

        dataProvider provider;
        int maxPage;
        int currentpage;

        public GiaoDienChinh()
        {

            InitializeComponent();

            danhSachSanPham = new List<SanPham>();
            danhSachLoai = new List<string>();
            provider = new dataProvider();

            dtb = dataGridViewListSP;
        }

        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNV info = new ThongTinNV();
            info.ShowDialog();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau changepassword = new DoiMatKhau();
            changepassword.ShowDialog();
        }

        private void QuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            dsnv.ShowDialog();
        }

        private void NhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.ShowDialog();
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            //hieu viet
            quanLyToolStripMenuItem.Visible = tsql;

            //nam viet
            maxPage = (int)Math.Ceiling(provider.GetSoSanPham("Tất cả") / 10);
            // gọi toàn bộ sql vào danhSachSanPham("Tất cả",index)
            dataGridViewListSP.DataSource = provider.GetSanPham(1, "Tất cả");

            //quanLyToolStripMenuItem.Visible = tsql;
            // gọi toàn bộ danh sách loại sản phẩm vào danhSachLoai
            danhSachLoai = provider.GetDanhSachLoai();
            loaiCb.DataSource = danhSachLoai;

            Labling(1);
            this.KeyPreview = true;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            //trả về danh sách sản phẩm like""
            if (tbSearch.Text != "")
            {
                dataGridViewListSP.DataSource = provider.SearchSanPham(tbSearch.Text);
            }
            removeLable();
        }

        private void Labling(int middle)
        {
            index3Lb.Text = middle.ToString();
            currentpage = middle;
            if (middle - 1 > 0)
            {
                index2Lb.Text = (middle - 1).ToString();
            }
            else
            {
                index2Lb.Text = "";
            }
            if (middle - 2 > 0)
            {
                index1Lb.Text = (middle - 2).ToString();
            }
            else
            {
                index1Lb.Text = "";
            }
            if (middle + 1 <= maxPage)
            {
                index4Lb.Text = (middle + 1).ToString();
            }
            else
            {
                index4Lb.Text = "";
            }
            if (middle + 2 <= maxPage)
            {
                index5Lb.Text = (middle + 2).ToString();
            }
            else
            {
                index5Lb.Text = "";
            }
        }
        private void removeLable()
        {
            index1Lb.Text = "";
            index2Lb.Text = "";
            index3Lb.Text = "";
            index4Lb.Text = "";
            index5Lb.Text = "";
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridViewListSP.DataSource = provider.GetSanPham(currentpage, (string)loaiCb.SelectedItem);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridViewListSP.CurrentRow;
            SuaTTSanPham window = new SuaTTSanPham(current.Cells[0].Value.ToString(),
                                               current.Cells[1].Value.ToString(),
                                               current.Cells[3].Value.ToString(),
                                               Convert.ToInt32(current.Cells[4].Value),
                                               current.Cells[5].Value.ToString());
            window.FormClosed += Window_FormClosed;
            window.Show();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridViewListSP.CurrentRow;
            provider.DeleteSanPham(current.Cells[0].Value.ToString());
            dataGridViewListSP.DataSource = provider.GetSanPham(currentpage, (string)loaiCb.SelectedItem);
        }

        private void LoaiCb_SelectedValueChanged(object sender, EventArgs e)
        {
            //hàm gọi danh sách sản phẩm có loại = loaiCb.SelectedItem vào danhSachSanPham(loaiCb.value,index)
            maxPage = (int)Math.Ceiling(provider.GetSoSanPham((string)loaiCb.SelectedItem) / 10);
            dataGridViewListSP.DataSource = provider.GetSanPham(1, (string)loaiCb.SelectedItem);
            Labling(1);
        }

        private void IndexLb_Click(object sender, EventArgs e)
        {
            Label i = sender as Label;
            if (i.Text != "")
            {
                int middle = Convert.ToInt32(i.Text);
                dataGridViewListSP.DataSource = provider.GetSanPham(middle, (string)loaiCb.SelectedItem);
                Labling(middle);
            }
        }

        private void NhậpKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhapKho nk = new NhapKho();
            nk.ShowDialog();
        }

        private void GiaoDienChinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TroGiup.FormName = "GDC_" + this.Name;
                TroGiup tg = new TroGiup();
                tg.ShowDialog();
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TroGiup.FormName = "GDC_GiaoDienChinh";
            TroGiup tg = new TroGiup();
            tg.ShowDialog();
        }

        private void XuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuXuat xuatKho = new PhieuXuat();
            xuatKho.ShowDialog();
        }

    }
}
