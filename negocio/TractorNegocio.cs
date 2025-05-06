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

        public List<Tractor> listarTractores()
        {
            List<Tractor> listaTractores = new List<Tractor>();
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
                    Tractor auxTractor = new Tractor();

                    auxTractor.Interno = (int)datos.Lector["interno"];
                    int auxEmpresa = (int)datos.Lector["idEmpresa"];
                    auxTractor.Empresa = datos.buscarEmpresa(auxEmpresa);
                    auxTractor.Dominio = (string)datos.Lector["dominio"];
                    auxTractor.Modelo = (string)datos.Lector["modelo"].ToString();
                    auxTractor.Marca = (string)datos.Lector["marca"].ToString();
                    auxTractor.Activo = (bool)datos.Lector["activo"];
                    auxTractor.Observaciones = (string)datos.Lector["observaciones"].ToString();
                    auxTractor.OK_Taller = (bool)datos.Lector["okTaller"];
                    auxTractor.OK_Adm = (bool)datos.Lector["okAdm"];
                    auxTractor.OK_Satelital = (bool)datos.Lector["okSat"];
                    auxTractor.OK_Trafico = (bool)datos.Lector["okTrafico"];
                    auxTractor.Dni_Chofer = (int)datos.Lector["dni"];
                    if (!(datos.Lector["dni"] is DBNull))
                    {
                        int auxDni = (int)datos.Lector["dni"];
                        auxTractor.Chofer = datos.buscarChofer(auxDni);
                    }
                    int auxSatUb = (int)datos.Lector["idSat_Ub"];
                    auxTractor.Satelital_Ubicacion = datos.buscarSatUb(auxSatUb);
                    int auxSatCb = (int)datos.Lector["idSat_Cb"];
                    auxTractor.Satelital_Combustible = datos.buscarSatCb(auxSatCb);



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

        public void agregar(Tractor nvTr) { }

        public void modificar(Tractor mdTr) 
        {
            /*
             
            AccesoDatos datos = new AccesoDatos();
            int idEmpresa = datos.buscarIdEmpresa(mdTr.Empresa);
            int idSatUb = datos.buscarIdSatUb(mdTr.Satelital_Ubicacion);
            int idSatCb = datos.buscarIdSatCb(mdTr.Satelital_Combustible);
            int dni = datos.buscarDni(mdTr.Chofer);


            try
            {
                datos.setearConsulta("UPDATE cantarini_control.dbo.tractores SET idEmpresa=" + mdTr.Empresa + ", idSat_Ub=0, idSat_Cb=0, dni=NULL, dominio='#S/A', modelo='', marca='', activo=0, observaciones='', okTaller=0, okAdm=0, okSat=0, okTrafico=0 WHERE interno=0;\r\n");
            }
            */
        }
    }
}
