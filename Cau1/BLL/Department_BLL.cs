using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cau1.DAL;
using Cau1.DTO;

namespace Cau1.BLL
{
    public class Department_BLL
    {
        Department_DAL dal = new Department_DAL();
        public List<Department_DTO> ReadDepartmentList()
        {
            List<Department_DTO> lstDp = dal.ReadDepartmentList();
            return lstDp;
        }
    }
}
