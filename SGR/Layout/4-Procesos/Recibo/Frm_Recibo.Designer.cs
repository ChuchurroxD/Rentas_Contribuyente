namespace SGR.WinApp.Layout._4_Procesos.Recibo
{
    partial class Frm_Recibo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.cboGrupoEmision = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cboMesFin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMesIni = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblContribuyente = new System.Windows.Forms.Label();
            this.txtContribuyente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblListar = new System.Windows.Forms.LinkLabel();
            this.cboMesFinC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMesIniC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAnioC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabListaSector = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmitido = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabListaContr = new System.Windows.Forms.TabPage();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkAnularC = new System.Windows.Forms.CheckBox();
            this.ximprimir1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nromes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xanioc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.xSector_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xjunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xemitidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnromes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabListaSector.SuspendLayout();
            this.tabListaContr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 174);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.cboGrupoEmision);
            this.tp1.Controls.Add(this.label13);
            this.tp1.Controls.Add(this.linkLabel1);
            this.tp1.Controls.Add(this.cboMesFin);
            this.tp1.Controls.Add(this.label4);
            this.tp1.Controls.Add(this.cboMesIni);
            this.tp1.Controls.Add(this.label3);
            this.tp1.Controls.Add(this.cboPeriodo);
            this.tp1.Controls.Add(this.label2);
            this.tp1.Controls.Add(this.cboSector);
            this.tp1.Controls.Add(this.label1);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(786, 148);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "SECTOR";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // cboGrupoEmision
            // 
            this.cboGrupoEmision.FormattingEnabled = true;
            this.cboGrupoEmision.Location = new System.Drawing.Point(114, 101);
            this.cboGrupoEmision.Name = "cboGrupoEmision";
            this.cboGrupoEmision.Size = new System.Drawing.Size(255, 21);
            this.cboGrupoEmision.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Grupo de Emisión:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(404, 109);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Listar...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cboMesFin
            // 
            this.cboMesFin.FormattingEnabled = true;
            this.cboMesFin.Location = new System.Drawing.Point(568, 58);
            this.cboMesFin.Name = "cboMesFin";
            this.cboMesFin.Size = new System.Drawing.Size(160, 21);
            this.cboMesFin.TabIndex = 7;
            this.cboMesFin.SelectedIndexChanged += new System.EventHandler(this.cboMesFin_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mes Final:";
            // 
            // cboMesIni
            // 
            this.cboMesIni.FormattingEnabled = true;
            this.cboMesIni.Location = new System.Drawing.Point(114, 58);
            this.cboMesIni.Name = "cboMesIni";
            this.cboMesIni.Size = new System.Drawing.Size(160, 21);
            this.cboMesIni.TabIndex = 5;
            this.cboMesIni.SelectedIndexChanged += new System.EventHandler(this.cboMesIni_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes Inicial:";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(568, 15);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(160, 21);
            this.cboPeriodo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año a Procesar:";
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(114, 15);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(331, 21);
            this.cboSector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sector:";
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.lblDeuda);
            this.tp2.Controls.Add(this.lblContribuyente);
            this.tp2.Controls.Add(this.txtContribuyente);
            this.tp2.Controls.Add(this.label9);
            this.tp2.Controls.Add(this.lblListar);
            this.tp2.Controls.Add(this.cboMesFinC);
            this.tp2.Controls.Add(this.label6);
            this.tp2.Controls.Add(this.cboMesIniC);
            this.tp2.Controls.Add(this.label7);
            this.tp2.Controls.Add(this.cboAnioC);
            this.tp2.Controls.Add(this.label8);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(786, 148);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "CONTRIBUYENTE";
            this.tp2.UseVisualStyleBackColor = true;
            this.tp2.Click += new System.EventHandler(this.tp2_Click);
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(371, 125);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(71, 13);
            this.lblDeuda.TabIndex = 19;
            this.lblDeuda.Text = "contribuyente";
            this.lblDeuda.Visible = false;
            // 
            // lblContribuyente
            // 
            this.lblContribuyente.AutoSize = true;
            this.lblContribuyente.Location = new System.Drawing.Point(190, 40);
            this.lblContribuyente.Name = "lblContribuyente";
            this.lblContribuyente.Size = new System.Drawing.Size(71, 13);
            this.lblContribuyente.TabIndex = 18;
            this.lblContribuyente.Text = "contribuyente";
            // 
            // txtContribuyente
            // 
            this.txtContribuyente.Location = new System.Drawing.Point(111, 37);
            this.txtContribuyente.Name = "txtContribuyente";
            this.txtContribuyente.Size = new System.Drawing.Size(66, 20);
            this.txtContribuyente.TabIndex = 17;
            this.txtContribuyente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Contribuyente:";
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Location = new System.Drawing.Point(324, 125);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(41, 13);
            this.lblListar.TabIndex = 15;
            this.lblListar.TabStop = true;
            this.lblListar.Text = "Listar...";
            this.lblListar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cboMesFinC
            // 
            this.cboMesFinC.FormattingEnabled = true;
            this.cboMesFinC.Location = new System.Drawing.Point(600, 83);
            this.cboMesFinC.Name = "cboMesFinC";
            this.cboMesFinC.Size = new System.Drawing.Size(160, 21);
            this.cboMesFinC.TabIndex = 14;
            this.cboMesFinC.SelectedIndexChanged += new System.EventHandler(this.cboMesFinC_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mes Final:";
            // 
            // cboMesIniC
            // 
            this.cboMesIniC.FormattingEnabled = true;
            this.cboMesIniC.Location = new System.Drawing.Point(304, 83);
            this.cboMesIniC.Name = "cboMesIniC";
            this.cboMesIniC.Size = new System.Drawing.Size(160, 21);
            this.cboMesIniC.TabIndex = 12;
            this.cboMesIniC.SelectedIndexChanged += new System.EventHandler(this.cboMesIniC_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mes Inicial:";
            // 
            // cboAnioC
            // 
            this.cboAnioC.FormattingEnabled = true;
            this.cboAnioC.Location = new System.Drawing.Point(111, 83);
            this.cboAnioC.Name = "cboAnioC";
            this.cboAnioC.Size = new System.Drawing.Size(66, 21);
            this.cboAnioC.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Año a Procesar:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ximprimir,
            this.xSector_id,
            this.xjunta,
            this.xanio,
            this.xmes,
            this.xtotal,
            this.xemitidos,
            this.xpendientes,
            this.xnromes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(774, 144);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabListaSector);
            this.tabControl2.Controls.Add(this.tabListaContr);
            this.tabControl2.Location = new System.Drawing.Point(12, 210);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(794, 227);
            this.tabControl2.TabIndex = 2;
            // 
            // tabListaSector
            // 
            this.tabListaSector.Controls.Add(this.linkLabel2);
            this.tabListaSector.Controls.Add(this.dataGridView2);
            this.tabListaSector.Controls.Add(this.chkAnular);
            this.tabListaSector.Controls.Add(this.lblPendiente);
            this.tabListaSector.Controls.Add(this.label5);
            this.tabListaSector.Controls.Add(this.lblEmitido);
            this.tabListaSector.Controls.Add(this.lblTotal);
            this.tabListaSector.Location = new System.Drawing.Point(4, 22);
            this.tabListaSector.Name = "tabListaSector";
            this.tabListaSector.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaSector.Size = new System.Drawing.Size(786, 201);
            this.tabListaSector.TabIndex = 0;
            this.tabListaSector.Text = "Resumen";
            this.tabListaSector.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(317, 181);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(51, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Generar..";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // chkAnular
            // 
            this.chkAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAnular.AutoSize = true;
            this.chkAnular.Location = new System.Drawing.Point(222, 161);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(192, 17);
            this.chkAnular.TabIndex = 7;
            this.chkAnular.Text = "Anular los generados anteriormente";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.Visible = false;
            // 
            // lblPendiente
            // 
            this.lblPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente.Location = new System.Drawing.Point(677, 160);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(15, 15);
            this.lblPendiente.TabIndex = 6;
            this.lblPendiente.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "TOTAL:";
            // 
            // lblEmitido
            // 
            this.lblEmitido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmitido.AutoSize = true;
            this.lblEmitido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmitido.Location = new System.Drawing.Point(599, 160);
            this.lblEmitido.Name = "lblEmitido";
            this.lblEmitido.Size = new System.Drawing.Size(15, 15);
            this.lblEmitido.TabIndex = 5;
            this.lblEmitido.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(505, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0";
            // 
            // tabListaContr
            // 
            this.tabListaContr.Controls.Add(this.linkLabel4);
            this.tabListaContr.Controls.Add(this.dataGridView1);
            this.tabListaContr.Controls.Add(this.chkAnularC);
            this.tabListaContr.Location = new System.Drawing.Point(4, 22);
            this.tabListaContr.Name = "tabListaContr";
            this.tabListaContr.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaContr.Size = new System.Drawing.Size(786, 201);
            this.tabListaContr.TabIndex = 1;
            this.tabListaContr.Text = "Resumen";
            this.tabListaContr.UseVisualStyleBackColor = true;
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(318, 181);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(51, 13);
            this.linkLabel4.TabIndex = 15;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Generar..";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ximprimir1,
            this.nromes,
            this.xcodigo,
            this.xpersona,
            this.xanioc,
            this.xmesc,
            this.xrecibo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(774, 144);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // chkAnularC
            // 
            this.chkAnularC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAnularC.AutoSize = true;
            this.chkAnularC.Location = new System.Drawing.Point(263, 161);
            this.chkAnularC.Name = "chkAnularC";
            this.chkAnularC.Size = new System.Drawing.Size(192, 17);
            this.chkAnularC.TabIndex = 14;
            this.chkAnularC.Text = "Anular los generados anteriormente";
            this.chkAnularC.UseVisualStyleBackColor = true;
            this.chkAnularC.Visible = false;
            // 
            // ximprimir1
            // 
            this.ximprimir1.HeaderText = "Imprimir";
            this.ximprimir1.Image = global::SGR.WinApp.Properties.Resources.verificar;
            this.ximprimir1.Name = "ximprimir1";
            this.ximprimir1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ximprimir1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ximprimir1.Width = 70;
            // 
            // nromes
            // 
            this.nromes.DataPropertyName = "nromes";
            this.nromes.HeaderText = "nroMes";
            this.nromes.Name = "nromes";
            this.nromes.Visible = false;
            // 
            // xcodigo
            // 
            this.xcodigo.DataPropertyName = "codigo";
            this.xcodigo.HeaderText = "Código";
            this.xcodigo.Name = "xcodigo";
            // 
            // xpersona
            // 
            this.xpersona.DataPropertyName = "persona";
            this.xpersona.HeaderText = "Nombres / R. Social";
            this.xpersona.Name = "xpersona";
            this.xpersona.Width = 300;
            // 
            // xanioc
            // 
            this.xanioc.DataPropertyName = "anio";
            this.xanioc.HeaderText = "Año";
            this.xanioc.Name = "xanioc";
            this.xanioc.Width = 70;
            // 
            // xmesc
            // 
            this.xmesc.DataPropertyName = "mes";
            this.xmesc.HeaderText = "Mes";
            this.xmesc.Name = "xmesc";
            // 
            // xrecibo
            // 
            this.xrecibo.DataPropertyName = "recibo";
            this.xrecibo.HeaderText = "Recibo";
            this.xrecibo.Name = "xrecibo";
            // 
            // ximprimir
            // 
            this.ximprimir.HeaderText = "Imprimir";
            this.ximprimir.Image = global::SGR.WinApp.Properties.Resources.verificar;
            this.ximprimir.Name = "ximprimir";
            this.ximprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ximprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ximprimir.Width = 70;
            // 
            // xSector_id
            // 
            this.xSector_id.DataPropertyName = "Sector_id";
            this.xSector_id.HeaderText = "Cod. Sector";
            this.xSector_id.Name = "xSector_id";
            this.xSector_id.Width = 90;
            // 
            // xjunta
            // 
            this.xjunta.DataPropertyName = "junta";
            this.xjunta.HeaderText = "Sector";
            this.xjunta.Name = "xjunta";
            this.xjunta.Width = 200;
            // 
            // xanio
            // 
            this.xanio.DataPropertyName = "anio";
            this.xanio.HeaderText = "Año";
            this.xanio.Name = "xanio";
            this.xanio.Width = 70;
            // 
            // xmes
            // 
            this.xmes.DataPropertyName = "mes";
            this.xmes.HeaderText = "Mes";
            this.xmes.Name = "xmes";
            this.xmes.Width = 70;
            // 
            // xtotal
            // 
            this.xtotal.DataPropertyName = "total";
            this.xtotal.HeaderText = "Contribuyentes";
            this.xtotal.Name = "xtotal";
            // 
            // xemitidos
            // 
            this.xemitidos.DataPropertyName = "emitidos";
            this.xemitidos.HeaderText = "Emitidos";
            this.xemitidos.Name = "xemitidos";
            this.xemitidos.Width = 70;
            // 
            // xpendientes
            // 
            this.xpendientes.DataPropertyName = "pendientes";
            this.xpendientes.HeaderText = "Pendientes";
            this.xpendientes.Name = "xpendientes";
            // 
            // xnromes
            // 
            this.xnromes.DataPropertyName = "nromes";
            this.xnromes.HeaderText = "CodMes";
            this.xnromes.Name = "xnromes";
            this.xnromes.Visible = false;
            // 
            // Frm_Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Recibo";
            this.Text = "Frm_Recibo";
            this.Load += new System.EventHandler(this.Frm_Recibo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabListaSector.ResumeLayout(false);
            this.tabListaSector.PerformLayout();
            this.tabListaContr.ResumeLayout(false);
            this.tabListaContr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cboMesFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMesIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabListaSector;
        private System.Windows.Forms.TabPage tabListaContr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEmitido;
        private System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lblContribuyente;
        private System.Windows.Forms.TextBox txtContribuyente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lblListar;
        private System.Windows.Forms.ComboBox cboMesFinC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMesIniC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboAnioC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkAnularC;
        private System.Windows.Forms.ComboBox cboGrupoEmision;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.DataGridViewImageColumn ximprimir1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nromes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn xanioc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrecibo;
        private System.Windows.Forms.DataGridViewImageColumn ximprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSector_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xjunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xemitidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnromes;
    }
}