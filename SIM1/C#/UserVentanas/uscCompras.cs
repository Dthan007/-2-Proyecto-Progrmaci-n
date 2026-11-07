using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ServicioVerificador;

using BLL;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscCompras : UserControl
    {
        public uscCompras()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var productos = new List<ProductoCompra>();

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

                productos.Add(new ProductoCompra
                {
                    CodigoProducto = Cifrado.Cifrar(codigoTexto),
                    Cantidad = Cifrado.Cifrar(cantidadTexto)
                });
            }

            var solicitud = new SolicitudCompra
            {
                NumeroCompra = Cifrado.Cifrar(txtNumeroCompra.Text),
            IdentificacionCliente = Cifrado.Cifrar(txtIdentificacionCliente.Text),
            FechaCompra = Cifrado.Cifrar(DateTime.Today.ToString("yyyy-MM-dd")),
            TotalCompra = Cifrado.Cifrar(txtTotalCompra.Text.Trim().Replace(',', '.')),
            TarjetaCifrada = Cifrado.Cifrar(txtNumeroTarjeta.Text),
            VencimientoCifrado = Cifrado.Cifrar(txtFechaVencimiento.Text),
            CvvCifrado = Cifrado.Cifrar(txtCvv.Text),
            Productos = productos.ToArray()
            };

            var respuesta = ClienteVerificador.RegistrarCompra(solicitud);
            lblResultado.Text = respuesta.Mensaje;
        }
    }
}
