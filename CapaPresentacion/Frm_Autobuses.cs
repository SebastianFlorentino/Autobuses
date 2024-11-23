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
    public partial class Frm_Autobuses : Form
    {
        private bool editar = false;
        N_Autobuses objNegocio = new N_Autobuses();
        E_Autobuses objEntidad = new E_Autobuses();
        public Frm_Autobuses()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        public void limpiarCaja()
        {
            editar = false;
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtColor.Text = "";
            txtAnno.Text = "";

            txtMarca.Focus();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Autobuses objNegocio = new N_Autobuses();

            tablaAutobus.DataSource = objNegocio.listandoAutobuses(buscar);
            tablaAutobus.Columns[0].Visible = false;
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.text);
        }

        private void Frm_Autobuses_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaAutobus.SelectedRows.Count > 0)
            {
                objEntidad.IDAutobus = Convert.ToInt32(tablaAutobus.CurrentRow.Cells[0].Value.ToString());
                objEntidad.marca = txtMarca.Text;
                objEntidad.modelo = txtModelo.Text;
                objEntidad.placa = txtPlaca.Text;
                objEntidad.color = txtColor.Text;
                objEntidad.anno = txtAnno.Text;

                objNegocio.editandoAutobuses(objEntidad);
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
            if (tablaAutobus.SelectedRows.Count > 0)
            {
                objEntidad.IDAutobus = Convert.ToInt32(tablaAutobus.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminandoAutobuses(objEntidad);

                MessageBox.Show("El chofer fue eliminado");
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
                    objEntidad.marca = txtMarca.Text;
                    objEntidad.modelo = txtModelo.Text;
                    objEntidad.placa = txtPlaca.Text;
                    objEntidad.color = txtColor.Text;
                    objEntidad.anno = txtAnno.Text;

                    objNegocio.insertandoAutobuses(objEntidad);

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
                    objEntidad.marca = txtMarca.Text;
                    objEntidad.modelo = txtModelo.Text;
                    objEntidad.placa = txtPlaca.Text;
                    objEntidad.color = txtColor.Text;
                    objEntidad.anno = txtAnno.Text;

                    objNegocio.insertandoAutobuses(objEntidad);

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
