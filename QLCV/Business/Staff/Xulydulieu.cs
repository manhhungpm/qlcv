using QLCV.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.Staff
{
    class Xulydulieu
    {
        public DataTable staff_selectAllId(Dulieu dt)
        {
            return Xuly.table_Select("select * from staff where DepartmentID = '" + dt.DepartmentID + "'");
        }
        public DataTable staff_selectAll()
        {
            return Xuly.table_Select("select * from staff");
        }
    }
}
