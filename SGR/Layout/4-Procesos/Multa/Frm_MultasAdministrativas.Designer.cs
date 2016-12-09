namespace SGR.WinApp.Layout._4_Procesos.Multa
{
    partial class Frm_MultasAdministrativas
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbtTribut = new System.Windows.Forms.RadioButton();
            this.rbtAdmin = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txt_oculto = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaRecurso = new System.Windows.Forms.DateTimePicker();
            this.txtNroResolucion = new System.Windows.Forms.TextBox();
            this.lblFechaRecurso = new System.Windows.Forms.Label();
            this.lblNroResolucion = new System.Windows.Forms.Label();
            this.cboTipoRecurso = new System.Windows.Forms.ComboBox();
            this.cboDeclaro = new System.Windows.Forms.ComboBox();
            this.lblDeclaro = new System.Windows.Forms.Label();
            this.lblTipoRecurso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNuevoContribuyente = new System.Windows.Forms.Button();
            this.cboContribuyente = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboTipoInfraccion = new System.Windows.Forms.ComboBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNotificacion = new System.Windows.Forms.DateTimePicker();
            this.lblTipoInfraccion = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResolucionAnio = new System.Windows.Forms.TextBox();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.lblFechaNotificacion = new System.Windows.Forms.Label();
            this.lblMontoo = new System.Windows.Forms.Label();
            this.lblContribuyente = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(21, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbtTribut);
            this.tabPage1.Controls.Add(this.rbtAdmin);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.txt_oculto);
            this.tabPage1.Controls.Add(this.txtObservacion);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnGrabar);
            this.tabPage1.Controls.Add(this.lblObservacion);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contribuyentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbtTribut
            // 
            this.rbtTribut.AutoSize = true;
            this.rbtTribut.Location = new System.Drawing.Point(179, 285);
            this.rbtTribut.Name = "rbtTribut";
            this.rbtTribut.Size = new System.Drawing.Size(108, 17);
            this.rbtTribut.TabIndex = 34;
            this.rbtTribut.Text = "Multas Tributarias";
            this.rbtTribut.UseVisualStyleBackColor = true;
            // 
            // rbtAdmin
            // 
            this.rbtAdmin.AutoSize = true;
            this.rbtAdmin.Checked = true;
            this.rbtAdmin.Location = new System.Drawing.Point(30, 285);
            this.rbtAdmin.Name = "rbtAdmin";
            this.rbtAdmin.Size = new System.Drawing.Size(129, 17);
            this.rbtAdmin.TabIndex = 33;
            this.rbtAdmin.TabStop = true;
            this.rbtAdmin.Text = "Multas Administrativas";
            this.rbtAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(498, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txt_oculto
            // 
            this.txt_oculto.Location = new System.Drawing.Point(27, 412);
            this.txt_oculto.Name = "txt_oculto";
            this.txt_oculto.Size = new System.Drawing.Size(100, 20);
            this.txt_oculto.TabIndex = 32;
            this.txt_oculto.Visible = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(142, 384);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(434, 20);
            this.txtObservacion.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(405, 279);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(305, 279);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 27;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(27, 387);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(70, 13);
            this.lblObservacion.TabIndex = 9;
            this.lblObservacion.Text = "Observación:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaRecurso);
            this.groupBox2.Controls.Add(this.txtNroResolucion);
            this.groupBox2.Controls.Add(this.lblFechaRecurso);
            this.groupBox2.Controls.Add(this.lblNroResolucion);
            this.groupBox2.Controls.Add(this.cboTipoRecurso);
            this.groupBox2.Controls.Add(this.cboDeclaro);
            this.groupBox2.Controls.Add(this.lblDeclaro);
            this.groupBox2.Controls.Add(this.lblTipoRecurso);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recurso Impugnatorio";
            this.groupBox2.Visible = false;
            // 
            // dtpFechaRecurso
            // 
            this.dtpFechaRecurso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecurso.Location = new System.Drawing.Point(417, 45);
            this.dtpFechaRecurso.Name = "dtpFechaRecurso";
            this.dtpFechaRecurso.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaRecurso.TabIndex = 23;
            // 
            // txtNroResolucion
            // 
            this.txtNroResolucion.Location = new System.Drawing.Point(417, 19);
            this.txtNroResolucion.Name = "txtNroResolucion";
            this.txtNroResolucion.Size = new System.Drawing.Size(78, 20);
            this.txtNroResolucion.TabIndex = 23;
            this.txtNroResolucion.Text = "0";
            // 
            // lblFechaRecurso
            // 
            this.lblFechaRecurso.AutoSize = true;
            this.lblFechaRecurso.Location = new System.Drawing.Point(312, 48);
            this.lblFechaRecurso.Name = "lblFechaRecurso";
            this.lblFechaRecurso.Size = new System.Drawing.Size(83, 13);
            this.lblFechaRecurso.TabIndex = 26;
            this.lblFechaRecurso.Text = "Fecha Recurso:";
            // 
            // lblNroResolucion
            // 
            this.lblNroResolucion.AutoSize = true;
            this.lblNroResolucion.Location = new System.Drawing.Point(312, 19);
            this.lblNroResolucion.Name = "lblNroResolucion";
            this.lblNroResolucion.Size = new System.Drawing.Size(83, 13);
            this.lblNroResolucion.TabIndex = 25;
            this.lblNroResolucion.Text = "Nro Resolución:";
            // 
            // cboTipoRecurso
            // 
            this.cboTipoRecurso.FormattingEnabled = true;
            this.cboTipoRecurso.Location = new System.Drawing.Point(109, 23);
            this.cboTipoRecurso.Name = "cboTipoRecurso";
            this.cboTipoRecurso.Size = new System.Drawing.Size(139, 21);
            this.cboTipoRecurso.TabIndex = 23;
            // 
            // cboDeclaro
            // 
            this.cboDeclaro.FormattingEnabled = true;
            this.cboDeclaro.Location = new System.Drawing.Point(109, 48);
            this.cboDeclaro.Name = "cboDeclaro";
            this.cboDeclaro.Size = new System.Drawing.Size(139, 21);
            this.cboDeclaro.TabIndex = 24;
            // 
            // lblDeclaro
            // 
            this.lblDeclaro.AutoSize = true;
            this.lblDeclaro.Location = new System.Drawing.Point(7, 51);
            this.lblDeclaro.Name = "lblDeclaro";
            this.lblDeclaro.Size = new System.Drawing.Size(50, 13);
            this.lblDeclaro.TabIndex = 1;
            this.lblDeclaro.Text = "Declaro?";
            // 
            // lblTipoRecurso
            // 
            this.lblTipoRecurso.AutoSize = true;
            this.lblTipoRecurso.Location = new System.Drawing.Point(7, 26);
            this.lblTipoRecurso.Name = "lblTipoRecurso";
            this.lblTipoRecurso.Size = new System.Drawing.Size(74, 13);
            this.lblTipoRecurso.TabIndex = 0;
            this.lblTipoRecurso.Text = "Tipo Recurso:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnNuevoContribuyente);
            this.groupBox1.Controls.Add(this.cboContribuyente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboTipoInfraccion);
            this.groupBox1.Controls.Add(this.dtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.dtpFechaEmision);
            this.groupBox1.Controls.Add(this.dtpFechaNotificacion);
            this.groupBox1.Controls.Add(this.lblTipoInfraccion);
            this.groupBox1.Controls.Add(this.lblFechaEmision);
            this.groupBox1.Controls.Add(this.lblFechaVencimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtResolucionAnio);
            this.groupBox1.Controls.Add(this.txtResolucion);
            this.groupBox1.Controls.Add(this.txtMontoPagado);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblResolucion);
            this.groupBox1.Controls.Add(this.lblFechaNotificacion);
            this.groupBox1.Controls.Add(this.lblMontoo);
            this.groupBox1.Controls.Add(this.lblContribuyente);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Deuda Contribuyente";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(496, 223);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 30;
            this.chkEstado.Text = "Anular";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Opciones de búsqueda por persona";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(194, 50);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(280, 20);
            this.txtBusqueda.TabIndex = 84;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::SGR.WinApp.Properties.Resources.search1;
            this.BtnBuscar.Location = new System.Drawing.Point(496, 47);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(71, 23);
            this.BtnBuscar.TabIndex = 83;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(287, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Si es nuevo Contribuyente";
            // 
            // btnNuevoContribuyente
            // 
            this.btnNuevoContribuyente.Location = new System.Drawing.Point(23, 19);
            this.btnNuevoContribuyente.Name = "btnNuevoContribuyente";
            this.btnNuevoContribuyente.Size = new System.Drawing.Size(258, 23);
            this.btnNuevoContribuyente.TabIndex = 59;
            this.btnNuevoContribuyente.Text = "Nuevo Contribuyente";
            this.btnNuevoContribuyente.UseVisualStyleBackColor = true;
            this.btnNuevoContribuyente.Click += new System.EventHandler(this.btnNuevoContribuyente_Click);
            // 
            // cboContribuyente
            // 
            this.cboContribuyente.FormattingEnabled = true;
            this.cboContribuyente.Location = new System.Drawing.Point(133, 89);
            this.cboContribuyente.Name = "cboContribuyente";
            this.cboContribuyente.Size = new System.Drawing.Size(434, 21);
            this.cboContribuyente.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "No se ha seleccionado ningún archivo.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Seleccionar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTipoInfraccion
            // 
            this.cboTipoInfraccion.FormattingEnabled = true;
            this.cboTipoInfraccion.Location = new System.Drawing.Point(428, 168);
            this.cboTipoInfraccion.Name = "cboTipoInfraccion";
            this.cboTipoInfraccion.Size = new System.Drawing.Size(203, 21);
            this.cboTipoInfraccion.TabIndex = 20;
            this.cboTipoInfraccion.SelectedIndexChanged += new System.EventHandler(this.cboTipoInfraccion_SelectedIndexChanged);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(428, 142);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaVencimiento.TabIndex = 19;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(428, 116);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaEmision.TabIndex = 18;
            // 
            // dtpFechaNotificacion
            // 
            this.dtpFechaNotificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNotificacion.Location = new System.Drawing.Point(133, 141);
            this.dtpFechaNotificacion.Name = "dtpFechaNotificacion";
            this.dtpFechaNotificacion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNotificacion.TabIndex = 17;
            // 
            // lblTipoInfraccion
            // 
            this.lblTipoInfraccion.AutoSize = true;
            this.lblTipoInfraccion.Location = new System.Drawing.Point(321, 171);
            this.lblTipoInfraccion.Name = "lblTipoInfraccion";
            this.lblTipoInfraccion.Size = new System.Drawing.Size(81, 13);
            this.lblTipoInfraccion.TabIndex = 16;
            this.lblTipoInfraccion.Text = "Tipo Infracción:";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(323, 121);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(79, 13);
            this.lblFechaEmision.TabIndex = 15;
            this.lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(323, 148);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(101, 13);
            this.lblFechaVencimiento.TabIndex = 14;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "--";
            // 
            // txtResolucionAnio
            // 
            this.txtResolucionAnio.Location = new System.Drawing.Point(239, 116);
            this.txtResolucionAnio.Name = "txtResolucionAnio";
            this.txtResolucionAnio.Size = new System.Drawing.Size(78, 20);
            this.txtResolucionAnio.TabIndex = 12;
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(133, 116);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(78, 20);
            this.txtResolucion.TabIndex = 11;
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(133, 167);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPagado.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(133, 194);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(434, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(18, 197);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Archivo:";
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Location = new System.Drawing.Point(18, 116);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(63, 13);
            this.lblResolucion.TabIndex = 3;
            this.lblResolucion.Text = "Resolución:";
            // 
            // lblFechaNotificacion
            // 
            this.lblFechaNotificacion.AutoSize = true;
            this.lblFechaNotificacion.Location = new System.Drawing.Point(18, 144);
            this.lblFechaNotificacion.Name = "lblFechaNotificacion";
            this.lblFechaNotificacion.Size = new System.Drawing.Size(99, 13);
            this.lblFechaNotificacion.TabIndex = 2;
            this.lblFechaNotificacion.Text = "Fecha Notificación:";
            // 
            // lblMontoo
            // 
            this.lblMontoo.AutoSize = true;
            this.lblMontoo.Location = new System.Drawing.Point(18, 170);
            this.lblMontoo.Name = "lblMontoo";
            this.lblMontoo.Size = new System.Drawing.Size(68, 13);
            this.lblMontoo.TabIndex = 1;
            this.lblMontoo.Text = "Monto Pago:";
            // 
            // lblContribuyente
            // 
            this.lblContribuyente.AutoSize = true;
            this.lblContribuyente.Location = new System.Drawing.Point(18, 90);
            this.lblContribuyente.Name = "lblContribuyente";
            this.lblContribuyente.Size = new System.Drawing.Size(75, 13);
            this.lblContribuyente.TabIndex = 0;
            this.lblContribuyente.Text = "Contribuyente:";
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            this.ofdArchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdArchivo_FileOk);
            // 
            // Frm_MultasAdministrativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 480);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MultasAdministrativas";
            this.Text = "Frm_MultasAdministrativas";
            this.Load += new System.EventHandler(this.Frm_MultasAdministrativas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaRecurso;
        private System.Windows.Forms.TextBox txtNroResolucion;
        private System.Windows.Forms.Label lblFechaRecurso;
        private System.Windows.Forms.Label lblNroResolucion;
        private System.Windows.Forms.ComboBox cboTipoRecurso;
        private System.Windows.Forms.ComboBox cboDeclaro;
        private System.Windows.Forms.Label lblDeclaro;
        private System.Windows.Forms.Label lblTipoRecurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboTipoInfraccion;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.DateTimePicker dtpFechaNotificacion;
        private System.Windows.Forms.Label lblTipoInfraccion;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResolucionAnio;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Label lblFechaNotificacion;
        private System.Windows.Forms.Label lblMontoo;
        private System.Windows.Forms.Label lblContribuyente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cboContribuyente;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnNuevoContribuyente;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txt_oculto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.RadioButton rbtTribut;
        private System.Windows.Forms.RadioButton rbtAdmin;
    }
}