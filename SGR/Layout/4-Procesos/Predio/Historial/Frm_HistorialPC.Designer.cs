namespace SGR.WinApp.Layout._4_Procesos.Predio.Historial_PC
{
    partial class Frm_HistorialPC
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.dgHistorial = new System.Windows.Forms.DataGridView();
            this.idHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obligacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOperDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(698, 58);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo:";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(152, 23);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo.TabIndex = 2;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEditar,
            this.toolImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 27);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNuevo
            // 
            this.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(24, 24);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolEditar
            // 
            this.toolEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.toolEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditar.Name = "toolEditar";
            this.toolEditar.Size = new System.Drawing.Size(24, 24);
            this.toolEditar.Text = "Editar";
            this.toolEditar.Click += new System.EventHandler(this.toolEditar_Click);
            // 
            // toolImprimir
            // 
            this.toolImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolImprimir.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImprimir.Name = "toolImprimir";
            this.toolImprimir.Size = new System.Drawing.Size(24, 24);
            this.toolImprimir.Text = "Imprimir";
            // 
            // dgHistorial
            // 
            this.dgHistorial.AllowUserToAddRows = false;
            this.dgHistorial.AllowUserToDeleteRows = false;
            this.dgHistorial.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHistorial,
            this.tipoDocumento,
            this.idPredio,
            this.idPersona,
            this.tipo_,
            this.idPeriodo,
            this.descripcion,
            this.obligacion,
            this.expediente,
            this.tipoOperacion,
            this.tipoOperDescrip,
            this.tipodocDescrip,
            this.fecha,
            this.registro_user_add,
            this.registro_user_update,
            this.registro_pc_add,
            this.registro_pc_update,
            this.registro_fecha_add,
            this.registro_fecha_update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgHistorial.EnableHeadersVisualStyles = false;
            this.dgHistorial.Location = new System.Drawing.Point(0, 89);
            this.dgHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.dgHistorial.MultiSelect = false;
            this.dgHistorial.Name = "dgHistorial";
            this.dgHistorial.ReadOnly = true;
            this.dgHistorial.RowHeadersVisible = false;
            this.dgHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHistorial.Size = new System.Drawing.Size(704, 248);
            this.dgHistorial.TabIndex = 16;
            // 
            // idHistorial
            // 
            this.idHistorial.DataPropertyName = "idHistorial";
            this.idHistorial.HeaderText = "Historial ID";
            this.idHistorial.Name = "idHistorial";
            this.idHistorial.ReadOnly = true;
            this.idHistorial.Visible = false;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "tipoDocumento";
            this.tipoDocumento.HeaderText = "Tipo Documento ID";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Visible = false;
            // 
            // idPredio
            // 
            this.idPredio.DataPropertyName = "idPredio";
            this.idPredio.HeaderText = "Predio ID";
            this.idPredio.Name = "idPredio";
            this.idPredio.ReadOnly = true;
            this.idPredio.Visible = false;
            // 
            // idPersona
            // 
            this.idPersona.DataPropertyName = "idPersona";
            this.idPersona.HeaderText = "Persona ID";
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Visible = false;
            // 
            // tipo_
            // 
            this.tipo_.DataPropertyName = "tipo";
            this.tipo_.HeaderText = "Tipo";
            this.tipo_.Name = "tipo_";
            this.tipo_.ReadOnly = true;
            this.tipo_.Visible = false;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // obligacion
            // 
            this.obligacion.DataPropertyName = "Obligacion";
            this.obligacion.HeaderText = "Obligación";
            this.obligacion.Name = "obligacion";
            this.obligacion.ReadOnly = true;
            // 
            // expediente
            // 
            this.expediente.DataPropertyName = "Expediente";
            this.expediente.HeaderText = "Expediente";
            this.expediente.Name = "expediente";
            this.expediente.ReadOnly = true;
            // 
            // tipoOperacion
            // 
            this.tipoOperacion.DataPropertyName = "TipoOperacion";
            this.tipoOperacion.HeaderText = "Tipo Opera";
            this.tipoOperacion.Name = "tipoOperacion";
            this.tipoOperacion.ReadOnly = true;
            this.tipoOperacion.Visible = false;
            // 
            // tipoOperDescrip
            // 
            this.tipoOperDescrip.DataPropertyName = "tipoOperDescrip";
            this.tipoOperDescrip.HeaderText = "Tipo Operación";
            this.tipoOperDescrip.Name = "tipoOperDescrip";
            this.tipoOperDescrip.ReadOnly = true;
            // 
            // tipodocDescrip
            // 
            this.tipodocDescrip.DataPropertyName = "tipodocDescrip";
            this.tipodocDescrip.HeaderText = "Tipo Documento";
            this.tipodocDescrip.Name = "tipodocDescrip";
            this.tipodocDescrip.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "User Add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "User Update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "PC Add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "PC Update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "Fecha Add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "Fecha Update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // Frm_HistorialPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 338);
            this.Controls.Add(this.dgHistorial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_HistorialPC";
            this.Text = "Gentión Historial";
            this.Load += new System.EventHandler(this.Frm_HistorialPC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.DataGridView dgHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn obligacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOperDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
    }
}