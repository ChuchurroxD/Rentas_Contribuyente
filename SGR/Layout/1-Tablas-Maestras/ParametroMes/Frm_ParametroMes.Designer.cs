namespace SGR.WinApp.Layout._1_Tablas_Maestras.ParametroMes
{
    partial class Frm_ParametroMes
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
            this.toolStripBotonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBusquedaPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarParametroMes = new System.Windows.Forms.DataGridView();
            this.xparametro_mes_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoImpresion_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xperiodo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipoAbreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfecha_emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfecha_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xregistro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarParametroMes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBotonNuevo,
            this.toolStripBotonEditar,
            this.toolStripBotonReporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(759, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBotonNuevo
            // 
            this.toolStripBotonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonNuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolStripBotonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonNuevo.Name = "toolStripBotonNuevo";
            this.toolStripBotonNuevo.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonNuevo.Text = "Nuevo";
            this.toolStripBotonNuevo.Click += new System.EventHandler(this.toolStripBotonNuevo_Click);
            // 
            // toolStripBotonEditar
            // 
            this.toolStripBotonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonEditar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.toolStripBotonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonEditar.Name = "toolStripBotonEditar";
            this.toolStripBotonEditar.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonEditar.Text = "Editar";
            this.toolStripBotonEditar.Click += new System.EventHandler(this.toolStripBotonEditar_Click);
            // 
            // toolStripBotonReporte
            // 
            this.toolStripBotonReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolStripBotonReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonReporte.Name = "toolStripBotonReporte";
            this.toolStripBotonReporte.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonReporte.Text = "Reporte";
            this.toolStripBotonReporte.Click += new System.EventHandler(this.toolStripBotonReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.comboBusquedaPeriodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // comboBusquedaPeriodo
            // 
            this.comboBusquedaPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBusquedaPeriodo.FormattingEnabled = true;
            this.comboBusquedaPeriodo.Location = new System.Drawing.Point(189, 17);
            this.comboBusquedaPeriodo.Name = "comboBusquedaPeriodo";
            this.comboBusquedaPeriodo.Size = new System.Drawing.Size(187, 21);
            this.comboBusquedaPeriodo.TabIndex = 1;
            this.comboBusquedaPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaPeriodo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda:";
            // 
            // dgvListarParametroMes
            // 
            this.dgvListarParametroMes.AllowUserToAddRows = false;
            this.dgvListarParametroMes.AllowUserToDeleteRows = false;
            this.dgvListarParametroMes.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarParametroMes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarParametroMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarParametroMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xparametro_mes_ID,
            this.grupoImpresion_ID,
            this.xperiodo_id,
            this.xmes,
            this.xtipo,
            this.xtipoDescripcion,
            this.xtipoAbreviatura,
            this.xfecha_emision,
            this.xfecha_vence,
            this.xestado,
            this.xregistro_user_add,
            this.xregistro_pc_add,
            this.xregistro_fecha_add,
            this.xregistro_user_update,
            this.xregistro_pc_update,
            this.xregistro_fecha_update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarParametroMes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarParametroMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarParametroMes.EnableHeadersVisualStyles = false;
            this.dgvListarParametroMes.Location = new System.Drawing.Point(0, 80);
            this.dgvListarParametroMes.MultiSelect = false;
            this.dgvListarParametroMes.Name = "dgvListarParametroMes";
            this.dgvListarParametroMes.ReadOnly = true;
            this.dgvListarParametroMes.RowHeadersVisible = false;
            this.dgvListarParametroMes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarParametroMes.Size = new System.Drawing.Size(759, 325);
            this.dgvListarParametroMes.TabIndex = 2;
            this.dgvListarParametroMes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarParametroMes_ColumnHeaderMouseClick);
            this.dgvListarParametroMes.DoubleClick += new System.EventHandler(this.dgvListarParametroMes_DoubleClick);
            // 
            // xparametro_mes_ID
            // 
            this.xparametro_mes_ID.DataPropertyName = "parametro_mes_ID";
            this.xparametro_mes_ID.HeaderText = "Codigo";
            this.xparametro_mes_ID.Name = "xparametro_mes_ID";
            this.xparametro_mes_ID.ReadOnly = true;
            this.xparametro_mes_ID.Visible = false;
            // 
            // grupoImpresion_ID
            // 
            this.grupoImpresion_ID.DataPropertyName = "grupoImpresion_ID";
            this.grupoImpresion_ID.HeaderText = "grupoImpresion_ID";
            this.grupoImpresion_ID.Name = "grupoImpresion_ID";
            this.grupoImpresion_ID.ReadOnly = true;
            this.grupoImpresion_ID.Visible = false;
            // 
            // xperiodo_id
            // 
            this.xperiodo_id.DataPropertyName = "periodo_id";
            this.xperiodo_id.HeaderText = "Año";
            this.xperiodo_id.Name = "xperiodo_id";
            this.xperiodo_id.ReadOnly = true;
            // 
            // xmes
            // 
            this.xmes.DataPropertyName = "mes";
            this.xmes.HeaderText = "Mes";
            this.xmes.Name = "xmes";
            this.xmes.ReadOnly = true;
            // 
            // xtipo
            // 
            this.xtipo.DataPropertyName = "tipo";
            this.xtipo.HeaderText = "Tipo Codigo";
            this.xtipo.Name = "xtipo";
            this.xtipo.ReadOnly = true;
            this.xtipo.Visible = false;
            // 
            // xtipoDescripcion
            // 
            this.xtipoDescripcion.DataPropertyName = "tipoDescripcion";
            this.xtipoDescripcion.HeaderText = "Tipo";
            this.xtipoDescripcion.Name = "xtipoDescripcion";
            this.xtipoDescripcion.ReadOnly = true;
            this.xtipoDescripcion.Width = 150;
            // 
            // xtipoAbreviatura
            // 
            this.xtipoAbreviatura.DataPropertyName = "tipoAbreviatura";
            this.xtipoAbreviatura.HeaderText = "Abreviatura";
            this.xtipoAbreviatura.Name = "xtipoAbreviatura";
            this.xtipoAbreviatura.ReadOnly = true;
            this.xtipoAbreviatura.Visible = false;
            // 
            // xfecha_emision
            // 
            this.xfecha_emision.DataPropertyName = "fecha_emision";
            this.xfecha_emision.HeaderText = "Fecha Emision";
            this.xfecha_emision.Name = "xfecha_emision";
            this.xfecha_emision.ReadOnly = true;
            this.xfecha_emision.Width = 150;
            // 
            // xfecha_vence
            // 
            this.xfecha_vence.DataPropertyName = "fecha_vence";
            this.xfecha_vence.HeaderText = "Fecha Vencimiento";
            this.xfecha_vence.Name = "xfecha_vence";
            this.xfecha_vence.ReadOnly = true;
            this.xfecha_vence.Width = 150;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "estado";
            this.xestado.HeaderText = "Activo?";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            // 
            // xregistro_user_add
            // 
            this.xregistro_user_add.DataPropertyName = "registro_user_add";
            this.xregistro_user_add.HeaderText = "Usuario Agregar";
            this.xregistro_user_add.Name = "xregistro_user_add";
            this.xregistro_user_add.ReadOnly = true;
            this.xregistro_user_add.Visible = false;
            // 
            // xregistro_pc_add
            // 
            this.xregistro_pc_add.DataPropertyName = "registro_pc_add";
            this.xregistro_pc_add.HeaderText = "Pc Agregar";
            this.xregistro_pc_add.Name = "xregistro_pc_add";
            this.xregistro_pc_add.ReadOnly = true;
            this.xregistro_pc_add.Visible = false;
            // 
            // xregistro_fecha_add
            // 
            this.xregistro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.xregistro_fecha_add.HeaderText = "Fecha Agregar";
            this.xregistro_fecha_add.Name = "xregistro_fecha_add";
            this.xregistro_fecha_add.ReadOnly = true;
            this.xregistro_fecha_add.Visible = false;
            // 
            // xregistro_user_update
            // 
            this.xregistro_user_update.DataPropertyName = "registro_user_update";
            this.xregistro_user_update.HeaderText = "Usuario Modificar";
            this.xregistro_user_update.Name = "xregistro_user_update";
            this.xregistro_user_update.ReadOnly = true;
            this.xregistro_user_update.Visible = false;
            // 
            // xregistro_pc_update
            // 
            this.xregistro_pc_update.DataPropertyName = "registro_pc_update";
            this.xregistro_pc_update.HeaderText = "Pc Modificar";
            this.xregistro_pc_update.Name = "xregistro_pc_update";
            this.xregistro_pc_update.ReadOnly = true;
            this.xregistro_pc_update.Visible = false;
            // 
            // xregistro_fecha_update
            // 
            this.xregistro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.xregistro_fecha_update.HeaderText = "Fecha Modificar";
            this.xregistro_fecha_update.Name = "xregistro_fecha_update";
            this.xregistro_fecha_update.ReadOnly = true;
            this.xregistro_fecha_update.Visible = false;
            // 
            // Frm_ParametroMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 405);
            this.Controls.Add(this.dgvListarParametroMes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ParametroMes";
            this.Text = "Listar Parametro Mes";
            this.Load += new System.EventHandler(this.Frm_ParametroMes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarParametroMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBotonNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBotonEditar;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListarParametroMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBusquedaPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xparametro_mes_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoImpresion_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xperiodo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipoAbreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfecha_emision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfecha_vence;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_update;
    }
}