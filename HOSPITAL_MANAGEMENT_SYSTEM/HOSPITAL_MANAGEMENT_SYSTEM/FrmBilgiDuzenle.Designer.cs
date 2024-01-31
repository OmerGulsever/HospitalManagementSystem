namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.Bt_Update = new System.Windows.Forms.Button();
            this.cB_GENDER = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Mtb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.tB_PASS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mtb_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(152, 283);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(156, 51);
            this.Bt_Update.TabIndex = 32;
            this.Bt_Update.Text = "GÜNCELLE";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // cB_GENDER
            // 
            this.cB_GENDER.FormattingEnabled = true;
            this.cB_GENDER.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cB_GENDER.Location = new System.Drawing.Point(152, 241);
            this.cB_GENDER.Name = "cB_GENDER";
            this.cB_GENDER.Size = new System.Drawing.Size(156, 32);
            this.cB_GENDER.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "CİNSİYET:";
            // 
            // Mtb_Phone
            // 
            this.Mtb_Phone.Location = new System.Drawing.Point(152, 157);
            this.Mtb_Phone.Mask = "(999) 000-0000";
            this.Mtb_Phone.Name = "Mtb_Phone";
            this.Mtb_Phone.Size = new System.Drawing.Size(156, 32);
            this.Mtb_Phone.TabIndex = 4;
            // 
            // tB_PASS
            // 
            this.tB_PASS.Location = new System.Drawing.Point(152, 199);
            this.tB_PASS.Name = "tB_PASS";
            this.tB_PASS.Size = new System.Drawing.Size(156, 32);
            this.tB_PASS.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "ŞİFRE:";
            // 
            // tB_Surname
            // 
            this.tB_Surname.Location = new System.Drawing.Point(152, 73);
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(156, 32);
            this.tB_Surname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "SOYAD:";
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(152, 31);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(156, 32);
            this.Tb_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "AD:";
            // 
            // Mtb_TC
            // 
            this.Mtb_TC.Location = new System.Drawing.Point(152, 115);
            this.Mtb_TC.Mask = "00000000000";
            this.Mtb_TC.Name = "Mtb_TC";
            this.Mtb_TC.Size = new System.Drawing.Size(156, 32);
            this.Mtb_TC.TabIndex = 3;
            this.Mtb_TC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "TEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "T.C.:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.Bt_Update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(417, 386);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.cB_GENDER);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mtb_Phone);
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
            this.Name = "FrmBilgiDuzenle";
            this.Text = " Hasta Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.ComboBox cB_GENDER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Mtb_Phone;
        private System.Windows.Forms.TextBox tB_PASS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Mtb_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}