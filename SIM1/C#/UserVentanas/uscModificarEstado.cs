using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscModificarEstado : UserControl
    {
        private string identificacionConsultada = null;
        public uscModificarEstado()
        {
            InitializeComponent();

            btnBuscar.Click += btnBuscar_Click;
            btnEnviar.Click += btnEnviar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            identificacionConsultada = null;
            string identificacion = txtIdentificacion.Text.Trim();

            if (string.IsNullOrWhiteSpace(identificacion))
            {
                MessageBox.Show("Ingrese una identificación.");
                return;
            }

            var respuesta = ClienteAutenticacion.ObtenerUsuarioPorIdentificacion(identificacion);

            if (!respuesta.Resultado)
            {
                MessageBox.Show(
                    respuesta.Mensaje,
                    "Consulta de usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarCampos();
                return;
            }

            txtNombre.Text = respuesta.Usuario.Nombre + " " +
                             respuesta.Usuario.PrimerApellido + " " +
                             respuesta.Usuario.SegundoApellido;

            txtTipo.Text = respuesta.Tipo == 1 ? "Administrador" : "Cliente";

            txtEstado.Text = respuesta.Estado == "activo" ? "Activo" : "No Activo";

            cmbEstado.SelectedIndex = respuesta.Estado == "activo" ? 0 : 1;

            identificacionConsultada = identificacion;

            MessageBox.Show(
                "Usuario encontrado correctamente.",
                "Consulta de usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }

        private void LimpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtTipo.Clear();
            txtEstado.Clear();

            cmbEstado.SelectedIndex = -1;
            identificacionConsultada = null;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text.Trim();

            if (string.IsNullOrWhiteSpace(identificacionConsultada) ||
                identificacion != identificacionConsultada)
            {
                MessageBox.Show("Primero debe buscar un usuario válido.");
                return;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el nuevo estado del usuario.");
                return;
            }

            string nuevoEstado = cmbEstado.SelectedIndex == 0
                ? "activo"
                : "inactivo";

            var solicitud = new ServicioAutenticacion.SolicitudCambioEstado
            {
                Identificacion = identificacion,
                Estado = nuevoEstado
            };

            var respuesta = ClienteAutenticacion.CambiarEstadoUsuario(solicitud);

            if (respuesta.Resultado)
            {
                txtEstado.Text = nuevoEstado == "activo" ? "Activo" : "No Activo";

                MessageBox.Show(
                    "El estado del usuario se modificó correctamente.",
                    "Modificar estado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    respuesta.Mensaje,
                    "Error al modificar estado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
