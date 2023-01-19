using System.Data;
using System.Data.SqlClient;

namespace ProiectMIP
{
    public partial class StergereAngajat : Form
    {
        public StergereAngajat()
        {
            InitializeComponent();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            AdaugareAngajat objAngajat = new AdaugareAngajat();
            this.Hide();
            objAngajat.Show();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DialogResult dr = MessageBox.Show("Sunteti sigur ca doriti sa stergeti angajatul din tabela?", "Confirmare", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EVTU0EQ;Initial Catalog=Companie;Integrated Security=True");
                string query = "DELETE from Angajat where IDAngajat='" + txtID.Text.Trim() + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                
                adapter.Fill(dt);

                MessageBox.Show("Angajatul a fost sters!");
            }
            else if (dr == DialogResult.No)
            {
               MessageBox.Show("Angajatul nu a fost sters!");
            }
        }
    }
}
