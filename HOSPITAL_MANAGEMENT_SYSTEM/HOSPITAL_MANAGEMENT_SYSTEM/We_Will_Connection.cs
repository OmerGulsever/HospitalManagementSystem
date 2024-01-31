using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HOSPITAL_MANAGEMENT_SYSTEM
{
    internal class We_Will_Connection
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-9QAJ9L8\\SQLEXPRESS;Initial Catalog=Hospital_Management_System;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
