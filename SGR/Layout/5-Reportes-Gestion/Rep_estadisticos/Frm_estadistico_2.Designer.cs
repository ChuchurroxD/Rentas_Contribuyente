namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_estadisticos
{
    partial class Frm_estadistico_2
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
            this.cboMesFinal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMesInicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReporte1 = new System.Windows.Forms.DataGridView();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbonoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CobradoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MorosidadPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargoArbitrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbonoArbitrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoArbitrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CobradoArbitrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MorosidadArbitrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboMesFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMesInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Controls.Add(this.btnGenerarReporte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Búsqueda";
            // 
            // cboMesFinal
            // 
            this.cboMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesFinal.FormattingEnabled = true;
            this.cboMesFinal.Location = new System.Drawing.Point(585, 46);
            this.cboMesFinal.Name = "cboMesFinal";
            this.cboMesFinal.Size = new System.Drawing.Size(121, 21);
            this.cboMesFinal.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mes Final";
            // 
            // cboMesInicio
            // 
            this.cboMesInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesInicio.FormattingEnabled = true;
            this.cboMesInicio.Location = new System.Drawing.Point(335, 46);
            this.cboMesInicio.Name = "cboMesInicio";
            this.cboMesInicio.Size = new System.Drawing.Size(121, 21);
            this.cboMesInicio.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mes Inicial";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(71, 45);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo.TabIndex = 33;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.btnGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReporte.Location = new System.Drawing.Point(378, 96);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(159, 31);
            this.btnGenerarReporte.TabIndex = 11;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // dgvReporte1
            // 
            this.dgvReporte1.AllowUserToAddRows = false;
            this.dgvReporte1.AllowUserToDeleteRows = false;
            this.dgvReporte1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporte1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporte1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mes,
            this.nro,
            this.CargoPredio,
            this.AbonoPredio,
            this.SaldoPredio,
            this.CobradoPredio,
            this.MorosidadPredio,
            this.CargoArbitrio,
            this.AbonoArbitrio,
            this.SaldoArbitrio,
            this.CobradoArbitrio,
            this.MorosidadArbitrio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporte1.EnableHeadersVisualStyles = false;
            this.dgvReporte1.Location = new System.Drawing.Point(12, 163);
            this.dgvReporte1.Name = "dgvReporte1";
            this.dgvReporte1.ReadOnly = true;
            this.dgvReporte1.RowHeadersVisible = false;
            this.dgvReporte1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte1.Size = new System.Drawing.Size(738, 230);
            this.dgvReporte1.TabIndex = 5;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // nro
            // 
            this.nro.DataPropertyName = "nro";
            this.nro.HeaderText = "nro";
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            this.nro.Visible = false;
            // 
            // CargoPredio
            // 
            this.CargoPredio.DataPropertyName = "CargoPredio";
            this.CargoPredio.HeaderText = "Cargo Predio";
            this.CargoPredio.Name = "CargoPredio";
            this.CargoPredio.ReadOnly = true;
            // 
            // AbonoPredio
            // 
            this.AbonoPredio.DataPropertyName = "AbonoPredio";
            this.AbonoPredio.HeaderText = "Abono Predio";
            this.AbonoPredio.Name = "AbonoPredio";
            this.AbonoPredio.ReadOnly = true;
            // 
            // SaldoPredio
            // 
            this.SaldoPredio.DataPropertyName = "SaldoPredio";
            this.SaldoPredio.HeaderText = "Saldo Predio";
            this.SaldoPredio.Name = "SaldoPredio";
            this.SaldoPredio.ReadOnly = true;
            // 
            // CobradoPredio
            // 
            this.CobradoPredio.DataPropertyName = "CobradoPredio";
            this.CobradoPredio.HeaderText = "% Cobrado";
            this.CobradoPredio.Name = "CobradoPredio";
            this.CobradoPredio.ReadOnly = true;
            // 
            // MorosidadPredio
            // 
            this.MorosidadPredio.DataPropertyName = "MorosidadPredio";
            this.MorosidadPredio.HeaderText = "% Morosidad";
            this.MorosidadPredio.Name = "MorosidadPredio";
            this.MorosidadPredio.ReadOnly = true;
            // 
            // CargoArbitrio
            // 
            this.CargoArbitrio.DataPropertyName = "CargoArbitrio";
            this.CargoArbitrio.HeaderText = "Cargo Arbitrio";
            this.CargoArbitrio.Name = "CargoArbitrio";
            this.CargoArbitrio.ReadOnly = true;
            // 
            // AbonoArbitrio
            // 
            this.AbonoArbitrio.DataPropertyName = "AbonoArbitrio";
            this.AbonoArbitrio.HeaderText = "Abono Arbitrio";
            this.AbonoArbitrio.Name = "AbonoArbitrio";
            this.AbonoArbitrio.ReadOnly = true;
            // 
            // SaldoArbitrio
            // 
            this.SaldoArbitrio.DataPropertyName = "SaldoArbitrio";
            this.SaldoArbitrio.HeaderText = "Saldo Arbitrio";
            this.SaldoArbitrio.Name = "SaldoArbitrio";
            this.SaldoArbitrio.ReadOnly = true;
            // 
            // CobradoArbitrio
            // 
            this.CobradoArbitrio.DataPropertyName = "CobradoArbitrio";
            this.CobradoArbitrio.HeaderText = "% Cobrado";
            this.CobradoArbitrio.Name = "CobradoArbitrio";
            this.CobradoArbitrio.ReadOnly = true;
            // 
            // MorosidadArbitrio
            // 
            this.MorosidadArbitrio.DataPropertyName = "MorosidadArbitrio";
            this.MorosidadArbitrio.HeaderText = "% Morosidad";
            this.MorosidadArbitrio.Name = "MorosidadArbitrio";
            this.MorosidadArbitrio.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Image = global::SGR.WinApp.Properties.Resources.search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(266, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 38;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_estadistico_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 413);
            this.Controls.Add(this.dgvReporte1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_estadistico_2";
            this.Text = "Reporte Estadistico 2";
            this.Load += new System.EventHandler(this.Frm_estadistico_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMesFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMesInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReporte1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargoPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbonoPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CobradoPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MorosidadPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargoArbitrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbonoArbitrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoArbitrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CobradoArbitrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MorosidadArbitrio;
        private System.Windows.Forms.Button button1;
    }
}