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
            string trama =
                "PROVEEDOR|" +
                cmbTipoTransaccion.SelectedIndex + "|" +
                txtIDjuridica.Text + "|" +
                txtNombre.Text + "|" +
                txtNomContacto.Text + "|" +
                txtTelefono.Text + "|" +
                txtCorreo.Text + "|" +
                cmbEstado.SelectedIndex;

            BLL.EnviarConsulta proveedorBLL = new BLL.EnviarConsulta();
            string respuesta = proveedorBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
