using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            FrmChoferes ventana = new FrmChoferes();
            ventana.ShowDialog();
        }
    }
}
