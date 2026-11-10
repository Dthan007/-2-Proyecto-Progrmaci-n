using System.Globalization;


namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscMantenimientoProductos : UserControl
    {
        public uscMantenimientoProductos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int tipoTransaccion = cmbTipoTransaccion.SelectedIndex;
            string numeroProducto = txtNoProducto.Text;
            string nombreProducto = txtNombre.Text;

            if (!double.TryParse(
                txtPrecio.Text,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out double precio))
            {
                MessageBox.Show("El precio no es válido.");
                return;
            }

            var cliente = new WCFServicioProductoReference.WCFServicioProductoClient();

            try
            {
                var producto = new WCFServicioProductoReference.Producto
                {
                    TipoTransaccion = tipoTransaccion,
                    NumeroProducto = numeroProducto,
                    NombreProducto = nombreProducto,
                    Precio = precio
                };

                var respuesta = cliente.MantenimientoProducto(producto);

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
                    "Error al comunicarse con el servicio WCF: " + ex.Message,
                    "Error de comunicación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }//btnAceptar_Click().

        public void LimpiarCampos()
        {
            txtNoProducto.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbTipoTransaccion.SelectedIndex = 0;
        }//LimpiarCampos().
    }//uscIngreso_Mantenimiento.
}//Sistema_de_Ventas_y_Distribución. 