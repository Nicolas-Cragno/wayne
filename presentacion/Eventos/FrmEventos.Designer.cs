namespace presentacion.Eventos
{
    partial class FrmEventos
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
            this.btnEventosClose = new System.Windows.Forms.Button();
            this.btnEventosNuevo = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.tbxEventosFiltro = new System.Windows.Forms.TextBox();
            this.lblEventosFiltro = new System.Windows.Forms.Label();
            this.lblEventosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventosClose
            // 
            this.btnEventosClose.Location = new System.Drawing.Point(423, 376);
            this.btnEventosClose.Name = "btnEventosClose";
            this.btnEventosClose.Size = new System.Drawing.Size(51, 23);
            this.btnEventosClose.TabIndex = 12;
            this.btnEventosClose.Text = "Cerrar";
            this.btnEventosClose.UseVisualStyleBackColor = true;
            this.btnEventosClose.Click += new System.EventHandler(this.btnEventosClose_Click);
            // 
            // btnEventosNuevo
            // 
            this.btnEventosNuevo.Location = new System.Drawing.Point(382, 79);
            this.btnEventosNuevo.Name = "btnEventosNuevo";
            this.btnEventosNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnEventosNuevo.TabIndex = 11;
            this.btnEventosNuevo.Text = "Agregar Evento";
            this.btnEventosNuevo.UseVisualStyleBackColor = true;
            this.btnEventosNuevo.Click += new System.EventHandler(this.btnEventosNuevo_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEventos.Location = new System.Drawing.Point(34, 107);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(453, 263);
            this.dgvEventos.TabIndex = 10;
            this.dgvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentClick);
            this.dgvEventos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentDoubleClick);
            this.dgvEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellDoubleClick);
            // 
            // tbxEventosFiltro
            // 
            this.tbxEventosFiltro.Location = new System.Drawing.Point(81, 81);
            this.tbxEventosFiltro.Name = "tbxEventosFiltro";
            this.tbxEventosFiltro.Size = new System.Drawing.Size(273, 20);
            this.tbxEventosFiltro.TabIndex = 9;
            this.tbxEventosFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEventosFiltro_KeyPress);
            // 
            // lblEventosFiltro
            // 
            this.lblEventosFiltro.AutoSize = true;
            this.lblEventosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosFiltro.Location = new System.Drawing.Point(41, 85);
            this.lblEventosFiltro.Name = "lblEventosFiltro";
            this.lblEventosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblEventosFiltro.TabIndex = 8;
            this.lblEventosFiltro.Text = "Filtro";
            // 
            // lblEventosTitulo
            // 
            this.lblEventosTitulo.AutoSize = true;
            this.lblEventosTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosTitulo.Location = new System.Drawing.Point(169, 24);
            this.lblEventosTitulo.Name = "lblEventosTitulo";
            this.lblEventosTitulo.Size = new System.Drawing.Size(155, 33);
            this.lblEventosTitulo.TabIndex = 7;
            this.lblEventosTitulo.Text = "EVENTOS";
            // 
            // FrmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 422);
            this.Controls.Add(this.btnEventosClose);
            this.Controls.Add(this.btnEventosNuevo);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.tbxEventosFiltro);
            this.Controls.Add(this.lblEventosFiltro);
            this.Controls.Add(this.lblEventosTitulo);
            this.Name = "FrmEventos";
            this.Text = "FrmEventos";
            this.Load += new System.EventHandler(this.FrmEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventosClose;
        private System.Windows.Forms.Button btnEventosNuevo;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox tbxEventosFiltro;
        private System.Windows.Forms.Label lblEventosFiltro;
        private System.Windows.Forms.Label lblEventosTitulo;
    }
}