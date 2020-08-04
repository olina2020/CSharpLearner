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
        public bool KaiDan(int tableId)
        {
            return oiDal.CreateOrder(tableId) > 0;
        }
    }
}
