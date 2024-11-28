using GMap.NET.MapProviders;
using System.Data.OleDb;


namespace NEAProjectActual
{
    public partial class FormHome : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
        string dbSource = @"Data Source=your_database_path\ADSBDatabase.accdb";
        public FormHome()
        {
            InitializeComponent();

        }

        private void ListView()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Aircraft";

                //do the sql
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                // no duplicates allowed
                lstTrackedAircraft.Items.Clear();


                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["icaoAddress"].ToString());

                    item.SubItems.Add(reader["registration"].ToString());
                    item.SubItems.Add(reader["type"].ToString());
                    item.SubItems.Add(reader["irline"].ToString());
                    lstTrackedAircraft.Items.Add(item);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }



        }
        private void ConfigMap()
        {
            mapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            //Sets map used to Google Maps

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
            ConfigMap();
            ListView();
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

    }
}
