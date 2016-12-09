namespace SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion
{
    partial class Frm_Inafectacion_Detalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Opciones de búsqueda por persona";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(198, 13);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(341, 20);
            this.txtBusqueda.TabIndex = 84;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::SGR.WinApp.Properties.Resources.search1;
            this.BtnBuscar.Location = new System.Drawing.Point(539, 12);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(32, 23);
            this.BtnBuscar.TabIndex = 83;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // cboPersona
            // 
            this.cboPersona.Enabled = false;
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(104, 50);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(489, 21);
            this.cboPersona.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Persona:";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(104, 88);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(140, 21);
            this.cboPeriodo.TabIndex = 89;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(10, 88);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 88;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // Frm_Inafectacion_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 262);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.BtnBuscar);
            this.Name = "Frm_Inafectacion_Detalle";
            this.Text = "Frm_Inafectacion_Detalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox cboPersona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
    }
}