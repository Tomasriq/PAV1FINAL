namespace NewWareSoft.Negocio.ABM
{
    partial class ABMProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mskFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDenominacion = new System.Windows.Forms.Label();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecFinDesarrollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.groupBoxProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grillaProductos);
            this.groupBox1.Location = new System.Drawing.Point(461, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(590, 364);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Listado de productos";
            // 
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.AllowUserToDeleteRows = false;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.Denominacion,
            this.Descripcion,
            this.FecFinDesarrollo});
            this.grillaProductos.Location = new System.Drawing.Point(18, 55);
            this.grillaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.ReadOnly = true;
            this.grillaProductos.RowHeadersWidth = 51;
            this.grillaProductos.RowTemplate.Height = 29;
            this.grillaProductos.Size = new System.Drawing.Size(554, 297);
            this.grillaProductos.TabIndex = 2;
            this.grillaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProductos_CellContentClick);
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Controls.Add(this.btnCancelar);
            this.groupBoxProductos.Controls.Add(this.btnActualizarProducto);
            this.groupBoxProductos.Controls.Add(this.btnGuardarProducto);
            this.groupBoxProductos.Controls.Add(this.btnNuevoProducto);
            this.groupBoxProductos.Controls.Add(this.label6);
            this.groupBoxProductos.Controls.Add(this.btnEliminarProd);
            this.groupBoxProductos.Controls.Add(this.txtIdProducto);
            this.groupBoxProductos.Controls.Add(this.lblIdProducto);
            this.groupBoxProductos.Controls.Add(this.txtDenominacion);
            this.groupBoxProductos.Controls.Add(this.txtDescripcion);
            this.groupBoxProductos.Controls.Add(this.mskFechaFin);
            this.groupBoxProductos.Controls.Add(this.lblFechaProducto);
            this.groupBoxProductos.Controls.Add(this.lblDescripcion);
            this.groupBoxProductos.Controls.Add(this.lblDenominacion);
            this.groupBoxProductos.Location = new System.Drawing.Point(36, 21);
            this.groupBoxProductos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProductos.Size = new System.Drawing.Size(402, 393);
            this.groupBoxProductos.TabIndex = 11;
            this.groupBoxProductos.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(8, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 27);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.Location = new System.Drawing.Point(178, 250);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(143, 27);
            this.btnActualizarProducto.TabIndex = 18;
            this.btnActualizarProducto.Text = "Modificar Producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = false;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Location = new System.Drawing.Point(178, 205);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(143, 27);
            this.btnGuardarProducto.TabIndex = 17;
            this.btnGuardarProducto.Text = "Cargar Producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.Silver;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnNuevoProducto.Location = new System.Drawing.Point(179, 337);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(143, 27);
            this.btnNuevoProducto.TabIndex = 8;
            this.btnNuevoProducto.Text = "Limpiar Campos";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Productos";
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEliminarProd.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnEliminarProd.Location = new System.Drawing.Point(179, 294);
            this.btnEliminarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(143, 27);
            this.btnEliminarProd.TabIndex = 15;
            this.btnEliminarProd.Text = "Eliminar Producto";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdProducto.Location = new System.Drawing.Point(178, 44);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(200, 20);
            this.txtIdProducto.TabIndex = 13;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblIdProducto.ForeColor = System.Drawing.Color.Black;
            this.lblIdProducto.Location = new System.Drawing.Point(81, 45);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(89, 19);
            this.lblIdProducto.TabIndex = 12;
            this.lblIdProducto.Text = "Id Producto";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(178, 77);
            this.txtDenominacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(200, 20);
            this.txtDenominacion.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(178, 111);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 51);
            this.txtDescripcion.TabIndex = 7;
            // 
            // mskFechaFin
            // 
            this.mskFechaFin.Location = new System.Drawing.Point(178, 165);
            this.mskFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.mskFechaFin.Mask = "00/00/0000";
            this.mskFechaFin.Name = "mskFechaFin";
            this.mskFechaFin.Size = new System.Drawing.Size(67, 20);
            this.mskFechaFin.TabIndex = 6;
            this.mskFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaProducto
            // 
            this.lblFechaProducto.AutoSize = true;
            this.lblFechaProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblFechaProducto.ForeColor = System.Drawing.Color.Black;
            this.lblFechaProducto.Location = new System.Drawing.Point(4, 166);
            this.lblFechaProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaProducto.Name = "lblFechaProducto";
            this.lblFechaProducto.Size = new System.Drawing.Size(170, 19);
            this.lblFechaProducto.TabIndex = 5;
            this.lblFechaProducto.Text = "Fecha fin de desarrollo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(81, 124);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblDenominacion
            // 
            this.lblDenominacion.AutoSize = true;
            this.lblDenominacion.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblDenominacion.ForeColor = System.Drawing.Color.Black;
            this.lblDenominacion.Location = new System.Drawing.Point(59, 76);
            this.lblDenominacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenominacion.Name = "lblDenominacion";
            this.lblDenominacion.Size = new System.Drawing.Size(115, 19);
            this.lblDenominacion.TabIndex = 3;
            this.lblDenominacion.Text = "Denominación:";
            // 
            // CodProducto
            // 
            this.CodProducto.DataPropertyName = "codigo";
            this.CodProducto.HeaderText = "Código Producto";
            this.CodProducto.MinimumWidth = 6;
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Width = 125;
            // 
            // Denominacion
            // 
            this.Denominacion.DataPropertyName = "denominacion";
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.MinimumWidth = 6;
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.ReadOnly = true;
            this.Denominacion.Width = 125;
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
            // FecFinDesarrollo
            // 
            this.FecFinDesarrollo.DataPropertyName = "fecha_fin_desarrollo";
            this.FecFinDesarrollo.HeaderText = "Fecha Fin Desarrollo";
            this.FecFinDesarrollo.MinimumWidth = 6;
            this.FecFinDesarrollo.Name = "FecFinDesarrollo";
            this.FecFinDesarrollo.ReadOnly = true;
            this.FecFinDesarrollo.Width = 125;
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProductos);
            this.Name = "ABMProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMProductos";
            this.Load += new System.EventHandler(this.ABMProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox mskFechaFin;
        private System.Windows.Forms.Label lblFechaProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDenominacion;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecFinDesarrollo;
    }
}