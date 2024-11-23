using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Rutas
    {
        D_rutas objDato = new D_rutas();

        //Create

        public void insertandoRutas(E_Rutas rutas)
        {
            objDato.InsertarRutas(rutas);

        }

        //Read

        public List<E_Rutas> listandoRutas(string buscar)
        {
            return objDato.ListarRutas(buscar);
        }

        //Update

        public void editandoRutas(E_Rutas rutas)
        {
            objDato.EditarRutas(rutas);
        }

        //Delete

        public void eliminandoRutas(E_Rutas rutas)
        {
            objDato.EliminarRutas(rutas);
        }
    }
}
