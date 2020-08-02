using CaterBll;
using CaterCommon;
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
    public partial class FormDishInfo : Form
    {
        public FormDishInfo()
        {
            InitializeComponent();
        }
        private DishInfoBll diBll = new DishInfoBll();

        private void FormDishInfo_Load(object sender, EventArgs e)
        {
            LoadTypeList();
            LoadList();           
        }
        private void LoadList()
        {
            //拼接条件
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (txtTitleSearch.Text!="")
            {
                dic.Add("dtitle", txtTitleSearch.Text);
            }
            if (ddlTypeSearch.SelectedValue.ToString()!="0")
            {
                dic.Add("DTypeId", ddlTypeSearch.SelectedValue.ToString());
            }
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = diBll.GetList(dic);            
        }
        private void LoadTypeList()
        {
            DishTypeInfoBll dtiBll = new DishTypeInfoBll();

            //为了下拉框显示“全部”，向list中插入数据
            #region 绑定搜索的下拉列表
            List<DishTypeInfo> list = dtiBll.GetList();
            list.Insert(0, new DishTypeInfo()
            {
                DId = 0,
                DTitle = "全部"
            }); 
            ddlTypeSearch.DataSource = list;
            ddlTypeSearch.ValueMember = "did";
            ddlTypeSearch.DisplayMember = "dtitle";
            #endregion

            #region 绑定添加的下拉列表
            cbbType.DataSource = dtiBll.GetList();
            cbbType.DisplayMember = "dtitle";
            cbbType.ValueMember = "did";
            #endregion


        }

        private void txtTitleSearch_Leave(object sender, EventArgs e)
        {
            LoadList();
        }

        private void ddlTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtTitleSearch.Text = "";
            ddlTypeSearch.SelectedIndex = 0;//显示“全部”
            LoadList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //收集用户输入的信息
            DishInfo di = new DishInfo()
            {
                DTitle = txtNameAdd.Text,
                DChar=txtPinyin.Text,
                DPrice=Convert.ToDecimal(txtPrice.Text),
                DTypeId=Convert.ToInt32(cbbType.SelectedValue)
            };
            if (txtIdAdd.Text=="添加时无编号")
            {
                //添加
                if (diBll.Add(di))
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
                di.DId = int.Parse(txtIdAdd.Text);
                if (diBll.Edit(di))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败，请稍后重试");
                }
            }
            //恢复控件
            txtIdAdd.Text = "添加时无编号";
            txtNameAdd.Text = "";
            txtPrice.Text = "";
            txtPinyin.Text = "";
            cbbType.SelectedIndex = 0;

        }

        private void txtNameAdd_Leave(object sender, EventArgs e)
        {
            txtPinyin.Text = PinyinHelper.GetPinyin(txtNameAdd.Text);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtIdAdd.Text = "添加时无编号";
            txtNameAdd.Text = "";
            txtPrice.Text = "";
            txtPinyin.Text = "";
            cbbType.SelectedIndex = 0;
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //双击列表中的某一行，将信息显示到右侧
            var row = dgvList.Rows[e.RowIndex];
            txtIdAdd.Text = row.Cells[0].Value.ToString();
            txtNameAdd.Text = row.Cells[1].Value.ToString();
            cbbType.Text = row.Cells[2].Value.ToString();
            txtPrice.Text = row.Cells[3].Value.ToString();
            txtPinyin.Text = row.Cells[4].Value.ToString();
            btnSave.Text = "修改";
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            FormDishTypeInfo formDti = new FormDishTypeInfo();
            DialogResult result = formDti.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadTypeList();
                LoadList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);
            DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (result==DialogResult.OK)
            {
                if (diBll.Remove(id))
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
}
