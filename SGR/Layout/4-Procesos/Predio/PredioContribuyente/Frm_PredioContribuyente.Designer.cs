namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioContribuyente
{
    partial class Frm_PredioContribuyente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.predio_contribuyente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Condomino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExonAutoValuo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AnioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adq_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_posesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolmantenedores.SuspendLayout();
            this.SuspendLayout();
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
            this.predio_contribuyente_id,
            this.idPeriodo,
            this.Fecha,
            this.Porcentaje_Condomino,
            this.ExonAutoValuo,
            this.AnioCompra,
            this.Predio_id,
            this.persona_ID,
            this.tipo_adquisicion,
            this.adq_descripcion,
            this.tipo_posesion,
            this.expediente,
            this.observaciones,
            this.Estado,
            this.registro_user_add,
            this.registro_fecha_add,
            this.registro_pc_add,
            this.registro_user_update,
            this.registro_fecha_update,
            this.registro_pc_update});
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 300);
            this.dataGridView1.TabIndex = 12;
            // 
            // predio_contribuyente_id
            // 
            this.predio_contribuyente_id.DataPropertyName = "predio_contribuyente_id";
            this.predio_contribuyente_id.HeaderText = "Código";
            this.predio_contribuyente_id.Name = "predio_contribuyente_id";
            this.predio_contribuyente_id.ReadOnly = true;
            this.predio_contribuyente_id.Width = 60;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.ReadOnly = true;
            this.idPeriodo.Width = 300;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 60;
            // 
            // Porcentaje_Condomino
            // 
            this.Porcentaje_Condomino.DataPropertyName = "Porcentaje_Condomino";
            this.Porcentaje_Condomino.HeaderText = "Porcentaje_Condomino";
            this.Porcentaje_Condomino.Name = "Porcentaje_Condomino";
            this.Porcentaje_Condomino.ReadOnly = true;
            this.Porcentaje_Condomino.Width = 60;
            // 
            // ExonAutoValuo
            // 
            this.ExonAutoValuo.DataPropertyName = "ExonAutoValuo";
            this.ExonAutoValuo.HeaderText = "ExonAutoValuo";
            this.ExonAutoValuo.Name = "ExonAutoValuo";
            this.ExonAutoValuo.ReadOnly = true;
            this.ExonAutoValuo.Visible = false;
            this.ExonAutoValuo.Width = 70;
            // 
            // AnioCompra
            // 
            this.AnioCompra.DataPropertyName = "AnioCompra";
            this.AnioCompra.HeaderText = "AnioCompra";
            this.AnioCompra.Name = "AnioCompra";
            this.AnioCompra.ReadOnly = true;
            this.AnioCompra.Width = 200;
            // 
            // Predio_id
            // 
            this.Predio_id.DataPropertyName = "Predio_id";
            this.Predio_id.HeaderText = "Predio_id";
            this.Predio_id.Name = "Predio_id";
            this.Predio_id.ReadOnly = true;
            // 
            // persona_ID
            // 
            this.persona_ID.DataPropertyName = "persona_ID";
            this.persona_ID.HeaderText = "persona_ID";
            this.persona_ID.Name = "persona_ID";
            this.persona_ID.ReadOnly = true;
            // 
            // tipo_adquisicion
            // 
            this.tipo_adquisicion.DataPropertyName = "tipo_adquisicion";
            this.tipo_adquisicion.HeaderText = "tipo_adquisicion";
            this.tipo_adquisicion.Name = "tipo_adquisicion";
            this.tipo_adquisicion.ReadOnly = true;
            // 
            // adq_descripcion
            // 
            this.adq_descripcion.DataPropertyName = "adq_descripcion";
            this.adq_descripcion.HeaderText = "adq_descripcion";
            this.adq_descripcion.Name = "adq_descripcion";
            this.adq_descripcion.ReadOnly = true;
            // 
            // tipo_posesion
            // 
            this.tipo_posesion.DataPropertyName = "tipo_posesion";
            this.tipo_posesion.HeaderText = "tipo_posesion";
            this.tipo_posesion.Name = "tipo_posesion";
            this.tipo_posesion.ReadOnly = true;
            // 
            // expediente
            // 
            this.expediente.DataPropertyName = "expediente";
            this.expediente.HeaderText = "expediente";
            this.expediente.Name = "expediente";
            this.expediente.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
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
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleditar,
            this.tooleliminar});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(1027, 27);
            this.toolmantenedores.TabIndex = 11;
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
            // 
            // Frm_PredioContribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolmantenedores);
            this.Name = "Frm_PredioContribuyente";
            this.Text = "Detalle de Contribuyente en Predios";
            this.Load += new System.EventHandler(this.Frm_PredioContribuyente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_contribuyente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Condomino;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExonAutoValuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn adq_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_posesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
    }
}