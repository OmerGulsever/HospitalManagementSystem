namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.BT_PATIENTS = new System.Windows.Forms.Button();
            this.BT_DOCTOR = new System.Windows.Forms.Button();
            this.BT_SECRETARY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_PATIENTS
            // 
            this.BT_PATIENTS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_PATIENTS.BackgroundImage")));
            this.BT_PATIENTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_PATIENTS.Location = new System.Drawing.Point(23, 136);
            this.BT_PATIENTS.Name = "BT_PATIENTS";
            this.BT_PATIENTS.Size = new System.Drawing.Size(247, 232);
            this.BT_PATIENTS.TabIndex = 0;
            this.BT_PATIENTS.UseVisualStyleBackColor = true;
            this.BT_PATIENTS.Click += new System.EventHandler(this.BT_PATIENTS_Click);
            // 
            // BT_DOCTOR
            // 
            this.BT_DOCTOR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_DOCTOR.BackgroundImage")));
            this.BT_DOCTOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_DOCTOR.Location = new System.Drawing.Point(276, 136);
            this.BT_DOCTOR.Name = "BT_DOCTOR";
            this.BT_DOCTOR.Size = new System.Drawing.Size(247, 232);
            this.BT_DOCTOR.TabIndex = 1;
            this.BT_DOCTOR.UseVisualStyleBackColor = true;
            this.BT_DOCTOR.Click += new System.EventHandler(this.BT_DOCTOR_Click);
            // 
            // BT_SECRETARY
            // 
            this.BT_SECRETARY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_SECRETARY.BackgroundImage")));
            this.BT_SECRETARY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_SECRETARY.Location = new System.Drawing.Point(529, 136);
            this.BT_SECRETARY.Name = "BT_SECRETARY";
            this.BT_SECRETARY.Size = new System.Drawing.Size(247, 232);
            this.BT_SECRETARY.TabIndex = 2;
            this.BT_SECRETARY.UseVisualStyleBackColor = true;
            this.BT_SECRETARY.Click += new System.EventHandler(this.BT_SECRETARY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 79);
            this.label4.TabIndex = 6;
            this.label4.Text = "MY HOSPITAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(570, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(799, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_SECRETARY);
            this.Controls.Add(this.BT_DOCTOR);
            this.Controls.Add(this.BT_PATIENTS);
            this.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmLogins";
            this.Text = "WELCOME to MY HOSPITAL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_PATIENTS;
        private System.Windows.Forms.Button BT_DOCTOR;
        private System.Windows.Forms.Button BT_SECRETARY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

