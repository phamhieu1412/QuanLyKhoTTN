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

namespace AppQuanLyKho.View
{
    public partial class GiaoDienChinh : Form
    {
        private bool tsql;

        public bool Tsql { get => tsql; set => tsql = value; }

        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            //dataGridViewListSP.DataSource = GetAllProduct().Tables[0];
        }

        //DataSet GetAllProduct()
        //{
        //    DataSet data = new DataSet();
                
        //    //Sql connection
        //    string query = " select * from SanPham";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        connection.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        adapter.Fill(data);
        //        connection.Close();
        //    }


        //    return data;
        //}

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

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {

            quanLyToolStripMenuItem.Visible = tsql;
        }
    }
}
