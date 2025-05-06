using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class FrmChoferes : Form
    {
        private List<Persona> listadoChoferes;
        public FrmChoferes()
        {
            InitializeComponent();
        }

        private void ocultarColumnas()
        {
            dgvChoferes.Columns["Tipo_Empleado"].Visible = false;
            dgvChoferes.Columns["Empresa"].Visible = false;
            dgvChoferes.Columns["Viajes"].Visible = false;
            dgvChoferes.Columns["Promedio"].Visible = false;
            dgvChoferes.Columns["Observaciones"].Visible = false;
            dgvChoferes.Columns["OK_Adm"].Visible = false;
            dgvChoferes.Columns["OK_Trafico"].Visible = false;
            dgvChoferes.Columns["Ingreso"].Visible = false;
            //dgvChoferes.Columns["activo"].Visible = false;
            dgvChoferes.Columns["Interno"].Visible = false;
        }

        private void FrmChoferes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        // Modificar datos del chofer seleccionado ↓↓
        private void dgvChoferes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona seleccion = (Persona)dgvChoferes.CurrentRow.DataBoundItem;


            FrmFichaChofer ficha = new FrmFichaChofer(seleccion);
            ficha.ShowDialog();
            //FrmModificarChofer modificar = new FrmModificarChofer(seleccion);
            //modificar.ShowDialog();
            cargar();
        }

        private void filtrarChoferes()
        {
            List<Persona> listaFiltrada;
            string filtro = tbxChoferesFiltro.Text;

            if (filtro != "")
            {
                // filtra por dni, apellido y/o nombres.
                listaFiltrada = listadoChoferes.FindAll(ev => ev.Dni.ToString().Contains(filtro.ToUpper()) || ev.Apellido.ToString().Contains(filtro.ToUpper()) || ev.Nombres.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                // si el filtro esta en blanco, devuelve la lista total
                listaFiltrada = listadoChoferes;
            }

            dgvChoferes.DataSource = null; // vaciarla primero para pisarla desp
            dgvChoferes.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            filtrarChoferes();
        }

        private void tbxChoferesFiltro_Enter(object sender, EventArgs e)
        {
            //filtrarChoferes();
        }

        private void cargar()
        {
            PersonaNegocio negocio = new PersonaNegocio();
            listadoChoferes = negocio.listarChoferes();
            dgvChoferes.DataSource = listadoChoferes;
            ocultarColumnas();
        }

        private void btnChoferesNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarChofer ventana = new FrmAgregarChofer();
            ventana.ShowDialog();
            cargar();

        }
        private void btnChoferesClose_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void tbxChoferesFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarChoferes();
        }

        private void tbxChoferesFiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
