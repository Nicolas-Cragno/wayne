using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class FrmAgregarChofer : Form
    {
        public FrmAgregarChofer()
        {
            InitializeComponent();
        }

        private void FrmAgregarChofer_Load(object sender, EventArgs e)
        {
            PuestoNegocio puestoNegocio = new PuestoNegocio();
            EmpresaNegocio empresaNegocio = new EmpresaNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();

            try
            {
                cbxAgregarChoferTipo.DataSource = puestoNegocio.listarPuestos();
                cbxAgregarChoferEmpresa.DataSource = empresaNegocio.listarEmpresas();
                cbxAgregarChoferInterno.DataSource = tractorNegocio.listarInternos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            Persona nuevoChofer = new Persona();
            PersonaNegocio negocio = new PersonaNegocio(); 
            Evento evento = new Evento();
            EventoNegocio eventoNegocio = new EventoNegocio();
            AccesoDatos datos = new AccesoDatos();
            int idEmpresa;
            
            try
            {
                nuevoChofer.Dni = int.Parse(tbxAgregarChoferDNI.Text);
                nuevoChofer.Apellido = (string)tbxAgregarChoferApellido.Text.ToUpper();
                nuevoChofer.Nombres = (string)tbxAgregarChoferNombre.Text.ToUpper();
                nuevoChofer.Tipo_Empleado = (string)cbxAgregarChoferTipo.Text.ToUpper(); // es int (en la formula de agregar se pasa)
                nuevoChofer.Empresa = (string)cbxAgregarChoferEmpresa.Text.ToUpper(); // es int (en la formula de agregar se pasa)
                nuevoChofer.Interno = int.Parse(cbxAgregarChoferInterno.Text);
                nuevoChofer.Observaciones = (string)tbxAgregarChoferObservaciones.Text.ToUpper();
                // nuevoChofer.Ingreso = DateTime.Now; // la fecha la pido directamente en la consulta final

                negocio.agregar(nuevoChofer);
                MessageBox.Show("Chofer agregado.");

                // Registrar como evento ↓↓
                idEmpresa = datos.buscarIdEmpresa(nuevoChofer.Empresa);
                string empresa = datos.buscarEmpresaAbreviada(idEmpresa);
                evento.Dni = nuevoChofer.Dni;
                evento.Interno = nuevoChofer.Interno;
                evento.Tipo = "ALTA CHOFER " + empresa;
                evento.Detalle = "CHOFER DADO DE ALTA POR SISTEMA.";
                eventoNegocio.registrarEvento(evento);

                Close();

                
            }
            catch (SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    MessageBox.Show("El chofer ingresado ya existe.");
                }
            }
        }

        public void tbxAgregarChoferTipo_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void cbxAgregarChoferTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarChoferTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxAgregarChoferEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarChoferEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxAgregarChoferInterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarChoferInterno.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarChoferCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
