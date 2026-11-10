using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscRegistrarUsuario : UserControl
    {
        public uscRegistrarUsuario()
        {
            InitializeComponent();

            cmbEstado.SelectedIndex = 0;
            cmbEstado.Enabled = false;

            btnBuscar.Click += btnBuscar_Click;
            btnEnviar.Click += btnEnviar_Click;
            btnModificar.Click += btnModificar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void uscRegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text.Trim();

            if (string.IsNullOrWhiteSpace(identificacion))
            {
                MessageBox.Show("Ingrese una identificación.");
                return;
            }

            var respuesta = ClienteAutenticacion.ObtenerUsuarioPorIdentificacion(identificacion);

            if (!respuesta.Resultado)
            {
                MessageBox.Show(respuesta.Mensaje, "Consulta de usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            txtNombre.Text = respuesta.Usuario.Nombre;
            txtPrimerApellido.Text = respuesta.Usuario.PrimerApellido;
            txtSegundoApellido.Text = respuesta.Usuario.SegundoApellido;
            txtCorreo.Text = respuesta.Usuario.CorreoElectronico;
            txtUsuario.Text = respuesta.Usuario.Usuario;

            cmbTipo.SelectedIndex = respuesta.Tipo == 1 ? 0 : 1;

            cmbEstado.SelectedIndex = respuesta.Estado == "activo" ? 0 : 1;

            // No se recupera la contraseña por seguridad.
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            MessageBox.Show("Usuario encontrado correctamente.",
                "Consulta de usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            var solicitud = new ServicioAutenticacion.SolicitudCrearUsuario
            {
                Identificacion = txtIdentificacion.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                PrimerApellido = txtPrimerApellido.Text.Trim(),
                SegundoApellido = txtSegundoApellido.Text.Trim(),
                CorreoElectronico = txtCorreo.Text.Trim(),

                Usuario = BLL.Cifrado.Cifrar(txtUsuario.Text.Trim()),
                Contrasena = BLL.Cifrado.Cifrar(txtPassword.Text),

                Estado = "activo",
                Tipo = cmbTipo.SelectedIndex == 0 ? "1" : "2"
            };

            var respuesta = ClienteAutenticacion.CrearUsuario(solicitud);

            if (respuesta.Resultado)
            {
                MessageBox.Show("Usuario registrado correctamente.",
                    "Registro de usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje,
                    "Error al registrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            cmbTipo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string contrasenaCifrada = null;

            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                contrasenaCifrada = BLL.Cifrado.Cifrar(txtPassword.Text);
            }

            var solicitud = new ServicioAutenticacion.DatosUsuario
            {
                Identificacion = txtIdentificacion.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                PrimerApellido = txtPrimerApellido.Text.Trim(),
                SegundoApellido = txtSegundoApellido.Text.Trim(),
                CorreoElectronico = txtCorreo.Text.Trim(),
                Usuario = BLL.Cifrado.Cifrar(txtUsuario.Text.Trim()),
                Contrasena = contrasenaCifrada
            };

            var respuesta = ClienteAutenticacion.ModificarUsuario(solicitud);

            if (respuesta.Resultado)
            {
                MessageBox.Show("Usuario modificado correctamente.",
                    "Modificar usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje,
                    "Error al modificar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
