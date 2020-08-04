using CaterDal;
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
        //点菜
        public bool DianCai(int orderId, int dishId)
        {
            return oiDal.DianCai(orderId, dishId) > 0;
        }

    }
}
