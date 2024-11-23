using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_rutas
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        //Create
        public void InsertarRutas(E_Rutas rutas)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarRutas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@NRuta", rutas.nRuta);
  

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //Read
        public List<E_Rutas> ListarRutas(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarRutas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Rutas> listar = new List<E_Rutas>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Rutas
                {
                    idRuta = leerFilas.GetInt32(0),
                    nRuta = leerFilas.GetString(1)
                });
            }

            cn.Close();
            leerFilas.Close();
            return listar;

        }

        //Update
        public void EditarRutas(E_Rutas rutas)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarRutas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@IDRuta", rutas.idRuta);
            cmd.Parameters.AddWithValue("@NRutas", rutas.nRuta);
            

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //Delete

        public void EliminarRutas(E_Rutas rutas)
        {
            SqlCommand cmd = new SqlCommand("SP_BorrarRutas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Borrar", rutas.idRuta);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
