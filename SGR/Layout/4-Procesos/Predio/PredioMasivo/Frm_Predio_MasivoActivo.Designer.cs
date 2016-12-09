namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo
{
    partial class Frm_Predio_MasivoActivo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtArbitrio = new System.Windows.Forms.RadioButton();
            this.rbtPredio = new System.Windows.Forms.RadioButton();
            this.btnExcelErrores = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnGenerarCalculoMasivo = new System.Windows.Forms.Button();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErrores
            // 
            this.dgvErrores.AllowUserToAddRows = false;
            this.dgvErrores.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.descripcion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErrores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvErrores.EnableHeadersVisualStyles = false;
            this.dgvErrores.Location = new System.Drawing.Point(15, 69);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.RowHeadersVisible = false;
            this.dgvErrores.Size = new System.Drawing.Size(747, 466);
            this.dgvErrores.TabIndex = 25;
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
            // rbtArbitrio
            // 
            this.rbtArbitrio.AutoSize = true;
            this.rbtArbitrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtArbitrio.Location = new System.Drawing.Point(77, 21);
            this.rbtArbitrio.Name = "rbtArbitrio";
            this.rbtArbitrio.Size = new System.Drawing.Size(65, 17);
            this.rbtArbitrio.TabIndex = 27;
            this.rbtArbitrio.Text = "Arbitrio";
            this.rbtArbitrio.UseVisualStyleBackColor = true;
            this.rbtArbitrio.CheckedChanged += new System.EventHandler(this.rbtArbitrio_CheckedChanged);
            // 
            // rbtPredio
            // 
            this.rbtPredio.AutoSize = true;
            this.rbtPredio.Checked = true;
            this.rbtPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPredio.Location = new System.Drawing.Point(15, 21);
            this.rbtPredio.Name = "rbtPredio";
            this.rbtPredio.Size = new System.Drawing.Size(61, 17);
            this.rbtPredio.TabIndex = 26;
            this.rbtPredio.TabStop = true;
            this.rbtPredio.Text = "Predio";
            this.rbtPredio.UseVisualStyleBackColor = true;
            this.rbtPredio.CheckedChanged += new System.EventHandler(this.rbtPredio_CheckedChanged);
            // 
            // btnExcelErrores
            // 
            this.btnExcelErrores.Enabled = false;
            this.btnExcelErrores.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.btnExcelErrores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelErrores.Location = new System.Drawing.Point(312, 12);
            this.btnExcelErrores.Name = "btnExcelErrores";
            this.btnExcelErrores.Size = new System.Drawing.Size(106, 36);
            this.btnExcelErrores.TabIndex = 28;
            this.btnExcelErrores.Text = "Errores";
            this.btnExcelErrores.UseVisualStyleBackColor = true;
            this.btnExcelErrores.Click += new System.EventHandler(this.btnExcelErrores_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Image = global::SGR.WinApp.Properties.Resources.education;
            this.btnVerificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificar.Location = new System.Drawing.Point(148, 10);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(149, 38);
            this.btnVerificar.TabIndex = 21;
            this.btnVerificar.Text = "Verificar Parámetro";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnGenerarCalculoMasivo
            // 
            this.btnGenerarCalculoMasivo.Enabled = false;
            this.btnGenerarCalculoMasivo.Image = global::SGR.WinApp.Properties.Resources.moneyy;
            this.btnGenerarCalculoMasivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCalculoMasivo.Location = new System.Drawing.Point(444, 12);
            this.btnGenerarCalculoMasivo.Name = "btnGenerarCalculoMasivo";
            this.btnGenerarCalculoMasivo.Size = new System.Drawing.Size(182, 38);
            this.btnGenerarCalculoMasivo.TabIndex = 23;
            this.btnGenerarCalculoMasivo.Text = "Generar Cálculo Másivo";
            this.btnGenerarCalculoMasivo.UseVisualStyleBackColor = true;
            this.btnGenerarCalculoMasivo.Click += new System.EventHandler(this.btnGenerarCalculoMasivo_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPeriodo.Location = new System.Drawing.Point(131, 51);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(52, 17);
            this.lblPeriodo.TabIndex = 29;
            this.lblPeriodo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Periodo Activo";
            // 
            // Frm_Predio_MasivoActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(768, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.dgvErrores);
            this.Controls.Add(this.btnExcelErrores);
            this.Controls.Add(this.rbtArbitrio);
            this.Controls.Add(this.rbtPredio);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnGenerarCalculoMasivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Predio_MasivoActivo";
            this.Text = "Cálculo Másivo del Año Activo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnExcelErrores;
        private System.Windows.Forms.RadioButton rbtArbitrio;
        private System.Windows.Forms.RadioButton rbtPredio;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnGenerarCalculoMasivo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label label1;
    }
}