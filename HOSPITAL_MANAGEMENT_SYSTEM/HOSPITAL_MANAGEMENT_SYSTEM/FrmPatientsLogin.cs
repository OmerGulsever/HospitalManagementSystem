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
    public partial class FrmPatientsLogin : Form
    {
        public FrmPatientsLogin()
        {
            InitializeComponent();
        }

        private void Llb_Uyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientsSave fr=new FrmPatientsSave();
            fr.Show();
        }

        We_Will_Connection bgl=new We_Will_Connection();

        private void B_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from tPATIENTS where TC=@tc and PASSWORD=@ps",bgl.baglanti());
            cmd.Parameters.AddWithValue("@tc", mTb_TC.Text);
            cmd.Parameters.AddWithValue("@ps",Tb_PASS.Text);
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientsDetail fr=new FrmPatientsDetail();
                fr.tc = mTb_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC yada Şifre !","Kayıt Bulanamadı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
