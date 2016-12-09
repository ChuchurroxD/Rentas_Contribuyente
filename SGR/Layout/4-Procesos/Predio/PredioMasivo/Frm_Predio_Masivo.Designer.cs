namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo
{
    partial class Frm_Predio_Masivo
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
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPeriodoAntiguo = new System.Windows.Forms.ComboBox();
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtPredio = new System.Windows.Forms.RadioButton();
            this.rbtArbitrio = new System.Windows.Forms.RadioButton();
            this.btnExcelErrores = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnGenerarCalculoMasivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(354, 12);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periodo Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Periodo Antiguo";
            // 
            // cboPeriodoAntiguo
            // 
            this.cboPeriodoAntiguo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodoAntiguo.FormattingEnabled = true;
            this.cboPeriodoAntiguo.Location = new System.Drawing.Point(106, 15);
            this.cboPeriodoAntiguo.Name = "cboPeriodoAntiguo";
            this.cboPeriodoAntiguo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodoAntiguo.TabIndex = 1;
            // 
            // dgvErrores
            // 
            this.dgvErrores.AllowUserToAddRows = false;
            this.dgvErrores.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErrores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvErrores.EnableHeadersVisualStyles = false;
            this.dgvErrores.Location = new System.Drawing.Point(18, 96);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.RowHeadersVisible = false;
            this.dgvErrores.Size = new System.Drawing.Size(747, 244);
            this.dgvErrores.TabIndex = 9;
            // 
            // num
            // 
            this.num.HeaderText = "Nª";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 30;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción de Error";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 650;
            // 
            // rbtPredio
            // 
            this.rbtPredio.AutoSize = true;
            this.rbtPredio.Checked = true;
            this.rbtPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPredio.Location = new System.Drawing.Point(531, 15);
            this.rbtPredio.Name = "rbtPredio";
            this.rbtPredio.Size = new System.Drawing.Size(61, 17);
            this.rbtPredio.TabIndex = 10;
            this.rbtPredio.TabStop = true;
            this.rbtPredio.Text = "Predio";
            this.rbtPredio.UseVisualStyleBackColor = true;
            this.rbtPredio.CheckedChanged += new System.EventHandler(this.rbtPredio_CheckedChanged);
            // 
            // rbtArbitrio
            // 
            this.rbtArbitrio.AutoSize = true;
            this.rbtArbitrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtArbitrio.Location = new System.Drawing.Point(593, 15);
            this.rbtArbitrio.Name = "rbtArbitrio";
            this.rbtArbitrio.Size = new System.Drawing.Size(65, 17);
            this.rbtArbitrio.TabIndex = 11;
            this.rbtArbitrio.Text = "Arbitrio";
            this.rbtArbitrio.UseVisualStyleBackColor = true;
            this.rbtArbitrio.CheckedChanged += new System.EventHandler(this.rbtArbitrio_CheckedChanged);
            // 
            // btnExcelErrores
            // 
            this.btnExcelErrores.Enabled = false;
            this.btnExcelErrores.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.btnExcelErrores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelErrores.Location = new System.Drawing.Point(242, 54);
            this.btnExcelErrores.Name = "btnExcelErrores";
            this.btnExcelErrores.Size = new System.Drawing.Size(106, 36);
            this.btnExcelErrores.TabIndex = 17;
            this.btnExcelErrores.Text = "ERRORES";
            this.btnExcelErrores.UseVisualStyleBackColor = true;
            this.btnExcelErrores.Click += new System.EventHandler(this.btnExcelErrores_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Enabled = false;
            this.btnCopiar.Image = global::SGR.WinApp.Properties.Resources.tables;
            this.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopiar.Location = new System.Drawing.Point(379, 52);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(131, 38);
            this.btnCopiar.TabIndex = 4;
            this.btnCopiar.Text = "Copiar Datos";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Image = global::SGR.WinApp.Properties.Resources.education;
            this.btnVerificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificar.Location = new System.Drawing.Point(61, 52);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(149, 38);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar Parámetro";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnGenerarCalculoMasivo
            // 
            this.btnGenerarCalculoMasivo.Enabled = false;
            this.btnGenerarCalculoMasivo.Image = global::SGR.WinApp.Properties.Resources.moneyy;
            this.btnGenerarCalculoMasivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCalculoMasivo.Location = new System.Drawing.Point(542, 52);
            this.btnGenerarCalculoMasivo.Name = "btnGenerarCalculoMasivo";
            this.btnGenerarCalculoMasivo.Size = new System.Drawing.Size(182, 38);
            this.btnGenerarCalculoMasivo.TabIndex = 5;
            this.btnGenerarCalculoMasivo.Text = "Generar Cálculo Másivo";
            this.btnGenerarCalculoMasivo.UseVisualStyleBackColor = true;
            this.btnGenerarCalculoMasivo.Click += new System.EventHandler(this.btnGenerarCalculoMasivo_Click);
            // 
            // Frm_Predio_Masivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(797, 381);
            this.Controls.Add(this.btnExcelErrores);
            this.Controls.Add(this.rbtArbitrio);
            this.Controls.Add(this.rbtPredio);
            this.Controls.Add(this.dgvErrores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPeriodoAntiguo);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnGenerarCalculoMasivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPeriodo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Predio_Masivo";
            this.Text = "Càlculo Masivo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarCalculoMasivo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPeriodoAntiguo;
        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.RadioButton rbtPredio;
        private System.Windows.Forms.RadioButton rbtArbitrio;
        private System.Windows.Forms.Button btnExcelErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}