using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProiectMIP
{
    internal class CautareDate : SalvareDate
    {
        static SalvareDate SalvareDate = new SalvareDate();
        string conex = SalvareDate.conexiune();

        public new DataTable sqlData(string query)
        {
            SqlConnection con = new SqlConnection(@conex);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable dta = new DataTable();
            adapter.Fill(dta);

            return dta;
        }
    }
}
