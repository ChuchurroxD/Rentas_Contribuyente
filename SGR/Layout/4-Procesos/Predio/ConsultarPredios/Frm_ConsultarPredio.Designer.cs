namespace SGR.WinApp.Layout._4_Procesos.Predio.ConsultarPredios
{
    partial class Frm_ConsultarPredio
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.rbtDirección = new System.Windows.Forms.RadioButton();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbtCodContribuyente = new System.Windows.Forms.RadioButton();
            this.rbtNDoc = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCalleB = new System.Windows.Forms.ComboBox();
            this.txtDptoB = new System.Windows.Forms.TextBox();
            this.txtLoteB = new System.Windows.Forms.TextBox();
            this.txtPisoB = new System.Windows.Forms.TextBox();
            this.txtViaB = new System.Windows.Forms.TextBox();
            this.txtManzanaB = new System.Windows.Forms.TextBox();
            this.txtEdificioB = new System.Windows.Forms.TextBox();
            this.txtTiendaB = new System.Windows.Forms.TextBox();
            this.txtInteriorB = new System.Windows.Forms.TextBox();
            this.cboSectorB = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtNDocu = new System.Windows.Forms.TextBox();
            this.txtNomRazon = new System.Windows.Forms.TextBox();
            this.txtCodContribuyente = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccCompleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_contribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.rbtDirección);
            this.groupBox3.Controls.Add(this.rbtNombre);
            this.groupBox3.Controls.Add(this.rbtCodContribuyente);
            this.groupBox3.Controls.Add(this.rbtNDoc);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.cboCalleB);
            this.groupBox3.Controls.Add(this.txtDptoB);
            this.groupBox3.Controls.Add(this.txtLoteB);
            this.groupBox3.Controls.Add(this.txtPisoB);
            this.groupBox3.Controls.Add(this.txtViaB);
            this.groupBox3.Controls.Add(this.txtManzanaB);
            this.groupBox3.Controls.Add(this.txtEdificioB);
            this.groupBox3.Controls.Add(this.txtTiendaB);
            this.groupBox3.Controls.Add(this.txtInteriorB);
            this.groupBox3.Controls.Add(this.cboSectorB);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.label51);
            this.groupBox3.Controls.Add(this.label52);
            this.groupBox3.Controls.Add(this.label53);
            this.groupBox3.Controls.Add(this.label54);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Controls.Add(this.txtNDocu);
            this.groupBox3.Controls.Add(this.txtNomRazon);
            this.groupBox3.Controls.Add(this.txtCodContribuyente);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(924, 170);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Contribuyentes";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(135, 14);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 13);
            this.label32.TabIndex = 88;
            this.label32.Text = "Buscar por:";
            // 
            // rbtDirección
            // 
            this.rbtDirección.AutoSize = true;
            this.rbtDirección.Location = new System.Drawing.Point(587, 12);
            this.rbtDirección.Name = "rbtDirección";
            this.rbtDirección.Size = new System.Drawing.Size(70, 17);
            this.rbtDirección.TabIndex = 87;
            this.rbtDirección.Text = "Dirección";
            this.rbtDirección.UseVisualStyleBackColor = true;
            this.rbtDirección.CheckedChanged += new System.EventHandler(this.rbtDirección_CheckedChanged);
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(460, 13);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(111, 17);
            this.rbtNombre.TabIndex = 85;
            this.rbtNombre.Text = "Nombre/Razon S.";
            this.rbtNombre.UseVisualStyleBackColor = true;
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.rbtNombre_CheckedChanged);
            // 
            // rbtCodContribuyente
            // 
            this.rbtCodContribuyente.AutoSize = true;
            this.rbtCodContribuyente.Location = new System.Drawing.Point(335, 12);
            this.rbtCodContribuyente.Name = "rbtCodContribuyente";
            this.rbtCodContribuyente.Size = new System.Drawing.Size(115, 17);
            this.rbtCodContribuyente.TabIndex = 84;
            this.rbtCodContribuyente.Text = "Cod. Contribuyente";
            this.rbtCodContribuyente.UseVisualStyleBackColor = true;
            this.rbtCodContribuyente.CheckedChanged += new System.EventHandler(this.rbtCodContribuyente_CheckedChanged);
            // 
            // rbtNDoc
            // 
            this.rbtNDoc.AutoSize = true;
            this.rbtNDoc.Checked = true;
            this.rbtNDoc.Location = new System.Drawing.Point(221, 12);
            this.rbtNDoc.Name = "rbtNDoc";
            this.rbtNDoc.Size = new System.Drawing.Size(108, 17);
            this.rbtNDoc.TabIndex = 83;
            this.rbtNDoc.TabStop = true;
            this.rbtNDoc.Text = "Núm. Documento";
            this.rbtNDoc.UseVisualStyleBackColor = true;
            this.rbtNDoc.CheckedChanged += new System.EventHandler(this.rbtNDoc_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Image = global::SGR.WinApp.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(362, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 46);
            this.btnBuscar.TabIndex = 82;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCalleB
            // 
            this.cboCalleB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalleB.FormattingEnabled = true;
            this.cboCalleB.Location = new System.Drawing.Point(316, 60);
            this.cboCalleB.Name = "cboCalleB";
            this.cboCalleB.Size = new System.Drawing.Size(223, 21);
            this.cboCalleB.TabIndex = 81;
            // 
            // txtDptoB
            // 
            this.txtDptoB.Location = new System.Drawing.Point(834, 31);
            this.txtDptoB.Name = "txtDptoB";
            this.txtDptoB.Size = new System.Drawing.Size(73, 20);
            this.txtDptoB.TabIndex = 80;
            // 
            // txtLoteB
            // 
            this.txtLoteB.Location = new System.Drawing.Point(719, 60);
            this.txtLoteB.Name = "txtLoteB";
            this.txtLoteB.Size = new System.Drawing.Size(71, 20);
            this.txtLoteB.TabIndex = 79;
            // 
            // txtPisoB
            // 
            this.txtPisoB.Location = new System.Drawing.Point(491, 93);
            this.txtPisoB.Name = "txtPisoB";
            this.txtPisoB.Size = new System.Drawing.Size(67, 20);
            this.txtPisoB.TabIndex = 77;
            // 
            // txtViaB
            // 
            this.txtViaB.Location = new System.Drawing.Point(619, 61);
            this.txtViaB.Name = "txtViaB";
            this.txtViaB.Size = new System.Drawing.Size(52, 20);
            this.txtViaB.TabIndex = 76;
            // 
            // txtManzanaB
            // 
            this.txtManzanaB.Location = new System.Drawing.Point(833, 56);
            this.txtManzanaB.Name = "txtManzanaB";
            this.txtManzanaB.Size = new System.Drawing.Size(73, 20);
            this.txtManzanaB.TabIndex = 75;
            // 
            // txtEdificioB
            // 
            this.txtEdificioB.Location = new System.Drawing.Point(301, 89);
            this.txtEdificioB.Name = "txtEdificioB";
            this.txtEdificioB.Size = new System.Drawing.Size(90, 20);
            this.txtEdificioB.TabIndex = 74;
            // 
            // txtTiendaB
            // 
            this.txtTiendaB.Location = new System.Drawing.Point(648, 91);
            this.txtTiendaB.Name = "txtTiendaB";
            this.txtTiendaB.Size = new System.Drawing.Size(100, 20);
            this.txtTiendaB.TabIndex = 73;
            // 
            // txtInteriorB
            // 
            this.txtInteriorB.Location = new System.Drawing.Point(82, 89);
            this.txtInteriorB.Name = "txtInteriorB";
            this.txtInteriorB.Size = new System.Drawing.Size(90, 20);
            this.txtInteriorB.TabIndex = 71;
            // 
            // cboSectorB
            // 
            this.cboSectorB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSectorB.FormattingEnabled = true;
            this.cboSectorB.Location = new System.Drawing.Point(81, 61);
            this.cboSectorB.Name = "cboSectorB";
            this.cboSectorB.Size = new System.Drawing.Size(169, 21);
            this.cboSectorB.TabIndex = 70;
            this.cboSectorB.SelectedIndexChanged += new System.EventHandler(this.cboSectorB_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(10, 89);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(42, 13);
            this.label36.TabIndex = 69;
            this.label36.Text = "Interior:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(254, 93);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 13);
            this.label38.TabIndex = 68;
            this.label38.Text = "Edificio:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(599, 94);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 13);
            this.label41.TabIndex = 67;
            this.label41.Text = "Tienda:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(689, 65);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(31, 13);
            this.label46.TabIndex = 66;
            this.label46.Text = "Lote:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(458, 96);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(27, 13);
            this.label49.TabIndex = 65;
            this.label49.Text = "Piso";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(573, 66);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(40, 13);
            this.label51.TabIndex = 63;
            this.label51.Text = "Nº Vìa:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(280, 64);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(33, 13);
            this.label52.TabIndex = 62;
            this.label52.Text = "Calle:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(809, 63);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(24, 13);
            this.label53.TabIndex = 61;
            this.label53.Text = "Mz:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(8, 64);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 13);
            this.label54.TabIndex = 60;
            this.label54.Text = "Sector:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(801, 34);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(33, 13);
            this.label55.TabIndex = 59;
            this.label55.Text = "Dpto:";
            // 
            // txtNDocu
            // 
            this.txtNDocu.Location = new System.Drawing.Point(59, 31);
            this.txtNDocu.Name = "txtNDocu";
            this.txtNDocu.Size = new System.Drawing.Size(99, 20);
            this.txtNDocu.TabIndex = 10;
            // 
            // txtNomRazon
            // 
            this.txtNomRazon.Location = new System.Drawing.Point(517, 33);
            this.txtNomRazon.Name = "txtNomRazon";
            this.txtNomRazon.Size = new System.Drawing.Size(231, 20);
            this.txtNomRazon.TabIndex = 9;
            // 
            // txtCodContribuyente
            // 
            this.txtCodContribuyente.Location = new System.Drawing.Point(267, 32);
            this.txtCodContribuyente.Name = "txtCodContribuyente";
            this.txtCodContribuyente.Size = new System.Drawing.Size(124, 20);
            this.txtCodContribuyente.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Nº Doc.:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(397, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ape y Nom/ Raz. Soc.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cód.Contribuyente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persona_ID,
            this.tipoDocumentoDescripcion,
            this.documento,
            this.paterno,
            this.materno,
            this.nombres,
            this.direccCompleta,
            this.sector,
            this.estado_contribuyente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 192);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 299);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContribuyenteBuscados_CellContentDoubleClick);
            // 
            // persona_ID
            // 
            this.persona_ID.DataPropertyName = "persona_ID";
            this.persona_ID.FillWeight = 61.9411F;
            this.persona_ID.HeaderText = "Código";
            this.persona_ID.Name = "persona_ID";
            this.persona_ID.ReadOnly = true;
            this.persona_ID.Width = 70;
            // 
            // tipoDocumentoDescripcion
            // 
            this.tipoDocumentoDescripcion.DataPropertyName = "tipoDocumentoDescripcion";
            this.tipoDocumentoDescripcion.HeaderText = "Tipo Documento";
            this.tipoDocumentoDescripcion.Name = "tipoDocumentoDescripcion";
            this.tipoDocumentoDescripcion.ReadOnly = true;
            this.tipoDocumentoDescripcion.Visible = false;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.FillWeight = 92.73458F;
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // paterno
            // 
            this.paterno.DataPropertyName = "paterno";
            this.paterno.FillWeight = 108.7538F;
            this.paterno.HeaderText = "Ape. Paterno";
            this.paterno.Name = "paterno";
            this.paterno.ReadOnly = true;
            this.paterno.Width = 150;
            // 
            // materno
            // 
            this.materno.DataPropertyName = "materno";
            this.materno.FillWeight = 115.3985F;
            this.materno.HeaderText = "Ape. Materno";
            this.materno.Name = "materno";
            this.materno.ReadOnly = true;
            this.materno.Width = 150;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.FillWeight = 89.40649F;
            this.nombres.HeaderText = "Nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 150;
            // 
            // direccCompleta
            // 
            this.direccCompleta.DataPropertyName = "direccCompleta";
            this.direccCompleta.FillWeight = 165.7719F;
            this.direccCompleta.HeaderText = "Dirección Completa";
            this.direccCompleta.Name = "direccCompleta";
            this.direccCompleta.ReadOnly = true;
            this.direccCompleta.Width = 300;
            // 
            // sector
            // 
            this.sector.DataPropertyName = "sector";
            this.sector.FillWeight = 79.19505F;
            this.sector.HeaderText = "Sector";
            this.sector.Name = "sector";
            this.sector.ReadOnly = true;
            // 
            // estado_contribuyente
            // 
            this.estado_contribuyente.DataPropertyName = "estado_contribuyente";
            this.estado_contribuyente.FillWeight = 86.79847F;
            this.estado_contribuyente.HeaderText = "Estado";
            this.estado_contribuyente.Name = "estado_contribuyente";
            this.estado_contribuyente.ReadOnly = true;
            // 
            // Frm_ConsultarPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_ConsultarPredio";
            this.Text = "Frm_ConsultarPredio";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton rbtDirección;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.RadioButton rbtCodContribuyente;
        private System.Windows.Forms.RadioButton rbtNDoc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboCalleB;
        private System.Windows.Forms.TextBox txtDptoB;
        private System.Windows.Forms.TextBox txtLoteB;
        private System.Windows.Forms.TextBox txtPisoB;
        private System.Windows.Forms.TextBox txtViaB;
        private System.Windows.Forms.TextBox txtManzanaB;
        private System.Windows.Forms.TextBox txtEdificioB;
        private System.Windows.Forms.TextBox txtTiendaB;
        private System.Windows.Forms.TextBox txtInteriorB;
        private System.Windows.Forms.ComboBox cboSectorB;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtNDocu;
        private System.Windows.Forms.TextBox txtNomRazon;
        private System.Windows.Forms.TextBox txtCodContribuyente;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccCompleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_contribuyente;
    }
}