namespace SGR.WinApp.Layout._4_Procesos.Predio.Arbitrio
{
    partial class Frm_ValidacionPredioArbitrio
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
            this.txtBusquedaContribuyente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPeriodoBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvValidacionPredioArbitrio = new System.Windows.Forms.DataGridView();
            this.xNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpredio_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdireccion_completa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnombre_predio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo_inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo_predio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado_predio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcionTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcionTipoInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcionTipoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcionEstadoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidacionPredioArbitrio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtBusquedaContribuyente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboPeriodoBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // txtBusquedaContribuyente
            // 
            this.txtBusquedaContribuyente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaContribuyente.Location = new System.Drawing.Point(571, 25);
            this.txtBusquedaContribuyente.Name = "txtBusquedaContribuyente";
            this.txtBusquedaContribuyente.Size = new System.Drawing.Size(216, 21);
            this.txtBusquedaContribuyente.TabIndex = 3;
            this.txtBusquedaContribuyente.TextChanged += new System.EventHandler(this.txtBusquedaContribuyente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contribuyente:";
            // 
            // comboPeriodoBusqueda
            // 
            this.comboPeriodoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeriodoBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPeriodoBusqueda.FormattingEnabled = true;
            this.comboPeriodoBusqueda.Location = new System.Drawing.Point(309, 25);
            this.comboPeriodoBusqueda.Name = "comboPeriodoBusqueda";
            this.comboPeriodoBusqueda.Size = new System.Drawing.Size(123, 21);
            this.comboPeriodoBusqueda.TabIndex = 1;
            this.comboPeriodoBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboPeriodoBusqueda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // dgvValidacionPredioArbitrio
            // 
            this.dgvValidacionPredioArbitrio.AllowUserToAddRows = false;
            this.dgvValidacionPredioArbitrio.AllowUserToDeleteRows = false;
            this.dgvValidacionPredioArbitrio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValidacionPredioArbitrio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvValidacionPredioArbitrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValidacionPredioArbitrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xNombreCompleto,
            this.xidPeriodo,
            this.xpredio_ID,
            this.xdireccion_completa,
            this.xnombre_predio,
            this.xtipo_operacion,
            this.xtipo_inmueble,
            this.xtipo_predio,
            this.xestado_predio,
            this.xDescripcionTipoOperacion,
            this.xDescripcionTipoInmueble,
            this.xDescripcionTipoPredio,
            this.xDescripcionEstadoPredio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValidacionPredioArbitrio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvValidacionPredioArbitrio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValidacionPredioArbitrio.EnableHeadersVisualStyles = false;
            this.dgvValidacionPredioArbitrio.Location = new System.Drawing.Point(0, 63);
            this.dgvValidacionPredioArbitrio.MultiSelect = false;
            this.dgvValidacionPredioArbitrio.Name = "dgvValidacionPredioArbitrio";
            this.dgvValidacionPredioArbitrio.ReadOnly = true;
            this.dgvValidacionPredioArbitrio.RowHeadersVisible = false;
            this.dgvValidacionPredioArbitrio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValidacionPredioArbitrio.Size = new System.Drawing.Size(860, 335);
            this.dgvValidacionPredioArbitrio.TabIndex = 1;
            // 
            // xNombreCompleto
            // 
            this.xNombreCompleto.DataPropertyName = "NombreCompleto";
            this.xNombreCompleto.HeaderText = "Contribuyente";
            this.xNombreCompleto.Name = "xNombreCompleto";
            this.xNombreCompleto.ReadOnly = true;
            this.xNombreCompleto.Width = 240;
            // 
            // xidPeriodo
            // 
            this.xidPeriodo.DataPropertyName = "idPeriodo";
            this.xidPeriodo.HeaderText = "idPeriodo";
            this.xidPeriodo.Name = "xidPeriodo";
            this.xidPeriodo.ReadOnly = true;
            this.xidPeriodo.Visible = false;
            // 
            // xpredio_ID
            // 
            this.xpredio_ID.DataPropertyName = "predio_ID";
            this.xpredio_ID.HeaderText = "Codigo Predio";
            this.xpredio_ID.Name = "xpredio_ID";
            this.xpredio_ID.ReadOnly = true;
            this.xpredio_ID.Width = 130;
            // 
            // xdireccion_completa
            // 
            this.xdireccion_completa.DataPropertyName = "direccion_completa";
            this.xdireccion_completa.HeaderText = "Direccion Predio";
            this.xdireccion_completa.Name = "xdireccion_completa";
            this.xdireccion_completa.ReadOnly = true;
            this.xdireccion_completa.Visible = false;
            this.xdireccion_completa.Width = 250;
            // 
            // xnombre_predio
            // 
            this.xnombre_predio.DataPropertyName = "nombre_predio";
            this.xnombre_predio.HeaderText = "Nombre Predio";
            this.xnombre_predio.Name = "xnombre_predio";
            this.xnombre_predio.ReadOnly = true;
            this.xnombre_predio.Width = 250;
            // 
            // xtipo_operacion
            // 
            this.xtipo_operacion.DataPropertyName = "tipo_operacion";
            this.xtipo_operacion.HeaderText = "Codigo tipo_operacion";
            this.xtipo_operacion.Name = "xtipo_operacion";
            this.xtipo_operacion.ReadOnly = true;
            this.xtipo_operacion.Visible = false;
            // 
            // xtipo_inmueble
            // 
            this.xtipo_inmueble.DataPropertyName = "tipo_inmueble";
            this.xtipo_inmueble.HeaderText = "Codigo tipo_inmueble";
            this.xtipo_inmueble.Name = "xtipo_inmueble";
            this.xtipo_inmueble.ReadOnly = true;
            this.xtipo_inmueble.Visible = false;
            // 
            // xtipo_predio
            // 
            this.xtipo_predio.DataPropertyName = "tipo_predio";
            this.xtipo_predio.HeaderText = "Codigo tipo_predio";
            this.xtipo_predio.Name = "xtipo_predio";
            this.xtipo_predio.ReadOnly = true;
            this.xtipo_predio.Visible = false;
            // 
            // xestado_predio
            // 
            this.xestado_predio.DataPropertyName = "estado_predio";
            this.xestado_predio.HeaderText = "Codigo estado_predio ";
            this.xestado_predio.Name = "xestado_predio";
            this.xestado_predio.ReadOnly = true;
            this.xestado_predio.Visible = false;
            // 
            // xDescripcionTipoOperacion
            // 
            this.xDescripcionTipoOperacion.DataPropertyName = "DescripcionTipoOperacion";
            this.xDescripcionTipoOperacion.HeaderText = "Tipo Operación";
            this.xDescripcionTipoOperacion.Name = "xDescripcionTipoOperacion";
            this.xDescripcionTipoOperacion.ReadOnly = true;
            // 
            // xDescripcionTipoInmueble
            // 
            this.xDescripcionTipoInmueble.DataPropertyName = "DescripcionTipoInmueble";
            this.xDescripcionTipoInmueble.HeaderText = "Tipo Inmueble";
            this.xDescripcionTipoInmueble.Name = "xDescripcionTipoInmueble";
            this.xDescripcionTipoInmueble.ReadOnly = true;
            // 
            // xDescripcionTipoPredio
            // 
            this.xDescripcionTipoPredio.DataPropertyName = "DescripcionTipoPredio";
            this.xDescripcionTipoPredio.HeaderText = "Tipo Predio";
            this.xDescripcionTipoPredio.Name = "xDescripcionTipoPredio";
            this.xDescripcionTipoPredio.ReadOnly = true;
            this.xDescripcionTipoPredio.Width = 120;
            // 
            // xDescripcionEstadoPredio
            // 
            this.xDescripcionEstadoPredio.DataPropertyName = "DescripcionEstadoPredio";
            this.xDescripcionEstadoPredio.HeaderText = "Estado Predio";
            this.xDescripcionEstadoPredio.Name = "xDescripcionEstadoPredio";
            this.xDescripcionEstadoPredio.ReadOnly = true;
            this.xDescripcionEstadoPredio.Width = 145;
            // 
            // Frm_ValidacionPredioArbitrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 398);
            this.Controls.Add(this.dgvValidacionPredioArbitrio);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ValidacionPredioArbitrio";
            this.Text = "Listado Validacion Predio";
            this.Load += new System.EventHandler(this.Frm_ValidacionPredioArbitrio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidacionPredioArbitrio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboPeriodoBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvValidacionPredioArbitrio;
        private System.Windows.Forms.TextBox txtBusquedaContribuyente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpredio_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdireccion_completa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnombre_predio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo_inmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo_predio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xestado_predio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcionTipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcionTipoInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcionTipoPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcionEstadoPredio;
    }
}