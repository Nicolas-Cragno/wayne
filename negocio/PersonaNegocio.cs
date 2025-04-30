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

                    int auxPuesto = (int)datos.Lector["idPuesto"];
                    auxChofer.Tipo_Empleado = datos.buscarPuesto(auxPuesto);
                    auxChofer.Activo = (bool)datos.Lector["activo"];
                    auxChofer.OK_Adm = (bool)datos.Lector["okAdm"];
                    auxChofer.OK_Trafico = (bool)datos.Lector["okTrafico"];
                    /*
                    int auxEmpresa = (int)datos.Lector["idEmpresa"]; // dispara error
                    auxChofer.Empresa = datos.buscarEmpresa(auxEmpresa);  // dispara error
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

        public void agregar(Persona nvCh) { }

        public void modificar(Persona mdCh) { }
    }
}
