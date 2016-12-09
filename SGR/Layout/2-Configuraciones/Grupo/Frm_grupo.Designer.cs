namespace SGR.WinApp.Layout._2_Configuraciones.Grupo
{
    partial class Frm_grupo
    {
        //holaaa
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
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.toolGrabar = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.toolcancelar = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            this.toolsalir = new System.Windows.Forms.ToolStripButton();
            this.toolmantenedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.toolGrabar,
            this.tooleditar,
            this.toolcancelar,
            this.tooleliminar,
            this.toolsalir});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(439, 27);
            this.toolmantenedores.TabIndex = 6;
            this.toolmantenedores.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xcodigo,
            this.xDescripcion,
            this.xestado});
            this.dataGridView1.Location = new System.Drawing.Point(11, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(402, 228);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // xcodigo
            // 
            this.xcodigo.DataPropertyName = "UnNec_iCodigo";
            this.xcodigo.HeaderText = "Codigo";
            this.xcodigo.Name = "xcodigo";
            this.xcodigo.ReadOnly = true;
            // 
            // xDescripcion
            // 
            this.xDescripcion.DataPropertyName = "UnNec_vDescripcion";
            this.xDescripcion.HeaderText = "Descripción";
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.ReadOnly = true;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "UnNegoc_bActivo";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
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
            // toolGrabar
            // 
            this.toolGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGrabar.Image = global::SGR.WinApp.Properties.Resources.guardar;
            this.toolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGrabar.Name = "toolGrabar";
            this.toolGrabar.Size = new System.Drawing.Size(24, 24);
            this.toolGrabar.Text = "Grabar";
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
            // toolcancelar
            // 
            this.toolcancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolcancelar.Image = global::SGR.WinApp.Properties.Resources.back_arrow;
            this.toolcancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolcancelar.Name = "toolcancelar";
            this.toolcancelar.Size = new System.Drawing.Size(24, 24);
            this.toolcancelar.Text = "Cancelar";
            // 
            // tooleliminar
            // 
            this.tooleliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooleliminar.Image = global::SGR.WinApp.Properties.Resources.delete;
            this.tooleliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooleliminar.Name = "tooleliminar";
            this.tooleliminar.Size = new System.Drawing.Size(24, 24);
            this.tooleliminar.Text = "Eliminar";
            this.tooleliminar.Click += new System.EventHandler(this.tooleliminar_Click);
            // 
            // toolsalir
            // 
            this.toolsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsalir.Image = global::SGR.WinApp.Properties.Resources.enter;
            this.toolsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsalir.Name = "toolsalir";
            this.toolsalir.Size = new System.Drawing.Size(24, 24);
            this.toolsalir.Text = "Salir";
            // 
            // Frm_grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 268);
            this.Controls.Add(this.toolmantenedores);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_grupo";
            this.Text = "Frm_grupo";
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton toolGrabar;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.ToolStripButton toolcancelar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.ToolStripButton toolsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xestado;
    }
}