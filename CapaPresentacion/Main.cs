using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        

        private void btnChofer_Click(object sender, EventArgs e)
        {
            frmChofer chofer = new frmChofer();
            chofer.Show();
            this.Hide();
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            Frm_Autobuses frm_Autobuses = new Frm_Autobuses();
            frm_Autobuses.Show();
            this.Hide();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            frmRutas frmRutas = new frmRutas();
            frmRutas.Show();
            this.Hide();
        }
    }
}
