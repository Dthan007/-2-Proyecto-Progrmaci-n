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
            string trama =
                "PRODUCTO|" +
                cmbTipoTransaccion.SelectedIndex + "|" +
                txtNoProducto.Text + "|" +
                txtNombre.Text + "|" +
                txtPrecio.Text;

            BLL.EnviarConsulta productoBLL = new BLL.EnviarConsulta();
            string respuesta = productoBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);

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