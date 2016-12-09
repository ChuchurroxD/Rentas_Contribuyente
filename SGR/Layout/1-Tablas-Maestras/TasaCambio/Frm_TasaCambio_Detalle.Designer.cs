namespace SGR.WinApp.Layout._1_Tablas_Maestras.TasaCambio
{
    partial class Frm_TasaCambio_Detalle
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.botonGrabar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidTasaCambio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Compra:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(106, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(143, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2016, 9, 5, 0, 9, 5, 0);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(105, 65);
            this.txtPrecioVenta.MaxLength = 6;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(143, 20);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(105, 95);
            this.txtPrecioCompra.MaxLength = 6;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(146, 20);
            this.txtPrecioCompra.TabIndex = 5;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(106, 129);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(65, 17);
            this.chkEstado.TabIndex = 6;
            this.chkEstado.Text = "Activo ?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // botonGrabar
            // 
            this.botonGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGrabar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonGrabar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.botonGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGrabar.Location = new System.Drawing.Point(18, 160);
            this.botonGrabar.Name = "botonGrabar";
            this.botonGrabar.Size = new System.Drawing.Size(123, 46);
            this.botonGrabar.TabIndex = 7;
            this.botonGrabar.Text = "Grabar";
            this.botonGrabar.UseVisualStyleBackColor = true;
            this.botonGrabar.Click += new System.EventHandler(this.botonGrabar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelar.Location = new System.Drawing.Point(165, 160);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(123, 46);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(26, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo Oculto:";
            this.label4.Visible = false;
            // 
            // txtidTasaCambio
            // 
            this.txtidTasaCambio.Enabled = false;
            this.txtidTasaCambio.Location = new System.Drawing.Point(106, 6);
            this.txtidTasaCambio.Name = "txtidTasaCambio";
            this.txtidTasaCambio.Size = new System.Drawing.Size(143, 20);
            this.txtidTasaCambio.TabIndex = 10;
            this.txtidTasaCambio.Visible = false;
            // 
            // Frm_TasaCambio_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 218);
            this.Controls.Add(this.txtidTasaCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonGrabar);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TasaCambio_Detalle";
            this.Text = "Detalle de Tasa Cambio";
            this.Load += new System.EventHandler(this.Frm_TasaCambio_Detalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button botonGrabar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidTasaCambio;
    }
}