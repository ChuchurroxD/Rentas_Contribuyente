namespace SGR.WinApp.Layout._4_Procesos.Pagos
{
    partial class Frm_PagoCuotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodPago = new System.Windows.Forms.TextBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.xanular = new System.Windows.Forms.DataGridViewImageColumn();
            this.nroRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCopias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajeroCaja_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liquidacion_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fraccionamiento_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otroReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPago_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajeroCaja_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de Voucher:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SGR.WinApp.Properties.Resources.bookmark;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(504, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "VERIFICAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCodPago
            // 
            this.txtCodPago.Location = new System.Drawing.Point(371, 24);
            this.txtCodPago.Name = "txtCodPago";
            this.txtCodPago.Size = new System.Drawing.Size(117, 20);
            this.txtCodPago.TabIndex = 3;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xanular,
            this.nroRecibo,
            this.Pagos_ID,
            this.idPeriodo,
            this.TipoPago,
            this.TasaCambio,
            this.NroCopias,
            this.CajeroCaja_ID,
            this.Persona_ID,
            this.liquidacion_ID,
            this.fraccionamiento_ID,
            this.otroReferencia,
            this.tipoPago_descripcion,
            this.CajeroCaja_nombre,
            this.tipo,
            this.hora,
            this.estado,
            this.FechaPago,
            this.xpagante,
            this.MontoTotal,
            this.voucher});
            this.dgvPagos.EnableHeadersVisualStyles = false;
            this.dgvPagos.Location = new System.Drawing.Point(12, 73);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(824, 247);
            this.dgvPagos.TabIndex = 9;
            this.dgvPagos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellContentDoubleClick);
            // 
            // xanular
            // 
            this.xanular.HeaderText = "Anular";
            this.xanular.Image = global::SGR.WinApp.Properties.Resources.anular;
            this.xanular.Name = "xanular";
            this.xanular.ReadOnly = true;
            this.xanular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xanular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xanular.Width = 70;
            // 
            // nroRecibo
            // 
            this.nroRecibo.DataPropertyName = "nroRecibo";
            this.nroRecibo.HeaderText = "nroRecibo";
            this.nroRecibo.Name = "nroRecibo";
            this.nroRecibo.ReadOnly = true;
            this.nroRecibo.Visible = false;
            // 
            // Pagos_ID
            // 
            this.Pagos_ID.DataPropertyName = "Pagos_ID";
            this.Pagos_ID.HeaderText = "Pagos_ID";
            this.Pagos_ID.Name = "Pagos_ID";
            this.Pagos_ID.ReadOnly = true;
            this.Pagos_ID.Visible = false;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "idPeriodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.ReadOnly = true;
            this.idPeriodo.Visible = false;
            // 
            // TipoPago
            // 
            this.TipoPago.DataPropertyName = "TipoPago";
            this.TipoPago.HeaderText = "TipoPago";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.ReadOnly = true;
            this.TipoPago.Visible = false;
            // 
            // TasaCambio
            // 
            this.TasaCambio.DataPropertyName = "TasaCambio";
            this.TasaCambio.HeaderText = "TasaCambio";
            this.TasaCambio.Name = "TasaCambio";
            this.TasaCambio.ReadOnly = true;
            this.TasaCambio.Visible = false;
            // 
            // NroCopias
            // 
            this.NroCopias.DataPropertyName = "NroCopias";
            this.NroCopias.HeaderText = "NroCopias";
            this.NroCopias.Name = "NroCopias";
            this.NroCopias.ReadOnly = true;
            this.NroCopias.Visible = false;
            // 
            // CajeroCaja_ID
            // 
            this.CajeroCaja_ID.DataPropertyName = "CajeroCaja_ID";
            this.CajeroCaja_ID.HeaderText = "CajeroCaja_ID";
            this.CajeroCaja_ID.Name = "CajeroCaja_ID";
            this.CajeroCaja_ID.ReadOnly = true;
            this.CajeroCaja_ID.Visible = false;
            // 
            // Persona_ID
            // 
            this.Persona_ID.DataPropertyName = "Persona_ID";
            this.Persona_ID.HeaderText = "Persona_ID";
            this.Persona_ID.Name = "Persona_ID";
            this.Persona_ID.ReadOnly = true;
            this.Persona_ID.Visible = false;
            // 
            // liquidacion_ID
            // 
            this.liquidacion_ID.DataPropertyName = "liquidacion_ID";
            this.liquidacion_ID.HeaderText = "liquidacion_ID";
            this.liquidacion_ID.Name = "liquidacion_ID";
            this.liquidacion_ID.ReadOnly = true;
            this.liquidacion_ID.Visible = false;
            // 
            // fraccionamiento_ID
            // 
            this.fraccionamiento_ID.DataPropertyName = "fraccionamiento_ID";
            this.fraccionamiento_ID.HeaderText = "fraccionamiento_ID";
            this.fraccionamiento_ID.Name = "fraccionamiento_ID";
            this.fraccionamiento_ID.ReadOnly = true;
            this.fraccionamiento_ID.Visible = false;
            // 
            // otroReferencia
            // 
            this.otroReferencia.DataPropertyName = "otroReferencia";
            this.otroReferencia.HeaderText = "otroReferencia";
            this.otroReferencia.Name = "otroReferencia";
            this.otroReferencia.ReadOnly = true;
            this.otroReferencia.Visible = false;
            // 
            // tipoPago_descripcion
            // 
            this.tipoPago_descripcion.DataPropertyName = "tipoPago_descripcion";
            this.tipoPago_descripcion.HeaderText = "tipoPago_descripcion";
            this.tipoPago_descripcion.Name = "tipoPago_descripcion";
            this.tipoPago_descripcion.ReadOnly = true;
            this.tipoPago_descripcion.Visible = false;
            // 
            // CajeroCaja_nombre
            // 
            this.CajeroCaja_nombre.DataPropertyName = "CajeroCaja_nombre";
            this.CajeroCaja_nombre.HeaderText = "CajeroCaja_nombre";
            this.CajeroCaja_nombre.Name = "CajeroCaja_nombre";
            this.CajeroCaja_nombre.ReadOnly = true;
            this.CajeroCaja_nombre.Visible = false;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Width = 200;
            // 
            // xpagante
            // 
            this.xpagante.DataPropertyName = "Pagante";
            this.xpagante.HeaderText = "Pagante";
            this.xpagante.Name = "xpagante";
            this.xpagante.ReadOnly = true;
            this.xpagante.Width = 250;
            // 
            // MontoTotal
            // 
            this.MontoTotal.DataPropertyName = "MontoTotal";
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 150;
            // 
            // voucher
            // 
            this.voucher.DataPropertyName = "recibo_usado";
            this.voucher.HeaderText = "N° Voucher";
            this.voucher.Name = "voucher";
            this.voucher.ReadOnly = true;
            this.voucher.Width = 150;
            // 
            // Frm_PagoCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 332);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.txtCodPago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_PagoCuotas";
            this.Text = "ANULAR PAGO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodPago;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewImageColumn xanular;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCopias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajeroCaja_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn liquidacion_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fraccionamiento_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn otroReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPago_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajeroCaja_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucher;
    }
}