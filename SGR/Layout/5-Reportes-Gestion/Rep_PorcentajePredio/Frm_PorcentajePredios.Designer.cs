namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_PorcentajePredio
{
    partial class Frm_PorcentajePredios
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
            this.botonGenerarReporte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboHasta = new System.Windows.Forms.ComboBox();
            this.cboDesde = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtRusticoUrbano = new System.Windows.Forms.RadioButton();
            this.rbtClasiDepreciacion = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGenerarReporte
            // 
            this.botonGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarReporte.Location = new System.Drawing.Point(236, 108);
            this.botonGenerarReporte.Name = "botonGenerarReporte";
            this.botonGenerarReporte.Size = new System.Drawing.Size(155, 41);
            this.botonGenerarReporte.TabIndex = 9;
            this.botonGenerarReporte.Text = "Generar Reporte";
            this.botonGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarReporte.UseVisualStyleBackColor = true;
            this.botonGenerarReporte.Click += new System.EventHandler(this.botonGenerarReporte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasta:";
            // 
            // cboHasta
            // 
            this.cboHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHasta.FormattingEnabled = true;
            this.cboHasta.Location = new System.Drawing.Point(236, 31);
            this.cboHasta.Name = "cboHasta";
            this.cboHasta.Size = new System.Drawing.Size(85, 21);
            this.cboHasta.TabIndex = 5;
            // 
            // cboDesde
            // 
            this.cboDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesde.FormattingEnabled = true;
            this.cboDesde.Location = new System.Drawing.Point(73, 31);
            this.cboDesde.Name = "cboDesde";
            this.cboDesde.Size = new System.Drawing.Size(85, 21);
            this.cboDesde.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.rbtClasiDepreciacion);
            this.groupBox1.Controls.Add(this.rbtRusticoUrbano);
            this.groupBox1.Controls.Add(this.cboDesde);
            this.groupBox1.Controls.Add(this.cboHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 71);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // rbtRusticoUrbano
            // 
            this.rbtRusticoUrbano.AutoSize = true;
            this.rbtRusticoUrbano.Location = new System.Drawing.Point(382, 32);
            this.rbtRusticoUrbano.Name = "rbtRusticoUrbano";
            this.rbtRusticoUrbano.Size = new System.Drawing.Size(127, 17);
            this.rbtRusticoUrbano.TabIndex = 6;
            this.rbtRusticoUrbano.TabStop = true;
            this.rbtRusticoUrbano.Text = "Rústico/Urbano";
            this.rbtRusticoUrbano.UseVisualStyleBackColor = true;
            // 
            // rbtClasiDepreciacion
            // 
            this.rbtClasiDepreciacion.AutoSize = true;
            this.rbtClasiDepreciacion.Location = new System.Drawing.Point(515, 32);
            this.rbtClasiDepreciacion.Name = "rbtClasiDepreciacion";
            this.rbtClasiDepreciacion.Size = new System.Drawing.Size(196, 17);
            this.rbtClasiDepreciacion.TabIndex = 7;
            this.rbtClasiDepreciacion.TabStop = true;
            this.rbtClasiDepreciacion.Text = "Clasificación Depreciacion";
            this.rbtClasiDepreciacion.UseVisualStyleBackColor = true;
            // 
            // Frm_PorcentajePredios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 190);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonGenerarReporte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_PorcentajePredios";
            this.Text = "PORCENTAJE PREDIOS";
            this.Load += new System.EventHandler(this.Frm_PorcentajePredios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonGenerarReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHasta;
        private System.Windows.Forms.ComboBox cboDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtClasiDepreciacion;
        private System.Windows.Forms.RadioButton rbtRusticoUrbano;
    }
}