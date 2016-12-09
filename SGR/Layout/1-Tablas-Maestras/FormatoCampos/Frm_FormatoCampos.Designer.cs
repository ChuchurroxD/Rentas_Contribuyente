namespace SGR.WinApp.Layout._1_Tablas_Maestras.FormatoCampos
{
    partial class Frm_FormatoCampos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgFormatoCampos = new System.Windows.Forms.DataGridView();
            this.xFormColum_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoFormato_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoFormato_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFormColum_anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFormColum_Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFormColum_Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFormColum_Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFormColum_Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            this.toolcancelar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgFormatoCampos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFormatoCampos
            // 
            this.dgFormatoCampos.AllowUserToAddRows = false;
            this.dgFormatoCampos.AllowUserToDeleteRows = false;
            this.dgFormatoCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFormatoCampos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFormatoCampos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgFormatoCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFormatoCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xFormColum_id,
            this.xTipoFormato_id,
            this.xTipoFormato_descripcion,
            this.xFormColum_anio,
            this.xFormColum_Columna1,
            this.xFormColum_Columna2,
            this.xFormColum_Columna3,
            this.xFormColum_Columna4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFormatoCampos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgFormatoCampos.EnableHeadersVisualStyles = false;
            this.dgFormatoCampos.Location = new System.Drawing.Point(0, 91);
            this.dgFormatoCampos.Margin = new System.Windows.Forms.Padding(2);
            this.dgFormatoCampos.MultiSelect = false;
            this.dgFormatoCampos.Name = "dgFormatoCampos";
            this.dgFormatoCampos.ReadOnly = true;
            this.dgFormatoCampos.RowHeadersVisible = false;
            this.dgFormatoCampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFormatoCampos.Size = new System.Drawing.Size(804, 256);
            this.dgFormatoCampos.TabIndex = 13;
            this.dgFormatoCampos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgFormatoCampos_ColumnHeaderMouseClick);
            this.dgFormatoCampos.DoubleClick += new System.EventHandler(this.dgFormatoCampos_DoubleClick);
            // 
            // xFormColum_id
            // 
            this.xFormColum_id.DataPropertyName = "id";
            this.xFormColum_id.HeaderText = "Formato Columna ID";
            this.xFormColum_id.Name = "xFormColum_id";
            this.xFormColum_id.ReadOnly = true;
            this.xFormColum_id.Visible = false;
            // 
            // xTipoFormato_id
            // 
            this.xTipoFormato_id.DataPropertyName = "tipo_formato_id";
            this.xTipoFormato_id.HeaderText = "Tipo Formato ID";
            this.xTipoFormato_id.Name = "xTipoFormato_id";
            this.xTipoFormato_id.ReadOnly = true;
            this.xTipoFormato_id.Visible = false;
            // 
            // xTipoFormato_descripcion
            // 
            this.xTipoFormato_descripcion.DataPropertyName = "tipo_formato_descripcion";
            this.xTipoFormato_descripcion.HeaderText = "Tipo Formato";
            this.xTipoFormato_descripcion.Name = "xTipoFormato_descripcion";
            this.xTipoFormato_descripcion.ReadOnly = true;
            this.xTipoFormato_descripcion.Width = 200;
            // 
            // xFormColum_anio
            // 
            this.xFormColum_anio.DataPropertyName = "anio";
            this.xFormColum_anio.HeaderText = "Año";
            this.xFormColum_anio.Name = "xFormColum_anio";
            this.xFormColum_anio.ReadOnly = true;
            this.xFormColum_anio.Visible = false;
            this.xFormColum_anio.Width = 80;
            // 
            // xFormColum_Columna1
            // 
            this.xFormColum_Columna1.DataPropertyName = "colum1";
            this.xFormColum_Columna1.HeaderText = "Columna 1";
            this.xFormColum_Columna1.Name = "xFormColum_Columna1";
            this.xFormColum_Columna1.ReadOnly = true;
            this.xFormColum_Columna1.Width = 150;
            // 
            // xFormColum_Columna2
            // 
            this.xFormColum_Columna2.DataPropertyName = "colum2";
            this.xFormColum_Columna2.HeaderText = "Columna 2";
            this.xFormColum_Columna2.Name = "xFormColum_Columna2";
            this.xFormColum_Columna2.ReadOnly = true;
            this.xFormColum_Columna2.Width = 150;
            // 
            // xFormColum_Columna3
            // 
            this.xFormColum_Columna3.DataPropertyName = "colum3";
            this.xFormColum_Columna3.HeaderText = "Columna 3";
            this.xFormColum_Columna3.Name = "xFormColum_Columna3";
            this.xFormColum_Columna3.ReadOnly = true;
            this.xFormColum_Columna3.Width = 150;
            // 
            // xFormColum_Columna4
            // 
            this.xFormColum_Columna4.DataPropertyName = "colum4";
            this.xFormColum_Columna4.HeaderText = "Columna 4";
            this.xFormColum_Columna4.Name = "xFormColum_Columna4";
            this.xFormColum_Columna4.ReadOnly = true;
            this.xFormColum_Columna4.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(804, 61);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(109, 27);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo.TabIndex = 3;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(321, 28);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(277, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEditar,
            this.tooleliminar,
            this.toolcancelar,
            this.toolImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 27);
            this.toolStrip1.TabIndex = 12;
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
            this.toolEditar.Click += new System.EventHandler(this.tooleditar_Click);
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
            // 
            // toolcancelar
            // 
            this.toolcancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolcancelar.Image = global::SGR.WinApp.Properties.Resources.back_arrow;
            this.toolcancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolcancelar.Name = "toolcancelar";
            this.toolcancelar.Size = new System.Drawing.Size(24, 24);
            this.toolcancelar.Text = "Cancelar";
            this.toolcancelar.Visible = false;
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
            // Frm_FormatoCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 358);
            this.Controls.Add(this.dgFormatoCampos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_FormatoCampos";
            this.Text = "GESTIONAR FORMATO CAMPOS";
            this.Load += new System.EventHandler(this.Frm_TribFormatoCampos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFormatoCampos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFormatoCampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.ToolStripButton toolcancelar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFormColum_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoFormato_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoFormato_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFormColum_anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFormColum_Columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFormColum_Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFormColum_Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFormColum_Columna4;
    }
}