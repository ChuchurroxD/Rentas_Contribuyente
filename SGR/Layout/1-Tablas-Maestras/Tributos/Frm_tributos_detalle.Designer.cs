namespace SGR.WinApp.Layout._1_Tablas_Maestras.Tributos
{
    partial class Frm_tributos_detalle
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtPorcentajeUIT = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboClasificacionIngresos = new System.Windows.Forms.ComboBox();
            this.cboTipoTributo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCobroIntereses = new System.Windows.Forms.CheckBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.cboArea1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboArea2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentajeArea = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(681, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 46);
            this.btnCancelar.TabIndex = 29;
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
            this.btnGrabar.Location = new System.Drawing.Point(509, 238);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(143, 46);
            this.btnGrabar.TabIndex = 28;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtPorcentajeUIT
            // 
            this.txtPorcentajeUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeUIT.Location = new System.Drawing.Point(139, 146);
            this.txtPorcentajeUIT.MaxLength = 20;
            this.txtPorcentajeUIT.Name = "txtPorcentajeUIT";
            this.txtPorcentajeUIT.Size = new System.Drawing.Size(89, 20);
            this.txtPorcentajeUIT.TabIndex = 27;
            this.txtPorcentajeUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeUIT_KeyPress);
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(113, 105);
            this.txtImporte.MaxLength = 20;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(89, 20);
            this.txtImporte.TabIndex = 26;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(113, 63);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(367, 20);
            this.txtDescripcion.TabIndex = 25;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbreviatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbreviatura.Location = new System.Drawing.Point(376, 25);
            this.txtAbreviatura.MaxLength = 10;
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(104, 20);
            this.txtAbreviatura.TabIndex = 24;
            this.txtAbreviatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbreviatura_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(113, 28);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 20);
            this.txtCodigo.TabIndex = 23;
            // 
            // cboClasificacionIngresos
            // 
            this.cboClasificacionIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacionIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasificacionIngresos.FormattingEnabled = true;
            this.cboClasificacionIngresos.Location = new System.Drawing.Point(205, 19);
            this.cboClasificacionIngresos.Name = "cboClasificacionIngresos";
            this.cboClasificacionIngresos.Size = new System.Drawing.Size(480, 21);
            this.cboClasificacionIngresos.TabIndex = 22;
            // 
            // cboTipoTributo
            // 
            this.cboTipoTributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoTributo.FormattingEnabled = true;
            this.cboTipoTributo.Location = new System.Drawing.Point(237, 105);
            this.cboTipoTributo.Name = "cboTipoTributo";
            this.cboTipoTributo.Size = new System.Drawing.Size(242, 21);
            this.cboTipoTributo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Porcentaje UIT (%)";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(42, 247);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 19;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Abrev.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Importe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo";
            // 
            // chkCobroIntereses
            // 
            this.chkCobroIntereses.AutoSize = true;
            this.chkCobroIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCobroIntereses.Location = new System.Drawing.Point(131, 247);
            this.chkCobroIntereses.Name = "chkCobroIntereses";
            this.chkCobroIntereses.Size = new System.Drawing.Size(69, 17);
            this.chkCobroIntereses.TabIndex = 30;
            this.chkCobroIntereses.Text = "Intereses";
            this.chkCobroIntereses.UseVisualStyleBackColor = true;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(27, 19);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(140, 21);
            this.cboPeriodo.TabIndex = 31;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // cboArea1
            // 
            this.cboArea1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea1.FormattingEnabled = true;
            this.cboArea1.Location = new System.Drawing.Point(31, 19);
            this.cboArea1.Name = "cboArea1";
            this.cboArea1.Size = new System.Drawing.Size(255, 21);
            this.cboArea1.TabIndex = 32;
            this.cboArea1.SelectedIndexChanged += new System.EventHandler(this.cboArea1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboArea2);
            this.groupBox1.Controls.Add(this.cboArea1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(502, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 108);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area";
            // 
            // cboArea2
            // 
            this.cboArea2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea2.FormattingEnabled = true;
            this.cboArea2.Location = new System.Drawing.Point(31, 62);
            this.cboArea2.Name = "cboArea2";
            this.cboArea2.Size = new System.Drawing.Size(255, 21);
            this.cboArea2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Porcentaje Area (%)";
            // 
            // txtPorcentajeArea
            // 
            this.txtPorcentajeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeArea.Location = new System.Drawing.Point(366, 146);
            this.txtPorcentajeArea.MaxLength = 20;
            this.txtPorcentajeArea.Name = "txtPorcentajeArea";
            this.txtPorcentajeArea.Size = new System.Drawing.Size(89, 20);
            this.txtPorcentajeArea.TabIndex = 35;
            this.txtPorcentajeArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeArea_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPeriodo);
            this.groupBox2.Controls.Add(this.cboClasificacionIngresos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 57);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tipo Tributo";
            // 
            // Frm_tributos_detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 296);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPorcentajeArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCobroIntereses);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtPorcentajeUIT);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAbreviatura);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboTipoTributo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_tributos_detalle";
            this.Text = "Gestionar Tributos detalle";
            this.Load += new System.EventHandler(this.Frm_tributos_detalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtPorcentajeUIT;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAbreviatura;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboClasificacionIngresos;
        private System.Windows.Forms.ComboBox cboTipoTributo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCobroIntereses;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.ComboBox cboArea1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboArea2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorcentajeArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
    }
}