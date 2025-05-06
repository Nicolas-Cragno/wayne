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

namespace presentacion.Tractores
{
    public partial class FrmTractores : Form
    {
        public List<Tractor> listadoTractores;

        public FrmTractores()
        {
            InitializeComponent();
        }

        private void ocultarColumnas()
        {
            
            dgvTractores.Columns["Empresa"].Visible = false;
            dgvTractores.Columns["Satelital_Ubicacion"].Visible = false;
            dgvTractores.Columns["Satelital_Combustible"].Visible = false;
            //dgvTractores.Columns["Chofer"].Visible = false;
            //dgvTractores.Columns["Dominio"].Visible = false;
            dgvTractores.Columns["Modelo"].Visible = false;
            dgvTractores.Columns["Marca"].Visible = false;
            dgvTractores.Columns["Observaciones"].Visible = false;
            dgvTractores.Columns["OK_Taller"].Visible = false;
            dgvTractores.Columns["OK_Adm"].Visible = false;
            dgvTractores.Columns["OK_Satelital"].Visible = false;
            dgvTractores.Columns["OK_Trafico"].Visible = false;
        }

        private void FrmTractores_Load(object sender, EventArgs e)
        {
            TractorNegocio negocio = new TractorNegocio();
            listadoTractores = negocio.listarTractores();
            dgvTractores.DataSource = listadoTractores;
            ocultarColumnas();
        }

        // modificar (buscsar accion en dgv)

        private void filtrarTractores()
        {
            List<Tractor> listaFiltrada;
            string filtro = tbxTractoresFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoTractores.FindAll(ev => ev.Interno.ToString().Contains(filtro.ToUpper()) || ev.Dominio.ToString().Contains(filtro.ToUpper()));
            } else
            {
                listaFiltrada = listadoTractores;
            }

            dgvTractores.DataSource = null;
            dgvTractores.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void dgvTractores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tractor seleccion = (Tractor)dgvTractores.CurrentRow.DataBoundItem;

            FrmModificarTractor modificar = new FrmModificarTractor(seleccion);
            modificar.Show();
        }

        private void btnTractoresNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
