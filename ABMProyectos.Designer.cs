namespace NewWareSoft.Negocio.ABM
{
    partial class ABMProyecto
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
            this.btnCargarGrilla = new System.Windows.Forms.Button();
            this.grillaProyecto = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.mskFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDProyecto = new System.Windows.Forms.Label();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskFechaFinProb = new System.Windows.Forms.MaskedTextBox();
            this.CodProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin_prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarGrilla
            // 
            this.btnCargarGrilla.BackColor = System.Drawing.Color.Silver;
            this.btnCargarGrilla.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnCargarGrilla.Location = new System.Drawing.Point(911, 196);
            this.btnCargarGrilla.Name = "btnCargarGrilla";
            this.btnCargarGrilla.Size = new System.Drawing.Size(134, 31);
            this.btnCargarGrilla.TabIndex = 38;
            this.btnCargarGrilla.Text = "Cargar grilla";
            this.btnCargarGrilla.UseVisualStyleBackColor = false;
            this.btnCargarGrilla.Click += new System.EventHandler(this.btnCargarGrilla_Click);
            // 
            // grillaProyecto
            // 
            this.grillaProyecto.AllowUserToAddRows = false;
            this.grillaProyecto.AllowUserToDeleteRows = false;
            this.grillaProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProyecto,
            this.Descripcion,
            this.IdCliente,
            this.FecInicio,
            this.fecha_fin_prob,
            this.fecha_fin});
            this.grillaProyecto.Location = new System.Drawing.Point(201, 38);
            this.grillaProyecto.Name = "grillaProyecto";
            this.grillaProyecto.ReadOnly = true;
            this.grillaProyecto.RowHeadersWidth = 51;
            this.grillaProyecto.RowTemplate.Height = 25;
            this.grillaProyecto.Size = new System.Drawing.Size(704, 304);
            this.grillaProyecto.TabIndex = 43;
            this.grillaProyecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(630, 365);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(154, 38);
            this.btnLimpiarCampos.TabIndex = 41;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBaja.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnBaja.Location = new System.Drawing.Point(911, 250);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(134, 31);
            this.btnBaja.TabIndex = 37;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(403, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 38);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnModificar.Location = new System.Drawing.Point(911, 146);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 31);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bntAgregar
            // 
            this.bntAgregar.BackColor = System.Drawing.Color.Silver;
            this.bntAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.bntAgregar.Location = new System.Drawing.Point(911, 97);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(134, 31);
            this.bntAgregar.TabIndex = 35;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = false;
            this.bntAgregar.Click += new System.EventHandler(this.bntAgregar_Click);
            // 
            // mskFechaInicio
            // 
            this.mskFechaInicio.Location = new System.Drawing.Point(117, 315);
            this.mskFechaInicio.Mask = "00/00/0000";
            this.mskFechaInicio.Name = "mskFechaInicio";
            this.mskFechaInicio.Size = new System.Drawing.Size(67, 20);
            this.mskFechaInicio.TabIndex = 30;
            this.mskFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(26, 168);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(157, 20);
            this.txtDescripcion.TabIndex = 29;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(27, 84);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(157, 20);
            this.txtIdCliente.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(16, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha de inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "ABM Proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "ID de cliente:";
            // 
            // lblIDProyecto
            // 
            this.lblIDProyecto.AutoSize = true;
            this.lblIDProyecto.BackColor = System.Drawing.Color.Transparent;
            this.lblIDProyecto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblIDProyecto.Location = new System.Drawing.Point(15, 233);
            this.lblIDProyecto.Name = "lblIDProyecto";
            this.lblIDProyecto.Size = new System.Drawing.Size(119, 19);
            this.lblIDProyecto.TabIndex = 48;
            this.lblIDProyecto.Text = "ID del proyecto:";
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Location = new System.Drawing.Point(27, 261);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(157, 20);
            this.txtIdProyecto.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label5.Location = new System.Drawing.Point(15, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Fecha probable de fin:";
            // 
            // mskFechaFinProb
            // 
            this.mskFechaFinProb.Location = new System.Drawing.Point(117, 383);
            this.mskFechaFinProb.Mask = "00/00/0000";
            this.mskFechaFinProb.Name = "mskFechaFinProb";
            this.mskFechaFinProb.Size = new System.Drawing.Size(67, 20);
            this.mskFechaFinProb.TabIndex = 51;
            this.mskFechaFinProb.ValidatingType = typeof(System.DateTime);
            // 
            // CodProyecto
            // 
            this.CodProyecto.DataPropertyName = "codigo";
            this.CodProyecto.HeaderText = "Codigo Proyecto";
            this.CodProyecto.MinimumWidth = 6;
            this.CodProyecto.Name = "CodProyecto";
            this.CodProyecto.ReadOnly = true;
            this.CodProyecto.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "id_cliente";
            this.IdCliente.HeaderText = "ID Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 125;
            // 
            // FecInicio
            // 
            this.FecInicio.DataPropertyName = "fecha_inicio";
            this.FecInicio.HeaderText = "Fecha Inicio";
            this.FecInicio.MinimumWidth = 6;
            this.FecInicio.Name = "FecInicio";
            this.FecInicio.ReadOnly = true;
            this.FecInicio.Width = 125;
            // 
            // fecha_fin_prob
            // 
            this.fecha_fin_prob.DataPropertyName = "fecha_fin_probable";
            this.fecha_fin_prob.HeaderText = "Fecha Probable Fin";
            this.fecha_fin_prob.Name = "fecha_fin_prob";
            this.fecha_fin_prob.ReadOnly = true;
            // 
            // fecha_fin
            // 
            this.fecha_fin.DataPropertyName = "fecha_fin_real";
            this.fecha_fin.HeaderText = "Fecha Fin";
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.ReadOnly = true;
            // 
            // ABMProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 428);
            this.Controls.Add(this.mskFechaFinProb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.lblIDProyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCargarGrilla);
            this.Controls.Add(this.grillaProyecto);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.bntAgregar);
            this.Controls.Add(this.mskFechaInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMProyectos";
            this.Load += new System.EventHandler(this.ABMProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarGrilla;
        private System.Windows.Forms.DataGridView grillaProyecto;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.MaskedTextBox mskFechaInicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDProyecto;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskFechaFinProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin_prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin;
    }
}