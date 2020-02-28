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
//using PagedList;

namespace AppQuanLyKho.View
{
    public partial class NhaCungCap : Form
    {
        int pageNumber = 1;
        //IPagedList<NhaCungCap> list;

        public NhaCungCap()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HKOJN4O;Initial Catalog=TTN_QLKho;Integrated Security=True");

        //pagination lỗi mãi ko fix dc chán ko buồn làm
        /*public async Task<IPagedList<NhaCungCap>> GetPagedListAsync(int pageNumber =1 , int pageSize =10) {
            return await Task.Factory.StartNew(() =>
            {
                using (TTN_QLKhoEntities1 db =new TTN_QLKhoEntities1())
                {
                    return db.NhaCungCaps.OrderByDescending(p => p.MaNCC).ToPagedList(pageNumber, pageSize);
                }
            });
        }       */                                    

        private void KetNoiDatabase()
        {

            con.Open();// mo ket noi

            string sql = "XEMNHACUNGCAP";// lay het du lieu trong bang NCC
            SqlCommand com = new SqlCommand(sql, con);//bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//van chuyen du lieu ve

            DataTable dt = new DataTable();// taoj 1 kho ao de luu tru du lieu

            da.Fill(dt);// do du lieu vao kho

            con.Close();//dong ket noi
            //dGVNCC.DataSource = dt;// do dulieu vao datagridview
            dGVNCC.DataSource = dt;
        }
        

        
        private void XoaData()
        {
            textBoxMaNCC.Text = "";
            textBoxTenNCC.Text = "";
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            KetNoiDatabase();
            LoadDataFromDataGridToTextBox();
            this.KeyPreview = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {

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

        private void dGVNCC_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dGVNCC.CurrentRow.Selected = true;//dulieu duoc chon 1 dong va day len TextBox
            }
            catch (Exception)
            { }
        }
        public void XoaKiTuTrangOGiua(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && s[i + 1] == ' ')
                {
                    s = s.Substring(i, i + 1);
                    i--;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaNCC.Text != "" && textBoxTenNCC.Text != ""
                && textBoxDiaChi.Text != "" && textBoxSDT.Text != "")
            {
                SqlCommand cmd = new SqlCommand("THEMNHACUNGCAP", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MANCC", textBoxMaNCC.Text);
                cmd.Parameters.AddWithValue("@TENNCC", textBoxTenNCC.Text);
                cmd.Parameters.AddWithValue("@DIACHI", textBoxDiaChi.Text);
                cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);


                // kiem tra xem no co toan khoang trang khong
                bool matchMANCC = Regex.IsMatch(textBoxMaNCC.Text, @"^\s");
                bool matchTENNCC = Regex.IsMatch(textBoxTenNCC.Text, @"^\s");
                bool matchDIACHI = Regex.IsMatch(textBoxDiaChi.Text, @"^\s");
                bool matchSDT = Regex.IsMatch(textBoxSDT.Text, @"^\s");

                if (matchMANCC || matchTENNCC || matchSDT || matchDIACHI)
                {
                    MessageBox.Show("khong nhap toan khoang trang");
                }
                else
                if (textBoxMaNCC.Text.Length > 8)
                {
                    MessageBox.Show("Ma nha cung cap toi da 8 ki tu ");
                }
                else if (textBoxSDT.Text.Length > 11)
                {
                    MessageBox.Show("SDT toi da 11 ki tu ");
                }
                else
                {

                    try
                    {
                        XoaKiTuTrangOGiua(textBoxMaNCC.Text);
                        XoaKiTuTrangOGiua(textBoxTenNCC.Text);
                        XoaKiTuTrangOGiua(textBoxDiaChi.Text);
                        XoaKiTuTrangOGiua(textBoxSDT.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Them ban ghi moi thanh cong");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Trùng Mã Nhà Cung Cấp");
                    }
                    con.Close();
                    KetNoiDatabase();
                    XoaData();
                    LoadDataFromDataGridToTextBox();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Ban can cung cap day du thong tin!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (textBoxMaNCC.Text != "" && textBoxTenNCC.Text != ""
                && textBoxDiaChi.Text != "" && textBoxSDT.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SUANHACUNGCAP", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MANCC", textBoxMaNCC.Text);
                cmd.Parameters.AddWithValue("@TENNCC", textBoxTenNCC.Text);
                cmd.Parameters.AddWithValue("@DIACHI", textBoxDiaChi.Text);
                cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);

            

                // kiem tra xem no co toan khoang trang khong
                bool matchMANCC = Regex.IsMatch(textBoxMaNCC.Text, @"^\s");
                bool matchTENNCC = Regex.IsMatch(textBoxTenNCC.Text, @"^\s");
                bool matchDIACHI = Regex.IsMatch(textBoxDiaChi.Text, @"^\s");
                bool matchSDT = Regex.IsMatch(textBoxSDT.Text, @"^\s");

                if (matchMANCC || matchTENNCC || matchSDT || matchDIACHI)
                {
                    MessageBox.Show("khong chi toan khoang trang");
                }
                else if (textBoxMaNCC.Text.Length > 8)
                {
                    MessageBox.Show("Ma nha cung cap toi da 8 ki tu ");
                }
                else if (textBoxSDT.Text.Length > 11)
                {
                    MessageBox.Show("SDT toi da 11 ki tu ");
                }
                else
                {

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sua ban ghi thanh cong");
                    KetNoiDatabase();
                    XoaData();
                    LoadDataFromDataGridToTextBox();
                }
            }
            else
            {
                MessageBox.Show("Ban can cung cap day du thong tin!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxMaNCC.Text != "" && textBoxTenNCC.Text == "")
            {
                SqlCommand cmd = new SqlCommand("XEMCHITIETNHACUNGCAP", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MANCC", textBoxMaNCC.Text);
                if (textBoxMaNCC.Text.Length > 8)
                {
                    MessageBox.Show("Toi da 8 ki tu ");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);//van chuyen du lieu ve
                    DataTable dt = new DataTable();// taoj 1 kho ao de luu tru du lieu
                    da.Fill(dt);// do du lieu vao kho
                    dGVNCC.DataSource = dt;// do dulieu vao datagridview
                    con.Close();
                    //XoaData();

                }
            }
            else if (textBoxMaNCC.Text == "" && textBoxTenNCC.Text != "")
            {
                SqlCommand cmd = new SqlCommand("XEMCHITIETNHACUNGCAP", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MANCC", textBoxMaNCC.Text);
                if (textBoxMaNCC.Text.Length > 8)
                {
                    MessageBox.Show("Toi da 8 ki tu ");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);//van chuyen du lieu ve

                    DataTable dt = new DataTable();// taoj 1 kho ao de luu tru du lieu

                    da.Fill(dt);// do du lieu vao kho
                    dGVNCC.DataSource = dt;// do dulieu vao datagridview
                    con.Close();
                    //XoaData();

                }
            }
            else
            {
                MessageBox.Show("Bạn cần cung cấp đầy đủ thông tin Mã NCC hoặc Tên NCC!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textBoxMaNCC.Text != "" && textBoxTenNCC.Text != ""
                && textBoxDiaChi.Text != "" && textBoxSDT.Text != "")
            {
                SqlCommand cmd = new SqlCommand("XOANHACUNGCAP", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MaNCC", textBoxMaNCC.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Xoa ban ghi moi thanh cong");
                KetNoiDatabase();
                XoaData();
                LoadDataFromDataGridToTextBox();
            }
            else
            {
                MessageBox.Show("Ban can cung cap day du thong tin!");
            }
        }

        private void btnXoaTam_Click(object sender, EventArgs e)
        {
            XoaData();
            KetNoiDatabase();
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
