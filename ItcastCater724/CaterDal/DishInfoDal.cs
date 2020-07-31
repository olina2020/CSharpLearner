using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class DishInfoDal
    {
        //查询
        public List<DishInfo> GetList()
        {
            string sql = @"select di.*, dti.dtitle as dTypeTitle 
                           from dishinfo as di
                           inner join dishtypeinfo as dti
                           on di.dtypeid = dti.did
                           where di.DIsDelete = 0 and dti.DIsDelete = 0";
            DataTable dt = SqliteHelper.GetDataTable(sql);
            List<DishInfo> list = new List<DishInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishInfo()
                { 
                    DId=Convert.ToInt32(row["did"]),
                    DTitle=row["dtitle"].ToString(),
                    DTypeTitle=row["dtypetitle"].ToString(),
                    DChar=row["dchar"].ToString(),
                    DPrice=Convert.ToDecimal(row["dprice"].ToString())
                });
            }

            return list;
        }
    }
}
