using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRutas : Form
    {
        E_Rutas objEntidad = new E_Rutas();
        N_Rutas objNegocio = new N_Rutas();
        private bool editar = false;
        public frmRutas()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void limpiarCaja()
        {
            editar = false;
            txtRuta.Text = "";
            

            txtRuta.Focus();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            

            tablaRuta.DataSource = objNegocio.listandoRutas(buscar);
            tablaRuta.Columns[0].Visible = false;
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }

        private void frmRutas_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaRuta.SelectedRows.Count > 0)
            {
                objEntidad.idRuta = Convert.ToInt32(tablaRuta.CurrentRow.Cells[0].Value.ToString());
                objEntidad.nRuta = txtRuta.Text;
                

                objNegocio.editandoRutas(objEntidad);
                MessageBox.Show("Fue editada la fila");
                mostrarBuscarTabla("");
                limpiarCaja();
            }
            else
            {
                MessageBox.Show("Seleccione un campo para editar");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tablaRuta.SelectedRows.Count > 0)
            {
                objEntidad.idRuta = Convert.ToInt32(tablaRuta.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminandoRutas(objEntidad);

                MessageBox.Show("La ruta fue eliminado");
                mostrarBuscarTabla("");
                limpiarCaja();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que quiere eliminar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objEntidad.nRuta = txtRuta.Text;
                    

                    objNegocio.insertandoRutas(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar " + ex.Message);
                }
            }
            if (editar == true)
            {
                try
                {
                    objEntidad.nRuta = txtRuta.Text;
                    

                    objNegocio.insertandoRutas(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCaja();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar " + ex.Message);
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
