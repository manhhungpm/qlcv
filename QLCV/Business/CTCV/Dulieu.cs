using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.CTCV
{
    class Dulieu
    {
        private int workID;
        public int WorkID
        {
            get
            {
                return workID;
            }

            set
            {
                workID = value;
            }
        }

        private string workName;
        public string WorkName
        {
            get
            {
                return workName;
            }

            set
            {
                workName = value;
            }
        }
        public int StaffID
        {
            get
            {
                return staffID;
            }

            set
            {
                staffID = value;
            }
        }
        private int staffID;

        private string staffName;
        public string StaffName
        {
            get
            {
                return staffName;
            }

            set
            {
                staffName = value;
            }
        }

        private int departmentID;
        public int DepartmentID
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
        private string departmentName;


    }
}
