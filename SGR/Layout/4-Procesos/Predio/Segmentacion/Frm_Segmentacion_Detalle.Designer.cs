namespace SGR.WinApp.Layout._4_Procesos.Predio.Segmentacion
{
    partial class Frm_Segmentacion_Detalle
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
            this.lblSegmentacion = new System.Windows.Forms.Label();
            this.cboSegmentacion = new System.Windows.Forms.ComboBox();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSegmentacion
            // 
            this.lblSegmentacion.AutoSize = true;
            this.lblSegmentacion.Location = new System.Drawing.Point(31, 35);
            this.lblSegmentacion.Name = "lblSegmentacion";
            this.lblSegmentacion.Size = new System.Drawing.Size(78, 13);
            this.lblSegmentacion.TabIndex = 0;
            this.lblSegmentacion.Text = "Segmentación:";
            // 
            // cboSegmentacion
            // 
            this.cboSegmentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSegmentacion.FormattingEnabled = true;
            this.cboSegmentacion.Location = new System.Drawing.Point(116, 31);
            this.cboSegmentacion.Name = "cboSegmentacion";
            this.cboSegmentacion.Size = new System.Drawing.Size(269, 21);
            this.cboSegmentacion.TabIndex = 1;
            // 
            // cboPersona
            // 
            this.cboPersona.Enabled = false;
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(116, 95);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(435, 21);
            this.cboPersona.TabIndex = 80;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(31, 103);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(49, 13);
            this.lblPersona.TabIndex = 81;
            this.lblPersona.Text = "Persona:";
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Checked = true;
            this.ckbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEstado.Location = new System.Drawing.Point(34, 138);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(59, 17);
            this.ckbEstado.TabIndex = 82;
            this.ckbEstado.Text = "Estado";
            this.ckbEstado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(342, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 34);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.Image = global::SGR.WinApp.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(107, 174);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 34);
            this.btnGuardar.TabIndex = 83;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Opciones de búsqueda por persona";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(213, 65);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(316, 20);
            this.txtBusqueda.TabIndex = 107;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::SGR.WinApp.Properties.Resources.search1;
            this.BtnBuscar.Location = new System.Drawing.Point(532, 63);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(32, 23);
            this.BtnBuscar.TabIndex = 106;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Frm_Segmentacion_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ckbEstado);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.cboSegmentacion);
            this.Controls.Add(this.lblSegmentacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Segmentacion_Detalle";
            this.Text = "SegmentacionDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSegmentacion;
        private System.Windows.Forms.ComboBox cboSegmentacion;
        private System.Windows.Forms.ComboBox cboPersona;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button BtnBuscar;
    }
}