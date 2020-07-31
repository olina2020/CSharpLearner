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
        public int Insert(DishTypeInfo dti)
        {
            string sql = "insert into DishTypeInfo(dTitle, dIsDelete) values(@title, 0)";
            SQLiteParameter p = new SQLiteParameter("@title", dti.DTitle);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
        //修改
        public int Update(DishTypeInfo dti)
        {
            string sql = "update DishTypeInfo set dtitle=@title where did=@id";
            SQLiteParameter[] ps =
                {
                    new SQLiteParameter("@title", dti.DTitle),
                    new SQLiteParameter("@id", dti.DId)
                };           
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        //删除
        public int Delete(int id)
        {
            string sql = "Update DishTypeInfo set dIsDelete=1 where did=@id";
            SQLiteParameter p = new SQLiteParameter("@id", id);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
    }
}
