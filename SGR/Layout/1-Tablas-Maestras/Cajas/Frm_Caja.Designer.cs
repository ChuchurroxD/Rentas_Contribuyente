namespace SGR.WinApp.Layout._1_Tablas_Maestras.Cajas
{
    partial class Frm_Caja
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
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xCaja_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidOficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xregistro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStrip1.Size = new System.Drawing.Size(811, 27);
            this.toolStrip1.TabIndex = 5;
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
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(760, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Búsqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusqueda.Location = new System.Drawing.Point(106, 24);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.MaxLength = 100;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(277, 20);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.xCaja_id,
            this.xDescripcion,
            this.xidOficina,
            this.xtipo,
            this.xEstado,
            this.xregistro_fecha_add,
            this.xregistro_user_add,
            this.xregistro_pc_add,
            this.xregistro_fecha_update,
            this.xregistro_user_update,
            this.xregistro_pc_update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 120);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 290);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // xCaja_id
            // 
            this.xCaja_id.DataPropertyName = "Caja_id";
            this.xCaja_id.HeaderText = "ID";
            this.xCaja_id.Name = "xCaja_id";
            this.xCaja_id.ReadOnly = true;
            this.xCaja_id.Visible = false;
            this.xCaja_id.Width = 70;
            // 
            // xDescripcion
            // 
            this.xDescripcion.DataPropertyName = "descripcion";
            this.xDescripcion.HeaderText = "Descripción";
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.ReadOnly = true;
            this.xDescripcion.Width = 300;
            // 
            // xidOficina
            // 
            this.xidOficina.DataPropertyName = "idOficina";
            this.xidOficina.HeaderText = "IdOficina";
            this.xidOficina.Name = "xidOficina";
            this.xidOficina.ReadOnly = true;
            this.xidOficina.Visible = false;
            this.xidOficina.Width = 70;
            // 
            // xtipo
            // 
            this.xtipo.DataPropertyName = "tipo";
            this.xtipo.HeaderText = "Tipo Oficina";
            this.xtipo.Name = "xtipo";
            this.xtipo.ReadOnly = true;
            this.xtipo.Width = 200;
            // 
            // xEstado
            // 
            this.xEstado.DataPropertyName = "estado";
            this.xEstado.HeaderText = "Estado";
            this.xEstado.Name = "xEstado";
            this.xEstado.ReadOnly = true;
            this.xEstado.Width = 70;
            // 
            // xregistro_fecha_add
            // 
            this.xregistro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.xregistro_fecha_add.HeaderText = "Fecha Creada";
            this.xregistro_fecha_add.Name = "xregistro_fecha_add";
            this.xregistro_fecha_add.ReadOnly = true;
            this.xregistro_fecha_add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xregistro_fecha_add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xregistro_fecha_add.Visible = false;
            // 
            // xregistro_user_add
            // 
            this.xregistro_user_add.DataPropertyName = "registro_user_add";
            this.xregistro_user_add.HeaderText = "Registro Usuario";
            this.xregistro_user_add.Name = "xregistro_user_add";
            this.xregistro_user_add.ReadOnly = true;
            this.xregistro_user_add.Visible = false;
            // 
            // xregistro_pc_add
            // 
            this.xregistro_pc_add.DataPropertyName = "registro_pc_add";
            this.xregistro_pc_add.HeaderText = "Registro PC";
            this.xregistro_pc_add.Name = "xregistro_pc_add";
            this.xregistro_pc_add.ReadOnly = true;
            this.xregistro_pc_add.Visible = false;
            // 
            // xregistro_fecha_update
            // 
            this.xregistro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.xregistro_fecha_update.HeaderText = "Fecha Modificación";
            this.xregistro_fecha_update.Name = "xregistro_fecha_update";
            this.xregistro_fecha_update.ReadOnly = true;
            this.xregistro_fecha_update.Visible = false;
            // 
            // xregistro_user_update
            // 
            this.xregistro_user_update.DataPropertyName = "registro_user_update";
            this.xregistro_user_update.HeaderText = "Usuario Update";
            this.xregistro_user_update.Name = "xregistro_user_update";
            this.xregistro_user_update.ReadOnly = true;
            this.xregistro_user_update.Visible = false;
            // 
            // xregistro_pc_update
            // 
            this.xregistro_pc_update.DataPropertyName = "registro_pc_update";
            this.xregistro_pc_update.HeaderText = "PC Update";
            this.xregistro_pc_update.Name = "xregistro_pc_update";
            this.xregistro_pc_update.ReadOnly = true;
            this.xregistro_pc_update.Visible = false;
            // 
            // Frm_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Caja";
            this.Text = "Gestionar Caja";
            this.Load += new System.EventHandler(this.Frm_Caja_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn xCaja_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidOficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_update;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
    }
}