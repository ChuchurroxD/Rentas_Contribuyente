namespace SGR.WinApp.Layout._1_Tablas_Maestras.TasaCambio
{
    partial class Frm_TasaCambio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBotonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarTasaCambio = new System.Windows.Forms.DataGridView();
            this.xidTasaCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xprecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xprecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xregistro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantTasaCambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTasaCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantTasaCambioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBotonNuevo,
            this.toolStripBotonModificar,
            this.toolStripBotonReporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBotonNuevo
            // 
            this.toolStripBotonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonNuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolStripBotonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonNuevo.Name = "toolStripBotonNuevo";
            this.toolStripBotonNuevo.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonNuevo.Text = "toolStripButton1";
            this.toolStripBotonNuevo.Click += new System.EventHandler(this.toolStripBotonNuevo_Click);
            // 
            // toolStripBotonModificar
            // 
            this.toolStripBotonModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonModificar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.toolStripBotonModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonModificar.Name = "toolStripBotonModificar";
            this.toolStripBotonModificar.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonModificar.Text = "toolStripButton2";
            this.toolStripBotonModificar.Click += new System.EventHandler(this.toolStripBotonModificar_Click);
            // 
            // toolStripBotonReporte
            // 
            this.toolStripBotonReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolStripBotonReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonReporte.Name = "toolStripBotonReporte";
            this.toolStripBotonReporte.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonReporte.Text = "Reporte";
            this.toolStripBotonReporte.Click += new System.EventHandler(this.toolStripBotonReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(104, 19);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 2;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(247, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda:";
            // 
            // dgvListarTasaCambio
            // 
            this.dgvListarTasaCambio.AllowUserToAddRows = false;
            this.dgvListarTasaCambio.AllowUserToDeleteRows = false;
            this.dgvListarTasaCambio.AutoGenerateColumns = false;
            this.dgvListarTasaCambio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarTasaCambio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarTasaCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTasaCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xidTasaCambio,
            this.xfecha,
            this.xprecioVenta,
            this.xprecioCompra,
            this.xestado,
            this.xregistro_fecha_add,
            this.xregistro_user_add,
            this.xregistro_pc_add,
            this.xregistro_fecha_update,
            this.xregistro_user_update,
            this.xregistro_pc_update});
            this.dgvListarTasaCambio.DataSource = this.mantTasaCambioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarTasaCambio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarTasaCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarTasaCambio.EnableHeadersVisualStyles = false;
            this.dgvListarTasaCambio.Location = new System.Drawing.Point(0, 79);
            this.dgvListarTasaCambio.MultiSelect = false;
            this.dgvListarTasaCambio.Name = "dgvListarTasaCambio";
            this.dgvListarTasaCambio.ReadOnly = true;
            this.dgvListarTasaCambio.RowHeadersVisible = false;
            this.dgvListarTasaCambio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarTasaCambio.Size = new System.Drawing.Size(588, 310);
            this.dgvListarTasaCambio.TabIndex = 2;
            this.dgvListarTasaCambio.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarTasaCambio_ColumnHeaderMouseClick);
            this.dgvListarTasaCambio.DoubleClick += new System.EventHandler(this.dgvListarTasaCambio_DoubleClick);
            // 
            // xidTasaCambio
            // 
            this.xidTasaCambio.DataPropertyName = "idTasaCambio";
            this.xidTasaCambio.HeaderText = "idTasaCambio";
            this.xidTasaCambio.Name = "xidTasaCambio";
            this.xidTasaCambio.ReadOnly = true;
            this.xidTasaCambio.Visible = false;
            // 
            // xfecha
            // 
            this.xfecha.DataPropertyName = "fecha";
            this.xfecha.HeaderText = "Fecha";
            this.xfecha.Name = "xfecha";
            this.xfecha.ReadOnly = true;
            // 
            // xprecioVenta
            // 
            this.xprecioVenta.DataPropertyName = "precioVenta";
            this.xprecioVenta.HeaderText = "Precio Venta";
            this.xprecioVenta.Name = "xprecioVenta";
            this.xprecioVenta.ReadOnly = true;
            // 
            // xprecioCompra
            // 
            this.xprecioCompra.DataPropertyName = "precioCompra";
            this.xprecioCompra.HeaderText = "Precio Compra";
            this.xprecioCompra.Name = "xprecioCompra";
            this.xprecioCompra.ReadOnly = true;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "estado";
            this.xestado.HeaderText = "Activo ?";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            // 
            // xregistro_fecha_add
            // 
            this.xregistro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.xregistro_fecha_add.HeaderText = "registro_fecha_add";
            this.xregistro_fecha_add.Name = "xregistro_fecha_add";
            this.xregistro_fecha_add.ReadOnly = true;
            this.xregistro_fecha_add.Visible = false;
            // 
            // xregistro_user_add
            // 
            this.xregistro_user_add.DataPropertyName = "registro_user_add";
            this.xregistro_user_add.HeaderText = "registro_user_add";
            this.xregistro_user_add.Name = "xregistro_user_add";
            this.xregistro_user_add.ReadOnly = true;
            this.xregistro_user_add.Visible = false;
            // 
            // xregistro_pc_add
            // 
            this.xregistro_pc_add.DataPropertyName = "registro_pc_add";
            this.xregistro_pc_add.HeaderText = "registro_pc_add";
            this.xregistro_pc_add.Name = "xregistro_pc_add";
            this.xregistro_pc_add.ReadOnly = true;
            this.xregistro_pc_add.Visible = false;
            // 
            // xregistro_fecha_update
            // 
            this.xregistro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.xregistro_fecha_update.HeaderText = "registro_fecha_update";
            this.xregistro_fecha_update.Name = "xregistro_fecha_update";
            this.xregistro_fecha_update.ReadOnly = true;
            this.xregistro_fecha_update.Visible = false;
            // 
            // xregistro_user_update
            // 
            this.xregistro_user_update.DataPropertyName = "registro_user_update";
            this.xregistro_user_update.HeaderText = "registro_user_update";
            this.xregistro_user_update.Name = "xregistro_user_update";
            this.xregistro_user_update.ReadOnly = true;
            this.xregistro_user_update.Visible = false;
            // 
            // xregistro_pc_update
            // 
            this.xregistro_pc_update.DataPropertyName = "registro_pc_update";
            this.xregistro_pc_update.HeaderText = "registro_pc_update";
            this.xregistro_pc_update.Name = "xregistro_pc_update";
            this.xregistro_pc_update.ReadOnly = true;
            this.xregistro_pc_update.Visible = false;
            // 
            // mantTasaCambioBindingSource
            // 
            this.mantTasaCambioBindingSource.DataSource = typeof(SGR.Entity.Model.Mant_TasaCambio);
            // 
            // Frm_TasaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 389);
            this.Controls.Add(this.dgvListarTasaCambio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TasaCambio";
            this.Text = "Listar Tasa Cambio";
            this.Load += new System.EventHandler(this.Frm_TasaCambio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTasaCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantTasaCambioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBotonNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBotonModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarTasaCambio;
        private System.Windows.Forms.BindingSource mantTasaCambioBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidTasaCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xprecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xprecioCompra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_update;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox textBox1;
    }
}