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
using negocio;

namespace presentacion.Eventos
{
    public partial class FrmEventos : Form
    {
        private List<Evento> listadoEventos;
        public FrmEventos()
        {
            InitializeComponent();
        }

        private void ocultarColumnas()
        {
            dgvEventos.Columns["Id_Evento"].Visible = false;
            dgvEventos.Columns["Detalle"].Visible = false;
           // dgvEventos.Columns[""].Visible = false;
        }
        private void FrmEventos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            EventoNegocio negocio = new EventoNegocio();
            listadoEventos = negocio.listarEventos();
            dgvEventos.DataSource = listadoEventos;
            ocultarColumnas();
        }

        private void filtrarEventos()
        {
            List<Evento> listaFiltrada;
            string filtro = tbxEventosFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoEventos.FindAll(ev => ev.Persona.ToString().Contains(filtro.ToUpper()) || ev.Interno.ToString().Contains(filtro.ToUpper()) || ev.Interno.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoEventos;
            }

            dgvEventos.DataSource = null;
            dgvEventos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento seleccion = (Evento)dgvEventos.CurrentRow.DataBoundItem;

            FrmFichaEvento evento = new FrmFichaEvento(seleccion);
            evento.ShowDialog();
            cargar();
        }

        private void btnEventosClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxEventosFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarEventos();
        }

        private void btnEventosNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEvento ventana = new FrmAgregarEvento();
            ventana.ShowDialog();
            cargar();
        }

        private void dgvEventos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento seleccion = (Evento)dgvEventos.CurrentRow.DataBoundItem;
            FrmFichaEvento evento = new FrmFichaEvento(seleccion);
            evento.ShowDialog();
            cargar();
        }
    }
    
}
