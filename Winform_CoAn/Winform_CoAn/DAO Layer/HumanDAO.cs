using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Winform_CoAn.DTO;

namespace Winform_CoAn.DAO_Layer
{
    public class HumanDAO
    {
        public string ID;
        public string Name;
        public string Address;
        public string Role;
        public string RoleID;

        private static HumanDAO instance;

        public static HumanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HumanDAO();
                return HumanDAO.instance;
            }
            private set { HumanDAO.instance = value; }
        }

        private HumanDAO() { }

        public DataTable GetAll()
        {
            string sql = "select * from Human";
            return DataProviderDAO.Instance.Select(sql, false);
        }

        public DataTable GetBySearch(string search)
        {
            string sql = "select * from Human ";
            sql += "where quequan like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where hoten like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where gioitinh like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where sodienthoai like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where dantoc like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where taikhoan like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where phongbanma like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where trinhdohocvanma like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from Human ";
            sql += "where ma like '%'+ @tukhoa +'%' ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@tukhoa", search);

            return DataProviderDAO.Instance.Select(sql, false, para);
        }

        public bool Insert(HumanDAO human)
        {
            string sql = "insert into Human ";
            sql += " (Id, Name, Address, Role, RoleID) ";
            sql += " values ";
            sql += " ( @ID, @Name, @Address, @Role, @oleID)";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ID", human.ID);
            para.Add("@Name", human.Name);
            para.Add("@Address", human.Address);
            para.Add("@Role", human.Role);
            para.Add("@RoleID", human.RoleID);
            return DataProviderDAO.Instance.InsertUpdateDelete(sql, para, false);
        }
        //Ham update can thi dung
        //public bool Update (HumanDAO human)
        //{
        //    string sql = "update Human ";
        //    sql += " set ";
        //    sql += " ID = @ID, Name = @Name, Address = @Address, Role = @Role, RoleID = @RoleID";
        //    sql += " where ID like @ID ";

        //    Dictionary<string, object> para = new Dictionary<string, object>();
        //    para.Add("@ID", human.ID);
        //    para.Add("@Name", human.Name);
        //    para.Add("@Address", human.Address);
        //    para.Add("@Role", human.Role);
        //    para.Add("@RoleID", human.RoleID);

        //    return DataProviderDAO.Instance.InsertUpdateDelete(sql, para, false);
        //}

        public bool Delete(string ID)
        {
            string sql = "delete Human ";
            sql += " where ID = @ID ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ID", ID);

            return DataProviderDAO.Instance.InsertUpdateDelete(sql, para, false);
        }

        public DataTable GetById(string ID)
        {
            string sql = "select * from Human where ma like @ID";
            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ID", ID);

            return DataProviderDAO.Instance.Select(sql, false, para);
        }
    }
}
