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
    public partial class FrmPatientsSave : Form
    {
        public FrmPatientsSave()
        {
            InitializeComponent();
        }

        We_Will_Connection bgl=new We_Will_Connection();

        private void Bt_Register_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tPATIENTS (NAME,SURNAME,TC,PHONE,PASSWORD,GENDER) VALUES (@NAME,@SURNAME,@TC,@PHONE,@PASS,@GENDER)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@NAME", Tb_Name.Text);
            cmd.Parameters.AddWithValue("@SURNAME", tB_Surname.Text);
            cmd.Parameters.AddWithValue("@TC", Mtb_TC.Text);
            cmd.Parameters.AddWithValue("@PHONE", Mtb_Phone.Text);
            cmd.Parameters.AddWithValue("@PASS", tB_PASS.Text);
            cmd.Parameters.AddWithValue("@GENDER", cB_GENDER.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Oluşturulmuştur Şifreniz: "+tB_PASS.Text,"Kayıt Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
