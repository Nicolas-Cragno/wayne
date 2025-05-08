namespace presentacion.Eventos
{
    partial class FrmModificarEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificarEvento = new System.Windows.Forms.Button();
            this.cbxModificarEventoChofer = new System.Windows.Forms.ComboBox();
            this.tbxModificarEventoTipo = new System.Windows.Forms.TextBox();
            this.lblModificarEventoTipo = new System.Windows.Forms.Label();
            this.cbxModificarEventoInterno = new System.Windows.Forms.ComboBox();
            this.lblModificarEventoDNI = new System.Windows.Forms.Label();
            this.tbxModificarEventoDetalle = new System.Windows.Forms.TextBox();
            this.lblModificarEventoDetalle = new System.Windows.Forms.Label();
            this.lblModificarEventoInterno = new System.Windows.Forms.Label();
            this.lblModificarEventoTitulo = new System.Windows.Forms.Label();
            this.btnModificarEventoCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Location = new System.Drawing.Point(29, 323);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(102, 23);
            this.btnModificarEvento.TabIndex = 94;
            this.btnModificarEvento.Text = "Guardar Cambios";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            this.btnModificarEvento.Click += new System.EventHandler(this.btnModificarEvento_Click);
            // 
            // cbxModificarEventoChofer
            // 
            this.cbxModificarEventoChofer.FormattingEnabled = true;
            this.cbxModificarEventoChofer.Location = new System.Drawing.Point(73, 53);
            this.cbxModificarEventoChofer.Name = "cbxModificarEventoChofer";
            this.cbxModificarEventoChofer.Size = new System.Drawing.Size(280, 21);
            this.cbxModificarEventoChofer.TabIndex = 93;
            // 
            // tbxModificarEventoTipo
            // 
            this.tbxModificarEventoTipo.Location = new System.Drawing.Point(186, 82);
            this.tbxModificarEventoTipo.Name = "tbxModificarEventoTipo";
            this.tbxModificarEventoTipo.Size = new System.Drawing.Size(167, 20);
            this.tbxModificarEventoTipo.TabIndex = 92;
            // 
            // lblModificarEventoTipo
            // 
            this.lblModificarEventoTipo.AutoSize = true;
            this.lblModificarEventoTipo.Location = new System.Drawing.Point(156, 85);
            this.lblModificarEventoTipo.Name = "lblModificarEventoTipo";
            this.lblModificarEventoTipo.Size = new System.Drawing.Size(24, 13);
            this.lblModificarEventoTipo.TabIndex = 91;
            this.lblModificarEventoTipo.Text = "tipo";
            // 
            // cbxModificarEventoInterno
            // 
            this.cbxModificarEventoInterno.FormattingEnabled = true;
            this.cbxModificarEventoInterno.Location = new System.Drawing.Point(73, 81);
            this.cbxModificarEventoInterno.Name = "cbxModificarEventoInterno";
            this.cbxModificarEventoInterno.Size = new System.Drawing.Size(72, 21);
            this.cbxModificarEventoInterno.TabIndex = 90;
            // 
            // lblModificarEventoDNI
            // 
            this.lblModificarEventoDNI.AutoSize = true;
            this.lblModificarEventoDNI.Location = new System.Drawing.Point(30, 56);
            this.lblModificarEventoDNI.Name = "lblModificarEventoDNI";
            this.lblModificarEventoDNI.Size = new System.Drawing.Size(37, 13);
            this.lblModificarEventoDNI.TabIndex = 89;
            this.lblModificarEventoDNI.Text = "chofer";
            // 
            // tbxModificarEventoDetalle
            // 
            this.tbxModificarEventoDetalle.Location = new System.Drawing.Point(29, 131);
            this.tbxModificarEventoDetalle.Multiline = true;
            this.tbxModificarEventoDetalle.Name = "tbxModificarEventoDetalle";
            this.tbxModificarEventoDetalle.Size = new System.Drawing.Size(324, 186);
            this.tbxModificarEventoDetalle.TabIndex = 88;
            // 
            // lblModificarEventoDetalle
            // 
            this.lblModificarEventoDetalle.AutoSize = true;
            this.lblModificarEventoDetalle.Location = new System.Drawing.Point(37, 115);
            this.lblModificarEventoDetalle.Name = "lblModificarEventoDetalle";
            this.lblModificarEventoDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblModificarEventoDetalle.TabIndex = 87;
            this.lblModificarEventoDetalle.Text = "Detalle";
            // 
            // lblModificarEventoInterno
            // 
            this.lblModificarEventoInterno.AutoSize = true;
            this.lblModificarEventoInterno.Location = new System.Drawing.Point(28, 85);
            this.lblModificarEventoInterno.Name = "lblModificarEventoInterno";
            this.lblModificarEventoInterno.Size = new System.Drawing.Size(39, 13);
            this.lblModificarEventoInterno.TabIndex = 86;
            this.lblModificarEventoInterno.Text = "interno";
            // 
            // lblModificarEventoTitulo
            // 
            this.lblModificarEventoTitulo.AutoSize = true;
            this.lblModificarEventoTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEventoTitulo.Location = new System.Drawing.Point(57, 8);
            this.lblModificarEventoTitulo.Name = "lblModificarEventoTitulo";
            this.lblModificarEventoTitulo.Size = new System.Drawing.Size(266, 33);
            this.lblModificarEventoTitulo.TabIndex = 85;
            this.lblModificarEventoTitulo.Text = "Edición de evento";
            this.lblModificarEventoTitulo.Click += new System.EventHandler(this.lblModificarEventoTitulo_Click);
            // 
            // btnModificarEventoCerrar
            // 
            this.btnModificarEventoCerrar.Location = new System.Drawing.Point(279, 323);
            this.btnModificarEventoCerrar.Name = "btnModificarEventoCerrar";
            this.btnModificarEventoCerrar.Size = new System.Drawing.Size(74, 23);
            this.btnModificarEventoCerrar.TabIndex = 95;
            this.btnModificarEventoCerrar.Text = "Cerrar";
            this.btnModificarEventoCerrar.UseVisualStyleBackColor = true;
            this.btnModificarEventoCerrar.Click += new System.EventHandler(this.btnModificarEventoCerrar_Click);
            // 
            // FrmModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 354);
            this.Controls.Add(this.btnModificarEventoCerrar);
            this.Controls.Add(this.btnModificarEvento);
            this.Controls.Add(this.cbxModificarEventoChofer);
            this.Controls.Add(this.tbxModificarEventoTipo);
            this.Controls.Add(this.lblModificarEventoTipo);
            this.Controls.Add(this.cbxModificarEventoInterno);
            this.Controls.Add(this.lblModificarEventoDNI);
            this.Controls.Add(this.tbxModificarEventoDetalle);
            this.Controls.Add(this.lblModificarEventoDetalle);
            this.Controls.Add(this.lblModificarEventoInterno);
            this.Controls.Add(this.lblModificarEventoTitulo);
            this.Name = "FrmModificarEvento";
            this.Text = "FrmModificarEvento";
            this.Load += new System.EventHandler(this.FrmModificarEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarEvento;
        private System.Windows.Forms.ComboBox cbxModificarEventoChofer;
        private System.Windows.Forms.TextBox tbxModificarEventoTipo;
        private System.Windows.Forms.Label lblModificarEventoTipo;
        private System.Windows.Forms.ComboBox cbxModificarEventoInterno;
        private System.Windows.Forms.Label lblModificarEventoDNI;
        private System.Windows.Forms.TextBox tbxModificarEventoDetalle;
        private System.Windows.Forms.Label lblModificarEventoDetalle;
        private System.Windows.Forms.Label lblModificarEventoInterno;
        private System.Windows.Forms.Label lblModificarEventoTitulo;
        private System.Windows.Forms.Button btnModificarEventoCerrar;
    }
}