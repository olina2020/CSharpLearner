using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class DishTypeInfoBll
    {
        //查询
        private DishTypeInfoDal dtiDal = new DishTypeInfoDal();
        public List<DishTypeInfo> GetList()
        {
            return dtiDal.GetList();
        }
    }
}
