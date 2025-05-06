namespace presentacion.Tractores
{
    partial class FrmTractores
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
            this.btnTractoresClose = new System.Windows.Forms.Button();
            this.BtnTractoresFiltro = new System.Windows.Forms.Button();
            this.btnTractoresNuevo = new System.Windows.Forms.Button();
            this.dgvTractores = new System.Windows.Forms.DataGridView();
            this.tbxTractoresFiltro = new System.Windows.Forms.TextBox();
            this.lblTractoresFiltro = new System.Windows.Forms.Label();
            this.lblTractoresTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTractores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTractoresClose
            // 
            this.btnTractoresClose.Location = new System.Drawing.Point(436, 376);
            this.btnTractoresClose.Name = "btnTractoresClose";
            this.btnTractoresClose.Size = new System.Drawing.Size(51, 23);
            this.btnTractoresClose.TabIndex = 13;
            this.btnTractoresClose.Text = "Cerrar";
            this.btnTractoresClose.UseVisualStyleBackColor = true;
            // 
            // BtnTractoresFiltro
            // 
            this.BtnTractoresFiltro.Location = new System.Drawing.Point(303, 79);
            this.BtnTractoresFiltro.Name = "BtnTractoresFiltro";
            this.BtnTractoresFiltro.Size = new System.Drawing.Size(59, 23);
            this.BtnTractoresFiltro.TabIndex = 12;
            this.BtnTractoresFiltro.Text = "Buscar";
            this.BtnTractoresFiltro.UseVisualStyleBackColor = true;
            // 
            // btnTractoresNuevo
            // 
            this.btnTractoresNuevo.Location = new System.Drawing.Point(395, 78);
            this.btnTractoresNuevo.Name = "btnTractoresNuevo";
            this.btnTractoresNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnTractoresNuevo.TabIndex = 11;
            this.btnTractoresNuevo.Text = "Nuevo Chofer";
            this.btnTractoresNuevo.UseVisualStyleBackColor = true;
            this.btnTractoresNuevo.Click += new System.EventHandler(this.btnTractoresNuevo_Click);
            // 
            // dgvTractores
            // 
            this.dgvTractores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTractores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTractores.Location = new System.Drawing.Point(34, 107);
            this.dgvTractores.MultiSelect = false;
            this.dgvTractores.Name = "dgvTractores";
            this.dgvTractores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTractores.Size = new System.Drawing.Size(453, 263);
            this.dgvTractores.TabIndex = 10;
            this.dgvTractores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTractores_CellDoubleClick);
            // 
            // tbxTractoresFiltro
            // 
            this.tbxTractoresFiltro.Location = new System.Drawing.Point(73, 81);
            this.tbxTractoresFiltro.Name = "tbxTractoresFiltro";
            this.tbxTractoresFiltro.Size = new System.Drawing.Size(224, 20);
            this.tbxTractoresFiltro.TabIndex = 9;
            // 
            // lblTractoresFiltro
            // 
            this.lblTractoresFiltro.AutoSize = true;
            this.lblTractoresFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTractoresFiltro.Location = new System.Drawing.Point(33, 85);
            this.lblTractoresFiltro.Name = "lblTractoresFiltro";
            this.lblTractoresFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblTractoresFiltro.TabIndex = 8;
            this.lblTractoresFiltro.Text = "Filtro";
            // 
            // lblTractoresTitulo
            // 
            this.lblTractoresTitulo.AutoSize = true;
            this.lblTractoresTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTractoresTitulo.Location = new System.Drawing.Point(169, 24);
            this.lblTractoresTitulo.Name = "lblTractoresTitulo";
            this.lblTractoresTitulo.Size = new System.Drawing.Size(196, 33);
            this.lblTractoresTitulo.TabIndex = 7;
            this.lblTractoresTitulo.Text = "TRACTORES";
            // 
            // FrmTractores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 422);
            this.Controls.Add(this.btnTractoresClose);
            this.Controls.Add(this.BtnTractoresFiltro);
            this.Controls.Add(this.btnTractoresNuevo);
            this.Controls.Add(this.dgvTractores);
            this.Controls.Add(this.tbxTractoresFiltro);
            this.Controls.Add(this.lblTractoresFiltro);
            this.Controls.Add(this.lblTractoresTitulo);
            this.Name = "FrmTractores";
            this.Text = "FrmTractores";
            this.Load += new System.EventHandler(this.FrmTractores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTractores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTractoresClose;
        private System.Windows.Forms.Button BtnTractoresFiltro;
        private System.Windows.Forms.Button btnTractoresNuevo;
        private System.Windows.Forms.DataGridView dgvTractores;
        private System.Windows.Forms.TextBox tbxTractoresFiltro;
        private System.Windows.Forms.Label lblTractoresFiltro;
        private System.Windows.Forms.Label lblTractoresTitulo;
    }
}