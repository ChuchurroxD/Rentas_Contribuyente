namespace SGR.WinApp.Layout._1_Tablas_Maestras.Segmentacion
{
    partial class Frm_SegmentacionDetalle
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
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMontoInicio = new System.Windows.Forms.Label();
            this.lblMontoFin = new System.Windows.Forms.Label();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMontoFin = new System.Windows.Forms.TextBox();
            this.txtMontoInicio = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.rbtCargo = new System.Windows.Forms.RadioButton();
            this.rbtAbono = new System.Windows.Forms.RadioButton();
            this.rbtSaldo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(26, 26);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 0;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:\r\n";
            // 
            // lblMontoInicio
            // 
            this.lblMontoInicio.AutoSize = true;
            this.lblMontoInicio.Location = new System.Drawing.Point(26, 57);
            this.lblMontoInicio.Name = "lblMontoInicio";
            this.lblMontoInicio.Size = new System.Drawing.Size(68, 13);
            this.lblMontoInicio.TabIndex = 2;
            this.lblMontoInicio.Text = "Monto Inicio:";
            // 
            // lblMontoFin
            // 
            this.lblMontoFin.AutoSize = true;
            this.lblMontoFin.Location = new System.Drawing.Point(252, 57);
            this.lblMontoFin.Name = "lblMontoFin";
            this.lblMontoFin.Size = new System.Drawing.Size(57, 13);
            this.lblMontoFin.TabIndex = 6;
            this.lblMontoFin.Text = "Monto Fin:";
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Checked = true;
            this.ckbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEstado.Location = new System.Drawing.Point(255, 92);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(59, 17);
            this.ckbEstado.TabIndex = 9;
            this.ckbEstado.Text = "Estado";
            this.ckbEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(100, 124);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(212, 35);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtMontoFin
            // 
            this.txtMontoFin.Location = new System.Drawing.Point(315, 54);
            this.txtMontoFin.Name = "txtMontoFin";
            this.txtMontoFin.Size = new System.Drawing.Size(100, 20);
            this.txtMontoFin.TabIndex = 12;
            this.txtMontoFin.Text = "0";
            this.txtMontoFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoFin_KeyPress);
            // 
            // txtMontoInicio
            // 
            this.txtMontoInicio.Location = new System.Drawing.Point(100, 54);
            this.txtMontoInicio.Name = "txtMontoInicio";
            this.txtMontoInicio.Size = new System.Drawing.Size(100, 20);
            this.txtMontoInicio.TabIndex = 13;
            this.txtMontoInicio.Text = "0";
            this.txtMontoInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoInicio_KeyPress);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(100, 23);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodo.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(239, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 46);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGrabar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(57, 184);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(123, 46);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // rbtCargo
            // 
            this.rbtCargo.AutoSize = true;
            this.rbtCargo.Checked = true;
            this.rbtCargo.Location = new System.Drawing.Point(29, 92);
            this.rbtCargo.Name = "rbtCargo";
            this.rbtCargo.Size = new System.Drawing.Size(53, 17);
            this.rbtCargo.TabIndex = 17;
            this.rbtCargo.TabStop = true;
            this.rbtCargo.Text = "Cargo";
            this.rbtCargo.UseVisualStyleBackColor = true;
            // 
            // rbtAbono
            // 
            this.rbtAbono.AutoSize = true;
            this.rbtAbono.Location = new System.Drawing.Point(100, 92);
            this.rbtAbono.Name = "rbtAbono";
            this.rbtAbono.Size = new System.Drawing.Size(56, 17);
            this.rbtAbono.TabIndex = 18;
            this.rbtAbono.Text = "Abono";
            this.rbtAbono.UseVisualStyleBackColor = true;
            // 
            // rbtSaldo
            // 
            this.rbtSaldo.AutoSize = true;
            this.rbtSaldo.Location = new System.Drawing.Point(173, 92);
            this.rbtSaldo.Name = "rbtSaldo";
            this.rbtSaldo.Size = new System.Drawing.Size(52, 17);
            this.rbtSaldo.TabIndex = 19;
            this.rbtSaldo.TabStop = true;
            this.rbtSaldo.Text = "Saldo";
            this.rbtSaldo.UseVisualStyleBackColor = true;
            // 
            // Frm_SegmentacionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(441, 245);
            this.Controls.Add(this.rbtSaldo);
            this.Controls.Add(this.rbtAbono);
            this.Controls.Add(this.rbtCargo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtMontoInicio);
            this.Controls.Add(this.txtMontoFin);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.ckbEstado);
            this.Controls.Add(this.lblMontoFin);
            this.Controls.Add(this.lblMontoInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPeriodo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SegmentacionDetalle";
            this.Text = "Detalle de Segmentación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMontoInicio;
        private System.Windows.Forms.Label lblMontoFin;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMontoFin;
        private System.Windows.Forms.TextBox txtMontoInicio;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.RadioButton rbtCargo;
        private System.Windows.Forms.RadioButton rbtAbono;
        private System.Windows.Forms.RadioButton rbtSaldo;
    }
}