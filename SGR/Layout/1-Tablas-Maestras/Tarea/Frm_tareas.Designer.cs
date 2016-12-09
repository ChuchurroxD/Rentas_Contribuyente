namespace SGR.WinApp.Layout._1_Tablas_Maestras.Tarea
{
    partial class Frm_tareas
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
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTareas = new System.Windows.Forms.DataGridView();
            this.xTarea_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGrupo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTarea_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTarea_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTarea_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTarea_activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xTarea_padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolEliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.cboGrupo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(872, 47);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(148, 21);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(189, 21);
            this.cboGrupo.TabIndex = 3;
            this.cboGrupo.SelectedIndexChanged += new System.EventHandler(this.cboGrupo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupo:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(448, 21);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.MaxLength = 100;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(209, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // dgTareas
            // 
            this.dgTareas.AllowUserToAddRows = false;
            this.dgTareas.AllowUserToDeleteRows = false;
            this.dgTareas.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xTarea_id,
            this.xGrupo_id,
            this.xTarea_nombre,
            this.xTarea_descripcion,
            this.xTarea_url,
            this.xTarea_activo,
            this.xTarea_padre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTareas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTareas.EnableHeadersVisualStyles = false;
            this.dgTareas.Location = new System.Drawing.Point(11, 78);
            this.dgTareas.Margin = new System.Windows.Forms.Padding(2);
            this.dgTareas.MultiSelect = false;
            this.dgTareas.Name = "dgTareas";
            this.dgTareas.ReadOnly = true;
            this.dgTareas.RowHeadersVisible = false;
            this.dgTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTareas.Size = new System.Drawing.Size(853, 394);
            this.dgTareas.TabIndex = 10;
            this.dgTareas.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTareas_ColumnHeaderMouseClick);
            this.dgTareas.DoubleClick += new System.EventHandler(this.dgTareas_DoubleClick);
            // 
            // xTarea_id
            // 
            this.xTarea_id.DataPropertyName = "Tarec_iCodigo";
            this.xTarea_id.HeaderText = "Código";
            this.xTarea_id.Name = "xTarea_id";
            this.xTarea_id.ReadOnly = true;
            this.xTarea_id.Visible = false;
            // 
            // xGrupo_id
            // 
            this.xGrupo_id.DataPropertyName = "Grupo_id";
            this.xGrupo_id.HeaderText = "Grupo id";
            this.xGrupo_id.Name = "xGrupo_id";
            this.xGrupo_id.ReadOnly = true;
            this.xGrupo_id.Visible = false;
            // 
            // xTarea_nombre
            // 
            this.xTarea_nombre.DataPropertyName = "Tarec_vNombre";
            this.xTarea_nombre.HeaderText = "Nombre";
            this.xTarea_nombre.Name = "xTarea_nombre";
            this.xTarea_nombre.ReadOnly = true;
            this.xTarea_nombre.Width = 150;
            // 
            // xTarea_descripcion
            // 
            this.xTarea_descripcion.DataPropertyName = "Tarec_vDescripcion";
            this.xTarea_descripcion.HeaderText = "Descripción";
            this.xTarea_descripcion.Name = "xTarea_descripcion";
            this.xTarea_descripcion.ReadOnly = true;
            this.xTarea_descripcion.Width = 200;
            // 
            // xTarea_url
            // 
            this.xTarea_url.DataPropertyName = "Tarec_vUrl";
            this.xTarea_url.HeaderText = "URL";
            this.xTarea_url.Name = "xTarea_url";
            this.xTarea_url.ReadOnly = true;
            this.xTarea_url.Width = 400;
            // 
            // xTarea_activo
            // 
            this.xTarea_activo.DataPropertyName = "Tarec_bActivo";
            this.xTarea_activo.HeaderText = "Activo";
            this.xTarea_activo.Name = "xTarea_activo";
            this.xTarea_activo.ReadOnly = true;
            // 
            // xTarea_padre
            // 
            this.xTarea_padre.DataPropertyName = "Tarec_Padre";
            this.xTarea_padre.HeaderText = "Tarea Padre";
            this.xTarea_padre.Name = "xTarea_padre";
            this.xTarea_padre.ReadOnly = true;
            this.xTarea_padre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xTarea_padre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xTarea_padre.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEditar,
            this.toolImprimir,
            this.toolEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 27);
            this.toolStrip1.TabIndex = 9;
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
            this.toolImprimir.Click += new System.EventHandler(this.toolImprimir_Click);
            // 
            // toolEliminar
            // 
            this.toolEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminar.Name = "toolEliminar";
            this.toolEliminar.Size = new System.Drawing.Size(23, 24);
            this.toolEliminar.Text = "Eliminar";
            // 
            // Frm_tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgTareas);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_tareas";
            this.Text = "Gestión Tarea";
            this.Load += new System.EventHandler(this.Frm_tareas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTareas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTarea_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGrupo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTarea_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTarea_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTarea_url;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xTarea_activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTarea_padre;
    }
}