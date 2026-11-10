using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            //validar usuario y contraseña
            if (txtUsuario.Text == "admin" && txtpassword.Text == "admin")
            {
                // Si el usuario y la contraseña son correctos, mostrar el formulario principal
                formulario.mostrarpantalla();
                formulario.inicioAdmin();
            }
            else
            {
                // Si el usuario o la contraseña son incorrectos, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
    }
}
