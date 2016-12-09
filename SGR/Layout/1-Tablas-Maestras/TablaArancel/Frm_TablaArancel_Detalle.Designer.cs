namespace SGR.WinApp.Layout._1_Tablas_Maestras.TablaArancel
{
    partial class Frm_TablaArancel_Detalle
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
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtCodigoOculto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(90, 66);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(65, 17);
            this.chkEstado.TabIndex = 2;
            this.chkEstado.Text = "Activo ?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtCodigoOculto
            // 
            this.txtCodigoOculto.Enabled = false;
            this.txtCodigoOculto.Location = new System.Drawing.Point(89, 7);
            this.txtCodigoOculto.Name = "txtCodigoOculto";
            this.txtCodigoOculto.Size = new System.Drawing.Size(175, 20);
            this.txtCodigoOculto.TabIndex = 0;
            this.txtCodigoOculto.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(90, 31);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(175, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonGuardar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.botonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGuardar.Location = new System.Drawing.Point(14, 107);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(123, 46);
            this.botonGuardar.TabIndex = 5;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelar.Location = new System.Drawing.Point(159, 107);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(123, 46);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // Frm_TablaArancel_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 168);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoOculto);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TablaArancel_Detalle";
            this.Text = "Detalle de Tabla Arancel";
            this.Load += new System.EventHandler(this.Frm_TablaArancel_Detalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtCodigoOculto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonCancelar;
    }
}