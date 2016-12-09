namespace SGR.WinApp.Layout._1_Tablas_Maestras.TablaArancel
{
    partial class Frm_TablaArancel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBotonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarTablaArancel = new System.Windows.Forms.DataGridView();
            this.xidTablaArancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xregistro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTablaArancel)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(455, 27);
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
            this.toolStripBotonNuevo.Text = "Nuevo";
            this.toolStripBotonNuevo.Click += new System.EventHandler(this.toolStripBotonNuevo_Click);
            // 
            // toolStripBotonModificar
            // 
            this.toolStripBotonModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonModificar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.toolStripBotonModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonModificar.Name = "toolStripBotonModificar";
            this.toolStripBotonModificar.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonModificar.Text = "Modificar";
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
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(147, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(194, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda:";
            // 
            // dgvListarTablaArancel
            // 
            this.dgvListarTablaArancel.AllowUserToAddRows = false;
            this.dgvListarTablaArancel.AllowUserToDeleteRows = false;
            this.dgvListarTablaArancel.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarTablaArancel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarTablaArancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTablaArancel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xidTablaArancel,
            this.xCosto,
            this.xDescripcion,
            this.xEstado,
            this.xregistro_fecha_add,
            this.xregistro_user_add,
            this.xregistro_pc_add,
            this.xregistro_fecha_update,
            this.xregistro_user_update,
            this.xregistro_pc_update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarTablaArancel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarTablaArancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarTablaArancel.EnableHeadersVisualStyles = false;
            this.dgvListarTablaArancel.Location = new System.Drawing.Point(0, 80);
            this.dgvListarTablaArancel.MultiSelect = false;
            this.dgvListarTablaArancel.Name = "dgvListarTablaArancel";
            this.dgvListarTablaArancel.ReadOnly = true;
            this.dgvListarTablaArancel.RowHeadersVisible = false;
            this.dgvListarTablaArancel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarTablaArancel.Size = new System.Drawing.Size(455, 243);
            this.dgvListarTablaArancel.TabIndex = 2;
            this.dgvListarTablaArancel.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarTablaArancel_ColumnHeaderMouseClick);
            this.dgvListarTablaArancel.DoubleClick += new System.EventHandler(this.dgvListarTablaArancel_DoubleClick);
            // 
            // xidTablaArancel
            // 
            this.xidTablaArancel.DataPropertyName = "idTablaArancel";
            this.xidTablaArancel.HeaderText = "Código";
            this.xidTablaArancel.Name = "xidTablaArancel";
            this.xidTablaArancel.ReadOnly = true;
            this.xidTablaArancel.Visible = false;
            // 
            // xCosto
            // 
            this.xCosto.DataPropertyName = "Costo";
            this.xCosto.HeaderText = "Costo";
            this.xCosto.Name = "xCosto";
            this.xCosto.ReadOnly = true;
            this.xCosto.Visible = false;
            // 
            // xDescripcion
            // 
            this.xDescripcion.DataPropertyName = "Descripcion";
            this.xDescripcion.HeaderText = "Descripción";
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.ReadOnly = true;
            this.xDescripcion.Width = 350;
            // 
            // xEstado
            // 
            this.xEstado.DataPropertyName = "Estado";
            this.xEstado.HeaderText = "Activo?";
            this.xEstado.Name = "xEstado";
            this.xEstado.ReadOnly = true;
            this.xEstado.Width = 60;
            // 
            // xregistro_fecha_add
            // 
            this.xregistro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.xregistro_fecha_add.HeaderText = "Fecha add";
            this.xregistro_fecha_add.Name = "xregistro_fecha_add";
            this.xregistro_fecha_add.ReadOnly = true;
            this.xregistro_fecha_add.Visible = false;
            // 
            // xregistro_user_add
            // 
            this.xregistro_user_add.DataPropertyName = "registro_user_add";
            this.xregistro_user_add.HeaderText = "Usuario add";
            this.xregistro_user_add.Name = "xregistro_user_add";
            this.xregistro_user_add.ReadOnly = true;
            this.xregistro_user_add.Visible = false;
            // 
            // xregistro_pc_add
            // 
            this.xregistro_pc_add.DataPropertyName = "registro_pc_add";
            this.xregistro_pc_add.HeaderText = "Pc add";
            this.xregistro_pc_add.Name = "xregistro_pc_add";
            this.xregistro_pc_add.ReadOnly = true;
            this.xregistro_pc_add.Visible = false;
            // 
            // xregistro_fecha_update
            // 
            this.xregistro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.xregistro_fecha_update.HeaderText = "Fecha Update";
            this.xregistro_fecha_update.Name = "xregistro_fecha_update";
            this.xregistro_fecha_update.ReadOnly = true;
            this.xregistro_fecha_update.Visible = false;
            // 
            // xregistro_user_update
            // 
            this.xregistro_user_update.DataPropertyName = "registro_user_update";
            this.xregistro_user_update.HeaderText = "Usuario Update";
            this.xregistro_user_update.Name = "xregistro_user_update";
            this.xregistro_user_update.ReadOnly = true;
            this.xregistro_user_update.Visible = false;
            // 
            // xregistro_pc_update
            // 
            this.xregistro_pc_update.DataPropertyName = "registro_pc_update";
            this.xregistro_pc_update.HeaderText = "Pc update";
            this.xregistro_pc_update.Name = "xregistro_pc_update";
            this.xregistro_pc_update.ReadOnly = true;
            this.xregistro_pc_update.Visible = false;
            // 
            // Frm_TablaArancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 323);
            this.Controls.Add(this.dgvListarTablaArancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TablaArancel";
            this.Text = "Listado Tabla Arancel";
            this.Load += new System.EventHandler(this.Frm_TablaArancel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTablaArancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBotonNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBotonModificar;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarTablaArancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidTablaArancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_update;
    }
}