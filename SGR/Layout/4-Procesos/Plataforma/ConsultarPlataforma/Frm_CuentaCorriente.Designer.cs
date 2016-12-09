namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    partial class Frm_CuentaCorriente
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cuenta_corriente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_tributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_opera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_anula_descarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interes_cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::SGR.WinApp.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(381, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(70, 32);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESUMEN CUENTA CORRIENTE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta_corriente_ID,
            this.persona,
            this.anio,
            this.mes,
            this.tributo,
            this.tipo_tributo,
            this.fecha_vence,
            this.estado,
            this.pendiente,
            this.pagado,
            this.deuda,
            this.fecha_cancelacion,
            this.pendiente_total,
            this.pagado_total,
            this.cargo,
            this.abono,
            this.Observaciones,
            this.activo,
            this.fecha_generacion,
            this.tipo_opera,
            this.fecha_anula_descarga,
            this.num_operacion,
            this.interes_cobrado,
            this.registro_fecha_add,
            this.registro_user_add,
            this.registro_pc_add,
            this.registro_fecha_update,
            this.registro_user_update,
            this.registro_pc_update,
            this.predio_ID,
            this.tributo_ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 267);
            this.dataGridView1.TabIndex = 3;
            // 
            // cuenta_corriente_ID
            // 
            this.cuenta_corriente_ID.DataPropertyName = "cuenta_corriente_ID";
            this.cuenta_corriente_ID.HeaderText = "Cuenta Corriente ID";
            this.cuenta_corriente_ID.Name = "cuenta_corriente_ID";
            this.cuenta_corriente_ID.ReadOnly = true;
            this.cuenta_corriente_ID.Visible = false;
            // 
            // persona
            // 
            this.persona.DataPropertyName = "persona_Id";
            this.persona.HeaderText = "persona";
            this.persona.Name = "persona";
            this.persona.ReadOnly = true;
            this.persona.Visible = false;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Periodo";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 70;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 50;
            // 
            // tributo
            // 
            this.tributo.DataPropertyName = "tributo";
            this.tributo.HeaderText = "Tributo";
            this.tributo.Name = "tributo";
            this.tributo.ReadOnly = true;
            this.tributo.Width = 150;
            // 
            // tipo_tributo
            // 
            this.tipo_tributo.DataPropertyName = "tipo_tributo";
            this.tipo_tributo.HeaderText = "Tipo Tributo";
            this.tipo_tributo.Name = "tipo_tributo";
            this.tipo_tributo.ReadOnly = true;
            // 
            // fecha_vence
            // 
            this.fecha_vence.DataPropertyName = "fecha_vence";
            this.fecha_vence.HeaderText = "Fecha Vencimiento";
            this.fecha_vence.Name = "fecha_vence";
            this.fecha_vence.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 70;
            // 
            // pendiente
            // 
            this.pendiente.DataPropertyName = "pendiente";
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            // 
            // pagado
            // 
            this.pagado.DataPropertyName = "pagado";
            this.pagado.HeaderText = "Cancelado";
            this.pagado.Name = "pagado";
            this.pagado.ReadOnly = true;
            // 
            // deuda
            // 
            this.deuda.DataPropertyName = "total";
            this.deuda.HeaderText = "Total";
            this.deuda.Name = "deuda";
            this.deuda.ReadOnly = true;
            // 
            // fecha_cancelacion
            // 
            this.fecha_cancelacion.DataPropertyName = "fecha_cancelacion";
            this.fecha_cancelacion.HeaderText = "Fecha Cancelacion";
            this.fecha_cancelacion.Name = "fecha_cancelacion";
            this.fecha_cancelacion.ReadOnly = true;
            this.fecha_cancelacion.Visible = false;
            // 
            // pendiente_total
            // 
            this.pendiente_total.DataPropertyName = "pendiente_total";
            this.pendiente_total.HeaderText = "Pendiente Total";
            this.pendiente_total.Name = "pendiente_total";
            this.pendiente_total.ReadOnly = true;
            this.pendiente_total.Visible = false;
            // 
            // pagado_total
            // 
            this.pagado_total.DataPropertyName = "pagado_total";
            this.pagado_total.HeaderText = "Pagado Total";
            this.pagado_total.Name = "pagado_total";
            this.pagado_total.ReadOnly = true;
            this.pagado_total.Visible = false;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Visible = false;
            // 
            // abono
            // 
            this.abono.DataPropertyName = "abono";
            this.abono.HeaderText = "Abono";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            this.abono.Visible = false;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Visible = false;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // fecha_generacion
            // 
            this.fecha_generacion.DataPropertyName = "fecha_generacion";
            this.fecha_generacion.HeaderText = "Fecha Generacion";
            this.fecha_generacion.Name = "fecha_generacion";
            this.fecha_generacion.ReadOnly = true;
            this.fecha_generacion.Visible = false;
            // 
            // tipo_opera
            // 
            this.tipo_opera.DataPropertyName = "tipo_opera";
            this.tipo_opera.HeaderText = "Tipo Operacion";
            this.tipo_opera.Name = "tipo_opera";
            this.tipo_opera.ReadOnly = true;
            this.tipo_opera.Visible = false;
            // 
            // fecha_anula_descarga
            // 
            this.fecha_anula_descarga.DataPropertyName = "fecha_anula_descarga";
            this.fecha_anula_descarga.HeaderText = "Fecha Anula Descarga";
            this.fecha_anula_descarga.Name = "fecha_anula_descarga";
            this.fecha_anula_descarga.ReadOnly = true;
            this.fecha_anula_descarga.Visible = false;
            // 
            // num_operacion
            // 
            this.num_operacion.DataPropertyName = "num_operacion";
            this.num_operacion.HeaderText = "Nro Operacion";
            this.num_operacion.Name = "num_operacion";
            this.num_operacion.ReadOnly = true;
            this.num_operacion.Visible = false;
            // 
            // interes_cobrado
            // 
            this.interes_cobrado.DataPropertyName = "interes_cobrado";
            this.interes_cobrado.HeaderText = "Interes Cobrado";
            this.interes_cobrado.Name = "interes_cobrado";
            this.interes_cobrado.ReadOnly = true;
            this.interes_cobrado.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "Registro Fecha Add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "Registro Usuario Add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "Registro PC Add";
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
            this.registro_user_update.HeaderText = "Registro User Update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "Registro Pc Update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // predio_ID
            // 
            this.predio_ID.DataPropertyName = "predio_ID";
            this.predio_ID.HeaderText = "Predio ID";
            this.predio_ID.Name = "predio_ID";
            this.predio_ID.ReadOnly = true;
            this.predio_ID.Visible = false;
            // 
            // tributo_ID
            // 
            this.tributo_ID.DataPropertyName = "tributo_ID";
            this.tributo_ID.HeaderText = "Tributo ID";
            this.tributo_ID.Name = "tributo_ID";
            this.tributo_ID.ReadOnly = true;
            this.tributo_ID.Visible = false;
            // 
            // Frm_CuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 357);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CuentaCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CuentaCorriente";
            this.Load += new System.EventHandler(this.Frm_CuentaCorriente_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta_corriente_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_tributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_generacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_opera;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_anula_descarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn interes_cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo_ID;
    }
}