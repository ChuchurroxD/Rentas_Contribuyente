namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos
{
    partial class Frm_PlanillaIngresosResumen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboConceptoAgrupado = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.chk_filtro = new System.Windows.Forms.CheckBox();
            this.botonGenerarResumen = new System.Windows.Forms.Button();
            this.botonListar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResumenDelDia = new System.Windows.Forms.DataGridView();
            this.dgvResumenPorPartida = new System.Windows.Forms.DataGridView();
            this.Fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clai_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clai_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDevolucion = new System.Windows.Forms.DataGridView();
            this.dFuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnro_Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmonto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dclai_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dclai_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclai_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnro_Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmonto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclai_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenDelDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPorPartida)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.cboConceptoAgrupado);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.chk_filtro);
            this.groupBox1.Controls.Add(this.botonGenerarResumen);
            this.groupBox1.Controls.Add(this.botonListar);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // cboConceptoAgrupado
            // 
            this.cboConceptoAgrupado.Enabled = false;
            this.cboConceptoAgrupado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConceptoAgrupado.FormattingEnabled = true;
            this.cboConceptoAgrupado.Location = new System.Drawing.Point(204, 53);
            this.cboConceptoAgrupado.Name = "cboConceptoAgrupado";
            this.cboConceptoAgrupado.Size = new System.Drawing.Size(311, 21);
            this.cboConceptoAgrupado.TabIndex = 57;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(128, 56);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 56;
            this.label37.Text = "Concepto:";
            // 
            // chk_filtro
            // 
            this.chk_filtro.AutoSize = true;
            this.chk_filtro.Location = new System.Drawing.Point(25, 52);
            this.chk_filtro.Name = "chk_filtro";
            this.chk_filtro.Size = new System.Drawing.Size(67, 17);
            this.chk_filtro.TabIndex = 6;
            this.chk_filtro.Text = "Filtrar";
            this.chk_filtro.UseVisualStyleBackColor = true;
            this.chk_filtro.CheckedChanged += new System.EventHandler(this.chk_filtro_CheckedChanged);
            // 
            // botonGenerarResumen
            // 
            this.botonGenerarResumen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarResumen.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarResumen.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarResumen.Location = new System.Drawing.Point(740, 32);
            this.botonGenerarResumen.Name = "botonGenerarResumen";
            this.botonGenerarResumen.Size = new System.Drawing.Size(168, 40);
            this.botonGenerarResumen.TabIndex = 5;
            this.botonGenerarResumen.Text = "Generar Resumen";
            this.botonGenerarResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarResumen.UseVisualStyleBackColor = true;
            this.botonGenerarResumen.Click += new System.EventHandler(this.botonGenerarResumen_Click);
            // 
            // botonListar
            // 
            this.botonListar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListar.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonListar.Location = new System.Drawing.Point(603, 36);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(87, 33);
            this.botonListar.TabIndex = 4;
            this.botonListar.Text = "Listar";
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(394, 24);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(121, 21);
            this.dtpFechaHasta.TabIndex = 3;
            this.dtpFechaHasta.Value = new System.DateTime(2016, 9, 5, 0, 0, 0, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(203, 23);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(121, 21);
            this.dtpFechaDesde.TabIndex = 2;
            this.dtpFechaDesde.Value = new System.DateTime(2016, 9, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // dgvResumenDelDia
            // 
            this.dgvResumenDelDia.AllowUserToAddRows = false;
            this.dgvResumenDelDia.AllowUserToDeleteRows = false;
            this.dgvResumenDelDia.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumenDelDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResumenDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenDelDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xFuente,
            this.xPagante,
            this.xclai_codigo,
            this.xnro_Recibo,
            this.FechaPago,
            this.xmonto_pago,
            this.xclai_descripcion,
            this.xRecurso,
            this.xMontoTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumenDelDia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResumenDelDia.EnableHeadersVisualStyles = false;
            this.dgvResumenDelDia.Location = new System.Drawing.Point(15, 31);
            this.dgvResumenDelDia.MultiSelect = false;
            this.dgvResumenDelDia.Name = "dgvResumenDelDia";
            this.dgvResumenDelDia.ReadOnly = true;
            this.dgvResumenDelDia.RowHeadersVisible = false;
            this.dgvResumenDelDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumenDelDia.Size = new System.Drawing.Size(435, 159);
            this.dgvResumenDelDia.TabIndex = 2;
            // 
            // dgvResumenPorPartida
            // 
            this.dgvResumenPorPartida.AllowUserToAddRows = false;
            this.dgvResumenPorPartida.AllowUserToDeleteRows = false;
            this.dgvResumenPorPartida.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumenPorPartida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResumenPorPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenPorPartida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fuente,
            this.Pagante,
            this.nro_Recibo,
            this.Recurso,
            this.cFechaPago,
            this.monto_pago,
            this.clai_codigo,
            this.clai_descripcion,
            this.MontoTotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumenPorPartida.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResumenPorPartida.EnableHeadersVisualStyles = false;
            this.dgvResumenPorPartida.Location = new System.Drawing.Point(12, 31);
            this.dgvResumenPorPartida.MultiSelect = false;
            this.dgvResumenPorPartida.Name = "dgvResumenPorPartida";
            this.dgvResumenPorPartida.ReadOnly = true;
            this.dgvResumenPorPartida.RowHeadersVisible = false;
            this.dgvResumenPorPartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumenPorPartida.Size = new System.Drawing.Size(560, 358);
            this.dgvResumenPorPartida.TabIndex = 3;
            // 
            // Fuente
            // 
            this.Fuente.DataPropertyName = "Fuente";
            this.Fuente.HeaderText = "FUENTE";
            this.Fuente.Name = "Fuente";
            this.Fuente.ReadOnly = true;
            this.Fuente.Width = 60;
            // 
            // Pagante
            // 
            this.Pagante.DataPropertyName = "Pagante";
            this.Pagante.HeaderText = "Pagante";
            this.Pagante.Name = "Pagante";
            this.Pagante.ReadOnly = true;
            this.Pagante.Visible = false;
            // 
            // nro_Recibo
            // 
            this.nro_Recibo.DataPropertyName = "nro_Recibo";
            this.nro_Recibo.HeaderText = "nro_Recibo";
            this.nro_Recibo.Name = "nro_Recibo";
            this.nro_Recibo.ReadOnly = true;
            this.nro_Recibo.Visible = false;
            // 
            // Recurso
            // 
            this.Recurso.DataPropertyName = "Recurso";
            this.Recurso.HeaderText = "Recurso";
            this.Recurso.Name = "Recurso";
            this.Recurso.ReadOnly = true;
            this.Recurso.Visible = false;
            // 
            // cFechaPago
            // 
            this.cFechaPago.DataPropertyName = "FechaPago";
            this.cFechaPago.HeaderText = "FechaPago";
            this.cFechaPago.Name = "cFechaPago";
            this.cFechaPago.ReadOnly = true;
            this.cFechaPago.Visible = false;
            // 
            // monto_pago
            // 
            this.monto_pago.DataPropertyName = "monto_pago";
            this.monto_pago.HeaderText = "monto_pago";
            this.monto_pago.Name = "monto_pago";
            this.monto_pago.ReadOnly = true;
            this.monto_pago.Visible = false;
            // 
            // clai_codigo
            // 
            this.clai_codigo.DataPropertyName = "clai_codigo";
            this.clai_codigo.HeaderText = "PARTIDA";
            this.clai_codigo.Name = "clai_codigo";
            this.clai_codigo.ReadOnly = true;
            this.clai_codigo.Width = 120;
            // 
            // clai_descripcion
            // 
            this.clai_descripcion.DataPropertyName = "clai_descripcion";
            this.clai_descripcion.HeaderText = "CLASIFICACIÓN";
            this.clai_descripcion.Name = "clai_descripcion";
            this.clai_descripcion.ReadOnly = true;
            this.clai_descripcion.Width = 270;
            // 
            // MontoTotal
            // 
            this.MontoTotal.DataPropertyName = "MontoTotal";
            this.MontoTotal.HeaderText = "MONTO TOTAL";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgvResumenPorPartida);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 398);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen Por Partida";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.dgvResumenDelDia);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(588, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 209);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen del Día";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.dgvDevolucion);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(588, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 194);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Devolución";
            // 
            // dgvDevolucion
            // 
            this.dgvDevolucion.AllowUserToAddRows = false;
            this.dgvDevolucion.AllowUserToDeleteRows = false;
            this.dgvDevolucion.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dFuente,
            this.dPagante,
            this.dRecurso,
            this.dnro_Recibo,
            this.dmonto_pago,
            this.dFechaPago,
            this.dclai_codigo,
            this.dclai_descripcion,
            this.dMontoTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevolucion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDevolucion.EnableHeadersVisualStyles = false;
            this.dgvDevolucion.Location = new System.Drawing.Point(15, 21);
            this.dgvDevolucion.MultiSelect = false;
            this.dgvDevolucion.Name = "dgvDevolucion";
            this.dgvDevolucion.ReadOnly = true;
            this.dgvDevolucion.RowHeadersVisible = false;
            this.dgvDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucion.Size = new System.Drawing.Size(435, 159);
            this.dgvDevolucion.TabIndex = 3;
            // 
            // dFuente
            // 
            this.dFuente.DataPropertyName = "Fuente";
            this.dFuente.HeaderText = "FUENTE";
            this.dFuente.Name = "dFuente";
            this.dFuente.ReadOnly = true;
            this.dFuente.Width = 60;
            // 
            // dPagante
            // 
            this.dPagante.DataPropertyName = "Pagante";
            this.dPagante.HeaderText = "Pagante";
            this.dPagante.Name = "dPagante";
            this.dPagante.ReadOnly = true;
            this.dPagante.Visible = false;
            // 
            // dRecurso
            // 
            this.dRecurso.DataPropertyName = "Recurso";
            this.dRecurso.HeaderText = "Recurso";
            this.dRecurso.Name = "dRecurso";
            this.dRecurso.ReadOnly = true;
            this.dRecurso.Visible = false;
            // 
            // dnro_Recibo
            // 
            this.dnro_Recibo.DataPropertyName = "nro_Recibo";
            this.dnro_Recibo.HeaderText = "nro_Recibo";
            this.dnro_Recibo.Name = "dnro_Recibo";
            this.dnro_Recibo.ReadOnly = true;
            this.dnro_Recibo.Visible = false;
            // 
            // dmonto_pago
            // 
            this.dmonto_pago.DataPropertyName = "monto_pago";
            this.dmonto_pago.HeaderText = "monto_pago";
            this.dmonto_pago.Name = "dmonto_pago";
            this.dmonto_pago.ReadOnly = true;
            this.dmonto_pago.Visible = false;
            // 
            // dFechaPago
            // 
            this.dFechaPago.DataPropertyName = "FechaPago";
            this.dFechaPago.HeaderText = "FechaPago";
            this.dFechaPago.Name = "dFechaPago";
            this.dFechaPago.ReadOnly = true;
            this.dFechaPago.Visible = false;
            // 
            // dclai_codigo
            // 
            this.dclai_codigo.DataPropertyName = "clai_codigo";
            this.dclai_codigo.HeaderText = "PARTIDA";
            this.dclai_codigo.Name = "dclai_codigo";
            this.dclai_codigo.ReadOnly = true;
            this.dclai_codigo.Width = 120;
            // 
            // dclai_descripcion
            // 
            this.dclai_descripcion.DataPropertyName = "clai_descripcion";
            this.dclai_descripcion.HeaderText = "CLASIFICACIÓN";
            this.dclai_descripcion.Name = "dclai_descripcion";
            this.dclai_descripcion.ReadOnly = true;
            this.dclai_descripcion.Width = 150;
            // 
            // dMontoTotal
            // 
            this.dMontoTotal.DataPropertyName = "MontoTotal";
            this.dMontoTotal.HeaderText = "MONTO TOTAL";
            this.dMontoTotal.Name = "dMontoTotal";
            this.dMontoTotal.ReadOnly = true;
            // 
            // xFuente
            // 
            this.xFuente.DataPropertyName = "Fuente";
            this.xFuente.HeaderText = "FUENTE";
            this.xFuente.Name = "xFuente";
            this.xFuente.ReadOnly = true;
            this.xFuente.Width = 120;
            // 
            // xPagante
            // 
            this.xPagante.DataPropertyName = "Pagante";
            this.xPagante.HeaderText = "Pagante";
            this.xPagante.Name = "xPagante";
            this.xPagante.ReadOnly = true;
            this.xPagante.Visible = false;
            // 
            // xclai_codigo
            // 
            this.xclai_codigo.DataPropertyName = "clai_codigo";
            this.xclai_codigo.HeaderText = "clai_codigo";
            this.xclai_codigo.Name = "xclai_codigo";
            this.xclai_codigo.ReadOnly = true;
            this.xclai_codigo.Visible = false;
            // 
            // xnro_Recibo
            // 
            this.xnro_Recibo.DataPropertyName = "nro_Recibo";
            this.xnro_Recibo.HeaderText = "nro_Recibo";
            this.xnro_Recibo.Name = "xnro_Recibo";
            this.xnro_Recibo.ReadOnly = true;
            this.xnro_Recibo.Visible = false;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "FechaPago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Visible = false;
            // 
            // xmonto_pago
            // 
            this.xmonto_pago.DataPropertyName = "monto_pago";
            this.xmonto_pago.HeaderText = "monto_pago";
            this.xmonto_pago.Name = "xmonto_pago";
            this.xmonto_pago.ReadOnly = true;
            this.xmonto_pago.Visible = false;
            // 
            // xclai_descripcion
            // 
            this.xclai_descripcion.DataPropertyName = "clai_descripcion";
            this.xclai_descripcion.HeaderText = "clai_descripcion";
            this.xclai_descripcion.Name = "xclai_descripcion";
            this.xclai_descripcion.ReadOnly = true;
            this.xclai_descripcion.Visible = false;
            // 
            // xRecurso
            // 
            this.xRecurso.DataPropertyName = "Recurso";
            this.xRecurso.HeaderText = "RECURSO";
            this.xRecurso.Name = "xRecurso";
            this.xRecurso.ReadOnly = true;
            this.xRecurso.Visible = false;
            this.xRecurso.Width = 120;
            // 
            // xMontoTotal
            // 
            this.xMontoTotal.DataPropertyName = "MontoTotal";
            this.xMontoTotal.HeaderText = "MONTO TOTAL";
            this.xMontoTotal.Name = "xMontoTotal";
            this.xMontoTotal.ReadOnly = true;
            this.xMontoTotal.Width = 150;
            // 
            // Frm_PlanillaIngresosResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 492);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PlanillaIngresosResumen";
            this.Text = "Resumen para Planilla de Ingresos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenDelDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPorPartida)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonListar;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button botonGenerarResumen;
        private System.Windows.Forms.DataGridView dgvResumenDelDia;
        private System.Windows.Forms.DataGridView dgvResumenPorPartida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnro_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmonto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dclai_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dclai_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn clai_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clai_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.CheckBox chk_filtro;
        private System.Windows.Forms.ComboBox cboConceptoAgrupado;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclai_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnro_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmonto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclai_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoTotal;
    }
}