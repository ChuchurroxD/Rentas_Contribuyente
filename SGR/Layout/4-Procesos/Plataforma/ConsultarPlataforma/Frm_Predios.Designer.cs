namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    partial class Frm_Predios
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Predio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_contribuyente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Condominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_posesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_predios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto_Anual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuota_Trimestral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExonAutoValuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.Predio_id,
            this.predio_contribuyente_id,
            this.razon_social,
            this.Porcentaje_Condominio,
            this.adquisicion,
            this.posesion,
            this.tipo_adquisicion,
            this.tipo_posesion,
            this.expediente,
            this.observaciones,
            this.registro_fecha_add,
            this.registro_user_add,
            this.registro_pc_add,
            this.registro_fecha_update,
            this.registro_user_update,
            this.registro_pc_update,
            this.total_predios,
            this.impuesto_Anual,
            this.idpersona,
            this.cuota_Trimestral,
            this.idPeriodo,
            this.fecha,
            this.ExonAutoValuo,
            this.AnioCompra,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(874, 340);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.cboPeriodo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 63);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Predios";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(79, 26);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo.TabIndex = 11;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Año:";
            // 
            // Predio_id
            // 
            this.Predio_id.DataPropertyName = "Predio_id";
            this.Predio_id.HeaderText = "Código";
            this.Predio_id.Name = "Predio_id";
            this.Predio_id.ReadOnly = true;
            // 
            // predio_contribuyente_id
            // 
            this.predio_contribuyente_id.DataPropertyName = "predio_contribuyente_id";
            this.predio_contribuyente_id.HeaderText = "Predio Contribuyente";
            this.predio_contribuyente_id.Name = "predio_contribuyente_id";
            this.predio_contribuyente_id.ReadOnly = true;
            this.predio_contribuyente_id.Visible = false;
            this.predio_contribuyente_id.Width = 70;
            // 
            // razon_social
            // 
            this.razon_social.DataPropertyName = "razon_social";
            this.razon_social.HeaderText = "Ubicación";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 330;
            // 
            // Porcentaje_Condominio
            // 
            this.Porcentaje_Condominio.DataPropertyName = "Porcentaje_Condomino";
            this.Porcentaje_Condominio.HeaderText = "Condominio %";
            this.Porcentaje_Condominio.Name = "Porcentaje_Condominio";
            this.Porcentaje_Condominio.ReadOnly = true;
            this.Porcentaje_Condominio.Width = 120;
            // 
            // adquisicion
            // 
            this.adquisicion.DataPropertyName = "adq_descripcion";
            this.adquisicion.HeaderText = "Adquisición";
            this.adquisicion.Name = "adquisicion";
            this.adquisicion.ReadOnly = true;
            this.adquisicion.Width = 125;
            // 
            // posesion
            // 
            this.posesion.DataPropertyName = "pose_descripcion";
            this.posesion.HeaderText = "Posesión";
            this.posesion.Name = "posesion";
            this.posesion.ReadOnly = true;
            this.posesion.Width = 125;
            // 
            // tipo_adquisicion
            // 
            this.tipo_adquisicion.DataPropertyName = "tipo_adquisicion";
            this.tipo_adquisicion.HeaderText = "tipo Adquisicion";
            this.tipo_adquisicion.Name = "tipo_adquisicion";
            this.tipo_adquisicion.ReadOnly = true;
            this.tipo_adquisicion.Visible = false;
            // 
            // tipo_posesion
            // 
            this.tipo_posesion.DataPropertyName = "tipo_posesion";
            this.tipo_posesion.HeaderText = "tipo posesion";
            this.tipo_posesion.Name = "tipo_posesion";
            this.tipo_posesion.ReadOnly = true;
            this.tipo_posesion.Visible = false;
            // 
            // expediente
            // 
            this.expediente.DataPropertyName = "expediente";
            this.expediente.HeaderText = "expediente";
            this.expediente.Name = "expediente";
            this.expediente.ReadOnly = true;
            this.expediente.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "registro_fech_add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "registro_user_add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "registro_pc_add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "registro_fecha_update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "registro_pc_update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // total_predios
            // 
            this.total_predios.DataPropertyName = "total_predios";
            this.total_predios.HeaderText = "total predios";
            this.total_predios.Name = "total_predios";
            this.total_predios.ReadOnly = true;
            this.total_predios.Visible = false;
            // 
            // impuesto_Anual
            // 
            this.impuesto_Anual.DataPropertyName = "impuesto_Anual";
            this.impuesto_Anual.HeaderText = "Impuesto Anual";
            this.impuesto_Anual.Name = "impuesto_Anual";
            this.impuesto_Anual.ReadOnly = true;
            this.impuesto_Anual.Visible = false;
            // 
            // idpersona
            // 
            this.idpersona.DataPropertyName = "persona_ID";
            this.idpersona.HeaderText = "codigo persona";
            this.idpersona.Name = "idpersona";
            this.idpersona.ReadOnly = true;
            this.idpersona.Visible = false;
            // 
            // cuota_Trimestral
            // 
            this.cuota_Trimestral.DataPropertyName = "cuota_Trimestral";
            this.cuota_Trimestral.HeaderText = "cuota_Trimestral";
            this.cuota_Trimestral.Name = "cuota_Trimestral";
            this.cuota_Trimestral.ReadOnly = true;
            this.cuota_Trimestral.Visible = false;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.ReadOnly = true;
            this.idPeriodo.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            // 
            // ExonAutoValuo
            // 
            this.ExonAutoValuo.DataPropertyName = "ExonAutoValuo";
            this.ExonAutoValuo.HeaderText = "Exoneracion autoevaluo";
            this.ExonAutoValuo.Name = "ExonAutoValuo";
            this.ExonAutoValuo.ReadOnly = true;
            this.ExonAutoValuo.Visible = false;
            // 
            // AnioCompra
            // 
            this.AnioCompra.DataPropertyName = "AnioCompra";
            this.AnioCompra.HeaderText = "Anio compra";
            this.AnioCompra.Name = "AnioCompra";
            this.AnioCompra.ReadOnly = true;
            this.AnioCompra.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Activo";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 70;
            // 
            // Frm_Predios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Predios";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_contribuyente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Condominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn posesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_posesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_predios;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto_Anual;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota_Trimestral;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExonAutoValuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCompra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
    }
}