namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    partial class uscMantenimientoProveedores
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
            lblTipTrans = new Label();
            cmbTipoTransaccion = new ComboBox();
            lblIDJuridica = new Label();
            txtIDjuridica = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblNombreCont = new Label();
            txtNomContacto = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTipTrans
            // 
            lblTipTrans.AutoSize = true;
            lblTipTrans.Font = new Font("Segoe UI", 12F);
            lblTipTrans.Location = new Point(4, 23);
            lblTipTrans.Name = "lblTipTrans";
            lblTipTrans.Size = new Size(147, 21);
            lblTipTrans.TabIndex = 0;
            lblTipTrans.Text = "Tipo de transacción:";
            // 
            // cmbTipoTransaccion
            // 
            cmbTipoTransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoTransaccion.Font = new Font("Segoe UI", 12F);
            cmbTipoTransaccion.FormattingEnabled = true;
            cmbTipoTransaccion.Items.AddRange(new object[] { "Ingreso", "Modificación" });
            cmbTipoTransaccion.Location = new Point(157, 23);
            cmbTipoTransaccion.Name = "cmbTipoTransaccion";
            cmbTipoTransaccion.Size = new Size(158, 29);
            cmbTipoTransaccion.TabIndex = 1;
            // 
            // lblIDJuridica
            // 
            lblIDJuridica.AutoSize = true;
            lblIDJuridica.Font = new Font("Segoe UI", 12F);
            lblIDJuridica.Location = new Point(33, 79);
            lblIDJuridica.Name = "lblIDJuridica";
            lblIDJuridica.Size = new Size(118, 21);
            lblIDJuridica.TabIndex = 0;
            lblIDJuridica.Text = "Cédula Jurídica:";
            // 
            // txtIDjuridica
            // 
            txtIDjuridica.Font = new Font("Segoe UI", 12F);
            txtIDjuridica.Location = new Point(157, 79);
            txtIDjuridica.MaxLength = 10;
            txtIDjuridica.Name = "txtIDjuridica";
            txtIDjuridica.PlaceholderText = "3100550000";
            txtIDjuridica.Size = new Size(158, 29);
            txtIDjuridica.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(80, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(157, 135);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 29);
            txtNombre.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(80, 191);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 21);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(157, 191);
            txtTelefono.MaxLength = 8;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "88997766";
            txtTelefono.Size = new Size(158, 29);
            txtTelefono.TabIndex = 7;
            // 
            // lblNombreCont
            // 
            lblNombreCont.AutoSize = true;
            lblNombreCont.Font = new Font("Segoe UI", 12F);
            lblNombreCont.Location = new Point(337, 23);
            lblNombreCont.Name = "lblNombreCont";
            lblNombreCont.Size = new Size(162, 21);
            lblNombreCont.TabIndex = 0;
            lblNombreCont.Text = "Nombre del Contacto:";
            // 
            // txtNomContacto
            // 
            txtNomContacto.Font = new Font("Segoe UI", 12F);
            txtNomContacto.Location = new Point(505, 23);
            txtNomContacto.MaxLength = 75;
            txtNomContacto.Name = "txtNomContacto";
            txtNomContacto.Size = new Size(154, 29);
            txtNomContacto.TabIndex = 9;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(358, 79);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(141, 21);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.Location = new Point(505, 79);
            txtCorreo.MaxLength = 75;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(154, 29);
            txtCorreo.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(440, 135);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 21);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 12F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(505, 135);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(154, 29);
            cmbEstado.TabIndex = 13;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(403, 227);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 34);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(505, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // uscMantenimientoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtNomContacto);
            Controls.Add(lblNombreCont);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtIDjuridica);
            Controls.Add(lblIDJuridica);
            Controls.Add(cmbTipoTransaccion);
            Controls.Add(lblTipTrans);
            Name = "uscMantenimientoProveedores";
            Size = new Size(762, 376);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipTrans;
        private ComboBox cmbTipoTransaccion;
        private Label lblIDJuridica;
        private TextBox txtIDjuridica;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblNombreCont;
        private TextBox txtNomContacto;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
