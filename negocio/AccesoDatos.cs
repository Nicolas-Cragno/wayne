using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static string server = "server=.\\SQLEXPRESS;";
        static string database = "database=cantarini_db;";
        static string security = "integrated security=true";

        string cadenaConexion = server+database+security;

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        } // iniciar conexión a base de datos

        public void setearConsulta(string consulsta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulsta;
        }  // consultas-query a BD

        public void ejecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // Leer contenido de db segun consulta

        public void ejecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        } // Escribir consulta - query desde la app a BD

        public SqlDataReader Lector
        {
            get { return lector; } 
        }  // Leer lo leido en BD desde afuera (solo lectura)

        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }  // Finalizar conexión a BD
    }
}
