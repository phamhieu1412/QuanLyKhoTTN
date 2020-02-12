using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKho.Controller
{
    class dataProvider
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HKOJN4O;Initial Catalog=TTN_QLKho;Integrated Security=True");

        public DataTable ExcutiveQuery(string query)
        {
            sqlConnection.Open();
            DataTable data = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
            }
            catch
            {
                MessageBox.Show("Kết nối gián đoạn!", "NCR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return data;
        }

        public bool ExcutiveNonQuery(string query)
        {
            sqlConnection.Open();
            try
            {
                SqlCommand cm = new SqlCommand(query, sqlConnection);
                return cm.ExecuteNonQuery() > 0;
            }
            catch (SqlException e)
            {
                //MessageBox.Show("Kết nối gián đoạn!", "NCR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return false;
        }
    }
}
