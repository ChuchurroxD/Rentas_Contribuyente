namespace SGR.WinApp.Layout._4_Procesos.Predio.Anulacion
{
    partial class Frm_Anulacion
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
            this.dgAnulacion = new System.Windows.Forms.DataGridView();
            this.persona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anulacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributos_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributos_descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAnulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAnul_descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetaAnulacion_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCorriente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.rbtPredio = new System.Windows.Forms.RadioButton();
            this.rbtArbitrio = new System.Windows.Forms.RadioButton();
            this.rbtAmbos = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodContribuyente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.rbtFormulario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnulacion)).BeginInit();
            this.toolmantenedores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAnulacion
            // 
            this.dgAnulacion.AllowUserToAddRows = false;
            this.dgAnulacion.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAnulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAnulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persona_id,
            this.anulacion_id,
            this.predio_id,
            this.nombrePersona,
            this.tributos_id,
            this.tributos_descrip,
            this.fecha,
            this.Observacion,
            this.anioInicio,
            this.mesInicio,
            this.anioFin,
            this.mesFin,
            this.registro_fecha_add,
            this.registro_pc_add,
            this.registro_user_add,
            this.tipoAnulacion,
            this.tipoAnul_descrip,
            this.DetaAnulacion_ID,
            this.cuentaCorriente_id,
            this.montoDeuda,
            this.montoAbono,
            this.mes,
            this.anio,
            this.periodo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAnulacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAnulacion.EnableHeadersVisualStyles = false;
            this.dgAnulacion.Location = new System.Drawing.Point(0, 92);
            this.dgAnulacion.Name = "dgAnulacion";
            this.dgAnulacion.Size = new System.Drawing.Size(944, 382);
            this.dgAnulacion.TabIndex = 162;
            // 
            // persona_id
            // 
            this.persona_id.DataPropertyName = "persona_id";
            this.persona_id.HeaderText = "persona_id";
            this.persona_id.Name = "persona_id";
            this.persona_id.ReadOnly = true;
            this.persona_id.Visible = false;
            this.persona_id.Width = 30;
            // 
            // anulacion_id
            // 
            this.anulacion_id.DataPropertyName = "anulacion_id";
            this.anulacion_id.HeaderText = "Anulacion ID";
            this.anulacion_id.Name = "anulacion_id";
            this.anulacion_id.Visible = false;
            // 
            // predio_id
            // 
            this.predio_id.DataPropertyName = "predio_id";
            this.predio_id.HeaderText = "predio_id";
            this.predio_id.Name = "predio_id";
            this.predio_id.Visible = false;
            // 
            // nombrePersona
            // 
            this.nombrePersona.DataPropertyName = "nombrePersona";
            this.nombrePersona.HeaderText = "Nombre";
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.ReadOnly = true;
            this.nombrePersona.Width = 200;
            // 
            // tributos_id
            // 
            this.tributos_id.DataPropertyName = "tributos_id";
            this.tributos_id.HeaderText = "Tributo ID";
            this.tributos_id.Name = "tributos_id";
            this.tributos_id.ReadOnly = true;
            this.tributos_id.Visible = false;
            this.tributos_id.Width = 150;
            // 
            // tributos_descrip
            // 
            this.tributos_descrip.DataPropertyName = "tributos_descrip";
            this.tributos_descrip.HeaderText = "Tributo";
            this.tributos_descrip.Name = "tributos_descrip";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Visible = false;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 400;
            // 
            // anioInicio
            // 
            this.anioInicio.DataPropertyName = "anioInicio";
            this.anioInicio.HeaderText = "Año Inicio";
            this.anioInicio.Name = "anioInicio";
            this.anioInicio.ReadOnly = true;
            this.anioInicio.Width = 60;
            // 
            // mesInicio
            // 
            this.mesInicio.DataPropertyName = "mesInicio";
            this.mesInicio.HeaderText = "Mes Inicio";
            this.mesInicio.Name = "mesInicio";
            this.mesInicio.ReadOnly = true;
            this.mesInicio.Width = 40;
            // 
            // anioFin
            // 
            this.anioFin.DataPropertyName = "anioFin";
            this.anioFin.HeaderText = "Año Fin";
            this.anioFin.Name = "anioFin";
            this.anioFin.Width = 60;
            // 
            // mesFin
            // 
            this.mesFin.DataPropertyName = "mesFin";
            this.mesFin.HeaderText = "Mes Fin";
            this.mesFin.Name = "mesFin";
            this.mesFin.Width = 40;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "Fecha Add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "PC Add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.Visible = false;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "User Add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.Visible = false;
            // 
            // tipoAnulacion
            // 
            this.tipoAnulacion.DataPropertyName = "tipoAnulacion";
            this.tipoAnulacion.HeaderText = "Tipo Anulacion ID";
            this.tipoAnulacion.Name = "tipoAnulacion";
            this.tipoAnulacion.Visible = false;
            // 
            // tipoAnul_descrip
            // 
            this.tipoAnul_descrip.DataPropertyName = "tipoAnul_descrip";
            this.tipoAnul_descrip.HeaderText = "Tipo Anulacion";
            this.tipoAnul_descrip.Name = "tipoAnul_descrip";
            this.tipoAnul_descrip.Visible = false;
            // 
            // DetaAnulacion_ID
            // 
            this.DetaAnulacion_ID.DataPropertyName = "detaAnulacion_id";
            this.DetaAnulacion_ID.HeaderText = "DetaAnulacion ID";
            this.DetaAnulacion_ID.Name = "DetaAnulacion_ID";
            this.DetaAnulacion_ID.Visible = false;
            // 
            // cuentaCorriente_id
            // 
            this.cuentaCorriente_id.DataPropertyName = "cuentaCorriente_id";
            this.cuentaCorriente_id.HeaderText = "CuentaCorriente ID";
            this.cuentaCorriente_id.Name = "cuentaCorriente_id";
            this.cuentaCorriente_id.Visible = false;
            // 
            // montoDeuda
            // 
            this.montoDeuda.DataPropertyName = "montoDeuda";
            this.montoDeuda.HeaderText = "Cargo";
            this.montoDeuda.Name = "montoDeuda";
            this.montoDeuda.ReadOnly = true;
            this.montoDeuda.Visible = false;
            // 
            // montoAbono
            // 
            this.montoAbono.DataPropertyName = "montoAbono";
            this.montoAbono.HeaderText = "Abono";
            this.montoAbono.Name = "montoAbono";
            this.montoAbono.ReadOnly = true;
            this.montoAbono.Visible = false;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Visible = false;
            this.mes.Width = 90;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Visible = false;
            // 
            // periodo
            // 
            this.periodo.DataPropertyName = "periodo";
            this.periodo.HeaderText = "Periodo";
            this.periodo.Name = "periodo";
            this.periodo.Visible = false;
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(964, 27);
            this.toolmantenedores.TabIndex = 160;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(69, 18);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(148, 21);
            this.cboPeriodo.TabIndex = 3;
            // 
            // rbtPredio
            // 
            this.rbtPredio.AutoSize = true;
            this.rbtPredio.Checked = true;
            this.rbtPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPredio.Location = new System.Drawing.Point(508, 19);
            this.rbtPredio.Name = "rbtPredio";
            this.rbtPredio.Size = new System.Drawing.Size(61, 17);
            this.rbtPredio.TabIndex = 156;
            this.rbtPredio.TabStop = true;
            this.rbtPredio.Text = "Predio";
            this.rbtPredio.UseVisualStyleBackColor = true;
            // 
            // rbtArbitrio
            // 
            this.rbtArbitrio.AutoSize = true;
            this.rbtArbitrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtArbitrio.Location = new System.Drawing.Point(575, 18);
            this.rbtArbitrio.Name = "rbtArbitrio";
            this.rbtArbitrio.Size = new System.Drawing.Size(65, 17);
            this.rbtArbitrio.TabIndex = 157;
            this.rbtArbitrio.Text = "Arbitrio";
            this.rbtArbitrio.UseVisualStyleBackColor = true;
            // 
            // rbtAmbos
            // 
            this.rbtAmbos.AutoSize = true;
            this.rbtAmbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAmbos.Location = new System.Drawing.Point(646, 18);
            this.rbtAmbos.Name = "rbtAmbos";
            this.rbtAmbos.Size = new System.Drawing.Size(107, 17);
            this.rbtAmbos.TabIndex = 158;
            this.rbtAmbos.Text = "Arbitrio/Predio";
            this.rbtAmbos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 159;
            this.label3.Text = "Cod.Contribuyente";
            // 
            // txtCodContribuyente
            // 
            this.txtCodContribuyente.Location = new System.Drawing.Point(383, 16);
            this.txtCodContribuyente.Name = "txtCodContribuyente";
            this.txtCodContribuyente.Size = new System.Drawing.Size(100, 20);
            this.txtCodContribuyente.TabIndex = 160;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(849, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 163;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.rbtFormulario);
            this.groupBox1.Controls.Add(this.txtCodContribuyente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbtAmbos);
            this.groupBox1.Controls.Add(this.rbtArbitrio);
            this.groupBox1.Controls.Add(this.rbtPredio);
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(944, 58);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Búsqueda";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // rbtFormulario
            // 
            this.rbtFormulario.AutoSize = true;
            this.rbtFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFormulario.Location = new System.Drawing.Point(759, 17);
            this.rbtFormulario.Name = "rbtFormulario";
            this.rbtFormulario.Size = new System.Drawing.Size(83, 17);
            this.rbtFormulario.TabIndex = 164;
            this.rbtFormulario.Text = "Formulario";
            this.rbtFormulario.UseVisualStyleBackColor = true;
            // 
            // Frm_Anulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 486);
            this.Controls.Add(this.dgAnulacion);
            this.Controls.Add(this.toolmantenedores);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Anulacion";
            this.Text = "Anulación de Deuda";
            this.Load += new System.EventHandler(this.Frm_Anulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnulacion)).EndInit();
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgAnulacion;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn anulacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributos_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributos_descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAnulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAnul_descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetaAnulacion_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaCorriente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.RadioButton rbtPredio;
        private System.Windows.Forms.RadioButton rbtArbitrio;
        private System.Windows.Forms.RadioButton rbtAmbos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodContribuyente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton rbtFormulario;
    }
}