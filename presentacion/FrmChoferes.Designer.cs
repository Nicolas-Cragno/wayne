namespace presentacion
{
    partial class FrmChoferes
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
            this.lblChoferesTitulo = new System.Windows.Forms.Label();
            this.lblChoferesFiltro = new System.Windows.Forms.Label();
            this.tbxChoferesFiltro = new System.Windows.Forms.TextBox();
            this.dgvChoferes = new System.Windows.Forms.DataGridView();
            this.btnChoferesNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoferesTitulo
            // 
            this.lblChoferesTitulo.AutoSize = true;
            this.lblChoferesTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesTitulo.Location = new System.Drawing.Point(172, 24);
            this.lblChoferesTitulo.Name = "lblChoferesTitulo";
            this.lblChoferesTitulo.Size = new System.Drawing.Size(177, 33);
            this.lblChoferesTitulo.TabIndex = 0;
            this.lblChoferesTitulo.Text = "CHOFERES";
            // 
            // lblChoferesFiltro
            // 
            this.lblChoferesFiltro.AutoSize = true;
            this.lblChoferesFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesFiltro.Location = new System.Drawing.Point(226, 85);
            this.lblChoferesFiltro.Name = "lblChoferesFiltro";
            this.lblChoferesFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblChoferesFiltro.TabIndex = 1;
            this.lblChoferesFiltro.Text = "Filtro";
            // 
            // tbxChoferesFiltro
            // 
            this.tbxChoferesFiltro.Location = new System.Drawing.Point(266, 81);
            this.tbxChoferesFiltro.Name = "tbxChoferesFiltro";
            this.tbxChoferesFiltro.Size = new System.Drawing.Size(224, 20);
            this.tbxChoferesFiltro.TabIndex = 2;
            // 
            // dgvChoferes
            // 
            this.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferes.Location = new System.Drawing.Point(37, 107);
            this.dgvChoferes.Name = "dgvChoferes";
            this.dgvChoferes.Size = new System.Drawing.Size(453, 263);
            this.dgvChoferes.TabIndex = 3;
            this.dgvChoferes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoferes_CellContentClick);
            this.dgvChoferes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoferes_CellDoubleClick);
            // 
            // btnChoferesNuevo
            // 
            this.btnChoferesNuevo.Location = new System.Drawing.Point(398, 376);
            this.btnChoferesNuevo.Name = "btnChoferesNuevo";
            this.btnChoferesNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnChoferesNuevo.TabIndex = 4;
            this.btnChoferesNuevo.Text = "Nuevo Chofer";
            this.btnChoferesNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 422);
            this.Controls.Add(this.btnChoferesNuevo);
            this.Controls.Add(this.dgvChoferes);
            this.Controls.Add(this.tbxChoferesFiltro);
            this.Controls.Add(this.lblChoferesFiltro);
            this.Controls.Add(this.lblChoferesTitulo);
            this.Name = "FrmChoferes";
            this.Text = "FrmChoferes";
            this.Load += new System.EventHandler(this.FrmChoferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoferesTitulo;
        private System.Windows.Forms.Label lblChoferesFiltro;
        private System.Windows.Forms.TextBox tbxChoferesFiltro;
        private System.Windows.Forms.DataGridView dgvChoferes;
        private System.Windows.Forms.Button btnChoferesNuevo;
    }
}