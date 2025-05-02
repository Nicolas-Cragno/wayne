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
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static string server = "server=.\\SQLEXPRESS;";
        static string database = "database=cantarini_control;";
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
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        } // Escribir consulta - query desde la app a BD

        public string buscarChofer(int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            string queryChofer = "SELECT apellido, nombres FROM cantarini_control.dbo.personas WHERE dni = " + dni + ";";
            string nombreChofer;
            datos.setearConsulta(queryChofer);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                nombreChofer = (string)datos.Lector["apellido"] + ", " + (string)datos.Lector["nombres"];
            }
            else
            {
                nombreChofer = "SIN CHOFER ASIGNADO";
            }

            return nombreChofer;
        }

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

        public int buscarIdPuesto(string nombrePuesto)
        {
            AccesoDatos datos = new AccesoDatos();
            string queryPuesto = "SELECT idPuesto FROM cantarini_control.dbo.puestos WHERE nombre = '" + nombrePuesto + "';";
            int idPuesto;
            datos.setearConsulta(queryPuesto);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                idPuesto = (int)datos.Lector["idPuesto"];
            }
            else
            {
                idPuesto = 0;
            }
            return idPuesto;
        }

        public string buscarEmpresa(int idEmpresa)
        {
            string nombreEmpresa;

            switch (idEmpresa)
            {
                case 1: nombreEmpresa = "TRANSPORTES CANTARINI";
                    break;
                case 2: nombreEmpresa = "TRANSAMERICA TRANSPORTES";
                    break;
                case 3: nombreEmpresa = "EXPRESO CANTARINI";
                    break;
                default: nombreEmpresa = "NO REGISTRADO";
                    break;
            }
            /*  busqueda por DB que trae error
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
            */
            return nombreEmpresa;
        }

        public int buscarIdEmpresa(string nombreEmpresa)
        {

            AccesoDatos datos = new AccesoDatos();
            string queryEmpresa = "SELECT idEmpresa FROM cantarini_control.dbo.empresas WHERE nombre='" + nombreEmpresa + "';";
            int idEmpresa;
            datos.setearConsulta(queryEmpresa);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                idEmpresa = (int)datos.Lector["idEmpresa"];
            }
            else
            {
                idEmpresa = 0;
            }

            return idEmpresa;
        }

        public string buscarSatUb(int idSat)
        {
            string nombreSat;

            switch (idSat)
            {
                case 0: nombreSat = "SIN SATELITAL";
                    break;
                case 1: nombreSat = "MICHELIN";
                    break;
                case 2: nombreSat = "CARTRUCK";
                    break;
                default: nombreSat = "SIN SATELITAL";
                    break;
            }
            

            return nombreSat;
        }

        public int buscarIdSatUb(string sat)
        {
            AccesoDatos datos = new AccesoDatos();
            string querySat = "SELECT idSat_Ub FROM cantarini_control.dbo.ubicacion_satelital WHERE nombre = '" + sat + "';";
            int idSat;
            datos.setearConsulta(querySat);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                idSat = (int)datos.Lector["idSat_Ub"];
            }
            else
            {
                idSat = 0;
            }

            return idSat;
        }

        public string buscarSatCb(int idSat)
        {
            string nombreSat;

            switch (idSat)
            {
                case 0:
                    nombreSat = "SIN SATELITAL";
                    break;
                case 1:
                    nombreSat = "MICHELIN";
                    break;
                case 2:
                    nombreSat = "SCANIA";
                    break;
                default:
                    nombreSat = "SIN SATELITAL";
                    break;
            }


            return nombreSat;
        }

        public int buscarIdSatCb(string sat)
        {
            AccesoDatos datos = new AccesoDatos();
            string querySat = "SELECT idSat_Cb FROM cantarini_control.dbo.combustible_satelital WHERE nombre = '" + sat + "';";
            int idSat;
            datos.setearConsulta(querySat);
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                idSat = (int)datos.Lector["idSat_Cb"];
            }
            else
            {
                idSat = 0;
            }

            return idSat;
        }

        public int numerarBool(bool estado)
        {
            int nro;
            if (estado)
            {
                nro = 1;
            }
            else
            {
                nro = 0;
            }

            return nro;
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
