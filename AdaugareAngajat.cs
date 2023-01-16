namespace ProiectMIP
{
    public partial class AdaugareAngajat : Form
    {
        SalvareDate SalvareDate = new SalvareDate();


        public static AdaugareAngajat Instance = new AdaugareAngajat();
        public TextBox txtNum;
        public TextBox txtPren;
        public TextBox txtStr;
        public TextBox txtNr;

        public AdaugareAngajat()
        {
            InitializeComponent();
            Instance = this;
            txtNum = txtNume;
            txtPren = txtPrenume;
            txtStr = txtStrada;
            txtNr = txtNumar;
        }

        private void Salvare_Click(object sender, EventArgs e)
        {
            try
            {
                object listboxDepartament = lbDepartament.SelectedItem;
                SalvareDate.sqlData("INSERT INTO Angajat(numeAngajat, prenumeAngajat, numeDepartament, nrTelefonAngajat) VALUES ('"
                              + txtNume.Text.Trim() + "','"
                              + txtPrenume.Text.Trim() + "','"
                              + listboxDepartament.ToString().Trim() + "','"
                              + txtNrTelefon.Text.Trim() + "')");
            }
            catch (System.NullReferenceException)
            {

                MessageBox.Show("Alegeti un departament!");
            }

            MessageBox.Show("Date inregistrate cu succes!");
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            VizualizareAngajat obj_vizualizareAngajat = new VizualizareAngajat();
            this.Hide();
            obj_vizualizareAngajat.Show();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            numarareAngajat obj_cautareAngajat = new numarareAngajat();
            this.Hide();
            obj_cautareAngajat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> departamente = new List<string>();
            departamente.Add("Resurse Umane");
            departamente.Add("Financiar");
            departamente.Add("Productie");
            departamente.Add("Vanzari");
            departamente.Add("HR");
            lbDepartament.DataSource = departamente;
        }
    }
}