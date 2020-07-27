using CaterCommon;
using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class ManagerInfoBll
    {
        //创建数据层对象
        ManagerInfoDal miDal = new ManagerInfoDal();
        public List<ManagerInfo> GetList()
        {           
            return miDal.GetList();
        }
        public bool Add(ManagerInfo mi)
        {
            //调用dal层的insert方法，完成插入操作
            return miDal.Insert(mi) > 0;
        }
        public bool Edit(ManagerInfo mi)
        {
            //调用dal层的update方法，完成更新操作
            return miDal.Update(mi) > 0;
        }
        public bool Remove(int id)
        {
            return miDal.Delete(id) > 0;
        }
        public LoginState Login(string name, string pwd)
        {
            //根据用户名进行对象的查询
            ManagerInfo mi = miDal.GetByName(name);
            if (mi==null)
            {
                //用户名错误
                return LoginState.NameError;
            }
            else
            {
                //用户名正确
                if (mi.Mpwd.Equals(Md5Helper.EncryptString(pwd)))
                {
                    //密码正确
                    //登录成功
                    return LoginState.Ok;
                }
                else
                {
                    //密码不正确
                    return LoginState.PwdError;
                }
            }
        }
    }
}
