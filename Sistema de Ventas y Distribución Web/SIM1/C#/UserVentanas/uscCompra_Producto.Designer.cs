namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    partial class uscCompra_Producto
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
            lblTipoTrans = new Label();
            cmbTransaccion = new ComboBox();
            lblNumIngreso = new Label();
            txtIngreso = new TextBox();
            txtCompra = new TextBox();
            lblFechaCompra = new Label();
            txtJuridica = new TextBox();
            lblIDjuridica = new Label();
            lblProductos = new Label();
            txtNoProducto = new TextBox();
            lblNoProducto = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTipoTrans
            // 
            lblTipoTrans.AutoSize = true;
            lblTipoTrans.Font = new Font("Consolas", 12F);
            lblTipoTrans.Location = new Point(41, 34);
            lblTipoTrans.Name = "lblTipoTrans";
            lblTipoTrans.Size = new Size(162, 19);
            lblTipoTrans.TabIndex = 0;
            lblTipoTrans.Text = "Tipo Transacción:";
            // 
            // cmbTransaccion
            // 
            cmbTransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransaccion.Font = new Font("Consolas", 12F);
            cmbTransaccion.FormattingEnabled = true;
            cmbTransaccion.Items.AddRange(new object[] { "Compras" });
            cmbTransaccion.Location = new Point(209, 34);
            cmbTransaccion.Name = "cmbTransaccion";
            cmbTransaccion.Size = new Size(176, 27);
            cmbTransaccion.TabIndex = 1;
            // 
            // lblNumIngreso
            // 
            lblNumIngreso.AutoSize = true;
            lblNumIngreso.Font = new Font("Consolas", 12F);
            lblNumIngreso.Location = new Point(23, 88);
            lblNumIngreso.Name = "lblNumIngreso";
            lblNumIngreso.Size = new Size(180, 19);
            lblNumIngreso.TabIndex = 0;
            lblNumIngreso.Text = "Número de Ingreso: ";
            // 
            // txtIngreso
            // 
            txtIngreso.Font = new Font("Consolas", 12F);
            txtIngreso.Location = new Point(209, 88);
            txtIngreso.MaxLength = 10;
            txtIngreso.Name = "txtIngreso";
            txtIngreso.PlaceholderText = "2526202000";
            txtIngreso.Size = new Size(176, 26);
            txtIngreso.TabIndex = 2;
            // 
            // txtCompra
            // 
            txtCompra.Font = new Font("Consolas", 12F);
            txtCompra.Location = new Point(209, 147);
            txtCompra.MaxLength = 8;
            txtCompra.Name = "txtCompra";
            txtCompra.PlaceholderText = "20250830";
            txtCompra.Size = new Size(176, 26);
            txtCompra.TabIndex = 3;
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Font = new Font("Consolas", 12F);
            lblFechaCompra.Location = new Point(50, 147);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(153, 19);
            lblFechaCompra.TabIndex = 0;
            lblFechaCompra.Text = "Fecha de compra:";
            // 
            // txtJuridica
            // 
            txtJuridica.Font = new Font("Consolas", 12F);
            txtJuridica.Location = new Point(209, 198);
            txtJuridica.MaxLength = 10;
            txtJuridica.Name = "txtJuridica";
            txtJuridica.PlaceholderText = "3100550000";
            txtJuridica.Size = new Size(176, 26);
            txtJuridica.TabIndex = 4;
            // 
            // lblIDjuridica
            // 
            lblIDjuridica.AutoSize = true;
            lblIDjuridica.Font = new Font("Consolas", 12F);
            lblIDjuridica.Location = new Point(50, 198);
            lblIDjuridica.Name = "lblIDjuridica";
            lblIDjuridica.Size = new Size(153, 19);
            lblIDjuridica.TabIndex = 0;
            lblIDjuridica.Text = "Cédula Jurídica:";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Consolas", 12F);
            lblProductos.Location = new Point(522, 34);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(189, 19);
            lblProductos.TabIndex = 0;
            lblProductos.Text = "Lista de productos: ";
            // 
            // txtNoProducto
            // 
            txtNoProducto.Font = new Font("Segoe UI", 12F);
            txtNoProducto.Location = new Point(579, 88);
            txtNoProducto.MaxLength = 10;
            txtNoProducto.Name = "txtNoProducto";
            txtNoProducto.PlaceholderText = "3444550000";
            txtNoProducto.Size = new Size(176, 29);
            txtNoProducto.TabIndex = 5;
            // 
            // lblNoProducto
            // 
            lblNoProducto.AutoSize = true;
            lblNoProducto.Font = new Font("Consolas", 12F);
            lblNoProducto.Location = new Point(462, 88);
            lblNoProducto.Name = "lblNoProducto";
            lblNoProducto.Size = new Size(126, 19);
            lblNoProducto.TabIndex = 0;
            lblNoProducto.Text = "No Producto: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(579, 147);
            txtCantidad.MaxLength = 7;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "0000345";
            txtCantidad.Size = new Size(176, 29);
            txtCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Consolas", 12F);
            lblCantidad.Location = new Point(489, 147);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(99, 19);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(579, 198);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(176, 34);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // uscCompra_Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAceptar);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtNoProducto);
            Controls.Add(lblNoProducto);
            Controls.Add(lblProductos);
            Controls.Add(txtJuridica);
            Controls.Add(lblIDjuridica);
            Controls.Add(txtCompra);
            Controls.Add(lblFechaCompra);
            Controls.Add(txtIngreso);
            Controls.Add(lblNumIngreso);
            Controls.Add(cmbTransaccion);
            Controls.Add(lblTipoTrans);
            Name = "uscCompra_Producto";
            Size = new Size(822, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoTrans;
        private ComboBox cmbTransaccion;
        private Label lblNumIngreso;
        private TextBox txtIngreso;
        private TextBox txtCompra;
        private Label lblFechaCompra;
        private TextBox txtJuridica;
        private Label lblIDjuridica;
        private Label lblProductos;
        private TextBox txtNoProducto;
        private Label lblNoProducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnAceptar;
    }
}
