using Sistema_de_Ventas_y_Distribución.UserVentanas;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class frmCentral : Form
    {


        public frmCentral()
        {
            InitializeComponent();
            pnlGeneral.Controls.Clear();
            uscCompras obj_C = new uscCompras();
            obj_C.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_C);
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscCompras obj_C = new uscCompras();
            obj_C.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_C);
        }

        private void compraProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscCompra_Producto obj_CP = new uscCompra_Producto();
            obj_CP.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_CP);

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscMantenimientoProductos obj_IM = new uscMantenimientoProductos();
            obj_IM.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_IM);

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscMantenimientoProveedores obj_IP = new uscMantenimientoProveedores();
            obj_IP.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_IP);

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscMantenimientoClientes obj_MC = new uscMantenimientoClientes();
            obj_MC.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_MC);

        }
    }
}
