namespace SGR.WinApp.Layout._1_Tablas_Maestras.Sectores
{
    partial class Frm_sectores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xSector_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipo_Junta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBarrido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xRecojo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xJardin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xSerenazgo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xsysFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcionTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1022, 27);
            this.toolStrip1.TabIndex = 3;
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
            this.xSector_id,
            this.xdescripcion,
            this.xTipo_Junta,
            this.xBarrido,
            this.xRecojo,
            this.xJardin,
            this.xSerenazgo,
            this.xestado,
            this.xsysFecha,
            this.xusuario,
            this.xDescripcionTipo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 435);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // xSector_id
            // 
            this.xSector_id.DataPropertyName = "Sector_id";
            this.xSector_id.HeaderText = "Codigo";
            this.xSector_id.Name = "xSector_id";
            this.xSector_id.ReadOnly = true;
            this.xSector_id.Visible = false;
            this.xSector_id.Width = 70;
            // 
            // xdescripcion
            // 
            this.xdescripcion.DataPropertyName = "Descripcion";
            this.xdescripcion.HeaderText = "Descripción";
            this.xdescripcion.Name = "xdescripcion";
            this.xdescripcion.ReadOnly = true;
            this.xdescripcion.Width = 300;
            // 
            // xTipo_Junta
            // 
            this.xTipo_Junta.DataPropertyName = "Tipo_Junta";
            this.xTipo_Junta.HeaderText = "Tipo Junta";
            this.xTipo_Junta.Name = "xTipo_Junta";
            this.xTipo_Junta.ReadOnly = true;
            this.xTipo_Junta.Visible = false;
            this.xTipo_Junta.Width = 150;
            // 
            // xBarrido
            // 
            this.xBarrido.DataPropertyName = "Barrido";
            this.xBarrido.HeaderText = "Barrido";
            this.xBarrido.Name = "xBarrido";
            this.xBarrido.ReadOnly = true;
            this.xBarrido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xBarrido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xBarrido.Width = 70;
            // 
            // xRecojo
            // 
            this.xRecojo.DataPropertyName = "Recojo";
            this.xRecojo.HeaderText = "Recojo";
            this.xRecojo.Name = "xRecojo";
            this.xRecojo.ReadOnly = true;
            this.xRecojo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xRecojo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xRecojo.Width = 70;
            // 
            // xJardin
            // 
            this.xJardin.DataPropertyName = "Jardin";
            this.xJardin.HeaderText = "Jardín";
            this.xJardin.Name = "xJardin";
            this.xJardin.ReadOnly = true;
            this.xJardin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xJardin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xJardin.Width = 70;
            // 
            // xSerenazgo
            // 
            this.xSerenazgo.DataPropertyName = "Serenazgo";
            this.xSerenazgo.HeaderText = "Serenazgo";
            this.xSerenazgo.Name = "xSerenazgo";
            this.xSerenazgo.ReadOnly = true;
            this.xSerenazgo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xSerenazgo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xSerenazgo.Width = 70;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "estado";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            this.xestado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xestado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xestado.Width = 70;
            // 
            // xsysFecha
            // 
            this.xsysFecha.DataPropertyName = "sysFecha";
            this.xsysFecha.HeaderText = "Fecha Ingreso";
            this.xsysFecha.Name = "xsysFecha";
            this.xsysFecha.ReadOnly = true;
            this.xsysFecha.Visible = false;
            // 
            // xusuario
            // 
            this.xusuario.DataPropertyName = "sysUser";
            this.xusuario.HeaderText = "Usuario";
            this.xusuario.Name = "xusuario";
            this.xusuario.ReadOnly = true;
            this.xusuario.Visible = false;
            this.xusuario.Width = 80;
            // 
            // xDescripcionTipo
            // 
            this.xDescripcionTipo.DataPropertyName = "descripcionTIpo";
            this.xDescripcionTipo.HeaderText = "Tipo Sector";
            this.xDescripcionTipo.Name = "xDescripcionTipo";
            this.xDescripcionTipo.ReadOnly = true;
            this.xDescripcionTipo.Width = 350;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1022, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusqueda.Location = new System.Drawing.Point(83, 18);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.MaxLength = 100;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(209, 20);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // Frm_sectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_sectores";
            this.Text = "Gestionar Sectores";
            this.Load += new System.EventHandler(this.Frm_sectores_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSector_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipo_Junta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xBarrido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xRecojo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xJardin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xSerenazgo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsysFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcionTipo;
    }
}