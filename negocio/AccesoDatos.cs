using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Security.AccessControl;


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
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
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

        public string buscarPuesto(int idPuesto)
        {
            AccesoDatos datos = new AccesoDatos();
            string queryPuesto = "SELECT nombre FROM cantarini_control.dbo.puestos WHERE idPuesto = " + idPuesto + ";";
            string nombrePuesto;
            datos.setearConsulta(queryPuesto);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                nombrePuesto = (string)datos.Lector["nombre"];
            }
            else
            {
                nombrePuesto = "";
            }
                return nombrePuesto;
        }

        public string buscarEmpresa(int idEmpresa)
        {
            AccesoDatos datos = new AccesoDatos();
            string queryEmpresa = "SELECT nombre FROM cantarini_control.dbo.empresas WHERE idEmpresa=" + idEmpresa + ";";
            string nombreEmpresa;
            datos.setearConsulta(queryEmpresa);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                nombreEmpresa = (string)datos.Lector["nombre"];
            }
            else
            {
                nombreEmpresa = "";
            }

            return nombreEmpresa;
        }

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
