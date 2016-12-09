namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_FacturadoCobrado
{
    partial class Frm_FacturadoCobrado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonListar = new System.Windows.Forms.Button();
            this.comboBusquedaMes = new System.Windows.Forms.ComboBox();
            this.comboBusquedaPeriodo = new System.Windows.Forms.ComboBox();
            this.comboBusquedaOficina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonGenerarReporte = new System.Windows.Forms.Button();
            this.dgvFacturadoCobrado = new System.Windows.Forms.DataGridView();
            this.tributos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TributoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morosidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBusquedaMesHasta = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturadoCobrado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.comboBusquedaMesHasta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.botonListar);
            this.groupBox1.Controls.Add(this.comboBusquedaMes);
            this.groupBox1.Controls.Add(this.comboBusquedaPeriodo);
            this.groupBox1.Controls.Add(this.comboBusquedaOficina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botonGenerarReporte);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // botonListar
            // 
            this.botonListar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListar.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListar.Location = new System.Drawing.Point(648, 17);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(83, 34);
            this.botonListar.TabIndex = 9;
            this.botonListar.Text = "Listar";
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // comboBusquedaMes
            // 
            this.comboBusquedaMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaMes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaMes.FormattingEnabled = true;
            this.comboBusquedaMes.Location = new System.Drawing.Point(265, 25);
            this.comboBusquedaMes.Name = "comboBusquedaMes";
            this.comboBusquedaMes.Size = new System.Drawing.Size(134, 21);
            this.comboBusquedaMes.TabIndex = 8;
            this.comboBusquedaMes.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaMes_SelectedIndexChanged);
            // 
            // comboBusquedaPeriodo
            // 
            this.comboBusquedaPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaPeriodo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaPeriodo.FormattingEnabled = true;
            this.comboBusquedaPeriodo.Location = new System.Drawing.Point(85, 25);
            this.comboBusquedaPeriodo.Name = "comboBusquedaPeriodo";
            this.comboBusquedaPeriodo.Size = new System.Drawing.Size(105, 21);
            this.comboBusquedaPeriodo.TabIndex = 7;
            // 
            // comboBusquedaOficina
            // 
            this.comboBusquedaOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaOficina.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaOficina.FormattingEnabled = true;
            this.comboBusquedaOficina.Location = new System.Drawing.Point(61, 69);
            this.comboBusquedaOficina.Name = "comboBusquedaOficina";
            this.comboBusquedaOficina.Size = new System.Drawing.Size(141, 21);
            this.comboBusquedaOficina.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oficina:";
            // 
            // botonGenerarReporte
            // 
            this.botonGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarReporte.Location = new System.Drawing.Point(277, 64);
            this.botonGenerarReporte.Name = "botonGenerarReporte";
            this.botonGenerarReporte.Size = new System.Drawing.Size(159, 34);
            this.botonGenerarReporte.TabIndex = 2;
            this.botonGenerarReporte.Text = "Generar Reporte";
            this.botonGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarReporte.UseVisualStyleBackColor = true;
            this.botonGenerarReporte.Click += new System.EventHandler(this.botonGenerarReporte_Click);
            // 
            // dgvFacturadoCobrado
            // 
            this.dgvFacturadoCobrado.AllowUserToAddRows = false;
            this.dgvFacturadoCobrado.AllowUserToDeleteRows = false;
            this.dgvFacturadoCobrado.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturadoCobrado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturadoCobrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturadoCobrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tributos_ID,
            this.mes,
            this.anio,
            this.idOficina,
            this.TributoDescripcion,
            this.abono,
            this.cargo,
            this.Saldo,
            this.Cobrado,
            this.Morosidad});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturadoCobrado.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFacturadoCobrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturadoCobrado.EnableHeadersVisualStyles = false;
            this.dgvFacturadoCobrado.Location = new System.Drawing.Point(0, 104);
            this.dgvFacturadoCobrado.MultiSelect = false;
            this.dgvFacturadoCobrado.Name = "dgvFacturadoCobrado";
            this.dgvFacturadoCobrado.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturadoCobrado.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFacturadoCobrado.RowHeadersVisible = false;
            this.dgvFacturadoCobrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturadoCobrado.Size = new System.Drawing.Size(743, 192);
            this.dgvFacturadoCobrado.TabIndex = 1;
            this.dgvFacturadoCobrado.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvFacturadoCobrado_Paint);
            // 
            // tributos_ID
            // 
            this.tributos_ID.DataPropertyName = "tributos_ID";
            this.tributos_ID.HeaderText = "CODIGO TRIBUTO";
            this.tributos_ID.Name = "tributos_ID";
            this.tributos_ID.ReadOnly = true;
            this.tributos_ID.Visible = false;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Visible = false;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "anio";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Visible = false;
            // 
            // idOficina
            // 
            this.idOficina.DataPropertyName = "oficina_id";
            this.idOficina.HeaderText = "idOficina";
            this.idOficina.Name = "idOficina";
            this.idOficina.ReadOnly = true;
            this.idOficina.Visible = false;
            // 
            // TributoDescripcion
            // 
            this.TributoDescripcion.DataPropertyName = "TributoDescripcion";
            this.TributoDescripcion.HeaderText = "CONCEPTO";
            this.TributoDescripcion.Name = "TributoDescripcion";
            this.TributoDescripcion.ReadOnly = true;
            this.TributoDescripcion.Width = 250;
            // 
            // abono
            // 
            this.abono.DataPropertyName = "abono";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.abono.DefaultCellStyle = dataGridViewCellStyle2;
            this.abono.HeaderText = "ABONO";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            this.abono.Width = 120;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.cargo.DefaultCellStyle = dataGridViewCellStyle3;
            this.cargo.HeaderText = "CARGO";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 120;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Saldo.HeaderText = "SALDO";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 120;
            // 
            // Cobrado
            // 
            this.Cobrado.DataPropertyName = "Cobrado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Cobrado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cobrado.HeaderText = "COBRADO";
            this.Cobrado.Name = "Cobrado";
            this.Cobrado.ReadOnly = true;
            this.Cobrado.Width = 120;
            // 
            // Morosidad
            // 
            this.Morosidad.DataPropertyName = "Morosidad";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Morosidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Morosidad.HeaderText = "MOROSIDAD";
            this.Morosidad.Name = "Morosidad";
            this.Morosidad.ReadOnly = true;
            this.Morosidad.Visible = false;
            this.Morosidad.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta:";
            // 
            // comboBusquedaMesHasta
            // 
            this.comboBusquedaMesHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaMesHasta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaMesHasta.FormattingEnabled = true;
            this.comboBusquedaMesHasta.Location = new System.Drawing.Point(484, 25);
            this.comboBusquedaMesHasta.Name = "comboBusquedaMesHasta";
            this.comboBusquedaMesHasta.Size = new System.Drawing.Size(134, 21);
            this.comboBusquedaMesHasta.TabIndex = 11;
            // 
            // Frm_FacturadoCobrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 296);
            this.Controls.Add(this.dgvFacturadoCobrado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_FacturadoCobrado";
            this.Text = "Listado Facturado Cobrado";
            this.Load += new System.EventHandler(this.Frm_FacturadoCobrado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturadoCobrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFacturadoCobrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonGenerarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonListar;
        private System.Windows.Forms.ComboBox comboBusquedaMes;
        private System.Windows.Forms.ComboBox comboBusquedaPeriodo;
        private System.Windows.Forms.ComboBox comboBusquedaOficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn TributoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morosidad;
        private System.Windows.Forms.ComboBox comboBusquedaMesHasta;
        private System.Windows.Forms.Label label4;
    }
}