using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class DishTypeInfoDal
    {
        //查询
        public List<DishTypeInfo> GetList()
        {
            string sql = "select * from DishTypeInfo where dIsDelete=0";
            DataTable dt = SqliteHelper.GetDataTable(sql);
            //转存集合
            List<DishTypeInfo> list = new List<DishTypeInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishTypeInfo()
                {
                    DId=Convert.ToInt32(row["did"]),
                    DTitle=row["dtitle"].ToString()
                });                   
            }
            return list;
        }
        //添加

    }
}
