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
using presentacion.Choferes;
using presentacion.Eventos;

namespace presentacion
{
    public partial class FrmFichaChofer : Form
    {
        private Persona chofer = null;
        private int dniSeleccionado;
        public List<Evento> listadoEventosChofer;
        public FrmFichaChofer(Persona choferSeleccionado)
        {
            InitializeComponent();
            this.chofer = choferSeleccionado;
            dniSeleccionado = choferSeleccionado.Dni;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFichaChofer_Load(object sender, EventArgs e)
        {

        }

        private void FrmFichaChofer_Load_1(object sender, EventArgs e)
        {
            cargar();
            cargarEventos();
        }

        private void cargar()
        {
            if (chofer != null)
            {
                string dni = chofer.Dni.ToString();
                string apellido = chofer.Apellido;
                string nombres = chofer.Nombres;
                bool estado = chofer.Activo;
                PuestoNegocio puestoNegocio = new PuestoNegocio();
                EmpresaNegocio empresaNegocio = new EmpresaNegocio();
                TractorNegocio tractorNegocio = new TractorNegocio();

                if (estado)
                {
                    tbxFichaChoferEstado.Text = "Activo";
                }
                else
                {
                    tbxFichaChoferEstado.Text = "Inactivo";
                }

                lblFichaChoferTitulo.Text = apellido + ", " + nombres;
                tbxFichaChoferDNI.Text = dni;
                tbxFichaChoferEmpresa.Text = chofer.Empresa;
                tbxFichaChoferTipo.Text = chofer.Tipo_Empleado;
                tbxFichaChoferInterno.Text = chofer.Interno.ToString();
                tbxFichaChoferViajes.Text = chofer.Viajes.ToString();
                tbxFichaChoferPromedio.Text = chofer.Promedio.ToString();
                tbxFichaChoferObservaciones.Text = chofer.Observaciones;          
            }
        }

        private void ocultarColumnasEventos()
        {
            dgvFichaChoferEvento.Columns["Id_Evento"].Visible = false;
            dgvFichaChoferEvento.Columns["Persona"].Visible = false;
            dgvFichaChoferEvento.Columns["Interno"].Visible = false;
        }

        private void filtrarEventos()
        {
            List<Evento> listaFiltrada;
            string filtro = tbxFichaChoferEventoFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoEventosChofer.FindAll(ev => ev.Tipo.ToString().Contains(filtro.ToUpper()) || ev.Detalle.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoEventosChofer;
            }

            dgvFichaChoferEvento.DataSource = null;
            dgvFichaChoferEvento.DataSource = listaFiltrada;
            ocultarColumnasEventos();
        }

        private void cargarEventos()
        {
            EventoNegocio negocio = new EventoNegocio();
            listadoEventosChofer = negocio.listarEventosChofer(dniSeleccionado);
            dgvFichaChoferEvento.DataSource = listadoEventosChofer;
            
            ocultarColumnasEventos();
        }

        private void btnFichaChoferEditar_Click(object sender, EventArgs e)
        {
            FrmModificarChofer modificar = new FrmModificarChofer(chofer);
            modificar.ShowDialog();
            Close();
        }

        private void dgvFichaChoferEvento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmFichaChofer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxFichaChoferEventoFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarEventos();
        }

        private void btnAgregarFichaChoferEvento_Click(object sender, EventArgs e)
        {
            FrmEventoChofer ventana = new FrmEventoChofer(chofer);
            ventana.ShowDialog();
            cargar();
        }

        private void dgvFichaChoferEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento seleccion = (Evento)dgvFichaChoferEvento.CurrentRow.DataBoundItem;

            FrmFichaEvento evento = new FrmFichaEvento(seleccion);
            evento.ShowDialog();
            cargar();
        }

        private void btbFichaChoferCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
