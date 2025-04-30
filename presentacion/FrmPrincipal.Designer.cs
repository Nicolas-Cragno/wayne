namespace presentacion
{
    partial class FrmPrincipal
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
            this.btnChoferes = new System.Windows.Forms.Button();
            this.btnTractores = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoferes
            // 
            this.btnChoferes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoferes.Location = new System.Drawing.Point(288, 81);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Size = new System.Drawing.Size(257, 34);
            this.btnChoferes.TabIndex = 0;
            this.btnChoferes.Text = "CHOFERES";
            this.btnChoferes.UseVisualStyleBackColor = true;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);
            // 
            // btnTractores
            // 
            this.btnTractores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTractores.Location = new System.Drawing.Point(288, 140);
            this.btnTractores.Name = "btnTractores";
            this.btnTractores.Size = new System.Drawing.Size(257, 34);
            this.btnTractores.TabIndex = 1;
            this.btnTractores.Text = "TRACTORES";
            this.btnTractores.UseVisualStyleBackColor = true;
            this.btnTractores.Click += new System.EventHandler(this.btnTractores_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(288, 199);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(257, 34);
            this.btnEventos.TabIndex = 2;
            this.btnEventos.Text = "EVENTOS";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.Location = new System.Drawing.Point(288, 258);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(257, 34);
            this.btnMovimientos.TabIndex = 3;
            this.btnMovimientos.Text = "MOVIMIENTOS";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 373);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnTractores);
            this.Controls.Add(this.btnChoferes);
            this.Name = "FrmPrincipal";
            this.Text = "Wayne Control";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoferes;
        private System.Windows.Forms.Button btnTractores;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnMovimientos;
    }
}