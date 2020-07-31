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
    public partial class FormDishInfo : Form
    {
        public FormDishInfo()
        {
            InitializeComponent();
        }
        private DishInfoBll diBll = new DishInfoBll();

        private void FormDishInfo_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = diBll.GetList();
        }
    }
}
