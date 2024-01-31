namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmDoctorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorLogin));
            this.Tb_PASS = new System.Windows.Forms.TextBox();
            this.mTb_TC = new System.Windows.Forms.MaskedTextBox();
            this.B_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tb_PASS
            // 
            this.Tb_PASS.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_PASS.Location = new System.Drawing.Point(206, 122);
            this.Tb_PASS.Name = "Tb_PASS";
            this.Tb_PASS.Size = new System.Drawing.Size(146, 34);
            this.Tb_PASS.TabIndex = 2;
            this.Tb_PASS.Text = "2222";
            this.Tb_PASS.UseSystemPasswordChar = true;
            // 
            // mTb_TC
            // 
            this.mTb_TC.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTb_TC.Location = new System.Drawing.Point(206, 82);
            this.mTb_TC.Mask = "00000000000";
            this.mTb_TC.Name = "mTb_TC";
            this.mTb_TC.Size = new System.Drawing.Size(146, 34);
            this.mTb_TC.TabIndex = 1;
            this.mTb_TC.Text = "11111111110";
            this.mTb_TC.ValidatingType = typeof(int);
            // 
            // B_login
            // 
            this.B_login.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_login.Location = new System.Drawing.Point(206, 162);
            this.B_login.Name = "B_login";
            this.B_login.Size = new System.Drawing.Size(146, 41);
            this.B_login.TabIndex = 3;
            this.B_login.Text = "GİRİŞ YAP";
            this.B_login.UseVisualStyleBackColor = true;
            this.B_login.Click += new System.EventHandler(this.B_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C. KİMLİK NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOKTOR GİRİS PANELİ";
            // 
            // FrmDoctorLogin
            // 
            this.AcceptButton = this.B_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(395, 243);
            this.Controls.Add(this.Tb_PASS);
            this.Controls.Add(this.mTb_TC);
            this.Controls.Add(this.B_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorLogin";
            this.Text = "DOKTOR GİRİŞİ";
            this.Load += new System.EventHandler(this.FrmDoctorLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_PASS;
        private System.Windows.Forms.MaskedTextBox mTb_TC;
        private System.Windows.Forms.Button B_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}