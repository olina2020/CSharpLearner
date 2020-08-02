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
    public partial class FormHallInfo : Form
    {
        public FormHallInfo()
        {
            InitializeComponent();
            hiBll = new HallInfoBll();
        }
        private HallInfoBll hiBll;
        private void FormHallInfo_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = hiBll.GetList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HallInfo hi = new HallInfo()
            {
                HTitle = txtTitle.Text
            };
            if (txtId.Text== "添加时无编号")
            {
                //添加
                if (hiBll.Add(hi))
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
                hi.HId = int.Parse(txtId.Text);
                if (hiBll.Edit(hi))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败，请稍后重试");
                }
            }
            txtId.Text = "添加时无编号";
            txtTitle.Text = "";
            btnSave.Text = "添加";
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);
            DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (result==DialogResult.Cancel)
            {
                return;
            }
            if (hiBll.Remove(id))
            {
                LoadList();
            }
        }
    }
}
