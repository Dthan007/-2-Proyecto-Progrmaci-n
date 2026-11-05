namespace Sistema_de_Ventas_y_Distribución
{
    partial class frmCentral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mspGeneral = new MenuStrip();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            compraProveedorToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pnlGeneral = new Panel();
            mspGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // mspGeneral
            // 
            mspGeneral.Items.AddRange(new ToolStripItem[] { comprasToolStripMenuItem, compraProveedorToolStripMenuItem, mantenimientoToolStripMenuItem });
            mspGeneral.Location = new Point(0, 0);
            mspGeneral.Name = "mspGeneral";
            mspGeneral.Size = new Size(844, 24);
            mspGeneral.TabIndex = 0;
            mspGeneral.Text = "menuStrip1";
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(113, 20);
            comprasToolStripMenuItem.Text = "Registro Compras";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // compraProveedorToolStripMenuItem
            // 
            compraProveedorToolStripMenuItem.Name = "compraProveedorToolStripMenuItem";
            compraProveedorToolStripMenuItem.Size = new Size(114, 20);
            compraProveedorToolStripMenuItem.Text = "Compra Producto";
            compraProveedorToolStripMenuItem.Click += compraProveedorToolStripMenuItem_Click;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, proveedoresToolStripMenuItem, clientesToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // pnlGeneral
            // 
            pnlGeneral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGeneral.Location = new Point(0, 27);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(844, 463);
            pnlGeneral.TabIndex = 0;
            // 
            // frmCentral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 490);
            Controls.Add(pnlGeneral);
            Controls.Add(mspGeneral);
            MainMenuStrip = mspGeneral;
            Name = "frmCentral";
            Text = "Nova Online";
            mspGeneral.ResumeLayout(false);
            mspGeneral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mspGeneral;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private Panel pnlGeneral;
        private ToolStripMenuItem compraProveedorToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
    }
}
