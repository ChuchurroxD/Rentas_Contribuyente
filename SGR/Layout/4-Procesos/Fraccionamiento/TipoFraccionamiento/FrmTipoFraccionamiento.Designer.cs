namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento
{
    partial class FrmTipoFraccionamiento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TiFr_base_legal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipo_Junta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsysFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoFracc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiFr_tipo_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column122 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12rr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TiFr_base_legal,
            this.xdescripcion,
            this.xTipo_Junta,
            this.xsysFecha,
            this.xusuario,
            this.xestado,
            this.Column1,
            this.Column2,
            this.xTipoFracc,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.TiFr_tipo_f,
            this.Column122,
            this.Column12rr});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(7, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(810, 238);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CambiarPosicion);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // TiFr_base_legal
            // 
            this.TiFr_base_legal.DataPropertyName = "TiFr_base_legal";
            this.TiFr_base_legal.HeaderText = "Base Legal";
            this.TiFr_base_legal.Name = "TiFr_base_legal";
            this.TiFr_base_legal.ReadOnly = true;
            this.TiFr_base_legal.Width = 300;
            // 
            // xdescripcion
            // 
            this.xdescripcion.DataPropertyName = "TiFr_fecha_inicio";
            this.xdescripcion.HeaderText = "Fecha Inicio";
            this.xdescripcion.Name = "xdescripcion";
            this.xdescripcion.ReadOnly = true;
            // 
            // xTipo_Junta
            // 
            this.xTipo_Junta.DataPropertyName = "TiFr_fecha_fin";
            this.xTipo_Junta.HeaderText = "Fecha Fin";
            this.xTipo_Junta.Name = "xTipo_Junta";
            this.xTipo_Junta.ReadOnly = true;
            // 
            // xsysFecha
            // 
            this.xsysFecha.DataPropertyName = "TiFr_max_cuotas";
            this.xsysFecha.HeaderText = "Max. Cuotas";
            this.xsysFecha.Name = "xsysFecha";
            this.xsysFecha.ReadOnly = true;
            // 
            // xusuario
            // 
            this.xusuario.DataPropertyName = "TiFr_modalidadDesc";
            this.xusuario.HeaderText = "Modalidad";
            this.xusuario.Name = "xusuario";
            this.xusuario.ReadOnly = true;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "TiFr_estado";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            this.xestado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xestado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TiFr_anio_fin";
            this.Column1.HeaderText = "Anio Fin";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TiFr_anio_inicio";
            this.Column2.HeaderText = "Anio Inicio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // xTipoFracc
            // 
            this.xTipoFracc.DataPropertyName = "TiFr_tipo_fraccionamiento_ID";
            this.xTipoFracc.HeaderText = "Tipo Fraccionamiento";
            this.xTipoFracc.Name = "xTipoFracc";
            this.xTipoFracc.ReadOnly = true;
            this.xTipoFracc.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TiFr_cuota_inicial";
            this.Column4.HeaderText = "Cuota Inicial";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TiFr_porce_inicial";
            this.Column5.HeaderText = "Porcentaje Ini";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TiFr_cuota_minima";
            this.Column6.HeaderText = "Cuota Minima";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TiFr_interes_moratorio";
            this.Column7.HeaderText = "Interes Moratorio";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TiFr_interes_compensa";
            this.Column8.HeaderText = "Interes Compensa";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TiFr_descuento";
            this.Column9.HeaderText = "descuento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TiFr_monto_derecho";
            this.Column10.HeaderText = "monto derecho";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TiFr_modalidad";
            this.Column11.HeaderText = "Modalidad";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // TiFr_tipo_f
            // 
            this.TiFr_tipo_f.DataPropertyName = "TiFr_max_uit";
            this.TiFr_tipo_f.HeaderText = "Max UIT";
            this.TiFr_tipo_f.Name = "TiFr_tipo_f";
            this.TiFr_tipo_f.ReadOnly = true;
            this.TiFr_tipo_f.Visible = false;
            // 
            // Column122
            // 
            this.Column122.DataPropertyName = "TiFr_tipo_fDesc";
            this.Column122.HeaderText = "Tipo F Desc";
            this.Column122.Name = "Column122";
            this.Column122.ReadOnly = true;
            this.Column122.Visible = false;
            // 
            // Column12rr
            // 
            this.Column12rr.DataPropertyName = "TiFr_tipo_f";
            this.Column12rr.HeaderText = "Tipo F";
            this.Column12rr.Name = "Column12rr";
            this.Column12rr.ReadOnly = true;
            this.Column12rr.Visible = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(75, 25);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(277, 20);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(550, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleditar,
            this.tooleliminar,
            this.toolImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolnuevo
            // 
            this.toolnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolnuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolnuevo.Name = "toolnuevo";
            this.toolnuevo.Size = new System.Drawing.Size(24, 24);
            this.toolnuevo.Text = "Nuevo";
            this.toolnuevo.Click += new System.EventHandler(this.toolnuevo_Click);
            // 
            // tooleditar
            // 
            this.tooleditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooleditar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.tooleditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooleditar.Name = "tooleditar";
            this.tooleditar.Size = new System.Drawing.Size(24, 24);
            this.tooleditar.Text = "Editar";
            this.tooleditar.Click += new System.EventHandler(this.tooleditar_Click);
            // 
            // tooleliminar
            // 
            this.tooleliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooleliminar.Image = global::SGR.WinApp.Properties.Resources.delete;
            this.tooleliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooleliminar.Name = "tooleliminar";
            this.tooleliminar.Size = new System.Drawing.Size(24, 24);
            this.tooleliminar.Text = "Eliminar";
            this.tooleliminar.Visible = false;
            this.tooleliminar.Click += new System.EventHandler(this.tooleliminar_Click);
            // 
            // toolImprimir
            // 
            this.toolImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolImprimir.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImprimir.Name = "toolImprimir";
            this.toolImprimir.Size = new System.Drawing.Size(24, 24);
            this.toolImprimir.Text = "Imprimir";
            this.toolImprimir.Click += new System.EventHandler(this.toolImprimir_Click);
            // 
            // FrmTipoFraccionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 343);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoFraccionamiento";
            this.Load += new System.EventHandler(this.FrmFraccionamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiFr_base_legal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipo_Junta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsysFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xusuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoFracc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiFr_tipo_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column122;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12rr;
        private System.Windows.Forms.ToolStripButton toolImprimir;
    }
}