namespace SGR.WinApp.Layout._4_Procesos.Predio
{
    partial class Frm_Errores
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
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcelErrores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.SuspendLayout();
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
            this.dgvErrores.Location = new System.Drawing.Point(12, 54);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.Size = new System.Drawing.Size(668, 356);
            this.dgvErrores.TabIndex = 11;
            this.dgvErrores.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvErrores_RowPostPaint);
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción de Error";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 650;
            // 
            // btnExcelErrores
            // 
            this.btnExcelErrores.Image = global::SGR.WinApp.Properties.Resources.page_white_copy;
            this.btnExcelErrores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelErrores.Location = new System.Drawing.Point(12, 12);
            this.btnExcelErrores.Name = "btnExcelErrores";
            this.btnExcelErrores.Size = new System.Drawing.Size(106, 36);
            this.btnExcelErrores.TabIndex = 17;
            this.btnExcelErrores.Text = "ERRORES";
            this.btnExcelErrores.UseVisualStyleBackColor = true;
            this.btnExcelErrores.Click += new System.EventHandler(this.btnExcelErrores_Click);
            // 
            // Frm_Errores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(724, 422);
            this.Controls.Add(this.btnExcelErrores);
            this.Controls.Add(this.dgvErrores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Errores";
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnExcelErrores;
    }
}