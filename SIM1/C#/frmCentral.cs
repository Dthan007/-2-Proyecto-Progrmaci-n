using Sistema_de_Ventas_y_Distribución.UserVentanas;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscLogin obj_L = new uscLogin();
            obj_L.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_L);

        }

        public void inicioAdmin()
        {
            loginToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Visible = false;

            administradorToolStripMenuItem.Enabled = true;
            administradorToolStripMenuItem.Visible = true;

            cerrarSesiónToolStripMenuItem.Enabled = true;
            cerrarSesiónToolStripMenuItem.Visible = true;
        }

        public void inicioCliente()
        {
            loginToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Visible = false;

            administradorToolStripMenuItem.Enabled = false;
            administradorToolStripMenuItem.Visible = false;

            cerrarSesiónToolStripMenuItem.Enabled = true;
            cerrarSesiónToolStripMenuItem.Visible = true;
        }

        public void mostrarpantalla()
        {
            pnlGeneral.Controls.Clear();
            uscCompras obj_CP = new uscCompras();
            obj_CP.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_CP);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscLogin obj_L = new uscLogin();
            obj_L.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_L);

            loginToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Visible = true;

            administradorToolStripMenuItem.Enabled = false;
            administradorToolStripMenuItem.Visible = false;

            cerrarSesiónToolStripMenuItem.Enabled = false;
            cerrarSesiónToolStripMenuItem.Visible = false;
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscRegistrarUsuario obj_RU = new uscRegistrarUsuario();
            obj_RU.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_RU);

        }

        private void modificarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscModificarEstado obj_ME = new uscModificarEstado();
            obj_ME.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_ME);

        }
    }
}
