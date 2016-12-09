namespace SGR.WinApp.Layout._1_Tablas_Maestras.Arancel
{
    partial class Frm_Arancel_Detalle
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoArancel = new System.Windows.Forms.TextBox();
            this.txtCuadra = new System.Windows.Forms.TextBox();
            this.comboAnio = new System.Windows.Forms.ComboBox();
            this.comboSector = new System.Windows.Forms.ComboBox();
            this.comboCalle = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIDoculto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sector:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuadra:";
            // 
            // txtMontoArancel
            // 
            this.txtMontoArancel.Location = new System.Drawing.Point(297, 17);
            this.txtMontoArancel.MaxLength = 10;
            this.txtMontoArancel.Name = "txtMontoArancel";
            this.txtMontoArancel.Size = new System.Drawing.Size(163, 20);
            this.txtMontoArancel.TabIndex = 2;
            this.txtMontoArancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoArancel_KeyPress);
            // 
            // txtCuadra
            // 
            this.txtCuadra.Location = new System.Drawing.Point(62, 98);
            this.txtCuadra.MaxLength = 20;
            this.txtCuadra.Name = "txtCuadra";
            this.txtCuadra.Size = new System.Drawing.Size(163, 20);
            this.txtCuadra.TabIndex = 5;
            this.txtCuadra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuadra_KeyPress);
            // 
            // comboAnio
            // 
            this.comboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnio.FormattingEnabled = true;
            this.comboAnio.Location = new System.Drawing.Point(62, 17);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.Size = new System.Drawing.Size(163, 21);
            this.comboAnio.TabIndex = 1;
            // 
            // comboSector
            // 
            this.comboSector.FormattingEnabled = true;
            this.comboSector.Location = new System.Drawing.Point(62, 56);
            this.comboSector.Name = "comboSector";
            this.comboSector.Size = new System.Drawing.Size(163, 21);
            this.comboSector.TabIndex = 3;
            this.comboSector.SelectedIndexChanged += new System.EventHandler(this.comboSector_SelectedIndexChanged);
            // 
            // comboCalle
            // 
            this.comboCalle.FormattingEnabled = true;
            this.comboCalle.Location = new System.Drawing.Point(297, 56);
            this.comboCalle.Name = "comboCalle";
            this.comboCalle.Size = new System.Drawing.Size(163, 21);
            this.comboCalle.TabIndex = 4;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(62, 136);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGrabar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(85, 174);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(123, 46);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(241, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 46);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIDoculto
            // 
            this.txtIDoculto.Location = new System.Drawing.Point(297, 133);
            this.txtIDoculto.Name = "txtIDoculto";
            this.txtIDoculto.Size = new System.Drawing.Size(163, 20);
            this.txtIDoculto.TabIndex = 13;
            this.txtIDoculto.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Codigo:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lado: ";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(297, 98);
            this.txtLado.MaxLength = 3;
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(163, 20);
            this.txtLado.TabIndex = 6;
            this.txtLado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado_KeyPress);
            // 
            // Frm_Arancel_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 236);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDoculto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.comboCalle);
            this.Controls.Add(this.comboSector);
            this.Controls.Add(this.comboAnio);
            this.Controls.Add(this.txtCuadra);
            this.Controls.Add(this.txtMontoArancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Arancel_Detalle";
            this.Text = "Detalle de Arancel";
            this.Load += new System.EventHandler(this.Frm_Arancel_Detalle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Arancel_Detalle_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoArancel;
        private System.Windows.Forms.TextBox txtCuadra;
        private System.Windows.Forms.ComboBox comboAnio;
        private System.Windows.Forms.ComboBox comboSector;
        private System.Windows.Forms.ComboBox comboCalle;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIDoculto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLado;
    }
}