using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

using BLL;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscCompras : UserControl
    {

        private readonly string ipVerificador = "127.0.0.1";
        private readonly int puertoVerificador = 6000;

        public uscCompras()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var productos = new List<object>();

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                var codigoTexto = fila.Cells["colCodigo"].Value?.ToString();
                var cantidadTexto = fila.Cells["colCantidad"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(codigoTexto) || string.IsNullOrWhiteSpace(cantidadTexto))
                {
                    continue;
                }

                productos.Add(new
                {
                    codigo_producto = codigoTexto,
                    cantidad = cantidadTexto
                });
            }

            var trama = new
            {
                historia = "VERIFICADOR2",
                numero_compra = txtNumeroCompra.Text,
                identificacion_cliente = txtIdentificacionCliente.Text,
                fecha_compra = DateTime.Today.ToString("yyyy-MM-dd"),
                total_compra = txtTotalCompra.Text,
                tarjeta_cifrada = Cifrado.Cifrar(txtFechaVencimiento.Text),
                vencimiento_cifrado = Cifrado.Cifrar(txtFechaVencimiento.Text),
                cvv_cifrado = Cifrado.Cifrar(txtCvv.Text),
                productos = productos
            };

            var tramaJson = JsonSerializer.Serialize(trama);
            var conexion = new ConexionSocket(ipVerificador, puertoVerificador);

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
                "OK" => "Compra registrada exitosamente",
                "1" => "Datos invalidos",
                "2" => "Error al procesar la compra en el Almacen",
                "4" => "Error no controlado",
                _ => status ?? "Respuesta deconocida del servidor"
            };
        }
    }
}
