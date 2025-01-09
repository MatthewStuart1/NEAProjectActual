using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NEAProjectActual
{
    public partial class FormAircraftDetails : Form
    {
        private string _planeId;

        public FormAircraftDetails(string planeId)
        {
            InitializeComponent();
            _planeId = planeId;

            LoadAircraftDetails();
        }

        private void LoadAircraftDetails()
        {
            try
            {
                lblPlaneId.Text = _planeId;
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT icaoAddress, registration, type, airline FROM Aircraft";
                dr = dbConnector.DoSQL(sqlStr);
                lstFlightDetails.Items.Clear();
                while (dr.Read())
                {
                    var item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    lstFlightDetails.Items.Add(item);
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
    }

}
