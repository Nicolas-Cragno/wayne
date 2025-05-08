using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace presentacion.Eventos
{
    public partial class FrmFichaEvento : Form
    {
        Evento evento = null;

        public FrmFichaEvento(Evento eventoSeleccionado)
        {
            InitializeComponent();
            evento = eventoSeleccionado;
        }

        private void FrmFichaEvento_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            if (evento != null)
            {
                tbxFichaEventoChofer.Text = evento.Persona;
                tbxFichaEventoInterno.Text = evento.Interno.ToString();
                tbxFichaEventoFecha.Text = evento.Fecha.ToString();
                tbxFichaEventoTipo.Text = evento.Tipo;
                tbxFichaEventoDetalle.Text = evento.Detalle;
            }
        }

        private void btnFichaEventoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFichaEventoEditar_Click(object sender, EventArgs e)
        {
            FrmModificarEvento ventana = new FrmModificarEvento(evento);
            ventana.ShowDialog();
            cargar();
        }
    }
}
