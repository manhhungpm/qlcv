using QLCV.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Business.Boss
{
    class Xulydulieu
    {
        Dulieu dt = new Dulieu();
        public DataTable Boss_SelectAll()
        {
            return Xuly.table_Select("select * from boss");
        }
    }
}
