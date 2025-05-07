using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class EventoNegocio
    {
        const string db_eventos = "cantarini_control.dbo.eventos";

        public List<Evento> listarEventos()
        {
            List<Evento> listaEventos = new List<Evento>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaEventos = "SELECT idEvento, dni, interno, tipo, detalle, fecha ";
            string database = "FROM " + db_eventos + ";";
            string queryEventos = camposListaEventos + database;

            try{
                datos.setearConsulta(queryEventos);
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Evento auxEvento = new Evento();
                    int auxDni = (int)datos.Lector["dni"];

                    auxEvento.Id_Evento = (int)datos.Lector["idEvento"];
                    auxEvento.Persona = datos.buscarChofer(auxDni);
                    auxEvento.Interno = (int)datos.Lector["interno"];
                    auxEvento.Tipo = (string)datos.Lector["tipo"];
                    auxEvento.Detalle = (string)datos.Lector["detalle"];
                    auxEvento.Fecha = (DateTime)datos.Lector["fecha"];

                    listaEventos.Add(auxEvento);
                }

                return listaEventos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

               
        }

        public List<Evento> listarEventosChofer(int dni)
        {
            List<Evento> listaEventosChofer = new List<Evento>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaEventosChofer = "SELECT IdEvento, dni, interno, tipo, detalle, fecha";
            string database = " FROM " + db_eventos;
            string parametro = " WHERE dni=" + dni + ";";
            string queryEventosChofer = camposListaEventosChofer + database + parametro;

            try
            {
                datos.setearConsulta(queryEventosChofer);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Evento auxEvento = new Evento();
                    int auxDni = (int)datos.Lector["dni"];

                    auxEvento.Id_Evento = (int)datos.Lector["IdEvento"];
                    auxEvento.Persona = datos.buscarChofer(auxDni);
                    auxEvento.Interno = (int)datos.Lector["interno"];
                    auxEvento.Tipo = (string)datos.Lector["tipo"];
                    auxEvento.Detalle = (string)datos.Lector["detalle"];
                    auxEvento.Fecha = (DateTime)datos.Lector["fecha"];

                    listaEventosChofer.Add(auxEvento);
                }

                return listaEventosChofer;
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

        public void agregarEvento(Evento nvEv)
        {
            AccesoDatos datos = new AccesoDatos();

            int dni = datos.buscarDniFull(nvEv.Persona);

            try
            {
                datos.setearConsulta("INSERT INTO cantarini_control.dbo.eventos (dni, interno, tipo, detalle, fecha) VALUES (" + dni + ", " + nvEv.Interno + ", '" + nvEv.Tipo + "', '" + nvEv.Detalle + "', convert(date, getdate()));");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Evento> listarEventosTractor(int interno)
        {
            List<Evento> listaEventosTractor = new List<Evento>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaEventosTractor = "select IdEvento, dni, interno, tipo, detalle, fecha";
            string database = "FROM " + db_eventos + " ";
            string parametro = "WHERE interno=" + interno + ";";
            string queryEventosTractor = camposListaEventosTractor + database;

            try
            {
                datos.setearConsulta(queryEventosTractor);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Evento auxEvento = new Evento();
                    int auxDni = (int)datos.Lector["dni"];

                    auxEvento.Id_Evento = (int)datos.Lector["IdEvento"];
                    auxEvento.Persona = datos.buscarChofer(auxDni);
                    auxEvento.Interno = (int)datos.Lector["interno"];
                    auxEvento.Tipo = (string)datos.Lector["tipo"];
                    auxEvento.Detalle = (string)datos.Lector["detalle"];
                    auxEvento.Fecha = (DateTime)datos.Lector["fecha"];

                    listaEventosTractor.Add(auxEvento);
                }

                return listaEventosTractor;
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
