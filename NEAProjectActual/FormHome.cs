using GMap.NET.MapProviders;
using System.Data.OleDb;

namespace NEAProjectActual
{
    public partial class FormHome : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public FormHome()
        {
            InitializeComponent();
            lstTrackedAircraft.ItemActivate += listViewPlanes_ItemActivate;
        }

        public void ListView()
        {
            try
            {
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT registration, icaoAddress, type, airline FROM Aircraft";
                dr = dbConnector.DoSQL(sqlStr);
                lstTrackedAircraft.Items.Clear();
                while (dr.Read())
                {
                    var item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    lstTrackedAircraft.Items.Add(item);
                }
                dbConnector.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ConfigMap()
        {
            mapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            mapControl1.ShowCenter = false;
            mapControl1.Overlays.Clear();
            mapControl1.Position = new GMap.NET.PointLatLng(46.218386, 6.133021);
            mapControl1.MinZoom = 0;
            mapControl1.MaxZoom = 24;
            mapControl1.Zoom = 12;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListView();
            ConfigMap();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            formAddNew.Show();
        }

        private void btnAddBulk_Click(object sender, EventArgs e)
        {
            FormAddBulk formAddBulk = new FormAddBulk();
            formAddBulk.Show();
        }

        public static void AddNewAircraft()
        {
            // SQL to add a new aircraft to the tracked database
        }

        private void btnNewPilot_Click(object sender, EventArgs e)
        {
            FormAddPilot formAddPilot = new FormAddPilot();
            formAddPilot.Show();
        }

        private void listViewPlanes_ItemActivate(object? sender, EventArgs e)
        {
            if (lstTrackedAircraft.SelectedItems.Count > 0)
            {
                var item = lstTrackedAircraft.SelectedItems[0];
                string planeId = item.SubItems[0].Text;

                var planeDetailsForm = new FormAircraftDetails(planeId);
                planeDetailsForm.Show();
            }
        }

        public void DurationCalculator(DateTime Departure, DateTime Arrival)
        {

        }
    }
}
