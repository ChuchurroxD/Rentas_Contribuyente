namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo
{
    partial class Frm_CalculoIndividulPredio
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
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContribuyente = new System.Windows.Forms.Label();
            this.lblTributo = new System.Windows.Forms.Label();
            this.dgvCtaCorriente = new System.Windows.Forms.DataGridView();
            this.cuenta_corriente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcelErrores = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCorriente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErrores
            // 
            this.dgvErrores.AllowUserToAddRows = false;
            this.dgvErrores.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErrores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvErrores.EnableHeadersVisualStyles = false;
            this.dgvErrores.Location = new System.Drawing.Point(24, 54);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.RowHeadersVisible = false;
            this.dgvErrores.Size = new System.Drawing.Size(704, 103);
            this.dgvErrores.TabIndex = 10;
            // 
            // num
            // 
            this.num.HeaderText = "Nª";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 30;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción de Error";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 650;
            // 
            // lblContribuyente
            // 
            this.lblContribuyente.AutoSize = true;
            this.lblContribuyente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContribuyente.Location = new System.Drawing.Point(351, 18);
            this.lblContribuyente.Name = "lblContribuyente";
            this.lblContribuyente.Size = new System.Drawing.Size(41, 13);
            this.lblContribuyente.TabIndex = 12;
            this.lblContribuyente.Text = "label1";
            // 
            // lblTributo
            // 
            this.lblTributo.AutoSize = true;
            this.lblTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTributo.Location = new System.Drawing.Point(588, 18);
            this.lblTributo.Name = "lblTributo";
            this.lblTributo.Size = new System.Drawing.Size(60, 13);
            this.lblTributo.TabIndex = 13;
            this.lblTributo.Text = "lblTributo";
            // 
            // dgvCtaCorriente
            // 
            this.dgvCtaCorriente.AllowUserToAddRows = false;
            this.dgvCtaCorriente.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaCorriente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCtaCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaCorriente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta_corriente_ID,
            this.nombre,
            this.tributo,
            this.anio,
            this.mes,
            this.fecha_vence,
            this.cargo,
            this.abono,
            this.estado,
            this.predioId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCtaCorriente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCtaCorriente.EnableHeadersVisualStyles = false;
            this.dgvCtaCorriente.Location = new System.Drawing.Point(24, 176);
            this.dgvCtaCorriente.Name = "dgvCtaCorriente";
            this.dgvCtaCorriente.Size = new System.Drawing.Size(704, 176);
            this.dgvCtaCorriente.TabIndex = 14;
            this.dgvCtaCorriente.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCtaCorriente_RowPostPaint);
            // 
            // cuenta_corriente_ID
            // 
            this.cuenta_corriente_ID.DataPropertyName = "cuenta_corriente_ID";
            this.cuenta_corriente_ID.HeaderText = "Nª";
            this.cuenta_corriente_ID.Name = "cuenta_corriente_ID";
            this.cuenta_corriente_ID.ReadOnly = true;
            this.cuenta_corriente_ID.Width = 30;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // tributo
            // 
            this.tributo.DataPropertyName = "tributo";
            this.tributo.HeaderText = "Tributo";
            this.tributo.Name = "tributo";
            this.tributo.ReadOnly = true;
            this.tributo.Width = 150;
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
            // fecha_vence
            // 
            this.fecha_vence.DataPropertyName = "fecha_vence";
            this.fecha_vence.HeaderText = "Fecha_vence";
            this.fecha_vence.Name = "fecha_vence";
            this.fecha_vence.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            // 
            // abono
            // 
            this.abono.DataPropertyName = "abono";
            this.abono.HeaderText = "Abono";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // predioId
            // 
            this.predioId.DataPropertyName = "predioId";
            this.predioId.HeaderText = "PredioId";
            this.predioId.Name = "predioId";
            this.predioId.ReadOnly = true;
            // 
            // btnExcelErrores
            // 
            this.btnExcelErrores.Enabled = false;
            this.btnExcelErrores.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.btnExcelErrores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelErrores.Location = new System.Drawing.Point(134, 7);
            this.btnExcelErrores.Name = "btnExcelErrores";
            this.btnExcelErrores.Size = new System.Drawing.Size(106, 36);
            this.btnExcelErrores.TabIndex = 16;
            this.btnExcelErrores.Text = "ERRORES";
            this.btnExcelErrores.UseVisualStyleBackColor = true;
            this.btnExcelErrores.Click += new System.EventHandler(this.btnExcelErrores_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Image = global::SGR.WinApp.Properties.Resources.ireport;
            this.btnVerificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificar.Location = new System.Drawing.Point(12, 6);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(116, 37);
            this.btnVerificar.TabIndex = 15;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Image = global::SGR.WinApp.Properties.Resources.coins;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(246, 7);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 36);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Frm_CalculoIndividulPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(751, 364);
            this.Controls.Add(this.btnExcelErrores);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.dgvCtaCorriente);
            this.Controls.Add(this.lblTributo);
            this.Controls.Add(this.lblContribuyente);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvErrores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CalculoIndividulPredio";
            this.Text = "Càlculo Individual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCorriente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblContribuyente;
        private System.Windows.Forms.Label lblTributo;
        private System.Windows.Forms.DataGridView dgvCtaCorriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta_corriente_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn predioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnExcelErrores;
    }
}