using ClassLibrary;
using System.Data;

namespace ProiectMIP
{
    public partial class numarareAngajat : Form
    {
        CautareDate Cautare = new CautareDate();
        public numarareAngajat()
        {
            InitializeComponent();

            //utilizare ClassLibrary
            Persoana persoana = new Persoana();
            persoana.Nume = AdaugareAngajat.Instance.txtNum.Text.Trim();
            persoana.Prenume = AdaugareAngajat.Instance.txtPren.Text.Trim();

            Adresa adresa = new Adresa();
            adresa.Strada = AdaugareAngajat.Instance.txtStr.Text.Trim();
            adresa.Numar = AdaugareAngajat.Instance.txtNr.Text.Trim();

            string aux = persoana.Nume + " " + persoana.Prenume + " locuiește pe strada " + adresa.Strada + " nr. " + adresa.Numar;
            lblPersoana.Text = aux;
        }

        private void btnCautaNume_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Cautare.sqlData("select numeAngajat, prenumeAngajat, numeDepartament from Angajat where numeDepartament = '" + txtNume.Text.Trim() + "'");
            dgSelectWhere.DataSource = dt;

            //tratare exceptie
            if (dt.Rows.Count == 0)
                MessageBox.Show("Nu exista angajati in acest departament!");
        }

        private void btnDepartament_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Cautare.sqlData("select count(numeDepartament) as 'Numar angajati din departament', numeDepartament from Angajat group by numedepartament");//+ txtDepartament.Text.Trim() + "'");
            dgSelectWhere.DataSource = dt;

            //tratare exceptie
            if (dt.Rows.Count ==0 )
                MessageBox.Show("Nu exista angajati in departamentul cautat!");
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

        private void dgSelectWhere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
