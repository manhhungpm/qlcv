using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.Department
{
    class Dulieu
    {
        private string departmentID;
        public string DepartmentID
        {
            get
            {
                return departmentID;
            }

            set
            {
                departmentID = value;
            }
        }

        private string departmentMa;
        public string DepartmentMa
        {
            get
            {
                return departmentMa;
            }

            set
            {
                departmentMa = value;
            }
        }

        private string departmentName;
        public string DepartmentName
        {
            get
            {
                return departmentName;
            }

            set
            {
                departmentName = value;
            }
        }
    }
}
