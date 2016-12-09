namespace SGR.WinApp.Layout._4_Procesos.Compensación
{
    partial class Frm_ReporteCompensacionDetalle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCompensacion_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTributo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCompensacionDetalle = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compensacion_idc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaCompensacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCorriente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCompensado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xinteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdeudaVencida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonGenerarReporte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompensacionDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.botonGenerarReporte);
            this.groupBox1.Controls.Add(this.lblCompensacion_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTributo);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDocumento);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Contribuyente";
            // 
            // lblCompensacion_id
            // 
            this.lblCompensacion_id.AutoSize = true;
            this.lblCompensacion_id.Location = new System.Drawing.Point(555, 29);
            this.lblCompensacion_id.Name = "lblCompensacion_id";
            this.lblCompensacion_id.Size = new System.Drawing.Size(149, 15);
            this.lblCompensacion_id.TabIndex = 11;
            this.lblCompensacion_id.Text = "Código compensación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código Compensación:";
            // 
            // lblTributo
            // 
            this.lblTributo.AutoSize = true;
            this.lblTributo.Location = new System.Drawing.Point(456, 50);
            this.lblTributo.Name = "lblTributo";
            this.lblTributo.Size = new System.Drawing.Size(52, 15);
            this.lblTributo.TabIndex = 9;
            this.lblTributo.Text = "Tributo";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(394, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 15);
            this.label.TabIndex = 8;
            this.label.Text = "Tributo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(77, 73);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 15);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(202, 50);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(80, 15);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(168, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento de identidad:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos y Nombres:";
            // 
            // dgCompensacionDetalle
            // 
            this.dgCompensacionDetalle.AllowUserToAddRows = false;
            this.dgCompensacionDetalle.AllowUserToDeleteRows = false;
            this.dgCompensacionDetalle.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompensacionDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCompensacionDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompensacionDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row,
            this.xpersona,
            this.compensacion_idc,
            this.observacion,
            this.expediente,
            this.nombrePersona,
            this.xpredio,
            this.Ubicacion,
            this.xtributo,
            this.Column6,
            this.fecha,
            this.registro_fecha_add,
            this.registro_pc_add,
            this.registro_user_add,
            this.registro_fecha_update,
            this.registro_user_update,
            this.registro_pc_update,
            this.detaCompensacion_id,
            this.cuentaCorriente_id,
            this.montoDeuda,
            this.montoAbono,
            this.anio,
            this.mes,
            this.montoCompensado,
            this.xmonto,
            this.xinteres,
            this.xtotal,
            this.xdeudaVencida,
            this.periodo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCompensacionDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCompensacionDetalle.EnableHeadersVisualStyles = false;
            this.dgCompensacionDetalle.Location = new System.Drawing.Point(12, 118);
            this.dgCompensacionDetalle.Name = "dgCompensacionDetalle";
            this.dgCompensacionDetalle.ReadOnly = true;
            this.dgCompensacionDetalle.RowHeadersVisible = false;
            this.dgCompensacionDetalle.RowHeadersWidth = 30;
            this.dgCompensacionDetalle.RowTemplate.Height = 30;
            this.dgCompensacionDetalle.Size = new System.Drawing.Size(818, 202);
            this.dgCompensacionDetalle.TabIndex = 3;
            // 
            // row
            // 
            this.row.DataPropertyName = "row";
            this.row.HeaderText = "Row";
            this.row.Name = "row";
            this.row.ReadOnly = true;
            this.row.Width = 70;
            // 
            // xpersona
            // 
            this.xpersona.DataPropertyName = "persona_id";
            this.xpersona.HeaderText = "Persona";
            this.xpersona.Name = "xpersona";
            this.xpersona.ReadOnly = true;
            this.xpersona.Visible = false;
            // 
            // compensacion_idc
            // 
            this.compensacion_idc.DataPropertyName = "compensacion_id";
            this.compensacion_idc.HeaderText = "compensacion_id";
            this.compensacion_idc.Name = "compensacion_idc";
            this.compensacion_idc.ReadOnly = true;
            this.compensacion_idc.Visible = false;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Visible = false;
            // 
            // expediente
            // 
            this.expediente.DataPropertyName = "expediente";
            this.expediente.HeaderText = "Expediente";
            this.expediente.Name = "expediente";
            this.expediente.ReadOnly = true;
            this.expediente.Visible = false;
            // 
            // nombrePersona
            // 
            this.nombrePersona.DataPropertyName = "nombrePersona";
            this.nombrePersona.HeaderText = "Nombre ";
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.ReadOnly = true;
            this.nombrePersona.Visible = false;
            // 
            // xpredio
            // 
            this.xpredio.DataPropertyName = "predio_ID";
            this.xpredio.HeaderText = "Predio";
            this.xpredio.Name = "xpredio";
            this.xpredio.ReadOnly = true;
            this.xpredio.Visible = false;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "predio";
            this.Ubicacion.HeaderText = "Ubicación";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Visible = false;
            // 
            // xtributo
            // 
            this.xtributo.DataPropertyName = "tributos_id";
            this.xtributo.HeaderText = "Grupo Tributo";
            this.xtributo.Name = "xtributo";
            this.xtributo.ReadOnly = true;
            this.xtributo.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tributos_descrip";
            this.Column6.HeaderText = "Grupo Tributo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
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
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "PC Update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // detaCompensacion_id
            // 
            this.detaCompensacion_id.DataPropertyName = "detaCompensacion_id";
            this.detaCompensacion_id.HeaderText = "detaCompensacion_id";
            this.detaCompensacion_id.Name = "detaCompensacion_id";
            this.detaCompensacion_id.ReadOnly = true;
            this.detaCompensacion_id.Visible = false;
            // 
            // cuentaCorriente_id
            // 
            this.cuentaCorriente_id.DataPropertyName = "cuentaCorriente_id";
            this.cuentaCorriente_id.HeaderText = "cuentaCorriente_id";
            this.cuentaCorriente_id.Name = "cuentaCorriente_id";
            this.cuentaCorriente_id.ReadOnly = true;
            this.cuentaCorriente_id.Visible = false;
            // 
            // montoDeuda
            // 
            this.montoDeuda.DataPropertyName = "montoDeuda";
            this.montoDeuda.HeaderText = "montoDeuda";
            this.montoDeuda.Name = "montoDeuda";
            this.montoDeuda.ReadOnly = true;
            this.montoDeuda.Visible = false;
            // 
            // montoAbono
            // 
            this.montoAbono.DataPropertyName = "montoAbono";
            this.montoAbono.HeaderText = "montoAbono";
            this.montoAbono.Name = "montoAbono";
            this.montoAbono.ReadOnly = true;
            this.montoAbono.Visible = false;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // montoCompensado
            // 
            this.montoCompensado.DataPropertyName = "montoCompensado";
            this.montoCompensado.HeaderText = "Monto Compensado";
            this.montoCompensado.Name = "montoCompensado";
            this.montoCompensado.ReadOnly = true;
            this.montoCompensado.Width = 150;
            // 
            // xmonto
            // 
            this.xmonto.DataPropertyName = "monto";
            this.xmonto.HeaderText = "Deuda (S/.)";
            this.xmonto.Name = "xmonto";
            this.xmonto.ReadOnly = true;
            this.xmonto.Visible = false;
            // 
            // xinteres
            // 
            this.xinteres.DataPropertyName = "interes";
            this.xinteres.HeaderText = "Interes (S/.)";
            this.xinteres.Name = "xinteres";
            this.xinteres.ReadOnly = true;
            this.xinteres.Visible = false;
            // 
            // xtotal
            // 
            this.xtotal.DataPropertyName = "total";
            this.xtotal.HeaderText = "Deuda Total (S/.)";
            this.xtotal.Name = "xtotal";
            this.xtotal.ReadOnly = true;
            this.xtotal.Visible = false;
            // 
            // xdeudaVencida
            // 
            this.xdeudaVencida.DataPropertyName = "deudaVencida";
            this.xdeudaVencida.HeaderText = "Deuda Vencida";
            this.xdeudaVencida.Name = "xdeudaVencida";
            this.xdeudaVencida.ReadOnly = true;
            this.xdeudaVencida.Visible = false;
            // 
            // periodo
            // 
            this.periodo.DataPropertyName = "periodo";
            this.periodo.HeaderText = "periodo";
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            this.periodo.Visible = false;
            // 
            // botonGenerarReporte
            // 
            this.botonGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarReporte.Location = new System.Drawing.Point(640, 50);
            this.botonGenerarReporte.Name = "botonGenerarReporte";
            this.botonGenerarReporte.Size = new System.Drawing.Size(160, 44);
            this.botonGenerarReporte.TabIndex = 12;
            this.botonGenerarReporte.Text = "Generar Reporte";
            this.botonGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarReporte.UseVisualStyleBackColor = true;
            this.botonGenerarReporte.Click += new System.EventHandler(this.botonGenerarReporte_Click);
            // 
            // Frm_ReporteCompensacionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 332);
            this.Controls.Add(this.dgCompensacionDetalle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ReporteCompensacionDetalle";
            this.Text = "Detalles Compensaciones";
            this.Load += new System.EventHandler(this.Frm_ReporteCompensacionDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompensacionDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTributo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblCompensacion_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgCompensacionDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn compensacion_idc;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaCompensacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaCorriente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCompensado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xinteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdeudaVencida;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.Button botonGenerarReporte;
    }
}