namespace CoToan
{
    partial class FormLuaChonCheDoChoi
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
            this.btBatDau = new System.Windows.Forms.Button();
            this.txtNguoiChoi1 = new System.Windows.Forms.TextBox();
            this.txtNguoiChoi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInternetMode = new System.Windows.Forms.RadioButton();
            this.rbLanMode = new System.Windows.Forms.RadioButton();
            this.rb1PCMode = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBatDau
            // 
            this.btBatDau.Location = new System.Drawing.Point(537, 209);
            this.btBatDau.Name = "btBatDau";
            this.btBatDau.Size = new System.Drawing.Size(174, 47);
            this.btBatDau.TabIndex = 2;
            this.btBatDau.Text = "Bắt Đầu";
            this.btBatDau.UseVisualStyleBackColor = true;
            this.btBatDau.Click += new System.EventHandler(this.btStart_Click);
            // 
            // txtNguoiChoi1
            // 
            this.txtNguoiChoi1.Location = new System.Drawing.Point(200, 36);
            this.txtNguoiChoi1.MaxLength = 10;
            this.txtNguoiChoi1.Name = "txtNguoiChoi1";
            this.txtNguoiChoi1.Size = new System.Drawing.Size(180, 20);
            this.txtNguoiChoi1.TabIndex = 3;
            // 
            // txtNguoiChoi2
            // 
            this.txtNguoiChoi2.Location = new System.Drawing.Point(200, 80);
            this.txtNguoiChoi2.MaxLength = 10;
            this.txtNguoiChoi2.Name = "txtNguoiChoi2";
            this.txtNguoiChoi2.Size = new System.Drawing.Size(180, 20);
            this.txtNguoiChoi2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Người Chơi 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Người Chơi 2 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInternetMode);
            this.groupBox1.Controls.Add(this.rbLanMode);
            this.groupBox1.Controls.Add(this.rb1PCMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ chơi :";
            // 
            // rbInternetMode
            // 
            this.rbInternetMode.AutoSize = true;
            this.rbInternetMode.Location = new System.Drawing.Point(26, 140);
            this.rbInternetMode.Name = "rbInternetMode";
            this.rbInternetMode.Size = new System.Drawing.Size(97, 17);
            this.rbInternetMode.TabIndex = 2;
            this.rbInternetMode.Text = "Kết nối Internet";
            this.rbInternetMode.UseVisualStyleBackColor = true;
            // 
            // rbLanMode
            // 
            this.rbLanMode.AutoSize = true;
            this.rbLanMode.Location = new System.Drawing.Point(26, 87);
            this.rbLanMode.Name = "rbLanMode";
            this.rbLanMode.Size = new System.Drawing.Size(108, 17);
            this.rbLanMode.TabIndex = 1;
            this.rbLanMode.Text = "Kết nối mạng Lan";
            this.rbLanMode.UseVisualStyleBackColor = true;
            // 
            // rb1PCMode
            // 
            this.rb1PCMode.AutoSize = true;
            this.rb1PCMode.Checked = true;
            this.rb1PCMode.Location = new System.Drawing.Point(26, 39);
            this.rb1PCMode.Name = "rb1PCMode";
            this.rb1PCMode.Size = new System.Drawing.Size(98, 17);
            this.rb1PCMode.TabIndex = 0;
            this.rb1PCMode.TabStop = true;
            this.rb1PCMode.Text = "Chơi trên 1 máy";
            this.rb1PCMode.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNguoiChoi1);
            this.groupBox2.Controls.Add(this.txtNguoiChoi2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 181);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Ván Cờ:";
            // 
            // FormLuaChonCheDoChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBatDau);
            this.Name = "FormLuaChonCheDoChoi";
            this.Text = "FormLuaChonCheDoChoi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBatDau;
        private System.Windows.Forms.TextBox txtNguoiChoi1;
        private System.Windows.Forms.TextBox txtNguoiChoi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbInternetMode;
        private System.Windows.Forms.RadioButton rbLanMode;
        private System.Windows.Forms.RadioButton rb1PCMode;
    }
}