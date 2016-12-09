namespace SGR.WinApp.Layout._4_Procesos.Predio.Otros
{
    partial class Frm_CertificadoContribuyente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.btnVerAlcabalaAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recibo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expediente";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(116, 13);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(230, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(116, 46);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(230, 20);
            this.txtExpediente.TabIndex = 4;
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(116, 79);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(230, 20);
            this.txtRecibo.TabIndex = 5;
            // 
            // btnVerAlcabalaAl
            // 
            this.btnVerAlcabalaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlcabalaAl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerAlcabalaAl.Image = global::SGR.WinApp.Properties.Resources.search;
            this.btnVerAlcabalaAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerAlcabalaAl.Location = new System.Drawing.Point(116, 110);
            this.btnVerAlcabalaAl.Name = "btnVerAlcabalaAl";
            this.btnVerAlcabalaAl.Size = new System.Drawing.Size(104, 32);
            this.btnVerAlcabalaAl.TabIndex = 179;
            this.btnVerAlcabalaAl.Text = "Ver ";
            this.btnVerAlcabalaAl.UseVisualStyleBackColor = true;
            this.btnVerAlcabalaAl.Click += new System.EventHandler(this.btnVerAlcabalaAl_Click);
            // 
            // Frm_CertificadoContribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(375, 154);
            this.Controls.Add(this.btnVerAlcabalaAl);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CertificadoContribuyente";
            this.Text = "Frm_CertificadoContribuyente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Button btnVerAlcabalaAl;
    }
}