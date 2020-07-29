
using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class MemberInfoDal
    {
        public List<MemberInfo> GetList()
        {
            //连接查询，得到会员的名字
            string sql = "select mi.*, mti.mTitle as MTypeTitle from MemberInfo as mi " +
                "inner join MemberTypeInfo as mti on mi.mTypeId=mti.mid " +
                "where mi.mIsDelete=0";
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
                    MTypeTitle=row["MTypeTitle"].ToString()
                }) ;


            }
            return list;
        }

    }
}
