using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ServicioVerificador;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscMantenimientoClientes : UserControl
    {

        public uscMantenimientoClientes()
        {
            InitializeComponent();
        }

        private void uscMantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (cmbTipoTransaccion.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de transaccion.");
                return;
            }

            var tipoSeleccionado = cmbTipoTransaccion.SelectedItem.ToString();
            var tipoTransaccion = tipoSeleccionado switch
            {
                "Agregar" => "agregar",
                "Modificar" => "modificar",
                "Borrar" => "borrar",
                _ => ""
            };

            var solicitud = new SolicitudCliente
            {
                TipoTransaccion = tipoTransaccion,
                Identificacion = txtIdentificacion.Text,
                PaisOrigen = txtPaisOrigen.Text,
                Nombre = txtNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Telefono = txtTelefono.Text,
                CorreoElectronico = txtCorreo.Text,
                Direccion = txtDireccion.Text  
            };

            var respuesta = ClienteVerificador.MantenimientoCliente(solicitud);

            lblResultado.Text = respuesta.Mensaje;
        }
    }
}
