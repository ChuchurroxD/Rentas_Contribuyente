namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento
{
    partial class Frm_Fraccionamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.xfraccionamiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xvisualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.xcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbase_legal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfecha_acogida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdeuda_fraccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestadoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpredial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpredialI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xarbitrios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xarbitriosI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xalcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xalcabalaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmultasI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfincas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfincasI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xalquileres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xalquileresI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtasas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtasasI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fraccionamientos Previos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xfraccionamiento_id,
            this.xvisualizar,
            this.xcodigo,
            this.xbase_legal,
            this.xfecha_acogida,
            this.xCuotas,
            this.xdeuda_fraccionada,
            this.xestadoo});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(10, 48);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(838, 150);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // xfraccionamiento_id
            // 
            this.xfraccionamiento_id.DataPropertyName = "fraccionamiento_id";
            this.xfraccionamiento_id.HeaderText = "id";
            this.xfraccionamiento_id.Name = "xfraccionamiento_id";
            this.xfraccionamiento_id.ReadOnly = true;
            this.xfraccionamiento_id.Visible = false;
            this.xfraccionamiento_id.Width = 70;
            // 
            // xvisualizar
            // 
            this.xvisualizar.HeaderText = "Mostrar";
            this.xvisualizar.Name = "xvisualizar";
            this.xvisualizar.ReadOnly = true;
            this.xvisualizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xvisualizar.Visible = false;
            // 
            // xcodigo
            // 
            this.xcodigo.DataPropertyName = "codigo";
            this.xcodigo.HeaderText = "Código";
            this.xcodigo.Name = "xcodigo";
            this.xcodigo.ReadOnly = true;
            // 
            // xbase_legal
            // 
            this.xbase_legal.DataPropertyName = "base_legal";
            this.xbase_legal.HeaderText = "Base Legal";
            this.xbase_legal.Name = "xbase_legal";
            this.xbase_legal.ReadOnly = true;
            this.xbase_legal.Width = 300;
            // 
            // xfecha_acogida
            // 
            this.xfecha_acogida.DataPropertyName = "fecha_acogida";
            this.xfecha_acogida.HeaderText = "Fecha Acogida";
            this.xfecha_acogida.Name = "xfecha_acogida";
            this.xfecha_acogida.ReadOnly = true;
            this.xfecha_acogida.Width = 125;
            // 
            // xCuotas
            // 
            this.xCuotas.DataPropertyName = "Cuotas";
            this.xCuotas.HeaderText = "Cuotas";
            this.xCuotas.Name = "xCuotas";
            this.xCuotas.ReadOnly = true;
            this.xCuotas.Visible = false;
            this.xCuotas.Width = 70;
            // 
            // xdeuda_fraccionada
            // 
            this.xdeuda_fraccionada.DataPropertyName = "deuda_fraccionada";
            this.xdeuda_fraccionada.HeaderText = "Deuda Fraccionada";
            this.xdeuda_fraccionada.Name = "xdeuda_fraccionada";
            this.xdeuda_fraccionada.ReadOnly = true;
            this.xdeuda_fraccionada.Width = 125;
            // 
            // xestadoo
            // 
            this.xestadoo.DataPropertyName = "estado";
            this.xestadoo.HeaderText = "Estado";
            this.xestadoo.Name = "xestadoo";
            this.xestadoo.ReadOnly = true;
            this.xestadoo.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen Deuda Vencida";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel3.Location = new System.Drawing.Point(461, 168);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(91, 17);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Siguiente...";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(324, 165);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(79, 23);
            this.txtTotal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpersona,
            this.xanio,
            this.xpredial,
            this.xpredialI,
            this.xarbitrios,
            this.xarbitriosI,
            this.xalcabala,
            this.xalcabalaI,
            this.xmultas,
            this.xmultasI,
            this.xfincas,
            this.xfincasI,
            this.xalquileres,
            this.xalquileresI,
            this.xtasas,
            this.xtasasI,
            this.xtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // xpersona
            // 
            this.xpersona.DataPropertyName = "persona_ID";
            this.xpersona.HeaderText = "Persona";
            this.xpersona.Name = "xpersona";
            this.xpersona.Visible = false;
            // 
            // xanio
            // 
            this.xanio.DataPropertyName = "anio";
            this.xanio.HeaderText = "Año";
            this.xanio.Name = "xanio";
            // 
            // xpredial
            // 
            this.xpredial.DataPropertyName = "predial";
            this.xpredial.HeaderText = "Predial";
            this.xpredial.Name = "xpredial";
            this.xpredial.Visible = false;
            // 
            // xpredialI
            // 
            this.xpredialI.DataPropertyName = "predialI";
            this.xpredialI.HeaderText = "Int. Predial";
            this.xpredialI.Name = "xpredialI";
            this.xpredialI.Visible = false;
            // 
            // xarbitrios
            // 
            this.xarbitrios.DataPropertyName = "arbitrios";
            this.xarbitrios.HeaderText = "Arbitrios";
            this.xarbitrios.Name = "xarbitrios";
            this.xarbitrios.Visible = false;
            // 
            // xarbitriosI
            // 
            this.xarbitriosI.DataPropertyName = "arbitriosI";
            this.xarbitriosI.HeaderText = "Int. Arbitrios";
            this.xarbitriosI.Name = "xarbitriosI";
            this.xarbitriosI.Visible = false;
            // 
            // xalcabala
            // 
            this.xalcabala.DataPropertyName = "alcabala";
            this.xalcabala.HeaderText = "Alcabala";
            this.xalcabala.Name = "xalcabala";
            this.xalcabala.Visible = false;
            // 
            // xalcabalaI
            // 
            this.xalcabalaI.DataPropertyName = "alcabalaI";
            this.xalcabalaI.HeaderText = "Int. Alcabala";
            this.xalcabalaI.Name = "xalcabalaI";
            this.xalcabalaI.Visible = false;
            // 
            // xmultas
            // 
            this.xmultas.DataPropertyName = "multas";
            this.xmultas.HeaderText = "Multas";
            this.xmultas.Name = "xmultas";
            this.xmultas.Visible = false;
            // 
            // xmultasI
            // 
            this.xmultasI.DataPropertyName = "multasI";
            this.xmultasI.HeaderText = "Int. Multas";
            this.xmultasI.Name = "xmultasI";
            this.xmultasI.Visible = false;
            // 
            // xfincas
            // 
            this.xfincas.DataPropertyName = "fincas";
            this.xfincas.HeaderText = "Fincas";
            this.xfincas.Name = "xfincas";
            this.xfincas.Visible = false;
            // 
            // xfincasI
            // 
            this.xfincasI.DataPropertyName = "fincasI";
            this.xfincasI.HeaderText = "Int. Fincas";
            this.xfincasI.Name = "xfincasI";
            this.xfincasI.Visible = false;
            // 
            // xalquileres
            // 
            this.xalquileres.DataPropertyName = "alquileres";
            this.xalquileres.HeaderText = "Alquileres";
            this.xalquileres.Name = "xalquileres";
            this.xalquileres.Visible = false;
            // 
            // xalquileresI
            // 
            this.xalquileresI.DataPropertyName = "alquileresI";
            this.xalquileresI.HeaderText = "Int. Alquileres";
            this.xalquileresI.Name = "xalquileresI";
            this.xalquileresI.Visible = false;
            // 
            // xtasas
            // 
            this.xtasas.DataPropertyName = "tasas";
            this.xtasas.HeaderText = "Tasas";
            this.xtasas.Name = "xtasas";
            this.xtasas.Visible = false;
            // 
            // xtasasI
            // 
            this.xtasasI.DataPropertyName = "tasasI";
            this.xtasasI.HeaderText = "Int. Tasas";
            this.xtasasI.Name = "xtasasI";
            this.xtasasI.Visible = false;
            // 
            // xtotal
            // 
            this.xtotal.DataPropertyName = "total";
            this.xtotal.HeaderText = "Total";
            this.xtotal.Name = "xtotal";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblDocumento);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Contribuyente";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(148, 72);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 15);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dirección Fiscal:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(404, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 15);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(202, 50);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(80, 15);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(168, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento de Indentidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos y Nombres:";
            // 
            // Frm_Fraccionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 578);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Fraccionamiento";
            this.Text = "Fraccionamiento";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn xanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpredial;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpredialI;
        private System.Windows.Forms.DataGridViewTextBoxColumn xarbitrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn xarbitriosI;
        private System.Windows.Forms.DataGridViewTextBoxColumn xalcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn xalcabalaI;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmultasI;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfincas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfincasI;
        private System.Windows.Forms.DataGridViewTextBoxColumn xalquileres;
        private System.Windows.Forms.DataGridViewTextBoxColumn xalquileresI;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtasas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtasasI;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfraccionamiento_id;
        private System.Windows.Forms.DataGridViewImageColumn xvisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbase_legal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfecha_acogida;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdeuda_fraccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn xestadoo;
    }
}