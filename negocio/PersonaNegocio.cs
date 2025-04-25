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
                    auxChofer.Interno = (int)datos.Lector["interno"];
                    auxChofer.OK_Adm = (bool)datos.Lector["okAdm"];
                    auxChofer.OK_Trafico = (bool)datos.Lector["okTrafico"];
                    auxChofer.Activo = (bool)datos.Lector["activo"];
                    auxChofer.Observaciones = (string)datos.Lector["Observaciones"].ToString(); // Puede llegar a devolver NULL.
                    int auxPuesto = (int)datos.Lector["idPuesto"];
                    auxChofer.Tipo_Empleado = datos.buscarPuesto(auxPuesto);
                    int auxEmpresa = (int)datos.Lector["idEmpresa"];
                    // auxChofer.Empresa = datos.buscarEmpresa(auxEmpresa); // al tener 3 accesos (principal, buscador de puesto y este) tarda mucho y se corta la conexion

                    switch (auxEmpresa)
                    {
                        case 0: auxChofer.Empresa = "";
                            break;
                        case 1: auxChofer.Empresa = "Transportes Cantarini";
                            break;
                        case 2: auxChofer.Empresa = "Transamerica Transportes";
                            break;
                        case 3: auxChofer.Empresa = "Expreso Cantarini";
                            break;
                        default: auxChofer.Empresa = "";
                            break;
                    }

                    /*
                    //int auxEmpresa = (int)datos.Lector["idEmpresa"];

                    string queryPuesto = "SELECT nombre FROM puestos WHERE idPuesto = " + auxPuesto + ";";
                    datos.setearConsulta(queryPuesto);
                    datos.ejecutarLectura();
                    auxChofer.Tipo_Empleado = (string)datos.Lector["nombre"];

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
