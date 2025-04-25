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

namespace presentacion
{
    public partial class FrmModificarChofer : Form
    {
        private Persona chofer = null;
        public FrmModificarChofer(Persona choferSeleccionado)
        {
            InitializeComponent();
            this.chofer = choferSeleccionado; // tomamos el chofer que nos trae la selección
        }

        private void FrmModificarChofer_Load(object sender, EventArgs e)
        {
            if (chofer != null)
            {
                string dni = chofer.Dni.ToString();
                string apellido = chofer.Apellido;
                string nombres = chofer.Nombres;

                lblModificarChoferTitulo.Text = dni + " - " + apellido + ", " + nombres;
                tbxModificarChoferApellido.Text = apellido;
                tbxModificarChoferNombre.Text = nombres;
                tbxModificarChoferTipo.Text = chofer.Tipo_Empleado.ToString();
                tbxModificarChoferEmpresa.Text = chofer.Empresa.ToString();
                tbxModificarChoferInterno.Text = chofer.Interno.ToString();
                tbxModificarChoferObservaciones.Text = chofer.Observaciones;
                cbxModificarChoferADM.Checked = chofer.OK_Adm;
                cbxModificarChoferTrafico.Checked = chofer.OK_Trafico;
                cbxModificarChoferActivo.Checked = chofer.Activo;
                
            } 
        }
    }
}
