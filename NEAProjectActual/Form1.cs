using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace NEAProjectActual
{
    public partial class Form1 : Form
    {
        public Form1()
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

        }
    }
}
