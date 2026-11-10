namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscCompra_Producto : UserControl
    {
        public uscCompra_Producto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int tipoTransaccion = cmbTransaccion.SelectedIndex;
            string ingreso = txtIngreso.Text;
            string compra_ = txtCompra.Text;
            string juridica = txtJuridica.Text;
            string noProducto = txtNoProducto.Text;
            string cantidad = txtCantidad.Text;

            var cliente = new WCFServicioCompraReference.WCFServicioCompraClient();

            try 
            {
                var compra = new WCFServicioCompraReference.Compra
                {
                    TipoTransaccion = tipoTransaccion,
                    Ingreso = ingreso,
                    Compra_ = compra_,
                    Juridica = juridica,
                    NoProducto = noProducto,
                    Cantidad = cantidad
                };
                    
                var respuesta = cliente.MantenimientoCompra(compra);

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
            cmbTransaccion.SelectedIndex = -1;
            txtIngreso.Clear();
            txtCompra.Clear();
            txtJuridica.Clear();
            txtNoProducto.Clear();
            txtCantidad.Clear();
        }
    }//uscCompra_Producto.
}//Sistema_de_Ventas_y_Distribución.UserVentanas.
