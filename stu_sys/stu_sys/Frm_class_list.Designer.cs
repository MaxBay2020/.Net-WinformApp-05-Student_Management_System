namespace stu_sys
{
    partial class Frm_class_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_class_list));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_grade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_class_list = new System.Windows.Forms.DataGridView();
            this.col_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.txt_class);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_grade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_delete.Location = new System.Drawing.Point(464, 33);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_find
            // 
            this.btn_find.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_find.Location = new System.Drawing.Point(364, 33);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 5;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(228, 32);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(121, 23);
            this.txt_class.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(193, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class";
            // 
            // cbo_grade
            // 
            this.cbo_grade.FormattingEnabled = true;
            this.cbo_grade.Location = new System.Drawing.Point(54, 30);
            this.cbo_grade.Name = "cbo_grade";
            this.cbo_grade.Size = new System.Drawing.Size(121, 25);
            this.cbo_grade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade";
            // 
            // dgv_class_list
            // 
            this.dgv_class_list.AllowUserToAddRows = false;
            this.dgv_class_list.AllowUserToDeleteRows = false;
            this.dgv_class_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_class_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_class_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_check,
            this.cId,
            this.cName,
            this.Grade,
            this.Comment,
            this.col_modify,
            this.col_delete});
            this.dgv_class_list.Location = new System.Drawing.Point(0, 96);
            this.dgv_class_list.Name = "dgv_class_list";
            this.dgv_class_list.RowTemplate.Height = 23;
            this.dgv_class_list.Size = new System.Drawing.Size(783, 302);
            this.dgv_class_list.TabIndex = 1;
            this.dgv_class_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_class_list_CellContentClick);
            // 
            // col_check
            // 
            this.col_check.HeaderText = "Select";
            this.col_check.Name = "col_check";
            // 
            // cId
            // 
            this.cId.DataPropertyName = "cId";
            this.cId.HeaderText = "Class ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "cName";
            this.cName.HeaderText = "Class Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "gName";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // col_modify
            // 
            dataGridViewCellStyle1.NullValue = "Modify";
            this.col_modify.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_modify.HeaderText = "Modify";
            this.col_modify.Name = "col_modify";
            this.col_modify.Text = "";
            // 
            // col_delete
            // 
            dataGridViewCellStyle2.NullValue = "Delete";
            this.col_delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_delete.HeaderText = "Delete";
            this.col_delete.Name = "col_delete";
            // 
            // Frm_class_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 398);
            this.Controls.Add(this.dgv_class_list);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(545, 437);
            this.Name = "Frm_class_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class List";
            this.Load += new System.EventHandler(this.Frm_class_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_grade;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.DataGridView dgv_class_list;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewLinkColumn col_modify;
        private System.Windows.Forms.DataGridViewLinkColumn col_delete;
        private System.Windows.Forms.Button btn_delete;
    }
}