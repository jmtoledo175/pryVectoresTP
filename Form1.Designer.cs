namespace pryVectores
{
    partial class fmrInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosDeUnVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.vendedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoVendedorToolStripMenuItem,
            this.listadoGeneralDeVendedoresToolStripMenuItem,
            this.consultaDeDatosDeUnVendedorToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // agregarNuevoVendedorToolStripMenuItem
            // 
            this.agregarNuevoVendedorToolStripMenuItem.Name = "agregarNuevoVendedorToolStripMenuItem";
            this.agregarNuevoVendedorToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.agregarNuevoVendedorToolStripMenuItem.Text = "Agregar nuevo vendedor...";
            this.agregarNuevoVendedorToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoVendedorToolStripMenuItem_Click);
            // 
            // listadoGeneralDeVendedoresToolStripMenuItem
            // 
            this.listadoGeneralDeVendedoresToolStripMenuItem.Name = "listadoGeneralDeVendedoresToolStripMenuItem";
            this.listadoGeneralDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.listadoGeneralDeVendedoresToolStripMenuItem.Text = "Listado general de vendedores...";
            this.listadoGeneralDeVendedoresToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDeVendedoresToolStripMenuItem_Click);
            // 
            // consultaDeDatosDeUnVendedorToolStripMenuItem
            // 
            this.consultaDeDatosDeUnVendedorToolStripMenuItem.Name = "consultaDeDatosDeUnVendedorToolStripMenuItem";
            this.consultaDeDatosDeUnVendedorToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.consultaDeDatosDeUnVendedorToolStripMenuItem.Text = "Consulta de datos de un vendedor...";
            this.consultaDeDatosDeUnVendedorToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosDeUnVendedorToolStripMenuItem_Click);
            // 
            // fmrInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralDeVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosDeUnVendedorToolStripMenuItem;
    }
}

