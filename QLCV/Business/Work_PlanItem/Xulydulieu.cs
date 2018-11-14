using QLCV.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.Work_PlanItem
{
    class Xulydulieu
    {
        Dulieu dt = new Dulieu();

        //public void Work_Delete(Dulieu dt)
        //{
        //    Xuly.table_Command("DELETE FROM work WHERE workID = '" + dt.WorkID + "'");
        //}
        public void Work_Insert(Dulieu dt)
        {
            Xuly.table_Command("INSERT INTO work VALUES(N'" + dt.WorkName + "','" + dt.FromTime + "','" + dt.ToTime + "','" + dt.WorkStatus + "','" + dt.WorkDate + "')");
        }
        //public void Work_Update(Dulieu dt)
        //{
        //    Xuly.table_Command("UPDATE work SET workName=N'" + dt.workName + "',Fromtime='" + dt.Fromtime + "',Totime='" + dt.Totime + "',Status='" + dt.WorkStatus + "',Date='" + dt.WorkDate + "' WHERE workID = '" + dt.WorkID + "'");
        //}

    }
}
