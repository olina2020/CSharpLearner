using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class TableInfoBll
    { 
        private TableInfoDal tiDal=new TableInfoDal();
        //查询
        public List<TableInfo> GetList(Dictionary<string, string> dic)
        {
            return tiDal.GetList(dic);
        }
        //添加
        public bool Add(TableInfo ti)
        {
            return tiDal.Insert(ti) > 0;
        }
        //修改
        public bool Edit(TableInfo ti)
        {
            return tiDal.Update(ti) > 0;
        }
        //删除
        public bool Remove(int id)
        {
            return tiDal.Delete(id) > 0;
        }


    }
}
