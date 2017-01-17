namespace SGR.WinApp.Layout._4_Procesos.Predio.Adeudo
{
    partial class Frm_Alcabala_Listado
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
            this.dgvAlcabalListado = new System.Windows.Forms.DataGridView();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.certalcabala_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_alcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_posesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioGeneracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condomino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_imponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_afecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaAlcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprador_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adquisicion_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posesion_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_completa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.rbtAnulados = new System.Windows.Forms.RadioButton();
            this.rbtPendiente = new System.Windows.Forms.RadioButton();
            this.rbtCancelados = new System.Windows.Forms.RadioButton();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBusquedaAnio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcabalListado)).BeginInit();
            this.toolmantenedores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlcabalListado
            // 
            this.dgvAlcabalListado.AllowUserToAddRows = false;
            this.dgvAlcabalListado.AllowUserToDeleteRows = false;
            this.dgvAlcabalListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlcabalListado.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlcabalListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlcabalListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlcabalListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estado,
            this.certalcabala_id,
            this.persona_id,
            this.comprador,
            this.predio_id,
            this.tipo_alcabala,
            this.tipo_adquisicion,
            this.tipo_posesion,
            this.anioGeneracion,
            this.fecha_tramite,
            this.condomino,
            this.valor_venta,
            this.valuo,
            this.base_imponible,
            this.uits,
            this.valor_afecto,
            this.alcabala,
            this.registro_fecha_add,
            this.registro_pc_add,
            this.registro_user_add,
            this.registro_fecha_update,
            this.registro_pc_update,
            this.registro_user_update,
            this.tasaAlcabala,
            this.anio,
            this.comprador_name,
            this.adquisicion_descripcion,
            this.posesion_descripcion,
            this.direccion_completa,
            this.vendedor_name,
            this.area});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlcabalListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlcabalListado.EnableHeadersVisualStyles = false;
            this.dgvAlcabalListado.Location = new System.Drawing.Point(11, 111);
            this.dgvAlcabalListado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlcabalListado.MultiSelect = false;
            this.dgvAlcabalListado.Name = "dgvAlcabalListado";
            this.dgvAlcabalListado.ReadOnly = true;
            this.dgvAlcabalListado.RowHeadersVisible = false;
            this.dgvAlcabalListado.RowTemplate.Height = 24;
            this.dgvAlcabalListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlcabalListado.Size = new System.Drawing.Size(921, 331);
            this.dgvAlcabalListado.TabIndex = 9;
            this.dgvAlcabalListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlcabalListado_CellContentClick);
            this.dgvAlcabalListado.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlcabalListado_ColumnHeaderMouseClick);
            this.dgvAlcabalListado.DoubleClick += new System.EventHandler(this.dgvAlcabalListado_DoubleClick);
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 50;
            // 
            // certalcabala_id
            // 
            this.certalcabala_id.DataPropertyName = "certalcabala_id";
            this.certalcabala_id.HeaderText = "Código";
            this.certalcabala_id.Name = "certalcabala_id";
            this.certalcabala_id.ReadOnly = true;
            // 
            // persona_id
            // 
            this.persona_id.DataPropertyName = "persona_id";
            this.persona_id.HeaderText = "persona_id";
            this.persona_id.Name = "persona_id";
            this.persona_id.ReadOnly = true;
            this.persona_id.Visible = false;
            // 
            // comprador
            // 
            this.comprador.DataPropertyName = "comprador";
            this.comprador.HeaderText = "comprador";
            this.comprador.Name = "comprador";
            this.comprador.ReadOnly = true;
            this.comprador.Visible = false;
            this.comprador.Width = 50;
            // 
            // predio_id
            // 
            this.predio_id.DataPropertyName = "predio_id";
            this.predio_id.HeaderText = "Predio";
            this.predio_id.Name = "predio_id";
            this.predio_id.ReadOnly = true;
            // 
            // tipo_alcabala
            // 
            this.tipo_alcabala.DataPropertyName = "tipo_alcabala";
            this.tipo_alcabala.HeaderText = "tipo_alcabala";
            this.tipo_alcabala.Name = "tipo_alcabala";
            this.tipo_alcabala.ReadOnly = true;
            this.tipo_alcabala.Visible = false;
            this.tipo_alcabala.Width = 50;
            // 
            // tipo_adquisicion
            // 
            this.tipo_adquisicion.DataPropertyName = "tipo_adquisicion";
            this.tipo_adquisicion.HeaderText = "tipo_adquisicion";
            this.tipo_adquisicion.Name = "tipo_adquisicion";
            this.tipo_adquisicion.ReadOnly = true;
            this.tipo_adquisicion.Visible = false;
            // 
            // tipo_posesion
            // 
            this.tipo_posesion.DataPropertyName = "tipo_posesion";
            this.tipo_posesion.HeaderText = "tipo_posesion";
            this.tipo_posesion.Name = "tipo_posesion";
            this.tipo_posesion.ReadOnly = true;
            this.tipo_posesion.Visible = false;
            // 
            // anioGeneracion
            // 
            this.anioGeneracion.DataPropertyName = "anioGeneracion";
            this.anioGeneracion.HeaderText = "Año Gener.";
            this.anioGeneracion.Name = "anioGeneracion";
            this.anioGeneracion.ReadOnly = true;
            this.anioGeneracion.Visible = false;
            // 
            // fecha_tramite
            // 
            this.fecha_tramite.DataPropertyName = "fecha_tramite";
            this.fecha_tramite.HeaderText = "Fecha de trámite";
            this.fecha_tramite.Name = "fecha_tramite";
            this.fecha_tramite.ReadOnly = true;
            // 
            // condomino
            // 
            this.condomino.DataPropertyName = "condomino";
            this.condomino.HeaderText = "Condomino";
            this.condomino.Name = "condomino";
            this.condomino.ReadOnly = true;
            this.condomino.Visible = false;
            // 
            // valor_venta
            // 
            this.valor_venta.DataPropertyName = "valor_venta";
            this.valor_venta.HeaderText = "Valor Venta";
            this.valor_venta.Name = "valor_venta";
            this.valor_venta.ReadOnly = true;
            // 
            // valuo
            // 
            this.valuo.DataPropertyName = "valuo";
            this.valuo.HeaderText = "Valuo";
            this.valuo.Name = "valuo";
            this.valuo.ReadOnly = true;
            // 
            // base_imponible
            // 
            this.base_imponible.DataPropertyName = "base_imponible";
            this.base_imponible.HeaderText = "Base Imponible";
            this.base_imponible.Name = "base_imponible";
            this.base_imponible.ReadOnly = true;
            // 
            // uits
            // 
            this.uits.DataPropertyName = "uits";
            this.uits.HeaderText = "Uit";
            this.uits.Name = "uits";
            this.uits.ReadOnly = true;
            // 
            // valor_afecto
            // 
            this.valor_afecto.DataPropertyName = "valor_afecto";
            this.valor_afecto.HeaderText = "Valor Afecto";
            this.valor_afecto.Name = "valor_afecto";
            this.valor_afecto.ReadOnly = true;
            // 
            // alcabala
            // 
            this.alcabala.DataPropertyName = "alcabala";
            this.alcabala.HeaderText = "Alcabala";
            this.alcabala.Name = "alcabala";
            this.alcabala.ReadOnly = true;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "registro_fecha_add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "registro_pc_add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "registro_user_add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "registro_fecha_update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "registro_pc_update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // tasaAlcabala
            // 
            this.tasaAlcabala.DataPropertyName = "tasaAlcabala";
            this.tasaAlcabala.HeaderText = "Tasa";
            this.tasaAlcabala.Name = "tasaAlcabala";
            this.tasaAlcabala.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // comprador_name
            // 
            this.comprador_name.DataPropertyName = "comprador_name";
            this.comprador_name.HeaderText = "Comprador";
            this.comprador_name.Name = "comprador_name";
            this.comprador_name.ReadOnly = true;
            // 
            // adquisicion_descripcion
            // 
            this.adquisicion_descripcion.DataPropertyName = "adquisicion_descripcion";
            this.adquisicion_descripcion.HeaderText = "Adquisición";
            this.adquisicion_descripcion.Name = "adquisicion_descripcion";
            this.adquisicion_descripcion.ReadOnly = true;
            // 
            // posesion_descripcion
            // 
            this.posesion_descripcion.DataPropertyName = "posesion_descripcion";
            this.posesion_descripcion.HeaderText = "Posesión";
            this.posesion_descripcion.Name = "posesion_descripcion";
            this.posesion_descripcion.ReadOnly = true;
            // 
            // direccion_completa
            // 
            this.direccion_completa.DataPropertyName = "direccion_completa";
            this.direccion_completa.HeaderText = "Dirección";
            this.direccion_completa.Name = "direccion_completa";
            this.direccion_completa.ReadOnly = true;
            // 
            // vendedor_name
            // 
            this.vendedor_name.DataPropertyName = "vendedor_name";
            this.vendedor_name.HeaderText = "Vendedor";
            this.vendedor_name.Name = "vendedor_name";
            this.vendedor_name.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBotonReporte,
            this.toolDelete});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(942, 27);
            this.toolmantenedores.TabIndex = 8;
            this.toolmantenedores.Text = "toolStrip1";
            // 
            // toolStripBotonReporte
            // 
            this.toolStripBotonReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolStripBotonReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonReporte.Name = "toolStripBotonReporte";
            this.toolStripBotonReporte.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonReporte.Text = "Reporte";
            // 
            // toolDelete
            // 
            this.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDelete.Image = global::SGR.WinApp.Properties.Resources.delete;
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(24, 24);
            this.toolDelete.Text = "Anular";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.rbtAnulados);
            this.groupBox1.Controls.Add(this.rbtPendiente);
            this.groupBox1.Controls.Add(this.rbtCancelados);
            this.groupBox1.Controls.Add(this.rbtTodos);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtVendedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtComprador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBusquedaAnio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(921, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Búsqueda";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.Image = global::SGR.WinApp.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(850, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(26, 32);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rbtAnulados
            // 
            this.rbtAnulados.AutoSize = true;
            this.rbtAnulados.Location = new System.Drawing.Point(279, 18);
            this.rbtAnulados.Name = "rbtAnulados";
            this.rbtAnulados.Size = new System.Drawing.Size(49, 17);
            this.rbtAnulados.TabIndex = 28;
            this.rbtAnulados.Text = "Anul.";
            this.rbtAnulados.UseVisualStyleBackColor = true;
            // 
            // rbtPendiente
            // 
            this.rbtPendiente.AutoSize = true;
            this.rbtPendiente.Location = new System.Drawing.Point(227, 19);
            this.rbtPendiente.Name = "rbtPendiente";
            this.rbtPendiente.Size = new System.Drawing.Size(53, 17);
            this.rbtPendiente.TabIndex = 27;
            this.rbtPendiente.Text = "Pend.";
            this.rbtPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtCancelados
            // 
            this.rbtCancelados.AutoSize = true;
            this.rbtCancelados.Location = new System.Drawing.Point(177, 20);
            this.rbtCancelados.Name = "rbtCancelados";
            this.rbtCancelados.Size = new System.Drawing.Size(53, 17);
            this.rbtCancelados.TabIndex = 26;
            this.rbtCancelados.Text = "Canc.";
            this.rbtCancelados.UseVisualStyleBackColor = true;
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Checked = true;
            this.rbtTodos.Location = new System.Drawing.Point(128, 19);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(47, 17);
            this.rbtTodos.TabIndex = 25;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Tod.";
            this.rbtTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Image = global::SGR.WinApp.Properties.Resources.search1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(748, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 32);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(600, 17);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(124, 20);
            this.txtVendedor.TabIndex = 7;
            this.txtVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vendedor:";
            // 
            // txtComprador
            // 
            this.txtComprador.Location = new System.Drawing.Point(398, 18);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(139, 20);
            this.txtComprador.TabIndex = 5;
            this.txtComprador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComprador_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comprador:";
            // 
            // comboBusquedaAnio
            // 
            this.comboBusquedaAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaAnio.FormattingEnabled = true;
            this.comboBusquedaAnio.Location = new System.Drawing.Point(48, 18);
            this.comboBusquedaAnio.Name = "comboBusquedaAnio";
            this.comboBusquedaAnio.Size = new System.Drawing.Size(68, 21);
            this.comboBusquedaAnio.TabIndex = 3;
            this.comboBusquedaAnio.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaAnio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año:";
            // 
            // Frm_Alcabala_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(942, 453);
            this.Controls.Add(this.dgvAlcabalListado);
            this.Controls.Add(this.toolmantenedores);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Alcabala_Listado";
            this.Text = "Listados de Alcabala";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcabalListado)).EndInit();
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlcabalListado;
        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBusquedaAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn certalcabala_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_alcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_posesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioGeneracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_tramite;
        private System.Windows.Forms.DataGridViewTextBoxColumn condomino;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_imponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn uits;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_afecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaAlcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprador_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn adquisicion_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn posesion_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_completa;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.RadioButton rbtAnulados;
        private System.Windows.Forms.RadioButton rbtPendiente;
        private System.Windows.Forms.RadioButton rbtCancelados;
        private System.Windows.Forms.RadioButton rbtTodos;
        private System.Windows.Forms.Button btnImprimir;
    }
}