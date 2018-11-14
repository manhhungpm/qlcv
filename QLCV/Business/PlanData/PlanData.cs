
using QLCV.Business.Work_PlanItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.PlanData
{
    [Serializable]
    public class PlanData
    {
        private List<Dulieu> job;

        public List<Dulieu> Job
        {
            get { return job; }
            set { job = value; }
        }
    }
}