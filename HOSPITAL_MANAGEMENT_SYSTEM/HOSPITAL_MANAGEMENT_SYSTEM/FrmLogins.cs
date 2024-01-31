using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void BT_PATIENTS_Click(object sender, EventArgs e)
        {
            FrmPatientsLogin frhasta = new FrmPatientsLogin();
            frhasta.Show();
            this.Hide();
        }

        private void BT_DOCTOR_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin frmDoctor = new FrmDoctorLogin();
            frmDoctor.Show();
            this.Hide();
        }

        private void BT_SECRETARY_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin frSec =new FrmSecretaryLogin();
            frSec.Show();
            this.Hide();
        }
    }
}
