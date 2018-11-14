using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.Work_PlanItem
{
    public class Dulieu
    {
        private DateTime workDate;
        public DateTime WorkDate
        {
            get
            {
                return workDate;
            }

            set
            {
                workDate = value;
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

        private Point fromTime;
        public Point FromTime
        {
            get { return fromTime; }
            set { fromTime = value; }
        }

        private Point toTime;
        public Point ToTime
        {
            get { return toTime; }
            set { toTime = value; }
        }

        private string workStatus;
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

        public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED" };

        private string staffName;
        private string departmentName;
    }

    public enum EPlanItem
    {
        DONE,
        DOING,
        COMING,
        MISSED
    }
}