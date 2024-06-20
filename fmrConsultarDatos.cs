using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryVectores.fmrNuevoVendedor;

namespace pryVectores
{
    public partial class fmrConsultarDatos : Form
    {
        public fmrConsultarDatos()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 i = 0;
            Decimal Sueldo = 0;
            Int32 Codigo = 0;
            for (i = cmbVendedores.SelectedIndex; i < fmrNuevoVendedor.DatosVendedores.IND; i++)
            {
                var vendedor = fmrNuevoVendedor.DatosVendedores.Vendedor[i];
                Sueldo = vendedor.Sueldo;
                lblSueldo.Text = Convert.ToString(Sueldo);
                Codigo = vendedor.Codigo;
                lblCodigoResultado.Text = Convert.ToString(Codigo);
            }


        }

        private void fmrConsultarDatos_Load(object sender, EventArgs e)
        {
            cmbVendedores.Items.Clear();
            for (int i = 0; i < fmrNuevoVendedor.DatosVendedores.IND; i++)
            {
                var vendedor = fmrNuevoVendedor.DatosVendedores.Vendedor[i];
                cmbVendedores.Items.Add(vendedor.Nombre);
            }

            if (cmbVendedores.Items.Count > 0)
            {
                cmbVendedores.SelectedIndex = 0;
            }
        }
    }
}
