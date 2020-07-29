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
            LoadList();
        }
        private void LoadList()
        {
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = miBll.GetList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
