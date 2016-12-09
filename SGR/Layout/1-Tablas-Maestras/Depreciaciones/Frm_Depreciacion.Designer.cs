namespace SGR.WinApp.Layout._1_Tablas_Maestras.Depreciaciones
{
    partial class Frm_Depreciacion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.toolCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_clasificacion = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xdepreciacion_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclasificacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xantiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xantiguedad_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmaterial_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestadoPiso_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestadoPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muyBueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xporcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xanti_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xanti_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleditar,
            this.toolCancelar,
            this.toolImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 27);
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
            // toolCancelar
            // 
            this.toolCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelar.Image = global::SGR.WinApp.Properties.Resources.back_arrow;
            this.toolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancelar.Name = "toolCancelar";
            this.toolCancelar.Size = new System.Drawing.Size(24, 24);
            this.toolCancelar.Text = "Cancelar";
            this.toolCancelar.Click += new System.EventHandler(this.toolcancelar_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.chkTodos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_clasificacion);
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(962, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Opciones de Búsqueda";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(798, 28);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(145, 17);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.Text = "Todas las Clasificaciones";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clasificación";
            // 
            // cbo_clasificacion
            // 
            this.cbo_clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_clasificacion.FormattingEnabled = true;
            this.cbo_clasificacion.Location = new System.Drawing.Point(317, 24);
            this.cbo_clasificacion.Name = "cbo_clasificacion";
            this.cbo_clasificacion.Size = new System.Drawing.Size(415, 21);
            this.cbo_clasificacion.TabIndex = 3;
            this.cbo_clasificacion.SelectedIndexChanged += new System.EventHandler(this.cbo_clasificacion_SelectedIndexChanged);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(54, 24);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(138, 21);
            this.cboPeriodo.TabIndex = 2;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xdepreciacion_ID,
            this.xanio,
            this.xclasificacion_id,
            this.xclasificacion,
            this.xantiguedad,
            this.xantiguedad_descripcion,
            this.xmaterial_id,
            this.xmaterial,
            this.xestadoPiso_id,
            this.xestadoPiso,
            this.muyBueno,
            this.bueno,
            this.regular,
            this.malo,
            this.xporcentaje,
            this.xestado,
            this.xanti_inicial,
            this.xanti_final});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 106);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(952, 306);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // xdepreciacion_ID
            // 
            this.xdepreciacion_ID.DataPropertyName = "depreciacion_ID";
            this.xdepreciacion_ID.HeaderText = "ID";
            this.xdepreciacion_ID.Name = "xdepreciacion_ID";
            this.xdepreciacion_ID.ReadOnly = true;
            this.xdepreciacion_ID.Visible = false;
            // 
            // xanio
            // 
            this.xanio.DataPropertyName = "anio";
            this.xanio.FillWeight = 80F;
            this.xanio.HeaderText = "Año";
            this.xanio.Name = "xanio";
            this.xanio.ReadOnly = true;
            // 
            // xclasificacion_id
            // 
            this.xclasificacion_id.DataPropertyName = "clasificacion";
            this.xclasificacion_id.HeaderText = "Clasificacion_ID";
            this.xclasificacion_id.Name = "xclasificacion_id";
            this.xclasificacion_id.ReadOnly = true;
            this.xclasificacion_id.Visible = false;
            // 
            // xclasificacion
            // 
            this.xclasificacion.DataPropertyName = "clasificacion_descripcion";
            this.xclasificacion.HeaderText = "Clasificación";
            this.xclasificacion.Name = "xclasificacion";
            this.xclasificacion.ReadOnly = true;
            this.xclasificacion.Width = 200;
            // 
            // xantiguedad
            // 
            this.xantiguedad.DataPropertyName = "antiguedad";
            this.xantiguedad.HeaderText = "Antiguedad_ID";
            this.xantiguedad.Name = "xantiguedad";
            this.xantiguedad.ReadOnly = true;
            this.xantiguedad.Visible = false;
            this.xantiguedad.Width = 150;
            // 
            // xantiguedad_descripcion
            // 
            this.xantiguedad_descripcion.DataPropertyName = "antiguedad_descripcion";
            this.xantiguedad_descripcion.HeaderText = "Antiguedad";
            this.xantiguedad_descripcion.Name = "xantiguedad_descripcion";
            this.xantiguedad_descripcion.ReadOnly = true;
            this.xantiguedad_descripcion.Width = 70;
            // 
            // xmaterial_id
            // 
            this.xmaterial_id.DataPropertyName = "material";
            this.xmaterial_id.HeaderText = "Material_Id";
            this.xmaterial_id.Name = "xmaterial_id";
            this.xmaterial_id.ReadOnly = true;
            this.xmaterial_id.Visible = false;
            // 
            // xmaterial
            // 
            this.xmaterial.DataPropertyName = "material_descripcion";
            this.xmaterial.HeaderText = "Material";
            this.xmaterial.Name = "xmaterial";
            this.xmaterial.ReadOnly = true;
            this.xmaterial.Width = 200;
            // 
            // xestadoPiso_id
            // 
            this.xestadoPiso_id.DataPropertyName = "estado_piso";
            this.xestadoPiso_id.HeaderText = "Estado_Piso_Id";
            this.xestadoPiso_id.Name = "xestadoPiso_id";
            this.xestadoPiso_id.ReadOnly = true;
            this.xestadoPiso_id.Visible = false;
            // 
            // xestadoPiso
            // 
            this.xestadoPiso.DataPropertyName = "estadoPiso_descripcion";
            this.xestadoPiso.HeaderText = "Estado Piso";
            this.xestadoPiso.Name = "xestadoPiso";
            this.xestadoPiso.ReadOnly = true;
            this.xestadoPiso.Visible = false;
            this.xestadoPiso.Width = 200;
            // 
            // muyBueno
            // 
            this.muyBueno.DataPropertyName = "muyBueno";
            this.muyBueno.HeaderText = "Muy Bueno";
            this.muyBueno.Name = "muyBueno";
            this.muyBueno.ReadOnly = true;
            this.muyBueno.Width = 70;
            // 
            // bueno
            // 
            this.bueno.DataPropertyName = "bueno";
            this.bueno.HeaderText = "Bueno";
            this.bueno.Name = "bueno";
            this.bueno.ReadOnly = true;
            this.bueno.Width = 70;
            // 
            // regular
            // 
            this.regular.DataPropertyName = "regular";
            this.regular.HeaderText = "Regular";
            this.regular.Name = "regular";
            this.regular.ReadOnly = true;
            this.regular.Width = 70;
            // 
            // malo
            // 
            this.malo.DataPropertyName = "malo";
            this.malo.HeaderText = "Malo";
            this.malo.Name = "malo";
            this.malo.ReadOnly = true;
            this.malo.Width = 70;
            // 
            // xporcentaje
            // 
            this.xporcentaje.DataPropertyName = "porcentaje";
            this.xporcentaje.HeaderText = "Porcentaje";
            this.xporcentaje.Name = "xporcentaje";
            this.xporcentaje.ReadOnly = true;
            this.xporcentaje.Visible = false;
            this.xporcentaje.Width = 150;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "estado";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            this.xestado.Width = 50;
            // 
            // xanti_inicial
            // 
            this.xanti_inicial.DataPropertyName = "anti_inicial";
            this.xanti_inicial.HeaderText = "Inicial";
            this.xanti_inicial.Name = "xanti_inicial";
            this.xanti_inicial.ReadOnly = true;
            this.xanti_inicial.Visible = false;
            // 
            // xanti_final
            // 
            this.xanti_final.DataPropertyName = "anti_final";
            this.xanti_final.HeaderText = "Final";
            this.xanti_final.Name = "xanti_final";
            this.xanti_final.ReadOnly = true;
            this.xanti_final.Visible = false;
            // 
            // Frm_Depreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Depreciacion";
            this.Text = "Gestionar Depreciacion";
            this.Load += new System.EventHandler(this.Frm_Depreciacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_clasificacion;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdepreciacion_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclasificacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xantiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn xantiguedad_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmaterial_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn xestadoPiso_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xestadoPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn muyBueno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bueno;
        private System.Windows.Forms.DataGridViewTextBoxColumn regular;
        private System.Windows.Forms.DataGridViewTextBoxColumn malo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xporcentaje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xanti_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn xanti_final;
    }
}