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
    public partial class frmChofer : Form
    {
        private string IDchofer;
        private bool editar = false;

        E_Choferes objEntidad = new E_Choferes();
        N_Choferes objNegocio = new N_Choferes();

        public frmChofer()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tablaChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (tablaChoferes.SelectedRows.Count > 0)
            //{
            //    editar = true;

            //    IDchofer = tablaChoferes.CurrentRow.Cells[0].Value.ToString();
            //    txtNombre.Text = tablaChoferes.CurrentRow.Cells[1].Value.ToString();
            //    txtApellidos.Text = tablaChoferes.CurrentRow.Cells[2].Value.ToString();
            //    dtFecha.Value = Convert.ToDateTime(tablaChoferes.CurrentRow.Cells[3].Value);
            //    txtCedula.Text = tablaChoferes.CurrentRow.Cells[4].Value.ToString();

            //}
         
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Choferes objNegocio = new N_Choferes();

            tablaChoferes.DataSource = objNegocio.listandoChoferes(buscar);
            tablaChoferes.Columns[0].Visible = false;
        }



        private void frmChofer_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }


        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        public void limpiarCaja()
        {
            editar = false;
            txtNombre.Text = "";
            txtApellidos.Text = "";
            dtFecha.Text = "";
            txtCedula.Text = "";

            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaChoferes.SelectedRows.Count > 0)
            {
                editar = true;


                //IDchofer = tablaChoferes.CurrentRow.Cells[0].Value.ToString();
                //txtNombre.Text = tablaChoferes.CurrentRow.Cells[1].Value.ToString();
                //txtApellidos.Text = tablaChoferes.CurrentRow.Cells[2].Value.ToString();
                //dtFecha.Value = Convert.ToDateTime( tablaChoferes.CurrentRow.Cells[3].Value);
                //txtCedula.Text = tablaChoferes.CurrentRow.Cells[4].Value.ToString();

                objEntidad.IDchofer = Convert.ToInt32(tablaChoferes.CurrentRow.Cells[0].Value.ToString());
                objEntidad.nombre = txtNombre.Text;
                objEntidad.apellidos = txtApellidos.Text;
                objEntidad.fecha = dtFecha.Value;
                objEntidad.cedula = txtCedula.Text;

                objNegocio.editandoChoferes(objEntidad);
                MessageBox.Show("Fue editada la fila");
                mostrarBuscarTabla("");
                limpiarCaja();


            }
            else
            {
                MessageBox.Show("Seleccione un campo para editar");
            }
        }

        private void tablaChoferes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaChoferes.SelectedRows.Count > 0)
            {
                editar = true;

                IDchofer = tablaChoferes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaChoferes.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = tablaChoferes.CurrentRow.Cells[2].Value.ToString();
                dtFecha.Value = Convert.ToDateTime(tablaChoferes.CurrentRow.Cells[3].Value);
                txtCedula.Text = tablaChoferes.CurrentRow.Cells[4].Value.ToString();

            }else
            {
                MessageBox.Show("Mensaje de error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objEntidad.nombre = txtNombre.Text.ToUpper();
                    objEntidad.apellidos = txtApellidos.Text.ToUpper();
                    objEntidad.fecha = dtFecha.Value;
                    objEntidad.cedula = txtCedula.Text;

                    objNegocio.insertandoChoferes(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCaja();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("No se pudo registrar " +  ex.Message);
                }
            }
            if (editar == true)
            {
                try
                {
                    objEntidad.nombre = txtNombre.Text.ToUpper();
                    objEntidad.apellidos = txtApellidos.Text.ToUpper();
                    objEntidad.fecha = dtFecha.Value;
                    objEntidad.cedula = txtCedula.Text;

                    objNegocio.insertandoChoferes(objEntidad);

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tablaChoferes.SelectedRows.Count > 0)
            {
                objEntidad.IDchofer = Convert.ToInt32(tablaChoferes.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminandoChoferes(objEntidad);

                MessageBox.Show("El chofer fue eliminado");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que quiere eliminar");
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
