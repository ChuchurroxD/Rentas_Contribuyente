namespace SGR.WinApp.Layout._1_Tablas_Maestras.Periodo
{
    partial class Frm_Periodo
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
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xcanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopeUITPension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUitAlcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmoraAlcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTasaAlcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorOficilizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tooleditar,
            this.tooleliminar,
            this.toolStripBotonReporte});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(856, 27);
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
            this.groupBox1.Size = new System.Drawing.Size(856, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Búsqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(234, 28);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(277, 20);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.Frm_Periodo_Load);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda por año:";
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
            this.xcanio,
            this.TopeUITPension,
            this.MinimoPredio,
            this.xDescripcion,
            this.xUIT,
            this.xUitAlcabala,
            this.xmoraAlcabala,
            this.xTasaAlcabala,
            this.Interes,
            this.FactorOficilizacion,
            this.Formulario,
            this.Tramo1,
            this.Tramo2,
            this.Tramo3,
            this.xestado});
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(856, 248);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // xcanio
            // 
            this.xcanio.DataPropertyName = "Peric_canio";
            this.xcanio.HeaderText = "Año";
            this.xcanio.Name = "xcanio";
            this.xcanio.ReadOnly = true;
            this.xcanio.Width = 50;
            // 
            // TopeUITPension
            // 
            this.TopeUITPension.DataPropertyName = "TopeUITPension";
            this.TopeUITPension.HeaderText = "TopeUIT Pensión";
            this.TopeUITPension.Name = "TopeUITPension";
            this.TopeUITPension.ReadOnly = true;
            this.TopeUITPension.Width = 60;
            // 
            // MinimoPredio
            // 
            this.MinimoPredio.DataPropertyName = "MinimoPredio";
            this.MinimoPredio.HeaderText = "MinPre.";
            this.MinimoPredio.Name = "MinimoPredio";
            this.MinimoPredio.ReadOnly = true;
            this.MinimoPredio.Width = 50;
            // 
            // xDescripcion
            // 
            this.xDescripcion.DataPropertyName = "Peric_vdescripcion";
            this.xDescripcion.HeaderText = "Descripción";
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.ReadOnly = true;
            this.xDescripcion.Width = 150;
            // 
            // xUIT
            // 
            this.xUIT.DataPropertyName = "Peric_euit";
            this.xUIT.HeaderText = "UIT";
            this.xUIT.Name = "xUIT";
            this.xUIT.ReadOnly = true;
            this.xUIT.Width = 60;
            // 
            // xUitAlcabala
            // 
            this.xUitAlcabala.DataPropertyName = "Peric_iuitAlcabala";
            this.xUitAlcabala.HeaderText = "UIT Alcabala";
            this.xUitAlcabala.Name = "xUitAlcabala";
            this.xUitAlcabala.ReadOnly = true;
            this.xUitAlcabala.Width = 70;
            // 
            // xmoraAlcabala
            // 
            this.xmoraAlcabala.DataPropertyName = "Peric_nmoraAlcaba";
            this.xmoraAlcabala.HeaderText = "Mora de alcabala";
            this.xmoraAlcabala.Name = "xmoraAlcabala";
            this.xmoraAlcabala.ReadOnly = true;
            this.xmoraAlcabala.Width = 60;
            // 
            // xTasaAlcabala
            // 
            this.xTasaAlcabala.DataPropertyName = "Peric_ntasaAlcabala";
            this.xTasaAlcabala.HeaderText = "Tasa Alcabala";
            this.xTasaAlcabala.Name = "xTasaAlcabala";
            this.xTasaAlcabala.ReadOnly = true;
            this.xTasaAlcabala.Width = 60;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "Interes";
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Width = 60;
            // 
            // FactorOficilizacion
            // 
            this.FactorOficilizacion.DataPropertyName = "FactorOficilizacion";
            this.FactorOficilizacion.HeaderText = "Factor Oficilización";
            this.FactorOficilizacion.Name = "FactorOficilizacion";
            this.FactorOficilizacion.ReadOnly = true;
            this.FactorOficilizacion.Width = 80;
            // 
            // Formulario
            // 
            this.Formulario.DataPropertyName = "Formulario";
            this.Formulario.HeaderText = "Form";
            this.Formulario.Name = "Formulario";
            this.Formulario.ReadOnly = true;
            this.Formulario.Width = 40;
            // 
            // Tramo1
            // 
            this.Tramo1.DataPropertyName = "Tramo1";
            this.Tramo1.HeaderText = "Hasta Tramo1";
            this.Tramo1.Name = "Tramo1";
            this.Tramo1.ReadOnly = true;
            this.Tramo1.Width = 80;
            // 
            // Tramo2
            // 
            this.Tramo2.DataPropertyName = "Tramo2";
            this.Tramo2.HeaderText = "Hasta Tramo2";
            this.Tramo2.Name = "Tramo2";
            this.Tramo2.ReadOnly = true;
            this.Tramo2.Width = 80;
            // 
            // Tramo3
            // 
            this.Tramo3.DataPropertyName = "Tramo3";
            this.Tramo3.HeaderText = "Hasta Tramo3";
            this.Tramo3.Name = "Tramo3";
            this.Tramo3.ReadOnly = true;
            this.Tramo3.Width = 80;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "Peric_bactivo";
            this.xestado.HeaderText = "Est";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            this.xestado.Width = 30;
            // 
            // Frm_Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(856, 336);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolmantenedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Periodo";
            this.Text = "Gestión de Periodo";
            this.Load += new System.EventHandler(this.Frm_Periodo_Load);
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
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopeUITPension;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimoPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUitAlcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmoraAlcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTasaAlcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorOficilizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramo3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
    }
}