namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial
{
    partial class Frm_RepGerencial
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPeriodo1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPeriodo2 = new System.Windows.Forms.ComboBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPeriodo3 = new System.Windows.Forms.ComboBox();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPeriodo4 = new System.Windows.Forms.ComboBox();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboPeriodo1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INGRESOS POR MES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AÑO:";
            // 
            // cboPeriodo1
            // 
            this.cboPeriodo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo1.FormattingEnabled = true;
            this.cboPeriodo1.Location = new System.Drawing.Point(372, 14);
            this.cboPeriodo1.Name = "cboPeriodo1";
            this.cboPeriodo1.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo1.TabIndex = 1;
            this.cboPeriodo1.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo1_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout.5-Reportes-Gestion.Rep_Gerencial.rpt_IngresosMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(918, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cboPeriodo2);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "POR TIPO DE PAGO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AÑO:";
            // 
            // cboPeriodo2
            // 
            this.cboPeriodo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo2.FormattingEnabled = true;
            this.cboPeriodo2.Location = new System.Drawing.Point(372, 14);
            this.cboPeriodo2.Name = "cboPeriodo2";
            this.cboPeriodo2.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo2.TabIndex = 2;
            this.cboPeriodo2.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo2_SelectedIndexChanged);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(3, 45);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(918, 506);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cboPeriodo3);
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(921, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FRACCIONAMIENTOS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "AÑO:";
            // 
            // cboPeriodo3
            // 
            this.cboPeriodo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo3.FormattingEnabled = true;
            this.cboPeriodo3.Location = new System.Drawing.Point(372, 14);
            this.cboPeriodo3.Name = "cboPeriodo3";
            this.cboPeriodo3.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo3.TabIndex = 2;
            this.cboPeriodo3.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo3_SelectedIndexChanged);
            // 
            // reportViewer3
            // 
            this.reportViewer3.Location = new System.Drawing.Point(3, 45);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(918, 507);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.cboPeriodo4);
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(921, 557);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "EMISIÓN DE TIPO TRIBUTO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AÑO:";
            // 
            // cboPeriodo4
            // 
            this.cboPeriodo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo4.FormattingEnabled = true;
            this.cboPeriodo4.Location = new System.Drawing.Point(372, 14);
            this.cboPeriodo4.Name = "cboPeriodo4";
            this.cboPeriodo4.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo4.TabIndex = 2;
            this.cboPeriodo4.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo4_SelectedIndexChanged);
            // 
            // reportViewer4
            // 
            this.reportViewer4.Location = new System.Drawing.Point(3, 45);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(915, 507);
            this.reportViewer4.TabIndex = 0;
            // 
            // Frm_RepGerencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 598);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_RepGerencial";
            this.Text = "REPORTE GERENCIAL";
            this.Load += new System.EventHandler(this.Frm_RepGerencial_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPeriodo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPeriodo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPeriodo3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPeriodo4;
    }
}