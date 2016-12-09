namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos
{
    partial class Frm_PlanillaIngresos
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
            this.groupBoxOpcionesBusqueda = new System.Windows.Forms.GroupBox();
            this.cboContribuyente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txt_pagante = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonListar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBusquedaOficina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGenerarReporte = new System.Windows.Forms.GroupBox();
            this.botonResumen = new System.Windows.Forms.Button();
            this.botonReporte = new System.Windows.Forms.Button();
            this.dgvListadoPlanillaIngresos = new System.Windows.Forms.DataGridView();
            this.xFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clai_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnro_Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmonto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclai_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOpcionesBusqueda.SuspendLayout();
            this.groupBoxGenerarReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPlanillaIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOpcionesBusqueda
            // 
            this.groupBoxOpcionesBusqueda.BackColor = System.Drawing.Color.Lavender;
            this.groupBoxOpcionesBusqueda.Controls.Add(this.cboContribuyente);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.label5);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.btnBusqueda);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.txt_pagante);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.checkBox1);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.label4);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.botonListar);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.dtpFechaHasta);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.dtpFechaDesde);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.label3);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.label2);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.comboBusquedaOficina);
            this.groupBoxOpcionesBusqueda.Controls.Add(this.label1);
            this.groupBoxOpcionesBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOpcionesBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOpcionesBusqueda.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOpcionesBusqueda.Name = "groupBoxOpcionesBusqueda";
            this.groupBoxOpcionesBusqueda.Size = new System.Drawing.Size(1028, 97);
            this.groupBoxOpcionesBusqueda.TabIndex = 0;
            this.groupBoxOpcionesBusqueda.TabStop = false;
            this.groupBoxOpcionesBusqueda.Text = "Opciones de Busqueda";
            // 
            // cboContribuyente
            // 
            this.cboContribuyente.Enabled = false;
            this.cboContribuyente.FormattingEnabled = true;
            this.cboContribuyente.Location = new System.Drawing.Point(594, 63);
            this.cboContribuyente.Name = "cboContribuyente";
            this.cboContribuyente.Size = new System.Drawing.Size(369, 21);
            this.cboContribuyente.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Contribuyente:";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Enabled = false;
            this.btnBusqueda.Image = global::SGR.WinApp.Properties.Resources.search1;
            this.btnBusqueda.Location = new System.Drawing.Point(420, 61);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(32, 23);
            this.btnBusqueda.TabIndex = 91;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txt_pagante
            // 
            this.txt_pagante.Enabled = false;
            this.txt_pagante.Location = new System.Drawing.Point(233, 63);
            this.txt_pagante.Name = "txt_pagante";
            this.txt_pagante.Size = new System.Drawing.Size(178, 21);
            this.txt_pagante.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(98, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Filtrar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar:";
            // 
            // botonListar
            // 
            this.botonListar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListar.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListar.Location = new System.Drawing.Point(817, 26);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(97, 27);
            this.botonListar.TabIndex = 8;
            this.botonListar.Text = "Listar";
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(661, 27);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(133, 21);
            this.dtpFechaHasta.TabIndex = 5;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(463, 27);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(133, 21);
            this.dtpFechaDesde.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde: ";
            // 
            // comboBusquedaOficina
            // 
            this.comboBusquedaOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaOficina.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaOficina.FormattingEnabled = true;
            this.comboBusquedaOficina.Location = new System.Drawing.Point(211, 27);
            this.comboBusquedaOficina.Name = "comboBusquedaOficina";
            this.comboBusquedaOficina.Size = new System.Drawing.Size(192, 21);
            this.comboBusquedaOficina.TabIndex = 1;
            this.comboBusquedaOficina.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaOficina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficina: ";
            // 
            // groupBoxGenerarReporte
            // 
            this.groupBoxGenerarReporte.BackColor = System.Drawing.Color.Lavender;
            this.groupBoxGenerarReporte.Controls.Add(this.botonResumen);
            this.groupBoxGenerarReporte.Controls.Add(this.botonReporte);
            this.groupBoxGenerarReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGenerarReporte.Location = new System.Drawing.Point(0, 97);
            this.groupBoxGenerarReporte.Name = "groupBoxGenerarReporte";
            this.groupBoxGenerarReporte.Size = new System.Drawing.Size(1028, 75);
            this.groupBoxGenerarReporte.TabIndex = 1;
            this.groupBoxGenerarReporte.TabStop = false;
            // 
            // botonResumen
            // 
            this.botonResumen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResumen.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonResumen.Location = new System.Drawing.Point(542, 19);
            this.botonResumen.Name = "botonResumen";
            this.botonResumen.Size = new System.Drawing.Size(168, 40);
            this.botonResumen.TabIndex = 1;
            this.botonResumen.Text = "Resumen Planilla";
            this.botonResumen.UseVisualStyleBackColor = true;
            this.botonResumen.Click += new System.EventHandler(this.botonResumen_Click);
            // 
            // botonReporte
            // 
            this.botonReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonReporte.Location = new System.Drawing.Point(346, 19);
            this.botonReporte.Name = "botonReporte";
            this.botonReporte.Size = new System.Drawing.Size(163, 40);
            this.botonReporte.TabIndex = 0;
            this.botonReporte.Text = "Generar Reporte";
            this.botonReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonReporte.UseVisualStyleBackColor = true;
            this.botonReporte.Click += new System.EventHandler(this.botonReporte_Click);
            // 
            // dgvListadoPlanillaIngresos
            // 
            this.dgvListadoPlanillaIngresos.AllowUserToAddRows = false;
            this.dgvListadoPlanillaIngresos.AllowUserToDeleteRows = false;
            this.dgvListadoPlanillaIngresos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoPlanillaIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoPlanillaIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPlanillaIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xFechaPago,
            this.clai_descripcion,
            this.MontoTotal,
            this.xnro_Recibo,
            this.xPagante,
            this.xmonto_pago,
            this.xclai_codigo,
            this.xFuente,
            this.xRecurso});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoPlanillaIngresos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoPlanillaIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoPlanillaIngresos.EnableHeadersVisualStyles = false;
            this.dgvListadoPlanillaIngresos.Location = new System.Drawing.Point(0, 172);
            this.dgvListadoPlanillaIngresos.Name = "dgvListadoPlanillaIngresos";
            this.dgvListadoPlanillaIngresos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoPlanillaIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoPlanillaIngresos.RowHeadersVisible = false;
            this.dgvListadoPlanillaIngresos.Size = new System.Drawing.Size(1028, 211);
            this.dgvListadoPlanillaIngresos.TabIndex = 2;
            // 
            // xFechaPago
            // 
            this.xFechaPago.DataPropertyName = "FechaPago";
            this.xFechaPago.HeaderText = "FECHA PAGO";
            this.xFechaPago.Name = "xFechaPago";
            this.xFechaPago.ReadOnly = true;
            this.xFechaPago.Width = 180;
            // 
            // clai_descripcion
            // 
            this.clai_descripcion.DataPropertyName = "clai_descripcion";
            this.clai_descripcion.HeaderText = "clai_descripcion";
            this.clai_descripcion.Name = "clai_descripcion";
            this.clai_descripcion.ReadOnly = true;
            this.clai_descripcion.Visible = false;
            // 
            // MontoTotal
            // 
            this.MontoTotal.DataPropertyName = "MontoTotal";
            this.MontoTotal.HeaderText = "MontoTotal";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Visible = false;
            // 
            // xnro_Recibo
            // 
            this.xnro_Recibo.DataPropertyName = "nro_Recibo";
            this.xnro_Recibo.HeaderText = "RECIBO";
            this.xnro_Recibo.Name = "xnro_Recibo";
            this.xnro_Recibo.ReadOnly = true;
            this.xnro_Recibo.Width = 140;
            // 
            // xPagante
            // 
            this.xPagante.DataPropertyName = "Pagante";
            this.xPagante.HeaderText = "PAGANTE";
            this.xPagante.Name = "xPagante";
            this.xPagante.ReadOnly = true;
            this.xPagante.Width = 320;
            // 
            // xmonto_pago
            // 
            this.xmonto_pago.DataPropertyName = "monto_pago";
            this.xmonto_pago.HeaderText = "IMPORTE";
            this.xmonto_pago.Name = "xmonto_pago";
            this.xmonto_pago.ReadOnly = true;
            // 
            // xclai_codigo
            // 
            this.xclai_codigo.DataPropertyName = "clai_codigo";
            this.xclai_codigo.HeaderText = "PARTIDA";
            this.xclai_codigo.Name = "xclai_codigo";
            this.xclai_codigo.ReadOnly = true;
            // 
            // xFuente
            // 
            this.xFuente.DataPropertyName = "Fuente";
            this.xFuente.HeaderText = "RUBRO F.";
            this.xFuente.Name = "xFuente";
            this.xFuente.ReadOnly = true;
            // 
            // xRecurso
            // 
            this.xRecurso.DataPropertyName = "Recurso";
            this.xRecurso.HeaderText = "RECURSO";
            this.xRecurso.Name = "xRecurso";
            this.xRecurso.ReadOnly = true;
            // 
            // Frm_PlanillaIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 383);
            this.Controls.Add(this.dgvListadoPlanillaIngresos);
            this.Controls.Add(this.groupBoxGenerarReporte);
            this.Controls.Add(this.groupBoxOpcionesBusqueda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_PlanillaIngresos";
            this.Text = "Listado Planilla de Ingresos";
            this.Load += new System.EventHandler(this.Frm_PlanillaIngresos_Load);
            this.groupBoxOpcionesBusqueda.ResumeLayout(false);
            this.groupBoxOpcionesBusqueda.PerformLayout();
            this.groupBoxGenerarReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPlanillaIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOpcionesBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBusquedaOficina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxGenerarReporte;
        private System.Windows.Forms.Button botonReporte;
        private System.Windows.Forms.Button botonListar;
        private System.Windows.Forms.DataGridView dgvListadoPlanillaIngresos;
        private System.Windows.Forms.Button botonResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn clai_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnro_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmonto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclai_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRecurso;
        private System.Windows.Forms.TextBox txt_pagante;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ComboBox cboContribuyente;
    }
}