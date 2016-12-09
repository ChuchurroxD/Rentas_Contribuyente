namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_estadisticos
{
    partial class Frm_estadistico_3
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
            this.dgvPagosComparativo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboMes1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPeriodo1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboMes2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPeriodo2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnComparativo = new System.Windows.Forms.Button();
            this.Tributos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAño1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAño2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcVarianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosComparativo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgvPagosComparativo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnComparativo);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 339);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Búsqueda";
            // 
            // dgvPagosComparativo
            // 
            this.dgvPagosComparativo.AllowUserToAddRows = false;
            this.dgvPagosComparativo.AllowUserToDeleteRows = false;
            this.dgvPagosComparativo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagosComparativo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagosComparativo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagosComparativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosComparativo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tributos,
            this.MontoAño1,
            this.MontoAño2,
            this.Varianza,
            this.PorcVarianza});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagosComparativo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagosComparativo.EnableHeadersVisualStyles = false;
            this.dgvPagosComparativo.Location = new System.Drawing.Point(38, 168);
            this.dgvPagosComparativo.Name = "dgvPagosComparativo";
            this.dgvPagosComparativo.ReadOnly = true;
            this.dgvPagosComparativo.RowHeadersVisible = false;
            this.dgvPagosComparativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosComparativo.Size = new System.Drawing.Size(728, 137);
            this.dgvPagosComparativo.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboMes1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboPeriodo1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(38, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 54);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Añoy Mes con el cual desea comparar";
            // 
            // cboMes1
            // 
            this.cboMes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes1.FormattingEnabled = true;
            this.cboMes1.Location = new System.Drawing.Point(283, 28);
            this.cboMes1.Name = "cboMes1";
            this.cboMes1.Size = new System.Drawing.Size(121, 21);
            this.cboMes1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // cboPeriodo1
            // 
            this.cboPeriodo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo1.FormattingEnabled = true;
            this.cboPeriodo1.Location = new System.Drawing.Point(63, 27);
            this.cboPeriodo1.Name = "cboPeriodo1";
            this.cboPeriodo1.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "- - - - - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboMes2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboPeriodo2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(38, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 59);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añoy Mes que desea comparar";
            // 
            // cboMes2
            // 
            this.cboMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes2.FormattingEnabled = true;
            this.cboMes2.Location = new System.Drawing.Point(280, 29);
            this.cboMes2.Name = "cboMes2";
            this.cboMes2.Size = new System.Drawing.Size(121, 21);
            this.cboMes2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "- - - - - ";
            // 
            // cboPeriodo2
            // 
            this.cboPeriodo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo2.FormattingEnabled = true;
            this.cboPeriodo2.Location = new System.Drawing.Point(60, 28);
            this.cboPeriodo2.Name = "cboPeriodo2";
            this.cboPeriodo2.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mes";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Image = global::SGR.WinApp.Properties.Resources.search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(491, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 47;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComparativo
            // 
            this.btnComparativo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparativo.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnComparativo.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.btnComparativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComparativo.Location = new System.Drawing.Point(607, 75);
            this.btnComparativo.Name = "btnComparativo";
            this.btnComparativo.Size = new System.Drawing.Size(159, 31);
            this.btnComparativo.TabIndex = 11;
            this.btnComparativo.Text = "Generar Reporte";
            this.btnComparativo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComparativo.UseVisualStyleBackColor = true;
            this.btnComparativo.Click += new System.EventHandler(this.btnComparativo_Click);
            // 
            // Tributos
            // 
            this.Tributos.DataPropertyName = "Tributos";
            this.Tributos.HeaderText = "Tributos";
            this.Tributos.Name = "Tributos";
            this.Tributos.ReadOnly = true;
            // 
            // MontoAño1
            // 
            this.MontoAño1.DataPropertyName = "MontoAño1";
            this.MontoAño1.HeaderText = "Año y Mes que desea Comparar";
            this.MontoAño1.Name = "MontoAño1";
            this.MontoAño1.ReadOnly = true;
            this.MontoAño1.Width = 220;
            // 
            // MontoAño2
            // 
            this.MontoAño2.DataPropertyName = "MontoAño2";
            this.MontoAño2.HeaderText = "Año y Mes con el cual desea Comparar";
            this.MontoAño2.Name = "MontoAño2";
            this.MontoAño2.ReadOnly = true;
            this.MontoAño2.Width = 220;
            // 
            // Varianza
            // 
            this.Varianza.DataPropertyName = "Varianza";
            this.Varianza.HeaderText = "Varianza";
            this.Varianza.Name = "Varianza";
            this.Varianza.ReadOnly = true;
            this.Varianza.Visible = false;
            // 
            // PorcVarianza
            // 
            this.PorcVarianza.DataPropertyName = "PorcVarianza";
            this.PorcVarianza.HeaderText = "% Varianza";
            this.PorcVarianza.Name = "PorcVarianza";
            this.PorcVarianza.ReadOnly = true;
            this.PorcVarianza.Visible = false;
            // 
            // Frm_estadistico_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 353);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_estadistico_3";
            this.Text = "Reporte Comparativo de Pagos";
            this.Load += new System.EventHandler(this.Frm_estadistico_3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosComparativo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMes2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMes1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPeriodo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPeriodo1;
        private System.Windows.Forms.Button btnComparativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPagosComparativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tributos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAño1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAño2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcVarianza;
    }
}