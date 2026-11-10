namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    partial class uscRegistrarUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnviar = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtNombre = new TextBox();
            txtConfirmPassword = new TextBox();
            txtIdentificacion = new TextBox();
            lblPassword = new Label();
            lblUsuario = new Label();
            lblCorreo = new Label();
            lblSegundoApellido = new Label();
            lblPrimerApellido = new Label();
            lblNombre = new Label();
            lblConfirmPassword = new Label();
            lblIdentificacion = new Label();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.Font = new Font("Segoe UI", 12F);
            btnEnviar.Location = new Point(398, 305);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(200, 34);
            btnEnviar.TabIndex = 37;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(614, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 29);
            txtPassword.TabIndex = 36;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(614, 86);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 29);
            txtUsuario.TabIndex = 35;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.Location = new Point(614, 47);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "correo@gmail.com";
            txtCorreo.Size = new Size(200, 29);
            txtCorreo.TabIndex = 34;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Segoe UI", 12F);
            txtSegundoApellido.Location = new Point(195, 169);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(200, 29);
            txtSegundoApellido.TabIndex = 33;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Segoe UI", 12F);
            txtPrimerApellido.Location = new Point(195, 131);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(200, 29);
            txtPrimerApellido.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(195, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 31;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(614, 172);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 29);
            txtConfirmPassword.TabIndex = 30;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 12F);
            txtIdentificacion.Location = new Point(195, 52);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.PlaceholderText = "305260512";
            txtIdentificacion.Size = new Size(200, 29);
            txtIdentificacion.TabIndex = 29;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(506, 134);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(92, 21);
            lblPassword.TabIndex = 28;
            lblPassword.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(531, 94);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 27;
            lblUsuario.Text = "Usuario:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(537, 55);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(61, 21);
            lblCorreo.TabIndex = 26;
            lblCorreo.Text = "Correo:";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Font = new Font("Segoe UI", 12F);
            lblSegundoApellido.Location = new Point(33, 172);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(136, 21);
            lblSegundoApellido.TabIndex = 25;
            lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Font = new Font("Segoe UI", 12F);
            lblPrimerApellido.Location = new Point(48, 134);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(121, 21);
            lblPrimerApellido.TabIndex = 24;
            lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(98, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 12F);
            lblConfirmPassword.Location = new Point(431, 172);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(167, 21);
            lblConfirmPassword.TabIndex = 22;
            lblConfirmPassword.Text = "Confirmar Contraseña:";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Segoe UI", 12F);
            lblIdentificacion.Location = new Point(64, 55);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(105, 21);
            lblIdentificacion.TabIndex = 21;
            lblIdentificacion.Text = "Identificación:";
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(537, 230);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 23);
            lblEstado.TabIndex = 20;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 12F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "No Activo" });
            cmbEstado.Location = new Point(614, 227);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 29);
            cmbEstado.TabIndex = 19;
            // 
            // lblTipo
            // 
            lblTipo.Font = new Font("Segoe UI", 12F);
            lblTipo.Location = new Point(272, 230);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(53, 23);
            lblTipo.TabIndex = 39;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 12F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Administrador", "Cliente" });
            cmbTipo.Location = new Point(331, 227);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(200, 29);
            cmbTipo.TabIndex = 38;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(614, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 34);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(401, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 34);
            btnBuscar.TabIndex = 64;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(192, 305);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(200, 34);
            btnModificar.TabIndex = 65;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // uscRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(btnEnviar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(txtCorreo);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(lblCorreo);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);
            Name = "uscRegistrarUsuario";
            Size = new Size(865, 405);
            Load += uscRegistrarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtNombre;
        private TextBox txtConfirmPassword;
        private TextBox txtIdentificacion;
        private Label lblPassword;
        private Label lblUsuario;
        private Label lblCorreo;
        private Label lblSegundoApellido;
        private Label lblPrimerApellido;
        private Label lblNombre;
        private Label lblConfirmPassword;
        private Label lblIdentificacion;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Button btnCancelar;
        private Button btnBuscar;
        private Button btnModificar;
    }
}
