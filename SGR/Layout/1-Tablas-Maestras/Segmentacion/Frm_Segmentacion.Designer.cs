namespace SGR.WinApp.Layout._1_Tablas_Maestras.Segmentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Segmentacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.toolnuevoOtrasInstalaciones = new System.Windows.Forms.ToolStripButton();
            this.tooleditarOtrasInstalaciones = new System.Windows.Forms.ToolStripButton();
            this.toolCopiarPerodoAnterior = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSegmentacion = new System.Windows.Forms.DataGridView();
            this.segmentacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.toolmantenedores.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevoOtrasInstalaciones,
            this.tooleditarOtrasInstalaciones,
            this.toolCopiarPerodoAnterior});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(841, 27);
            this.toolmantenedores.TabIndex = 2;
            this.toolmantenedores.Text = "toolStrip1";
            // 
            // toolnuevoOtrasInstalaciones
            // 
            this.toolnuevoOtrasInstalaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolnuevoOtrasInstalaciones.Image = ((System.Drawing.Image)(resources.GetObject("toolnuevoOtrasInstalaciones.Image")));
            this.toolnuevoOtrasInstalaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolnuevoOtrasInstalaciones.Name = "toolnuevoOtrasInstalaciones";
            this.toolnuevoOtrasInstalaciones.Size = new System.Drawing.Size(24, 24);
            this.toolnuevoOtrasInstalaciones.Text = "Nuevo";
            this.toolnuevoOtrasInstalaciones.Click += new System.EventHandler(this.toolnuevoOtrasInstalaciones_Click);
            // 
            // tooleditarOtrasInstalaciones
            // 
            this.tooleditarOtrasInstalaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooleditarOtrasInstalaciones.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.tooleditarOtrasInstalaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooleditarOtrasInstalaciones.Name = "tooleditarOtrasInstalaciones";
            this.tooleditarOtrasInstalaciones.Size = new System.Drawing.Size(24, 24);
            this.tooleditarOtrasInstalaciones.Text = "Editar";
            this.tooleditarOtrasInstalaciones.Click += new System.EventHandler(this.tooleditarOtrasInstalaciones_Click);
            // 
            // toolCopiarPerodoAnterior
            // 
            this.toolCopiarPerodoAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCopiarPerodoAnterior.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.toolCopiarPerodoAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCopiarPerodoAnterior.Name = "toolCopiarPerodoAnterior";
            this.toolCopiarPerodoAnterior.Size = new System.Drawing.Size(24, 24);
            this.toolCopiarPerodoAnterior.Text = "Copiar de periodo anterior al periodo actual";
            this.toolCopiarPerodoAnterior.Click += new System.EventHandler(this.toolCopiarPerodoAnterior_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.btnImprimir);
            this.groupBox4.Controls.Add(this.cboPeriodo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(11, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(819, 47);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opcciones de Búsqueda";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(192, 17);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(200, 21);
            this.cboPeriodo.TabIndex = 3;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda por Año:";
            // 
            // dgvSegmentacion
            // 
            this.dgvSegmentacion.AllowUserToAddRows = false;
            this.dgvSegmentacion.AllowUserToDeleteRows = false;
            this.dgvSegmentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSegmentacion.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSegmentacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSegmentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegmentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.segmentacion_id,
            this.periodo_id,
            this.monto_inicio,
            this.monto_fin,
            this.tipo,
            this.tipo_descripcion,
            this.Estado,
            this.descripcion,
            this.registro_user_add,
            this.registro_fecha_add,
            this.registro_pc_add,
            this.registro_user_update,
            this.registro_fecha_update,
            this.registro_pc_update});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSegmentacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSegmentacion.EnableHeadersVisualStyles = false;
            this.dgvSegmentacion.Location = new System.Drawing.Point(11, 80);
            this.dgvSegmentacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSegmentacion.MultiSelect = false;
            this.dgvSegmentacion.Name = "dgvSegmentacion";
            this.dgvSegmentacion.ReadOnly = true;
            this.dgvSegmentacion.RowHeadersVisible = false;
            this.dgvSegmentacion.RowTemplate.Height = 24;
            this.dgvSegmentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSegmentacion.Size = new System.Drawing.Size(819, 395);
            this.dgvSegmentacion.TabIndex = 15;
            this.dgvSegmentacion.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSegmentacion_ColumnHeaderMouseClick);
            this.dgvSegmentacion.DoubleClick += new System.EventHandler(this.dgvSegmentacion_DoubleClick);
            // 
            // segmentacion_id
            // 
            this.segmentacion_id.DataPropertyName = "segmentacion_id";
            this.segmentacion_id.HeaderText = "Código";
            this.segmentacion_id.Name = "segmentacion_id";
            this.segmentacion_id.ReadOnly = true;
            this.segmentacion_id.Width = 60;
            // 
            // periodo_id
            // 
            this.periodo_id.DataPropertyName = "periodo_id";
            this.periodo_id.HeaderText = "Periodo";
            this.periodo_id.Name = "periodo_id";
            this.periodo_id.ReadOnly = true;
            this.periodo_id.Width = 60;
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
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // tipo_descripcion
            // 
            this.tipo_descripcion.DataPropertyName = "tipo_descripcion";
            this.tipo_descripcion.HeaderText = "Tipo Descripción";
            this.tipo_descripcion.Name = "tipo_descripcion";
            this.tipo_descripcion.ReadOnly = true;
            this.tipo_descripcion.Width = 150;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "registro_user_add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "registro_fecha_add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "registro_pc_add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "registro_fecha_update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "registro_pc_update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.Image = global::SGR.WinApp.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(497, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(26, 32);
            this.btnImprimir.TabIndex = 31;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Frm_Segmentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.dgvSegmentacion);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolmantenedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Segmentacion";
            this.Text = "Segmentación";
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolnuevoOtrasInstalaciones;
        private System.Windows.Forms.ToolStripButton tooleditarOtrasInstalaciones;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSegmentacion;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.ToolStripButton toolCopiarPerodoAnterior;
        private System.Windows.Forms.Button btnImprimir;
    }
}