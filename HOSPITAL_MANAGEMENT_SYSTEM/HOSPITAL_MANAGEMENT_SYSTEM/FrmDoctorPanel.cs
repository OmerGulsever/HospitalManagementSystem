using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        We_Will_Connection bgl=new We_Will_Connection();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospital_Management_SystemDataSet.tDOCTORS' table. You can move, or remove it, as needed.
            this.tDOCTORSTableAdapter.Fill(this.hospital_Management_SystemDataSet.tDOCTORS);
            DataTable dt = new DataTable();
            SqlDataAdapter da1= new SqlDataAdapter("select * from tDOCTORS", bgl.baglanti());
            da1.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşlar
            SqlCommand cmdbr = new SqlCommand("Select NAME from tBRANCHES", bgl.baglanti());
            SqlDataReader dr2 = cmdbr.ExecuteReader();
            while (dr2.Read())
            {
                CB_BRANCH.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void BT_ADD_Click(object sender, EventArgs e)
        {
            SqlCommand cmdadd = new SqlCommand("insert into tDOCTORS (NAME,SURNAME,BRANCH,TC,PASSWORD) values (@name,@surname,@branch,@tc,@pass)",bgl.baglanti());
            cmdadd.Parameters.AddWithValue("@name",TB_NAME.Text);
            cmdadd.Parameters.AddWithValue("@surname",TB_SURNAME.Text);
            cmdadd.Parameters.AddWithValue("@branch",CB_BRANCH.Text);
            cmdadd.Parameters.AddWithValue("@tc",MTB_TC.Text);
            cmdadd.Parameters.AddWithValue("@pass",TB_PASSWORD.Text);
            cmdadd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Oluşturuldu","Yeni kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TB_NAME.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TB_SURNAME.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CB_BRANCH.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MTB_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TB_PASSWORD.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BT_DELETE_Click(object sender, EventArgs e)
        {
            SqlCommand cmddelete = new SqlCommand("delete from tDOCTORS where TC=@t1",bgl.baglanti());
            cmddelete.Parameters.AddWithValue("@t1",MTB_TC.Text);
            cmddelete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi","UYARI !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void BT_UPDATE_Click(object sender, EventArgs e)
        {
            SqlCommand cmdup = new SqlCommand("Update tDOCTORS set NAME=@p1,SURNAME=@p2,BRANCH=@p3,PASSWORD=@p5 where TC=@p4",bgl.baglanti());
            cmdup.Parameters.AddWithValue("@p1",TB_NAME.Text);
            cmdup.Parameters.AddWithValue("@p2", TB_SURNAME.Text);
            cmdup.Parameters.AddWithValue("@p3",CB_BRANCH.Text);
            cmdup.Parameters.AddWithValue("@p4", MTB_TC.Text);
            cmdup.Parameters.AddWithValue("@p5",TB_PASSWORD.Text);
            cmdup.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi","GÜNCELLEME",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
