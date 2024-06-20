using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVectores
{
    public partial class fmrNuevoVendedor : Form
    {
        public fmrNuevoVendedor()
        {
            InitializeComponent();
        }
        
        private void fmrNuevoVendedor_Load(object sender, EventArgs e)
        {
            cmdCargar.Enabled = false;
            txtNombre.Enabled = false;
            txtSueldo.Enabled = false;

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
      
                txtNombre.Enabled=true;
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtSueldo.Enabled=true;
           
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            cmdCargar.Enabled = true;
        }
    }
}
