using AppQuanLyKho.Controller;
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
    public partial class DangNhap : Form
    {
        DangNhapController ctrl = new DangNhapController();
        public DangNhap()
        {
            InitializeComponent();
        }

        public static int ID = 0;


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            int status = ctrl.KtraDN(txtUserName.Text, txtPassword.Text);
            if (status == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !!! Mời nhập lại");
                return;
            }
            else
            {
                GiaoDienChinh main = new GiaoDienChinh();
                DangNhap DN = new DangNhap();

                if (status == 1) main.Tsql = true;
                else main.Tsql = false;

                ID = ctrl.LayID(txtUserName.Text);

                this.Hide();
                main.ShowDialog();
                this.Show();

                txtUserName.Text = "";
                txtPassword.Text = "";
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


    }
}
