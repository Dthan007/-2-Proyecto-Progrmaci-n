namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    partial class uscModificarEstado
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
            btnBuscar = new Button();
            txtIdentificacion = new TextBox();
            lblIdentificacion = new Label();
            lblUsuario = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblTipo = new Label();
            lblEstado = new Label();
            txtTipo = new TextBox();
            txtEstado = new TextBox();
            lblNewEstado = new Label();
            cmbEstado = new ComboBox();
            btnCancelar = new Button();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(365, 51);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 34);
            btnBuscar.TabIndex = 67;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 12F);
            txtIdentificacion.Location = new Point(159, 51);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.PlaceholderText = "305260512";
            txtIdentificacion.Size = new Size(200, 29);
            txtIdentificacion.TabIndex = 66;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Segoe UI", 12F);
            lblIdentificacion.Location = new Point(28, 54);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(105, 21);
            lblIdentificacion.TabIndex = 65;
            lblIdentificacion.Text = "Identificación:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(28, 124);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(147, 21);
            lblUsuario.TabIndex = 68;
            lblUsuario.Text = "Usuario Encontrado";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(159, 174);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 70;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(62, 177);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 69;
            lblNombre.Text = "Nombre:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F);
            lblTipo.Location = new Point(90, 219);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 21);
            lblTipo.TabIndex = 71;
            lblTipo.Text = "Tipo:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(74, 261);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 21);
            lblEstado.TabIndex = 72;
            lblEstado.Text = "Estado:";
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Segoe UI", 12F);
            txtTipo.Location = new Point(159, 216);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(200, 29);
            txtTipo.TabIndex = 73;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.Location = new Point(159, 258);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(200, 29);
            txtEstado.TabIndex = 74;
            // 
            // lblNewEstado
            // 
            lblNewEstado.AutoSize = true;
            lblNewEstado.Font = new Font("Segoe UI", 12F);
            lblNewEstado.Location = new Point(401, 181);
            lblNewEstado.Name = "lblNewEstado";
            lblNewEstado.Size = new Size(109, 21);
            lblNewEstado.TabIndex = 75;
            lblNewEstado.Text = "Nuevo Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 12F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "No Activo" });
            cmbEstado.Location = new Point(401, 216);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 29);
            cmbEstado.TabIndex = 76;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(453, 313);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 34);
            btnCancelar.TabIndex = 78;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.Font = new Font("Segoe UI", 12F);
            btnEnviar.Location = new Point(237, 313);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(200, 34);
            btnEnviar.TabIndex = 77;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // uscModificarEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Controls.Add(cmbEstado);
            Controls.Add(lblNewEstado);
            Controls.Add(txtEstado);
            Controls.Add(txtTipo);
            Controls.Add(lblEstado);
            Controls.Add(lblTipo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblUsuario);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblIdentificacion);
            Name = "uscModificarEstado";
            Size = new Size(731, 394);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtIdentificacion;
        private Label lblIdentificacion;
        private Label lblUsuario;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblTipo;
        private Label lblEstado;
        private TextBox txtTipo;
        private TextBox txtEstado;
        private Label lblNewEstado;
        private ComboBox cmbEstado;
        private Button btnCancelar;
        private Button btnEnviar;
    }
}
