namespace SGR.WinApp.Layout._2_Configuraciones.Rol
{
    partial class Frm_rol
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
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolmantenedores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.toolEditar,
            this.tooleliminar,
            this.toolStripBotonReporte});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(549, 27);
            this.toolmantenedores.TabIndex = 6;
            this.toolmantenedores.Text = "toolStrip1";
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
            this.tooleliminar.Click += new System.EventHandler(this.tooleliminar_Click);
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
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(549, 47);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Búsqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(238, 17);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(209, 20);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xcodigo,
            this.xnombre,
            this.xDescripcion,
            this.xestado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(549, 537);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // xcodigo
            // 
            this.xcodigo.DataPropertyName = "Rolec_iCodigo";
            this.xcodigo.HeaderText = "Codigo";
            this.xcodigo.Name = "xcodigo";
            this.xcodigo.ReadOnly = true;
            this.xcodigo.Visible = false;
            this.xcodigo.Width = 60;
            // 
            // xnombre
            // 
            this.xnombre.DataPropertyName = "Rolec_vNombre";
            this.xnombre.HeaderText = "Nombre";
            this.xnombre.Name = "xnombre";
            this.xnombre.ReadOnly = true;
            this.xnombre.Width = 180;
            // 
            // xDescripcion
            // 
            this.xDescripcion.DataPropertyName = "Rolec_vDescripcion";
            this.xDescripcion.HeaderText = "Descripción";
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.ReadOnly = true;
            this.xDescripcion.Width = 250;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "Rolec_bActivo";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            this.xestado.Width = 50;
            // 
            // Frm_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 622);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolmantenedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_rol";
            this.Text = "Gestión de Rol";
            this.Load += new System.EventHandler(this.Frm_rol_Load);
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
    }
}