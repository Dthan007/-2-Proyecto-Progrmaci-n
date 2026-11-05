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
            string trama =
                "COMPRA|" +
                cmbTransaccion.SelectedIndex + "|" +
                txtIngreso.Text + "|" +
                txtCompra.Text + "|" +
                txtJuridica.Text + "|" +
                txtNoProducto.Text + "|" +
                txtCantidad.Text;

            BLL.EnviarConsulta compraProveedorBLL = new BLL.EnviarConsulta();
            string respuesta = compraProveedorBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
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
