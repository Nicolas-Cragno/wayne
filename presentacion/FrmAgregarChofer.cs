using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            Persona nuevoChofer = new Persona();
            PersonaNegocio negocio = new PersonaNegocio(); 
            
            try
            {
                nuevoChofer.Dni = int.Parse(tbxAgregarChoferDNI.Text);
                nuevoChofer.Apellido = (string)tbxAgregarChoferApellido.Text.ToUpper();
                nuevoChofer.Nombres = (string)tbxAgregarChoferNombre.Text.ToUpper();
                nuevoChofer.Tipo_Empleado = (string)tbxAgregarChoferTipo.Text.ToUpper(); // es int (en la formula de agregar se pasa)
                nuevoChofer.Empresa = (string)tbxAgregarChoferEmpresa.Text.ToUpper(); // es int (en la formula de agregar se pasa)
                nuevoChofer.Interno = int.Parse(tbxAgregarChoferInterno.Text);
                nuevoChofer.Observaciones = (string)tbxAgregarChoferObservaciones.Text.ToUpper();
                // nuevoChofer.Ingreso = DateTime.Now; // la fecha la pido directamente en la consulta final

                negocio.agregar(nuevoChofer);
                MessageBox.Show("Chofer agregado.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
