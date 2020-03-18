using System;

namespace Itcast20200317
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 加号的两个练习 卡卡西

            //Console.WriteLine("Hello World!");
            //string name = "卡卡西";
            //string add = "火影村";
            //int age = 30;
            //string email = "kakaxi@qq.com";
            //decimal payroll = 2000m;
            //Console.WriteLine("我叫" + name + ", 我住在" + add + ", 我今年" + age + "岁了，我的邮箱是" + email + ", 我的工资是" + payroll);

            //Console.WriteLine("我叫{0}, 我住在{1}, 我今天{2}岁了, 我的邮箱是{3}, 我的工资是{4}", name, add, age, email, payroll);

            //int age = 18;
            //age = 81;
            //Console.WriteLine(age); 
            #endregion

            #region 交换变量的两种方法
            //int number1 = 10;
            //int number2 = 5;
            //int temp = number1;
            //number1 = number2;
            //number2 = temp;
            //Console.WriteLine("交换后number1的值是{0}, number2的值是{1}", number1, number2);

            //int n1 = 10;
            //int n2 = 20;

            //n1 = n1 - n2;
            //n2 = n1 + n2;
            //n1 = n2 - n1;
            //Console.WriteLine("交换后n1的值是{0}, n2的值是{1}", n1, n2);
            #endregion

            #region 计算圆的周长和面积
            //int r = 5;
            //double s = 3.14*r*r;
            //double p = 2 * 3.14 * r;
            //Console.WriteLine("圆的面积是{0}，周长是{1}", s, p);
            #endregion

            #region T恤和裤子的费用
            //int tShirt = 35;
            //int trousers = 120;
            //int total = tShirt * 3 + trousers * 2;
            //double afterDiscount = total * 0.88;
            //Console.WriteLine("小明应该付的钱是{0}，打8.8折后的价格是{1}", total, afterDiscount);
            #endregion

            //int days = 46;
            //int week = days /7;
            //int rest = days % 7;
            //Console.WriteLine("是{0}周, 零{1}天", week, rest);

            int seconds = 107653;
            int days = seconds / 86400;
            int secs = seconds % 86400;
            int hours = secs / 3600;
            secs = secs % 3600;
            int minutes = secs / 60;
            secs = secs % 60;
            Console.WriteLine("{0}秒是{1}天，{2}个小时，{3}分钟, {4}秒", seconds, days, hours, minutes, secs);

            //Console.WriteLine("Please enter a number of day");
            //int days =Convert.ToInt32(Console.ReadLine());
            //int week = days / 7;
            //int rest = days % 7;
            //Console.WriteLine("是{0}周, 零{1}天", week, rest); 





        }
    }
}
