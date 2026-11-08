using System.Globalization;

namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscMantenimientoProveedores : UserControl
    {
        public uscMantenimientoProveedores()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int tipoTransaccion = cmbTipoTransaccion.SelectedIndex;
            string idJuridica = txtIDjuridica.Text;
            string nombreproveedor = txtNombre.Text;
            string nombreContacto = txtNomContacto.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            int estado = cmbEstado.SelectedIndex;

            BLL.ProveedorServiceBLL proveedorBLL = new BLL.ProveedorServiceBLL();

            var respuesta = proveedorBLL.MantenimientoProveedores(
                tipoTransaccion,
                idJuridica,
                nombreproveedor,
                nombreContacto,
                telefono,
                correo,
                estado
            );
            MessageBox.Show(
                respuesta.Mensaje,
                "Respuesta del Servidor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txtIDjuridica.Clear();
            txtNombre.Clear();
            txtNomContacto.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbTipoTransaccion.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }
    }//uscMantenimientoProveedores.
}//System_de_Ventas_y_Distribución.UserVentanas
