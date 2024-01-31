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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        We_Will_Connection bgl =new We_Will_Connection();

        private void B_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tSECRETARIES WHERE TC=@tc AND PASSWORD=@ps",bgl.baglanti());
            cmd.Parameters.AddWithValue("@tc",mTb_TC.Text);
            cmd.Parameters.AddWithValue("@ps", Tb_PASS.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryDetail frs=new FrmSecretaryDetail();
                frs.tcs = mTb_TC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC no veya ŞİFRE hatalı !!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
