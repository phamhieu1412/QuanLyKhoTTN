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
    public partial class TroGiup : Form
    {
        public TroGiup()
        {
            InitializeComponent();
        }
        
        public static string FormName;
        private void TroGiup_Load(object sender, EventArgs e)
        {

            if (FormName == "DangNhap")
            {
                tabTroGiup.SelectedTab = tabTG_DangNhap;
            }
            else if (FormName.Contains("GDC") == true)
            {
                tabTroGiup.SelectedTab = tabTG_GiaoDienChinh;
                if (FormName.Contains("GiaoDienChinh") == true)
                    tabGianDienChinh.SelectedTab = tabGDC_GiaoDienChinh;
                else if (FormName.Contains("TK") == true)
                {
                    tabGianDienChinh.SelectedTab = tabGDC_TaiKhoan;
                    if (FormName.Contains("ThongTinTaiKhoan") == true)
                        tabTaiKhoan.SelectedTab = tabTK_ThongTinTaiKhoan;
                    else if (FormName.Contains("DoiMatKhau") == true)
                        tabTaiKhoan.SelectedTab = tabTK_DoiMatKhau;
                    else if (FormName.Contains("QuanLy") == true)
                        tabTaiKhoan.SelectedTab = tabTK_QuanLy;
                }
                else if (FormName.Contains("NV") == true)
                {
                    tabGianDienChinh.SelectedTab = tabGDC_NghiepVu;
                    if (FormName.Contains("NhapKho") == true)
                        tabNghiepVu.SelectedTab = tabNV_NhapKho;
                    else if (FormName.Contains("XuatKho") == true)
                        tabNghiepVu.SelectedTab = tabNV_XuatKho;
                    else if (FormName.Contains("NhaCungCap") == true)
                        tabNghiepVu.SelectedTab = tabNV_NhaCungCap;
                }
            }
        }
    }
}
