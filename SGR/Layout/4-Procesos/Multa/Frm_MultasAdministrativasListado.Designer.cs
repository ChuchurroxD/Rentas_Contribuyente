namespace SGR.WinApp.Layout._4_Procesos.Multa
{
    partial class Frm_MultasAdministrativasListado
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
            this.mantArancelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mantArancelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListarArancel = new System.Windows.Forms.DataGridView();
            this.mult_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMulta_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_nro_resolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_anio_resolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_fecha_resol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_genera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_notifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_elimina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resol_resuelve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_declaro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recursod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mult_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.botonListar = new System.Windows.Forms.Button();
            this.comboBusquedaAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBusqueda = new System.Windows.Forms.GroupBox();
            this.rbtGenerado = new System.Windows.Forms.RadioButton();
            this.rbtCoactoivi = new System.Windows.Forms.RadioButton();
            this.rbtAnulado = new System.Windows.Forms.RadioButton();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolEnviarCoactivo = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtMultasAdministraticvas = new System.Windows.Forms.RadioButton();
            this.rbtMultasTributarias = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtMayor21 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArancel)).BeginInit();
            this.groupBusqueda.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListarArancel
            // 
            this.dgvListarArancel.AllowUserToAddRows = false;
            this.dgvListarArancel.AllowUserToDeleteRows = false;
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
            this.mult_id,
            this.persona_id,
            this.persona,
            this.mult_direccion,
            this.TipoMulta_id,
            this.mult_monto,
            this.mult_nro_resolucion,
            this.mult_anio_resolucion,
            this.mult_fecha_resol,
            this.mult_archivo,
            this.mult_observacion,
            this.fecha_genera,
            this.fecha_notifica,
            this.fecha_vence,
            this.registro_user,
            this.fecha_elimina,
            this.tp_recurso,
            this.resol_resuelve,
            this.tp_declaro,
            this.recursod,
            this.mult_estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarArancel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarArancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarArancel.EnableHeadersVisualStyles = false;
            this.dgvListarArancel.Location = new System.Drawing.Point(0, 141);
            this.dgvListarArancel.MultiSelect = false;
            this.dgvListarArancel.Name = "dgvListarArancel";
            this.dgvListarArancel.ReadOnly = true;
            this.dgvListarArancel.RowHeadersVisible = false;
            this.dgvListarArancel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarArancel.Size = new System.Drawing.Size(888, 327);
            this.dgvListarArancel.TabIndex = 5;
            this.dgvListarArancel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarArancel_CellContentClick);
            // 
            // mult_id
            // 
            this.mult_id.DataPropertyName = "mult_id";
            this.mult_id.HeaderText = "Código";
            this.mult_id.Name = "mult_id";
            this.mult_id.ReadOnly = true;
            // 
            // persona_id
            // 
            this.persona_id.DataPropertyName = "persona_id";
            this.persona_id.HeaderText = "persona_id";
            this.persona_id.Name = "persona_id";
            this.persona_id.ReadOnly = true;
            this.persona_id.Visible = false;
            this.persona_id.Width = 50;
            // 
            // persona
            // 
            this.persona.DataPropertyName = "persona";
            this.persona.HeaderText = "persona";
            this.persona.Name = "persona";
            this.persona.ReadOnly = true;
            // 
            // mult_direccion
            // 
            this.mult_direccion.DataPropertyName = "mult_direccion";
            this.mult_direccion.HeaderText = "Dirección";
            this.mult_direccion.Name = "mult_direccion";
            this.mult_direccion.ReadOnly = true;
            // 
            // TipoMulta_id
            // 
            this.TipoMulta_id.DataPropertyName = "TipoMulta_id";
            this.TipoMulta_id.HeaderText = "TipoMulta_id";
            this.TipoMulta_id.Name = "TipoMulta_id";
            this.TipoMulta_id.ReadOnly = true;
            this.TipoMulta_id.Visible = false;
            // 
            // mult_monto
            // 
            this.mult_monto.DataPropertyName = "mult_monto";
            this.mult_monto.HeaderText = "Monto";
            this.mult_monto.Name = "mult_monto";
            this.mult_monto.ReadOnly = true;
            this.mult_monto.Width = 50;
            // 
            // mult_nro_resolucion
            // 
            this.mult_nro_resolucion.DataPropertyName = "mult_nro_resolucion";
            this.mult_nro_resolucion.HeaderText = "Nro Resolucion";
            this.mult_nro_resolucion.Name = "mult_nro_resolucion";
            this.mult_nro_resolucion.ReadOnly = true;
            this.mult_nro_resolucion.Width = 50;
            // 
            // mult_anio_resolucion
            // 
            this.mult_anio_resolucion.DataPropertyName = "mult_anio_resolucion";
            this.mult_anio_resolucion.HeaderText = "Año Resolución";
            this.mult_anio_resolucion.Name = "mult_anio_resolucion";
            this.mult_anio_resolucion.ReadOnly = true;
            this.mult_anio_resolucion.Visible = false;
            // 
            // mult_fecha_resol
            // 
            this.mult_fecha_resol.DataPropertyName = "mult_fecha_resol";
            this.mult_fecha_resol.HeaderText = "Fecha Resol";
            this.mult_fecha_resol.Name = "mult_fecha_resol";
            this.mult_fecha_resol.ReadOnly = true;
            this.mult_fecha_resol.Visible = false;
            // 
            // mult_archivo
            // 
            this.mult_archivo.DataPropertyName = "mult_archivo";
            this.mult_archivo.HeaderText = "Archivo Resolucion";
            this.mult_archivo.Name = "mult_archivo";
            this.mult_archivo.ReadOnly = true;
            this.mult_archivo.Width = 150;
            // 
            // mult_observacion
            // 
            this.mult_observacion.DataPropertyName = "mult_observacion";
            this.mult_observacion.HeaderText = "Observacion";
            this.mult_observacion.Name = "mult_observacion";
            this.mult_observacion.ReadOnly = true;
            this.mult_observacion.Width = 160;
            // 
            // fecha_genera
            // 
            this.fecha_genera.DataPropertyName = "fecha_genera";
            this.fecha_genera.HeaderText = "Fecha Generación";
            this.fecha_genera.Name = "fecha_genera";
            this.fecha_genera.ReadOnly = true;
            this.fecha_genera.Visible = false;
            // 
            // fecha_notifica
            // 
            this.fecha_notifica.DataPropertyName = "fecha_notifica";
            this.fecha_notifica.HeaderText = "Fecha Notifica";
            this.fecha_notifica.Name = "fecha_notifica";
            this.fecha_notifica.ReadOnly = true;
            this.fecha_notifica.Visible = false;
            // 
            // fecha_vence
            // 
            this.fecha_vence.DataPropertyName = "fecha_vence";
            this.fecha_vence.HeaderText = "Fecha Vence";
            this.fecha_vence.Name = "fecha_vence";
            this.fecha_vence.ReadOnly = true;
            // 
            // registro_user
            // 
            this.registro_user.DataPropertyName = "registro_user";
            this.registro_user.HeaderText = "registro_user";
            this.registro_user.Name = "registro_user";
            this.registro_user.ReadOnly = true;
            this.registro_user.Visible = false;
            // 
            // fecha_elimina
            // 
            this.fecha_elimina.DataPropertyName = "fecha_elimina";
            this.fecha_elimina.HeaderText = "Fecha Elimina";
            this.fecha_elimina.Name = "fecha_elimina";
            this.fecha_elimina.ReadOnly = true;
            this.fecha_elimina.Visible = false;
            // 
            // tp_recurso
            // 
            this.tp_recurso.DataPropertyName = "tp_recurso";
            this.tp_recurso.HeaderText = "tp_recurso";
            this.tp_recurso.Name = "tp_recurso";
            this.tp_recurso.ReadOnly = true;
            // 
            // resol_resuelve
            // 
            this.resol_resuelve.DataPropertyName = "resol_resuelve";
            this.resol_resuelve.HeaderText = "resol_resuelve";
            this.resol_resuelve.Name = "resol_resuelve";
            this.resol_resuelve.ReadOnly = true;
            // 
            // tp_declaro
            // 
            this.tp_declaro.DataPropertyName = "tp_declaro";
            this.tp_declaro.HeaderText = "tp_declaro";
            this.tp_declaro.Name = "tp_declaro";
            this.tp_declaro.ReadOnly = true;
            // 
            // recursod
            // 
            this.recursod.DataPropertyName = "recursod";
            this.recursod.HeaderText = "recursod";
            this.recursod.Name = "recursod";
            this.recursod.ReadOnly = true;
            // 
            // mult_estado
            // 
            this.mult_estado.DataPropertyName = "mult_estado";
            this.mult_estado.HeaderText = "Estado";
            this.mult_estado.Name = "mult_estado";
            this.mult_estado.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // botonListar
            // 
            this.botonListar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListar.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonListar.Location = new System.Drawing.Point(618, 23);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(91, 33);
            this.botonListar.TabIndex = 3;
            this.botonListar.Text = "Listar";
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // comboBusquedaAnio
            // 
            this.comboBusquedaAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaAnio.FormattingEnabled = true;
            this.comboBusquedaAnio.Location = new System.Drawing.Point(57, 25);
            this.comboBusquedaAnio.Name = "comboBusquedaAnio";
            this.comboBusquedaAnio.Size = new System.Drawing.Size(115, 21);
            this.comboBusquedaAnio.TabIndex = 1;
            this.comboBusquedaAnio.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaAnio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año: ";
            // 
            // groupBusqueda
            // 
            this.groupBusqueda.BackColor = System.Drawing.Color.Lavender;
            this.groupBusqueda.Controls.Add(this.groupBox2);
            this.groupBusqueda.Controls.Add(this.groupBox1);
            this.groupBusqueda.Controls.Add(this.txtNombre);
            this.groupBusqueda.Controls.Add(this.label2);
            this.groupBusqueda.Controls.Add(this.botonListar);
            this.groupBusqueda.Controls.Add(this.comboBusquedaAnio);
            this.groupBusqueda.Controls.Add(this.label1);
            this.groupBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBusqueda.Location = new System.Drawing.Point(0, 27);
            this.groupBusqueda.Name = "groupBusqueda";
            this.groupBusqueda.Size = new System.Drawing.Size(888, 114);
            this.groupBusqueda.TabIndex = 4;
            this.groupBusqueda.TabStop = false;
            this.groupBusqueda.Text = "Opciones de Busqueda";
            // 
            // rbtGenerado
            // 
            this.rbtGenerado.AutoSize = true;
            this.rbtGenerado.Location = new System.Drawing.Point(233, 17);
            this.rbtGenerado.Name = "rbtGenerado";
            this.rbtGenerado.Size = new System.Drawing.Size(72, 17);
            this.rbtGenerado.TabIndex = 10;
            this.rbtGenerado.TabStop = true;
            this.rbtGenerado.Text = "Generado";
            this.rbtGenerado.UseVisualStyleBackColor = true;
            // 
            // rbtCoactoivi
            // 
            this.rbtCoactoivi.AutoSize = true;
            this.rbtCoactoivi.Location = new System.Drawing.Point(160, 17);
            this.rbtCoactoivi.Name = "rbtCoactoivi";
            this.rbtCoactoivi.Size = new System.Drawing.Size(67, 17);
            this.rbtCoactoivi.TabIndex = 9;
            this.rbtCoactoivi.Text = "Coactivo";
            this.rbtCoactoivi.UseVisualStyleBackColor = true;
            // 
            // rbtAnulado
            // 
            this.rbtAnulado.AutoSize = true;
            this.rbtAnulado.Location = new System.Drawing.Point(95, 17);
            this.rbtAnulado.Name = "rbtAnulado";
            this.rbtAnulado.Size = new System.Drawing.Size(64, 17);
            this.rbtAnulado.TabIndex = 8;
            this.rbtAnulado.Text = "Anulado";
            this.rbtAnulado.UseVisualStyleBackColor = true;
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Checked = true;
            this.rbtTodos.Location = new System.Drawing.Point(29, 17);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtTodos.TabIndex = 6;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(364, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre / Razon Social:";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Reporte";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
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
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEditar,
            this.toolStripButton5,
            this.toolEnviarCoactivo});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(888, 27);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolEnviarCoactivo
            // 
            this.toolEnviarCoactivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEnviarCoactivo.Image = global::SGR.WinApp.Properties.Resources.clipboard_with_a_list;
            this.toolEnviarCoactivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEnviarCoactivo.Name = "toolEnviarCoactivo";
            this.toolEnviarCoactivo.Size = new System.Drawing.Size(24, 24);
            this.toolEnviarCoactivo.Text = "toolEnviaerCoactivo";
            this.toolEnviarCoactivo.ToolTipText = "Enviar a Coactivo";
            this.toolEnviarCoactivo.Click += new System.EventHandler(this.toolEnviarCoactivo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtMultasTributarias);
            this.groupBox1.Controls.Add(this.rbtMultasAdministraticvas);
            this.groupBox1.Location = new System.Drawing.Point(22, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 52);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Multa";
            // 
            // rbtMultasAdministraticvas
            // 
            this.rbtMultasAdministraticvas.AutoSize = true;
            this.rbtMultasAdministraticvas.Checked = true;
            this.rbtMultasAdministraticvas.Location = new System.Drawing.Point(6, 19);
            this.rbtMultasAdministraticvas.Name = "rbtMultasAdministraticvas";
            this.rbtMultasAdministraticvas.Size = new System.Drawing.Size(129, 17);
            this.rbtMultasAdministraticvas.TabIndex = 0;
            this.rbtMultasAdministraticvas.TabStop = true;
            this.rbtMultasAdministraticvas.Text = "Multas Administrativas";
            this.rbtMultasAdministraticvas.UseVisualStyleBackColor = true;
            // 
            // rbtMultasTributarias
            // 
            this.rbtMultasTributarias.AutoSize = true;
            this.rbtMultasTributarias.Location = new System.Drawing.Point(155, 19);
            this.rbtMultasTributarias.Name = "rbtMultasTributarias";
            this.rbtMultasTributarias.Size = new System.Drawing.Size(108, 17);
            this.rbtMultasTributarias.TabIndex = 1;
            this.rbtMultasTributarias.Text = "Multas Tributarias";
            this.rbtMultasTributarias.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtMayor21);
            this.groupBox2.Controls.Add(this.rbtGenerado);
            this.groupBox2.Controls.Add(this.rbtTodos);
            this.groupBox2.Controls.Add(this.rbtAnulado);
            this.groupBox2.Controls.Add(this.rbtCoactoivi);
            this.groupBox2.Location = new System.Drawing.Point(308, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 46);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de Multas";
            // 
            // rbtMayor21
            // 
            this.rbtMayor21.AutoSize = true;
            this.rbtMayor21.Location = new System.Drawing.Point(310, 17);
            this.rbtMayor21.Name = "rbtMayor21";
            this.rbtMayor21.Size = new System.Drawing.Size(65, 17);
            this.rbtMayor21.TabIndex = 11;
            this.rbtMayor21.TabStop = true;
            this.rbtMayor21.Text = "G >21 D";
            this.rbtMayor21.UseVisualStyleBackColor = true;
            // 
            // Frm_MultasAdministrativasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 468);
            this.Controls.Add(this.dgvListarArancel);
            this.Controls.Add(this.groupBusqueda);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MultasAdministrativasListado";
            this.Text = "Frm_MultasAdministrativasDetalle";
            this.Load += new System.EventHandler(this.Frm_MultasAdministrativasListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantArancelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArancel)).EndInit();
            this.groupBusqueda.ResumeLayout(false);
            this.groupBusqueda.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mantArancelBindingSource1;
        private System.Windows.Forms.BindingSource mantArancelBindingSource;
        private System.Windows.Forms.DataGridView dgvListarArancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button botonListar;
        private System.Windows.Forms.ComboBox comboBusquedaAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBusqueda;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMulta_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_nro_resolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_anio_resolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_fecha_resol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_genera;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_notifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_elimina;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn resol_resuelve;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_declaro;
        private System.Windows.Forms.DataGridViewTextBoxColumn recursod;
        private System.Windows.Forms.DataGridViewTextBoxColumn mult_estado;
        private System.Windows.Forms.ToolStripButton toolEnviarCoactivo;
        private System.Windows.Forms.RadioButton rbtCoactoivi;
        private System.Windows.Forms.RadioButton rbtAnulado;
        private System.Windows.Forms.RadioButton rbtTodos;
        private System.Windows.Forms.RadioButton rbtGenerado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtMayor21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtMultasTributarias;
        private System.Windows.Forms.RadioButton rbtMultasAdministraticvas;
    }
}