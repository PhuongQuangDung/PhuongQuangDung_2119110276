using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class Employee_DTO
    {
        public string IdEmployee { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public bool Gender { get; set; }
        public string PlaceBirth { get; set; }

        public Department_DTO Department_MSSV { get; set; }
        public string DepamentName
        {

            get { return Department_MSSV.Name; }

        }
    }
}
