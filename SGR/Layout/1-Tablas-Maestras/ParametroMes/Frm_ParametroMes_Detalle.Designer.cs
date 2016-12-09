namespace SGR.WinApp.Layout._1_Tablas_Maestras.ParametroMes
{
    partial class Frm_ParametroMes_Detalle
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtParametroMesID = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboPeriodo = new System.Windows.Forms.ComboBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.botonGrabar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Emision:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Vencimiento:";
            // 
            // txtParametroMesID
            // 
            this.txtParametroMesID.Location = new System.Drawing.Point(121, 12);
            this.txtParametroMesID.Name = "txtParametroMesID";
            this.txtParametroMesID.Size = new System.Drawing.Size(164, 20);
            this.txtParametroMesID.TabIndex = 6;
            this.txtParametroMesID.Visible = false;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(121, 76);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(164, 20);
            this.txtMes.TabIndex = 2;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(121, 40);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(164, 21);
            this.comboTipo.TabIndex = 1;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // comboPeriodo
            // 
            this.comboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeriodo.FormattingEnabled = true;
            this.comboPeriodo.Location = new System.Drawing.Point(122, 112);
            this.comboPeriodo.Name = "comboPeriodo";
            this.comboPeriodo.Size = new System.Drawing.Size(163, 21);
            this.comboPeriodo.TabIndex = 3;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(122, 148);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(163, 20);
            this.dtpFechaEmision.TabIndex = 4;
            this.dtpFechaEmision.Value = new System.DateTime(2016, 6, 13, 0, 0, 0, 0);
            this.dtpFechaEmision.ValueChanged += new System.EventHandler(this.dtpFechaEmision_ValueChanged);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(121, 183);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(164, 20);
            this.dtpFechaVencimiento.TabIndex = 5;
            this.dtpFechaVencimiento.Value = new System.DateTime(2016, 6, 13, 0, 0, 0, 0);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(121, 220);
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
            this.botonGrabar.Location = new System.Drawing.Point(40, 267);
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
            this.botonCancelar.Location = new System.Drawing.Point(183, 267);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(123, 46);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // Frm_ParametroMes_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 334);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonGrabar);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.comboPeriodo);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtParametroMesID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ParametroMes_Detalle";
            this.Text = "Detalle Parametro Mes";
            this.Load += new System.EventHandler(this.Frm_ParametroMes_Detalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParametroMesID;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button botonGrabar;
        private System.Windows.Forms.Button botonCancelar;
    }
}