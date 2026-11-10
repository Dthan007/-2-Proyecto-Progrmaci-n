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
            string nombreProveedor = txtNombre.Text;
            string nombreContacto = txtNomContacto.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            int estado = cmbEstado.SelectedIndex;

            var cliente = new WCFServicioProveedorReference.WCFServicioProveedorClient();

            try
            {
                var proveedor = new WCFServicioProveedorReference.Proveedor
                {
                    TipoTransaccion = tipoTransaccion,
                    IdJuridica = idJuridica,
                    NombreProveedor = nombreProveedor,
                    NombreContacto = nombreContacto,
                    Telefono = telefono,
                    Correo = correo,
                    Estado = estado
                };

                var respuesta = cliente.MantenimientoProveedor(proveedor);

                MessageBox.Show(
                    respuesta.Mensaje,
                    respuesta.Resultado ? "Operación exitosa" : "Error en la operación",
                    MessageBoxButtons.OK,
                    respuesta.Resultado
                        ? MessageBoxIcon.Information
                        : MessageBoxIcon.Error
                );

                if (respuesta.Resultado)
                {
                    LimpiarCampos();
                }

                cliente.Close();
            }
            catch (Exception ex)
            {
                cliente.Abort();

                MessageBox.Show(
                    "Ocurrió un error al procesar la solicitud: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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
