namespace presentacion.Choferes
{
    partial class FrmEventoChofer
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
            this.btnEventoChofer = new System.Windows.Forms.Button();
            this.tbxEventoChoferTipo = new System.Windows.Forms.TextBox();
            this.lblEventoChoferTipo = new System.Windows.Forms.Label();
            this.cbxEventoChoferInterno = new System.Windows.Forms.ComboBox();
            this.tbxEventoChoferDetalle = new System.Windows.Forms.TextBox();
            this.lblEventoChoferDetalle = new System.Windows.Forms.Label();
            this.lblEventoChoferInterno = new System.Windows.Forms.Label();
            this.lblEventoChoferTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEventoChofer
            // 
            this.btnEventoChofer.Location = new System.Drawing.Point(268, 301);
            this.btnEventoChofer.Name = "btnEventoChofer";
            this.btnEventoChofer.Size = new System.Drawing.Size(85, 23);
            this.btnEventoChofer.TabIndex = 94;
            this.btnEventoChofer.Text = "Agregar";
            this.btnEventoChofer.UseVisualStyleBackColor = true;
            this.btnEventoChofer.Click += new System.EventHandler(this.btnEventoChofer_Click);
            // 
            // tbxEventoChoferTipo
            // 
            this.tbxEventoChoferTipo.Location = new System.Drawing.Point(186, 60);
            this.tbxEventoChoferTipo.Name = "tbxEventoChoferTipo";
            this.tbxEventoChoferTipo.Size = new System.Drawing.Size(167, 20);
            this.tbxEventoChoferTipo.TabIndex = 92;
            // 
            // lblEventoChoferTipo
            // 
            this.lblEventoChoferTipo.AutoSize = true;
            this.lblEventoChoferTipo.Location = new System.Drawing.Point(156, 63);
            this.lblEventoChoferTipo.Name = "lblEventoChoferTipo";
            this.lblEventoChoferTipo.Size = new System.Drawing.Size(24, 13);
            this.lblEventoChoferTipo.TabIndex = 91;
            this.lblEventoChoferTipo.Text = "tipo";
            // 
            // cbxEventoChoferInterno
            // 
            this.cbxEventoChoferInterno.FormattingEnabled = true;
            this.cbxEventoChoferInterno.Location = new System.Drawing.Point(73, 59);
            this.cbxEventoChoferInterno.Name = "cbxEventoChoferInterno";
            this.cbxEventoChoferInterno.Size = new System.Drawing.Size(72, 21);
            this.cbxEventoChoferInterno.TabIndex = 90;
            // 
            // tbxEventoChoferDetalle
            // 
            this.tbxEventoChoferDetalle.Location = new System.Drawing.Point(29, 109);
            this.tbxEventoChoferDetalle.Multiline = true;
            this.tbxEventoChoferDetalle.Name = "tbxEventoChoferDetalle";
            this.tbxEventoChoferDetalle.Size = new System.Drawing.Size(324, 186);
            this.tbxEventoChoferDetalle.TabIndex = 88;
            // 
            // lblEventoChoferDetalle
            // 
            this.lblEventoChoferDetalle.AutoSize = true;
            this.lblEventoChoferDetalle.Location = new System.Drawing.Point(37, 93);
            this.lblEventoChoferDetalle.Name = "lblEventoChoferDetalle";
            this.lblEventoChoferDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblEventoChoferDetalle.TabIndex = 87;
            this.lblEventoChoferDetalle.Text = "Detalle";
            // 
            // lblEventoChoferInterno
            // 
            this.lblEventoChoferInterno.AutoSize = true;
            this.lblEventoChoferInterno.Location = new System.Drawing.Point(28, 63);
            this.lblEventoChoferInterno.Name = "lblEventoChoferInterno";
            this.lblEventoChoferInterno.Size = new System.Drawing.Size(39, 13);
            this.lblEventoChoferInterno.TabIndex = 86;
            this.lblEventoChoferInterno.Text = "interno";
            // 
            // lblEventoChoferTitulo
            // 
            this.lblEventoChoferTitulo.AutoSize = true;
            this.lblEventoChoferTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventoChoferTitulo.Location = new System.Drawing.Point(86, 8);
            this.lblEventoChoferTitulo.Name = "lblEventoChoferTitulo";
            this.lblEventoChoferTitulo.Size = new System.Drawing.Size(211, 33);
            this.lblEventoChoferTitulo.TabIndex = 85;
            this.lblEventoChoferTitulo.Text = "Nuevo Evento";
            // 
            // FrmEventoChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 336);
            this.Controls.Add(this.btnEventoChofer);
            this.Controls.Add(this.tbxEventoChoferTipo);
            this.Controls.Add(this.lblEventoChoferTipo);
            this.Controls.Add(this.cbxEventoChoferInterno);
            this.Controls.Add(this.tbxEventoChoferDetalle);
            this.Controls.Add(this.lblEventoChoferDetalle);
            this.Controls.Add(this.lblEventoChoferInterno);
            this.Controls.Add(this.lblEventoChoferTitulo);
            this.Name = "FrmEventoChofer";
            this.Text = "FrmEventoChofer";
            this.Load += new System.EventHandler(this.FrmEventoChofer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventoChofer;
        private System.Windows.Forms.TextBox tbxEventoChoferTipo;
        private System.Windows.Forms.Label lblEventoChoferTipo;
        private System.Windows.Forms.ComboBox cbxEventoChoferInterno;
        private System.Windows.Forms.TextBox tbxEventoChoferDetalle;
        private System.Windows.Forms.Label lblEventoChoferDetalle;
        private System.Windows.Forms.Label lblEventoChoferInterno;
        private System.Windows.Forms.Label lblEventoChoferTitulo;
    }
}