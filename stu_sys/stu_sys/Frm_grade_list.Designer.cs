namespace stu_sys
{
    partial class Frm_grade_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_grade_list));
            this.dgv_grade_list = new System.Windows.Forms.DataGridView();
            this.col_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gName = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grade_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_grade_list
            // 
            this.dgv_grade_list.AllowUserToAddRows = false;
            this.dgv_grade_list.AllowUserToDeleteRows = false;
            this.dgv_grade_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_grade_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grade_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_check,
            this.gId,
            this.gName,
            this.col_modify,
            this.col_delete});
            this.dgv_grade_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_grade_list.Location = new System.Drawing.Point(0, 65);
            this.dgv_grade_list.Name = "dgv_grade_list";
            this.dgv_grade_list.RowHeadersVisible = false;
            this.dgv_grade_list.RowTemplate.Height = 23;
            this.dgv_grade_list.Size = new System.Drawing.Size(614, 290);
            this.dgv_grade_list.TabIndex = 0;
            this.dgv_grade_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_grade_list_CellContentClick);
            // 
            // col_check
            // 
            this.col_check.HeaderText = "Select";
            this.col_check.Name = "col_check";
            // 
            // gId
            // 
            this.gId.DataPropertyName = "gId";
            this.gId.HeaderText = "Grade ID";
            this.gId.Name = "gId";
            this.gId.ReadOnly = true;
            // 
            // gName
            // 
            this.gName.DataPropertyName = "gName";
            this.gName.HeaderText = "Grade Name";
            this.gName.Name = "gName";
            this.gName.ReadOnly = true;
            // 
            // col_modify
            // 
            dataGridViewCellStyle1.NullValue = "Modify";
            this.col_modify.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_modify.HeaderText = "Modify";
            this.col_modify.Name = "col_modify";
            // 
            // col_delete
            // 
            dataGridViewCellStyle2.NullValue = "Delete";
            this.col_delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_delete.HeaderText = "Delete";
            this.col_delete.Name = "col_delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(144, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade Name";
            // 
            // txt_gName
            // 
            this.txt_gName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gName.Location = new System.Drawing.Point(226, 23);
            this.txt_gName.Name = "txt_gName";
            this.txt_gName.Size = new System.Drawing.Size(143, 23);
            this.txt_gName.TabIndex = 2;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_submit.Location = new System.Drawing.Point(404, 23);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(48, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Location = new System.Drawing.Point(495, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Frm_grade_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 355);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_gName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_grade_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_grade_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade List";
            this.Load += new System.EventHandler(this.Frm_grade_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grade_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_grade_list;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn gId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gName;
        private System.Windows.Forms.DataGridViewLinkColumn col_modify;
        private System.Windows.Forms.DataGridViewLinkColumn col_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gName;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
    }
}