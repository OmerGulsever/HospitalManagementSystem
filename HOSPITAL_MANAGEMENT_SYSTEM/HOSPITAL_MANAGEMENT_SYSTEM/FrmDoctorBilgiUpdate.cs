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
    public partial class FrmDoctorBilgiUpdate : Form
    {
        public FrmDoctorBilgiUpdate()
        {
            InitializeComponent();
        }

        We_Will_Connection bgl=new We_Will_Connection();

        public string tc;

        private void FrmDoctorBilgiUpdate_Load(object sender, EventArgs e)
        {
            Mtb_TC.Text = tc;
            SqlCommand cmd=new SqlCommand("Select * from tDOCTORS where TC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",Mtb_TC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Tb_Name.Text = dr[1].ToString();
                tB_Surname.Text = dr[2].ToString();
                CB_BRANCH.Text = dr[3].ToString();
                tB_PASS.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand cmdbr = new SqlCommand("Select NAME from tBRANCHES", bgl.baglanti());
            SqlDataReader dr2 = cmdbr.ExecuteReader();
            while (dr2.Read())
            {
                CB_BRANCH.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmdup = new SqlCommand("Update tDOCTORS set NAME=@p1,SURNAME=@p2,BRANCH=@p3,PASSWORD=@p4 where TC=@p5",bgl.baglanti());
            cmdup.Parameters.AddWithValue("@p1",Tb_Name.Text);
            cmdup.Parameters.AddWithValue("@p2", tB_Surname.Text);
            cmdup.Parameters.AddWithValue("@p3",CB_BRANCH.Text);
            cmdup.Parameters.AddWithValue("@p4", tB_PASS.Text);
            cmdup.Parameters.AddWithValue("@p5",Mtb_TC.Text);
            cmdup.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir","GÜNCELLEME",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
