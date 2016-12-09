namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_GrandesBaseImponible
{
    partial class Frm_GrandeBaseImponible
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
            this.btnListar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHasta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonGenerarReporte = new System.Windows.Forms.Button();
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.periodo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_completa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_imponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboHasta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.botonGenerarReporte);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(427, 29);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(328, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(74, 21);
            this.txtNumero.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Tag = "";
            this.label4.Text = "Top:";
            // 
            // cboHasta
            // 
            this.cboHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHasta.FormattingEnabled = true;
            this.cboHasta.Location = new System.Drawing.Point(174, 31);
            this.cboHasta.Name = "cboHasta";
            this.cboHasta.Size = new System.Drawing.Size(85, 21);
            this.cboHasta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Periodo:";
            // 
            // botonGenerarReporte
            // 
            this.botonGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarReporte.Location = new System.Drawing.Point(608, 18);
            this.botonGenerarReporte.Name = "botonGenerarReporte";
            this.botonGenerarReporte.Size = new System.Drawing.Size(159, 34);
            this.botonGenerarReporte.TabIndex = 2;
            this.botonGenerarReporte.Text = "Generar Reporte";
            this.botonGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarReporte.UseVisualStyleBackColor = true;
            this.botonGenerarReporte.Click += new System.EventHandler(this.botonGenerarReporte_Click);
            // 
            // dgReporte
            // 
            this.dgReporte.AllowUserToAddRows = false;
            this.dgReporte.AllowUserToDeleteRows = false;
            this.dgReporte.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo_id,
            this.persona_id,
            this.razon_social,
            this.direccion_completa,
            this.base_imponible});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReporte.EnableHeadersVisualStyles = false;
            this.dgReporte.Location = new System.Drawing.Point(0, 71);
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.ReadOnly = true;
            this.dgReporte.RowHeadersVisible = false;
            this.dgReporte.Size = new System.Drawing.Size(810, 191);
            this.dgReporte.TabIndex = 4;
            // 
            // periodo_id
            // 
            this.periodo_id.DataPropertyName = "periodo_id";
            this.periodo_id.HeaderText = "Año";
            this.periodo_id.Name = "periodo_id";
            this.periodo_id.ReadOnly = true;
            // 
            // persona_id
            // 
            this.persona_id.DataPropertyName = "persona_id";
            this.persona_id.HeaderText = "Persona ID ";
            this.persona_id.Name = "persona_id";
            this.persona_id.ReadOnly = true;
            this.persona_id.Visible = false;
            // 
            // razon_social
            // 
            this.razon_social.DataPropertyName = "razon_social";
            this.razon_social.HeaderText = "Contribuyente";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 300;
            // 
            // direccion_completa
            // 
            this.direccion_completa.DataPropertyName = "direccion_completa";
            this.direccion_completa.HeaderText = "Direccion del Contribuyente";
            this.direccion_completa.Name = "direccion_completa";
            this.direccion_completa.ReadOnly = true;
            this.direccion_completa.Width = 300;
            // 
            // base_imponible
            // 
            this.base_imponible.DataPropertyName = "base_imponible";
            this.base_imponible.HeaderText = "Base Imponible";
            this.base_imponible.Name = "base_imponible";
            this.base_imponible.ReadOnly = true;
            // 
            // Frm_GrandeBaseImponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 262);
            this.Controls.Add(this.dgReporte);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_GrandeBaseImponible";
            this.Text = "Frm_GrandeBaseImponible";
            this.Load += new System.EventHandler(this.Frm_GrandeBaseImponible_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonGenerarReporte;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_completa;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_imponible;
    }
}