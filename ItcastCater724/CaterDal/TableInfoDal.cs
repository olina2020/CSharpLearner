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
    public partial class TableInfoDal
    {
        //查询，搜索
        public List<TableInfo> GetList(Dictionary<string, string> dic)
        {
            string sql = @"select ti.*, hi.HTitle from tableinfo as ti
                        inner join hallinfo as hi
                        on ti.THallId = hi.HId
                        where ti.TIsDelete = 0 and hi.HIsDelete = 0";
            
            List<SQLiteParameter> listP = new List<SQLiteParameter>();
            if (dic.Count>0)
            {
                foreach (var pair in dic)
                {
                    sql += " and " + pair.Key + "=@" + pair.Key;
                    listP.Add(new SQLiteParameter("@" + pair.Key, pair.Value));
                }
            }
            DataTable dt = SqliteHelper.GetDataTable(sql, listP.ToArray());
            List<TableInfo> list = new List<TableInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TableInfo()
                {
                    TId=Convert.ToInt32(row["tid"]),
                    TTitle=row["ttitle"].ToString(),
                    HallTitle=row["htitle"].ToString(),//datagridview显示厅包项
                    THallId=Convert.ToInt32(row["thallId"]),
                    TIsFree=Convert.ToBoolean(row["tIsFree"])
                });
            }
            return list;
        }
        //添加
        public int Insert(TableInfo ti)
        {
            string sql = "insert into TableInfo (TTitle, THallid, TIsFree, TIsDelete) values (@title, @hid, @isfree, 0)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title", ti.TTitle),
                new SQLiteParameter("@hid", ti.THallId),
                new SQLiteParameter("@isfree", ti.TIsFree),
            };
            return SqliteHelper.ExecuteNonQuery(sql,ps);
        }
        //修改
        public int Update(TableInfo ti)
        {
            string sql = "update TableInfo set ttitle=@title, thallid=@hid, tisfree=@isfree where tid=@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title", ti.TTitle),
                new SQLiteParameter("@hid", ti.THallId),
                new SQLiteParameter("@isfree", ti.TIsFree),
                new SQLiteParameter("@id", ti.TId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        //删除
        public int Delete(int id)
        {
            string sql = "update TableInfo set tisdelete=1 where tid=@id";
            SQLiteParameter p = new SQLiteParameter("@id", id);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
        //因为开单，改变餐桌状态
        //public int SetState(int tableId, bool isFree)
        //{
        //    string sql = "update tableinfo set tIsFree=@isfree where tid=@tid";
        //    SQLiteParameter[] ps =
        //    {
        //        new SQLiteParameter("@tid", tableId),
        //        new SQLiteParameter("@isfree", isFree?1:0)
        //    };
        //    return SqliteHelper.ExecuteNonQuery(sql, ps);
        //}
    }
}
