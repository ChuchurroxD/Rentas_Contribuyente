namespace SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion
{
    partial class Frm_ListadoExoneracionGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.rbtPrescrito = new System.Windows.Forms.RadioButton();
            this.rbtExonerado = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbTodosLosAños = new System.Windows.Forms.CheckBox();
            this.comboBusquedaAnio = new System.Windows.Forms.ComboBox();
            this.dgvExoneracion = new System.Windows.Forms.DataGridView();
            this.contribuyente_IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des_exo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resol_imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_dcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efec_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_imponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_afectado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto_anual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formularios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_operacion_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predio_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExoneracion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.Image = global::SGR.WinApp.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(750, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(26, 32);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rbtPrescrito
            // 
            this.rbtPrescrito.AutoSize = true;
            this.rbtPrescrito.Location = new System.Drawing.Point(223, 19);
            this.rbtPrescrito.Name = "rbtPrescrito";
            this.rbtPrescrito.Size = new System.Drawing.Size(73, 17);
            this.rbtPrescrito.TabIndex = 28;
            this.rbtPrescrito.Text = "PreEscrito";
            this.rbtPrescrito.UseVisualStyleBackColor = true;
            this.rbtPrescrito.CheckedChanged += new System.EventHandler(this.rbtPrescrito_CheckedChanged);
            // 
            // rbtExonerado
            // 
            this.rbtExonerado.AutoSize = true;
            this.rbtExonerado.Checked = true;
            this.rbtExonerado.Location = new System.Drawing.Point(128, 19);
            this.rbtExonerado.Name = "rbtExonerado";
            this.rbtExonerado.Size = new System.Drawing.Size(76, 17);
            this.rbtExonerado.TabIndex = 25;
            this.rbtExonerado.TabStop = true;
            this.rbtExonerado.Text = "Exonerado";
            this.rbtExonerado.UseVisualStyleBackColor = true;
            this.rbtExonerado.CheckedChanged += new System.EventHandler(this.rbtExonerado_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Image = global::SGR.WinApp.Properties.Resources.search1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(648, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 32);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(362, 21);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(260, 20);
            this.txtPersona.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.ckbTodosLosAños);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.rbtPrescrito);
            this.groupBox1.Controls.Add(this.rbtExonerado);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtPersona);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBusquedaAnio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(957, 67);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Búsqueda";
            // 
            // ckbTodosLosAños
            // 
            this.ckbTodosLosAños.AutoSize = true;
            this.ckbTodosLosAños.Location = new System.Drawing.Point(20, 44);
            this.ckbTodosLosAños.Name = "ckbTodosLosAños";
            this.ckbTodosLosAños.Size = new System.Drawing.Size(98, 17);
            this.ckbTodosLosAños.TabIndex = 30;
            this.ckbTodosLosAños.Text = "Todos los años";
            this.ckbTodosLosAños.UseVisualStyleBackColor = true;
            this.ckbTodosLosAños.CheckedChanged += new System.EventHandler(this.ckbTodosLosAños_CheckedChanged);
            // 
            // comboBusquedaAnio
            // 
            this.comboBusquedaAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusquedaAnio.FormattingEnabled = true;
            this.comboBusquedaAnio.Location = new System.Drawing.Point(48, 18);
            this.comboBusquedaAnio.Name = "comboBusquedaAnio";
            this.comboBusquedaAnio.Size = new System.Drawing.Size(68, 21);
            this.comboBusquedaAnio.TabIndex = 3;
            this.comboBusquedaAnio.SelectedIndexChanged += new System.EventHandler(this.comboBusquedaAnio_SelectedIndexChanged);
            // 
            // dgvExoneracion
            // 
            this.dgvExoneracion.AllowUserToAddRows = false;
            this.dgvExoneracion.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExoneracion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvExoneracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExoneracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contribuyente_IDD,
            this.anioInicio,
            this.mesInicio,
            this.anioFin,
            this.mesFin,
            this.des_exo_ID,
            this.tipo_operacion,
            this.condicion_descripcion,
            this.condicion,
            this.tipo,
            this.expediente,
            this.resolucion,
            this.resol_imagen,
            this.anio,
            this.fecha_inicio,
            this.fecha_fin,
            this.porcentaje_dcto,
            this.efec_descuento,
            this.observaciones,
            this.predio_ID,
            this.tributo_ID,
            this.motivo,
            this.base_imponible,
            this.deduccion,
            this.monto_afectado,
            this.impuesto_anual,
            this.formularios,
            this.registro_fecha_add,
            this.registro_pc_add,
            this.registro_user_add,
            this.registro_fecha_update,
            this.registro_pc_update,
            this.registro_user_update,
            this.tipo_descripcion,
            this.tipo_operacion_descripcion,
            this.motivo_descripcion,
            this.predio_descripcion,
            this.tributo_descripcion,
            this.estado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExoneracion.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExoneracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExoneracion.EnableHeadersVisualStyles = false;
            this.dgvExoneracion.Location = new System.Drawing.Point(0, 67);
            this.dgvExoneracion.Name = "dgvExoneracion";
            this.dgvExoneracion.RowHeadersVisible = false;
            this.dgvExoneracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExoneracion.Size = new System.Drawing.Size(957, 349);
            this.dgvExoneracion.TabIndex = 15;
            // 
            // contribuyente_IDD
            // 
            this.contribuyente_IDD.DataPropertyName = "contribuyente_ID";
            this.contribuyente_IDD.HeaderText = "contribuyente_IDD";
            this.contribuyente_IDD.Name = "contribuyente_IDD";
            this.contribuyente_IDD.ReadOnly = true;
            this.contribuyente_IDD.Visible = false;
            // 
            // anioInicio
            // 
            this.anioInicio.DataPropertyName = "anioInicio";
            this.anioInicio.HeaderText = "AñoIni.";
            this.anioInicio.Name = "anioInicio";
            this.anioInicio.ReadOnly = true;
            this.anioInicio.Width = 60;
            // 
            // mesInicio
            // 
            this.mesInicio.DataPropertyName = "mesInicio";
            this.mesInicio.HeaderText = "MesIni.";
            this.mesInicio.Name = "mesInicio";
            this.mesInicio.ReadOnly = true;
            this.mesInicio.Width = 60;
            // 
            // anioFin
            // 
            this.anioFin.DataPropertyName = "anioFin";
            this.anioFin.HeaderText = "AñoFin";
            this.anioFin.Name = "anioFin";
            this.anioFin.ReadOnly = true;
            this.anioFin.Width = 60;
            // 
            // mesFin
            // 
            this.mesFin.DataPropertyName = "mesFin";
            this.mesFin.HeaderText = "MesFin";
            this.mesFin.Name = "mesFin";
            this.mesFin.ReadOnly = true;
            this.mesFin.Width = 60;
            // 
            // des_exo_ID
            // 
            this.des_exo_ID.DataPropertyName = "des_exo_ID";
            this.des_exo_ID.HeaderText = "des_exo_ID";
            this.des_exo_ID.Name = "des_exo_ID";
            this.des_exo_ID.ReadOnly = true;
            this.des_exo_ID.Visible = false;
            // 
            // tipo_operacion
            // 
            this.tipo_operacion.DataPropertyName = "tipo_operacion";
            this.tipo_operacion.HeaderText = "tipo_operacion";
            this.tipo_operacion.Name = "tipo_operacion";
            this.tipo_operacion.ReadOnly = true;
            this.tipo_operacion.Visible = false;
            // 
            // condicion_descripcion
            // 
            this.condicion_descripcion.DataPropertyName = "condicion_descripcion";
            this.condicion_descripcion.HeaderText = "Condición";
            this.condicion_descripcion.Name = "condicion_descripcion";
            this.condicion_descripcion.ReadOnly = true;
            this.condicion_descripcion.Visible = false;
            this.condicion_descripcion.Width = 200;
            // 
            // condicion
            // 
            this.condicion.DataPropertyName = "condicion";
            this.condicion.HeaderText = "condicion";
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            this.condicion.Visible = false;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // expediente
            // 
            this.expediente.DataPropertyName = "expediente";
            this.expediente.HeaderText = "Expediente";
            this.expediente.Name = "expediente";
            this.expediente.ReadOnly = true;
            // 
            // resolucion
            // 
            this.resolucion.DataPropertyName = "resolucion";
            this.resolucion.HeaderText = "Resolución";
            this.resolucion.Name = "resolucion";
            this.resolucion.ReadOnly = true;
            // 
            // resol_imagen
            // 
            this.resol_imagen.DataPropertyName = "resol_imagen";
            this.resol_imagen.HeaderText = "resol_imagen";
            this.resol_imagen.Name = "resol_imagen";
            this.resol_imagen.ReadOnly = true;
            this.resol_imagen.Visible = false;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "anio";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Visible = false;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.DataPropertyName = "fecha_inicio";
            this.fecha_inicio.HeaderText = "Inicio";
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.ReadOnly = true;
            this.fecha_inicio.Visible = false;
            // 
            // fecha_fin
            // 
            this.fecha_fin.DataPropertyName = "fecha_fin";
            this.fecha_fin.HeaderText = "Fin";
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.ReadOnly = true;
            this.fecha_fin.Visible = false;
            // 
            // porcentaje_dcto
            // 
            this.porcentaje_dcto.DataPropertyName = "Porcentaje_dcto";
            this.porcentaje_dcto.HeaderText = "porcentaje_dcto";
            this.porcentaje_dcto.Name = "porcentaje_dcto";
            this.porcentaje_dcto.ReadOnly = true;
            this.porcentaje_dcto.Visible = false;
            // 
            // efec_descuento
            // 
            this.efec_descuento.DataPropertyName = "efec_descuento";
            this.efec_descuento.HeaderText = "efec_descuento";
            this.efec_descuento.Name = "efec_descuento";
            this.efec_descuento.ReadOnly = true;
            this.efec_descuento.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            // 
            // predio_ID
            // 
            this.predio_ID.DataPropertyName = "predio_ID";
            this.predio_ID.HeaderText = "predio_ID";
            this.predio_ID.Name = "predio_ID";
            this.predio_ID.ReadOnly = true;
            this.predio_ID.Visible = false;
            // 
            // tributo_ID
            // 
            this.tributo_ID.DataPropertyName = "tributo_ID";
            this.tributo_ID.HeaderText = "tributo_ID";
            this.tributo_ID.Name = "tributo_ID";
            this.tributo_ID.ReadOnly = true;
            this.tributo_ID.Visible = false;
            // 
            // motivo
            // 
            this.motivo.DataPropertyName = "motivo";
            this.motivo.HeaderText = "motivo";
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            this.motivo.Visible = false;
            // 
            // base_imponible
            // 
            this.base_imponible.DataPropertyName = "base_imponible";
            this.base_imponible.HeaderText = "Base_imponible";
            this.base_imponible.Name = "base_imponible";
            this.base_imponible.ReadOnly = true;
            this.base_imponible.Visible = false;
            // 
            // deduccion
            // 
            this.deduccion.DataPropertyName = "deduccion";
            this.deduccion.HeaderText = "Deducción";
            this.deduccion.Name = "deduccion";
            this.deduccion.ReadOnly = true;
            this.deduccion.Visible = false;
            // 
            // monto_afectado
            // 
            this.monto_afectado.DataPropertyName = "monto_afectado";
            this.monto_afectado.HeaderText = "Monto_afectado";
            this.monto_afectado.Name = "monto_afectado";
            this.monto_afectado.ReadOnly = true;
            this.monto_afectado.Visible = false;
            // 
            // impuesto_anual
            // 
            this.impuesto_anual.DataPropertyName = "impuesto_anual";
            this.impuesto_anual.HeaderText = "Impuesto_anual";
            this.impuesto_anual.Name = "impuesto_anual";
            this.impuesto_anual.ReadOnly = true;
            this.impuesto_anual.Visible = false;
            // 
            // formularios
            // 
            this.formularios.DataPropertyName = "formularios";
            this.formularios.HeaderText = "Formularios";
            this.formularios.Name = "formularios";
            this.formularios.ReadOnly = true;
            this.formularios.Visible = false;
            // 
            // registro_fecha_add
            // 
            this.registro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.registro_fecha_add.HeaderText = "registro_fecha_add";
            this.registro_fecha_add.Name = "registro_fecha_add";
            this.registro_fecha_add.ReadOnly = true;
            this.registro_fecha_add.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "Contribuyente";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Width = 250;
            // 
            // registro_user_add
            // 
            this.registro_user_add.DataPropertyName = "registro_user_add";
            this.registro_user_add.HeaderText = "registro_user_add";
            this.registro_user_add.Name = "registro_user_add";
            this.registro_user_add.ReadOnly = true;
            this.registro_user_add.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "registro_fecha_update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "registro_pc_update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // tipo_descripcion
            // 
            this.tipo_descripcion.DataPropertyName = "tipo_descripcion";
            this.tipo_descripcion.HeaderText = "Tipo";
            this.tipo_descripcion.Name = "tipo_descripcion";
            this.tipo_descripcion.ReadOnly = true;
            this.tipo_descripcion.Visible = false;
            this.tipo_descripcion.Width = 200;
            // 
            // tipo_operacion_descripcion
            // 
            this.tipo_operacion_descripcion.DataPropertyName = "tipo_operacion_descripcion";
            this.tipo_operacion_descripcion.HeaderText = "Tipo Operación";
            this.tipo_operacion_descripcion.Name = "tipo_operacion_descripcion";
            this.tipo_operacion_descripcion.ReadOnly = true;
            this.tipo_operacion_descripcion.Visible = false;
            this.tipo_operacion_descripcion.Width = 200;
            // 
            // motivo_descripcion
            // 
            this.motivo_descripcion.DataPropertyName = "motivo_descripcion";
            this.motivo_descripcion.HeaderText = "Motivo";
            this.motivo_descripcion.Name = "motivo_descripcion";
            this.motivo_descripcion.ReadOnly = true;
            this.motivo_descripcion.Visible = false;
            this.motivo_descripcion.Width = 200;
            // 
            // predio_descripcion
            // 
            this.predio_descripcion.DataPropertyName = "predio_descripcion";
            this.predio_descripcion.HeaderText = "Predio";
            this.predio_descripcion.Name = "predio_descripcion";
            this.predio_descripcion.ReadOnly = true;
            this.predio_descripcion.Visible = false;
            this.predio_descripcion.Width = 200;
            // 
            // tributo_descripcion
            // 
            this.tributo_descripcion.DataPropertyName = "tributo_descripcion";
            this.tributo_descripcion.HeaderText = "Tributo";
            this.tributo_descripcion.Name = "tributo_descripcion";
            this.tributo_descripcion.ReadOnly = true;
            this.tributo_descripcion.Visible = false;
            this.tributo_descripcion.Width = 200;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Activo?";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.estado.Width = 60;
            // 
            // Frm_ListadoExoneracionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 416);
            this.Controls.Add(this.dgvExoneracion);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ListadoExoneracionGeneral";
            this.Text = "Listado de ExoneracionGeneral";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExoneracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton rbtPrescrito;
        private System.Windows.Forms.RadioButton rbtExonerado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBusquedaAnio;
        private System.Windows.Forms.DataGridView dgvExoneracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn contribuyente_IDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn des_exo_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn resol_imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_dcto;
        private System.Windows.Forms.DataGridViewTextBoxColumn efec_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_imponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn deduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_afectado;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto_anual;
        private System.Windows.Forms.DataGridViewTextBoxColumn formularios;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_operacion_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn predio_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo_descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.CheckBox ckbTodosLosAños;
    }
}