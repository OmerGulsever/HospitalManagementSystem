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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }

        We_Will_Connection bgl=new We_Will_Connection();

        public string tc;

        private void Bt_duyuru_Click(object sender, EventArgs e)
        {
            FrmDuyuru frduy=new FrmDuyuru();
            frduy.Show();
        }

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {

            LB_KISI_TC.Text = tc;
  
            SqlCommand cmd = new SqlCommand("Select NAME,SURNAME from tDOCTORS where TC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LB_KISI_TC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LB_KISI_ISIM.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tAppointments where STATUS=1 and DOCTOR='" + LB_KISI_ISIM.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Bt_update_Click(object sender, EventArgs e)
        {
            FrmDoctorBilgiUpdate frdcup=new FrmDoctorBilgiUpdate();
            frdcup.tc=LB_KISI_TC.Text;
            frdcup.Show();
        }

        private void Bt_exit_Click(object sender, EventArgs e)
        {
            FrmLogins frmlg=new FrmLogins();
            frmlg.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            LB_HASTATC.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            Rtb_SIKAYET.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            
            
            SqlCommand cmddr = new SqlCommand("Select NAME,SURNAME from tPATIENTS where TC=@p1", bgl.baglanti());
            cmddr.Parameters.AddWithValue("@p1", LB_HASTATC.Text);
            SqlDataReader drrd = cmddr.ExecuteReader();
            while (drrd.Read())
            {
                LB_HASTAISIM.Text = drrd[0] + " " + drrd[1];
            }
            bgl.baglanti().Close();
        }
    }
}
