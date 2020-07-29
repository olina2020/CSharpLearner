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
    public partial class FormMemberTypeInfo : Form
    {
        public FormMemberTypeInfo()
        {
            InitializeComponent();
        }
        MemberTypeInfoBll mtiBll = new MemberTypeInfoBll();
        private void FormMemberTypeInfo_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource=mtiBll.GetList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("添加时无编号"))
            {
                //添加
                //接收用户输入的值，构造对象
                MemberTypeInfo mti = new MemberTypeInfo()
                {
                    MTitle = txtTitle.Text,
                    MDiscount = Convert.ToDecimal(txtDiscount.Text)
                };
                //调用添加方法
                if (mtiBll.Add(mti))
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
            //将控件还原
            txtId.Text = "添加时无编号";
            txtTitle.Text = "";
            txtDiscount.Text = "";
            btnSave.Text = "添加";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Text = "添加时无编号";
            txtTitle.Text = "";
            txtDiscount.Text = "";
            btnSave.Text = "添加";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //获取选中行的编号
            var row=dgvList.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value);
            //删除前确认提示
            DialogResult result= MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
            //进行删除
            if (result==DialogResult.Cancel)
            {
                //取消删除，跳出
                return;
            }
            if (mtiBll.Remove(id))
            {
                LoadList();
            }
            else
            {
                MessageBox.Show("删除失败，请稍后重试");
            }
        }
    }
}
