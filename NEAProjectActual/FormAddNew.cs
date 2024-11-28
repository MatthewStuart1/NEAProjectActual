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
    public partial class FormAddNew : Form
    {
        public FormAddNew()
        {
            InitializeComponent();

        }
        private void FormAddNew_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitNewReg_Click(object sender, EventArgs e)
        {
            string newReg = txtNewReg.Text;
            //string GReg = "G-" + newReg;

            FormHome.AddNewAircraft();

            MessageBox.Show($"new registration {newReg} added");
        }

    }
}
