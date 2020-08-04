using CaterBll;
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
            if (type == 1)
            {
                //经理                
            }
            else 
            {
                //店员，管理员菜单隐藏
                menuManagerInfo.Visible = false;
            }
            //加载所有的厅包信息
            LoadHallInfo();
        }

        private void LoadHallInfo()//在主页面加载厅包信息
        {
            //获取所有的厅包对象
            HallInfoBll hiBll = new HallInfoBll();
            var list=hiBll.GetList();
            //清空，避免修改后反复添加
            tcHallInfo.TabPages.Clear();
            //遍历集合，向标签页中添加信息
            TableInfoBll tiBll = new TableInfoBll();
            foreach (var hi in list)
            {
                //根据厅包对象，创建标签页对象
                TabPage tp = new TabPage(hi.HTitle);
                //获取当前厅包对象的所有餐桌
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("thallid", hi.HId.ToString());
                var listTableInfo= tiBll.GetList(dic);
                //动态创建列表，添加到标签页上
                ListView lvTableInfo = new ListView();
                //添加双击事件，完成开单功能，+=之后双击Tab键，获得双击事件的方法
                lvTableInfo.DoubleClick += LvTableInfo_DoubleClick1;
                lvTableInfo.LargeImageList = imageList1;
                lvTableInfo.Dock = DockStyle.Fill;
                tp.Controls.Add(lvTableInfo);
                //向列表中添加餐桌信息
                foreach (var ti in listTableInfo)
                {
                    var lvi = new ListViewItem(ti.TTitle, ti.TIsFree ? 0 : 1);
                    //后续开单操作需要用到餐桌编号，所以在这里存一下
                    lvi.Tag = ti.TId;                    
                    lvTableInfo.Items.Add(lvi);
                }
                //将标签页加入标签容器
                tcHallInfo.TabPages.Add(tp);
            }
        }

        private void LvTableInfo_DoubleClick1(object sender, EventArgs e)
        {
            //获取被点的餐桌项
            var lv1 = sender as ListView;
            var lvi = lv1.SelectedItems[0];
            if (lvi.ImageIndex==0)
            {
                //当前餐桌空闲，则开单
                //拿到选中的桌
                int tableId = Convert.ToInt32(lvi.Tag);
                //1.开单，向orderinfo表插入数据
                //2.修改餐桌状态为使用
                OrderInfoBll oiBll = new OrderInfoBll();
                int orderId= oiBll.KaiDan(tableId);//获得订单号
                lvi.Tag = orderId;
                //3.更新餐桌图标，开单后由空闲改为使用中
                lv1.SelectedItems[0].ImageIndex = 1;
            }
            else
            {
                //当前餐桌已经占用，则进行点菜操作
            }
            //4.打开点菜窗体
            FormOrderDish formOrderDish = new FormOrderDish();
            formOrderDish.Tag = lvi.Tag;
            formOrderDish.Show();
        }

        private void LvTableInfo_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuManagerInfo_Click(object sender, EventArgs e)
        {
            FormManagerInfo formManagerInfo = FormManagerInfo.Create(); //new FormManagerInfo();
            formManagerInfo.Show();
            formManagerInfo.Focus();//将当前窗体获得焦点
        }

        private void menuMemberInfo_Click(object sender, EventArgs e)
        {
            FormMemberInfo formMemberInfo = new FormMemberInfo();
            formMemberInfo.Show();
        }

        private void menuTableInfo_Click(object sender, EventArgs e)
        {
            FormTableInfo formTableInfo = new FormTableInfo();
            formTableInfo.Refresh += LoadHallInfo;
            formTableInfo.Show();
        }

        private void menuDishInfo_Click(object sender, EventArgs e)
        {
            FormDishInfo formDishInfo = new FormDishInfo();
            formDishInfo.Show();
        }

       
    }
}
