namespace presentacion
{
    partial class FrmFichaChofer
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
            this.lblFichaChoferTitulo = new System.Windows.Forms.Label();
            this.lblFichaChoferDNI = new System.Windows.Forms.Label();
            this.tbxFichaChoferDNI = new System.Windows.Forms.TextBox();
            this.tbxFichaChoferEmpresa = new System.Windows.Forms.TextBox();
            this.lblFichaChoferEmpresa = new System.Windows.Forms.Label();
            this.tbxFichaChoferTipo = new System.Windows.Forms.TextBox();
            this.lblFichaChoferTipo = new System.Windows.Forms.Label();
            this.tbxFichaChoferInterno = new System.Windows.Forms.TextBox();
            this.lblFichaChoferInterno = new System.Windows.Forms.Label();
            this.tbxFichaChoferViajes = new System.Windows.Forms.TextBox();
            this.lblFichaChoferViajes = new System.Windows.Forms.Label();
            this.tbxFichaChoferPromedio = new System.Windows.Forms.TextBox();
            this.lblFichaChoferPromedio = new System.Windows.Forms.Label();
            this.tbxFichaChoferEstado = new System.Windows.Forms.TextBox();
            this.lblFichaChoferEstado = new System.Windows.Forms.Label();
            this.tbxFichaChoferObservaciones = new System.Windows.Forms.TextBox();
            this.lblFichaChoferObservaciones = new System.Windows.Forms.Label();
            this.btnFichaChoferEditar = new System.Windows.Forms.Button();
            this.lblFichaChoferEventoTitulo = new System.Windows.Forms.Label();
            this.dgvFichaChoferEvento = new System.Windows.Forms.DataGridView();
            this.tbxFichaChoferEventoFiltro = new System.Windows.Forms.TextBox();
            this.lblFichaChoferEventoFiltro = new System.Windows.Forms.Label();
            this.btnAgregarFichaChoferEvento = new System.Windows.Forms.Button();
            this.btbFichaChoferCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaChoferEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFichaChoferTitulo
            // 
            this.lblFichaChoferTitulo.AutoSize = true;
            this.lblFichaChoferTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaChoferTitulo.Location = new System.Drawing.Point(22, 27);
            this.lblFichaChoferTitulo.Name = "lblFichaChoferTitulo";
            this.lblFichaChoferTitulo.Size = new System.Drawing.Size(235, 33);
            this.lblFichaChoferTitulo.TabIndex = 0;
            this.lblFichaChoferTitulo.Text = "Ficha de chofer";
            // 
            // lblFichaChoferDNI
            // 
            this.lblFichaChoferDNI.AutoSize = true;
            this.lblFichaChoferDNI.Location = new System.Drawing.Point(34, 78);
            this.lblFichaChoferDNI.Name = "lblFichaChoferDNI";
            this.lblFichaChoferDNI.Size = new System.Drawing.Size(21, 13);
            this.lblFichaChoferDNI.TabIndex = 1;
            this.lblFichaChoferDNI.Text = "dni";
            // 
            // tbxFichaChoferDNI
            // 
            this.tbxFichaChoferDNI.Location = new System.Drawing.Point(28, 94);
            this.tbxFichaChoferDNI.Name = "tbxFichaChoferDNI";
            this.tbxFichaChoferDNI.ReadOnly = true;
            this.tbxFichaChoferDNI.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaChoferDNI.TabIndex = 2;
            // 
            // tbxFichaChoferEmpresa
            // 
            this.tbxFichaChoferEmpresa.Location = new System.Drawing.Point(136, 94);
            this.tbxFichaChoferEmpresa.Name = "tbxFichaChoferEmpresa";
            this.tbxFichaChoferEmpresa.ReadOnly = true;
            this.tbxFichaChoferEmpresa.Size = new System.Drawing.Size(216, 20);
            this.tbxFichaChoferEmpresa.TabIndex = 4;
            // 
            // lblFichaChoferEmpresa
            // 
            this.lblFichaChoferEmpresa.AutoSize = true;
            this.lblFichaChoferEmpresa.Location = new System.Drawing.Point(142, 78);
            this.lblFichaChoferEmpresa.Name = "lblFichaChoferEmpresa";
            this.lblFichaChoferEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblFichaChoferEmpresa.TabIndex = 3;
            this.lblFichaChoferEmpresa.Text = "empresa";
            // 
            // tbxFichaChoferTipo
            // 
            this.tbxFichaChoferTipo.Location = new System.Drawing.Point(28, 145);
            this.tbxFichaChoferTipo.Name = "tbxFichaChoferTipo";
            this.tbxFichaChoferTipo.ReadOnly = true;
            this.tbxFichaChoferTipo.Size = new System.Drawing.Size(208, 20);
            this.tbxFichaChoferTipo.TabIndex = 6;
            // 
            // lblFichaChoferTipo
            // 
            this.lblFichaChoferTipo.AutoSize = true;
            this.lblFichaChoferTipo.Location = new System.Drawing.Point(34, 129);
            this.lblFichaChoferTipo.Name = "lblFichaChoferTipo";
            this.lblFichaChoferTipo.Size = new System.Drawing.Size(88, 13);
            this.lblFichaChoferTipo.TabIndex = 5;
            this.lblFichaChoferTipo.Text = "tipo de empleado";
            // 
            // tbxFichaChoferInterno
            // 
            this.tbxFichaChoferInterno.Location = new System.Drawing.Point(252, 145);
            this.tbxFichaChoferInterno.Name = "tbxFichaChoferInterno";
            this.tbxFichaChoferInterno.ReadOnly = true;
            this.tbxFichaChoferInterno.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaChoferInterno.TabIndex = 8;
            // 
            // lblFichaChoferInterno
            // 
            this.lblFichaChoferInterno.AutoSize = true;
            this.lblFichaChoferInterno.Location = new System.Drawing.Point(258, 129);
            this.lblFichaChoferInterno.Name = "lblFichaChoferInterno";
            this.lblFichaChoferInterno.Size = new System.Drawing.Size(39, 13);
            this.lblFichaChoferInterno.TabIndex = 7;
            this.lblFichaChoferInterno.Text = "interno";
            // 
            // tbxFichaChoferViajes
            // 
            this.tbxFichaChoferViajes.Location = new System.Drawing.Point(28, 195);
            this.tbxFichaChoferViajes.Name = "tbxFichaChoferViajes";
            this.tbxFichaChoferViajes.ReadOnly = true;
            this.tbxFichaChoferViajes.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaChoferViajes.TabIndex = 10;
            // 
            // lblFichaChoferViajes
            // 
            this.lblFichaChoferViajes.AutoSize = true;
            this.lblFichaChoferViajes.Location = new System.Drawing.Point(34, 179);
            this.lblFichaChoferViajes.Name = "lblFichaChoferViajes";
            this.lblFichaChoferViajes.Size = new System.Drawing.Size(61, 13);
            this.lblFichaChoferViajes.TabIndex = 9;
            this.lblFichaChoferViajes.Text = "cant. viajes";
            // 
            // tbxFichaChoferPromedio
            // 
            this.tbxFichaChoferPromedio.Location = new System.Drawing.Point(136, 195);
            this.tbxFichaChoferPromedio.Name = "tbxFichaChoferPromedio";
            this.tbxFichaChoferPromedio.ReadOnly = true;
            this.tbxFichaChoferPromedio.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaChoferPromedio.TabIndex = 12;
            // 
            // lblFichaChoferPromedio
            // 
            this.lblFichaChoferPromedio.AutoSize = true;
            this.lblFichaChoferPromedio.Location = new System.Drawing.Point(142, 179);
            this.lblFichaChoferPromedio.Name = "lblFichaChoferPromedio";
            this.lblFichaChoferPromedio.Size = new System.Drawing.Size(50, 13);
            this.lblFichaChoferPromedio.TabIndex = 11;
            this.lblFichaChoferPromedio.Text = "promedio";
            // 
            // tbxFichaChoferEstado
            // 
            this.tbxFichaChoferEstado.Location = new System.Drawing.Point(252, 195);
            this.tbxFichaChoferEstado.Name = "tbxFichaChoferEstado";
            this.tbxFichaChoferEstado.ReadOnly = true;
            this.tbxFichaChoferEstado.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaChoferEstado.TabIndex = 14;
            // 
            // lblFichaChoferEstado
            // 
            this.lblFichaChoferEstado.AutoSize = true;
            this.lblFichaChoferEstado.Location = new System.Drawing.Point(258, 179);
            this.lblFichaChoferEstado.Name = "lblFichaChoferEstado";
            this.lblFichaChoferEstado.Size = new System.Drawing.Size(39, 13);
            this.lblFichaChoferEstado.TabIndex = 13;
            this.lblFichaChoferEstado.Text = "estado";
            // 
            // tbxFichaChoferObservaciones
            // 
            this.tbxFichaChoferObservaciones.Location = new System.Drawing.Point(28, 248);
            this.tbxFichaChoferObservaciones.Multiline = true;
            this.tbxFichaChoferObservaciones.Name = "tbxFichaChoferObservaciones";
            this.tbxFichaChoferObservaciones.ReadOnly = true;
            this.tbxFichaChoferObservaciones.Size = new System.Drawing.Size(324, 109);
            this.tbxFichaChoferObservaciones.TabIndex = 16;
            // 
            // lblFichaChoferObservaciones
            // 
            this.lblFichaChoferObservaciones.AutoSize = true;
            this.lblFichaChoferObservaciones.Location = new System.Drawing.Point(34, 232);
            this.lblFichaChoferObservaciones.Name = "lblFichaChoferObservaciones";
            this.lblFichaChoferObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblFichaChoferObservaciones.TabIndex = 15;
            this.lblFichaChoferObservaciones.Text = "Observaciones";
            // 
            // btnFichaChoferEditar
            // 
            this.btnFichaChoferEditar.Location = new System.Drawing.Point(277, 363);
            this.btnFichaChoferEditar.Name = "btnFichaChoferEditar";
            this.btnFichaChoferEditar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaChoferEditar.TabIndex = 19;
            this.btnFichaChoferEditar.Text = "Editar Datos";
            this.btnFichaChoferEditar.UseVisualStyleBackColor = true;
            this.btnFichaChoferEditar.Click += new System.EventHandler(this.btnFichaChoferEditar_Click);
            // 
            // lblFichaChoferEventoTitulo
            // 
            this.lblFichaChoferEventoTitulo.AutoSize = true;
            this.lblFichaChoferEventoTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaChoferEventoTitulo.Location = new System.Drawing.Point(396, 78);
            this.lblFichaChoferEventoTitulo.Name = "lblFichaChoferEventoTitulo";
            this.lblFichaChoferEventoTitulo.Size = new System.Drawing.Size(228, 24);
            this.lblFichaChoferEventoTitulo.TabIndex = 20;
            this.lblFichaChoferEventoTitulo.Text = "Eventos relacionados";
            // 
            // dgvFichaChoferEvento
            // 
            this.dgvFichaChoferEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichaChoferEvento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFichaChoferEvento.Location = new System.Drawing.Point(400, 145);
            this.dgvFichaChoferEvento.MultiSelect = false;
            this.dgvFichaChoferEvento.Name = "dgvFichaChoferEvento";
            this.dgvFichaChoferEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichaChoferEvento.Size = new System.Drawing.Size(381, 212);
            this.dgvFichaChoferEvento.TabIndex = 21;
            this.dgvFichaChoferEvento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichaChoferEvento_CellContentClick);
            this.dgvFichaChoferEvento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichaChoferEvento_CellDoubleClick);
            // 
            // tbxFichaChoferEventoFiltro
            // 
            this.tbxFichaChoferEventoFiltro.Location = new System.Drawing.Point(448, 119);
            this.tbxFichaChoferEventoFiltro.Name = "tbxFichaChoferEventoFiltro";
            this.tbxFichaChoferEventoFiltro.Size = new System.Drawing.Size(217, 20);
            this.tbxFichaChoferEventoFiltro.TabIndex = 23;
            this.tbxFichaChoferEventoFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFichaChoferEventoFiltro_KeyPress);
            // 
            // lblFichaChoferEventoFiltro
            // 
            this.lblFichaChoferEventoFiltro.AutoSize = true;
            this.lblFichaChoferEventoFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaChoferEventoFiltro.Location = new System.Drawing.Point(408, 123);
            this.lblFichaChoferEventoFiltro.Name = "lblFichaChoferEventoFiltro";
            this.lblFichaChoferEventoFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblFichaChoferEventoFiltro.TabIndex = 22;
            this.lblFichaChoferEventoFiltro.Text = "Filtro";
            // 
            // btnAgregarFichaChoferEvento
            // 
            this.btnAgregarFichaChoferEvento.Location = new System.Drawing.Point(685, 117);
            this.btnAgregarFichaChoferEvento.Name = "btnAgregarFichaChoferEvento";
            this.btnAgregarFichaChoferEvento.Size = new System.Drawing.Size(92, 23);
            this.btnAgregarFichaChoferEvento.TabIndex = 24;
            this.btnAgregarFichaChoferEvento.Text = "Agregar Evento";
            this.btnAgregarFichaChoferEvento.UseVisualStyleBackColor = true;
            this.btnAgregarFichaChoferEvento.Click += new System.EventHandler(this.btnAgregarFichaChoferEvento_Click);
            // 
            // btbFichaChoferCerrar
            // 
            this.btbFichaChoferCerrar.Location = new System.Drawing.Point(706, 363);
            this.btbFichaChoferCerrar.Name = "btbFichaChoferCerrar";
            this.btbFichaChoferCerrar.Size = new System.Drawing.Size(75, 23);
            this.btbFichaChoferCerrar.TabIndex = 25;
            this.btbFichaChoferCerrar.Text = "Cerrar";
            this.btbFichaChoferCerrar.UseVisualStyleBackColor = true;
            this.btbFichaChoferCerrar.Click += new System.EventHandler(this.btbFichaChoferCerrar_Click);
            // 
            // FrmFichaChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 413);
            this.Controls.Add(this.btbFichaChoferCerrar);
            this.Controls.Add(this.btnAgregarFichaChoferEvento);
            this.Controls.Add(this.tbxFichaChoferEventoFiltro);
            this.Controls.Add(this.lblFichaChoferEventoFiltro);
            this.Controls.Add(this.dgvFichaChoferEvento);
            this.Controls.Add(this.lblFichaChoferEventoTitulo);
            this.Controls.Add(this.btnFichaChoferEditar);
            this.Controls.Add(this.tbxFichaChoferObservaciones);
            this.Controls.Add(this.lblFichaChoferObservaciones);
            this.Controls.Add(this.tbxFichaChoferEstado);
            this.Controls.Add(this.lblFichaChoferEstado);
            this.Controls.Add(this.tbxFichaChoferPromedio);
            this.Controls.Add(this.lblFichaChoferPromedio);
            this.Controls.Add(this.tbxFichaChoferViajes);
            this.Controls.Add(this.lblFichaChoferViajes);
            this.Controls.Add(this.tbxFichaChoferInterno);
            this.Controls.Add(this.lblFichaChoferInterno);
            this.Controls.Add(this.tbxFichaChoferTipo);
            this.Controls.Add(this.lblFichaChoferTipo);
            this.Controls.Add(this.tbxFichaChoferEmpresa);
            this.Controls.Add(this.lblFichaChoferEmpresa);
            this.Controls.Add(this.tbxFichaChoferDNI);
            this.Controls.Add(this.lblFichaChoferDNI);
            this.Controls.Add(this.lblFichaChoferTitulo);
            this.Name = "FrmFichaChofer";
            this.Text = "FrmFichaChofer";
            this.Load += new System.EventHandler(this.FrmFichaChofer_Load_1);
            this.TextChanged += new System.EventHandler(this.FrmFichaChofer_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaChoferEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFichaChoferTitulo;
        private System.Windows.Forms.Label lblFichaChoferDNI;
        private System.Windows.Forms.TextBox tbxFichaChoferDNI;
        private System.Windows.Forms.TextBox tbxFichaChoferEmpresa;
        private System.Windows.Forms.Label lblFichaChoferEmpresa;
        private System.Windows.Forms.TextBox tbxFichaChoferTipo;
        private System.Windows.Forms.Label lblFichaChoferTipo;
        private System.Windows.Forms.TextBox tbxFichaChoferInterno;
        private System.Windows.Forms.Label lblFichaChoferInterno;
        private System.Windows.Forms.TextBox tbxFichaChoferViajes;
        private System.Windows.Forms.Label lblFichaChoferViajes;
        private System.Windows.Forms.TextBox tbxFichaChoferPromedio;
        private System.Windows.Forms.Label lblFichaChoferPromedio;
        private System.Windows.Forms.TextBox tbxFichaChoferEstado;
        private System.Windows.Forms.Label lblFichaChoferEstado;
        private System.Windows.Forms.TextBox tbxFichaChoferObservaciones;
        private System.Windows.Forms.Label lblFichaChoferObservaciones;
        private System.Windows.Forms.Button btnFichaChoferEditar;
        private System.Windows.Forms.Label lblFichaChoferEventoTitulo;
        private System.Windows.Forms.DataGridView dgvFichaChoferEvento;
        private System.Windows.Forms.TextBox tbxFichaChoferEventoFiltro;
        private System.Windows.Forms.Label lblFichaChoferEventoFiltro;
        private System.Windows.Forms.Button btnAgregarFichaChoferEvento;
        private System.Windows.Forms.Button btbFichaChoferCerrar;
    }
}