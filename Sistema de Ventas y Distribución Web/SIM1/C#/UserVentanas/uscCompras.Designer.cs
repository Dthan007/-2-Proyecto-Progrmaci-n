namespace Sistema_de_Ventas_y_Distribución
{
    partial class uscCompras
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
            lblNumeroCompra = new Label();
            lblIdentificacionCliente = new Label();
            lblFechaCompra = new Label();
            lblTotalCompra = new Label();
            lblNumeroTarjeta = new Label();
            lblFechaVencimiento = new Label();
            lblCvv = new Label();
            lblProductos = new Label();
            lblResultado = new Label();
            txtNumeroCompra = new TextBox();
            txtIdentificacionCliente = new TextBox();
            txtFechaCompra = new TextBox();
            txtTotalCompra = new TextBox();
            txtNumeroTarjeta = new TextBox();
            txtFechaVencimiento = new TextBox();
            txtCvv = new TextBox();
            dgvProductos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            btnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblNumeroCompra
            // 
            lblNumeroCompra.AutoSize = true;
            lblNumeroCompra.Font = new Font("Segoe UI", 12F);
            lblNumeroCompra.Location = new Point(12, 23);
            lblNumeroCompra.Name = "lblNumeroCompra";
            lblNumeroCompra.Size = new Size(152, 21);
            lblNumeroCompra.TabIndex = 0;
            lblNumeroCompra.Text = "Numero de Compra:";
            // 
            // lblIdentificacionCliente
            // 
            lblIdentificacionCliente.AutoSize = true;
            lblIdentificacionCliente.Font = new Font("Segoe UI", 12F);
            lblIdentificacionCliente.Location = new Point(12, 63);
            lblIdentificacionCliente.Name = "lblIdentificacionCliente";
            lblIdentificacionCliente.Size = new Size(105, 21);
            lblIdentificacionCliente.TabIndex = 1;
            lblIdentificacionCliente.Text = "Identificación:";
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Font = new Font("Segoe UI", 12F);
            lblFechaCompra.Location = new Point(12, 102);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(131, 21);
            lblFechaCompra.TabIndex = 2;
            lblFechaCompra.Text = "Fecha de compra:";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 12F);
            lblTotalCompra.Location = new Point(12, 142);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(126, 21);
            lblTotalCompra.TabIndex = 3;
            lblTotalCompra.Text = "Total de Compra:";
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Font = new Font("Segoe UI", 12F);
            lblNumeroTarjeta.Location = new Point(417, 24);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(141, 21);
            lblNumeroTarjeta.TabIndex = 4;
            lblNumeroTarjeta.Text = "Número de Tarjeta:";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Font = new Font("Segoe UI", 12F);
            lblFechaVencimiento.Location = new Point(417, 63);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(167, 21);
            lblFechaVencimiento.TabIndex = 5;
            lblFechaVencimiento.Text = "Vencimiento (MM/AA):";
            // 
            // lblCvv
            // 
            lblCvv.AutoSize = true;
            lblCvv.Font = new Font("Segoe UI", 12F);
            lblCvv.Location = new Point(417, 102);
            lblCvv.Name = "lblCvv";
            lblCvv.Size = new Size(43, 21);
            lblCvv.TabIndex = 6;
            lblCvv.Text = "CVV:";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 12F);
            lblProductos.Location = new Point(12, 223);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(83, 21);
            lblProductos.TabIndex = 7;
            lblProductos.Text = "Productos:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(490, 415);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(82, 21);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado:";
            // 
            // txtNumeroCompra
            // 
            txtNumeroCompra.Font = new Font("Segoe UI", 12F);
            txtNumeroCompra.Location = new Point(170, 21);
            txtNumeroCompra.Name = "txtNumeroCompra";
            txtNumeroCompra.PlaceholderText = "2526202099";
            txtNumeroCompra.Size = new Size(200, 29);
            txtNumeroCompra.TabIndex = 9;
            // 
            // txtIdentificacionCliente
            // 
            txtIdentificacionCliente.Font = new Font("Segoe UI", 12F);
            txtIdentificacionCliente.Location = new Point(170, 61);
            txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            txtIdentificacionCliente.PlaceholderText = "305260546";
            txtIdentificacionCliente.Size = new Size(200, 29);
            txtIdentificacionCliente.TabIndex = 10;
            // 
            // txtFechaCompra
            // 
            txtFechaCompra.Font = new Font("Segoe UI", 12F);
            txtFechaCompra.Location = new Point(170, 100);
            txtFechaCompra.Name = "txtFechaCompra";
            txtFechaCompra.PlaceholderText = "5/10/2026";
            txtFechaCompra.Size = new Size(200, 29);
            txtFechaCompra.TabIndex = 11;
            // 
            // txtTotalCompra
            // 
            txtTotalCompra.Font = new Font("Segoe UI", 12F);
            txtTotalCompra.Location = new Point(170, 142);
            txtTotalCompra.Name = "txtTotalCompra";
            txtTotalCompra.PlaceholderText = "15000.50";
            txtTotalCompra.Size = new Size(200, 29);
            txtTotalCompra.TabIndex = 12;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Font = new Font("Segoe UI", 12F);
            txtNumeroTarjeta.Location = new Point(590, 21);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.PlaceholderText = "1111222233334444";
            txtNumeroTarjeta.Size = new Size(200, 29);
            txtNumeroTarjeta.TabIndex = 13;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Font = new Font("Segoe UI", 12F);
            txtFechaVencimiento.Location = new Point(590, 61);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.PlaceholderText = "05/10";
            txtFechaVencimiento.Size = new Size(200, 29);
            txtFechaVencimiento.TabIndex = 14;
            // 
            // txtCvv
            // 
            txtCvv.Font = new Font("Segoe UI", 12F);
            txtCvv.Location = new Point(590, 100);
            txtCvv.Name = "txtCvv";
            txtCvv.PlaceholderText = "123";
            txtCvv.Size = new Size(200, 29);
            txtCvv.TabIndex = 15;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colCantidad });
            dgvProductos.Location = new Point(12, 247);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(245, 189);
            dgvProductos.TabIndex = 16;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Codigo de Producto";
            colCodigo.Name = "colCodigo";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            // 
            // btnEnviar
            // 
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.Font = new Font("Segoe UI", 12F);
            btnEnviar.Location = new Point(490, 368);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(200, 34);
            btnEnviar.TabIndex = 17;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // uscCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEnviar);
            Controls.Add(dgvProductos);
            Controls.Add(txtCvv);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(txtNumeroTarjeta);
            Controls.Add(txtTotalCompra);
            Controls.Add(txtFechaCompra);
            Controls.Add(txtIdentificacionCliente);
            Controls.Add(txtNumeroCompra);
            Controls.Add(lblResultado);
            Controls.Add(lblProductos);
            Controls.Add(lblCvv);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblNumeroTarjeta);
            Controls.Add(lblTotalCompra);
            Controls.Add(lblFechaCompra);
            Controls.Add(lblIdentificacionCliente);
            Controls.Add(lblNumeroCompra);
            Name = "uscCompras";
            Size = new Size(808, 450);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroCompra;
        private Label lblIdentificacionCliente;
        private Label lblFechaCompra;
        private Label lblTotalCompra;
        private Label lblNumeroTarjeta;
        private Label lblFechaVencimiento;
        private Label lblCvv;
        private Label lblProductos;
        private Label lblResultado;
        private TextBox txtNumeroCompra;
        private TextBox txtIdentificacionCliente;
        private TextBox txtFechaCompra;
        private TextBox txtTotalCompra;
        private TextBox txtNumeroTarjeta;
        private TextBox txtFechaVencimiento;
        private TextBox txtCvv;
        private DataGridView dgvProductos;
        private Button btnEnviar;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colCantidad;
    }
}
