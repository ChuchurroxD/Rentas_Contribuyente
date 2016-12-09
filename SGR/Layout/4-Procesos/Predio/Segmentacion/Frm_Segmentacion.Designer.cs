namespace SGR.WinApp.Layout._4_Procesos.Predio.Segmentacion
{
    partial class Frm_Segmentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Segmentacion));
            this.dgvContribuyentePredio = new System.Windows.Forms.DataGridView();
            this.segmentacion_contribuyente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seg_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolnuevoContribuyentePredio = new System.Windows.Forms.ToolStripButton();
            this.tooleditarContribuyentePredio = new System.Windows.Forms.ToolStripButton();
            this.toolSegmentar = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtAbono = new System.Windows.Forms.RadioButton();
            this.rbtCargo = new System.Windows.Forms.RadioButton();
            this.rbtSaldo = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentePredio)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContribuyentePredio
            // 
            this.dgvContribuyentePredio.AllowUserToAddRows = false;
            this.dgvContribuyentePredio.AllowUserToDeleteRows = false;
            this.dgvContribuyentePredio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContribuyentePredio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContribuyentePredio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContribuyentePredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContribuyentePredio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.segmentacion_contribuyente_id,
            this.nombrecompleto,
            this.periodo_id,
            this.monto,
            this.monto_inicio,
            this.monto_fin,
            this.seg_descripcion,
            this.segmentacion_id,
            this.persona_id,
            this.cEstado,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContribuyentePredio.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvContribuyentePredio.EnableHeadersVisualStyles = false;
            this.dgvContribuyentePredio.Location = new System.Drawing.Point(11, 80);
            this.dgvContribuyentePredio.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContribuyentePredio.MultiSelect = false;
            this.dgvContribuyentePredio.Name = "dgvContribuyentePredio";
            this.dgvContribuyentePredio.ReadOnly = true;
            this.dgvContribuyentePredio.RowHeadersVisible = false;
            this.dgvContribuyentePredio.RowTemplate.Height = 24;
            this.dgvContribuyentePredio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContribuyentePredio.Size = new System.Drawing.Size(786, 378);
            this.dgvContribuyentePredio.TabIndex = 14;
            this.dgvContribuyentePredio.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContribuyentePredio_CellContentDoubleClick);
            this.dgvContribuyentePredio.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContribuyentePredio_ColumnHeaderMouseClick);
            // 
            // segmentacion_contribuyente_id
            // 
            this.segmentacion_contribuyente_id.DataPropertyName = "segmentacion_contribuyente_id";
            this.segmentacion_contribuyente_id.HeaderText = "Código";
            this.segmentacion_contribuyente_id.Name = "segmentacion_contribuyente_id";
            this.segmentacion_contribuyente_id.ReadOnly = true;
            this.segmentacion_contribuyente_id.Visible = false;
            this.segmentacion_contribuyente_id.Width = 60;
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.DataPropertyName = "nombrecompleto";
            this.nombrecompleto.HeaderText = "Nombre Completo";
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.ReadOnly = true;
            this.nombrecompleto.Width = 300;
            // 
            // periodo_id
            // 
            this.periodo_id.DataPropertyName = "periodo_id";
            this.periodo_id.HeaderText = "Periodo";
            this.periodo_id.Name = "periodo_id";
            this.periodo_id.ReadOnly = true;
            this.periodo_id.Visible = false;
            this.periodo_id.Width = 70;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // monto_inicio
            // 
            this.monto_inicio.DataPropertyName = "monto_inicio";
            this.monto_inicio.HeaderText = "Monto Inicio";
            this.monto_inicio.Name = "monto_inicio";
            this.monto_inicio.ReadOnly = true;
            this.monto_inicio.Width = 120;
            // 
            // monto_fin
            // 
            this.monto_fin.DataPropertyName = "monto_fin";
            this.monto_fin.HeaderText = "Monto Fin";
            this.monto_fin.Name = "monto_fin";
            this.monto_fin.ReadOnly = true;
            this.monto_fin.Width = 120;
            // 
            // seg_descripcion
            // 
            this.seg_descripcion.DataPropertyName = "seg_descripcion";
            this.seg_descripcion.HeaderText = "Segmentacion";
            this.seg_descripcion.Name = "seg_descripcion";
            this.seg_descripcion.ReadOnly = true;
            this.seg_descripcion.Visible = false;
            this.seg_descripcion.Width = 200;
            // 
            // segmentacion_id
            // 
            this.segmentacion_id.DataPropertyName = "segmentacion_id";
            this.segmentacion_id.HeaderText = "segmentacion_id";
            this.segmentacion_id.Name = "segmentacion_id";
            this.segmentacion_id.ReadOnly = true;
            this.segmentacion_id.Visible = false;
            this.segmentacion_id.Width = 60;
            // 
            // persona_id
            // 
            this.persona_id.DataPropertyName = "persona_id";
            this.persona_id.HeaderText = "persona_id";
            this.persona_id.Name = "persona_id";
            this.persona_id.ReadOnly = true;
            this.persona_id.Visible = false;
            // 
            // cEstado
            // 
            this.cEstado.DataPropertyName = "Estado";
            this.cEstado.HeaderText = "Estado";
            this.cEstado.Name = "cEstado";
            this.cEstado.ReadOnly = true;
            this.cEstado.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "registro_user_add";
            this.dataGridViewTextBoxColumn10.HeaderText = "registro_user_add";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "registro_fecha_add";
            this.dataGridViewTextBoxColumn11.HeaderText = "registro_fecha_add";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "registro_pc_add";
            this.dataGridViewTextBoxColumn12.HeaderText = "registro_pc_add";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "registro_user_update";
            this.dataGridViewTextBoxColumn13.HeaderText = "registro_user_update";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "registro_fecha_update";
            this.dataGridViewTextBoxColumn14.HeaderText = "registro_fecha_update";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "registro_pc_update";
            this.dataGridViewTextBoxColumn15.HeaderText = "registro_pc_update";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevoContribuyentePredio,
            this.tooleditarContribuyentePredio,
            this.toolSegmentar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(808, 27);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // toolnuevoContribuyentePredio
            // 
            this.toolnuevoContribuyentePredio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolnuevoContribuyentePredio.Image = ((System.Drawing.Image)(resources.GetObject("toolnuevoContribuyentePredio.Image")));
            this.toolnuevoContribuyentePredio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolnuevoContribuyentePredio.Name = "toolnuevoContribuyentePredio";
            this.toolnuevoContribuyentePredio.Size = new System.Drawing.Size(24, 24);
            this.toolnuevoContribuyentePredio.Text = "Nuevo";
            this.toolnuevoContribuyentePredio.Visible = false;
            this.toolnuevoContribuyentePredio.Click += new System.EventHandler(this.toolnuevoContribuyentePredio_Click);
            // 
            // tooleditarContribuyentePredio
            // 
            this.tooleditarContribuyentePredio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooleditarContribuyentePredio.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.tooleditarContribuyentePredio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooleditarContribuyentePredio.Name = "tooleditarContribuyentePredio";
            this.tooleditarContribuyentePredio.Size = new System.Drawing.Size(24, 24);
            this.tooleditarContribuyentePredio.Text = "Editar";
            this.tooleditarContribuyentePredio.Visible = false;
            this.tooleditarContribuyentePredio.Click += new System.EventHandler(this.tooleditarContribuyentePredio_Click);
            // 
            // toolSegmentar
            // 
            this.toolSegmentar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSegmentar.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.toolSegmentar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSegmentar.Name = "toolSegmentar";
            this.toolSegmentar.Size = new System.Drawing.Size(24, 24);
            this.toolSegmentar.Text = "toolStripButton1";
            this.toolSegmentar.ToolTipText = "Generar Segmentación";
            this.toolSegmentar.Click += new System.EventHandler(this.toolSegmentar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.btnImprimir);
            this.groupBox4.Controls.Add(this.rbtSaldo);
            this.groupBox4.Controls.Add(this.cboPeriodo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.rbtAbono);
            this.groupBox4.Controls.Add(this.rbtCargo);
            this.groupBox4.Location = new System.Drawing.Point(11, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(786, 47);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opcciones de Búsqueda";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.BackColor = System.Drawing.SystemColors.Window;
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(361, 18);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(200, 21);
            this.cboPeriodo.TabIndex = 22;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Periodo:";
            // 
            // rbtAbono
            // 
            this.rbtAbono.AutoSize = true;
            this.rbtAbono.Location = new System.Drawing.Point(158, 22);
            this.rbtAbono.Name = "rbtAbono";
            this.rbtAbono.Size = new System.Drawing.Size(56, 17);
            this.rbtAbono.TabIndex = 20;
            this.rbtAbono.Text = "Abono";
            this.rbtAbono.UseVisualStyleBackColor = true;
            this.rbtAbono.CheckedChanged += new System.EventHandler(this.rbtAbono_CheckedChanged);
            // 
            // rbtCargo
            // 
            this.rbtCargo.AutoSize = true;
            this.rbtCargo.Checked = true;
            this.rbtCargo.Location = new System.Drawing.Point(87, 22);
            this.rbtCargo.Name = "rbtCargo";
            this.rbtCargo.Size = new System.Drawing.Size(53, 17);
            this.rbtCargo.TabIndex = 19;
            this.rbtCargo.TabStop = true;
            this.rbtCargo.Text = "Cargo";
            this.rbtCargo.UseVisualStyleBackColor = true;
            this.rbtCargo.CheckedChanged += new System.EventHandler(this.rbtCargo_CheckedChanged);
            // 
            // rbtSaldo
            // 
            this.rbtSaldo.AutoSize = true;
            this.rbtSaldo.Location = new System.Drawing.Point(231, 22);
            this.rbtSaldo.Name = "rbtSaldo";
            this.rbtSaldo.Size = new System.Drawing.Size(52, 17);
            this.rbtSaldo.TabIndex = 23;
            this.rbtSaldo.TabStop = true;
            this.rbtSaldo.Text = "Saldo";
            this.rbtSaldo.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.Image = global::SGR.WinApp.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(607, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(26, 32);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Frm_Segmentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(808, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvContribuyentePredio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Segmentacion";
            this.Text = "Segmentación de Contribuyente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentePredio)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContribuyentePredio;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolnuevoContribuyentePredio;
        private System.Windows.Forms.ToolStripButton tooleditarContribuyentePredio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripButton toolSegmentar;
        private System.Windows.Forms.RadioButton rbtAbono;
        private System.Windows.Forms.RadioButton rbtCargo;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentacion_contribuyente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn seg_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.RadioButton rbtSaldo;
        private System.Windows.Forms.Button btnImprimir;
    }
}