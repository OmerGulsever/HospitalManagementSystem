namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmPatientsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientsDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LNK_BILGIDUZENLE = new System.Windows.Forms.LinkLabel();
            this.LB_KISI_ISIM = new System.Windows.Forms.Label();
            this.LB_KISI_TC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.BT_RANDEVU = new System.Windows.Forms.Button();
            this.RTB_SIKAYET = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_DOCTOR = new System.Windows.Forms.ComboBox();
            this.CB_BRANCH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.LNK_BILGIDUZENLE);
            this.groupBox1.Controls.Add(this.LB_KISI_ISIM);
            this.groupBox1.Controls.Add(this.LB_KISI_TC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİ BİLGİLERİ";
            // 
            // LNK_BILGIDUZENLE
            // 
            this.LNK_BILGIDUZENLE.AutoSize = true;
            this.LNK_BILGIDUZENLE.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNK_BILGIDUZENLE.Location = new System.Drawing.Point(27, 112);
            this.LNK_BILGIDUZENLE.Name = "LNK_BILGIDUZENLE";
            this.LNK_BILGIDUZENLE.Size = new System.Drawing.Size(178, 20);
            this.LNK_BILGIDUZENLE.TabIndex = 6;
            this.LNK_BILGIDUZENLE.TabStop = true;
            this.LNK_BILGIDUZENLE.Text = "BİLGİLERİMİ GÜNCELLE";
            this.LNK_BILGIDUZENLE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_BILGIDUZENLE_LinkClicked);
            // 
            // LB_KISI_ISIM
            // 
            this.LB_KISI_ISIM.AutoSize = true;
            this.LB_KISI_ISIM.Location = new System.Drawing.Point(93, 67);
            this.LB_KISI_ISIM.Name = "LB_KISI_ISIM";
            this.LB_KISI_ISIM.Size = new System.Drawing.Size(122, 27);
            this.LB_KISI_ISIM.TabIndex = 5;
            this.LB_KISI_ISIM.Text = "NULL NULL";
            // 
            // LB_KISI_TC
            // 
            this.LB_KISI_TC.AutoSize = true;
            this.LB_KISI_TC.Location = new System.Drawing.Point(88, 40);
            this.LB_KISI_TC.Name = "LB_KISI_TC";
            this.LB_KISI_TC.Size = new System.Drawing.Size(144, 27);
            this.LB_KISI_TC.TabIndex = 4;
            this.LB_KISI_TC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "İSİM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "T.C.:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_ID);
            this.groupBox2.Controls.Add(this.BT_RANDEVU);
            this.groupBox2.Controls.Add(this.RTB_SIKAYET);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CB_DOCTOR);
            this.groupBox2.Controls.Add(this.CB_BRANCH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANDEVU AL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID:";
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(119, 32);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(178, 33);
            this.TB_ID.TabIndex = 9;
            // 
            // BT_RANDEVU
            // 
            this.BT_RANDEVU.Location = new System.Drawing.Point(119, 255);
            this.BT_RANDEVU.Name = "BT_RANDEVU";
            this.BT_RANDEVU.Size = new System.Drawing.Size(178, 45);
            this.BT_RANDEVU.TabIndex = 8;
            this.BT_RANDEVU.Text = "RANDEVU AL";
            this.BT_RANDEVU.UseVisualStyleBackColor = true;
            this.BT_RANDEVU.Click += new System.EventHandler(this.BT_RANDEVU_Click);
            // 
            // RTB_SIKAYET
            // 
            this.RTB_SIKAYET.Location = new System.Drawing.Point(119, 153);
            this.RTB_SIKAYET.Name = "RTB_SIKAYET";
            this.RTB_SIKAYET.Size = new System.Drawing.Size(178, 96);
            this.RTB_SIKAYET.TabIndex = 7;
            this.RTB_SIKAYET.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "ŞİKAYET:";
            // 
            // CB_DOCTOR
            // 
            this.CB_DOCTOR.FormattingEnabled = true;
            this.CB_DOCTOR.Location = new System.Drawing.Point(119, 112);
            this.CB_DOCTOR.Name = "CB_DOCTOR";
            this.CB_DOCTOR.Size = new System.Drawing.Size(178, 35);
            this.CB_DOCTOR.TabIndex = 5;
            this.CB_DOCTOR.SelectedIndexChanged += new System.EventHandler(this.CB_DOCTOR_SelectedIndexChanged);
            // 
            // CB_BRANCH
            // 
            this.CB_BRANCH.FormattingEnabled = true;
            this.CB_BRANCH.Location = new System.Drawing.Point(119, 71);
            this.CB_BRANCH.Name = "CB_BRANCH";
            this.CB_BRANCH.Size = new System.Drawing.Size(178, 35);
            this.CB_BRANCH.TabIndex = 4;
            this.CB_BRANCH.SelectedIndexChanged += new System.EventHandler(this.CB_BRANCH_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "DOKTOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "POLİKLİNİK:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(374, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 202);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GEÇMİŞ RANDEVULAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(371, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 274);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AKTİF RANDEVULAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(783, 242);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // FrmPatientsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1194, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientsDetail";
            this.Text = "HASTA PANELİ";
            this.Load += new System.EventHandler(this.FrmPatientsDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_KISI_ISIM;
        private System.Windows.Forms.Label LB_KISI_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_RANDEVU;
        private System.Windows.Forms.RichTextBox RTB_SIKAYET;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_DOCTOR;
        private System.Windows.Forms.ComboBox CB_BRANCH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LNK_BILGIDUZENLE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_ID;
    }
}