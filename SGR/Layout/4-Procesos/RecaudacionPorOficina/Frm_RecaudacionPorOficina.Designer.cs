namespace SGR.WinApp.Layout._4_Procesos.RecaudacionPorOficina
{
    partial class Frm_RecaudacionPorOficina
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
            this.groupOpcionBusqueda = new System.Windows.Forms.GroupBox();
            this.botonListar = new System.Windows.Forms.Button();
            this.comboBusquedaDesde = new System.Windows.Forms.ComboBox();
            this.comboBusquedaHasta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonReporte = new System.Windows.Forms.Button();
            this.comboBusquedaOficina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarRecaudacionPorOficina = new System.Windows.Forms.DataGridView();
            this.xtributos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPeriodoDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPeriodoHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficina_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcionOficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xClasificacionDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTablaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAre_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTributoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmonto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupOpcionBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarRecaudacionPorOficina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupOpcionBusqueda
            // 
            this.groupOpcionBusqueda.BackColor = System.Drawing.Color.Lavender;
            this.groupOpcionBusqueda.Controls.Add(this.botonListar);
            this.groupOpcionBusqueda.Controls.Add(this.comboBusquedaDesde);
            this.groupOpcionBusqueda.Controls.Add(this.comboBusquedaHasta);
            this.groupOpcionBusqueda.Controls.Add(this.label4);
            this.groupOpcionBusqueda.Controls.Add(this.label3);
            this.groupOpcionBusqueda.Controls.Add(this.label2);
            this.groupOpcionBusqueda.Controls.Add(this.botonReporte);
            this.groupOpcionBusqueda.Controls.Add(this.comboBusquedaOficina);
            this.groupOpcionBusqueda.Controls.Add(this.label1);
            this.groupOpcionBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupOpcionBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOpcionBusqueda.Location = new System.Drawing.Point(0, 0);
            this.groupOpcionBusqueda.Name = "groupOpcionBusqueda";
            this.groupOpcionBusqueda.Size = new System.Drawing.Size(1028, 142);
            this.groupOpcionBusqueda.TabIndex = 0;
            this.groupOpcionBusqueda.TabStop = false;
            this.groupOpcionBusqueda.Text = "Opciones de Busqueda";
            // 
            // botonListar
            // 
            this.botonListar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListar.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonListar.Location = new System.Drawing.Point(895, 32);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(91, 31);
            this.botonListar.TabIndex = 10;
            this.botonListar.Text = "Listar ";
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // comboBusquedaDesde
            // 
            this.comboBusquedaDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaDesde.FormattingEnabled = true;
            this.comboBusquedaDesde.Location = new System.Drawing.Point(507, 38);
            this.comboBusquedaDesde.Name = "comboBusquedaDesde";
            this.comboBusquedaDesde.Size = new System.Drawing.Size(151, 21);
            this.comboBusquedaDesde.TabIndex = 9;
            // 
            // comboBusquedaHasta
            // 
            this.comboBusquedaHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaHasta.FormattingEnabled = true;
            this.comboBusquedaHasta.Location = new System.Drawing.Point(709, 38);
            this.comboBusquedaHasta.Name = "comboBusquedaHasta";
            this.comboBusquedaHasta.Size = new System.Drawing.Size(153, 21);
            this.comboBusquedaHasta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desde ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo: ";
            // 
            // botonReporte
            // 
            this.botonReporte.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonReporte.Location = new System.Drawing.Point(503, 85);
            this.botonReporte.Name = "botonReporte";
            this.botonReporte.Size = new System.Drawing.Size(180, 51);
            this.botonReporte.TabIndex = 2;
            this.botonReporte.Text = "Generar Reporte";
            this.botonReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonReporte.UseVisualStyleBackColor = true;
            this.botonReporte.Click += new System.EventHandler(this.botonReporte_Click);
            // 
            // comboBusquedaOficina
            // 
            this.comboBusquedaOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaOficina.FormattingEnabled = true;
            this.comboBusquedaOficina.Location = new System.Drawing.Point(160, 38);
            this.comboBusquedaOficina.Name = "comboBusquedaOficina";
            this.comboBusquedaOficina.Size = new System.Drawing.Size(237, 21);
            this.comboBusquedaOficina.TabIndex = 1;
            this.comboBusquedaOficina.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaOficina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficina: ";
            // 
            // dgvListarRecaudacionPorOficina
            // 
            this.dgvListarRecaudacionPorOficina.AllowUserToAddRows = false;
            this.dgvListarRecaudacionPorOficina.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListarRecaudacionPorOficina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarRecaudacionPorOficina.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListarRecaudacionPorOficina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListarRecaudacionPorOficina.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarRecaudacionPorOficina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarRecaudacionPorOficina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarRecaudacionPorOficina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xtributos_ID,
            this.xPeriodoDesde,
            this.xPeriodoHasta,
            this.oficina_id,
            this.xDescripcionOficina,
            this.xClasificacionDescripcion,
            this.xTablaDescripcion,
            this.xAre_descripcion,
            this.xTributoDescripcion,
            this.xmonto_pago});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarRecaudacionPorOficina.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarRecaudacionPorOficina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarRecaudacionPorOficina.EnableHeadersVisualStyles = false;
            this.dgvListarRecaudacionPorOficina.Location = new System.Drawing.Point(0, 142);
            this.dgvListarRecaudacionPorOficina.MultiSelect = false;
            this.dgvListarRecaudacionPorOficina.Name = "dgvListarRecaudacionPorOficina";
            this.dgvListarRecaudacionPorOficina.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarRecaudacionPorOficina.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListarRecaudacionPorOficina.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListarRecaudacionPorOficina.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListarRecaudacionPorOficina.RowTemplate.ReadOnly = true;
            this.dgvListarRecaudacionPorOficina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarRecaudacionPorOficina.Size = new System.Drawing.Size(1028, 260);
            this.dgvListarRecaudacionPorOficina.TabIndex = 1;
            // 
            // xtributos_ID
            // 
            this.xtributos_ID.DataPropertyName = "tributos_ID";
            this.xtributos_ID.HeaderText = "CODIGO";
            this.xtributos_ID.Name = "xtributos_ID";
            this.xtributos_ID.ReadOnly = true;
            // 
            // xPeriodoDesde
            // 
            this.xPeriodoDesde.DataPropertyName = "PeriodoDesde";
            this.xPeriodoDesde.HeaderText = "PeriodoDesde";
            this.xPeriodoDesde.Name = "xPeriodoDesde";
            this.xPeriodoDesde.ReadOnly = true;
            this.xPeriodoDesde.Visible = false;
            // 
            // xPeriodoHasta
            // 
            this.xPeriodoHasta.DataPropertyName = "PeriodoHasta";
            this.xPeriodoHasta.HeaderText = "PeriodoHasta";
            this.xPeriodoHasta.Name = "xPeriodoHasta";
            this.xPeriodoHasta.ReadOnly = true;
            this.xPeriodoHasta.Visible = false;
            // 
            // oficina_id
            // 
            this.oficina_id.DataPropertyName = "oficina_id";
            this.oficina_id.HeaderText = "oficina_id";
            this.oficina_id.Name = "oficina_id";
            this.oficina_id.ReadOnly = true;
            this.oficina_id.Visible = false;
            // 
            // xDescripcionOficina
            // 
            this.xDescripcionOficina.DataPropertyName = "DescripcionOficina";
            this.xDescripcionOficina.HeaderText = "OFICINA";
            this.xDescripcionOficina.Name = "xDescripcionOficina";
            this.xDescripcionOficina.ReadOnly = true;
            this.xDescripcionOficina.Visible = false;
            // 
            // xClasificacionDescripcion
            // 
            this.xClasificacionDescripcion.DataPropertyName = "ClasificacionDescripcion";
            this.xClasificacionDescripcion.HeaderText = "CLASIFICACION";
            this.xClasificacionDescripcion.Name = "xClasificacionDescripcion";
            this.xClasificacionDescripcion.ReadOnly = true;
            this.xClasificacionDescripcion.Width = 260;
            // 
            // xTablaDescripcion
            // 
            this.xTablaDescripcion.DataPropertyName = "TablaDescripcion";
            this.xTablaDescripcion.HeaderText = "TABLA DESCRIPCION";
            this.xTablaDescripcion.Name = "xTablaDescripcion";
            this.xTablaDescripcion.ReadOnly = true;
            this.xTablaDescripcion.Width = 150;
            // 
            // xAre_descripcion
            // 
            this.xAre_descripcion.DataPropertyName = "Are_Descripcion";
            this.xAre_descripcion.HeaderText = "AREA";
            this.xAre_descripcion.Name = "xAre_descripcion";
            this.xAre_descripcion.ReadOnly = true;
            this.xAre_descripcion.Width = 280;
            // 
            // xTributoDescripcion
            // 
            this.xTributoDescripcion.DataPropertyName = "TributoDescripcion";
            this.xTributoDescripcion.HeaderText = "TRIBUTO";
            this.xTributoDescripcion.Name = "xTributoDescripcion";
            this.xTributoDescripcion.ReadOnly = true;
            this.xTributoDescripcion.Width = 260;
            // 
            // xmonto_pago
            // 
            this.xmonto_pago.DataPropertyName = "monto_pago";
            this.xmonto_pago.HeaderText = "MONTO DE PAGO";
            this.xmonto_pago.Name = "xmonto_pago";
            this.xmonto_pago.ReadOnly = true;
            this.xmonto_pago.Width = 130;
            // 
            // Frm_RecaudacionPorOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 402);
            this.Controls.Add(this.dgvListarRecaudacionPorOficina);
            this.Controls.Add(this.groupOpcionBusqueda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RecaudacionPorOficina";
            this.Text = "Listado de Recaudacion por Oficina";
            this.Load += new System.EventHandler(this.Frm_RecaudacionPorOficina_Load);
            this.groupOpcionBusqueda.ResumeLayout(false);
            this.groupOpcionBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarRecaudacionPorOficina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOpcionBusqueda;
        private System.Windows.Forms.ComboBox comboBusquedaOficina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarRecaudacionPorOficina;
        private System.Windows.Forms.Button botonReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBusquedaDesde;
        private System.Windows.Forms.ComboBox comboBusquedaHasta;
        private System.Windows.Forms.Button botonListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtributos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPeriodoDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPeriodoHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficina_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcionOficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn xClasificacionDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTablaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAre_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTributoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmonto_pago;
    }
}