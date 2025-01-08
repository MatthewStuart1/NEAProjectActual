namespace NEAProjectActual
{
    public partial class FormAddPilot : Form
    {
        public FormAddPilot()
        {
            InitializeComponent();
        }

        private void FormAddPilot_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO Pilots (First Name, Sur Name, Licence Number, ME, IR, Night)" +
                $"VALUES ('{txtFirstName}', '{txtlastName}', '{txtlicence}', '{chkME}', '{chkIR}', '{chkNR}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            this.Close();

            var formHome = Application.OpenForms["FormHome"] as FormHome;

            if (formHome != null)
            {
                formHome.ListView();
            }
            else
            {
                MessageBox.Show("FormHome is not open or accessible.");
            }
        }
    }
}
