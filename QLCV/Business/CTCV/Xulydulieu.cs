using QLCV.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.CTCV
{
    class Xulydulieu
    {
        Dulieu dt = new Dulieu();
        public void chitietCV_Insert(Dulieu dt)
        {
            Xuly.table_Command("INSERT INTO chitietWork VALUES(N'" + dt.WorkName + "','" + dt.StaffName + "','" + dt.DepartmentName + "')");
        }
    }
}
