namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranch));
            this.BT_UPDATE = new System.Windows.Forms.Button();
            this.BT_DELETE = new System.Windows.Forms.Button();
            this.BT_ADD = new System.Windows.Forms.Button();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_BRANCH_NAME = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_UPDATE
            // 
            this.BT_UPDATE.Location = new System.Drawing.Point(159, 166);
            this.BT_UPDATE.Name = "BT_UPDATE";
            this.BT_UPDATE.Size = new System.Drawing.Size(179, 47);
            this.BT_UPDATE.TabIndex = 34;
            this.BT_UPDATE.Text = "GÜNCELLE";
            this.BT_UPDATE.UseVisualStyleBackColor = true;
            this.BT_UPDATE.Click += new System.EventHandler(this.BT_UPDATE_Click);
            // 
            // BT_DELETE
            // 
            this.BT_DELETE.Location = new System.Drawing.Point(251, 113);
            this.BT_DELETE.Name = "BT_DELETE";
            this.BT_DELETE.Size = new System.Drawing.Size(87, 47);
            this.BT_DELETE.TabIndex = 33;
            this.BT_DELETE.Text = "SİL";
            this.BT_DELETE.UseVisualStyleBackColor = true;
            this.BT_DELETE.Click += new System.EventHandler(this.BT_DELETE_Click);
            // 
            // BT_ADD
            // 
            this.BT_ADD.Location = new System.Drawing.Point(158, 113);
            this.BT_ADD.Name = "BT_ADD";
            this.BT_ADD.Size = new System.Drawing.Size(87, 47);
            this.BT_ADD.TabIndex = 32;
            this.BT_ADD.Text = "EKLE";
            this.BT_ADD.UseVisualStyleBackColor = true;
            this.BT_ADD.Click += new System.EventHandler(this.BT_ADD_Click);
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(159, 27);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(179, 37);
            this.TB_ID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "BRANŞ İD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "BRANŞ ADI:";
            // 
            // TB_BRANCH_NAME
            // 
            this.TB_BRANCH_NAME.Location = new System.Drawing.Point(159, 70);
            this.TB_BRANCH_NAME.Name = "TB_BRANCH_NAME";
            this.TB_BRANCH_NAME.Size = new System.Drawing.Size(179, 37);
            this.TB_BRANCH_NAME.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(364, 236);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SpringGreen;
            this.label6.Font = new System.Drawing.Font("Nunito", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 44);
            this.label6.TabIndex = 35;
            this.label6.Text = "BRANŞ EKLE / SİL PANELİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TB_ID);
            this.panel1.Controls.Add(this.BT_UPDATE);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BT_DELETE);
            this.panel1.Controls.Add(this.TB_BRANCH_NAME);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BT_ADD);
            this.panel1.Location = new System.Drawing.Point(13, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 236);
            this.panel1.TabIndex = 36;
            // 
            // FrmBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(772, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmBranch";
            this.Text = "BRANŞ PANELİ";
            this.Load += new System.EventHandler(this.FrmBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_UPDATE;
        private System.Windows.Forms.Button BT_DELETE;
        private System.Windows.Forms.Button BT_ADD;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_BRANCH_NAME;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}