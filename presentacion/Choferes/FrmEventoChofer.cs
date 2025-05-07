using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion.Choferes
{
    public partial class FrmEventoChofer : Form
    {
        Persona choferSeleccionado = null;
        public FrmEventoChofer(Persona chofer)
        {
            InitializeComponent();
            choferSeleccionado= chofer;
        }

        private void FrmEventoChofer_Load(object sender, EventArgs e)
        {
            TractorNegocio tractorNegocio = new TractorNegocio();

            try
            {
                cbxEventoChoferInterno.DataSource = tractorNegocio.listarInternos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEventoChofer_Click(object sender, EventArgs e)
        {
            Evento nuevoEvento = new Evento();
            EventoNegocio negocio = new EventoNegocio();
            string nombreChofer = choferSeleccionado.Apellido + ", " + choferSeleccionado.Nombres;
            AccesoDatos datos = new AccesoDatos();

            try
            {
                nuevoEvento.Persona = nombreChofer;
                nuevoEvento.Interno = int.Parse(cbxEventoChoferInterno.Text);
                nuevoEvento.Tipo = (string)tbxEventoChoferTipo.Text;
                nuevoEvento.Detalle = (string)tbxEventoChoferDetalle.Text;
                nuevoEvento.Fecha = DateTime.Now;

                negocio.agregarEvento(nuevoEvento);
                MessageBox.Show("Evento agregado.");

                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Evento duplicado");
                }
            }
        }
    }
}
