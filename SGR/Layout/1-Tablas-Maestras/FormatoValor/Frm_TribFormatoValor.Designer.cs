namespace SGR.WinApp.Layout._1_Tablas_Maestras.FormatoValor
{
    partial class Frm_TribFormatoValor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsysFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xTipoFracc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            this.toolcancelar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xcodigo,
            this.xsysFecha,
            this.xusuario,
            this.Column2,
            this.xestado,
            this.xTipoFracc,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(5, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(710, 269);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // xcodigo
            // 
            this.xcodigo.DataPropertyName = "Valoc_iformato_valores_ID";
            this.xcodigo.HeaderText = "Código";
            this.xcodigo.Name = "xcodigo";
            this.xcodigo.ReadOnly = true;
            this.xcodigo.Visible = false;
            this.xcodigo.Width = 50;
            // 
            // xsysFecha
            // 
            this.xsysFecha.DataPropertyName = "Valoc_vdescripcion";
            this.xsysFecha.HeaderText = "Descripción";
            this.xsysFecha.Name = "xsysFecha";
            this.xsysFecha.ReadOnly = true;
            this.xsysFecha.Width = 250;
            // 
            // xusuario
            // 
            this.xusuario.DataPropertyName = "Valoc_ianio";
            this.xusuario.HeaderText = "Año";
            this.xusuario.Name = "xusuario";
            this.xusuario.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Valoc_vtipodocDec";
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "Valoc_bactivo";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            this.xestado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xestado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // xTipoFracc
            // 
            this.xTipoFracc.DataPropertyName = "Valoc_vmot_determ";
            this.xTipoFracc.HeaderText = "mot Determ";
            this.xTipoFracc.Name = "xTipoFracc";
            this.xTipoFracc.ReadOnly = true;
            this.xTipoFracc.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Valoc_vmensaje";
            this.Column4.HeaderText = "Mensaje";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Valoc_vbase_legal";
            this.Column5.HeaderText = "Base Legal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Valoc_vpie_pag";
            this.Column6.HeaderText = "Pie Pagina";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Valoc_vtipodoc";
            this.Column7.HeaderText = "Cod Tipo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(550, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(75, 25);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleditar,
            this.tooleliminar,
            this.toolcancelar,
            this.toolImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 27);
            this.toolStrip1.TabIndex = 9;
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
            this.toolImprimir.Click += new System.EventHandler(this.toolImprimir_Click);
            // 
            // Frm_TribFormatoValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(721, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TribFormatoValor";
            this.Text = "Formato Valor";
            this.Load += new System.EventHandler(this.Frm_TribFormatoValor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.ToolStripButton toolcancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsysFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoFracc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStripButton toolImprimir;
    }
}