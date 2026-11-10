using Sistema_de_Ventas_y_Distribución.UserVentanas;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class frmCentral : Form
    {
        // 0 = Sin sesión, 1 = Administrador, 2 = Cliente
        private int tipoUsuarioActual = 0;

        public frmCentral()
        {
            InitializeComponent();

            // Ocultar todas las opciones del sistema
            OcultarMenu();

            // Mostrar únicamente Login
            loginToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Enabled = true;

            // Mostrar la pantalla de inicio de sesión
            pnlGeneral.Controls.Clear();

            uscLogin obj_L = new uscLogin();
            obj_L.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_L);
        }

        private void OcultarMenu()
        {
            comprasToolStripMenuItem.Visible = false;
            compraProveedorToolStripMenuItem.Visible = false;
            mantenimientoToolStripMenuItem.Visible = false;

            administradorToolStripMenuItem.Visible = false;
            administradorToolStripMenuItem.Enabled = false;

            cerrarSesiónToolStripMenuItem.Visible = false;
            cerrarSesiónToolStripMenuItem.Enabled = false;
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
            tipoUsuarioActual = 1;

            // Mostrar las opciones generales
            comprasToolStripMenuItem.Visible = true;
            compraProveedorToolStripMenuItem.Visible = true;
            mantenimientoToolStripMenuItem.Visible = true;

            // Mostrar opciones administrativas
            administradorToolStripMenuItem.Visible = true;
            administradorToolStripMenuItem.Enabled = true;

            // Ocultar Login
            loginToolStripMenuItem.Visible = false;
            loginToolStripMenuItem.Enabled = false;

            // Mostrar cerrar sesion
            cerrarSesiónToolStripMenuItem.Visible = true;
            cerrarSesiónToolStripMenuItem.Enabled = true;
        }

        public void inicioCliente()
        {
            tipoUsuarioActual = 2;

            // Mostrar unicamente las opciones permitidas al cliente
            comprasToolStripMenuItem.Visible = true;

            compraProveedorToolStripMenuItem.Visible = false;
            mantenimientoToolStripMenuItem.Visible = false;
            administradorToolStripMenuItem.Visible = false;

            // Ocultar Login
            loginToolStripMenuItem.Visible = false;
            loginToolStripMenuItem.Enabled = false;

            // Mostrar cerrar sesion
            cerrarSesiónToolStripMenuItem.Visible = true;
            cerrarSesiónToolStripMenuItem.Enabled = true;
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
            // Restablecer el tipo de usuario
            tipoUsuarioActual = 0;

            // Ocultar todas las opciones
            OcultarMenu();

            // Mostrar Login
            loginToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Enabled = true;

            // Mostrar la pantalla de inicio de sesión
            pnlGeneral.Controls.Clear();

            uscLogin obj_L = new uscLogin();
            obj_L.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_L);
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobar que el usuario sea administrador
            if (tipoUsuarioActual != 1)
            {
                MessageBox.Show(
                    "No tienes permisos para acceder a esta sección.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            pnlGeneral.Controls.Clear();

            uscRegistrarUsuario obj_RU = new uscRegistrarUsuario();
            obj_RU.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_RU);
        }

        private void modificarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobar que el usuario sea administrador
            if (tipoUsuarioActual != 1)
            {
                MessageBox.Show(
                    "No tienes permisos para acceder a esta sección.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            pnlGeneral.Controls.Clear();

            uscModificarEstado obj_ME = new uscModificarEstado();
            obj_ME.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_ME);
        }
    }
}
