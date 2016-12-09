namespace SGR.WinApp.Layout._1_Tablas_Maestras.Periodo
{
    partial class Frm_Periodo_Detalle
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTasaAlacabala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUitAlcabala = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoraAlcabala = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFactorOfi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTopeUit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFormulario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(312, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Location = new System.Drawing.Point(91, 175);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(62, 17);
            this.ckbEstado.TabIndex = 10;
            this.ckbEstado.Text = "Activo?";
            this.ckbEstado.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGrabar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(125, 212);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(127, 40);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnio.Location = new System.Drawing.Point(91, 13);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(143, 20);
            this.txtAnio.TabIndex = 1;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(91, 94);
            this.txtDescripcion.MaxLength = 240;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(143, 39);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tasa de Alcabala:";
            // 
            // txtTasaAlacabala
            // 
            this.txtTasaAlacabala.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasaAlacabala.Location = new System.Drawing.Point(372, 13);
            this.txtTasaAlacabala.Name = "txtTasaAlacabala";
            this.txtTasaAlacabala.Size = new System.Drawing.Size(133, 20);
            this.txtTasaAlacabala.TabIndex = 2;
            this.txtTasaAlacabala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaAlacabala_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "UIT:";
            // 
            // txtUit
            // 
            this.txtUit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUit.Location = new System.Drawing.Point(91, 39);
            this.txtUit.Name = "txtUit";
            this.txtUit.Size = new System.Drawing.Size(143, 20);
            this.txtUit.TabIndex = 3;
            this.txtUit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "UIT de Alcabala:";
            // 
            // txtUitAlcabala
            // 
            this.txtUitAlcabala.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUitAlcabala.Location = new System.Drawing.Point(372, 40);
            this.txtUitAlcabala.Name = "txtUitAlcabala";
            this.txtUitAlcabala.Size = new System.Drawing.Size(133, 20);
            this.txtUitAlcabala.TabIndex = 4;
            this.txtUitAlcabala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUitAlcabala_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mora de Alcabala:";
            // 
            // txtMoraAlcabala
            // 
            this.txtMoraAlcabala.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMoraAlcabala.Location = new System.Drawing.Point(372, 66);
            this.txtMoraAlcabala.Name = "txtMoraAlcabala";
            this.txtMoraAlcabala.Size = new System.Drawing.Size(133, 20);
            this.txtMoraAlcabala.TabIndex = 6;
            this.txtMoraAlcabala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoraAlcabala_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Factor Oficializa:";
            // 
            // txtFactorOfi
            // 
            this.txtFactorOfi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFactorOfi.Location = new System.Drawing.Point(372, 93);
            this.txtFactorOfi.Name = "txtFactorOfi";
            this.txtFactorOfi.Size = new System.Drawing.Size(133, 20);
            this.txtFactorOfi.TabIndex = 7;
            this.txtFactorOfi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactorOfi_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Interes:";
            // 
            // txtInteres
            // 
            this.txtInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInteres.Location = new System.Drawing.Point(91, 65);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(143, 20);
            this.txtInteres.TabIndex = 5;
            this.txtInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteres_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(309, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "TopeUIT:";
            // 
            // txtTopeUit
            // 
            this.txtTopeUit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTopeUit.Location = new System.Drawing.Point(372, 145);
            this.txtTopeUit.Name = "txtTopeUit";
            this.txtTopeUit.Size = new System.Drawing.Size(133, 20);
            this.txtTopeUit.TabIndex = 9;
            this.txtTopeUit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopeUit_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Minimo de Predio:";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(372, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Formulario:";
            // 
            // txtFormulario
            // 
            this.txtFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormulario.Location = new System.Drawing.Point(91, 142);
            this.txtFormulario.Name = "txtFormulario";
            this.txtFormulario.Size = new System.Drawing.Size(143, 20);
            this.txtFormulario.TabIndex = 41;
            this.txtFormulario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormulario_KeyPress);
            // 
            // Frm_Periodo_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(530, 277);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFormulario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTopeUit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFactorOfi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMoraAlcabala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUitAlcabala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTasaAlacabala);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ckbEstado);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Periodo_Detalle";
            this.Text = "Detalle de Periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTasaAlacabala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUitAlcabala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoraAlcabala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFactorOfi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTopeUit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFormulario;
    }
}