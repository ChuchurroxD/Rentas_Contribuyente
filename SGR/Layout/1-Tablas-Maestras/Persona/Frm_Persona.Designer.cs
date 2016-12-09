namespace SGR.WinApp.Layout._1_Tablas_Maestras.Persona
{
    partial class Frm_Persona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Persona));
            this.toolmantenedores = new System.Windows.Forms.ToolStrip();
            this.toolnuevo = new System.Windows.Forms.ToolStripButton();
            this.tooleditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBotonReporte = new System.Windows.Forms.ToolStripButton();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.ImgImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.TipoPersonaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distritoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fono_Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fono_oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.junta_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per_edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junta_via_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.via_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtraDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Declaracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubi_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNomRazon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.toolmantenedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolmantenedores
            // 
            this.toolmantenedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolmantenedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolnuevo,
            this.tooleditar,
            this.toolStripBotonReporte});
            this.toolmantenedores.Location = new System.Drawing.Point(0, 0);
            this.toolmantenedores.Name = "toolmantenedores";
            this.toolmantenedores.Size = new System.Drawing.Size(786, 27);
            this.toolmantenedores.TabIndex = 8;
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
            // toolStripBotonReporte
            // 
            this.toolStripBotonReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBotonReporte.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolStripBotonReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBotonReporte.Name = "toolStripBotonReporte";
            this.toolStripBotonReporte.Size = new System.Drawing.Size(24, 24);
            this.toolStripBotonReporte.Text = "Reporte";
            this.toolStripBotonReporte.Click += new System.EventHandler(this.toolStripBotonReporte_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImgImprimir,
            this.TipoPersonaDescripcion,
            this.depDescripcion,
            this.provDescripcion,
            this.distritoDescripcion,
            this.TipoDocDescripcion,
            this.viaDescripcion,
            this.persona_ID,
            this.tipo_persona,
            this.tipo_documento,
            this.documento,
            this.paterno,
            this.materno,
            this.nombres,
            this.num_via,
            this.interior,
            this.Dpto,
            this.mz,
            this.Lote,
            this.Fono_Domicilio,
            this.fono_oficina,
            this.email,
            this.ESTADO,
            this.junta_ID,
            this.Observacion,
            this.registro_fecha,
            this.registro_user,
            this.per_edad,
            this.junta_via_ID,
            this.Sector,
            this.NombreCompleto,
            this.registro_user_update,
            this.registro_fecha_update,
            this.registro_pc_add,
            this.registro_pc_update,
            this.via_ID,
            this.dep,
            this.prov,
            this.OtraDireccion,
            this.expediente,
            this.Declaracion,
            this.sexo,
            this.fechaNacimiento,
            this.edificio,
            this.piso,
            this.tienda,
            this.celular,
            this.Ubi_codigo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonas.EnableHeadersVisualStyles = false;
            this.dgvPersonas.Location = new System.Drawing.Point(0, 90);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersVisible = false;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(786, 272);
            this.dgvPersonas.TabIndex = 10;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            this.dgvPersonas.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersonas_ColumnHeaderMouseClick);
            this.dgvPersonas.DoubleClick += new System.EventHandler(this.dgvPersonas_DoubleClick_1);
            // 
            // ImgImprimir
            // 
            this.ImgImprimir.HeaderText = "";
            this.ImgImprimir.Image = ((System.Drawing.Image)(resources.GetObject("ImgImprimir.Image")));
            this.ImgImprimir.Name = "ImgImprimir";
            this.ImgImprimir.ReadOnly = true;
            this.ImgImprimir.Width = 30;
            // 
            // TipoPersonaDescripcion
            // 
            this.TipoPersonaDescripcion.DataPropertyName = "TipoPersonaDescripcion";
            this.TipoPersonaDescripcion.HeaderText = "Tipo Persona";
            this.TipoPersonaDescripcion.Name = "TipoPersonaDescripcion";
            this.TipoPersonaDescripcion.ReadOnly = true;
            this.TipoPersonaDescripcion.Visible = false;
            // 
            // depDescripcion
            // 
            this.depDescripcion.DataPropertyName = "depDescripcion";
            this.depDescripcion.HeaderText = "depDescripcion";
            this.depDescripcion.Name = "depDescripcion";
            this.depDescripcion.ReadOnly = true;
            this.depDescripcion.Visible = false;
            // 
            // provDescripcion
            // 
            this.provDescripcion.DataPropertyName = "provDescripcion";
            this.provDescripcion.HeaderText = "provDescripcion";
            this.provDescripcion.Name = "provDescripcion";
            this.provDescripcion.ReadOnly = true;
            this.provDescripcion.Visible = false;
            // 
            // distritoDescripcion
            // 
            this.distritoDescripcion.DataPropertyName = "distritoDescripcion";
            this.distritoDescripcion.HeaderText = "distritoDescripcion";
            this.distritoDescripcion.Name = "distritoDescripcion";
            this.distritoDescripcion.ReadOnly = true;
            this.distritoDescripcion.Visible = false;
            // 
            // TipoDocDescripcion
            // 
            this.TipoDocDescripcion.DataPropertyName = "TipoDocDescripcion";
            this.TipoDocDescripcion.HeaderText = "TipoDocDescripcion";
            this.TipoDocDescripcion.Name = "TipoDocDescripcion";
            this.TipoDocDescripcion.ReadOnly = true;
            this.TipoDocDescripcion.Visible = false;
            // 
            // viaDescripcion
            // 
            this.viaDescripcion.DataPropertyName = "viaDescripcion";
            this.viaDescripcion.HeaderText = "viaDescripcion";
            this.viaDescripcion.Name = "viaDescripcion";
            this.viaDescripcion.ReadOnly = true;
            this.viaDescripcion.Visible = false;
            // 
            // persona_ID
            // 
            this.persona_ID.DataPropertyName = "persona_ID";
            this.persona_ID.HeaderText = "Código";
            this.persona_ID.Name = "persona_ID";
            this.persona_ID.ReadOnly = true;
            // 
            // tipo_persona
            // 
            this.tipo_persona.DataPropertyName = "tipo_persona";
            this.tipo_persona.HeaderText = "tipo_persona";
            this.tipo_persona.Name = "tipo_persona";
            this.tipo_persona.ReadOnly = true;
            this.tipo_persona.Visible = false;
            // 
            // tipo_documento
            // 
            this.tipo_documento.DataPropertyName = "tipo_documento";
            this.tipo_documento.HeaderText = "tipo_documento";
            this.tipo_documento.Name = "tipo_documento";
            this.tipo_documento.ReadOnly = true;
            this.tipo_documento.Visible = false;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // paterno
            // 
            this.paterno.DataPropertyName = "paterno";
            this.paterno.HeaderText = "Ape. Paterno";
            this.paterno.Name = "paterno";
            this.paterno.ReadOnly = true;
            // 
            // materno
            // 
            this.materno.DataPropertyName = "materno";
            this.materno.HeaderText = "Ape. Materno";
            this.materno.Name = "materno";
            this.materno.ReadOnly = true;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Nombres Completos";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 350;
            // 
            // num_via
            // 
            this.num_via.DataPropertyName = "num_via";
            this.num_via.HeaderText = "num_via";
            this.num_via.Name = "num_via";
            this.num_via.ReadOnly = true;
            this.num_via.Visible = false;
            // 
            // interior
            // 
            this.interior.DataPropertyName = "interior";
            this.interior.HeaderText = "interior";
            this.interior.Name = "interior";
            this.interior.ReadOnly = true;
            this.interior.Visible = false;
            // 
            // Dpto
            // 
            this.Dpto.DataPropertyName = "Dpto";
            this.Dpto.HeaderText = "Dpto";
            this.Dpto.Name = "Dpto";
            this.Dpto.ReadOnly = true;
            this.Dpto.Visible = false;
            // 
            // mz
            // 
            this.mz.DataPropertyName = "mz";
            this.mz.HeaderText = "mz";
            this.mz.Name = "mz";
            this.mz.ReadOnly = true;
            this.mz.Visible = false;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Visible = false;
            // 
            // Fono_Domicilio
            // 
            this.Fono_Domicilio.DataPropertyName = "Fono_Domicilio";
            this.Fono_Domicilio.HeaderText = "Fono_Domicilio";
            this.Fono_Domicilio.Name = "Fono_Domicilio";
            this.Fono_Domicilio.ReadOnly = true;
            this.Fono_Domicilio.Visible = false;
            // 
            // fono_oficina
            // 
            this.fono_oficina.DataPropertyName = "fono_oficina";
            this.fono_oficina.HeaderText = "fono_oficina";
            this.fono_oficina.Name = "fono_oficina";
            this.fono_oficina.ReadOnly = true;
            this.fono_oficina.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // junta_ID
            // 
            this.junta_ID.DataPropertyName = "junta_ID";
            this.junta_ID.HeaderText = "junta_ID";
            this.junta_ID.Name = "junta_ID";
            this.junta_ID.ReadOnly = true;
            this.junta_ID.Visible = false;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Visible = false;
            // 
            // registro_fecha
            // 
            this.registro_fecha.DataPropertyName = "registro_fecha";
            this.registro_fecha.HeaderText = "registro_fecha";
            this.registro_fecha.Name = "registro_fecha";
            this.registro_fecha.ReadOnly = true;
            this.registro_fecha.Visible = false;
            // 
            // registro_user
            // 
            this.registro_user.DataPropertyName = "registro_user";
            this.registro_user.HeaderText = "registro_user";
            this.registro_user.Name = "registro_user";
            this.registro_user.ReadOnly = true;
            this.registro_user.Visible = false;
            // 
            // per_edad
            // 
            this.per_edad.DataPropertyName = "per_edad";
            this.per_edad.HeaderText = "per_edad";
            this.per_edad.Name = "per_edad";
            this.per_edad.ReadOnly = true;
            this.per_edad.Visible = false;
            // 
            // junta_via_ID
            // 
            this.junta_via_ID.DataPropertyName = "junta_via_ID";
            this.junta_via_ID.HeaderText = "junta_via_ID";
            this.junta_via_ID.Name = "junta_via_ID";
            this.junta_via_ID.ReadOnly = true;
            this.junta_via_ID.Visible = false;
            // 
            // Sector
            // 
            this.Sector.DataPropertyName = "Sector";
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Visible = false;
            // 
            // registro_user_update
            // 
            this.registro_user_update.DataPropertyName = "registro_user_update";
            this.registro_user_update.HeaderText = "registro_user_update";
            this.registro_user_update.Name = "registro_user_update";
            this.registro_user_update.ReadOnly = true;
            this.registro_user_update.Visible = false;
            // 
            // registro_fecha_update
            // 
            this.registro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.registro_fecha_update.HeaderText = "registro_fecha_update";
            this.registro_fecha_update.Name = "registro_fecha_update";
            this.registro_fecha_update.ReadOnly = true;
            this.registro_fecha_update.Visible = false;
            // 
            // registro_pc_add
            // 
            this.registro_pc_add.DataPropertyName = "registro_pc_add";
            this.registro_pc_add.HeaderText = "registro_pc_add";
            this.registro_pc_add.Name = "registro_pc_add";
            this.registro_pc_add.ReadOnly = true;
            this.registro_pc_add.Visible = false;
            // 
            // registro_pc_update
            // 
            this.registro_pc_update.DataPropertyName = "registro_pc_update";
            this.registro_pc_update.HeaderText = "registro_pc_update";
            this.registro_pc_update.Name = "registro_pc_update";
            this.registro_pc_update.ReadOnly = true;
            this.registro_pc_update.Visible = false;
            // 
            // via_ID
            // 
            this.via_ID.DataPropertyName = "via_ID";
            this.via_ID.HeaderText = "via_ID";
            this.via_ID.Name = "via_ID";
            this.via_ID.ReadOnly = true;
            this.via_ID.Visible = false;
            // 
            // dep
            // 
            this.dep.DataPropertyName = "dep";
            this.dep.HeaderText = "dep";
            this.dep.Name = "dep";
            this.dep.ReadOnly = true;
            this.dep.Visible = false;
            // 
            // prov
            // 
            this.prov.DataPropertyName = "prov";
            this.prov.HeaderText = "prov";
            this.prov.Name = "prov";
            this.prov.ReadOnly = true;
            this.prov.Visible = false;
            // 
            // OtraDireccion
            // 
            this.OtraDireccion.DataPropertyName = "OtraDireccion";
            this.OtraDireccion.HeaderText = "OtraDireccion";
            this.OtraDireccion.Name = "OtraDireccion";
            this.OtraDireccion.ReadOnly = true;
            this.OtraDireccion.Visible = false;
            // 
            // expediente
            // 
            this.expediente.DataPropertyName = "expediente";
            this.expediente.HeaderText = "expediente";
            this.expediente.Name = "expediente";
            this.expediente.ReadOnly = true;
            this.expediente.Visible = false;
            // 
            // Declaracion
            // 
            this.Declaracion.DataPropertyName = "Declaracion";
            this.Declaracion.HeaderText = "Declaracion";
            this.Declaracion.Name = "Declaracion";
            this.Declaracion.ReadOnly = true;
            this.Declaracion.Visible = false;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Visible = false;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "fechaNacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Visible = false;
            // 
            // edificio
            // 
            this.edificio.DataPropertyName = "edificio";
            this.edificio.HeaderText = "edificio";
            this.edificio.Name = "edificio";
            this.edificio.ReadOnly = true;
            this.edificio.Visible = false;
            // 
            // piso
            // 
            this.piso.DataPropertyName = "piso";
            this.piso.HeaderText = "piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            this.piso.Visible = false;
            // 
            // tienda
            // 
            this.tienda.DataPropertyName = "tienda";
            this.tienda.HeaderText = "tienda";
            this.tienda.Name = "tienda";
            this.tienda.ReadOnly = true;
            this.tienda.Visible = false;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Visible = false;
            // 
            // Ubi_codigo
            // 
            this.Ubi_codigo.DataPropertyName = "Ubi_codigo";
            this.Ubi_codigo.HeaderText = "Ubi_codigo";
            this.Ubi_codigo.Name = "Ubi_codigo";
            this.Ubi_codigo.ReadOnly = true;
            this.Ubi_codigo.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.txtNomRazon);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 63);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones de Búsqueda";
            // 
            // txtNomRazon
            // 
            this.txtNomRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomRazon.Location = new System.Drawing.Point(293, 24);
            this.txtNomRazon.Name = "txtNomRazon";
            this.txtNomRazon.Size = new System.Drawing.Size(338, 20);
            this.txtNomRazon.TabIndex = 9;
            this.txtNomRazon.TextChanged += new System.EventHandler(this.txtNomRazon_TextChanged);
            this.txtNomRazon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomRazon_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(93, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ape y Nom/ Raz. Soc./Documento:";
            // 
            // Frm_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 362);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolmantenedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Persona";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Frm_Persona_Load);
            this.toolmantenedores.ResumeLayout(false);
            this.toolmantenedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolmantenedores;
        private System.Windows.Forms.ToolStripButton toolnuevo;
        private System.Windows.Forms.ToolStripButton tooleditar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNomRazon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripButton toolStripBotonReporte;
        private System.Windows.Forms.DataGridViewImageColumn ImgImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPersonaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn provDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn distritoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_via;
        private System.Windows.Forms.DataGridViewTextBoxColumn interior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn mz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fono_Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fono_oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn junta_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn per_edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn junta_via_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro_pc_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn via_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtraDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Declaracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubi_codigo;
    }
}