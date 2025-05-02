using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TractorNegocio
    {
        const string db_tractores = "cantarini_control.dbo.tractores";

        public List<Tractores> listarTractores()
        {
            List<Tractores> listaTractores = new List<Tractores>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaTractores = "SELECT interno, idEmpresa, idSat_Ub, idSat_Cb, dni, dominio, modelo, marca, activo, observaciones, okTaller, okAdm, okSat, okTrafico";
            string database = " FROM " + db_tractores + ";";
            string queryTractores = camposListaTractores + database;

            try
            {
                datos.setearConsulta(queryTractores);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tractores auxTractor = new Tractores();
                    auxTractor.Interno = (int)datos.Lector["interno"];
                    int auxEmpresa = (int)datos.Lector["idEmpresa"];
                    auxTractor.Empresa = datos.buscarEmpresa(auxEmpresa);
                    int auxSatUb = (int)datos.Lector["idSat_Ub"];
                    auxTractor.Satelital_Ubicacion = datos.buscarSatUb(auxSatUb);
                    int auxSatCb = (int)datos.Lector["idSat_Cb"];
                    auxTractor.Satelital_Combustible = datos.buscarSatCb(auxSatCb);
                    int auxChofer = (int)datos.Lector["dni"];
                    auxTractor.Chofer = datos.buscarChofer(auxChofer);
                    auxTractor.Dominio = (string)datos.Lector["dominio"];
                    auxTractor.Modelo = (string)datos.Lector["modelo"];
                    auxTractor.Marca = (string)datos.Lector["marca"];
                    auxTractor.Activo = (int)datos.Lector["activo"];
                    auxTractor.OK_Taller = (int)datos.Lector["okTaller"];
                    auxTractor.OK_Adm = (int)datos.Lector["okAdm"];
                    auxTractor.OK_Satelital = (int)datos.Lector["okSat"];
                    auxTractor.OK_Trafico = (int)datos.Lector["okTrafico"];
                
                    listaTractores.Add(auxTractor);
                }

                return listaTractores;
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
        //a
        public List<int> listarInternos()
        {
            List<int> listaInternos = new List<int>();
            AccesoDatos datos = new AccesoDatos();

            string campoListaInternos = "SELECT interno";
            string database = " FROM " + db_tractores + ";";
            string queryInternos = campoListaInternos + database;

            try
            {
                datos.setearConsulta(queryInternos);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int auxInterno;
                    auxInterno = (int)datos.Lector["interno"];

                    listaInternos.Add(auxInterno);
                }

                return listaInternos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }

        public void agregar(Tractores nvTr) { }

        public void modificar(Tractores mdTr) { }
    }
}
