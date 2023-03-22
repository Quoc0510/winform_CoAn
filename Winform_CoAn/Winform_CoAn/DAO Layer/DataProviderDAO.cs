using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Winform_CoAn.DAO_Layer
{
    public class DataProviderDAO
    {

        //private SqlConnection con = null;

        private static DataProviderDAO instance;

        public static DataProviderDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProviderDAO();
                return DataProviderDAO.instance;
            }
            private set { instance = value; }
        }

        private DataProviderDAO() { }


        /// <summary>
        /// Thực hiện truy vấn như hiển thị, tìm kiếm ... 
        /// </summary>
        /// <param name="sql">Lệnh sql hoặc Thủ tục</param>
        /// <param name="isProcedure">True - proc , False - query</param>
        /// <param name="parameters">Danh sách tham số vào</param>
        /// <returns></returns>
        public DataTable Select(string sqlQuery, bool isProc, Dictionary<string, object> parameters = null)
        {
            //string connectionString = "Data Source=DESKTOP-C72O0SO\\FISHY;Initial Catalog=CompanyManagement;Integrated Security=True";
            //using (SqlConnection con = new SqlConnection(connectionString))


            string ConnectString = connectionstring.cnnstr;
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, con))
                {
                    con.Open();
                    if (isProc)
                        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    else
                        sqlCmd.CommandType = System.Data.CommandType.Text;
                    if (parameters != null)
                        foreach (KeyValuePair<string, object> para in parameters)
                            sqlCmd.Parameters.Add(new SqlParameter(para.Key, para.Value));

                    using (SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sqlDa.Fill(dt);
                            return dt;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Thêm , Sửa , Xóa
        /// </summary>
        /// <param name="sql">Câu lệnh truy vấn hoặc thủ tục</param>
        /// <param name="parameters">Danh sách tham số</param>
        /// <param name="isProcedure">True - thủ tục  False - Câu lệnh truy vấn</param>
        /// <returns></returns>
        public bool InsertUpdateDelete(string sql, Dictionary<string, object> parameters, bool isProcedure)
        {

            string ConnectString = connectionstring.cnnstr;
            using (SqlConnection sqlCon = new SqlConnection(ConnectString))
            {
                sqlCon.Open();
                //MessageBox.Show("Ket noi thanh cong");
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlCon))
                {
                    if (isProcedure)
                        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    else
                        sqlCmd.CommandType = System.Data.CommandType.Text;

                    foreach (KeyValuePair<string, object> parameter in parameters)
                        sqlCmd.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));

                    if (sqlCmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }

        }

    }
}