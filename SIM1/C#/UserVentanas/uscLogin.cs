using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using ServicioAutenticacion;
using Sistema_de_Ventas_y_Distribución;

namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscLogin : UserControl
    {
        public uscLogin()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmCentral formulario = this.FindForm() as frmCentral;

            if (formulario == null)
            {
                MessageBox.Show(
                    "No se pudo acceder al formulario principal.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show(
                    "Debe ingresar el usuario y la contraseña.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // Crear la solicitud de autenticación
                SolicitudLogin solicitud = new SolicitudLogin
                {
                    Usuario = Cifrado.Cifrar(txtUsuario.Text.Trim()),
                    Contrasena = Cifrado.Cifrar(txtpassword.Text),

                    // El servicio determina el tipo automáticamente
                    Tipo = ""
                };

                // Enviar las credenciales al servicio WCF
                RespuestaAutenticacion respuesta =
                    ClienteAutenticacion.AutenticarUsuario(solicitud);

                if (respuesta != null && respuesta.Resultado)
                {
                    // Identificar el tipo de usuario
                    if (respuesta.Tipo == 1)
                    {
                        formulario.mostrarpantalla();
                        formulario.inicioAdmin();
                    }
                    else if (respuesta.Tipo == 2)
                    {
                        formulario.mostrarpantalla();
                        formulario.inicioCliente();
                    }
                    else
                    {
                        MessageBox.Show(
                            "El tipo de usuario recibido no es válido.",
                            "Error de autenticación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    string mensaje = respuesta?.Mensaje;

                    if (string.IsNullOrWhiteSpace(mensaje))
                    {
                        mensaje = "No se pudo comunicar con el servicio de autenticación.";
                    }

                    MessageBox.Show(
                        mensaje,
                        "Error de autenticación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al intentar iniciar sesión: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
