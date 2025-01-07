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
        }

        public void ListView()
        {
            try
            {
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT icaoAddress, registration, type, airline FROM Aircraft";
                dr = dbConnector.DoSQL(sqlStr);
                lstTrackedAircraft.Items.Clear();
                while (dr.Read())
                {
                    lstTrackedAircraft.Items.Add(dr[0].ToString());
                    lstTrackedAircraft.Items[lstTrackedAircraft.Items.Count - 1].SubItems.Add(dr[1].ToString());
                    lstTrackedAircraft.Items[lstTrackedAircraft.Items.Count - 1].SubItems.Add(dr[2].ToString());
                    lstTrackedAircraft.Items[lstTrackedAircraft.Items.Count - 1].SubItems.Add(dr[3].ToString());
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
            //sets map used to Google Maps

            mapControl1.ShowCenter = false;
            //removes stupid red cross

            mapControl1.Overlays.Clear();
            //clears map of icons

            mapControl1.Position = new GMap.NET.PointLatLng(46.218386, 6.133021);
            //default position for map

            mapControl1.MinZoom = 0;
            //min zoom

            mapControl1.MaxZoom = 24;
            //max zoom

            mapControl1.Zoom = 12;
            //default zoom
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
            //SQL to add a new aircraft to the tracked database
        }

        private void btnNewPilot_Click(object sender, EventArgs e)
        {
            FormAddPilot formAddPilot = new FormAddPilot();
            formAddPilot.Show();
        }
    }
}
