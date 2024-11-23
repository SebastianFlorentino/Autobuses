using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Autobuses
    {
        D_Autobuses objDato = new D_Autobuses();

        //Create

        public void insertandoAutobuses(E_Autobuses autobuses)
        {
            objDato.InsertarAutobuses(autobuses);

        }

        //Read

        public List<E_Autobuses> listandoAutobuses(string buscar)
        {
            return objDato.ListarAutobuses(buscar);
        }

        //Update

        public void editandoAutobuses(E_Autobuses autobuses)
        {
            objDato.EditarAutobuses(autobuses);
        }

        //Delete

        public void eliminandoAutobuses(E_Autobuses autobuses)
        {
            objDato.EliminarAutobuses(autobuses);
        }
    }
}
