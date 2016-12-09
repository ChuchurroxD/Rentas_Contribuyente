namespace SGR.WinApp.Layout._1_Tablas_Maestras.ArancelRustico
{
    partial class Frm_Arancel_Rustico
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPeriodoBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarArancelRustico = new System.Windows.Forms.DataGridView();
            this.xarancelRustico_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCategoria_Rustico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCategoria_RusticoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xValorRustico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidGrupoRustico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGrupoRusticoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xregistro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantArancelRusticoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mantArancelRusticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArancelRustico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelRusticoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelRusticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripBotonModificar,
            this.toolStripBotonReporte,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.groupBox1.Controls.Add(this.comboPeriodoBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // comboPeriodoBusqueda
            // 
            this.comboPeriodoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeriodoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPeriodoBusqueda.FormattingEnabled = true;
            this.comboPeriodoBusqueda.Location = new System.Drawing.Point(201, 17);
            this.comboPeriodoBusqueda.Name = "comboPeriodoBusqueda";
            this.comboPeriodoBusqueda.Size = new System.Drawing.Size(193, 21);
            this.comboPeriodoBusqueda.TabIndex = 1;
            this.comboPeriodoBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboPeriodoBusqueda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda: ";
            // 
            // dgvListarArancelRustico
            // 
            this.dgvListarArancelRustico.AllowUserToAddRows = false;
            this.dgvListarArancelRustico.AllowUserToDeleteRows = false;
            this.dgvListarArancelRustico.AutoGenerateColumns = false;
            this.dgvListarArancelRustico.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarArancelRustico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarArancelRustico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarArancelRustico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xarancelRustico_id,
            this.xidPeriodo,
            this.xCategoria_Rustico,
            this.xCategoria_RusticoDescripcion,
            this.xValorRustico,
            this.xidGrupoRustico,
            this.xGrupoRusticoDescripcion,
            this.xactivo,
            this.xregistro_fecha_add,
            this.xregistro_user_add,
            this.xregistro_pc_add,
            this.xregistro_fecha_update,
            this.xregistro_user_update,
            this.xregistro_pc_update});
            this.dgvListarArancelRustico.DataSource = this.mantArancelRusticoBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarArancelRustico.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListarArancelRustico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarArancelRustico.EnableHeadersVisualStyles = false;
            this.dgvListarArancelRustico.Location = new System.Drawing.Point(0, 80);
            this.dgvListarArancelRustico.MultiSelect = false;
            this.dgvListarArancelRustico.Name = "dgvListarArancelRustico";
            this.dgvListarArancelRustico.ReadOnly = true;
            this.dgvListarArancelRustico.RowHeadersVisible = false;
            this.dgvListarArancelRustico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarArancelRustico.Size = new System.Drawing.Size(716, 292);
            this.dgvListarArancelRustico.TabIndex = 2;
            this.dgvListarArancelRustico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarArancelRustico_CellContentClick);
            this.dgvListarArancelRustico.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarArancelRustico_ColumnHeaderMouseClick);
            this.dgvListarArancelRustico.DoubleClick += new System.EventHandler(this.dgvListarArancelRustico_DoubleClick);
            // 
            // xarancelRustico_id
            // 
            this.xarancelRustico_id.DataPropertyName = "ArancelRustico_id";
            this.xarancelRustico_id.HeaderText = "ArancelRustico_id";
            this.xarancelRustico_id.Name = "xarancelRustico_id";
            this.xarancelRustico_id.ReadOnly = true;
            this.xarancelRustico_id.Visible = false;
            // 
            // xidPeriodo
            // 
            this.xidPeriodo.DataPropertyName = "idPeriodo";
            this.xidPeriodo.HeaderText = "Año";
            this.xidPeriodo.Name = "xidPeriodo";
            this.xidPeriodo.ReadOnly = true;
            this.xidPeriodo.Width = 50;
            // 
            // xCategoria_Rustico
            // 
            this.xCategoria_Rustico.DataPropertyName = "Categoria_Rustico";
            this.xCategoria_Rustico.HeaderText = "Categoria_Rustico";
            this.xCategoria_Rustico.Name = "xCategoria_Rustico";
            this.xCategoria_Rustico.ReadOnly = true;
            this.xCategoria_Rustico.Visible = false;
            // 
            // xCategoria_RusticoDescripcion
            // 
            this.xCategoria_RusticoDescripcion.DataPropertyName = "Categoria_RusticoDescripcion";
            this.xCategoria_RusticoDescripcion.HeaderText = "Categoria";
            this.xCategoria_RusticoDescripcion.Name = "xCategoria_RusticoDescripcion";
            this.xCategoria_RusticoDescripcion.ReadOnly = true;
            // 
            // xValorRustico
            // 
            this.xValorRustico.DataPropertyName = "ValorRustico";
            this.xValorRustico.HeaderText = "Valor";
            this.xValorRustico.Name = "xValorRustico";
            this.xValorRustico.ReadOnly = true;
            // 
            // xidGrupoRustico
            // 
            this.xidGrupoRustico.DataPropertyName = "idGrupoRustico";
            this.xidGrupoRustico.HeaderText = "idGrupoRustico";
            this.xidGrupoRustico.Name = "xidGrupoRustico";
            this.xidGrupoRustico.ReadOnly = true;
            this.xidGrupoRustico.Visible = false;
            // 
            // xGrupoRusticoDescripcion
            // 
            this.xGrupoRusticoDescripcion.DataPropertyName = "GrupoRusticoDescripcion";
            this.xGrupoRusticoDescripcion.HeaderText = "Grupo";
            this.xGrupoRusticoDescripcion.Name = "xGrupoRusticoDescripcion";
            this.xGrupoRusticoDescripcion.ReadOnly = true;
            this.xGrupoRusticoDescripcion.Width = 400;
            // 
            // xactivo
            // 
            this.xactivo.DataPropertyName = "activo";
            this.xactivo.HeaderText = "Activo ?";
            this.xactivo.Name = "xactivo";
            this.xactivo.ReadOnly = true;
            this.xactivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xactivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xactivo.Width = 60;
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
            // mantArancelRusticoBindingSource1
            // 
            this.mantArancelRusticoBindingSource1.DataSource = typeof(SGR.Entity.Model.Mant_ArancelRustico);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Frm_Arancel_Rustico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 372);
            this.Controls.Add(this.dgvListarArancelRustico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Arancel_Rustico";
            this.Text = "Listar Arancel Rustico";
            this.Load += new System.EventHandler(this.Frm_Arancel_Rustico_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArancelRustico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelRusticoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelRusticoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripBotonModificar;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListarArancelRustico;
        private System.Windows.Forms.BindingSource mantArancelRusticoBindingSource;
        private System.Windows.Forms.ComboBox comboPeriodoBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arancelRusticoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaRustico;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaRusticoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRustico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoRustico;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoRusticoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrofechaadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrouseradd;
        private System.Windows.Forms.DataGridViewTextBoxColumn registropcadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrofechaupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrouserupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn registropcupdate;
        private System.Windows.Forms.BindingSource mantArancelRusticoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xarancelRustico_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCategoria_Rustico;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCategoria_RusticoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xValorRustico;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidGrupoRustico;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGrupoRusticoDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_update;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}