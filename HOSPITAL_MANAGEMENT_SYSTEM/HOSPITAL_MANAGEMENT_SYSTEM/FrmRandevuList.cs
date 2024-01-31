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
    public partial class FrmRandevuList : Form
    {
        public FrmRandevuList()
        {
            InitializeComponent();
        }

        We_Will_Connection bgl=new We_Will_Connection();

        private void FrmRandevuList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tAppointments", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
