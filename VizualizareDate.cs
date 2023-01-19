using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProiectMIP
{
    //mostenire
   internal class VizualizareDate : SalvareDate
    {
        static SalvareDate SalvareDate = new SalvareDate();
        string conex = SalvareDate.conexiune();
        
        public DataTable sqlData()
        {
            SqlConnection con = new SqlConnection(@conex);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Angajat", con);

            DataTable dta = new DataTable();
            adapter.Fill(dta);

          return dta;
        }
    }
}
