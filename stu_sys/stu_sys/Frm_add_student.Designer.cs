namespace stu_sys
{
    partial class Frm_add_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_add_student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.cbo_grade_list = new System.Windows.Forms.ComboBox();
            this.cbo_class_list = new System.Windows.Forms.ComboBox();
            this.r_female = new System.Windows.Forms.RadioButton();
            this.r_male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.cbo_grade_list);
            this.panel1.Controls.Add(this.cbo_class_list);
            this.panel1.Controls.Add(this.r_female);
            this.panel1.Controls.Add(this.r_male);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 850);
            this.panel1.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.Location = new System.Drawing.Point(408, 654);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(150, 46);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_phone.Location = new System.Drawing.Point(230, 526);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(324, 39);
            this.txt_phone.TabIndex = 12;
            // 
            // cbo_grade_list
            // 
            this.cbo_grade_list.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_grade_list.FormattingEnabled = true;
            this.cbo_grade_list.Location = new System.Drawing.Point(230, 432);
            this.cbo_grade_list.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbo_grade_list.Name = "cbo_grade_list";
            this.cbo_grade_list.Size = new System.Drawing.Size(324, 39);
            this.cbo_grade_list.TabIndex = 11;
            this.cbo_grade_list.SelectedIndexChanged += new System.EventHandler(this.cbo_grade_list_SelectedIndexChanged);
            // 
            // cbo_class_list
            // 
            this.cbo_class_list.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_class_list.FormattingEnabled = true;
            this.cbo_class_list.Location = new System.Drawing.Point(230, 334);
            this.cbo_class_list.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbo_class_list.Name = "cbo_class_list";
            this.cbo_class_list.Size = new System.Drawing.Size(324, 39);
            this.cbo_class_list.TabIndex = 10;
            this.cbo_class_list.SelectedIndexChanged += new System.EventHandler(this.cbo_class_list_SelectedIndexChanged);
            // 
            // r_female
            // 
            this.r_female.AutoSize = true;
            this.r_female.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_female.Location = new System.Drawing.Point(418, 256);
            this.r_female.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.r_female.Name = "r_female";
            this.r_female.Size = new System.Drawing.Size(127, 35);
            this.r_female.TabIndex = 9;
            this.r_female.Text = "Female";
            this.r_female.UseVisualStyleBackColor = true;
            // 
            // r_male
            // 
            this.r_male.AutoSize = true;
            this.r_male.Checked = true;
            this.r_male.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_male.Location = new System.Drawing.Point(246, 256);
            this.r_male.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.r_male.Name = "r_male";
            this.r_male.Size = new System.Drawing.Size(101, 35);
            this.r_male.TabIndex = 8;
            this.r_male.TabStop = true;
            this.r_male.Text = "Male";
            this.r_male.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(132, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(132, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(132, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(132, 532);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_name.Location = new System.Drawing.Point(230, 158);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(324, 39);
            this.txt_name.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(230, 654);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(132, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(230, 220);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 102);
            this.panel2.TabIndex = 15;
            // 
            // Frm_add_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 898);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_add_student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.Frm_add_student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.ComboBox cbo_grade_list;
        private System.Windows.Forms.ComboBox cbo_class_list;
        private System.Windows.Forms.RadioButton r_female;
        private System.Windows.Forms.RadioButton r_male;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel2;
    }
}