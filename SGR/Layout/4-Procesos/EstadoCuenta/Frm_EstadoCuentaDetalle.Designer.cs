namespace SGR.WinApp.Layout._4_Procesos.EstadoCuenta
{
    partial class Frm_EstadoCuentaDetalle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPredio = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.chkPredio = new System.Windows.Forms.CheckBox();
            this.chkAlcabala = new System.Windows.Forms.CheckBox();
            this.chkArbitrio = new System.Windows.Forms.CheckBox();
            this.chkFormulario = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPedienteT = new System.Windows.Forms.Label();
            this.lblCanceladoT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cuenta_corriente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboPredio);
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cboPeriodo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblDocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contribuyente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 187;
            this.label9.Text = "Predio:";
            // 
            // cboPredio
            // 
            this.cboPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPredio.FormattingEnabled = true;
            this.cboPredio.Location = new System.Drawing.Point(87, 123);
            this.cboPredio.Name = "cboPredio";
            this.cboPredio.Size = new System.Drawing.Size(408, 21);
            this.cboPredio.TabIndex = 186;
            this.cboPredio.SelectedIndexChanged += new System.EventHandler(this.cboPredio_SelectedIndexChanged);
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(689, 113);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(155, 41);
            this.btnReporte.TabIndex = 19;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTodos);
            this.groupBox2.Controls.Add(this.chkPredio);
            this.groupBox2.Controls.Add(this.chkAlcabala);
            this.groupBox2.Controls.Add(this.chkArbitrio);
            this.groupBox2.Controls.Add(this.chkFormulario);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(431, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 64);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tributo:";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(343, 26);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 18;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // chkPredio
            // 
            this.chkPredio.AutoSize = true;
            this.chkPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPredio.Location = new System.Drawing.Point(29, 26);
            this.chkPredio.Name = "chkPredio";
            this.chkPredio.Size = new System.Drawing.Size(81, 17);
            this.chkPredio.TabIndex = 14;
            this.chkPredio.Text = "Imp. Predial";
            this.chkPredio.UseVisualStyleBackColor = true;
            this.chkPredio.CheckedChanged += new System.EventHandler(this.chkPredio_CheckedChanged);
            // 
            // chkAlcabala
            // 
            this.chkAlcabala.AutoSize = true;
            this.chkAlcabala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlcabala.Location = new System.Drawing.Point(270, 26);
            this.chkAlcabala.Name = "chkAlcabala";
            this.chkAlcabala.Size = new System.Drawing.Size(67, 17);
            this.chkAlcabala.TabIndex = 17;
            this.chkAlcabala.Text = "Alcabala";
            this.chkAlcabala.UseVisualStyleBackColor = true;
            this.chkAlcabala.CheckedChanged += new System.EventHandler(this.chkAlcabala_CheckedChanged);
            // 
            // chkArbitrio
            // 
            this.chkArbitrio.AutoSize = true;
            this.chkArbitrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArbitrio.Location = new System.Drawing.Point(116, 26);
            this.chkArbitrio.Name = "chkArbitrio";
            this.chkArbitrio.Size = new System.Drawing.Size(63, 17);
            this.chkArbitrio.TabIndex = 15;
            this.chkArbitrio.Text = "Arbitrios";
            this.chkArbitrio.UseVisualStyleBackColor = true;
            this.chkArbitrio.CheckedChanged += new System.EventHandler(this.chkArbitrio_CheckedChanged);
            // 
            // chkFormulario
            // 
            this.chkFormulario.AutoSize = true;
            this.chkFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormulario.Location = new System.Drawing.Point(185, 26);
            this.chkFormulario.Name = "chkFormulario";
            this.chkFormulario.Size = new System.Drawing.Size(79, 17);
            this.chkFormulario.TabIndex = 16;
            this.chkFormulario.Text = "Formularios";
            this.chkFormulario.UseVisualStyleBackColor = true;
            this.chkFormulario.CheckedChanged += new System.EventHandler(this.chkFormulario_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(524, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Incluir Cancelados";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(87, 85);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(136, 21);
            this.cboPeriodo.TabIndex = 10;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Periodo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(171, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 18);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "             ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Completo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(519, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(88, 18);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "                    ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(130, 16);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(60, 18);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "             ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento:";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta_corriente_ID,
            this.anio,
            this.mes,
            this.tributo,
            this.predio_ID1,
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
            this.persona_ID,
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 242);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pendiente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cancelado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total:";
            // 
            // lblPedienteT
            // 
            this.lblPedienteT.AutoSize = true;
            this.lblPedienteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedienteT.Location = new System.Drawing.Point(625, 423);
            this.lblPedienteT.Name = "lblPedienteT";
            this.lblPedienteT.Size = new System.Drawing.Size(80, 17);
            this.lblPedienteT.TabIndex = 5;
            this.lblPedienteT.Text = "pendiente";
            // 
            // lblCanceladoT
            // 
            this.lblCanceladoT.AutoSize = true;
            this.lblCanceladoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceladoT.Location = new System.Drawing.Point(625, 449);
            this.lblCanceladoT.Name = "lblCanceladoT";
            this.lblCanceladoT.Size = new System.Drawing.Size(82, 17);
            this.lblCanceladoT.TabIndex = 6;
            this.lblCanceladoT.Text = "cancelado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(625, 476);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "total";
            // 
            // cuenta_corriente_ID
            // 
            this.cuenta_corriente_ID.DataPropertyName = "cuenta_corriente_ID";
            this.cuenta_corriente_ID.HeaderText = "Cuenta Corriente ID";
            this.cuenta_corriente_ID.Name = "cuenta_corriente_ID";
            this.cuenta_corriente_ID.ReadOnly = true;
            this.cuenta_corriente_ID.Visible = false;
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
            // predio_ID1
            // 
            this.predio_ID1.DataPropertyName = "predio_ID";
            this.predio_ID1.HeaderText = "Predio ID";
            this.predio_ID1.Name = "predio_ID1";
            this.predio_ID1.ReadOnly = true;
            // 
            // tipo_tributo
            // 
            this.tipo_tributo.DataPropertyName = "tipo_tributo";
            this.tipo_tributo.HeaderText = "Tipo Tributo";
            this.tipo_tributo.Name = "tipo_tributo";
            this.tipo_tributo.ReadOnly = true;
            this.tipo_tributo.Visible = false;
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
            // persona_ID
            // 
            this.persona_ID.DataPropertyName = "persona_ID";
            this.persona_ID.HeaderText = "Persona ID";
            this.persona_ID.Name = "persona_ID";
            this.persona_ID.ReadOnly = true;
            this.persona_ID.Visible = false;
            // 
            // tributo_ID
            // 
            this.tributo_ID.DataPropertyName = "tributo_ID";
            this.tributo_ID.HeaderText = "Tributo ID";
            this.tributo_ID.Name = "tributo_ID";
            this.tributo_ID.ReadOnly = true;
            this.tributo_ID.Visible = false;
            // 
            // Frm_EstadoCuentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 502);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCanceladoT);
            this.Controls.Add(this.lblPedienteT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EstadoCuentaDetalle";
            this.Text = "Frm_EstadoCuentaDetalle";
            this.Load += new System.EventHandler(this.Frm_EstadoCuentaDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPedienteT;
        private System.Windows.Forms.Label lblCanceladoT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkFormulario;
        private System.Windows.Forms.CheckBox chkArbitrio;
        private System.Windows.Forms.CheckBox chkPredio;
        private System.Windows.Forms.CheckBox chkAlcabala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta_corriente_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_ID1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo_ID;
    }
}