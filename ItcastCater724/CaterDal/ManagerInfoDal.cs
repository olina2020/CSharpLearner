using CaterCommon;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterDal
{
    
    public partial class ManagerInfoDal
    {
        /// <summary>
        /// 查询获取结果集
        /// </summary>
        /// <returns></returns>
        public List<ManagerInfo> GetList()
        {
            //构造要查询的SQL语句
            string sql = "select * from ManagerInfo";
            DataTable dt = SqliteHelper.GetDataTable(sql);
            //将dt中的数据转存到list中
            List<ManagerInfo> list = new List<ManagerInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ManagerInfo()
                {
                    MId = Convert.ToInt32(row["mid"]),
                    MName = row["mname"].ToString(),
                    Mpwd = row["mpwd"].ToString(),
                    Mtype = Convert.ToInt32(row["mtype"])
                });
            }
            return list;//将集合返回
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi">ManagerInfo类型的对象</param>
        /// <returns>受影响的行数</returns>
        public int Insert(ManagerInfo mi)
        {
            //构造insert语句
            string sql = "insert into ManagerInfo(mname, mpwd,mtype) values(@name,@pwd,@type)";
            //构造sql语句的参数，使用数组初始化器
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name", mi.MName),
                new SQLiteParameter("@pwd", Md5Helper.EncryptString (mi.Mpwd)),//将密码进行加密
                new SQLiteParameter("@type", mi.Mtype)
            };
            //执行插入操作
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        //修改管理员，特别注意，密码是否修改
        public int Update(ManagerInfo mi)
        {
            //定义参数集合，可以动态添加元素
            List<SQLiteParameter> listPs = new List<SQLiteParameter>();
            //构造update的sql语句
            string sql = "update ManagerInfo set mname=@name";
            listPs.Add(new SQLiteParameter("@name", mi.MName));
            if (!mi.Mpwd.Equals("这是原来的密码吗"))
            {
                sql += ", mpwd=@pwd";
                listPs.Add(new SQLiteParameter("@pwd", Md5Helper.EncryptString(mi.Mpwd)));
            }
            //继续拼接语句
            sql+=", mpwd=@pwd, mtype=@type where mid=@id";
            listPs.Add(new SQLiteParameter("@type", mi.Mtype));
            listPs.Add(new SQLiteParameter("@id", mi.MId));           
            //执行语句并返回结果
            return SqliteHelper.ExecuteNonQuery(sql, listPs.ToArray());
        }
        //根据编号删除管理员
        public int Delete(int id)
        {
            string sql = "delete from ManagerInfo where mid=@id";
            //根据语句构造参数
            SQLiteParameter p = new SQLiteParameter("@id", id);
            //执行操作
            return SqliteHelper.ExecuteNonQuery(sql,p);
        }
        /// <summary>
        /// 根据用户名查找对象
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ManagerInfo GetByName(string name)
        {
            //定义一个对象
            ManagerInfo mi = null;
            //构造语句
            string sql = "select * from ManagerInfo where mname=@name";
            //为语句构造参数
            SQLiteParameter p = new SQLiteParameter("@name", name);
            //执行查询得到结果
            DataTable dt= SqliteHelper.GetDataTable(sql, p);
            //判断是否根据用户名查找到了对象
            if (dt.Rows.Count>0)
            {
                //用户名存在
                mi = new ManagerInfo()
                {
                    MId = Convert.ToInt32(dt.Rows[0][0]),
                    MName=name,
                    Mpwd=dt.Rows[0][2].ToString(),
                    Mtype=Convert.ToInt32(dt.Rows[0][3])
                };
                
            }
            else
            {
                //用户名不存在
               
            }
            return mi;
        }

    }
}
