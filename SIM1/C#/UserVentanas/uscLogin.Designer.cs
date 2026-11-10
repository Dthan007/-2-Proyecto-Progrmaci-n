namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    partial class uscLogin
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
            lbltextC = new Label();
            lbltext = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuario = new TextBox();
            txtpassword = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lbltextC
            // 
            lbltextC.AutoSize = true;
            lbltextC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltextC.Location = new Point(205, 39);
            lbltextC.Name = "lbltextC";
            lbltextC.Size = new Size(277, 25);
            lbltextC.TabIndex = 0;
            lbltextC.Text = "Sistema de Venta y Distribución";
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext.Location = new Point(277, 97);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(124, 25);
            lbltext.TabIndex = 1;
            lbltext.Text = "Iniciar Sesión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(190, 157);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 5;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(159, 226);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 6;
            label5.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(277, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(234, 29);
            txtUsuario.TabIndex = 7;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(277, 226);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(234, 29);
            txtpassword.TabIndex = 8;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(287, 293);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 53);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // uscLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIngresar);
            Controls.Add(txtpassword);
            Controls.Add(txtUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbltext);
            Controls.Add(lbltextC);
            Name = "uscLogin";
            Size = new Size(701, 406);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltextC;
        private Label lbltext;
        private Label label4;
        private Label label5;
        private TextBox txtUsuario;
        private TextBox txtpassword;
        private Button btnIngresar;
    }
}
