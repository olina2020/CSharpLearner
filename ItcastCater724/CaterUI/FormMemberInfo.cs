using CaterBll;
using CaterModel;
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
    public partial class FormMemberInfo : Form
    {
        public FormMemberInfo()
        {
            InitializeComponent();
        }
        MemberInfoBll miBll = new MemberInfoBll();
        //private void FormMemberInfo_Load(object sender, EventArgs e)
        //{
        //    LoadList();
        //}
        private void FormMemberInfo_Load_1(object sender, EventArgs e)
        {
            //加载会员信息
            LoadList();
            //加载会员分类信息
            LoadTypeList();
        }
        private void LoadList()
        {
            //使用键值对存储条件
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //收集用户名信息
            if (txtNameSearch.Text!="")
            {
                //需要根据姓名搜索
                dic.Add("mname", txtNameSearch.Text);

            }
            //收集手机号信息
            if (txtPhoneSearch.Text!="")
            {
                dic.Add("MPhone", txtPhoneSearch.Text);
            }
            //根据条件进行查询
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = miBll.GetList(dic);
        }
        private void LoadTypeList()
        {
            MemberTypeInfoBll mtiBll = new MemberTypeInfoBll();
            List<MemberTypeInfo> list = mtiBll.GetList();

            ddlType.DataSource = list;
            //设置显示值
            ddlType.DisplayMember = "mtitle";
            //设置value值
            ddlType.ValueMember = "mid";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            //内容改变事件
            LoadList();
        }

        private void txtPhoneSearch_Leave(object sender, EventArgs e)
        {
            //失去焦点事件
            LoadList();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtNameSearch.Text = "";
            txtPhoneSearch.Text = "";
            LoadList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //值的有效性判断
            if (txtNameAdd.Text=="")//同理，可以写电话号码为空，余额为空的判断代码
            {
                MessageBox.Show("请输入会员姓名");
                txtNameAdd.Focus();
                return;
            }
            //接收用户输入的数据
            MemberInfo mi = new MemberInfo()
            {
                MName = txtNameAdd.Text,
                MPhone = txtPhoneAdd.Text,
                MMoney = Convert.ToDecimal(txtMoney.Text),
                MTypeId=Convert.ToInt32(ddlType.SelectedValue),
            };
            if (txtId.Text.Equals("添加时无编号"))
            {
                //添加
                if (miBll.Add(mi))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败，请稍后重试");
                }
            }
            else
            {
                //修改
            }
            //恢复控件的值
            txtId.Text = "添加时无编号";
            txtNameAdd.Text = "";
            txtPhoneAdd.Text = "";
            txtMoney.Text = "";
            ddlType.SelectedIndex = 0;//第一项被选中
            btnSave.Text = "添加";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //恢复控件的值
            txtId.Text = "添加时无编号";
            txtNameAdd.Text = "";
            txtPhoneAdd.Text = "";
            txtMoney.Text = "";
            ddlType.SelectedIndex = 0;//第一项被选中
            btnSave.Text = "添加";
        }
    }
}
