namespace Sistema_de_Ventas_y_Distribución
{
    partial class uscMantenimientoClientes
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
            cmbTipoTransaccion = new ComboBox();
            lblTipoTransaccion = new Label();
            lblIdentificacion = new Label();
            lblPaisOrigen = new Label();
            lblNombre = new Label();
            lblPrimerApellido = new Label();
            lblSegundoApellido = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            txtIdentificacion = new TextBox();
            txtPaisOrigen = new TextBox();
            txtNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnEnviar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // cmbTipoTransaccion
            // 
            cmbTipoTransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoTransaccion.Font = new Font("Segoe UI", 12F);
            cmbTipoTransaccion.FormattingEnabled = true;
            cmbTipoTransaccion.Items.AddRange(new object[] { "Agregar", "Modificar", "Borrar" });
            cmbTipoTransaccion.Location = new Point(174, 20);
            cmbTipoTransaccion.Name = "cmbTipoTransaccion";
            cmbTipoTransaccion.Size = new Size(200, 29);
            cmbTipoTransaccion.TabIndex = 0;
            // 
            // lblTipoTransaccion
            // 
            lblTipoTransaccion.Font = new Font("Segoe UI", 12F);
            lblTipoTransaccion.Location = new Point(12, 23);
            lblTipoTransaccion.Name = "lblTipoTransaccion";
            lblTipoTransaccion.Size = new Size(156, 23);
            lblTipoTransaccion.TabIndex = 1;
            lblTipoTransaccion.Text = "Tipo de Transacción:";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Segoe UI", 12F);
            lblIdentificacion.Location = new Point(12, 63);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(105, 21);
            lblIdentificacion.TabIndex = 2;
            lblIdentificacion.Text = "Identificación:";
            // 
            // lblPaisOrigen
            // 
            lblPaisOrigen.AutoSize = true;
            lblPaisOrigen.Font = new Font("Segoe UI", 12F);
            lblPaisOrigen.Location = new Point(425, 25);
            lblPaisOrigen.Name = "lblPaisOrigen";
            lblPaisOrigen.Size = new Size(113, 21);
            lblPaisOrigen.TabIndex = 3;
            lblPaisOrigen.Text = "Pais de Origen:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(12, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Font = new Font("Segoe UI", 12F);
            lblPrimerApellido.Location = new Point(12, 142);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(121, 21);
            lblPrimerApellido.TabIndex = 5;
            lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Font = new Font("Segoe UI", 12F);
            lblSegundoApellido.Location = new Point(12, 180);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(136, 21);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(425, 68);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(61, 21);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(425, 107);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 21);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(425, 147);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 12F);
            txtIdentificacion.Location = new Point(174, 60);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.PlaceholderText = "305260512";
            txtIdentificacion.Size = new Size(200, 29);
            txtIdentificacion.TabIndex = 10;
            // 
            // txtPaisOrigen
            // 
            txtPaisOrigen.Font = new Font("Segoe UI", 12F);
            txtPaisOrigen.Location = new Point(544, 20);
            txtPaisOrigen.Name = "txtPaisOrigen";
            txtPaisOrigen.PlaceholderText = "CR";
            txtPaisOrigen.Size = new Size(200, 29);
            txtPaisOrigen.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(174, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 12;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Segoe UI", 12F);
            txtPrimerApellido.Location = new Point(174, 139);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(200, 29);
            txtPrimerApellido.TabIndex = 13;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Segoe UI", 12F);
            txtSegundoApellido.Location = new Point(174, 177);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(200, 29);
            txtSegundoApellido.TabIndex = 14;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.Location = new Point(544, 60);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "correo@gmail.com";
            txtCorreo.Size = new Size(200, 29);
            txtCorreo.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(544, 99);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "12345678";
            txtTelefono.Size = new Size(200, 29);
            txtTelefono.TabIndex = 16;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(544, 139);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Cartago, Costa Rica";
            txtDireccion.Size = new Size(200, 29);
            txtDireccion.TabIndex = 17;
            // 
            // btnEnviar
            // 
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.Font = new Font("Segoe UI", 12F);
            btnEnviar.Location = new Point(544, 180);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(200, 34);
            btnEnviar.TabIndex = 18;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(544, 228);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(82, 21);
            lblResultado.TabIndex = 19;
            lblResultado.Text = "Resultado:";
            // 
            // uscMantenimientoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblResultado);
            Controls.Add(btnEnviar);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtPaisOrigen);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblPaisOrigen);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblTipoTransaccion);
            Controls.Add(cmbTipoTransaccion);
            Name = "uscMantenimientoClientes";
            Size = new Size(766, 259);
            Load += uscMantenimientoClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoTransaccion;
        private Label lblTipoTransaccion;
        private Label lblIdentificacion;
        private Label lblPaisOrigen;
        private Label lblNombre;
        private Label lblPrimerApellido;
        private Label lblSegundoApellido;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblDireccion;
        private TextBox txtIdentificacion;
        private TextBox txtPaisOrigen;
        private TextBox txtNombre;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoApellido;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnEnviar;
        private Label lblResultado;
    }
}
