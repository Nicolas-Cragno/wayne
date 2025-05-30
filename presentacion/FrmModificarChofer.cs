﻿using System;
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
                PuestoNegocio puestoNegocio = new PuestoNegocio();
                EmpresaNegocio empresaNegocio = new EmpresaNegocio();
                TractorNegocio tractorNegocio = new TractorNegocio();

                lblModificarChoferTitulo.Text =  apellido + ", " + nombres;
                lblModificarChoferSubtitulo.Text = dni;
                tbxModificarChoferApellido.Text = apellido;
                tbxModificarChoferNombre.Text = nombres;
                tbxModificarChoferObservaciones.Text = chofer.Observaciones;
                cbxModificarChoferTipo.DataSource = puestoNegocio.listarPuestos();
                cbxModificarChoferEmpresa.DataSource = empresaNegocio.listarEmpresas();
                cbxModificarChoferInterno.DataSource = tractorNegocio.listarInternos();

                cbxModificarChoferInterno.Text = chofer.Interno.ToString();
                cbxModificarChoferTipo.Text = chofer.Tipo_Empleado.ToString();
                cbxModificarChoferEmpresa.Text = chofer.Empresa.ToString();


                cbxModificarChoferADM.Checked = chofer.OK_Adm; //bool
                cbxModificarChoferTrafico.Checked = chofer.OK_Trafico; //bool
                cbxModificarChoferActivo.Checked = chofer.Activo; //bool
                /*
                */

            }
        }

        private void btnModificarChofer_Click(object sender, EventArgs e)
        {
            Persona modifChofer = new Persona();
            PersonaNegocio negocio = new PersonaNegocio();

            try
            {
                modifChofer.Dni = int.Parse(lblModificarChoferSubtitulo.Text);
                modifChofer.Apellido = (string)tbxModificarChoferApellido.Text.ToUpper();
                modifChofer.Nombres = (string)tbxModificarChoferNombre.Text.ToUpper();
                modifChofer.Tipo_Empleado = (string)cbxModificarChoferTipo.Text.ToUpper(); // es int (en la formula de agregar se pasa)
                modifChofer.Empresa = (string)cbxModificarChoferEmpresa.Text.ToUpper(); // es int (en la formula de agregar se pasa)
                modifChofer.Interno = int.Parse(cbxModificarChoferInterno.Text);
                modifChofer.Observaciones = (string)tbxModificarChoferObservaciones.Text.ToUpper();
                modifChofer.Activo = cbxModificarChoferActivo.Checked;
                modifChofer.OK_Adm = cbxModificarChoferADM.Checked;
                modifChofer.OK_Trafico = cbxModificarChoferTrafico.Checked;
                
                /*
                */

                negocio.modificar(modifChofer);
                MessageBox.Show("Datos actualizados.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
