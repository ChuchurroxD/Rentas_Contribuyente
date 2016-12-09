namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento
{
    partial class Frm_FraccionamientoDetalle
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboAnioFin = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboAnioIni = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBaseLegal = new System.Windows.Forms.TextBox();
            this.cboModalidad = new System.Windows.Forms.ComboBox();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtCuotaIni = new System.Windows.Forms.TextBox();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.chkInteres = new System.Windows.Forms.CheckBox();
            this.txtIntComp = new System.Windows.Forms.TextBox();
            this.txtNroCuotas = new System.Windows.Forms.TextBox();
            this.txtCuotaMinima = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtDerecho = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtMaxUIT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvTributos = new System.Windows.Forms.DataGridView();
            this.xSector_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsysFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcionTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTributos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parámetros Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(270, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Image = global::SGR.WinApp.Properties.Resources.save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(132, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.cboAnioFin);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cboAnioIni);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(31, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 104);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo de deuda y tributos a afectar";
            // 
            // cboAnioFin
            // 
            this.cboAnioFin.FormattingEnabled = true;
            this.cboAnioFin.Location = new System.Drawing.Point(346, 36);
            this.cboAnioFin.Name = "cboAnioFin";
            this.cboAnioFin.Size = new System.Drawing.Size(121, 21);
            this.cboAnioFin.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(256, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Año Fin:";
            // 
            // cboAnioIni
            // 
            this.cboAnioIni.FormattingEnabled = true;
            this.cboAnioIni.Location = new System.Drawing.Point(101, 36);
            this.cboAnioIni.Name = "cboAnioIni";
            this.cboAnioIni.Size = new System.Drawing.Size(121, 21);
            this.cboAnioIni.TabIndex = 16;
            this.cboAnioIni.SelectedIndexChanged += new System.EventHandler(this.RecargarComboPeriodo);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Año Inicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBaseLegal);
            this.groupBox1.Controls.Add(this.cboModalidad);
            this.groupBox1.Controls.Add(this.txtFechaInicio);
            this.groupBox1.Controls.Add(this.txtFechaFin);
            this.groupBox1.Controls.Add(this.txtCuotaIni);
            this.groupBox1.Controls.Add(this.txtInicial);
            this.groupBox1.Controls.Add(this.chkInteres);
            this.groupBox1.Controls.Add(this.txtIntComp);
            this.groupBox1.Controls.Add(this.txtNroCuotas);
            this.groupBox1.Controls.Add(this.txtCuotaMinima);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.txtDerecho);
            this.groupBox1.Controls.Add(this.chkEstado);
            this.groupBox1.Controls.Add(this.txtMaxUIT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Norma y Parámetros de Aplicación";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Max N° UIT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Derecho (S/.):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cuota Mínima:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(256, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Int. Comp. (%):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "% Inicial:";
            // 
            // txtBaseLegal
            // 
            this.txtBaseLegal.Location = new System.Drawing.Point(101, 20);
            this.txtBaseLegal.Name = "txtBaseLegal";
            this.txtBaseLegal.Size = new System.Drawing.Size(366, 20);
            this.txtBaseLegal.TabIndex = 1;
            // 
            // cboModalidad
            // 
            this.cboModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModalidad.FormattingEnabled = true;
            this.cboModalidad.Location = new System.Drawing.Point(100, 52);
            this.cboModalidad.Name = "cboModalidad";
            this.cboModalidad.Size = new System.Drawing.Size(121, 21);
            this.cboModalidad.TabIndex = 2;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicio.Location = new System.Drawing.Point(99, 82);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(120, 20);
            this.txtFechaInicio.TabIndex = 3;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaFin.Location = new System.Drawing.Point(348, 82);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(120, 20);
            this.txtFechaFin.TabIndex = 4;
            // 
            // txtCuotaIni
            // 
            this.txtCuotaIni.Location = new System.Drawing.Point(101, 110);
            this.txtCuotaIni.Name = "txtCuotaIni";
            this.txtCuotaIni.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaIni.TabIndex = 5;
            this.txtCuotaIni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validaDecimal);
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(348, 110);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(100, 20);
            this.txtInicial.TabIndex = 6;
            this.txtInicial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validaDecimal);
            // 
            // chkInteres
            // 
            this.chkInteres.AutoSize = true;
            this.chkInteres.Location = new System.Drawing.Point(101, 139);
            this.chkInteres.Name = "chkInteres";
            this.chkInteres.Size = new System.Drawing.Size(15, 14);
            this.chkInteres.TabIndex = 7;
            this.chkInteres.UseVisualStyleBackColor = true;
            // 
            // txtIntComp
            // 
            this.txtIntComp.Location = new System.Drawing.Point(348, 139);
            this.txtIntComp.Name = "txtIntComp";
            this.txtIntComp.Size = new System.Drawing.Size(100, 20);
            this.txtIntComp.TabIndex = 8;
            this.txtIntComp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validaDecimal);
            // 
            // txtNroCuotas
            // 
            this.txtNroCuotas.Location = new System.Drawing.Point(101, 165);
            this.txtNroCuotas.Name = "txtNroCuotas";
            this.txtNroCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtNroCuotas.TabIndex = 9;
            this.txtNroCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validadaCuotas);
            // 
            // txtCuotaMinima
            // 
            this.txtCuotaMinima.Location = new System.Drawing.Point(348, 172);
            this.txtCuotaMinima.Name = "txtCuotaMinima";
            this.txtCuotaMinima.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaMinima.TabIndex = 10;
            this.txtCuotaMinima.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validaDecimal);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(99, 194);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validaDecimal);
            // 
            // txtDerecho
            // 
            this.txtDerecho.Location = new System.Drawing.Point(348, 201);
            this.txtDerecho.Name = "txtDerecho";
            this.txtDerecho.Size = new System.Drawing.Size(100, 20);
            this.txtDerecho.TabIndex = 12;
            this.txtDerecho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validaDecimal);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(101, 230);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 13;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtMaxUIT
            // 
            this.txtMaxUIT.Location = new System.Drawing.Point(348, 231);
            this.txtMaxUIT.Name = "txtMaxUIT";
            this.txtMaxUIT.Size = new System.Drawing.Size(100, 20);
            this.txtMaxUIT.TabIndex = 14;
            this.txtMaxUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validadaCuotas);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha Fin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descuento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max. N° Cuotas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interes Moratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuota ini.(S/.):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modalidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Legal:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.dgvTributos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tributos Afectados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 27);
            this.toolStrip1.TabIndex = 7;
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
            // dgvTributos
            // 
            this.dgvTributos.AllowUserToAddRows = false;
            this.dgvTributos.AllowUserToDeleteRows = false;
            this.dgvTributos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTributos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTributos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xSector_id,
            this.xdescripcion,
            this.xsysFecha,
            this.xusuario,
            this.xDescripcionTipo,
            this.Column1,
            this.cod});
            this.dgvTributos.EnableHeadersVisualStyles = false;
            this.dgvTributos.Location = new System.Drawing.Point(2, 32);
            this.dgvTributos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTributos.MultiSelect = false;
            this.dgvTributos.Name = "dgvTributos";
            this.dgvTributos.ReadOnly = true;
            this.dgvTributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTributos.Size = new System.Drawing.Size(529, 440);
            this.dgvTributos.TabIndex = 5;
            // 
            // xSector_id
            // 
            this.xSector_id.DataPropertyName = "TrFrc_vtrib";
            this.xSector_id.HeaderText = "Codigo";
            this.xSector_id.Name = "xSector_id";
            this.xSector_id.ReadOnly = true;
            this.xSector_id.Width = 70;
            // 
            // xdescripcion
            // 
            this.xdescripcion.DataPropertyName = "TrFrc_vtribDesc";
            this.xdescripcion.HeaderText = "Descripcion";
            this.xdescripcion.Name = "xdescripcion";
            this.xdescripcion.ReadOnly = true;
            this.xdescripcion.Width = 180;
            // 
            // xsysFecha
            // 
            this.xsysFecha.DataPropertyName = "TrFrc_vabrev";
            this.xsysFecha.HeaderText = "Abreviatura";
            this.xsysFecha.Name = "xsysFecha";
            this.xsysFecha.ReadOnly = true;
            this.xsysFecha.Width = 75;
            // 
            // xusuario
            // 
            this.xusuario.DataPropertyName = "TrFrc_dimporte";
            this.xusuario.HeaderText = "Importe";
            this.xusuario.Name = "xusuario";
            this.xusuario.ReadOnly = true;
            this.xusuario.Width = 60;
            // 
            // xDescripcionTipo
            // 
            this.xDescripcionTipo.DataPropertyName = "TrFrc_vgrupodesc";
            this.xDescripcionTipo.HeaderText = "Grupo";
            this.xDescripcionTipo.Name = "xDescripcionTipo";
            this.xDescripcionTipo.ReadOnly = true;
            this.xDescripcionTipo.Width = 90;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TrFrc_vgrupo";
            this.Column1.HeaderText = "Grupo Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "TrFrc_icod";
            this.cod.HeaderText = "Cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // Frm_FraccionamientoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(558, 507);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_FraccionamientoDetalle";
            this.Text = "Tipo Fraccionamiento Detalle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cancelar);
            this.Load += new System.EventHandler(this.Frm_FraccionamientoDetalle_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTributos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboAnioFin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboAnioIni;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaxUIT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDerecho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCuotaMinima;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIntComp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtNroCuotas;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.CheckBox chkInteres;
        private System.Windows.Forms.TextBox txtCuotaIni;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.ComboBox cboModalidad;
        private System.Windows.Forms.TextBox txtBaseLegal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTributos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSector_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsysFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcionTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
    }
}