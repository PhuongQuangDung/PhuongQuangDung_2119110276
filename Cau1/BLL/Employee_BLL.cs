using Cau1.DAL;
using Cau1.DTO;
using System.Collections.Generic;

namespace Cau1.BLL
{
    public class Employee_BLL
    {
        Employee_DAL dal = new Employee_DAL();
        public List<Employee_DTO> ReadEmployee()
        {
            List<Employee_DTO> lstNv = dal.ReadEmployee();
            return lstNv;
        }
        public void NewEmployee_MSSV(Employee_DTO nv)
        {
            dal.NewEmployee_MSSV(nv);
        }
        public void DeleteEmployee_MSSV(Employee_DTO nv)
        {
            dal.DeleteEmployee_MSSV(nv);
        }
        public void EditEmployee(Employee_DTO nv)
        {
            dal.EditEmployee_MSSV(nv);
        }
    }
}
