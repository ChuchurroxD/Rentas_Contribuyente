namespace SGR.WinApp.Layout._4_Procesos.Emision
{
    partial class Emi_EmisionMasiva
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPUPR = new System.Windows.Forms.CheckBox();
            this.chkHR = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvContribuyentes = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_conFormato = new System.Windows.Forms.RadioButton();
            this.btn_sinFormato = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::SGR.WinApp.Properties.Resources.check;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(457, 99);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(80, 28);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(529, 25);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 2;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(639, 68);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 21);
            this.cboMes.TabIndex = 3;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(494, 28);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(603, 71);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 5;
            this.lblMes.Text = "Mes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sinFormato);
            this.groupBox1.Controls.Add(this.btn_conFormato);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.chkPUPR);
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Controls.Add(this.lblMes);
            this.groupBox1.Controls.Add(this.chkHR);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvContribuyentes);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cboSector);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboAnio);
            this.groupBox1.Controls.Add(this.lblAnio);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 462);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Por Sector";
            // 
            // chkPUPR
            // 
            this.chkPUPR.AutoSize = true;
            this.chkPUPR.Location = new System.Drawing.Point(745, 27);
            this.chkPUPR.Name = "chkPUPR";
            this.chkPUPR.Size = new System.Drawing.Size(67, 17);
            this.chkPUPR.TabIndex = 7;
            this.chkPUPR.Text = "PU / PR";
            this.chkPUPR.UseVisualStyleBackColor = true;
            // 
            // chkHR
            // 
            this.chkHR.AutoSize = true;
            this.chkHR.Location = new System.Drawing.Point(687, 27);
            this.chkHR.Name = "chkHR";
            this.chkHR.Size = new System.Drawing.Size(42, 17);
            this.chkHR.TabIndex = 6;
            this.chkHR.Text = "HR";
            this.chkHR.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::SGR.WinApp.Properties.Resources.predios;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(374, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "IMPRIMIR DESDE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvContribuyentes
            // 
            this.dgvContribuyentes.AllowUserToAddRows = false;
            this.dgvContribuyentes.AllowUserToDeleteRows = false;
            this.dgvContribuyentes.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContribuyentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContribuyentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContribuyentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombres,
            this.documento,
            this.direccion});
            this.dgvContribuyentes.EnableHeadersVisualStyles = false;
            this.dgvContribuyentes.Location = new System.Drawing.Point(23, 145);
            this.dgvContribuyentes.MultiSelect = false;
            this.dgvContribuyentes.Name = "dgvContribuyentes";
            this.dgvContribuyentes.ReadOnly = true;
            this.dgvContribuyentes.RowHeadersVisible = false;
            this.dgvContribuyentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContribuyentes.Size = new System.Drawing.Size(813, 245);
            this.dgvContribuyentes.TabIndex = 10;
            this.dgvContribuyentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContribuyentes_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "persona_ID";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 120;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Contribuyente";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 250;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 250;
            // 
            // button2
            // 
            this.button2.Image = global::SGR.WinApp.Properties.Resources.clipboard_with_a_list;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(350, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "LISTAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(97, 25);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(362, 21);
            this.cboSector.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sector:";
            // 
            // btn_conFormato
            // 
            this.btn_conFormato.AutoSize = true;
            this.btn_conFormato.Checked = true;
            this.btn_conFormato.Location = new System.Drawing.Point(84, 67);
            this.btn_conFormato.Name = "btn_conFormato";
            this.btn_conFormato.Size = new System.Drawing.Size(85, 17);
            this.btn_conFormato.TabIndex = 12;
            this.btn_conFormato.TabStop = true;
            this.btn_conFormato.Text = "Con Formato";
            this.btn_conFormato.UseVisualStyleBackColor = true;
            // 
            // btn_sinFormato
            // 
            this.btn_sinFormato.AutoSize = true;
            this.btn_sinFormato.Location = new System.Drawing.Point(192, 69);
            this.btn_sinFormato.Name = "btn_sinFormato";
            this.btn_sinFormato.Size = new System.Drawing.Size(81, 17);
            this.btn_sinFormato.TabIndex = 13;
            this.btn_sinFormato.TabStop = true;
            this.btn_sinFormato.Text = "Sin Formato";
            this.btn_sinFormato.UseVisualStyleBackColor = true;
            // 
            // Emi_EmisionMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 499);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Emi_EmisionMasiva";
            this.Text = "Emi_EmisionMasiva";
            this.Load += new System.EventHandler(this.Emi_EmisionMasiva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkHR;
        private System.Windows.Forms.CheckBox chkPUPR;
        private System.Windows.Forms.DataGridView dgvContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton btn_sinFormato;
        private System.Windows.Forms.RadioButton btn_conFormato;
    }
}