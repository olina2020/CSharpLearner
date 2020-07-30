
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
    public partial class MemberInfoDal
    {
        public List<MemberInfo> GetList(Dictionary<string, string> dic)
        {
            //连接查询，得到会员的名字
            string sql = "select mi.*, mti.mTitle as MTypeTitle from MemberInfo as mi " +
                "inner join MemberTypeInfo as mti on mi.mTypeId=mti.mid " +
                "where mi.mIsDelete=0";
            //拼接条件
            if (dic.Count > 0)
            {
                foreach (var pair in dic)
                {
                    sql += " and " + pair.Key + " like '%" + pair.Value + "%'";
                }
            }
            //执行得到结果集
            DataTable dt = SqliteHelper.GetDataTable(sql);
            //定义list,完成转存
            List<MemberInfo> list = new List<MemberInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberInfo()
                {
                    MId = Convert.ToInt32(row["mid"]),
                    MName = row["mname"].ToString(),
                    MPhone = row["mphone"].ToString(),
                    MMoney = Convert.ToDecimal(row["mmoney"]),
                    MTypeId = Convert.ToInt32(row["MTypeId"]),
                    MTypeTitle = row["MTypeTitle"].ToString()
                });


            }
            return list;
        }
        //添加
        public int Insert(MemberInfo mi)
        {
            //构造insert语句
            string sql = "insert into memberinfo(mtypeid, mname, mphone, mmoney, misDelete) values(@tid, @name, @phone, @money, 0)";
            //为语句构造参数
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@tid", mi.MTypeId),
                new SQLiteParameter("@name", mi.MName),
                new SQLiteParameter("@phone", mi.MPhone),
                new SQLiteParameter("@money", mi.MMoney)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);

        }
        //修改
        public int Update(MemberInfo mi)
        {
            string sql = "update memberinfo set mname=@name, mphone=@phone, mmoney=@money, mtypeid=@tid where mid=@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name", mi.MName),
                new SQLiteParameter("@phone", mi.MPhone),
                new SQLiteParameter("@money", mi.MMoney),
                new SQLiteParameter("@tid", mi.MTypeId),
                new SQLiteParameter("@id", mi.MId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        //删除
        public int Delete(int id)//软删除
        {
            string sql = "update memberinfo set mIsDelete=1 where mid=@id";
            SQLiteParameter p = new SQLiteParameter("@id", id);
            return SqliteHelper.ExecuteNonQuery(sql,p);
        }
    }
}
