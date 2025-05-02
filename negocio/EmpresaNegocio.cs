using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EmpresaNegocio
    {
        const string db_empresas = "cantarini_control.dbo.empresas";

        public List<string> listarEmpresas()
        {
            List<string> listaEmpresas = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaEmpresas = "SELECT nombre";
            string databasse = " FROM " + db_empresas + ";";
            string queryEmpresas = camposListaEmpresas + databasse;

            try
            {
                datos.setearConsulta(queryEmpresas);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    string auxEmpresa;
                    auxEmpresa = (string)datos.Lector["nombre"];

                    listaEmpresas.Add(auxEmpresa);
                }

                return listaEmpresas;
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
