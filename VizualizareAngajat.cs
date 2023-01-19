using ClassLibrary;
using System.Data;

namespace ProiectMIP
{
    public partial class VizualizareAngajat : Form 
    {
        VizualizareDate VizualizareDate = new VizualizareDate();

        public VizualizareAngajat()
        {
            InitializeComponent();

            //utilizare ClassLibrary
            Persoana persoana = new Persoana();
            persoana.Nume = AdaugareAngajat.Instance.txtNum.Text.Trim();
            persoana.Prenume = AdaugareAngajat.Instance.txtPren.Text.Trim();
           
            Adresa adresa = new Adresa();
            adresa.Strada = AdaugareAngajat.Instance.txtStr.Text.Trim();
            adresa.Numar =  AdaugareAngajat.Instance.txtNr.Text.Trim();

            string aux = persoana.Nume + " " + persoana.Prenume + " locuiește pe strada " + adresa.Strada + " nr. " + adresa.Numar;
            lbPersoana.Text = aux;

            DataTable dt = new DataTable();
            dt = VizualizareDate.sqlData();
            dgSelectAll.DataSource = dt;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            AdaugareAngajat obj_adaugareAngajat = new AdaugareAngajat();
            this.Hide();
            obj_adaugareAngajat.Show();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
