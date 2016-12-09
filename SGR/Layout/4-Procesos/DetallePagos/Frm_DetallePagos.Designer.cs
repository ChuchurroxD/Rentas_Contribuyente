namespace SGR.WinApp.Layout._4_Procesos.DetallePagos
{
    partial class Frm_DetallePagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonFacturadoCobrado = new System.Windows.Forms.Button();
            this.botonGenerarReporte = new System.Windows.Forms.Button();
            this.botonListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBusquedaCaja = new System.Windows.Forms.ComboBox();
            this.dtpFechaPagoHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPagoDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarDetallePagos = new System.Windows.Forms.DataGridView();
            this.nro_Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonCajaResumen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDetallePagos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.botonCajaResumen);
            this.groupBox1.Controls.Add(this.botonFacturadoCobrado);
            this.groupBox1.Controls.Add(this.botonGenerarReporte);
            this.groupBox1.Controls.Add(this.botonListar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBusquedaCaja);
            this.groupBox1.Controls.Add(this.dtpFechaPagoHasta);
            this.groupBox1.Controls.Add(this.dtpFechaPagoDesde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // botonFacturadoCobrado
            // 
            this.botonFacturadoCobrado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botonFacturadoCobrado.Location = new System.Drawing.Point(844, 78);
            this.botonFacturadoCobrado.Name = "botonFacturadoCobrado";
            this.botonFacturadoCobrado.Size = new System.Drawing.Size(195, 26);
            this.botonFacturadoCobrado.TabIndex = 11;
            this.botonFacturadoCobrado.Text = "Prueba Facturado Cobrado";
            this.botonFacturadoCobrado.UseVisualStyleBackColor = false;
            this.botonFacturadoCobrado.Click += new System.EventHandler(this.botonFacturadoCobrado_Click);
            // 
            // botonGenerarReporte
            // 
            this.botonGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarReporte.Location = new System.Drawing.Point(441, 87);
            this.botonGenerarReporte.Name = "botonGenerarReporte";
            this.botonGenerarReporte.Size = new System.Drawing.Size(160, 44);
            this.botonGenerarReporte.TabIndex = 10;
            this.botonGenerarReporte.Text = "Generar Reporte";
            this.botonGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarReporte.UseVisualStyleBackColor = true;
            this.botonGenerarReporte.Click += new System.EventHandler(this.botonGenerarReporte_Click);
            // 
            // botonListar
            // 
            this.botonListar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListar.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonListar.Location = new System.Drawing.Point(793, 39);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(106, 33);
            this.botonListar.TabIndex = 9;
            this.botonListar.Text = "Listar";
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde:";
            // 
            // comboBusquedaCaja
            // 
            this.comboBusquedaCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaCaja.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaCaja.FormattingEnabled = true;
            this.comboBusquedaCaja.Location = new System.Drawing.Point(597, 46);
            this.comboBusquedaCaja.Name = "comboBusquedaCaja";
            this.comboBusquedaCaja.Size = new System.Drawing.Size(161, 21);
            this.comboBusquedaCaja.TabIndex = 5;
            this.comboBusquedaCaja.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaCaja_SelectedIndexChanged);
            // 
            // dtpFechaPagoHasta
            // 
            this.dtpFechaPagoHasta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPagoHasta.Location = new System.Drawing.Point(393, 45);
            this.dtpFechaPagoHasta.Name = "dtpFechaPagoHasta";
            this.dtpFechaPagoHasta.Size = new System.Drawing.Size(149, 21);
            this.dtpFechaPagoHasta.TabIndex = 4;
            // 
            // dtpFechaPagoDesde
            // 
            this.dtpFechaPagoDesde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPagoDesde.Location = new System.Drawing.Point(186, 45);
            this.dtpFechaPagoDesde.Name = "dtpFechaPagoDesde";
            this.dtpFechaPagoDesde.Size = new System.Drawing.Size(161, 21);
            this.dtpFechaPagoDesde.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta:";
            // 
            // dgvListarDetallePagos
            // 
            this.dgvListarDetallePagos.AllowUserToAddRows = false;
            this.dgvListarDetallePagos.AllowUserToDeleteRows = false;
            this.dgvListarDetallePagos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarDetallePagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListarDetallePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarDetallePagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_Recibo,
            this.Pagante,
            this.Caja_id,
            this.CajaDescripcion,
            this.TipoPago,
            this.DescripcionTipoPago,
            this.FechaPago,
            this.HFechaPago,
            this.MontoTotal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarDetallePagos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListarDetallePagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarDetallePagos.EnableHeadersVisualStyles = false;
            this.dgvListarDetallePagos.Location = new System.Drawing.Point(0, 140);
            this.dgvListarDetallePagos.Name = "dgvListarDetallePagos";
            this.dgvListarDetallePagos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarDetallePagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListarDetallePagos.RowHeadersVisible = false;
            this.dgvListarDetallePagos.Size = new System.Drawing.Size(1045, 268);
            this.dgvListarDetallePagos.TabIndex = 1;
            // 
            // nro_Recibo
            // 
            this.nro_Recibo.DataPropertyName = "nro_Recibo";
            this.nro_Recibo.HeaderText = "RECIBO";
            this.nro_Recibo.Name = "nro_Recibo";
            this.nro_Recibo.ReadOnly = true;
            this.nro_Recibo.Width = 80;
            // 
            // Pagante
            // 
            this.Pagante.DataPropertyName = "Pagante";
            this.Pagante.HeaderText = "PAGANTE";
            this.Pagante.Name = "Pagante";
            this.Pagante.ReadOnly = true;
            this.Pagante.Width = 350;
            // 
            // Caja_id
            // 
            this.Caja_id.DataPropertyName = "Caja_id";
            this.Caja_id.HeaderText = "CODIGO CAJA";
            this.Caja_id.Name = "Caja_id";
            this.Caja_id.ReadOnly = true;
            this.Caja_id.Visible = false;
            // 
            // CajaDescripcion
            // 
            this.CajaDescripcion.DataPropertyName = "CajaDescripcion";
            this.CajaDescripcion.HeaderText = "N° CAJA";
            this.CajaDescripcion.Name = "CajaDescripcion";
            this.CajaDescripcion.ReadOnly = true;
            this.CajaDescripcion.Width = 150;
            // 
            // TipoPago
            // 
            this.TipoPago.DataPropertyName = "TipoPago";
            this.TipoPago.HeaderText = "CODIGO TIPO PAGO";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.ReadOnly = true;
            this.TipoPago.Visible = false;
            // 
            // DescripcionTipoPago
            // 
            this.DescripcionTipoPago.DataPropertyName = "DescripcionTipoPago";
            this.DescripcionTipoPago.HeaderText = "TIPO PAGO";
            this.DescripcionTipoPago.Name = "DescripcionTipoPago";
            this.DescripcionTipoPago.ReadOnly = true;
            this.DescripcionTipoPago.Width = 120;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "FECHA PAGO";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Width = 150;
            // 
            // HFechaPago
            // 
            this.HFechaPago.DataPropertyName = "FechaPago";
            this.HFechaPago.HeaderText = "HORA PAGO";
            this.HFechaPago.Name = "HFechaPago";
            this.HFechaPago.ReadOnly = true;
            this.HFechaPago.Visible = false;
            this.HFechaPago.Width = 120;
            // 
            // MontoTotal
            // 
            this.MontoTotal.DataPropertyName = "MontoTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MontoTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.MontoTotal.HeaderText = "MONTO S/";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // botonCajaResumen
            // 
            this.botonCajaResumen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botonCajaResumen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.botonCajaResumen.Location = new System.Drawing.Point(844, 105);
            this.botonCajaResumen.Name = "botonCajaResumen";
            this.botonCajaResumen.Size = new System.Drawing.Size(195, 26);
            this.botonCajaResumen.TabIndex = 12;
            this.botonCajaResumen.Text = "Prueba Caja Resumen";
            this.botonCajaResumen.UseVisualStyleBackColor = false;
            this.botonCajaResumen.Click += new System.EventHandler(this.botonCajaResumen_Click);
            // 
            // Frm_DetallePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 408);
            this.Controls.Add(this.dgvListarDetallePagos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DetallePagos";
            this.Text = "Frm_DetallePagos";
            this.Load += new System.EventHandler(this.Frm_DetallePagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDetallePagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBusquedaCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonGenerarReporte;
        private System.Windows.Forms.Button botonListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarDetallePagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn HFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.Button botonFacturadoCobrado;
        private System.Windows.Forms.Button botonCajaResumen;
    }
}