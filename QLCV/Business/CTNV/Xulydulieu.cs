using QLCV.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.CTNV
{
    class Xulydulieu
    {
        Dulieu dt = new Dulieu();
        public void chitietNV_Insert(Dulieu dt)
        {
            Xuly.table_Command("INSERT INTO chitietStaff VALUES(N'" + dt.WorkName + "',N'" + dt.WorkStatus + "',N'" + dt.StaffName + "')");
        }
    }
}
