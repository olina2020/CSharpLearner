using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    public partial class OrderInfoDal
    {
        //开单，插入订单数据
        //更新餐桌状态
        //写在一起执行，只需要和数据库交互一次
        public int CreateOrder(int tableId)
        {
            //下订单
            string sql = "insert into orderinfo(odate, ispay, tableid) values(datetime('now', 'localtime'), 0, @tid); " +
                //更新餐桌状态
                "update tableinfo set tIsFree=0 where tid=@tid;" +
                //获取最新的订单编号
                "select oid from orderinfo order by oid desc limit 0,1";
            SQLiteParameter p = new SQLiteParameter("@tid", tableId);
            return Convert.ToInt32(SqliteHelper.ExecuteScalar(sql, p));
        }
        //根据桌子的ID获得订单的id
        public int GetOrderIdByTableId(int tableId)
        {
            string sql="select oid from orderinfo where tableId=@tableid and ispay=0";
            SQLiteParameter p = new SQLiteParameter("@tableid", tableId);
            return Convert.ToInt32(SqliteHelper.ExecuteScalar(sql, p));
        }

        //点菜
        public int DianCai(int orderid, int dishId)
        {
            string sql = "insert into orderDetailInfo(orderId, dishId, count) values(@oid, @did,1) ";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@oid", orderid),
                new SQLiteParameter("@did", dishId),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public List<OrderDetailInfo> GetDetailList(int orderId)
            {
            string sql = @"select di.DTitle, di.DPrice, odi.oid, odi.Count from dishinfo as di
                        inner join orderdetailinfo as odi
                        on di.DId = odi.DishId
                        where odi.OrderId = @orderid";
            SQLiteParameter p = new SQLiteParameter("@orderid", orderId);
            DataTable dt = SqliteHelper.GetDataTable(sql, p);
            List<OrderDetailInfo> list = new List<OrderDetailInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new OrderDetailInfo() 
                {
                    OId = Convert.ToInt32(row["oid"]),
                    DTitle=row["dtitle"].ToString(),
                    DPrice=Convert.ToDecimal(row["dprice"]),
                    Count=Convert.ToInt32(row["count"])
                });               
            }
            return list;
        }
    }
}
