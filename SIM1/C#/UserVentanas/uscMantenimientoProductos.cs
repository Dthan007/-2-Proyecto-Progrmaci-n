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
            
            BLL.AlmacenServiceBLL productoBLL = new BLL.AlmacenServiceBLL();

            var respuesta = productoBLL.MantenimientoProducto(
                tipoTransaccion,
                numeroProducto,
                nombreProducto,
                precio
            );

            MessageBox.Show(
                respuesta.Mensaje,
                "Respuesta del Servidor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            LimpiarCampos();
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