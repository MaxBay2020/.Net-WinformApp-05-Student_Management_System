namespace stu_sys
{
    partial class Frm_student_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_student_list));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cbo_grade_list = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_sName = new System.Windows.Forms.TextBox();
            this.cbo_class_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.col_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mod = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_del = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.cbo_grade_list);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.txt_sName);
            this.groupBox1.Controls.Add(this.cbo_class_list);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_delete.Location = new System.Drawing.Point(866, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_reset.Location = new System.Drawing.Point(759, 30);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cbo_grade_list
            // 
            this.cbo_grade_list.FormattingEnabled = true;
            this.cbo_grade_list.Location = new System.Drawing.Point(498, 32);
            this.cbo_grade_list.Name = "cbo_grade_list";
            this.cbo_grade_list.Size = new System.Drawing.Size(131, 20);
            this.cbo_grade_list.TabIndex = 6;
            this.cbo_grade_list.SelectedIndexChanged += new System.EventHandler(this.cbo_grade_list_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(448, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade";
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_find.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_find.Location = new System.Drawing.Point(657, 30);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_sName
            // 
            this.txt_sName.Location = new System.Drawing.Point(107, 32);
            this.txt_sName.Name = "txt_sName";
            this.txt_sName.Size = new System.Drawing.Size(116, 21);
            this.txt_sName.TabIndex = 1;
            // 
            // cbo_class_list
            // 
            this.cbo_class_list.FormattingEnabled = true;
            this.cbo_class_list.Location = new System.Drawing.Point(285, 32);
            this.cbo_class_list.Name = "cbo_class_list";
            this.cbo_class_list.Size = new System.Drawing.Size(132, 20);
            this.cbo_class_list.TabIndex = 3;
            this.cbo_class_list.SelectedIndexChanged += new System.EventHandler(this.cbo_class_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(241, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // dgv_student
            // 
            this.dgv_student.AllowUserToAddRows = false;
            this.dgv_student.AllowUserToDeleteRows = false;
            this.dgv_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_check,
            this.sId,
            this.sName,
            this.sGender,
            this.sClass,
            this.sGrade,
            this.sPhone,
            this.createTime,
            this.col_mod,
            this.col_del});
            this.dgv_student.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_student.Location = new System.Drawing.Point(0, 94);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowHeadersVisible = false;
            this.dgv_student.RowHeadersWidth = 82;
            this.dgv_student.RowTemplate.Height = 23;
            this.dgv_student.Size = new System.Drawing.Size(990, 267);
            this.dgv_student.TabIndex = 1;
            this.dgv_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_student_CellContentClick);
            // 
            // col_check
            // 
            this.col_check.HeaderText = "Select";
            this.col_check.Name = "col_check";
            // 
            // sId
            // 
            this.sId.DataPropertyName = "sId";
            this.sId.HeaderText = "Student ID";
            this.sId.MinimumWidth = 10;
            this.sId.Name = "sId";
            this.sId.ReadOnly = true;
            // 
            // sName
            // 
            this.sName.DataPropertyName = "sName";
            this.sName.HeaderText = "Name";
            this.sName.MinimumWidth = 10;
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
            // 
            // sGender
            // 
            this.sGender.DataPropertyName = "sGender";
            this.sGender.HeaderText = "Gender";
            this.sGender.MinimumWidth = 10;
            this.sGender.Name = "sGender";
            this.sGender.ReadOnly = true;
            // 
            // sClass
            // 
            this.sClass.DataPropertyName = "cName";
            this.sClass.HeaderText = "Class";
            this.sClass.MinimumWidth = 10;
            this.sClass.Name = "sClass";
            this.sClass.ReadOnly = true;
            // 
            // sGrade
            // 
            this.sGrade.DataPropertyName = "gName";
            this.sGrade.HeaderText = "Grade";
            this.sGrade.MinimumWidth = 10;
            this.sGrade.Name = "sGrade";
            this.sGrade.ReadOnly = true;
            // 
            // sPhone
            // 
            this.sPhone.DataPropertyName = "sPhone";
            this.sPhone.HeaderText = "Phone";
            this.sPhone.MinimumWidth = 10;
            this.sPhone.Name = "sPhone";
            this.sPhone.ReadOnly = true;
            // 
            // createTime
            // 
            this.createTime.DataPropertyName = "createTime";
            this.createTime.HeaderText = "Created Time";
            this.createTime.MinimumWidth = 10;
            this.createTime.Name = "createTime";
            this.createTime.ReadOnly = true;
            // 
            // col_mod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.NullValue = "Modify";
            this.col_mod.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_mod.HeaderText = "Modify";
            this.col_mod.Name = "col_mod";
            // 
            // col_del
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "Delete";
            this.col_del.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_del.HeaderText = "Delete";
            this.col_del.Name = "col_del";
            // 
            // Frm_student_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 361);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_student_list";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.Frm_student_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_class_list;
        private System.Windows.Forms.TextBox txt_sName;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.ComboBox cbo_grade_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
        private System.Windows.Forms.DataGridViewLinkColumn col_mod;
        private System.Windows.Forms.DataGridViewLinkColumn col_del;
        private System.Windows.Forms.Button btn_delete;
    }
}