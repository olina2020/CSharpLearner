﻿using CaterModel;
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
        public List<DishInfo> GetList(Dictionary<string, string> dic)
        {
            string sql = @"select di.*, dti.dtitle as dTypeTitle 
                           from dishinfo as di
                           inner join dishtypeinfo as dti
                           on di.dtypeid = dti.did
                           where di.DIsDelete = 0 and dti.DIsDelete = 0";
            //List<SQLiteParameter> listP = new List<SQLiteParameter>();
            //接收筛选条件
            if (dic.Count>0)
            {
                //sql += " and di.属性 like '%值%'";
                foreach (var pair in dic)
                {
                    sql += " and di." + pair.Key + " like '%" + pair.Value + "%'";
                    //sql += " and di." + pair.Key + " like @"+pair.Key;
                    //listP.Add(new SQLiteParameter("@"+pair.Key, "%"+pair.Value+"%"));
                }
            }
            
            
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
        //添加
        public int Insert(DishInfo di)
        {
            string sql = "insert into DishInfo (dtitle, dtypeid, dprice, dchar, dIsDelete) values (@title, @tid, @price, @dchar, 0)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title", di.DTitle),
                new SQLiteParameter("@tid", di.DTypeId),
                new SQLiteParameter("@price", di.DPrice),
                new SQLiteParameter("@dchar", di.DChar)
            };
            return SqliteHelper.ExecuteNonQuery(sql,ps);
        }
        //修改
        public int Update(DishInfo di)
        {
            string sql = "update DishInfo set dtitle=@title, dtypeid=@tid, dprice=@price, dchar=@dchar where did=@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id", di.DId),
                new SQLiteParameter("@title", di.DTitle),
                new SQLiteParameter("@tid", di.DTypeId),
                new SQLiteParameter("@price", di.DPrice),
                new SQLiteParameter("@dchar", di.DChar)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

    }
}
