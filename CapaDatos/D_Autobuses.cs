using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Autobuses
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        //Create
        public void InsertarAutobuses(E_Autobuses autobuses)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarAutobuses", cn);
            cmd.CommandType= CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Marca", autobuses.marca);
            cmd.Parameters.AddWithValue("@Modelo", autobuses.modelo);
            cmd.Parameters.AddWithValue("@Placa", autobuses.placa);
            cmd.Parameters.AddWithValue("@Color", autobuses.color);
            cmd.Parameters.AddWithValue("@anno", autobuses.anno);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //Read
        public List<E_Autobuses> ListarAutobuses(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarAutobuses", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Autobuses> listar = new List<E_Autobuses>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Autobuses
                {
                    IDAutobus = leerFilas.GetInt32(0),
                    marca = leerFilas.GetString(1),
                    modelo = leerFilas.GetString(2),
                    placa = leerFilas.GetString(3),
                    color = leerFilas.GetString(4),
                    anno = leerFilas.GetString(5),
                });
            }

            cn.Close();
            leerFilas.Close();
            return listar;

        }

        //Update
        public void EditarAutobuses(E_Autobuses autobuses)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarAutobuses", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@IDAutobus", autobuses.IDAutobus);
            cmd.Parameters.AddWithValue("@Marca", autobuses.marca);
            cmd.Parameters.AddWithValue("@Modelo", autobuses.modelo);
            cmd.Parameters.AddWithValue("@Placa", autobuses.placa);
            cmd.Parameters.AddWithValue("@Color", autobuses.color);
            cmd.Parameters.AddWithValue("@anno", autobuses.anno);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //Delete

        public void EliminarAutobuses(E_Autobuses autobuses)
        {
            SqlCommand cmd = new SqlCommand("SP_BorrarAutobuses", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Borrar",autobuses.IDAutobus);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}

