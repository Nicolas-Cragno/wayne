using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PuestoNegocio
    {
        const string db_puestos = "cantarini_control.dbo.puestos";
        public List<string> listarPuestos()
        {
            List<string> listaPuestos = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaPuestos = "SELECT nombre";
            string database = " FROM " + db_puestos + ";";
            string queryPuestos = camposListaPuestos + database;


            try
            {
                datos.setearConsulta(queryPuestos);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    string auxPuesto;
                    auxPuesto = (string)datos.Lector["nombre"];

                    listaPuestos.Add(auxPuesto);
                }

                return listaPuestos;
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
    }
}
