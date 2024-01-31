namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    partial class FrmDoctorPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_UPDATE = new System.Windows.Forms.Button();
            this.BT_DELETE = new System.Windows.Forms.Button();
            this.BT_ADD = new System.Windows.Forms.Button();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.CB_BRANCH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MTB_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_SURNAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hospital_Management_SystemDataSet = new HOSPITAL_MANAGEMENT_SYSTEM.Hospital_Management_SystemDataSet();
            this.hospitalManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDOCTORSTableAdapter = new HOSPITAL_MANAGEMENT_SYSTEM.Hospital_Management_SystemDataSetTableAdapters.tDOCTORSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDOCTORSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 362);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Font = new System.Drawing.Font("Nunito", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(481, 44);
            this.label6.TabIndex = 32;
            this.label6.Text = "DOKTOR EKLE / SİL PANELİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BT_UPDATE);
            this.panel1.Controls.Add(this.BT_DELETE);
            this.panel1.Controls.Add(this.BT_ADD);
            this.panel1.Controls.Add(this.TB_NAME);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_PASSWORD);
            this.panel1.Controls.Add(this.CB_BRANCH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MTB_TC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_SURNAME);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(8, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 362);
            this.panel1.TabIndex = 33;
            // 
            // BT_UPDATE
            // 
            this.BT_UPDATE.Location = new System.Drawing.Point(112, 296);
            this.BT_UPDATE.Name = "BT_UPDATE";
            this.BT_UPDATE.Size = new System.Drawing.Size(179, 47);
            this.BT_UPDATE.TabIndex = 47;
            this.BT_UPDATE.Text = "GÜNCELLE";
            this.BT_UPDATE.UseVisualStyleBackColor = true;
            this.BT_UPDATE.Click += new System.EventHandler(this.BT_UPDATE_Click);
            // 
            // BT_DELETE
            // 
            this.BT_DELETE.Location = new System.Drawing.Point(204, 243);
            this.BT_DELETE.Name = "BT_DELETE";
            this.BT_DELETE.Size = new System.Drawing.Size(87, 47);
            this.BT_DELETE.TabIndex = 46;
            this.BT_DELETE.Text = "SİL";
            this.BT_DELETE.UseVisualStyleBackColor = true;
            this.BT_DELETE.Click += new System.EventHandler(this.BT_DELETE_Click);
            // 
            // BT_ADD
            // 
            this.BT_ADD.Location = new System.Drawing.Point(112, 243);
            this.BT_ADD.Name = "BT_ADD";
            this.BT_ADD.Size = new System.Drawing.Size(87, 47);
            this.BT_ADD.TabIndex = 45;
            this.BT_ADD.Text = "EKLE";
            this.BT_ADD.UseVisualStyleBackColor = true;
            this.BT_ADD.Click += new System.EventHandler(this.BT_ADD_Click);
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(112, 26);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(179, 37);
            this.TB_NAME.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "AD:";
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.Location = new System.Drawing.Point(112, 200);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.Size = new System.Drawing.Size(179, 37);
            this.TB_PASSWORD.TabIndex = 5;
            this.TB_PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_BRANCH
            // 
            this.CB_BRANCH.FormattingEnabled = true;
            this.CB_BRANCH.ItemHeight = 31;
            this.CB_BRANCH.Location = new System.Drawing.Point(112, 112);
            this.CB_BRANCH.Name = "CB_BRANCH";
            this.CB_BRANCH.Size = new System.Drawing.Size(179, 39);
            this.CB_BRANCH.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 43;
            this.label5.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "SOYAD:";
            // 
            // MTB_TC
            // 
            this.MTB_TC.Location = new System.Drawing.Point(112, 157);
            this.MTB_TC.Mask = "00000000000";
            this.MTB_TC.Name = "MTB_TC";
            this.MTB_TC.Size = new System.Drawing.Size(179, 37);
            this.MTB_TC.TabIndex = 4;
            this.MTB_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 39;
            this.label3.Text = "BRANŞ:";
            // 
            // TB_SURNAME
            // 
            this.TB_SURNAME.Location = new System.Drawing.Point(112, 69);
            this.TB_SURNAME.Name = "TB_SURNAME";
            this.TB_SURNAME.Size = new System.Drawing.Size(179, 37);
            this.TB_SURNAME.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 31);
            this.label4.TabIndex = 40;
            this.label4.Text = "T.C.:";
            // 
            // hospital_Management_SystemDataSet
            // 
            this.hospital_Management_SystemDataSet.DataSetName = "Hospital_Management_SystemDataSet";
            this.hospital_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalManagementSystemDataSetBindingSource
            // 
            this.hospitalManagementSystemDataSetBindingSource.DataSource = this.hospital_Management_SystemDataSet;
            this.hospitalManagementSystemDataSetBindingSource.Position = 0;
            // 
            // tDOCTORSBindingSource
            // 
            this.tDOCTORSBindingSource.DataMember = "tDOCTORS";
            this.tDOCTORSBindingSource.DataSource = this.hospitalManagementSystemDataSetBindingSource;
            // 
            // tDOCTORSTableAdapter
            // 
            this.tDOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1194, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorPanel";
            this.Text = "DOKTOR PANELİ";
            this.Load += new System.EventHandler(this.FrmDoctorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDOCTORSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_UPDATE;
        private System.Windows.Forms.Button BT_DELETE;
        private System.Windows.Forms.Button BT_ADD;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PASSWORD;
        private System.Windows.Forms.ComboBox CB_BRANCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTB_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_SURNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource hospitalManagementSystemDataSetBindingSource;
        private Hospital_Management_SystemDataSet hospital_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource tDOCTORSBindingSource;
        private Hospital_Management_SystemDataSetTableAdapters.tDOCTORSTableAdapter tDOCTORSTableAdapter;
    }
}