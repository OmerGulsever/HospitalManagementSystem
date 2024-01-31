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
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }

        We_Will_Connection bgl=new We_Will_Connection();

        private void B_login_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select * from tDOCTORS where TC=@p1 and PASSWORD=@p2",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",mTb_TC.Text);
            cmd.Parameters.AddWithValue("@p2",Tb_PASS.Text);
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetail frm = new FrmDoctorDetail();
                frm.tc = mTb_TC.Text;
                frm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("TC veya Şifre Hatalı","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
            
        }

        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
