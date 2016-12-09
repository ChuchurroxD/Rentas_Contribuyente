namespace SGR.WinApp.Layout._1_Tablas_Maestras.Junta_Via
{
    partial class Frm_Junta_Via
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
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.toolCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionSector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.junta_via_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junta_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.via_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.via_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(650, 27);
            this.toolStrip1.TabIndex = 6;
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
            this.toolCancelar.Click += new System.EventHandler(this.toolCancelar_Click);
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtDescripcionSector);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Búsqueda";
            // 
            // txtDescripcionSector
            // 
            this.txtDescripcionSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionSector.Location = new System.Drawing.Point(111, 33);
            this.txtDescripcionSector.MaxLength = 100;
            this.txtDescripcionSector.Name = "txtDescripcionSector";
            this.txtDescripcionSector.Size = new System.Drawing.Size(271, 20);
            this.txtDescripcionSector.TabIndex = 1;
            this.txtDescripcionSector.TextChanged += new System.EventHandler(this.txtDescripcionSector_TextChanged);
            this.txtDescripcionSector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionSector_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.junta_via_ID,
            this.junta_ID,
            this.via_ID,
            this.registro_fecha_add,
            this.registro_user_add,
            this.registro_pc_add,
            this.registro_fecha_update,
            this.registro_user_update,
            this.registro_pc_update,
            this.descripcion_sector,
            this.via_descripcion,
            this.estado});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 228);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // junta_via_ID
            // 
            this.junta_via_ID.DataPropertyName = "junta_via_ID";
            this.junta_via_ID.HeaderText = "Junta Via ID";
            this.junta_via_ID.Name = "junta_via_ID";
            this.junta_via_ID.ReadOnly = true;
            this.junta_via_ID.Width = 120;
            // 
            // junta_ID
            // 
            this.junta_ID.DataPropertyName = "junta_ID";
            this.junta_ID.HeaderText = "Junta ID";
            this.junta_ID.Name = "junta_ID";
            this.junta_ID.ReadOnly = true;
            this.junta_ID.Visible = false;
            // 
            // via_ID
            // 
            this.via_ID.DataPropertyName = "via_ID";
            this.via_ID.HeaderText = "Via ID";
            this.via_ID.Name = "via_ID";
            this.via_ID.ReadOnly = true;
            this.via_ID.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "Registro Fecha Creada";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "Registro Usuario Crear";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "Registro PC crear";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "Registro Fecha Update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "Registro usuario Update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "Registro PC Update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // descripcion_sector
            // 
            this.descripcion_sector.DataPropertyName = "descripcion_sector";
            this.descripcion_sector.HeaderText = "Sector";
            this.descripcion_sector.Name = "descripcion_sector";
            this.descripcion_sector.ReadOnly = true;
            this.descripcion_sector.Width = 170;
            // 
            // via_descripcion
            // 
            this.via_descripcion.DataPropertyName = "via_descripcion";
            this.via_descripcion.HeaderText = "Vía";
            this.via_descripcion.Name = "via_descripcion";
            this.via_descripcion.ReadOnly = true;
            this.via_descripcion.Width = 200;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 70;
            // 
            // Frm_Junta_Via
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Junta_Via";
            this.Text = "Gestionar Junta Via";
            this.Load += new System.EventHandler(this.Frm_Junta_Via_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcionSector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn junta_via_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn junta_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn via_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn via_descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
    }
}