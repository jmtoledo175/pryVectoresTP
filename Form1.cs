using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace pryVectores
{
    public partial class fmrInicial : Form
    {
        public fmrInicial()
        {
            InitializeComponent();
        }

        public struct RegistroVendedor
        {
            public Int32 Codigo;
            public string Nombre;
            public Decimal Sueldo;
        }

        public static RegistroVendedor[] Vendedor = new RegistroVendedor[100];
        public static Int32 IND = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrDatos fmrDatos = new fmrDatos();
            fmrDatos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrNuevoVendedor fmrNuevoVendedor = new fmrNuevoVendedor();
            fmrNuevoVendedor.ShowDialog();
        }
    }
}
