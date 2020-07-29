using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            //点击Quit按钮时
            //将当前应用程序退出，而不仅仅是关闭当前窗体
            Application.Exit();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //点击窗体的关闭按钮时
            //将当前应用程序退出，而不仅仅是关闭当前窗体
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //判断登录进来的员工级别，以确定是否显示MenuManager图标
            int type = Convert.ToInt32(this.Tag);
            if (type==1)
            {
                //经理
            }
            else
            {
                //店员，管理员菜单隐藏
                menuManagerInfo.Visible = false;
            }
        }

        private void menuManagerInfo_Click(object sender, EventArgs e)
        {
            FormManagerInfo formManagerInfo = FormManagerInfo.Create(); //new FormManagerInfo();
            formManagerInfo.Show();
            formManagerInfo.Focus();//将当前窗体获得焦点
        }
    }
}
