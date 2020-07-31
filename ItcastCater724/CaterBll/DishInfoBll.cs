using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class DishInfoBll
    {
        private DishInfoDal diDal = new DishInfoDal();
        //查询
        public List<DishInfo> GetList()
        {
            return diDal.GetList();
        }
    }
}
