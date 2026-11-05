using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscMantenimientoClientes : UserControl
    {
        private readonly string ipVerificador = "127.0.0.1";
        private readonly int puertoVerificador = 6000;

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

            var trama = new
            {
                tipo_transaccion = tipoTransaccion,
                identificacion = txtIdentificacion.Text,
                pais_origen = txtPaisOrigen.Text,
                nombre = txtNombre.Text,
                primer_apellido = txtPrimerApellido.Text,
                segundo_apellido = txtSegundoApellido.Text,
                telefono = txtTelefono.Text,
                correo_electronico = txtCorreo.Text,
                direccion = txtDireccion.Text,
            };

            var tramaJson = JsonSerializer.Serialize(trama);

            var conexion = new BLL.ConexionSocket(ipVerificador, puertoVerificador);

            if (!conexion.Conectar())
            {
                return;
            }

            var respuestaJson = conexion.EnviarYRecibir(tramaJson);
            conexion.Desconectar();

            lblResultado.Text = InterpretarRespuesta(respuestaJson);
        }

        private string InterpretarRespuesta(string respuestaJson)
        {
            if (respuestaJson == null)
            {
                return "Sin respuesta del servidor.";
            }

            using var documento = JsonDocument.Parse(respuestaJson);
            var status = documento.RootElement.GetProperty("status").GetString();

            return status switch
            {
                "OK" => "Operacion exitosa",
                "1" => "Datos invalidos",
                "2" => "El cliente ya existe",
                "3" => "El cliente no existe",
                "4" => "Error no controlado",
                _ => status
            };
        }
    }
}
