using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class OrderInfoBll
    {
        private OrderInfoDal oiDal = new OrderInfoDal();
        public int KaiDan(int tableId)
        {
            return oiDal.CreateOrder(tableId);
        }
        public int GetOrderIdByTableId(int tableId)
        {
            return oiDal.GetOrderIdByTableId(tableId);
        }
        //点菜
        public bool DianCai(int orderId, int dishId)
        {
            return oiDal.DianCai(orderId, dishId) > 0;
        }
        //在右侧的datagridview里显示点菜的数据
        public List<OrderDetailInfo> GetDetailList(int orderId)
        {
            return oiDal.GetDetailList(orderId);
        }

    }
}
