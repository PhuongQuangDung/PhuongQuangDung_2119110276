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
    public class Employee_DAL : DBConnection
    {
        public List<Employee_DTO> ReadEmployee()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spReadEmployee_MSSV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee_DTO> lstNv = new List<Employee_DTO>();
            Department_DAL department = new Department_DAL();

            while (reader.Read())
            {
                Employee_DTO nv = new Employee_DTO();
                nv.IdEmployee = reader["IdEmployee"].ToString();
                nv.Name = reader["Name"].ToString();
                nv.DateBirth = DateTime.Parse(reader["DateBirth"].ToString());
                nv.Gender = bool.Parse(reader["Gender"].ToString());
                nv.PlaceBirth = reader["PlaceBirth"].ToString();
                nv.Department_MSSV = department.ReadDepartment(reader["IdDepartment"].ToString());
                lstNv.Add(nv);
            }
            conn.Close();
            return lstNv;
        }

        public void DeleteEmployee_MSSV(Employee_DTO nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spDeleteEmployee_MSSV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", nv.IdEmployee));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewEmployee_MSSV(Employee_DTO nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spInsertEmployee_MSSV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            cmd.Parameters.Add(new SqlParameter("@IdEmployee", nv.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", nv.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", nv.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", nv.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", nv.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@IdDepartment", nv.Department_MSSV.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditEmployee_MSSV(Employee_DTO nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spUpdateEmployee_MSSV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", nv.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", nv.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", nv.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", nv.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", nv.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@IdDepartment", nv.Department_MSSV.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
