namespace SGR.WinApp.Layout._1_Tablas_Maestras.Vias
{
    partial class Frm_Vias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarVias = new System.Windows.Forms.DataGridView();
            this.viaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTipoViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAntiguoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.predViasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.predViasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predViasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.predViasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEditar,
            this.toolReporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(517, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolNuevo
            // 
            this.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(24, 24);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolEditar
            // 
            this.toolEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.toolEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditar.Name = "toolEditar";
            this.toolEditar.Size = new System.Drawing.Size(24, 24);
            this.toolEditar.Text = "Editar";
            this.toolEditar.Click += new System.EventHandler(this.toolEditar_Click);
            // 
            // toolReporte
            // 
            this.toolReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReporte.Name = "toolReporte";
            this.toolReporte.Size = new System.Drawing.Size(24, 24);
            this.toolReporte.Text = "Reporte";
            this.toolReporte.Click += new System.EventHandler(this.toolReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(150, 25);
            this.txtBusqueda.MaxLength = 150;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(255, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda: ";
            // 
            // dgvListarVias
            // 
            this.dgvListarVias.AllowUserToAddRows = false;
            this.dgvListarVias.AllowUserToDeleteRows = false;
            this.dgvListarVias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarVias.AutoGenerateColumns = false;
            this.dgvListarVias.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarVias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarVias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarVias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viaidDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoViaDataGridViewTextBoxColumn,
            this.descripcionTipoViaDataGridViewTextBoxColumn,
            this.codigoAntiguoDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dgvListarVias.DataSource = this.predViasBindingSource3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarVias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListarVias.EnableHeadersVisualStyles = false;
            this.dgvListarVias.Location = new System.Drawing.Point(0, 95);
            this.dgvListarVias.MultiSelect = false;
            this.dgvListarVias.Name = "dgvListarVias";
            this.dgvListarVias.ReadOnly = true;
            this.dgvListarVias.RowHeadersVisible = false;
            this.dgvListarVias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarVias.Size = new System.Drawing.Size(512, 247);
            this.dgvListarVias.TabIndex = 2;
            this.dgvListarVias.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarVias_ColumnHeaderMouseClick);
            this.dgvListarVias.DoubleClick += new System.EventHandler(this.dgvListarVias_DoubleClick_1);
            // 
            // viaidDataGridViewTextBoxColumn
            // 
            this.viaidDataGridViewTextBoxColumn.DataPropertyName = "Via_id";
            this.viaidDataGridViewTextBoxColumn.HeaderText = "Código";
            this.viaidDataGridViewTextBoxColumn.Name = "viaidDataGridViewTextBoxColumn";
            this.viaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoViaDataGridViewTextBoxColumn
            // 
            this.tipoViaDataGridViewTextBoxColumn.DataPropertyName = "TipoVia";
            this.tipoViaDataGridViewTextBoxColumn.HeaderText = "TipoVia";
            this.tipoViaDataGridViewTextBoxColumn.Name = "tipoViaDataGridViewTextBoxColumn";
            this.tipoViaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoViaDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionTipoViaDataGridViewTextBoxColumn
            // 
            this.descripcionTipoViaDataGridViewTextBoxColumn.DataPropertyName = "descripcionTipoVia";
            this.descripcionTipoViaDataGridViewTextBoxColumn.HeaderText = "Tipo Via";
            this.descripcionTipoViaDataGridViewTextBoxColumn.Name = "descripcionTipoViaDataGridViewTextBoxColumn";
            this.descripcionTipoViaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoAntiguoDataGridViewTextBoxColumn
            // 
            this.codigoAntiguoDataGridViewTextBoxColumn.DataPropertyName = "CodigoAntiguo";
            this.codigoAntiguoDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.codigoAntiguoDataGridViewTextBoxColumn.Name = "codigoAntiguoDataGridViewTextBoxColumn";
            this.codigoAntiguoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Activo ?";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // predViasBindingSource3
            // 
            this.predViasBindingSource3.DataSource = typeof(SGR.Entity.Model.Pred_Vias);
            // 
            // predViasBindingSource1
            // 
            this.predViasBindingSource1.DataSource = typeof(SGR.Entity.Model.Pred_Vias);
            // 
            // predViasBindingSource2
            // 
            this.predViasBindingSource2.DataSource = typeof(SGR.Entity.Model.Pred_Vias);
            // 
            // Frm_Vias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 354);
            this.Controls.Add(this.dgvListarVias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Vias";
            this.Text = "Listar Vias";
            this.Load += new System.EventHandler(this.Frm_Vias_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predViasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.BindingSource predViasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn xVia_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodigoAntiguo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsysFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsysUser;
        private System.Windows.Forms.BindingSource predViasBindingSource1;
        private System.Windows.Forms.DataGridView dgvListarVias;
        private System.Windows.Forms.BindingSource predViasBindingSource2;
        private System.Windows.Forms.BindingSource predViasBindingSource3;
        private System.Windows.Forms.ToolStripButton toolReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoViaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTipoViaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAntiguoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysUserDataGridViewTextBoxColumn;
    }
}