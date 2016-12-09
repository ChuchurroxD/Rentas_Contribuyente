namespace SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion
{
    partial class Frm_Resolucion
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
            this.ptbResolucion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbResolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbResolucion
            // 
            this.ptbResolucion.Location = new System.Drawing.Point(12, 12);
            this.ptbResolucion.Name = "ptbResolucion";
            this.ptbResolucion.Size = new System.Drawing.Size(625, 487);
            this.ptbResolucion.TabIndex = 4;
            this.ptbResolucion.TabStop = false;
            // 
            // Frm_Resolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(649, 511);
            this.Controls.Add(this.ptbResolucion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Resolucion";
            this.Text = "Resolución";
            ((System.ComponentModel.ISupportInitialize)(this.ptbResolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbResolucion;
    }
}