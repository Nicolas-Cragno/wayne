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
            dgvChoferes.Columns["Interno"].Visible = false;
            dgvChoferes.Columns["Viajes"].Visible = false;
            dgvChoferes.Columns["Promedio"].Visible = false;
            dgvChoferes.Columns["Observaciones"].Visible = false;
            dgvChoferes.Columns["OK_Adm"].Visible = false;
            dgvChoferes.Columns["OK_Trafico"].Visible = false;
            dgvChoferes.Columns["Ingreso"].Visible = false;
        }

        private void FrmChoferes_Load(object sender, EventArgs e)
        {
            PersonaNegocio negocio = new PersonaNegocio();
            listadoChoferes = negocio.listarChoferes();
            dgvChoferes.DataSource = listadoChoferes;
            ocultarColumnas();
        }

        private void dgvChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        // Modificar datos del chofer seleccionado ↓↓
        private void dgvChoferes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona seleccion = (Persona)dgvChoferes.CurrentRow.DataBoundItem;

            FrmModificarChofer modificar = new FrmModificarChofer(seleccion);
            modificar.Show();
        }
    }
}
