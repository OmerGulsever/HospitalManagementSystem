namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmDoctorBilgiUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorBilgiUpdate));
            this.Bt_Update = new System.Windows.Forms.Button();
            this.tB_PASS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mtb_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_BRANCH = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(121, 226);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(156, 51);
            this.Bt_Update.TabIndex = 45;
            this.Bt_Update.Text = "GÜNCELLE";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // tB_PASS
            // 
            this.tB_PASS.Location = new System.Drawing.Point(121, 188);
            this.tB_PASS.Name = "tB_PASS";
            this.tB_PASS.Size = new System.Drawing.Size(156, 32);
            this.tB_PASS.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "ŞİFRE:";
            // 
            // tB_Surname
            // 
            this.tB_Surname.Location = new System.Drawing.Point(121, 74);
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(156, 32);
            this.tB_Surname.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "SOYAD:";
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(121, 36);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(156, 32);
            this.Tb_Name.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "AD:";
            // 
            // Mtb_TC
            // 
            this.Mtb_TC.Location = new System.Drawing.Point(121, 150);
            this.Mtb_TC.Mask = "00000000000";
            this.Mtb_TC.Name = "Mtb_TC";
            this.Mtb_TC.Size = new System.Drawing.Size(156, 32);
            this.Mtb_TC.TabIndex = 35;
            this.Mtb_TC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "BRANŞ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "T.C.:";
            // 
            // CB_BRANCH
            // 
            this.CB_BRANCH.FormattingEnabled = true;
            this.CB_BRANCH.Location = new System.Drawing.Point(121, 112);
            this.CB_BRANCH.Name = "CB_BRANCH";
            this.CB_BRANCH.Size = new System.Drawing.Size(156, 32);
            this.CB_BRANCH.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 51);
            this.button1.TabIndex = 47;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDoctorBilgiUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(355, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_BRANCH);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.tB_PASS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_Surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mtb_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorBilgiUpdate";
            this.Text = "DOKTOR BİLGİLERİNİ GÜNCELLE";
            this.Load += new System.EventHandler(this.FrmDoctorBilgiUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.TextBox tB_PASS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Mtb_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_BRANCH;
        private System.Windows.Forms.Button button1;
    }
}