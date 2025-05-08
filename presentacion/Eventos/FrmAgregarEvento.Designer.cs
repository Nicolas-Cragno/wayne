namespace presentacion.Eventos
{
    partial class FrmAgregarEvento
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
            this.cbxAgregarEventoInterno = new System.Windows.Forms.ComboBox();
            this.lblAgregarEventoDNI = new System.Windows.Forms.Label();
            this.tbxAgregarEventoDetalle = new System.Windows.Forms.TextBox();
            this.lblAgregarEventoDetalle = new System.Windows.Forms.Label();
            this.lblAgregarEventoInterno = new System.Windows.Forms.Label();
            this.lblAgregarEventoTitulo = new System.Windows.Forms.Label();
            this.tbxAgregarEventoTipo = new System.Windows.Forms.TextBox();
            this.lblAgregarEventoTipo = new System.Windows.Forms.Label();
            this.cbxAgregarEventoChofer = new System.Windows.Forms.ComboBox();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.btnAgregarEventoCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxAgregarEventoInterno
            // 
            this.cbxAgregarEventoInterno.FormattingEnabled = true;
            this.cbxAgregarEventoInterno.Location = new System.Drawing.Point(72, 81);
            this.cbxAgregarEventoInterno.Name = "cbxAgregarEventoInterno";
            this.cbxAgregarEventoInterno.Size = new System.Drawing.Size(72, 21);
            this.cbxAgregarEventoInterno.TabIndex = 80;
            // 
            // lblAgregarEventoDNI
            // 
            this.lblAgregarEventoDNI.AutoSize = true;
            this.lblAgregarEventoDNI.Location = new System.Drawing.Point(29, 56);
            this.lblAgregarEventoDNI.Name = "lblAgregarEventoDNI";
            this.lblAgregarEventoDNI.Size = new System.Drawing.Size(37, 13);
            this.lblAgregarEventoDNI.TabIndex = 76;
            this.lblAgregarEventoDNI.Text = "chofer";
            // 
            // tbxAgregarEventoDetalle
            // 
            this.tbxAgregarEventoDetalle.Location = new System.Drawing.Point(28, 131);
            this.tbxAgregarEventoDetalle.Multiline = true;
            this.tbxAgregarEventoDetalle.Name = "tbxAgregarEventoDetalle";
            this.tbxAgregarEventoDetalle.Size = new System.Drawing.Size(324, 186);
            this.tbxAgregarEventoDetalle.TabIndex = 74;
            // 
            // lblAgregarEventoDetalle
            // 
            this.lblAgregarEventoDetalle.AutoSize = true;
            this.lblAgregarEventoDetalle.Location = new System.Drawing.Point(36, 115);
            this.lblAgregarEventoDetalle.Name = "lblAgregarEventoDetalle";
            this.lblAgregarEventoDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblAgregarEventoDetalle.TabIndex = 73;
            this.lblAgregarEventoDetalle.Text = "Detalle";
            // 
            // lblAgregarEventoInterno
            // 
            this.lblAgregarEventoInterno.AutoSize = true;
            this.lblAgregarEventoInterno.Location = new System.Drawing.Point(27, 85);
            this.lblAgregarEventoInterno.Name = "lblAgregarEventoInterno";
            this.lblAgregarEventoInterno.Size = new System.Drawing.Size(39, 13);
            this.lblAgregarEventoInterno.TabIndex = 72;
            this.lblAgregarEventoInterno.Text = "interno";
            // 
            // lblAgregarEventoTitulo
            // 
            this.lblAgregarEventoTitulo.AutoSize = true;
            this.lblAgregarEventoTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEventoTitulo.Location = new System.Drawing.Point(85, 8);
            this.lblAgregarEventoTitulo.Name = "lblAgregarEventoTitulo";
            this.lblAgregarEventoTitulo.Size = new System.Drawing.Size(211, 33);
            this.lblAgregarEventoTitulo.TabIndex = 65;
            this.lblAgregarEventoTitulo.Text = "Nuevo Evento";
            // 
            // tbxAgregarEventoTipo
            // 
            this.tbxAgregarEventoTipo.Location = new System.Drawing.Point(185, 82);
            this.tbxAgregarEventoTipo.Name = "tbxAgregarEventoTipo";
            this.tbxAgregarEventoTipo.Size = new System.Drawing.Size(167, 20);
            this.tbxAgregarEventoTipo.TabIndex = 82;
            // 
            // lblAgregarEventoTipo
            // 
            this.lblAgregarEventoTipo.AutoSize = true;
            this.lblAgregarEventoTipo.Location = new System.Drawing.Point(155, 85);
            this.lblAgregarEventoTipo.Name = "lblAgregarEventoTipo";
            this.lblAgregarEventoTipo.Size = new System.Drawing.Size(24, 13);
            this.lblAgregarEventoTipo.TabIndex = 81;
            this.lblAgregarEventoTipo.Text = "tipo";
            // 
            // cbxAgregarEventoChofer
            // 
            this.cbxAgregarEventoChofer.FormattingEnabled = true;
            this.cbxAgregarEventoChofer.Location = new System.Drawing.Point(72, 53);
            this.cbxAgregarEventoChofer.Name = "cbxAgregarEventoChofer";
            this.cbxAgregarEventoChofer.Size = new System.Drawing.Size(280, 21);
            this.cbxAgregarEventoChofer.TabIndex = 83;
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.Location = new System.Drawing.Point(28, 323);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(85, 23);
            this.btnAgregarEvento.TabIndex = 84;
            this.btnAgregarEvento.Text = "Agregar";
            this.btnAgregarEvento.UseVisualStyleBackColor = true;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click_1);
            // 
            // btnAgregarEventoCerrar
            // 
            this.btnAgregarEventoCerrar.Location = new System.Drawing.Point(267, 323);
            this.btnAgregarEventoCerrar.Name = "btnAgregarEventoCerrar";
            this.btnAgregarEventoCerrar.Size = new System.Drawing.Size(85, 23);
            this.btnAgregarEventoCerrar.TabIndex = 85;
            this.btnAgregarEventoCerrar.Text = "Cerrar";
            this.btnAgregarEventoCerrar.UseVisualStyleBackColor = true;
            this.btnAgregarEventoCerrar.Click += new System.EventHandler(this.btnAgregarEventoCerrar_Click);
            // 
            // FrmAgregarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 354);
            this.Controls.Add(this.btnAgregarEventoCerrar);
            this.Controls.Add(this.btnAgregarEvento);
            this.Controls.Add(this.cbxAgregarEventoChofer);
            this.Controls.Add(this.tbxAgregarEventoTipo);
            this.Controls.Add(this.lblAgregarEventoTipo);
            this.Controls.Add(this.cbxAgregarEventoInterno);
            this.Controls.Add(this.lblAgregarEventoDNI);
            this.Controls.Add(this.tbxAgregarEventoDetalle);
            this.Controls.Add(this.lblAgregarEventoDetalle);
            this.Controls.Add(this.lblAgregarEventoInterno);
            this.Controls.Add(this.lblAgregarEventoTitulo);
            this.Name = "FrmAgregarEvento";
            this.Text = "FrmAgregarEvento";
            this.Load += new System.EventHandler(this.FrmAgregarEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAgregarEventoInterno;
        private System.Windows.Forms.Label lblAgregarEventoDNI;
        private System.Windows.Forms.TextBox tbxAgregarEventoDetalle;
        private System.Windows.Forms.Label lblAgregarEventoDetalle;
        private System.Windows.Forms.Label lblAgregarEventoInterno;
        private System.Windows.Forms.Label lblAgregarEventoTitulo;
        private System.Windows.Forms.TextBox tbxAgregarEventoTipo;
        private System.Windows.Forms.Label lblAgregarEventoTipo;
        private System.Windows.Forms.ComboBox cbxAgregarEventoChofer;
        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.Button btnAgregarEventoCerrar;
    }
}