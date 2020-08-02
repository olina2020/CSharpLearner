using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class HallInfoBll
    {
        //创建Bll实例并初始化
        private HallInfoDal hiDal;
        public HallInfoBll()
        {
            hiDal = new HallInfoDal();
        }
        //查询
        public List<HallInfo> GetList()
        {
            return hiDal.GetList();
        }
        public bool Add(HallInfo hi)
        {
            return hiDal.Insert(hi)>0;
        }
        public bool Edit(HallInfo hi)
        {
            return hiDal.Update(hi) > 0;
        }
        public bool Remove(int id)
        {
            return hiDal.Delete(id) > 0;
        }

    }
}
