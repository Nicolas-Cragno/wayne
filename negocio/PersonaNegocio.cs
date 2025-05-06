using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PersonaNegocio
    {
        const string db_personas = "cantarini_control.dbo.personas";
        public List<Persona> listarChoferes()
        {
            List<Persona> listaChoferes = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaChoferes = "SELECT dni, idPuesto, idEmpresa, interno, apellido, nombres, ingreso, viajes, promedio, Observaciones, activo, okAdm, okTrafico";
            string database = " FROM " + db_personas + ";";
            string queryChoferes = camposListaChoferes + database;
            

            try
            {
                datos.setearConsulta(queryChoferes);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Persona auxChofer = new Persona();

                    auxChofer.Dni = (int)datos.Lector["dni"];

                    auxChofer.Apellido = (string)datos.Lector["apellido"];
                    auxChofer.Nombres = (string)datos.Lector["nombres"];
                    auxChofer.Interno = (int)datos.Lector["interno"];
                    auxChofer.Viajes = (int)datos.Lector["viajes"];
                    auxChofer.Ingreso = (DateTime)datos.Lector["ingreso"];
                    auxChofer.Observaciones = (string)datos.Lector["Observaciones"].ToString(); // Puede llegar a devolver NULL.
                    int auxEmpresa = (int)datos.Lector["idEmpresa"]; // dispara error
                    auxChofer.Empresa = datos.buscarEmpresa(auxEmpresa);  // dispara error
                    
                    int auxPuesto = (int)datos.Lector["idPuesto"];
                    auxChofer.Tipo_Empleado = datos.buscarPuesto(auxPuesto);
                    auxChofer.Activo = (bool)datos.Lector["activo"];
                    auxChofer.OK_Adm = (bool)datos.Lector["okAdm"];
                    auxChofer.OK_Trafico = (bool)datos.Lector["okTrafico"];
                    /*
                    auxChofer.Promedio = (float)datos.Lector["promedio"]; // dispara el error
                    */
                    
                    listaChoferes.Add(auxChofer); 
                }

                return listaChoferes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<string> nombreChoferes()
        {
            List<string> listaChoferes = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaChoferes = "SELECT dni";
            string database = " FROM " + db_personas + ";";
            string queryChoferes = camposListaChoferes + database;


            try
            {
                datos.setearConsulta(queryChoferes);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int auxDni;
                    string auxChofer;

                    auxDni = (int)datos.Lector["dni"];
                    auxChofer = datos.buscarChofer(auxDni);

                    listaChoferes.Add(auxChofer);
                }

                return listaChoferes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Persona nvCh) 
        {
            AccesoDatos datos = new AccesoDatos();

            int idPuesto = datos.buscarIdPuesto(nvCh.Tipo_Empleado);
            int idEmpresa = datos.buscarIdEmpresa(nvCh.Empresa);

            try
            {
               //datos.setearConsulta("INSERT INTO cantarini_control.dbo.personas (dni, idPuesto, idEmpresa, interno, apellido, nombres, ingreso, Observaciones) VALUES (39345602, 0, 0, 0, 'CRAGNO', 'NICOLAS LAUTARO', convert(date, getdate()), 'PRUEBA');");
               datos.setearConsulta("INSERT INTO cantarini_control.dbo.personas (dni, idPuesto, idEmpresa, interno, apellido, nombres, ingreso, Observaciones) VALUES (" + nvCh.Dni + ", " + idPuesto + ", " + idEmpresa + ", " + nvCh.Interno + ", '" + nvCh.Apellido + "', '" + nvCh.Nombres + "', convert(date, getdate()), '" + nvCh.Observaciones + "');");
               datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void modificar(Persona mdCh) 
        {
            AccesoDatos datos = new AccesoDatos();

            int idPuesto = datos.buscarIdPuesto(mdCh.Tipo_Empleado);
            int idEmpresa = datos.buscarIdEmpresa(mdCh.Empresa);
            int activo = datos.numerarBool(mdCh.Activo);
            int okAdm = datos.numerarBool(mdCh.OK_Adm);
            int okTrafico = datos.numerarBool(mdCh.OK_Trafico);
            /*
            */

            try
            {
                datos.setearConsulta("UPDATE cantarini_control.dbo.personas SET idPuesto=" + idPuesto + ", idEmpresa= " + idEmpresa + ", interno= " + mdCh.Interno + ", apellido='" + mdCh.Apellido + "', nombres='" + mdCh.Nombres + "', Observaciones='" + mdCh.Observaciones + "', activo=" + activo + ", okAdm=" + okAdm + ", okTrafico=" + okTrafico + " WHERE dni=" + mdCh.Dni + ";");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally{ datos.cerrarConexion();}
        }
    }
}
