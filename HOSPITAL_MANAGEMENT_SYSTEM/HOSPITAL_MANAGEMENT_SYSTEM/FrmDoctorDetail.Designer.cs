namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmDoctorDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_KISI_ISIM = new System.Windows.Forms.Label();
            this.LB_KISI_TC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rtb_SIKAYET = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Bt_exit = new System.Windows.Forms.Button();
            this.Bt_duyuru = new System.Windows.Forms.Button();
            this.Bt_update = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LB_HASTAISIM = new System.Windows.Forms.Label();
            this.LB_HASTATC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.LB_KISI_ISIM);
            this.groupBox1.Controls.Add(this.LB_KISI_TC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOKTOR BİLGİLERİ";
            // 
            // LB_KISI_ISIM
            // 
            this.LB_KISI_ISIM.AutoSize = true;
            this.LB_KISI_ISIM.Location = new System.Drawing.Point(93, 69);
            this.LB_KISI_ISIM.Name = "LB_KISI_ISIM";
            this.LB_KISI_ISIM.Size = new System.Drawing.Size(131, 27);
            this.LB_KISI_ISIM.TabIndex = 9;
            this.LB_KISI_ISIM.Text = "NULL NULL";
            // 
            // LB_KISI_TC
            // 
            this.LB_KISI_TC.AutoSize = true;
            this.LB_KISI_TC.Location = new System.Drawing.Point(88, 42);
            this.LB_KISI_TC.Name = "LB_KISI_TC";
            this.LB_KISI_TC.Size = new System.Drawing.Size(155, 27);
            this.LB_KISI_TC.TabIndex = 8;
            this.LB_KISI_TC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "İSİM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "T.C.:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.Rtb_SIKAYET);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANDEVU DETAY";
            // 
            // Rtb_SIKAYET
            // 
            this.Rtb_SIKAYET.Location = new System.Drawing.Point(6, 60);
            this.Rtb_SIKAYET.Name = "Rtb_SIKAYET";
            this.Rtb_SIKAYET.Size = new System.Drawing.Size(359, 230);
            this.Rtb_SIKAYET.TabIndex = 11;
            this.Rtb_SIKAYET.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "ŞİKAYET:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Khaki;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(420, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 454);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Khaki;
            this.groupBox4.Controls.Add(this.Bt_exit);
            this.groupBox4.Controls.Add(this.Bt_duyuru);
            this.groupBox4.Controls.Add(this.Bt_update);
            this.groupBox4.Location = new System.Drawing.Point(420, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(836, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HIZLI ERİŞİM";
            // 
            // Bt_exit
            // 
            this.Bt_exit.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_exit.Location = new System.Drawing.Point(557, 32);
            this.Bt_exit.Name = "Bt_exit";
            this.Bt_exit.Size = new System.Drawing.Size(273, 60);
            this.Bt_exit.TabIndex = 3;
            this.Bt_exit.Text = "ÇIKIŞ";
            this.Bt_exit.UseVisualStyleBackColor = true;
            this.Bt_exit.Click += new System.EventHandler(this.Bt_exit_Click);
            // 
            // Bt_duyuru
            // 
            this.Bt_duyuru.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_duyuru.Location = new System.Drawing.Point(297, 32);
            this.Bt_duyuru.Name = "Bt_duyuru";
            this.Bt_duyuru.Size = new System.Drawing.Size(240, 60);
            this.Bt_duyuru.TabIndex = 1;
            this.Bt_duyuru.Text = "DUYURULAR";
            this.Bt_duyuru.UseVisualStyleBackColor = true;
            this.Bt_duyuru.Click += new System.EventHandler(this.Bt_duyuru_Click);
            // 
            // Bt_update
            // 
            this.Bt_update.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_update.Location = new System.Drawing.Point(6, 33);
            this.Bt_update.Name = "Bt_update";
            this.Bt_update.Size = new System.Drawing.Size(266, 60);
            this.Bt_update.TabIndex = 0;
            this.Bt_update.Text = "BİLGİ DÜZENLE";
            this.Bt_update.UseVisualStyleBackColor = true;
            this.Bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Khaki;
            this.groupBox5.Controls.Add(this.LB_HASTAISIM);
            this.groupBox5.Controls.Add(this.LB_HASTATC);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 125);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HASTA BİLGİLERİ";
            // 
            // LB_HASTAISIM
            // 
            this.LB_HASTAISIM.AutoSize = true;
            this.LB_HASTAISIM.Location = new System.Drawing.Point(93, 69);
            this.LB_HASTAISIM.Name = "LB_HASTAISIM";
            this.LB_HASTAISIM.Size = new System.Drawing.Size(131, 27);
            this.LB_HASTAISIM.TabIndex = 9;
            this.LB_HASTAISIM.Text = "NULL NULL";
            // 
            // LB_HASTATC
            // 
            this.LB_HASTATC.AutoSize = true;
            this.LB_HASTATC.Location = new System.Drawing.Point(88, 42);
            this.LB_HASTATC.Name = "LB_HASTATC";
            this.LB_HASTATC.Size = new System.Drawing.Size(155, 27);
            this.LB_HASTATC.TabIndex = 8;
            this.LB_HASTATC.Text = "00000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "İSİM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "T.C.:";
            // 
            // FrmDoctorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1283, 618);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorDetail";
            this.Text = "DOCTOR DETAY PANELi";
            this.Load += new System.EventHandler(this.FrmDoctorDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_KISI_ISIM;
        private System.Windows.Forms.Label LB_KISI_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox Rtb_SIKAYET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Bt_exit;
        private System.Windows.Forms.Button Bt_duyuru;
        private System.Windows.Forms.Button Bt_update;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LB_HASTAISIM;
        private System.Windows.Forms.Label LB_HASTATC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}