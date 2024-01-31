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
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
        }


        We_Will_Connection bgl=new We_Will_Connection();

        private void FrmBranch_Load(object sender, EventArgs e)
        {
            //branşları data gride yazma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tBRANCHES", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TB_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TB_BRANCH_NAME.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BT_ADD_Click(object sender, EventArgs e)
        {
            SqlCommand cmdadd = new SqlCommand("insert into tBRANCHES(NAME)values(@b1)",bgl.baglanti());
            cmdadd.Parameters.AddWithValue("@b1",TB_BRANCH_NAME.Text);
            cmdadd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş eklendi","EKleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BT_DELETE_Click(object sender, EventArgs e)
        {
            SqlCommand cmddel = new SqlCommand("delete from tBRANCHES where ID=@p1",bgl.baglanti());
            cmddel.Parameters.AddWithValue("@p1",TB_ID.Text);
            cmddel.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi !","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void BT_UPDATE_Click(object sender, EventArgs e)
        {
            SqlCommand cmdup = new SqlCommand("update tBRANCHES set NAME=@b2 where ID=@b1",bgl.baglanti());
            cmdup.Parameters.AddWithValue("@b1",TB_ID.Text);
            cmdup.Parameters.AddWithValue("@b2", TB_BRANCH_NAME.Text);
            cmdup.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
