using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace CapaDatos
{
    public class D_Choferes
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        //Create
        public void InsertarChoferes(E_Choferes choferes)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarChoferes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Nombre", choferes.nombre);
            cmd.Parameters.AddWithValue("@Apellidos", choferes.apellidos);
            cmd.Parameters.AddWithValue("@FechaNacimiento", choferes.fecha);
            cmd.Parameters.AddWithValue("@Cedula", choferes.cedula);
            
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //Read
        public List<E_Choferes> ListarChoferes(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarChoferes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Choferes> listar = new List<E_Choferes>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Choferes
                {
                    IDchofer = leerFilas.GetInt32(0),
                    nombre = leerFilas.GetString(1),
                    apellidos = leerFilas.GetString(2),
                    fecha = leerFilas.GetDateTime(3),
                    cedula = leerFilas.GetString(4)
                });
            }

            cn.Close();
            leerFilas.Close();
            return listar;

        }

        //Update
        public void EditarChoferes(E_Choferes choferes)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarChoferes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@IDChofer", choferes.IDchofer);
            cmd.Parameters.AddWithValue("@Nombre", choferes.nombre);
            cmd.Parameters.AddWithValue("@Apellidos", choferes.apellidos);
            cmd.Parameters.AddWithValue("@FechaNacimiento   ", choferes.fecha);
            cmd.Parameters.AddWithValue("@Cedula", choferes.cedula);
 
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //Delete

        public void EliminarChoferes(E_Choferes choferes)
        {
            SqlCommand cmd = new SqlCommand("SP_BorrarChoferes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Borrar", choferes.IDchofer);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
