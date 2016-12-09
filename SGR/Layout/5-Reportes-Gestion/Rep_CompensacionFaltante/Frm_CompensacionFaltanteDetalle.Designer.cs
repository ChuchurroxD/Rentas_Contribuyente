namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_CompensacionFaltante
{
    partial class Frm_CompensacionFaltanteDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContribuyente = new System.Windows.Forms.TextBox();
            this.botonGenerarReporte = new System.Windows.Forms.Button();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgCompensacionFaltante = new System.Windows.Forms.DataGridView();
            this.compensacionFaltante_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributos_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trib_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoFaltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompensacionFaltante)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtContribuyente);
            this.groupBox1.Controls.Add(this.botonGenerarReporte);
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Contribuyente: ";
            // 
            // txtContribuyente
            // 
            this.txtContribuyente.Location = new System.Drawing.Point(431, 31);
            this.txtContribuyente.Name = "txtContribuyente";
            this.txtContribuyente.Size = new System.Drawing.Size(222, 20);
            this.txtContribuyente.TabIndex = 13;
            this.txtContribuyente.TextChanged += new System.EventHandler(this.txtContribuyente_TextChanged);
            // 
            // botonGenerarReporte
            // 
            this.botonGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarReporte.Location = new System.Drawing.Point(687, 17);
            this.botonGenerarReporte.Name = "botonGenerarReporte";
            this.botonGenerarReporte.Size = new System.Drawing.Size(160, 44);
            this.botonGenerarReporte.TabIndex = 12;
            this.botonGenerarReporte.Text = "Generar Reporte";
            this.botonGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarReporte.UseVisualStyleBackColor = true;
            this.botonGenerarReporte.Click += new System.EventHandler(this.botonGenerarReporte_Click);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(148, 30);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(136, 21);
            this.cboPeriodo.TabIndex = 10;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Periodo:";
            // 
            // dgCompensacionFaltante
            // 
            this.dgCompensacionFaltante.AllowUserToAddRows = false;
            this.dgCompensacionFaltante.AllowUserToDeleteRows = false;
            this.dgCompensacionFaltante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCompensacionFaltante.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompensacionFaltante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCompensacionFaltante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompensacionFaltante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compensacionFaltante_id,
            this.anio,
            this.mes,
            this.persona_id,
            this.razon_social,
            this.predio_id,
            this.tributos_id,
            this.trib_descripcion,
            this.observacion,
            this.expediente,
            this.montoFaltante});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCompensacionFaltante.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgCompensacionFaltante.EnableHeadersVisualStyles = false;
            this.dgCompensacionFaltante.Location = new System.Drawing.Point(12, 106);
            this.dgCompensacionFaltante.MultiSelect = false;
            this.dgCompensacionFaltante.Name = "dgCompensacionFaltante";
            this.dgCompensacionFaltante.ReadOnly = true;
            this.dgCompensacionFaltante.RowHeadersVisible = false;
            this.dgCompensacionFaltante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCompensacionFaltante.Size = new System.Drawing.Size(1016, 341);
            this.dgCompensacionFaltante.TabIndex = 2;
            // 
            // compensacionFaltante_id
            // 
            this.compensacionFaltante_id.DataPropertyName = "compensacionFaltante_id";
            this.compensacionFaltante_id.HeaderText = "Compensacion Faltante ID";
            this.compensacionFaltante_id.Name = "compensacionFaltante_id";
            this.compensacionFaltante_id.ReadOnly = true;
            this.compensacionFaltante_id.Visible = false;
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
            // persona_id
            // 
            this.persona_id.DataPropertyName = "persona_id";
            this.persona_id.HeaderText = "Persona ID";
            this.persona_id.Name = "persona_id";
            this.persona_id.ReadOnly = true;
            this.persona_id.Visible = false;
            // 
            // razon_social
            // 
            this.razon_social.DataPropertyName = "razon_social";
            this.razon_social.HeaderText = "Razon Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 200;
            // 
            // predio_id
            // 
            this.predio_id.DataPropertyName = "predio_id";
            this.predio_id.HeaderText = "Predio ID";
            this.predio_id.Name = "predio_id";
            this.predio_id.ReadOnly = true;
            // 
            // tributos_id
            // 
            this.tributos_id.DataPropertyName = "tributos_id";
            this.tributos_id.HeaderText = "Tributos ID";
            this.tributos_id.Name = "tributos_id";
            this.tributos_id.ReadOnly = true;
            this.tributos_id.Visible = false;
            // 
            // trib_descripcion
            // 
            this.trib_descripcion.DataPropertyName = "trib_descripcion";
            this.trib_descripcion.HeaderText = "Tributo";
            this.trib_descripcion.Name = "trib_descripcion";
            this.trib_descripcion.ReadOnly = true;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Observación ";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Width = 200;
            // 
            // expediente
            // 
            this.expediente.DataPropertyName = "expediente";
            this.expediente.HeaderText = "Expediente";
            this.expediente.Name = "expediente";
            this.expediente.ReadOnly = true;
            this.expediente.Width = 200;
            // 
            // montoFaltante
            // 
            this.montoFaltante.DataPropertyName = "montoFaltante";
            this.montoFaltante.HeaderText = "Monto Faltante";
            this.montoFaltante.Name = "montoFaltante";
            this.montoFaltante.ReadOnly = true;
            this.montoFaltante.Width = 70;
            // 
            // Frm_CompensacionFaltanteDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 470);
            this.Controls.Add(this.dgCompensacionFaltante);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_CompensacionFaltanteDetalle";
            this.Text = "Compensacion Faltante";
            this.Load += new System.EventHandler(this.Frm_CompensacionFaltanteDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompensacionFaltante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgCompensacionFaltante;
        private System.Windows.Forms.Button botonGenerarReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn compensacionFaltante_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributos_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trib_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoFaltante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContribuyente;
    }
}