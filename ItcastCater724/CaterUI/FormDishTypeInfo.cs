﻿using CaterBll;
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
        private void FormDishTypeInfo_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = dtiBll.GetList();

        }
    }
}
