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
        public DangNhap()
        {
            InitializeComponent();
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            GiaoDienChinh main = new GiaoDienChinh();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK )
            {
                e.Cancel = true;
            }
        }


    }
}
