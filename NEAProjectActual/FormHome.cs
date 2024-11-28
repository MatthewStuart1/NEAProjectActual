using GMap.NET.MapProviders;

namespace NEAProjectActual
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void ConfigMap()
        {
            mapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            //Sets map used to Google Maps

            mapControl1.ShowCenter = false;
            //removes stupid red cross

            mapControl1.Overlays.Clear();
            //clears map of icons

            mapControl1.Position = new GMap.NET.PointLatLng(46.8182, 8.2275);
            //default position for map

            mapControl1.MinZoom = 0;
            //min zoom

            mapControl1.MaxZoom = 24;
            //max zoom

            mapControl1.Zoom = 9;
            //default zoom
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigMap();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew(this);
            formAddNew.Show();
        }

        private void btnAddBulk_Click(object sender, EventArgs e)
        {
            FormAddBulk formBulkAdd = new FormBulkAdd(this);
            formBulkAdd.Show();
        }
        public static void AddNewAircraft()
        {
            //SQL to add a new aircraft to the tracked database
        }

    }
}
