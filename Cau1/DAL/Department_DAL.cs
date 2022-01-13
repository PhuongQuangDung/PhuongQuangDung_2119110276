using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Cau1.DTO;

namespace Cau1.DAL
{
    public class Department_DAL : DBConnection
    {
        public List<Department_DTO> ReadDepartmentList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Department_MSSV", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Department_DTO> lstDp = new List<Department_DTO>();
            while (reader.Read())
            {
                Department_DTO department = new Department_DTO();
                department.IdDepartment = reader["IdDepartment"].ToString();
                department.Name = reader["Name"].ToString();
                lstDp.Add(department);
            }
            conn.Close();
            return lstDp;
        }
        public Department_DTO ReadDepartment(string id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Department_MSSV where IdDepartment=" + "'" + id.ToString() + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Department_DTO Dp = new Department_DTO();
            if (reader.HasRows && reader.Read())
            {
                Dp.IdDepartment = reader["IdDepartment"].ToString();
                Dp.Name = reader["Name"].ToString();
            }
            conn.Close();
            return Dp;
        }
    }
}
