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
    public partial class FormDishTypeInfo : Form
    {
        public FormDishTypeInfo()
        {
            InitializeComponent();
        }
        DishTypeInfoBll dtiBll = new DishTypeInfoBll();
        //设置一个全局变量，并赋初始值
        private int rowIndex = -1;
        private DialogResult result = DialogResult.Cancel;
        private void FormDishTypeInfo_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            //设置列自动适应宽度
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = dtiBll.GetList();
            //设置某行选中
            if (rowIndex>=0)
            {
                dgvList.Rows[rowIndex].Selected = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //添加
            //根据用户输入构造对象
            DishTypeInfo dti = new DishTypeInfo()
            { 
                DTitle = txtTitle.Text
            };            
            if (btnSave.Text=="添加")
            {
                //添加
                if (dtiBll.Add(dti))
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
                dti.DId = Convert.ToInt32(txtId.Text);
                if (dtiBll.Edit(dti))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败，请稍后重试");
                }
                
            }
            
            //清除文本值
            txtId.Text = "添加时无编号";
            txtTitle.Text = "";
            btnSave.Text = "添加";

            this.result = DialogResult.OK;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtId.Text = "添加时无编号";
            txtTitle.Text = "";
            btnSave.Text = "添加";
        }       
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvList.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtTitle.Text = row.Cells[1].Value.ToString();
            btnSave.Text = "修改";

            //记录被点击行的索引，用于刷新后再次被选中
            rowIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = dgvList.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value);

            DialogResult result= MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (result==DialogResult.Cancel)
            {
                return;
            }
            if (dtiBll.Remove(id))
            {
                LoadList();
            }
            else
            {
                MessageBox.Show("删除失败，请稍后重试");
            }
            this.result = DialogResult.OK;
        }

        private void FormDishTypeInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = this.result;
        }
    }
}
