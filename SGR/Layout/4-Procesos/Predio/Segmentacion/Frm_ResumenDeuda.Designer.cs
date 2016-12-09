namespace SGR.WinApp.Layout._4_Procesos.Predio.Segmentacion
{
    partial class Frm_ResumenDeuda
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtPendientes = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cboMesFin = new System.Windows.Forms.ComboBox();
            this.cboAnioFin = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboMesIni = new System.Windows.Forms.ComboBox();
            this.cboAnioIni = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvResumenDeuda = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_completa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEUDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interes_cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenDeuda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.btnCargar);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.rbtPendientes);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cboMesFin);
            this.groupBox4.Controls.Add(this.cboAnioFin);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cboMesIni);
            this.groupBox4.Controls.Add(this.cboAnioIni);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtPersona);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(8, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(943, 85);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opcciones de Búsqueda";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Image = global::SGR.WinApp.Properties.Resources.search;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(387, 20);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(119, 26);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(543, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(264, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Todos";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(168, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Pagados";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtPendientes
            // 
            this.rbtPendientes.AutoSize = true;
            this.rbtPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPendientes.Location = new System.Drawing.Point(10, 24);
            this.rbtPendientes.Name = "rbtPendientes";
            this.rbtPendientes.Size = new System.Drawing.Size(139, 17);
            this.rbtPendientes.TabIndex = 16;
            this.rbtPendientes.Text = "Pendientes de Pago";
            this.rbtPendientes.UseVisualStyleBackColor = true;
            this.rbtPendientes.CheckedChanged += new System.EventHandler(this.rbtPendientes_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(473, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "----";
            // 
            // cboMesFin
            // 
            this.cboMesFin.FormattingEnabled = true;
            this.cboMesFin.Location = new System.Drawing.Point(493, 52);
            this.cboMesFin.Name = "cboMesFin";
            this.cboMesFin.Size = new System.Drawing.Size(86, 21);
            this.cboMesFin.TabIndex = 14;
            // 
            // cboAnioFin
            // 
            this.cboAnioFin.FormattingEnabled = true;
            this.cboAnioFin.Location = new System.Drawing.Point(387, 52);
            this.cboAnioFin.Name = "cboAnioFin";
            this.cboAnioFin.Size = new System.Drawing.Size(86, 21);
            this.cboAnioFin.TabIndex = 13;
            this.cboAnioFin.SelectedIndexChanged += new System.EventHandler(this.cboAnioFin_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(305, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Periodo Final:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(187, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "----";
            // 
            // cboMesIni
            // 
            this.cboMesIni.FormattingEnabled = true;
            this.cboMesIni.Location = new System.Drawing.Point(207, 51);
            this.cboMesIni.Name = "cboMesIni";
            this.cboMesIni.Size = new System.Drawing.Size(86, 21);
            this.cboMesIni.TabIndex = 10;
            this.cboMesIni.SelectedIndexChanged += new System.EventHandler(this.cboMesIni_SelectedIndexChanged);
            // 
            // cboAnioIni
            // 
            this.cboAnioIni.FormattingEnabled = true;
            this.cboAnioIni.Location = new System.Drawing.Point(101, 51);
            this.cboAnioIni.Name = "cboAnioIni";
            this.cboAnioIni.Size = new System.Drawing.Size(86, 21);
            this.cboAnioIni.TabIndex = 9;
            this.cboAnioIni.SelectedIndexChanged += new System.EventHandler(this.cboAnioIni_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(8, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Periodo Inicial:";
            // 
            // txtPersona
            // 
            this.txtPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPersona.Location = new System.Drawing.Point(666, 50);
            this.txtPersona.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(253, 20);
            this.txtPersona.TabIndex = 2;
            this.txtPersona.TextChanged += new System.EventHandler(this.txtPersona_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(609, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Persona";
            // 
            // dgvResumenDeuda
            // 
            this.dgvResumenDeuda.AllowUserToAddRows = false;
            this.dgvResumenDeuda.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumenDeuda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResumenDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenDeuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.persona_ID,
            this.predio_ID,
            this.direccion_completa,
            this.tributo,
            this.anio,
            this.mes,
            this.cargo,
            this.ABONO,
            this.DEUDA,
            this.interes_cobrado,
            this.OBSERVACIONES,
            this.fecha_vence,
            this.registro_fecha_add,
            this.registro_user_add,
            this.registro_pc_add,
            this.registro_fecha_update,
            this.registro_user_update,
            this.registro_pc_update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumenDeuda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResumenDeuda.EnableHeadersVisualStyles = false;
            this.dgvResumenDeuda.Location = new System.Drawing.Point(8, 97);
            this.dgvResumenDeuda.Name = "dgvResumenDeuda";
            this.dgvResumenDeuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumenDeuda.Size = new System.Drawing.Size(943, 328);
            this.dgvResumenDeuda.TabIndex = 15;
            this.dgvResumenDeuda.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResumenDeuda_ColumnHeaderMouseClick);
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 200;
            // 
            // persona_ID
            // 
            this.persona_ID.DataPropertyName = "persona_ID";
            this.persona_ID.HeaderText = "persona_ID";
            this.persona_ID.Name = "persona_ID";
            this.persona_ID.ReadOnly = true;
            this.persona_ID.Visible = false;
            // 
            // predio_ID
            // 
            this.predio_ID.DataPropertyName = "predio_ID";
            this.predio_ID.HeaderText = "predio ID";
            this.predio_ID.Name = "predio_ID";
            this.predio_ID.ReadOnly = true;
            // 
            // direccion_completa
            // 
            this.direccion_completa.DataPropertyName = "direccion_completa";
            this.direccion_completa.HeaderText = "Dirección. completa";
            this.direccion_completa.Name = "direccion_completa";
            this.direccion_completa.ReadOnly = true;
            this.direccion_completa.Width = 200;
            // 
            // tributo
            // 
            this.tributo.DataPropertyName = "tributo";
            this.tributo.HeaderText = "Tributo";
            this.tributo.Name = "tributo";
            this.tributo.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 40;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 40;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 70;
            // 
            // ABONO
            // 
            this.ABONO.DataPropertyName = "ABONO";
            this.ABONO.HeaderText = "Abono";
            this.ABONO.Name = "ABONO";
            this.ABONO.ReadOnly = true;
            this.ABONO.Width = 70;
            // 
            // DEUDA
            // 
            this.DEUDA.DataPropertyName = "DEUDA";
            this.DEUDA.HeaderText = "Deuda";
            this.DEUDA.Name = "DEUDA";
            this.DEUDA.ReadOnly = true;
            this.DEUDA.Width = 70;
            // 
            // interes_cobrado
            // 
            this.interes_cobrado.DataPropertyName = "interes_cobrado";
            this.interes_cobrado.HeaderText = "Interes";
            this.interes_cobrado.Name = "interes_cobrado";
            this.interes_cobrado.ReadOnly = true;
            // 
            // OBSERVACIONES
            // 
            this.OBSERVACIONES.DataPropertyName = "OBSERVACIONES";
            this.OBSERVACIONES.HeaderText = "Observación";
            this.OBSERVACIONES.Name = "OBSERVACIONES";
            this.OBSERVACIONES.ReadOnly = true;
            // 
            // fecha_vence
            // 
            this.fecha_vence.DataPropertyName = "fecha_vence";
            this.fecha_vence.HeaderText = "Fecha Vencim.";
            this.fecha_vence.Name = "fecha_vence";
            this.fecha_vence.ReadOnly = true;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "registro_fecha_add";
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
            // Frm_ResumenDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(965, 459);
            this.Controls.Add(this.dgvResumenDeuda);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ResumenDeuda";
            this.Text = "Resumen de Deuda";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenDeuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboMesFin;
        private System.Windows.Forms.ComboBox cboAnioFin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboMesIni;
        private System.Windows.Forms.ComboBox cboAnioIni;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvResumenDeuda;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtPendientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_completa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEUDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn interes_cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.Button btnCargar;
    }
}