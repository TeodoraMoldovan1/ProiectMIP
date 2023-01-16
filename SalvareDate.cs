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
    public class SalvareDate
    {
        public string conexiune()
        {
            return @"Data Source=DESKTOP-EVTU0EQ;Initial Catalog=Companie;Integrated Security=True";
        }

        public void sqlData(string query)
        { 
                SqlConnection con = new SqlConnection(conexiune());
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dta = new DataTable();
                adapter.Fill(dta);
        }
    }
}
