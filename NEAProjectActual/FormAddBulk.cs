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
    public partial class FormAddBulk : Form
    {
        public FormAddBulk()
        {
            InitializeComponent();
        }



        private void FormAddBulk_Load(object sender, EventArgs e)
        {

        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void btnAddBulk_Click(object sender, EventArgs e)
        {
            ofd.Filter = "CSV |*.CSV";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

            } 

        }
    }
}
