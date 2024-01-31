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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcno;

        We_Will_Connection bgl=new We_Will_Connection();

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            Mtb_TC.Text = tcno;
            SqlCommand cmd=new SqlCommand("select* from tPATIENTS where TC=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",Mtb_TC.Text);
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                Tb_Name.Text = dr[1].ToString();
                tB_Surname.Text = dr[2].ToString();
                Mtb_Phone.Text = dr[4].ToString();
                tB_PASS.Text = dr[5].ToString();
                cB_GENDER.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tPATIENTS set NAME=@name,SURNAME=@sur,PHONE=@pho,PASSWORD=@pas,GENDER=@gn WHERE TC=@tc",bgl.baglanti());
            cmd.Parameters.AddWithValue("@name", Tb_Name.Text);
            cmd.Parameters.AddWithValue("@sur", tB_Surname.Text);
            cmd.Parameters.AddWithValue("@pho",Mtb_Phone.Text);
            cmd.Parameters.AddWithValue("@pas",tB_PASS.Text);
            cmd.Parameters.AddWithValue("@gn", cB_GENDER.Text);
            cmd.Parameters.AddWithValue("@tc", Mtb_TC.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir !","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
