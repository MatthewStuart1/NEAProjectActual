using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lblPlaneId.Text = _planeId;
        }
    }

}
