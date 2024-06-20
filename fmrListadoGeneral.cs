using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVectores
{
    public partial class fmrListadoGeneral : Form
    {
        public fmrListadoGeneral()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            
            dgvListado.Rows.Clear();
            Decimal SueldosTotal = 0;
            int Cantidad = 0;
            for (int i = 0; i < fmrNuevoVendedor.DatosVendedores.IND; i++)
            {
                var vendedor = fmrNuevoVendedor.DatosVendedores.Vendedor[i];
                dgvListado.Rows.Add(vendedor.Codigo, vendedor.Nombre, vendedor.Sueldo);
                SueldosTotal = SueldosTotal + vendedor.Sueldo;
                lblTotal.Text = SueldosTotal.ToString();
                Cantidad++;
                lblCantidadVendedores.Text = Cantidad.ToString();

            }
           
           
            
        }

        private void fmrListadoGeneral_Load(object sender, EventArgs e)
        {

        }
    }
}
