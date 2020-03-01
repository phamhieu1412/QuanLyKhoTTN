using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyKho.Model;

namespace AppQuanLyKho.Controller
{
    class dataProvider
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HKOJN4O;Initial Catalog=TTN_QLKho;Integrated Security=True");

        public DataTable ExcutiveQuery(string query)
        {
            if(sqlConnection.State == ConnectionState.Closed)
            sqlConnection.Open();
            DataTable data = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return data;
        }

        public bool ExcutiveNonQuery(string query)
        {
            //ktra trang thai
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                return cm.ExecuteNonQuery() > 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return false;
        }
        public List<string> GetMaLoai()
        {
            List<string> loais = new List<string> { "Tất cả" };
            string query;
            sqlConnection.Open();
            query = "select MaLoai from Loai";
            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    loais.Add((string)reader["MaLoai"]);
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return loais;
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
        //Nam lam phan san pham
        public double GetSoSanPham(string type)
        {
            sqlConnection.Open();
            string query;
            if (type == "Tất cả")
            {
                query = "Select Count(*) " +
                         "from SanPham, Loai " +
                         "where SanPham.MaLoai = Loai.MaLoai ";
            }
            else
            {
                query = "Select Count(*) " +
                         "from SanPham, Loai " +
                         "where SanPham.MaLoai = Loai.MaLoai and TenLoai = N'" + type + "'";
            }
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int value = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return value;
        }

        public List<string> GetDanhSachLoai()
        {
            List<string> loais = new List<string> { "Tất cả" };
            string query;
            sqlConnection.Open();
            query = "select TenLoai from Loai";
            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    loais.Add((string)reader["TenLoai"]);
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return loais;
        }

        public List<SanPham> GetSanPham(int index, string type)
        {
            List<SanPham> sanPham = new List<SanPham>();
            string query;
            sqlConnection.Open();
            if (type == "Tất cả")
            {
                query = "With orders as " +
                        "(" +
                        "select ROW_NUMBER() Over(Order by MaSP ASC) as rownum, MaSP, TenSp, HanMucDuTru, NuocSX, DVT, DonGia, TenLoai " +
                        "From SanPham,Loai " +
                        "Where SanPham.MaLoai = Loai.MaLoai " +
                        ")" +
                        "select MaSp,TenSp,HanMucDuTru,NuocSX,DVT,DonGia,TenLoai " +
                        "from orders " +
                        "where rownum >= " + ((index * 10) - 9) + " and rownum <= " + index * 10;
            }
            else
            {
                query = "With orders as " +
                   "(select ROW_NUMBER() Over(Order by MaSP ASC) as rownum, MaSP, TenSp, HanMucDuTru, NuocSX, DVT, DonGia, TenLoai " +
                   "From SanPham,Loai " +
                   "Where SanPham.MaLoai = Loai.MaLoai and TenLoai = N'" + type + "') " +
                   "select MaSp,TenSp,HanMucDuTru,NuocSX,DVT,DonGia,TenLoai " +
                   "from orders " +
                   "where rownum >= " + ((index * 10) - 9) + " and rownum <= " + index * 10;
            }
            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sanPham.Add(new SanPham((string)reader["MaSP"], (string)reader["TenSP"], (int)reader["HanMucDuTru"], (string)reader["NuocSX"], Decimal.ToInt32((decimal)reader["DonGia"]), (string)reader["DVT"], (string)reader["TenLoai"]));
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return sanPham;
        }

        public void DeleteSanPham(string masp)
        {
            sqlConnection.Open();
            string query;

            query = "Delete from SanPham where MaSp = '" + masp + "'";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<SanPham> SearchSanPham(string keyword)
        {
            List<SanPham> sanPham = new List<SanPham>();
            string query;
            sqlConnection.Open();

            query = "select MaSp,TenSp,HanMucDuTru,NuocSX,DVT,DonGia,TenLoai " +
                    "from SanPham,Loai " +
                    "Where SanPham.MaLoai = Loai.MaLoai and (TenSP Like N'%" + keyword + "%' Or MaSP like N'%" + keyword + "%')";

            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sanPham.Add(new SanPham((string)reader["MaSP"], (string)reader["TenSP"], (int)reader["HanMucDuTru"], (string)reader["NuocSX"], Decimal.ToInt32((decimal)reader["DonGia"]), (string)reader["DVT"], (string)reader["TenLoai"]));
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return sanPham;
        }

        public void UpdateSanPham(string masp, string tensp, string nuocsx, string dongia, string donvi)
        {
            sqlConnection.Open();
            string query;

            query = "update SanPham " +
                    "set TenSP = N'" + tensp + "' , NuocSX = N'" + nuocsx + "', DVT = N'" + donvi + "', DonGia = " + dongia + " " +
                    "where MaSP = '" + masp + "'";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
        //Dung lam phieu nhap
        public string CheckMa(string query)
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                cm.CommandType = CommandType.Text;
                string s = (string)cm.ExecuteScalar();
                return s;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return "";
        }

        //public List<string> GetDanhSachLoai()
        //{
        //    List<string> loais = new List<string> { "Tất cả" };
        //    string query;
        //    if (sqlConnection.State == ConnectionState.Closed)
        //        sqlConnection.Open();
        //    query = "select TenLoai from Loai";
        //    try
        //    {
        //        SqlCommand command = new SqlCommand(query, sqlConnection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            loais.Add((string)reader["TenLoai"]);
        //        }
        //        reader.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    sqlConnection.Close();
        //    return loais;
        //}

        public List<string> GetDanhSachNhaCungCap()
        {
            List<string> ncc = new List<string> { "Chọn nhà cung cấp" };
            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            query = "select TenNCC from NhaCungCap";
            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ncc.Add((string)reader["TenNCC"]);
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return ncc;
        }
        public List<string> GetDanhSachSanPham()
        {
            List<string> sp = new List<string> { "Chọn sản phẩm" };
            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            query = "select TenSP from SanPham";
            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sp.Add((string)reader["TenSP"]);
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return sp;
        }

        public List<SanPham> GetSanPham(string tensp)
        {
            List<SanPham> sanPham = new List<SanPham>();
            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();

            query = "select MaSp,TenSp,HanMucDuTru,NuocSX,DVT,DonGia,TenLoai " +
                    "from SanPham,Loai " +
                    "Where SanPham.MaLoai = Loai.MaLoai and TenSP = N'" + tensp + "'";

            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sanPham.Add(new SanPham((string)reader["MaSP"], (string)reader["TenSP"], (int)reader["HanMucDuTru"], (string)reader["NuocSX"], Decimal.ToInt32((decimal)reader["DonGia"]), (string)reader["DVT"], (string)reader["TenLoai"]));
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return sanPham;
        }

        //public List<SanPham> SearchSanPham(string keyword)
        //{
        //    List<SanPham> sanPham = new List<SanPham>();
        //    string query;
        //    if (sqlConnection.State == ConnectionState.Closed)
        //        sqlConnection.Open();

        //    query = "select MaSp,TenSp,HanMucDuTru,NuocSX,DVT,DonGia,TenLoai " +
        //            "from SanPham,Loai " +
        //            "Where SanPham.MaLoai = Loai.MaLoai and (TenSP Like N'%" + keyword + "%' Or MaSP like N'%" + keyword + "%')";

        //    try
        //    {
        //        SqlCommand command = new SqlCommand(query, sqlConnection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            sanPham.Add(new SanPham((string)reader["MaSP"], (string)reader["TenSP"], (int)reader["HanMucDuTru"], (string)reader["NuocSX"], Decimal.ToInt32((decimal)reader["DonGia"]), (string)reader["DVT"], (string)reader["TenLoai"]));
        //        }
        //        reader.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    sqlConnection.Close();
        //    return sanPham;
        //}

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
        //Trung lam phieu xuat
        public string MaPhieuXuatMoi()
        {
            string s = "";
            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            query = "SELECT TOP 1 MaPX as LastID FROM PhieuXuat ORDER BY MaPX DESC";
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                cm.CommandType = CommandType.Text;
                s = (string)cm.ExecuteScalar();


            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            //if (s != "")
            //{
            //    s = s.Replace("PX", "99");
            //    int temp = Convert.ToInt32(s);
            //    temp++;
            //    s = temp.ToString();
            //    s = s.Replace("99", "PX");
            //    return s;
            //}
            //else
            return "";
        }
        public string TenKhachHang(string MaKhachHang)
        {
            string s = "";
            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            query = "Select HoTen from KhachHang where MaKH = '" + MaKhachHang + "'";
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                cm.CommandType = CommandType.Text;
                if (cm.ExecuteScalar() != null)
                {
                    s = (string)cm.ExecuteScalar();

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return s;
        }
        public bool KiemTraMaKH(string MaKH)
        {
            bool s = false;
            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            query = "Select * from KhachHang where MaKH = '" + MaKH + "'";
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                cm.CommandType = CommandType.Text;
                if (cm.ExecuteScalar() != null)
                {
                    s = true;
                }
                else
                    s = false;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return s;
        }
        public void ThemKH(string MaKH, string HoTen)
        {

            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            query = "insert into KhachHang(MaKH,HoTen) values ('" + MaKH + "'," + "N'" + HoTen + "')";
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                if (cm.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("them thanh cong");
                }
                else
                    MessageBox.Show("them that bai");

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
        }
        public void ThemPhieuXuat(string MaPX, DateTime NgayXuat, int TongTien, string GhiChu, int Id, string MaSP, int SoLuong, string MaKH)
        {
            string query;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            query = "insert into PhieuXuat(MaPX,NgayMua,TongTien,GhiChu,Id,MaKH) " +
                " values ('" + MaPX + "','" + NgayXuat + "','" + TongTien + "',N'" + GhiChu + "','" + Id + "','" + MaKH + "')";
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                if (cm.ExecuteNonQuery() == 1)
                {
                    query = "insert into CT_PhieuXuat(MaPX,MaSP,SoLuong) " +
                " values ('" + MaPX + "','" + MaSP + "','" + SoLuong + "')";
                    SqlCommand cm1 = new SqlCommand(query, sqlConnection);
                    if (cm1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("them thanh cong");
                    }
                    else
                        MessageBox.Show("them that bai");
                }
                else
                    MessageBox.Show("them that bai");

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
        }
    }
}
