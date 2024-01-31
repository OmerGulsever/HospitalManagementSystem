namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmPatientsLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientsLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_login = new System.Windows.Forms.Button();
            this.mTb_TC = new System.Windows.Forms.MaskedTextBox();
            this.Tb_PASS = new System.Windows.Forms.TextBox();
            this.Llb_Uyeol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİS PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. KİMLİK NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE:";
            // 
            // B_login
            // 
            this.B_login.Location = new System.Drawing.Point(275, 202);
            this.B_login.Name = "B_login";
            this.B_login.Size = new System.Drawing.Size(146, 41);
            this.B_login.TabIndex = 3;
            this.B_login.Text = "GİRİŞ YAP";
            this.B_login.UseVisualStyleBackColor = true;
            this.B_login.Click += new System.EventHandler(this.B_login_Click);
            // 
            // mTb_TC
            // 
            this.mTb_TC.Location = new System.Drawing.Point(275, 106);
            this.mTb_TC.Mask = "00000000000";
            this.mTb_TC.Name = "mTb_TC";
            this.mTb_TC.Size = new System.Drawing.Size(146, 34);
            this.mTb_TC.TabIndex = 4;
            this.mTb_TC.ValidatingType = typeof(int);
            // 
            // Tb_PASS
            // 
            this.Tb_PASS.Location = new System.Drawing.Point(275, 152);
            this.Tb_PASS.Name = "Tb_PASS";
            this.Tb_PASS.Size = new System.Drawing.Size(146, 34);
            this.Tb_PASS.TabIndex = 5;
            this.Tb_PASS.UseSystemPasswordChar = true;
            // 
            // Llb_Uyeol
            // 
            this.Llb_Uyeol.AutoSize = true;
            this.Llb_Uyeol.LinkColor = System.Drawing.Color.White;
            this.Llb_Uyeol.Location = new System.Drawing.Point(188, 209);
            this.Llb_Uyeol.Name = "Llb_Uyeol";
            this.Llb_Uyeol.Size = new System.Drawing.Size(81, 27);
            this.Llb_Uyeol.TabIndex = 6;
            this.Llb_Uyeol.TabStop = true;
            this.Llb_Uyeol.Text = "Üye Ol";
            this.Llb_Uyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llb_Uyeol_LinkClicked);
            // 
            // FrmPatientsLogin
            // 
            this.AcceptButton = this.B_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(534, 307);
            this.Controls.Add(this.Llb_Uyeol);
            this.Controls.Add(this.Tb_PASS);
            this.Controls.Add(this.mTb_TC);
            this.Controls.Add(this.B_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientsLogin";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_login;
        private System.Windows.Forms.MaskedTextBox mTb_TC;
        private System.Windows.Forms.TextBox Tb_PASS;
        private System.Windows.Forms.LinkLabel Llb_Uyeol;
    }
}