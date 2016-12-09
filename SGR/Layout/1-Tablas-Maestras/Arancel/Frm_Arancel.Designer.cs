namespace SGR.WinApp.Layout._1_Tablas_Maestras.Arancel
{
    partial class Frm_Arancel
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.groupBusqueda = new System.Windows.Forms.GroupBox();
            this.comboBusquedaCalle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonListar = new System.Windows.Forms.Button();
            this.comboBusquedaSector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBusquedaAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvListarArancel = new System.Windows.Forms.DataGridView();
            this.xarancel_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xarancel_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xjunta_via_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuadra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xlado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSector_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xVia_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSectorDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xViaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xregistro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantArancelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantArancelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.groupBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEditar,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(887, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolNuevo
            // 
            this.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(24, 24);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolStripButton5_Click);
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
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Reporte";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // groupBusqueda
            // 
            this.groupBusqueda.BackColor = System.Drawing.Color.Lavender;
            this.groupBusqueda.Controls.Add(this.comboBusquedaCalle);
            this.groupBusqueda.Controls.Add(this.label3);
            this.groupBusqueda.Controls.Add(this.botonListar);
            this.groupBusqueda.Controls.Add(this.comboBusquedaSector);
            this.groupBusqueda.Controls.Add(this.label2);
            this.groupBusqueda.Controls.Add(this.comboBusquedaAnio);
            this.groupBusqueda.Controls.Add(this.label1);
            this.groupBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBusqueda.Location = new System.Drawing.Point(0, 27);
            this.groupBusqueda.Name = "groupBusqueda";
            this.groupBusqueda.Size = new System.Drawing.Size(887, 58);
            this.groupBusqueda.TabIndex = 1;
            this.groupBusqueda.TabStop = false;
            this.groupBusqueda.Text = "Opciones de Busqueda";
            this.groupBusqueda.Enter += new System.EventHandler(this.groupBusqueda_Enter);
            // 
            // comboBusquedaCalle
            // 
            this.comboBusquedaCalle.FormattingEnabled = true;
            this.comboBusquedaCalle.Location = new System.Drawing.Point(451, 23);
            this.comboBusquedaCalle.Name = "comboBusquedaCalle";
            this.comboBusquedaCalle.Size = new System.Drawing.Size(198, 21);
            this.comboBusquedaCalle.TabIndex = 5;
            this.comboBusquedaCalle.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaCalle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calle:";
            // 
            // botonListar
            // 
            this.botonListar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListar.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonListar.Location = new System.Drawing.Point(681, 16);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(91, 33);
            this.botonListar.TabIndex = 3;
            this.botonListar.Text = "Listar";
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // comboBusquedaSector
            // 
            this.comboBusquedaSector.FormattingEnabled = true;
            this.comboBusquedaSector.Location = new System.Drawing.Point(214, 22);
            this.comboBusquedaSector.Name = "comboBusquedaSector";
            this.comboBusquedaSector.Size = new System.Drawing.Size(198, 21);
            this.comboBusquedaSector.TabIndex = 2;
            this.comboBusquedaSector.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaSector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sector:";
            // 
            // comboBusquedaAnio
            // 
            this.comboBusquedaAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaAnio.FormattingEnabled = true;
            this.comboBusquedaAnio.Location = new System.Drawing.Point(49, 22);
            this.comboBusquedaAnio.Name = "comboBusquedaAnio";
            this.comboBusquedaAnio.Size = new System.Drawing.Size(115, 21);
            this.comboBusquedaAnio.TabIndex = 1;
            this.comboBusquedaAnio.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaAnio_SelectedIndexChanged);
            this.comboBusquedaAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBusquedaAnio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvListarArancel
            // 
            this.dgvListarArancel.AllowUserToAddRows = false;
            this.dgvListarArancel.AllowUserToDeleteRows = false;
            this.dgvListarArancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarArancel.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarArancel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarArancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarArancel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xarancel_ID,
            this.xanio,
            this.xarancel_monto,
            this.xjunta_via_ID,
            this.xcuadra,
            this.xlado,
            this.xSector_id,
            this.xVia_id,
            this.xSectorDescripcion,
            this.xViaDescripcion,
            this.xactivo,
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
            this.dgvListarArancel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarArancel.EnableHeadersVisualStyles = false;
            this.dgvListarArancel.Location = new System.Drawing.Point(0, 92);
            this.dgvListarArancel.MultiSelect = false;
            this.dgvListarArancel.Name = "dgvListarArancel";
            this.dgvListarArancel.ReadOnly = true;
            this.dgvListarArancel.RowHeadersVisible = false;
            this.dgvListarArancel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarArancel.Size = new System.Drawing.Size(887, 205);
            this.dgvListarArancel.TabIndex = 2;
            this.dgvListarArancel.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarArancel_ColumnHeaderMouseClick);
            this.dgvListarArancel.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarArancel_RowHeaderMouseClick);
            this.dgvListarArancel.DoubleClick += new System.EventHandler(this.dgvListarArancel_DoubleClick_1);
            // 
            // xarancel_ID
            // 
            this.xarancel_ID.DataPropertyName = "arancel_ID";
            this.xarancel_ID.HeaderText = "Arancel ID";
            this.xarancel_ID.Name = "xarancel_ID";
            this.xarancel_ID.ReadOnly = true;
            this.xarancel_ID.Visible = false;
            // 
            // xanio
            // 
            this.xanio.DataPropertyName = "anio";
            this.xanio.HeaderText = "Año";
            this.xanio.Name = "xanio";
            this.xanio.ReadOnly = true;
            this.xanio.Width = 50;
            // 
            // xarancel_monto
            // 
            this.xarancel_monto.DataPropertyName = "arancel_monto";
            this.xarancel_monto.HeaderText = "Monto Arancel";
            this.xarancel_monto.Name = "xarancel_monto";
            this.xarancel_monto.ReadOnly = true;
            // 
            // xjunta_via_ID
            // 
            this.xjunta_via_ID.DataPropertyName = "junta_via_ID";
            this.xjunta_via_ID.HeaderText = "Junta Via ID";
            this.xjunta_via_ID.Name = "xjunta_via_ID";
            this.xjunta_via_ID.ReadOnly = true;
            this.xjunta_via_ID.Visible = false;
            // 
            // xcuadra
            // 
            this.xcuadra.DataPropertyName = "cuadra";
            this.xcuadra.HeaderText = "Cuadra";
            this.xcuadra.Name = "xcuadra";
            this.xcuadra.ReadOnly = true;
            this.xcuadra.Width = 50;
            // 
            // xlado
            // 
            this.xlado.DataPropertyName = "lado";
            this.xlado.HeaderText = "Lado";
            this.xlado.Name = "xlado";
            this.xlado.ReadOnly = true;
            this.xlado.Width = 50;
            // 
            // xSector_id
            // 
            this.xSector_id.DataPropertyName = "Sector_id";
            this.xSector_id.HeaderText = "Sector ID";
            this.xSector_id.Name = "xSector_id";
            this.xSector_id.ReadOnly = true;
            this.xSector_id.Visible = false;
            // 
            // xVia_id
            // 
            this.xVia_id.DataPropertyName = "Via_id";
            this.xVia_id.HeaderText = "Via ID ";
            this.xVia_id.Name = "xVia_id";
            this.xVia_id.ReadOnly = true;
            this.xVia_id.Visible = false;
            // 
            // xSectorDescripcion
            // 
            this.xSectorDescripcion.DataPropertyName = "SectorDescripcion";
            this.xSectorDescripcion.HeaderText = "Sector";
            this.xSectorDescripcion.Name = "xSectorDescripcion";
            this.xSectorDescripcion.ReadOnly = true;
            this.xSectorDescripcion.Width = 150;
            // 
            // xViaDescripcion
            // 
            this.xViaDescripcion.DataPropertyName = "ViaDescripcion";
            this.xViaDescripcion.HeaderText = "Via";
            this.xViaDescripcion.Name = "xViaDescripcion";
            this.xViaDescripcion.ReadOnly = true;
            this.xViaDescripcion.Width = 160;
            // 
            // xactivo
            // 
            this.xactivo.DataPropertyName = "activo";
            this.xactivo.HeaderText = "Estado";
            this.xactivo.Name = "xactivo";
            this.xactivo.ReadOnly = true;
            this.xactivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xactivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xactivo.Width = 50;
            // 
            // xregistro_fecha_add
            // 
            this.xregistro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.xregistro_fecha_add.HeaderText = "Fecha de Creacion";
            this.xregistro_fecha_add.Name = "xregistro_fecha_add";
            this.xregistro_fecha_add.ReadOnly = true;
            this.xregistro_fecha_add.Visible = false;
            // 
            // xregistro_user_add
            // 
            this.xregistro_user_add.DataPropertyName = "registro_user_add";
            this.xregistro_user_add.HeaderText = "Usuario Inicial";
            this.xregistro_user_add.Name = "xregistro_user_add";
            this.xregistro_user_add.ReadOnly = true;
            this.xregistro_user_add.Visible = false;
            // 
            // xregistro_pc_add
            // 
            this.xregistro_pc_add.DataPropertyName = "registro_pc_add";
            this.xregistro_pc_add.HeaderText = "Pc Inicial";
            this.xregistro_pc_add.Name = "xregistro_pc_add";
            this.xregistro_pc_add.ReadOnly = true;
            this.xregistro_pc_add.Visible = false;
            // 
            // xregistro_fecha_update
            // 
            this.xregistro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.xregistro_fecha_update.HeaderText = "Fecha Modificacion";
            this.xregistro_fecha_update.Name = "xregistro_fecha_update";
            this.xregistro_fecha_update.ReadOnly = true;
            this.xregistro_fecha_update.Visible = false;
            // 
            // xregistro_user_update
            // 
            this.xregistro_user_update.DataPropertyName = "registro_user_update";
            this.xregistro_user_update.HeaderText = "Usuario Modificacion";
            this.xregistro_user_update.Name = "xregistro_user_update";
            this.xregistro_user_update.ReadOnly = true;
            this.xregistro_user_update.Visible = false;
            // 
            // xregistro_pc_update
            // 
            this.xregistro_pc_update.DataPropertyName = "registro_pc_update";
            this.xregistro_pc_update.HeaderText = "Pc de modificacion";
            this.xregistro_pc_update.Name = "xregistro_pc_update";
            this.xregistro_pc_update.ReadOnly = true;
            this.xregistro_pc_update.Visible = false;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // Frm_Arancel
            // 
            this.ClientSize = new System.Drawing.Size(887, 300);
            this.Controls.Add(this.dgvListarArancel);
            this.Controls.Add(this.groupBusqueda);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Arancel";
            this.Text = "Listar Arancel";
            this.Load += new System.EventHandler(this.Frm_Arancel_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBusqueda.ResumeLayout(false);
            this.groupBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.GroupBox groupBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource mantArancelBindingSource;
        private System.Windows.Forms.BindingSource mantArancelBindingSource1;
        private System.Windows.Forms.DataGridView dgvListarArancel;
        private System.Windows.Forms.ComboBox comboBusquedaAnio;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn xarancel_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xarancel_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xjunta_via_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuadra;
        private System.Windows.Forms.DataGridViewTextBoxColumn xlado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSector_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xVia_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSectorDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xViaDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_update;
        private System.Windows.Forms.ComboBox comboBusquedaSector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonListar;
        private System.Windows.Forms.ComboBox comboBusquedaCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}