using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Choferes
    {
        D_Choferes objDato = new D_Choferes();

        //Create

        public void insertandoChoferes(E_Choferes choferes)
        {
            objDato.InsertarChoferes(choferes);

        }

        //Read

        public List<E_Choferes> listandoChoferes(string buscar)
        {
            return objDato.ListarChoferes(buscar);
        }

        //Update

        public void editandoChoferes(E_Choferes choferes)
        {
            objDato.EditarChoferes(choferes);
        }

        //Delete

        public void eliminandoChoferes(E_Choferes choferes)
        {
            objDato.EliminarChoferes(choferes);
        }
    }
}
