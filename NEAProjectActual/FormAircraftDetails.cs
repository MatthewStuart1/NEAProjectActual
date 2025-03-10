﻿using System;
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
            _planeId = planeId;
            InitializeComponent();

            LoadAircraftDetails(planeId);
        }

        private void LoadAircraftDetails(string planeId)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            try
            {
                lblPlaneId.Text = _planeId;
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = $"SELECT flightID, PilotID, Departing, DepartureTime, Arriving, ArrivalTime FROM Flight WHERE AircraftID = {planeId}";
                dr = dbConnector.DoSQL(sqlStr);
                lstFlightDetails.Items.Clear();
                while (dr.Read())
                {
                    DateTime arrival = new DateTime();
                    DateTime departure = new DateTime();
                    arrival = Convert.ToDateTime(dr[6].ToString());
                    departure = Convert.ToDateTime(dr[4].ToString());

                    TimeSpan flightTime = arrival - departure;
                    string TimeSpan_ = flightTime.ToString();
                   
                    var item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    item.SubItems.Add(dr[4].ToString());
                    item.SubItems.Add(dr[5].ToString());
                    item.SubItems.Add(dr[6].ToString());
                    item.SubItems.Add(dr[TimeSpan_].ToString());
                    lstFlightDetails.Items.Add(item);
                }
                dbConnector.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                dbConnector.Close();
            }

        }


    }

}
