using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.CTNV
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

        public string WorkStatus
        {
            get
            {
                return workStatus;
            }

            set
            {
                workStatus = value;
            }
        }

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

        private string workName;
        private string workStatus;
        private string staffName;
    }
}
