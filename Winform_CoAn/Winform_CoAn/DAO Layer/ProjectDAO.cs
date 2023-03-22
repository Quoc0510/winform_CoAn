using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_CoAn.DTO;

namespace Winform_CoAn.DAO_Layer
{
    internal class ProjectDAO
    {
        public string ID;
        public string Name;
        public string Manager;
        public string Status;

        private static ProjectDAO instance;
        public static ProjectDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProjectDAO();
                return ProjectDAO.instance;
            }
            private set { ProjectDAO.instance = value; }
        }
        public ProjectDAO() { }

        public DataTable GetAll()
        {
            string sql = "select * from Project";
            return DataProviderDAO.Instance.Select(sql, false);
        }

        public bool Insert(ProjectDAO project)
        {
            string sql = "insert into Project ";
            sql += " (ID, Name, Manager, Status) ";
            sql += " values ";
            sql += " ( @ID, @Name, @Manager, @Status)";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ID", project.ID);
            para.Add("@Name", project.Name);
            para.Add("@Manager", project.Manager);
            para.Add("@Status", project.Status);
            return DataProviderDAO.Instance.InsertUpdateDelete(sql, para, false);
        }

        public bool Update(ProjectDAO project)
        {
            string sql = "update Project ";
            sql += " set ";
            sql += " ID = @ID, Name = @Name, Manager = @Manager, Status = @Status";
            sql += " where ID like @ID ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ID", project.ID);
            para.Add("@Name", project.Name);
            para.Add("@Manager", project.Manager);
            para.Add("@Status", project.Status);

            return DataProviderDAO.Instance.InsertUpdateDelete(sql, para, false);
        }

        public bool Delete(ProjectDAO project)
        {

            {
                string sql = "delete Project ";
                sql += " where ID = @ID ";

                Dictionary<string, object> para = new Dictionary<string, object>();
                para.Add("@ID", ID);
                return DataProviderDAO.Instance.InsertUpdateDelete(sql, para, false);
            }


        }
    }
}
