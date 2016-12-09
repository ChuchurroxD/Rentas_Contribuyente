namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Seguimiento_Fraccionamiento
{
    partial class Frm_FraccionamientoSeguimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFraccionamiento = new System.Windows.Forms.GroupBox();
            this.cboCalleB = new System.Windows.Forms.ComboBox();
            this.cboSectorB = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtNroCuotaVenc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNroCuota = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstadoFracc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoFraccionamiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbFraccionamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFraccionamiento
            // 
            this.gbFraccionamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFraccionamiento.BackColor = System.Drawing.Color.Lavender;
            this.gbFraccionamiento.Controls.Add(this.cboCalleB);
            this.gbFraccionamiento.Controls.Add(this.cboSectorB);
            this.gbFraccionamiento.Controls.Add(this.label52);
            this.gbFraccionamiento.Controls.Add(this.label54);
            this.gbFraccionamiento.Controls.Add(this.txtNroCuotaVenc);
            this.gbFraccionamiento.Controls.Add(this.label11);
            this.gbFraccionamiento.Controls.Add(this.txtNroCuota);
            this.gbFraccionamiento.Controls.Add(this.label10);
            this.gbFraccionamiento.Controls.Add(this.cboPeriodo);
            this.gbFraccionamiento.Controls.Add(this.label2);
            this.gbFraccionamiento.Controls.Add(this.txtRazonSocial);
            this.gbFraccionamiento.Controls.Add(this.label1);
            this.gbFraccionamiento.Controls.Add(this.cboEstadoFracc);
            this.gbFraccionamiento.Controls.Add(this.label7);
            this.gbFraccionamiento.Controls.Add(this.dtpFechaFin);
            this.gbFraccionamiento.Controls.Add(this.label6);
            this.gbFraccionamiento.Controls.Add(this.dtpFechaInicio);
            this.gbFraccionamiento.Controls.Add(this.label5);
            this.gbFraccionamiento.Controls.Add(this.cboTipoFraccionamiento);
            this.gbFraccionamiento.Controls.Add(this.label4);
            this.gbFraccionamiento.Location = new System.Drawing.Point(12, 12);
            this.gbFraccionamiento.Name = "gbFraccionamiento";
            this.gbFraccionamiento.Size = new System.Drawing.Size(1096, 150);
            this.gbFraccionamiento.TabIndex = 3;
            this.gbFraccionamiento.TabStop = false;
            this.gbFraccionamiento.Text = "Fraccionamiento";
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
            this.txtNroCuotaVenc.Location = new System.Drawing.Point(657, 111);
            this.txtNroCuotaVenc.MaxLength = 200;
            this.txtNroCuotaVenc.Name = "txtNroCuotaVenc";
            this.txtNroCuotaVenc.Size = new System.Drawing.Size(63, 20);
            this.txtNroCuotaVenc.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nro. Cuotas Vencidas";
            // 
            // txtNroCuota
            // 
            this.txtNroCuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroCuota.Location = new System.Drawing.Point(433, 111);
            this.txtNroCuota.MaxLength = 200;
            this.txtNroCuota.Name = "txtNroCuota";
            this.txtNroCuota.Size = new System.Drawing.Size(63, 20);
            this.txtNroCuota.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nro. Cuotas";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(129, 111);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(96, 21);
            this.cboPeriodo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Año";
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
            // cboEstadoFracc
            // 
            this.cboEstadoFracc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFracc.FormattingEnabled = true;
            this.cboEstadoFracc.Location = new System.Drawing.Point(560, 80);
            this.cboEstadoFracc.Name = "cboEstadoFracc";
            this.cboEstadoFracc.Size = new System.Drawing.Size(160, 21);
            this.cboEstadoFracc.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado Fraccionamiento:";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 204);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            this.xconvenio.Width = 60;
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
            // 
            // xvia
            // 
            this.xvia.DataPropertyName = "via";
            this.xvia.HeaderText = "Vía";
            this.xvia.Name = "xvia";
            this.xvia.ReadOnly = true;
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
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SGR.WinApp.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(261, 168);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SGR.WinApp.Properties.Resources.print;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(484, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Imprimir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_FraccionamientoSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1134, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbFraccionamiento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_FraccionamientoSeguimiento";
            this.Text = "Fraccionamiento Seguimiento";
            this.Load += new System.EventHandler(this.Frm_FraccionamientoSeguimiento_Load);
            this.gbFraccionamiento.ResumeLayout(false);
            this.gbFraccionamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFraccionamiento;
        private System.Windows.Forms.ComboBox cboTipoFraccionamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstadoFracc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroCuotaVenc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNroCuota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCalleB;
        private System.Windows.Forms.ComboBox cboSectorB;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
    }
}