namespace SGR.WinApp.Layout._4_Procesos.Coactivo
{
    partial class Frm_Notificacion
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
            this.txtExpedienteAnio = new System.Windows.Forms.TextBox();
            this.txtExpedienteN = new System.Windows.Forms.TextBox();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpedienteAnio
            // 
            this.txtExpedienteAnio.Location = new System.Drawing.Point(297, 31);
            this.txtExpedienteAnio.Name = "txtExpedienteAnio";
            this.txtExpedienteAnio.Size = new System.Drawing.Size(71, 20);
            this.txtExpedienteAnio.TabIndex = 172;
            // 
            // txtExpedienteN
            // 
            this.txtExpedienteN.Location = new System.Drawing.Point(177, 31);
            this.txtExpedienteN.Name = "txtExpedienteN";
            this.txtExpedienteN.Size = new System.Drawing.Size(97, 20);
            this.txtExpedienteN.TabIndex = 171;
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Location = new System.Drawing.Point(43, 34);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(60, 13);
            this.lblExpediente.TabIndex = 170;
            this.lblExpediente.Text = "Expediente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 169;
            this.label4.Text = "-";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(176, 74);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(114, 20);
            this.dtpFecha.TabIndex = 175;
            this.dtpFecha.Visible = false;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(43, 77);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(76, 13);
            this.lblFechaEmision.TabIndex = 174;
            this.lblFechaEmision.Text = "Fecha Emisión";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 177;
            this.dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 176;
            this.label1.Text = "Fecha de Notificación";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnviar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(151, 168);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(123, 32);
            this.btnEnviar.TabIndex = 178;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Frm_Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 229);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.txtExpedienteAnio);
            this.Controls.Add(this.txtExpedienteN);
            this.Controls.Add(this.lblExpediente);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Notificacion";
            this.Text = "Notificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpedienteAnio;
        private System.Windows.Forms.TextBox txtExpedienteN;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
    }
}