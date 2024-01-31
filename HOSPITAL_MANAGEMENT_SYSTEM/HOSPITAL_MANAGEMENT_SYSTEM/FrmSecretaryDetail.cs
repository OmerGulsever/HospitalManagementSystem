using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        public string tcs;

        We_Will_Connection bgl=new We_Will_Connection();

        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            LB_KISI_TC.Text = tcs;


            //ad soyad getirme

            SqlCommand komut = new SqlCommand("Select NameSurname from tSECRETARIES where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LB_KISI_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LB_KISI_ISIM.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları data gridde ekleme
            DataTable dt1=new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select NAME from tBRANCHES", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource= dt1;

            //doktorları getirmw

            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select NAME+' '+SURNAME AS[AD SOYAD],BRANCH from tDOCTORS",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource= dt2;

            //Branşları comboboxa getirme
            SqlCommand cmdbr = new SqlCommand("Select NAME from tBRANCHES", bgl.baglanti());
            SqlDataReader dr2= cmdbr.ExecuteReader();
            while (dr2.Read())
            {
                CB_BRANCH.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
             
        }

        private void BT_RAN_KAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand cmdup = new SqlCommand("insert into tAppointments (DATE,TIME,BRANCH,DOCTOR) values(@r1,@r2,@r3,@r4)",bgl.baglanti());
            cmdup.Parameters.AddWithValue("@r1", MTB_DATE.Text);
            cmdup.Parameters.AddWithValue("@r2", MTB_TIME.Text);
            cmdup.Parameters.AddWithValue("@r3",CB_BRANCH.Text);
            cmdup.Parameters.AddWithValue("@r4",CB_DOCTOR.Text);
            cmdup.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void CB_BRANCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktorları getirme
            CB_DOCTOR.Items.Clear();
            SqlCommand cmddr = new SqlCommand("Select NAME,SURNAME from tDOCTORS where BRANCH=@branch", bgl.baglanti());
            cmddr.Parameters.AddWithValue("@branch", CB_BRANCH.Text);
            SqlDataReader drdc = cmddr.ExecuteReader();
            while (drdc.Read())
            {
                CB_DOCTOR.Items.Add(drdc[0]+" " + drdc[1]);
            }
            bgl.baglanti().Close();
        }

        private void BT_DUYURUYAP_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("insert into tDuyuru (DUYURU) values (@d1)",bgl.baglanti());
            cmd1.Parameters.AddWithValue("@d1", RTB_DUYURU.Text);
            cmd1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Gönderildi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BT_CLEAR_Click(object sender, EventArgs e)
        {
            RTB_DUYURU.Text = "";
        }

        private void BT_DOCTOR_PANEL_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel FRMDC=new FrmDoctorPanel();
            FRMDC.Show();
        }

        private void BT_BRANCH_PANEL_Click(object sender, EventArgs e)
        {
            FrmBranch frmrbn = new FrmBranch();
            frmrbn.Show();
        }

        private void BT_RANDEVU_LIST_Click(object sender, EventArgs e)
        {
            FrmRandevuList frmRan = new FrmRandevuList();
            frmRan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyuru FRDYU=new FrmDuyuru();
            FRDYU.Show();
        }
    }
}
