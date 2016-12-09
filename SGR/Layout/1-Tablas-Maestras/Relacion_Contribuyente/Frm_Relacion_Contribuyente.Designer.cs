namespace SGR.WinApp.Layout._1_Tablas_Maestras.Relacion_Contribuyente
{
    partial class Frm_Relacion_Contribuyente
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
            this.dgvRelCOntribuyente = new System.Windows.Forms.DataGridView();
            this.relacion_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_allegado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_relacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_relacion_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPersona = new System.Windows.Forms.Label();
            this.toolmantenedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelCOntribuyente)).BeginInit();
            this.SuspendLayout();
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleditar,
            this.tooleliminar});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(694, 27);
            this.toolmantenedores.TabIndex = 8;
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
            // dgvRelCOntribuyente
            // 
            this.dgvRelCOntribuyente.AllowUserToAddRows = false;
            this.dgvRelCOntribuyente.AllowUserToDeleteRows = false;
            this.dgvRelCOntribuyente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelCOntribuyente.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelCOntribuyente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelCOntribuyente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelCOntribuyente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.relacion_ID,
            this.cod_allegado,
            this.razon_social,
            this.ruc,
            this.tipo_relacion,
            this.tipo_relacion_descripcion,
            this.persona_ID,
            this.Estado,
            this.registro_user_add,
            this.registro_fecha_add,
            this.registro_pc_add,
            this.registro_user_update,
            this.registro_fecha_update,
            this.registro_pc_update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelCOntribuyente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelCOntribuyente.EnableHeadersVisualStyles = false;
            this.dgvRelCOntribuyente.Location = new System.Drawing.Point(5, 48);
            this.dgvRelCOntribuyente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRelCOntribuyente.MultiSelect = false;
            this.dgvRelCOntribuyente.Name = "dgvRelCOntribuyente";
            this.dgvRelCOntribuyente.ReadOnly = true;
            this.dgvRelCOntribuyente.RowHeadersVisible = false;
            this.dgvRelCOntribuyente.RowTemplate.Height = 24;
            this.dgvRelCOntribuyente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelCOntribuyente.Size = new System.Drawing.Size(678, 263);
            this.dgvRelCOntribuyente.TabIndex = 13;
            this.dgvRelCOntribuyente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelCOntribuyente_CellContentDoubleClick);
            // 
            // relacion_ID
            // 
            this.relacion_ID.DataPropertyName = "relacion_ID";
            this.relacion_ID.HeaderText = "Código";
            this.relacion_ID.Name = "relacion_ID";
            this.relacion_ID.ReadOnly = true;
            this.relacion_ID.Width = 60;
            // 
            // cod_allegado
            // 
            this.cod_allegado.DataPropertyName = "cod_allegado";
            this.cod_allegado.HeaderText = "Observación";
            this.cod_allegado.Name = "cod_allegado";
            this.cod_allegado.ReadOnly = true;
            this.cod_allegado.Visible = false;
            this.cod_allegado.Width = 300;
            // 
            // razon_social
            // 
            this.razon_social.DataPropertyName = "razon_social";
            this.razon_social.HeaderText = "Persona";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 280;
            // 
            // ruc
            // 
            this.ruc.DataPropertyName = "ruc";
            this.ruc.HeaderText = "Documento";
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            // 
            // tipo_relacion
            // 
            this.tipo_relacion.DataPropertyName = "tipo_relacion";
            this.tipo_relacion.HeaderText = "tipo_relacion";
            this.tipo_relacion.Name = "tipo_relacion";
            this.tipo_relacion.ReadOnly = true;
            this.tipo_relacion.Visible = false;
            this.tipo_relacion.Width = 70;
            // 
            // tipo_relacion_descripcion
            // 
            this.tipo_relacion_descripcion.DataPropertyName = "tipo_relacion_descripcion";
            this.tipo_relacion_descripcion.HeaderText = "Tipo de Relaciòn";
            this.tipo_relacion_descripcion.Name = "tipo_relacion_descripcion";
            this.tipo_relacion_descripcion.ReadOnly = true;
            this.tipo_relacion_descripcion.Width = 150;
            // 
            // persona_ID
            // 
            this.persona_ID.DataPropertyName = "persona_ID";
            this.persona_ID.HeaderText = "persona_ID";
            this.persona_ID.Name = "persona_ID";
            this.persona_ID.ReadOnly = true;
            this.persona_ID.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 50;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "registro_user_add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "registro_fecha_add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "registro_pc_add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "registro_fecha_update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "registro_pc_update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(54, 30);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(47, 15);
            this.lblPersona.TabIndex = 14;
            this.lblPersona.Text = "label1";
            // 
            // Frm_Relacion_Contribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(694, 322);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.dgvRelCOntribuyente);
            this.Controls.Add(this.toolmantenedores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Relacion_Contribuyente";
            this.Text = "Rel.Contribuyente";
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelCOntribuyente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.DataGridView dgvRelCOntribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn relacion_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_allegado;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_relacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_relacion_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.Label lblPersona;
    }
}