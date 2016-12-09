namespace SGR.WinApp.Layout._1_Tablas_Maestras.Tributos
{
    partial class Frm_tributos
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xtributo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xabreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo_tributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xporcentaje_UIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclasificacion_ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcod_contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xarea_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xporcentaje_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipocl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaTributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcobro_interes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.toolStrip1.Size = new System.Drawing.Size(1000, 27);
            this.toolStrip1.TabIndex = 4;
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1000, 61);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Año";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(424, 24);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo.TabIndex = 32;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusqueda.Location = new System.Drawing.Point(81, 24);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.MaxLength = 100;
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
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.xtributo_ID,
            this.xdescripcion,
            this.ximporte,
            this.xabreviatura,
            this.xtipo_tributo,
            this.xporcentaje_UIT,
            this.xclasificacion_ingresos,
            this.xcod_contable,
            this.xarea_codigo,
            this.xporcentaje_area,
            this.xfuente,
            this.xTipoDescripcion,
            this.xtipocl,
            this.areaTributo,
            this.xcobro_interes,
            this.xactivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 303);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // xtributo_ID
            // 
            this.xtributo_ID.DataPropertyName = "tributos_ID";
            this.xtributo_ID.HeaderText = "ID";
            this.xtributo_ID.Name = "xtributo_ID";
            this.xtributo_ID.ReadOnly = true;
            this.xtributo_ID.Visible = false;
            this.xtributo_ID.Width = 70;
            // 
            // xdescripcion
            // 
            this.xdescripcion.DataPropertyName = "descripcion";
            this.xdescripcion.HeaderText = "Descripción";
            this.xdescripcion.Name = "xdescripcion";
            this.xdescripcion.ReadOnly = true;
            this.xdescripcion.Width = 300;
            // 
            // ximporte
            // 
            this.ximporte.DataPropertyName = "importe";
            this.ximporte.HeaderText = "Importe";
            this.ximporte.Name = "ximporte";
            this.ximporte.ReadOnly = true;
            // 
            // xabreviatura
            // 
            this.xabreviatura.DataPropertyName = "abrev";
            this.xabreviatura.HeaderText = "Abrev.";
            this.xabreviatura.Name = "xabreviatura";
            this.xabreviatura.ReadOnly = true;
            // 
            // xtipo_tributo
            // 
            this.xtipo_tributo.DataPropertyName = "tipo_tributo";
            this.xtipo_tributo.HeaderText = "Tipo Tributo";
            this.xtipo_tributo.Name = "xtipo_tributo";
            this.xtipo_tributo.ReadOnly = true;
            this.xtipo_tributo.Visible = false;
            // 
            // xporcentaje_UIT
            // 
            this.xporcentaje_UIT.DataPropertyName = "porce_uit";
            this.xporcentaje_UIT.HeaderText = "Porcentaje UIT";
            this.xporcentaje_UIT.Name = "xporcentaje_UIT";
            this.xporcentaje_UIT.ReadOnly = true;
            // 
            // xclasificacion_ingresos
            // 
            this.xclasificacion_ingresos.DataPropertyName = "clai_codigo";
            this.xclasificacion_ingresos.HeaderText = "Clasificacion Ingresos";
            this.xclasificacion_ingresos.Name = "xclasificacion_ingresos";
            this.xclasificacion_ingresos.ReadOnly = true;
            this.xclasificacion_ingresos.Visible = false;
            // 
            // xcod_contable
            // 
            this.xcod_contable.DataPropertyName = "cod_contable";
            this.xcod_contable.HeaderText = "Codigo Contable";
            this.xcod_contable.Name = "xcod_contable";
            this.xcod_contable.ReadOnly = true;
            this.xcod_contable.Visible = false;
            // 
            // xarea_codigo
            // 
            this.xarea_codigo.DataPropertyName = "are_codigo";
            this.xarea_codigo.HeaderText = "Codigo Area";
            this.xarea_codigo.Name = "xarea_codigo";
            this.xarea_codigo.ReadOnly = true;
            this.xarea_codigo.Visible = false;
            // 
            // xporcentaje_area
            // 
            this.xporcentaje_area.DataPropertyName = "porce_area";
            this.xporcentaje_area.HeaderText = "Porcentaje Area";
            this.xporcentaje_area.Name = "xporcentaje_area";
            this.xporcentaje_area.ReadOnly = true;
            // 
            // xfuente
            // 
            this.xfuente.DataPropertyName = "fuente";
            this.xfuente.HeaderText = "Fuente";
            this.xfuente.Name = "xfuente";
            this.xfuente.ReadOnly = true;
            this.xfuente.Visible = false;
            // 
            // xTipoDescripcion
            // 
            this.xTipoDescripcion.DataPropertyName = "tipo";
            this.xTipoDescripcion.HeaderText = "Tipo Tributo";
            this.xTipoDescripcion.Name = "xTipoDescripcion";
            this.xTipoDescripcion.ReadOnly = true;
            // 
            // xtipocl
            // 
            this.xtipocl.DataPropertyName = "tipocl";
            this.xtipocl.HeaderText = "Clasificación de Ingresos";
            this.xtipocl.Name = "xtipocl";
            this.xtipocl.ReadOnly = true;
            // 
            // areaTributo
            // 
            this.areaTributo.DataPropertyName = "area";
            this.areaTributo.HeaderText = "Area";
            this.areaTributo.Name = "areaTributo";
            this.areaTributo.ReadOnly = true;
            this.areaTributo.Width = 250;
            // 
            // xcobro_interes
            // 
            this.xcobro_interes.DataPropertyName = "cobro_interes";
            this.xcobro_interes.HeaderText = "Cobro Interes";
            this.xcobro_interes.Name = "xcobro_interes";
            this.xcobro_interes.ReadOnly = true;
            this.xcobro_interes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // xactivo
            // 
            this.xactivo.DataPropertyName = "activo";
            this.xactivo.HeaderText = "Activo";
            this.xactivo.Name = "xactivo";
            this.xactivo.ReadOnly = true;
            // 
            // Frm_tributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 391);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_tributos";
            this.Text = "Gestionar Tributos";
            this.Load += new System.EventHandler(this.Frm_tributos_Load);
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
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtributo_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn xabreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo_tributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xporcentaje_UIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclasificacion_ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcod_contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xarea_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xporcentaje_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipocl;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaTributo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xcobro_interes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xactivo;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
    }
}