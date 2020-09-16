namespace stu_sys
{
    partial class Frm_class_modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_class_modify));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbn_cancel = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.cbo_grade = new System.Windows.Forms.ComboBox();
            this.txt_class_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbn_cancel);
            this.panel1.Controls.Add(this.btn_modify);
            this.panel1.Controls.Add(this.txt_comment);
            this.panel1.Controls.Add(this.cbo_grade);
            this.panel1.Controls.Add(this.txt_class_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 352);
            this.panel1.TabIndex = 1;
            // 
            // tbn_cancel
            // 
            this.tbn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbn_cancel.Location = new System.Drawing.Point(190, 279);
            this.tbn_cancel.Name = "tbn_cancel";
            this.tbn_cancel.Size = new System.Drawing.Size(87, 33);
            this.tbn_cancel.TabIndex = 7;
            this.tbn_cancel.Text = "Cancel";
            this.tbn_cancel.UseVisualStyleBackColor = true;
            this.tbn_cancel.Click += new System.EventHandler(this.tbn_cancel_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_modify.Location = new System.Drawing.Point(86, 279);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(87, 33);
            this.btn_modify.TabIndex = 6;
            this.btn_modify.Text = "Modify";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(86, 139);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(298, 113);
            this.txt_comment.TabIndex = 5;
            // 
            // cbo_grade
            // 
            this.cbo_grade.FormattingEnabled = true;
            this.cbo_grade.Location = new System.Drawing.Point(86, 91);
            this.cbo_grade.Name = "cbo_grade";
            this.cbo_grade.Size = new System.Drawing.Size(126, 20);
            this.cbo_grade.TabIndex = 4;
            // 
            // txt_class_name
            // 
            this.txt_class_name.Location = new System.Drawing.Point(86, 43);
            this.txt_class_name.Name = "txt_class_name";
            this.txt_class_name.Size = new System.Drawing.Size(182, 21);
            this.txt_class_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name";
            // 
            // Frm_class_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_class_modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Info Modify";
            this.Load += new System.EventHandler(this.Frm_class_modify_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbn_cancel;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.ComboBox cbo_grade;
        private System.Windows.Forms.TextBox txt_class_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}