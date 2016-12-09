namespace SGR.WinApp.Layout._4_Procesos.Predio.Adeudo
{
    partial class Frm_ConstanciaAdeudo
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
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.dgvConstanciaNoDebe = new System.Windows.Forms.DataGridView();
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.rbtAlcala = new System.Windows.Forms.RadioButton();
            this.rbtP = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.rbtT = new System.Windows.Forms.RadioButton();
            this.Im = new System.Windows.Forms.DataGridViewImageColumn();
            this.idConstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TramiteRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TramiteImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obligacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlcabala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstanciaNoDebe)).BeginInit();
            this.toolmantenedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(758, 34);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(115, 21);
            this.cboAño.TabIndex = 12;
            this.cboAño.SelectedIndexChanged += new System.EventHandler(this.cboAño_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Año: ";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(12, 38);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(41, 13);
            this.lblDatos.TabIndex = 10;
            this.lblDatos.Text = "label1";
            // 
            // dgvConstanciaNoDebe
            // 
            this.dgvConstanciaNoDebe.AllowUserToAddRows = false;
            this.dgvConstanciaNoDebe.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConstanciaNoDebe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConstanciaNoDebe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConstanciaNoDebe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Im,
            this.idConstancia,
            this.idPeriodo,
            this.Expediente,
            this.Persona,
            this.IdPersona,
            this.Transferencia,
            this.TramiteRecibo,
            this.TramiteImporte,
            this.ImpuestoRecibo,
            this.ImpuestoImporte,
            this.Obligacion,
            this.Descripcion,
            this.Tipo,
            this.Valuo,
            this.CompraVenta,
            this.UIT,
            this.Saldo,
            this.Impuesto,
            this.idAlcabala,
            this.registro_user_add,
            this.registro_pc_add,
            this.registro_fecha_add,
            this.registro_fecha_update,
            this.registro_user_update,
            this.registro_pc_update,
            this.idPredio,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConstanciaNoDebe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConstanciaNoDebe.EnableHeadersVisualStyles = false;
            this.dgvConstanciaNoDebe.Location = new System.Drawing.Point(12, 73);
            this.dgvConstanciaNoDebe.Name = "dgvConstanciaNoDebe";
            this.dgvConstanciaNoDebe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConstanciaNoDebe.Size = new System.Drawing.Size(1057, 424);
            this.dgvConstanciaNoDebe.TabIndex = 13;
            this.dgvConstanciaNoDebe.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConstanciaNoDebe_CellContentDoubleClick);
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleditar});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(1028, 27);
            this.toolmantenedores.TabIndex = 14;
            this.toolmantenedores.Text = "toolStrip1";
            // 
            // toolnuevo
            // 
            this.toolnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolnuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolnuevo.Name = "toolnuevo";
            this.toolnuevo.Size = new System.Drawing.Size(24, 24);
            this.toolnuevo.Text = "Nuevo";
            this.toolnuevo.Click += new System.EventHandler(this.toolnuevo_Click);
            // 
            // tooleditar
            // 
            this.tooleditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooleditar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.tooleditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooleditar.Name = "tooleditar";
            this.tooleditar.Size = new System.Drawing.Size(24, 24);
            this.tooleditar.Text = "Editar";
            this.tooleditar.Click += new System.EventHandler(this.tooleditar_Click);
            // 
            // rbtAlcala
            // 
            this.rbtAlcala.AutoSize = true;
            this.rbtAlcala.Location = new System.Drawing.Point(128, 36);
            this.rbtAlcala.Name = "rbtAlcala";
            this.rbtAlcala.Size = new System.Drawing.Size(32, 17);
            this.rbtAlcala.TabIndex = 115;
            this.rbtAlcala.Text = "A";
            this.rbtAlcala.UseVisualStyleBackColor = true;
            this.rbtAlcala.CheckedChanged += new System.EventHandler(this.rbtAlcala_CheckedChanged);
            // 
            // rbtP
            // 
            this.rbtP.AutoSize = true;
            this.rbtP.Checked = true;
            this.rbtP.Location = new System.Drawing.Point(90, 36);
            this.rbtP.Name = "rbtP";
            this.rbtP.Size = new System.Drawing.Size(32, 17);
            this.rbtP.TabIndex = 114;
            this.rbtP.TabStop = true;
            this.rbtP.Text = "P";
            this.rbtP.UseVisualStyleBackColor = true;
            this.rbtP.CheckedChanged += new System.EventHandler(this.rbtP_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Persona";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(268, 34);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(415, 20);
            this.txtbusqueda.TabIndex = 117;
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(926, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(122, 36);
            this.btnListar.TabIndex = 118;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // rbtT
            // 
            this.rbtT.AutoSize = true;
            this.rbtT.Location = new System.Drawing.Point(166, 35);
            this.rbtT.Name = "rbtT";
            this.rbtT.Size = new System.Drawing.Size(32, 17);
            this.rbtT.TabIndex = 119;
            this.rbtT.Text = "T";
            this.rbtT.UseVisualStyleBackColor = true;
            this.rbtT.CheckedChanged += new System.EventHandler(this.rbtT_CheckedChanged);
            // 
            // Im
            // 
            this.Im.HeaderText = "Im";
            this.Im.Image = global::SGR.WinApp.Properties.Resources.print;
            this.Im.Name = "Im";
            this.Im.ReadOnly = true;
            this.Im.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Im.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Im.Width = 30;
            // 
            // idConstancia
            // 
            this.idConstancia.DataPropertyName = "idConstancia";
            this.idConstancia.HeaderText = "Código";
            this.idConstancia.Name = "idConstancia";
            this.idConstancia.ReadOnly = true;
            this.idConstancia.Width = 50;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Año";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.ReadOnly = true;
            this.idPeriodo.Visible = false;
            this.idPeriodo.Width = 50;
            // 
            // Expediente
            // 
            this.Expediente.DataPropertyName = "Expediente";
            this.Expediente.HeaderText = "Expediente";
            this.Expediente.Name = "Expediente";
            this.Expediente.ReadOnly = true;
            // 
            // Persona
            // 
            this.Persona.DataPropertyName = "Persona";
            this.Persona.HeaderText = "Persona";
            this.Persona.Name = "Persona";
            this.Persona.ReadOnly = true;
            // 
            // IdPersona
            // 
            this.IdPersona.DataPropertyName = "IdPersona";
            this.IdPersona.HeaderText = "IdContribuyente";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.ReadOnly = true;
            // 
            // Transferencia
            // 
            this.Transferencia.DataPropertyName = "Transferencia";
            this.Transferencia.HeaderText = "Transferencia";
            this.Transferencia.Name = "Transferencia";
            this.Transferencia.ReadOnly = true;
            // 
            // TramiteRecibo
            // 
            this.TramiteRecibo.DataPropertyName = "TramiteRecibo";
            this.TramiteRecibo.HeaderText = "Tramite - Recibo";
            this.TramiteRecibo.Name = "TramiteRecibo";
            this.TramiteRecibo.ReadOnly = true;
            this.TramiteRecibo.Width = 80;
            // 
            // TramiteImporte
            // 
            this.TramiteImporte.DataPropertyName = "TramiteImporte";
            this.TramiteImporte.HeaderText = "Tramite - Importe";
            this.TramiteImporte.Name = "TramiteImporte";
            this.TramiteImporte.ReadOnly = true;
            this.TramiteImporte.Width = 80;
            // 
            // ImpuestoRecibo
            // 
            this.ImpuestoRecibo.DataPropertyName = "ImpuestoRecibo";
            this.ImpuestoRecibo.HeaderText = "Impuesto - Recibo";
            this.ImpuestoRecibo.Name = "ImpuestoRecibo";
            this.ImpuestoRecibo.ReadOnly = true;
            this.ImpuestoRecibo.Width = 80;
            // 
            // ImpuestoImporte
            // 
            this.ImpuestoImporte.DataPropertyName = "ImpuestoImporte";
            this.ImpuestoImporte.HeaderText = "Impuesto - Importe";
            this.ImpuestoImporte.Name = "ImpuestoImporte";
            this.ImpuestoImporte.ReadOnly = true;
            this.ImpuestoImporte.Width = 80;
            // 
            // Obligacion
            // 
            this.Obligacion.DataPropertyName = "Obligacion";
            this.Obligacion.HeaderText = "Obligación";
            this.Obligacion.Name = "Obligacion";
            this.Obligacion.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // Valuo
            // 
            this.Valuo.DataPropertyName = "Valuo";
            this.Valuo.HeaderText = "Valuo";
            this.Valuo.Name = "Valuo";
            this.Valuo.ReadOnly = true;
            this.Valuo.Visible = false;
            // 
            // CompraVenta
            // 
            this.CompraVenta.DataPropertyName = "CompraVenta";
            this.CompraVenta.HeaderText = "CompraVenta";
            this.CompraVenta.Name = "CompraVenta";
            this.CompraVenta.ReadOnly = true;
            this.CompraVenta.Visible = false;
            // 
            // UIT
            // 
            this.UIT.DataPropertyName = "UIT";
            this.UIT.HeaderText = "UIT";
            this.UIT.Name = "UIT";
            this.UIT.ReadOnly = true;
            this.UIT.Visible = false;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Visible = false;
            // 
            // Impuesto
            // 
            this.Impuesto.DataPropertyName = "Impuesto";
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            this.Impuesto.Visible = false;
            // 
            // idAlcabala
            // 
            this.idAlcabala.DataPropertyName = "idAlcabala";
            this.idAlcabala.HeaderText = "idAlcabala";
            this.idAlcabala.Name = "idAlcabala";
            this.idAlcabala.ReadOnly = true;
            this.idAlcabala.Visible = false;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "registro_user_add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "registro_pc_add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "registro_fecha_add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "registro_fecha_update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "registro_pc_update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // idPredio
            // 
            this.idPredio.DataPropertyName = "idPredio";
            this.idPredio.HeaderText = "idPredio";
            this.idPredio.Name = "idPredio";
            this.idPredio.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Frm_ConstanciaAdeudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1028, 520);
            this.Controls.Add(this.rbtT);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtAlcala);
            this.Controls.Add(this.rbtP);
            this.Controls.Add(this.toolmantenedores);
            this.Controls.Add(this.dgvConstanciaNoDebe);
            this.Controls.Add(this.cboAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConstanciaAdeudo";
            this.Text = "LISTADO CONSTANCIA DE NO ADEUDO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstanciaNoDebe)).EndInit();
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridView dgvConstanciaNoDebe;
        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.RadioButton rbtAlcala;
        private System.Windows.Forms.RadioButton rbtP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RadioButton rbtT;
        private System.Windows.Forms.DataGridViewImageColumn Im;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TramiteRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TramiteImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obligacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlcabala;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPredio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
    }
}