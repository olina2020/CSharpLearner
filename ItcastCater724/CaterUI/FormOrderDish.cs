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
    public partial class FormOrderDish : Form
    {
        public FormOrderDish()
        {
            InitializeComponent();
        }
        OrderInfoBll oiBll = new OrderInfoBll();
        private void FormOrderDish_Load(object sender, EventArgs e)
        {
            LoadDishType();
            LoadDishInfo();
            LoadDetailList();
        }
        private void LoadDishInfo()
        {
            //拼接查询条件
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (txtTitle.Text!="")
            {
                dic.Add("dchar", txtTitle.Text);
            }
            if (ddlType.SelectedValue.ToString()!="0")
            {
                dic.Add("dtypeid", ddlType.SelectedValue.ToString());
            }
            
            
            //查询菜品，显示到表格中
            DishInfoBll diBll = new DishInfoBll();
            dgvAllDish.AutoGenerateColumns = false;
            dgvAllDish.DataSource= diBll.GetList(dic);
        }
        private void LoadDishType()
        {
            DishTypeInfoBll dtiBll = new DishTypeInfoBll();
            var list = dtiBll.GetList();
            list.Insert(0, new DishTypeInfo()
            {
                DId=0,
                DTitle="全部"
            });
            ddlType.ValueMember = "did";
            ddlType.DisplayMember = "dtitle";
            ddlType.DataSource = list;
        }
        private void LoadDetailList()
        {
            int orderId = Convert.ToInt32(this.Tag);
            dgvOrderDetail.AutoGenerateColumns = false;
            dgvOrderDetail.DataSource = oiBll.GetDetailList(orderId);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            LoadDishInfo();
        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDishInfo();
        }

        private void dgvAllDish_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //点菜
            //订单编号
            int orderId = Convert.ToInt32(this.Tag);

            //菜单编号
            int dishId = Convert.ToInt32(dgvAllDish.Rows[e.RowIndex].Cells[0].Value);
            //执行点菜操作
            
            if (oiBll.DianCai(orderId, dishId))
            {
                //点菜成功
                LoadDetailList();
            } 

        }
    }
}
