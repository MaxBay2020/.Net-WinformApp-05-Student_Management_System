namespace stu_sys
{
    partial class Frm_modity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_modity));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
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
            this.btn_modify = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btn_cancel);
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
            this.panel1.Controls.Add(this.btn_modify);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 425);
            this.panel1.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Location = new System.Drawing.Point(204, 327);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_phone.Location = new System.Drawing.Point(115, 263);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(164, 23);
            this.txt_phone.TabIndex = 12;
            // 
            // cbo_grade_list
            // 
            this.cbo_grade_list.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_grade_list.FormattingEnabled = true;
            this.cbo_grade_list.Location = new System.Drawing.Point(115, 216);
            this.cbo_grade_list.Name = "cbo_grade_list";
            this.cbo_grade_list.Size = new System.Drawing.Size(164, 25);
            this.cbo_grade_list.TabIndex = 11;
            this.cbo_grade_list.SelectedIndexChanged += new System.EventHandler(this.cbo_grade_list_SelectedIndexChanged);
            // 
            // cbo_class_list
            // 
            this.cbo_class_list.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_class_list.FormattingEnabled = true;
            this.cbo_class_list.Location = new System.Drawing.Point(115, 167);
            this.cbo_class_list.Name = "cbo_class_list";
            this.cbo_class_list.Size = new System.Drawing.Size(164, 25);
            this.cbo_class_list.TabIndex = 10;
            this.cbo_class_list.SelectedIndexChanged += new System.EventHandler(this.cbo_class_list_SelectedIndexChanged_1);
            // 
            // r_female
            // 
            this.r_female.AutoSize = true;
            this.r_female.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_female.Location = new System.Drawing.Point(209, 128);
            this.r_female.Name = "r_female";
            this.r_female.Size = new System.Drawing.Size(67, 21);
            this.r_female.TabIndex = 9;
            this.r_female.Text = "Female";
            this.r_female.UseVisualStyleBackColor = true;
            // 
            // r_male
            // 
            this.r_male.AutoSize = true;
            this.r_male.Checked = true;
            this.r_male.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_male.Location = new System.Drawing.Point(123, 128);
            this.r_male.Name = "r_male";
            this.r_male.Size = new System.Drawing.Size(55, 21);
            this.r_male.TabIndex = 8;
            this.r_male.TabStop = true;
            this.r_male.Text = "Male";
            this.r_male.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(66, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(66, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(66, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(66, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_name.Location = new System.Drawing.Point(115, 79);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 23);
            this.txt_name.TabIndex = 3;
            // 
            // btn_modify
            // 
            this.btn_modify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_modify.Location = new System.Drawing.Point(115, 327);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 1;
            this.btn_modify.Text = "Modify";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(115, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 51);
            this.panel2.TabIndex = 15;
            // 
            // Frm_modity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 449);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_modity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info Modify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_modity_FormClosing);
            this.Load += new System.EventHandler(this.Frm_modity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
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
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}