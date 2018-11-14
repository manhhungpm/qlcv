using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.Staff
{
    class Dulieu
    {
        private String staffID;
        public string StaffID
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


        private String staffMa;
        public string StaffMa
        {
            get
            {
                return staffMa;
            }

            set
            {
                staffMa = value;
            }
        }

        //tên nhân viên
        private String staffName;
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

        //pass đăng nhập
        public string StaffPass
        {
            get
            {
                return staffPass;
            }

            set
            {
                staffPass = value;
            }
        }
        private String staffPass;

        private int hs;
        public int Hs
        {
            get
            {
                return hs;
            }

            set
            {
                hs = value;
            }
        }

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
    }
}
