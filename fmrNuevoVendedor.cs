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
        public struct RegistroVendedor
        {
            public Int32 Codigo;
            public string Nombre;
            public Decimal Sueldo;
        }
        public static class DatosVendedores
        {
            public static RegistroVendedor[] Vendedor = new RegistroVendedor[100];
            public static Int32 IND = 0;
        }
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            
            if(DatosVendedores.IND < 100)
            {
                Int32 Codigo = Convert.ToInt32(txtCodigo.Text);
                string Nombre = txtNombre.Text;
                Decimal Sueldo = Convert.ToDecimal(txtSueldo.Text);
                RegistroVendedor nuevoVendedor = new RegistroVendedor
                {
                    Codigo = Codigo,
                    Nombre = Nombre,
                    Sueldo = Sueldo
                };

                DatosVendedores.Vendedor[DatosVendedores.IND]= nuevoVendedor;
                DatosVendedores.IND++;
                MessageBox.Show("Vendedor agregado con exito");
                txtCodigo.Clear();
                txtNombre.Clear();
                txtSueldo.Clear();
            }
            else
            {
                MessageBox.Show("No se puede agregar al vendedor, vector lleno");
            }
        }
    }
}
