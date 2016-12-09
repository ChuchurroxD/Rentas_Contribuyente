namespace SGR.WinApp.Layout._1_Tablas_Maestras.ValoresArbitrios
{
    partial class Frm_ValoresArbitrios
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
            this.comboBusquedaPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarValoresArbitrio = new System.Windows.Forms.DataGridView();
            this.xidValoresArbitrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidTablaArancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcionTablaArancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidCodificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registrofechaaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrouseraddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registropcaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrofechaupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrouserupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registropcupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantValoresArbitriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarValoresArbitrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantValoresArbitriosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBotonNuevo,
            this.toolStripBotonModificar,
            this.toolStripBotonReporte,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(741, 27);
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
            this.groupBox1.Controls.Add(this.comboBusquedaPeriodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // comboBusquedaPeriodo
            // 
            this.comboBusquedaPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaPeriodo.FormattingEnabled = true;
            this.comboBusquedaPeriodo.Location = new System.Drawing.Point(218, 19);
            this.comboBusquedaPeriodo.Name = "comboBusquedaPeriodo";
            this.comboBusquedaPeriodo.Size = new System.Drawing.Size(191, 21);
            this.comboBusquedaPeriodo.TabIndex = 1;
            this.comboBusquedaPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaPeriodo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda: ";
            // 
            // dgvListarValoresArbitrio
            // 
            this.dgvListarValoresArbitrio.AllowUserToAddRows = false;
            this.dgvListarValoresArbitrio.AllowUserToDeleteRows = false;
            this.dgvListarValoresArbitrio.AutoGenerateColumns = false;
            this.dgvListarValoresArbitrio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarValoresArbitrio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarValoresArbitrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarValoresArbitrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xidValoresArbitrio,
            this.xidTablaArancel,
            this.xidPeriodo,
            this.xdescripcionTablaArancel,
            this.xCosto,
            this.xidCodificador,
            this.xRubro,
            this.xRecurso,
            this.xEstado,
            this.registrofechaaddDataGridViewTextBoxColumn,
            this.registrouseraddDataGridViewTextBoxColumn,
            this.registropcaddDataGridViewTextBoxColumn,
            this.registrofechaupdateDataGridViewTextBoxColumn,
            this.registrouserupdateDataGridViewTextBoxColumn,
            this.registropcupdateDataGridViewTextBoxColumn});
            this.dgvListarValoresArbitrio.DataSource = this.mantValoresArbitriosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarValoresArbitrio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarValoresArbitrio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarValoresArbitrio.EnableHeadersVisualStyles = false;
            this.dgvListarValoresArbitrio.Location = new System.Drawing.Point(0, 81);
            this.dgvListarValoresArbitrio.MultiSelect = false;
            this.dgvListarValoresArbitrio.Name = "dgvListarValoresArbitrio";
            this.dgvListarValoresArbitrio.ReadOnly = true;
            this.dgvListarValoresArbitrio.RowHeadersVisible = false;
            this.dgvListarValoresArbitrio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarValoresArbitrio.Size = new System.Drawing.Size(741, 247);
            this.dgvListarValoresArbitrio.TabIndex = 2;
            this.dgvListarValoresArbitrio.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarValoresArbitrio_ColumnHeaderMouseClick);
            this.dgvListarValoresArbitrio.DoubleClick += new System.EventHandler(this.dgvListarValoresArbitrio_DoubleClick);
            // 
            // xidValoresArbitrio
            // 
            this.xidValoresArbitrio.DataPropertyName = "idValoresArbitrio";
            this.xidValoresArbitrio.HeaderText = "Codigo";
            this.xidValoresArbitrio.Name = "xidValoresArbitrio";
            this.xidValoresArbitrio.ReadOnly = true;
            this.xidValoresArbitrio.Visible = false;
            // 
            // xidTablaArancel
            // 
            this.xidTablaArancel.DataPropertyName = "idTablaArancel";
            this.xidTablaArancel.HeaderText = "Codigo Tabla Arancel";
            this.xidTablaArancel.Name = "xidTablaArancel";
            this.xidTablaArancel.ReadOnly = true;
            this.xidTablaArancel.Visible = false;
            // 
            // xidPeriodo
            // 
            this.xidPeriodo.DataPropertyName = "idPeriodo";
            this.xidPeriodo.HeaderText = "Año";
            this.xidPeriodo.Name = "xidPeriodo";
            this.xidPeriodo.ReadOnly = true;
            this.xidPeriodo.Width = 60;
            // 
            // xdescripcionTablaArancel
            // 
            this.xdescripcionTablaArancel.DataPropertyName = "descripcionTablaArancel";
            this.xdescripcionTablaArancel.HeaderText = "Tabla Arancel";
            this.xdescripcionTablaArancel.Name = "xdescripcionTablaArancel";
            this.xdescripcionTablaArancel.ReadOnly = true;
            this.xdescripcionTablaArancel.Width = 250;
            // 
            // xCosto
            // 
            this.xCosto.DataPropertyName = "Costo";
            this.xCosto.HeaderText = "Costo";
            this.xCosto.Name = "xCosto";
            this.xCosto.ReadOnly = true;
            this.xCosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // xidCodificador
            // 
            this.xidCodificador.DataPropertyName = "idCodificador";
            this.xidCodificador.HeaderText = "Codificador";
            this.xidCodificador.Name = "xidCodificador";
            this.xidCodificador.ReadOnly = true;
            // 
            // xRubro
            // 
            this.xRubro.DataPropertyName = "Rubro";
            this.xRubro.HeaderText = "Rubro";
            this.xRubro.Name = "xRubro";
            this.xRubro.ReadOnly = true;
            this.xRubro.Width = 60;
            // 
            // xRecurso
            // 
            this.xRecurso.DataPropertyName = "Recurso";
            this.xRecurso.HeaderText = "Recurso";
            this.xRecurso.Name = "xRecurso";
            this.xRecurso.ReadOnly = true;
            this.xRecurso.Width = 60;
            // 
            // xEstado
            // 
            this.xEstado.DataPropertyName = "Estado";
            this.xEstado.HeaderText = "Estado";
            this.xEstado.Name = "xEstado";
            this.xEstado.ReadOnly = true;
            this.xEstado.Width = 60;
            // 
            // registrofechaaddDataGridViewTextBoxColumn
            // 
            this.registrofechaaddDataGridViewTextBoxColumn.DataPropertyName = "registro_fecha_add";
            this.registrofechaaddDataGridViewTextBoxColumn.HeaderText = "registro_fecha_add";
            this.registrofechaaddDataGridViewTextBoxColumn.Name = "registrofechaaddDataGridViewTextBoxColumn";
            this.registrofechaaddDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrofechaaddDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrouseraddDataGridViewTextBoxColumn
            // 
            this.registrouseraddDataGridViewTextBoxColumn.DataPropertyName = "registro_user_add";
            this.registrouseraddDataGridViewTextBoxColumn.HeaderText = "registro_user_add";
            this.registrouseraddDataGridViewTextBoxColumn.Name = "registrouseraddDataGridViewTextBoxColumn";
            this.registrouseraddDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrouseraddDataGridViewTextBoxColumn.Visible = false;
            // 
            // registropcaddDataGridViewTextBoxColumn
            // 
            this.registropcaddDataGridViewTextBoxColumn.DataPropertyName = "registro_pc_add";
            this.registropcaddDataGridViewTextBoxColumn.HeaderText = "registro_pc_add";
            this.registropcaddDataGridViewTextBoxColumn.Name = "registropcaddDataGridViewTextBoxColumn";
            this.registropcaddDataGridViewTextBoxColumn.ReadOnly = true;
            this.registropcaddDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrofechaupdateDataGridViewTextBoxColumn
            // 
            this.registrofechaupdateDataGridViewTextBoxColumn.DataPropertyName = "registro_fecha_update";
            this.registrofechaupdateDataGridViewTextBoxColumn.HeaderText = "registro_fecha_update";
            this.registrofechaupdateDataGridViewTextBoxColumn.Name = "registrofechaupdateDataGridViewTextBoxColumn";
            this.registrofechaupdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrofechaupdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrouserupdateDataGridViewTextBoxColumn
            // 
            this.registrouserupdateDataGridViewTextBoxColumn.DataPropertyName = "registro_user_update";
            this.registrouserupdateDataGridViewTextBoxColumn.HeaderText = "registro_user_update";
            this.registrouserupdateDataGridViewTextBoxColumn.Name = "registrouserupdateDataGridViewTextBoxColumn";
            this.registrouserupdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrouserupdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // registropcupdateDataGridViewTextBoxColumn
            // 
            this.registropcupdateDataGridViewTextBoxColumn.DataPropertyName = "registro_pc_update";
            this.registropcupdateDataGridViewTextBoxColumn.HeaderText = "registro_pc_update";
            this.registropcupdateDataGridViewTextBoxColumn.Name = "registropcupdateDataGridViewTextBoxColumn";
            this.registropcupdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registropcupdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // mantValoresArbitriosBindingSource
            // 
            this.mantValoresArbitriosBindingSource.DataSource = typeof(SGR.Entity.Model.Mant_ValoresArbitrios);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Frm_ValoresArbitrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 328);
            this.Controls.Add(this.dgvListarValoresArbitrio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ValoresArbitrios";
            this.Text = "Listado Valores Arbitrios";
            this.Load += new System.EventHandler(this.Frm_ValoresArbitrios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarValoresArbitrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantValoresArbitriosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBotonNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBotonModificar;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBusquedaPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarValoresArbitrio;
        private System.Windows.Forms.BindingSource mantValoresArbitriosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidValoresArbitrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidTablaArancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcionTablaArancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidCodificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRecurso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrofechaaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrouseraddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registropcaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrofechaupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrouserupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registropcupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}