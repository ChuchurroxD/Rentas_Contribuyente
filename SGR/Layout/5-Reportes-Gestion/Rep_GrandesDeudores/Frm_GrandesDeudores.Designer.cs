namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_GrandesDeudores
{
    partial class Frm_GrandesDeudores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.cboDesde = new System.Windows.Forms.ComboBox();
            this.cboHasta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonGenerarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deudaPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deudaArbitrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deudaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboSector);
            this.groupBox1.Controls.Add(this.cboDesde);
            this.groupBox1.Controls.Add(this.cboHasta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botonGenerarReporte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(707, 26);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(598, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(74, 21);
            this.txtNumero.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Tag = "";
            this.label4.Text = "Número:";
            // 
            // cboSector
            // 
            this.cboSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(70, 29);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(121, 21);
            this.cboSector.TabIndex = 6;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.cboSector_SelectedIndexChanged);
            // 
            // cboDesde
            // 
            this.cboDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesde.FormattingEnabled = true;
            this.cboDesde.Location = new System.Drawing.Point(261, 30);
            this.cboDesde.Name = "cboDesde";
            this.cboDesde.Size = new System.Drawing.Size(85, 21);
            this.cboDesde.TabIndex = 4;
            // 
            // cboHasta
            // 
            this.cboHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHasta.FormattingEnabled = true;
            this.cboHasta.Location = new System.Drawing.Point(424, 30);
            this.cboHasta.Name = "cboHasta";
            this.cboHasta.Size = new System.Drawing.Size(85, 21);
            this.cboHasta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde:";
            // 
            // botonGenerarReporte
            // 
            this.botonGenerarReporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarReporte.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonGenerarReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.botonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerarReporte.Location = new System.Drawing.Point(822, 21);
            this.botonGenerarReporte.Name = "botonGenerarReporte";
            this.botonGenerarReporte.Size = new System.Drawing.Size(159, 34);
            this.botonGenerarReporte.TabIndex = 2;
            this.botonGenerarReporte.Text = "Generar Reporte";
            this.botonGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerarReporte.UseVisualStyleBackColor = true;
            this.botonGenerarReporte.Click += new System.EventHandler(this.botonGenerarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sector:";
            // 
            // dgReporte
            // 
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row,
            this.Persona_id,
            this.Nombre,
            this.documento,
            this.tipo,
            this.representante,
            this.sector,
            this.calle,
            this.nroCalle,
            this.mz,
            this.lote,
            this.telefono,
            this.deudaPredio,
            this.deudaArbitrio,
            this.deudaTotal});
            this.dgReporte.Location = new System.Drawing.Point(0, 72);
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.Size = new System.Drawing.Size(987, 328);
            this.dgReporte.TabIndex = 3;
            // 
            // Row
            // 
            this.Row.DataPropertyName = "row";
            this.Row.HeaderText = "Row";
            this.Row.Name = "Row";
            // 
            // Persona_id
            // 
            this.Persona_id.DataPropertyName = "persona_id";
            this.Persona_id.HeaderText = "Persona ID";
            this.Persona_id.Name = "Persona_id";
            this.Persona_id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // representante
            // 
            this.representante.DataPropertyName = "representante";
            this.representante.HeaderText = "Representante";
            this.representante.Name = "representante";
            // 
            // sector
            // 
            this.sector.DataPropertyName = "sector";
            this.sector.HeaderText = "Sector";
            this.sector.Name = "sector";
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            // 
            // nroCalle
            // 
            this.nroCalle.DataPropertyName = "nroCalle";
            this.nroCalle.HeaderText = "Nro";
            this.nroCalle.Name = "nroCalle";
            // 
            // mz
            // 
            this.mz.DataPropertyName = "mz";
            this.mz.HeaderText = "Mz";
            this.mz.Name = "mz";
            // 
            // lote
            // 
            this.lote.DataPropertyName = "lote";
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // deudaPredio
            // 
            this.deudaPredio.DataPropertyName = "deudaPredio";
            this.deudaPredio.HeaderText = "Predial";
            this.deudaPredio.Name = "deudaPredio";
            // 
            // deudaArbitrio
            // 
            this.deudaArbitrio.DataPropertyName = "deudaArbitrio";
            this.deudaArbitrio.HeaderText = "Arbitrios";
            this.deudaArbitrio.Name = "deudaArbitrio";
            // 
            // deudaTotal
            // 
            this.deudaTotal.DataPropertyName = "deudaTotal";
            this.deudaTotal.HeaderText = "Deuda Total";
            this.deudaTotal.Name = "deudaTotal";
            // 
            // Frm_GrandesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 399);
            this.Controls.Add(this.dgReporte);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_GrandesDeudores";
            this.Text = "Listado de Grandes Deudores";
            this.Load += new System.EventHandler(this.Frm_GrandesDeudores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonGenerarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHasta;
        private System.Windows.Forms.ComboBox cboDesde;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn representante;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn mz;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn deudaPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn deudaArbitrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn deudaTotal;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListar;
    }
}