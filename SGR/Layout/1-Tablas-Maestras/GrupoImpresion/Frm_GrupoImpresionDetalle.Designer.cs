namespace SGR.WinApp.Layout._1_Tablas_Maestras.GrupoImpresion
{
    partial class Frm_GrupoImpresionDetalle
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cboTributo = new System.Windows.Forms.ComboBox();
            this.cboGrupoTipoImpresion = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoTributo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGrabar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(42, 180);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(126, 46);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tributo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupo Tipo Impresión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Periodo";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(22, 155);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(65, 17);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo ?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboTributo
            // 
            this.cboTributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTributo.FormattingEnabled = true;
            this.cboTributo.Location = new System.Drawing.Point(149, 120);
            this.cboTributo.Name = "cboTributo";
            this.cboTributo.Size = new System.Drawing.Size(223, 21);
            this.cboTributo.TabIndex = 5;
            // 
            // cboGrupoTipoImpresion
            // 
            this.cboGrupoTipoImpresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupoTipoImpresion.FormattingEnabled = true;
            this.cboGrupoTipoImpresion.Location = new System.Drawing.Point(149, 48);
            this.cboGrupoTipoImpresion.Name = "cboGrupoTipoImpresion";
            this.cboGrupoTipoImpresion.Size = new System.Drawing.Size(223, 21);
            this.cboGrupoTipoImpresion.TabIndex = 6;
            this.cboGrupoTipoImpresion.SelectedIndexChanged += new System.EventHandler(this.cboGrupoTipoImpresion_SelectedIndexChanged);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(149, 16);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(129, 21);
            this.cboPeriodo.TabIndex = 7;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(205, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Tributo";
            // 
            // cboTipoTributo
            // 
            this.cboTipoTributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTributo.FormattingEnabled = true;
            this.cboTipoTributo.Location = new System.Drawing.Point(149, 85);
            this.cboTipoTributo.Name = "cboTipoTributo";
            this.cboTipoTributo.Size = new System.Drawing.Size(223, 21);
            this.cboTipoTributo.TabIndex = 10;
            this.cboTipoTributo.SelectedIndexChanged += new System.EventHandler(this.cboTipoTributo_SelectedIndexChanged);
            // 
            // Frm_GrupoImpresionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 238);
            this.Controls.Add(this.cboTipoTributo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.cboGrupoTipoImpresion);
            this.Controls.Add(this.cboTributo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_GrupoImpresionDetalle";
            this.Text = "Frm_GrupoImpresionDetalle";
            this.Load += new System.EventHandler(this.Frm_GrupoImpresionDetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboTributo;
        private System.Windows.Forms.ComboBox cboGrupoTipoImpresion;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoTributo;
    }
}