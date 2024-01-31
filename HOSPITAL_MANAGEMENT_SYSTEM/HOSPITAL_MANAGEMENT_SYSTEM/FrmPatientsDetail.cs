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
using System.Data.Common;

namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    public partial class FrmPatientsDetail : Form
    {
        public FrmPatientsDetail()
        {
            InitializeComponent();
        }

        public string tc;

        We_Will_Connection bgl= new We_Will_Connection();

        private void FrmPatientsDetail_Load(object sender, EventArgs e)
        {
            //kişi bilgileri yazdırma
            
            LB_KISI_TC.Text = tc;

            SqlCommand komut = new SqlCommand("Select NAME,SURNAME from tPATIENTS where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LB_KISI_TC.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                LB_KISI_ISIM.Text = dr[0]+" "+dr[1];
            }
            bgl.baglanti().Close();


            //randevu geçmişi yazdırma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tAppointments where PATIENT_TC=" + tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları çekme
            SqlCommand cmd = new SqlCommand("Select NAME from tBRANCHES",bgl.baglanti());
            SqlDataReader dr1= cmd.ExecuteReader();
            while(dr1.Read())
            {
                CB_BRANCH.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();
        }

        private void CB_BRANCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_DOCTOR.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select NAME,SURNAME from tDOCTORS where BRANCH=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CB_BRANCH.Text);
            SqlDataReader dr3= komut3.ExecuteReader();
            while(dr3.Read())
            {
                CB_DOCTOR.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CB_DOCTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tAppointments where BRANCH='" + CB_BRANCH.Text + "'"+" and DOCTOR='"+CB_DOCTOR.Text+"' and STATUS=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LNK_BILGIDUZENLE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr=new FrmBilgiDuzenle();
            fr.tcno = LB_KISI_TC.Text;
            fr.Show();
        }

        private void BT_RANDEVU_Click(object sender, EventArgs e)
        {
            SqlCommand cmdupran = new SqlCommand("update tAppointments set STATUS=1,PATIENT_TC=@p1,Sikayet=@p2 where ID=@p3",bgl.baglanti());
            cmdupran.Parameters.AddWithValue("@p1",LB_KISI_TC.Text);
            cmdupran.Parameters.AddWithValue("@p2",RTB_SIKAYET.Text);
            cmdupran.Parameters.AddWithValue("@p3",TB_ID.Text);
            cmdupran.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TB_ID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
