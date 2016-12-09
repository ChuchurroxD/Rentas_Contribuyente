namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento
{
    partial class Frm_FraccionamientoListado
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
            this.cboCalleB = new System.Windows.Forms.ComboBox();
            this.cboSectorB = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtNroCuotaVenc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xanular = new System.Windows.Forms.DataGridViewImageColumn();
            this.xfraccionamiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xconvenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpersona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xjunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xvia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfechaAcogida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdeudaFraccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnroCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuotasVencidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoFraccionamiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbFraccionamiento = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbFraccionamiento.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCalleB
            // 
            this.cboCalleB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalleB.FormattingEnabled = true;
            this.cboCalleB.Location = new System.Drawing.Point(492, 51);
            this.cboCalleB.Name = "cboCalleB";
            this.cboCalleB.Size = new System.Drawing.Size(228, 21);
            this.cboCalleB.TabIndex = 85;
            // 
            // cboSectorB
            // 
            this.cboSectorB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSectorB.FormattingEnabled = true;
            this.cboSectorB.Location = new System.Drawing.Point(492, 23);
            this.cboSectorB.Name = "cboSectorB";
            this.cboSectorB.Size = new System.Drawing.Size(228, 21);
            this.cboSectorB.TabIndex = 84;
            this.cboSectorB.SelectedIndexChanged += new System.EventHandler(this.cboSectorB_SelectedIndexChanged);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(430, 54);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(33, 13);
            this.label52.TabIndex = 83;
            this.label52.Text = "Calle:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(430, 26);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 13);
            this.label54.TabIndex = 82;
            this.label54.Text = "Sector:";
            // 
            // txtNroCuotaVenc
            // 
            this.txtNroCuotaVenc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroCuotaVenc.Location = new System.Drawing.Point(562, 86);
            this.txtNroCuotaVenc.MaxLength = 200;
            this.txtNroCuotaVenc.Name = "txtNroCuotaVenc";
            this.txtNroCuotaVenc.Size = new System.Drawing.Size(63, 20);
            this.txtNroCuotaVenc.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nro. Cuotas Vencidas";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Location = new System.Drawing.Point(132, 23);
            this.txtRazonSocial.MaxLength = 200;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(178, 20);
            this.txtRazonSocial.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre / R. Social:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(249, 84);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "y";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(129, 83);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xanular,
            this.xfraccionamiento_id,
            this.xconvenio,
            this.xpersona_ID,
            this.xpersona,
            this.xjunta,
            this.xvia,
            this.xfechaAcogida,
            this.xdeudaFraccionada,
            this.xnroCuotas,
            this.xcuota,
            this.xcuotasVencidas,
            this.xestado});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 192);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(990, 209);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // xanular
            // 
            this.xanular.HeaderText = "Anular";
            this.xanular.Name = "xanular";
            this.xanular.ReadOnly = true;
            this.xanular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xanular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xanular.Width = 70;
            // 
            // xfraccionamiento_id
            // 
            this.xfraccionamiento_id.DataPropertyName = "fraccionamiento_id";
            this.xfraccionamiento_id.HeaderText = "codigo";
            this.xfraccionamiento_id.Name = "xfraccionamiento_id";
            this.xfraccionamiento_id.ReadOnly = true;
            this.xfraccionamiento_id.Visible = false;
            // 
            // xconvenio
            // 
            this.xconvenio.DataPropertyName = "convenio";
            this.xconvenio.HeaderText = "Convenio";
            this.xconvenio.Name = "xconvenio";
            this.xconvenio.ReadOnly = true;
            this.xconvenio.Width = 70;
            // 
            // xpersona_ID
            // 
            this.xpersona_ID.DataPropertyName = "persona_ID";
            this.xpersona_ID.HeaderText = "Cód. Cont.";
            this.xpersona_ID.Name = "xpersona_ID";
            this.xpersona_ID.ReadOnly = true;
            this.xpersona_ID.Width = 90;
            // 
            // xpersona
            // 
            this.xpersona.DataPropertyName = "persona";
            this.xpersona.HeaderText = "Razón Social";
            this.xpersona.Name = "xpersona";
            this.xpersona.ReadOnly = true;
            this.xpersona.Width = 250;
            // 
            // xjunta
            // 
            this.xjunta.DataPropertyName = "junta";
            this.xjunta.HeaderText = "Junta";
            this.xjunta.Name = "xjunta";
            this.xjunta.ReadOnly = true;
            this.xjunta.Visible = false;
            // 
            // xvia
            // 
            this.xvia.DataPropertyName = "via";
            this.xvia.HeaderText = "Vía";
            this.xvia.Name = "xvia";
            this.xvia.ReadOnly = true;
            this.xvia.Visible = false;
            // 
            // xfechaAcogida
            // 
            this.xfechaAcogida.DataPropertyName = "fechaAcogida";
            this.xfechaAcogida.HeaderText = "Fecha Acog.";
            this.xfechaAcogida.Name = "xfechaAcogida";
            this.xfechaAcogida.ReadOnly = true;
            this.xfechaAcogida.Width = 80;
            // 
            // xdeudaFraccionada
            // 
            this.xdeudaFraccionada.DataPropertyName = "deudaFraccionada";
            this.xdeudaFraccionada.HeaderText = "Deuda Fracc.";
            this.xdeudaFraccionada.Name = "xdeudaFraccionada";
            this.xdeudaFraccionada.ReadOnly = true;
            this.xdeudaFraccionada.Width = 80;
            // 
            // xnroCuotas
            // 
            this.xnroCuotas.DataPropertyName = "nroCuotas";
            this.xnroCuotas.HeaderText = "Nro. Cuotas";
            this.xnroCuotas.Name = "xnroCuotas";
            this.xnroCuotas.ReadOnly = true;
            this.xnroCuotas.Width = 80;
            // 
            // xcuota
            // 
            this.xcuota.DataPropertyName = "cuota";
            this.xcuota.HeaderText = "Cuota";
            this.xcuota.Name = "xcuota";
            this.xcuota.ReadOnly = true;
            this.xcuota.Width = 80;
            // 
            // xcuotasVencidas
            // 
            this.xcuotasVencidas.DataPropertyName = "cuotasVencidas";
            this.xcuotasVencidas.HeaderText = "Cuotas Venc.";
            this.xcuotasVencidas.Name = "xcuotasVencidas";
            this.xcuotasVencidas.ReadOnly = true;
            this.xcuotasVencidas.Width = 80;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "estado";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            this.xestado.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha Acogida:";
            // 
            // cboTipoFraccionamiento
            // 
            this.cboTipoFraccionamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFraccionamiento.FormattingEnabled = true;
            this.cboTipoFraccionamiento.Location = new System.Drawing.Point(129, 51);
            this.cboTipoFraccionamiento.Name = "cboTipoFraccionamiento";
            this.cboTipoFraccionamiento.Size = new System.Drawing.Size(284, 21);
            this.cboTipoFraccionamiento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Fraccionamiento:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(410, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 22);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbFraccionamiento
            // 
            this.gbFraccionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFraccionamiento.BackColor = System.Drawing.Color.Lavender;
            this.gbFraccionamiento.Controls.Add(this.cboCalleB);
            this.gbFraccionamiento.Controls.Add(this.cboSectorB);
            this.gbFraccionamiento.Controls.Add(this.btnBuscar);
            this.gbFraccionamiento.Controls.Add(this.label52);
            this.gbFraccionamiento.Controls.Add(this.label54);
            this.gbFraccionamiento.Controls.Add(this.txtNroCuotaVenc);
            this.gbFraccionamiento.Controls.Add(this.label11);
            this.gbFraccionamiento.Controls.Add(this.txtRazonSocial);
            this.gbFraccionamiento.Controls.Add(this.label1);
            this.gbFraccionamiento.Controls.Add(this.dtpFechaFin);
            this.gbFraccionamiento.Controls.Add(this.label6);
            this.gbFraccionamiento.Controls.Add(this.dtpFechaInicio);
            this.gbFraccionamiento.Controls.Add(this.label5);
            this.gbFraccionamiento.Controls.Add(this.cboTipoFraccionamiento);
            this.gbFraccionamiento.Controls.Add(this.label4);
            this.gbFraccionamiento.Location = new System.Drawing.Point(16, 16);
            this.gbFraccionamiento.Name = "gbFraccionamiento";
            this.gbFraccionamiento.Size = new System.Drawing.Size(990, 170);
            this.gbFraccionamiento.TabIndex = 7;
            this.gbFraccionamiento.TabStop = false;
            this.gbFraccionamiento.Text = "Fraccionamiento";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 499);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbFraccionamiento);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Fraccionamientos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1012, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Imprime Resolución";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Frm_FraccionamientoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 741);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_FraccionamientoListado";
            this.Text = "Frm_FraccionamientoListado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbFraccionamiento.ResumeLayout(false);
            this.gbFraccionamiento.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCalleB;
        private System.Windows.Forms.ComboBox cboSectorB;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtNroCuotaVenc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipoFraccionamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbFraccionamiento;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewImageColumn xanular;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfraccionamiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xconvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpersona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn xjunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xvia;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfechaAcogida;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdeudaFraccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnroCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuotasVencidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xestado;
    }
}