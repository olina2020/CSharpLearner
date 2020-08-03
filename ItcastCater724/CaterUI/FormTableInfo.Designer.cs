namespace CaterUI
{
    partial class FormTableInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddType = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ddlHallAdd = new System.Windows.Forms.ComboBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtIdAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbUnFree = new System.Windows.Forms.RadioButton();
            this.rbFree = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlFreeSearch = new System.Windows.Forms.ComboBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlHallSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(95, 145);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(167, 23);
            this.btnAddType.TabIndex = 10;
            this.btnAddType.Text = "厅包管理";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(74, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "提示：双击表格项进行修改";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(186, 282);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 28);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(77, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "添加";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(77, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除选中的行数据";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ddlHallAdd
            // 
            this.ddlHallAdd.FormattingEnabled = true;
            this.ddlHallAdd.Location = new System.Drawing.Point(96, 104);
            this.ddlHallAdd.Name = "ddlHallAdd";
            this.ddlHallAdd.Size = new System.Drawing.Size(167, 24);
            this.ddlHallAdd.TabIndex = 5;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(96, 73);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(167, 22);
            this.txtNameAdd.TabIndex = 4;
            // 
            // txtIdAdd
            // 
            this.txtIdAdd.Location = new System.Drawing.Point(96, 39);
            this.txtIdAdd.Name = "txtIdAdd";
            this.txtIdAdd.Size = new System.Drawing.Size(167, 22);
            this.txtIdAdd.TabIndex = 4;
            this.txtIdAdd.Text = "添加时无编号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "空 闲：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "厅 包：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "名 称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "添加\\修改";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.rbUnFree);
            this.groupBox3.Controls.Add(this.rbFree);
            this.groupBox3.Controls.Add(this.btnAddType);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnCancle);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.ddlHallAdd);
            this.groupBox3.Controls.Add(this.txtNameAdd);
            this.groupBox3.Controls.Add(this.txtIdAdd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(685, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 401);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "如果是包间则填写名称如果是厅包则填写号码";
            // 
            // rbUnFree
            // 
            this.rbUnFree.AutoSize = true;
            this.rbUnFree.Location = new System.Drawing.Point(172, 239);
            this.rbUnFree.Name = "rbUnFree";
            this.rbUnFree.Size = new System.Drawing.Size(71, 21);
            this.rbUnFree.TabIndex = 12;
            this.rbUnFree.Text = "使用中";
            this.rbUnFree.UseVisualStyleBackColor = true;
            // 
            // rbFree
            // 
            this.rbFree.AutoSize = true;
            this.rbFree.Checked = true;
            this.rbFree.Location = new System.Drawing.Point(92, 239);
            this.rbFree.Name = "rbFree";
            this.rbFree.Size = new System.Drawing.Size(57, 21);
            this.rbFree.TabIndex = 11;
            this.rbFree.TabStop = true;
            this.rbFree.Text = "空闲";
            this.rbFree.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "编 号：";
            // 
            // ddlFreeSearch
            // 
            this.ddlFreeSearch.FormattingEnabled = true;
            this.ddlFreeSearch.Location = new System.Drawing.Point(97, 78);
            this.ddlFreeSearch.Name = "ddlFreeSearch";
            this.ddlFreeSearch.Size = new System.Drawing.Size(166, 24);
            this.ddlFreeSearch.TabIndex = 6;
            this.ddlFreeSearch.SelectedIndexChanged += new System.EventHandler(this.ddlFreeSearch_SelectedIndexChanged);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(96, 109);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(167, 32);
            this.btnSearchAll.TabIndex = 5;
            this.btnSearchAll.Text = "显示全部";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "空 闲：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "厅 包：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "搜索";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlHallSearch);
            this.groupBox2.Controls.Add(this.ddlFreeSearch);
            this.groupBox2.Controls.Add(this.btnSearchAll);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(684, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 159);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // ddlHallSearch
            // 
            this.ddlHallSearch.FormattingEnabled = true;
            this.ddlHallSearch.Location = new System.Drawing.Point(96, 35);
            this.ddlHallSearch.Name = "ddlHallSearch";
            this.ddlHallSearch.Size = new System.Drawing.Size(166, 24);
            this.ddlHallSearch.TabIndex = 6;
            this.ddlHallSearch.SelectedIndexChanged += new System.EventHandler(this.ddlHallSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "列表";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 18);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(661, 491);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 512);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TId";
            this.Column1.HeaderText = "编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TTitle";
            this.Column2.HeaderText = "名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HallTitle";
            this.Column3.HeaderText = "厅包";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TIsFree";
            this.Column4.HeaderText = "是否空闲";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // FormTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 624);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTableInfo";
            this.Text = "餐桌管理";
            this.Load += new System.EventHandler(this.FormTableInfo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox ddlHallAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.TextBox txtIdAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlFreeSearch;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlHallSearch;
        private System.Windows.Forms.RadioButton rbUnFree;
        private System.Windows.Forms.RadioButton rbFree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}