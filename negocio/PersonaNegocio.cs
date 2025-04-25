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
        public List<Persona> listarChoferes()
        {
            List<Persona> listaChoferes = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();

         

            string camposListaChoferes = "SELECT dni, apellido, nombres, idPuesto, idEmpresa, interno, Observaciones, activo, okAdm, okTrafico";
            string database = " FROM cantarini_control.dbo.personas;";
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
                    auxChofer.Tipo_Empleado = (int)datos.Lector["idPuesto"];
                    auxChofer.Empresa = (int)datos.Lector["idEmpresa"];
                    auxChofer.Interno = (int)datos.Lector["interno"];
                    auxChofer.OK_Adm = (bool)datos.Lector["okAdm"];
                    auxChofer.OK_Trafico = (bool)datos.Lector["okTrafico"];
                    auxChofer.Activo = (bool)datos.Lector["activo"];
                    auxChofer.Observaciones = (string)datos.Lector["Observaciones"].ToString(); // Puede llegar a devolver NULL.

                    /*

                    auxChofer.Ingreso = (DateTime)datos.Lector["ingreso"];
                    auxChofer.Viajes = (int)datos.Lector["viajes"];
                    auxChofer.Promedio = (float)datos.Lector["promedio"];
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

        public void agregar(Persona nuevoChofer)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // carga en db
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion();}
        }
    }
}
