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

            #region 判断X天是几周零几天，判断X秒是几天几分几秒
            //int days = 46;
            //int week = days /7;
            //int rest = days % 7;
            //Console.WriteLine("是{0}周, 零{1}天", week, rest);

            //int seconds = 107653;
            //int days = seconds / 86400;
            //int secs = seconds % 86400;
            //int hours = secs / 3600;
            //secs = secs % 3600;
            //int minutes = secs / 60;
            //secs = secs % 60;
            //Console.WriteLine("{0}秒是{1}天，{2}个小时，{3}分钟, {4}秒", seconds, days, hours, minutes, secs);

            //Console.WriteLine("Please enter a number of day");
            //int days = Convert.ToInt32(Console.ReadLine());
            //int week = days / 7;
            //int rest = days % 7;
            //Console.WriteLine("是{0}周, 零{1}天", week, rest);
            #endregion

            #region 请用户输入一个年份，判断是否闰年
            /*Console.WriteLine("请输入需要判断闰年的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            bool b = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
            Console.WriteLine(b);*/
            #endregion

            #region 老苏的奖励
            //Console.WriteLine("Please enter your chinese score");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your music score");
            //int music = Convert.ToInt32(Console.ReadLine());
            //bool b = (chinese > 90 && music > 80) || (chinese == 100 && music > 70);
            //if (b)
            //{
            //    Console.WriteLine("You could obtain $100.");
            //}
            #endregion

            #region 输入用户名和密码
            //Console.WriteLine("Please enter your ID.");
            //string id = Console.ReadLine();
            //Console.WriteLine("Please enter your password.");
            //string pw = Console.ReadLine();
            //bool b = (id == "admin") && (pw == "mypass");
            //if (b)
            //{
            //    Console.WriteLine("Login successfully.");
            //}
            #endregion

            #region 使用if结构判断分数等级
            //Console.WriteLine("Please enter your score.");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //if (score < 90 && score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //if (score < 80 && score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score < 70 && score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //if (score<60)
            //{
            //    Console.WriteLine("E");
            //}
            #endregion
            #region 使用if else 判断分数等级，多级嵌套，不推荐
            //Console.WriteLine("Please enter your score.");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    if (score >= 80)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            //}
            #endregion
            #region 最正确的做法，使用 if else-if 来做
            //Console.WriteLine("Please enter your score.");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("E");
            //}
            #endregion
            #region 请客人输入三个数，输出最大的那个
            //Console.WriteLine("Please enter the first number");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the second number");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the third number");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine(n1);
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine(n2);
            //}
            //else
            //{
            //    Console.WriteLine(n3);
            //}
            #endregion




        }
    }
}
