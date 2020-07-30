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
    public partial class MemberTypeInfoDal
    {
        //查询
        public List<MemberTypeInfo> GetList()
        {
            //查询未删除的数据
            string sql = "select * from memberTypeInfo where mIsDelete=0";
            //执行查询，返回表格
            DataTable dt = SqliteHelper.GetDataTable(sql);
            List<MemberTypeInfo> list = new List<MemberTypeInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberTypeInfo()
                {
                    MId = Convert.ToInt32(row["mid"]),
                    MTitle = row["mtitle"].ToString(),
                    MDiscount=Convert.ToDecimal(row["mdiscount"])
                }) ;
            }
            return list;
        }
        //添加
        public int Insert(MemberTypeInfo mti)
        {
            //构造insert语句
            string sql = "insert into MemberTypeInfo(mtitle, mdiscount, misDelete) values(@title, @discount, 0)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title", mti.MTitle),
                new SQLiteParameter("@discount", mti.MDiscount)
            };
            //执行
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        //修改
        public int Update(MemberTypeInfo mti)
        {
            string sql = "update MemberTypeInfo set mtitle=@title, mdiscount=@discount where mid=@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title", mti.MTitle),
                new SQLiteParameter("@discount", mti.MDiscount),
                new SQLiteParameter("@id", mti.MId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        //删除
        public int Delete(int id)
        {
            //进行逻辑删除的sql语句
            string sql = "update memberTypeInfo set mIsDelete=1 where mid=@id";
            //参数
            SQLiteParameter p = new SQLiteParameter("@id", id);
            //执行并返回受影响的行数
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
    }
}
