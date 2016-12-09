namespace SGR.WinApp.Sistema.Entorno.Usuario
{
    partial class Frm_Usuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.xUsuario_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPersona_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_codArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_fechaCese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario_estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(843, 47);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(83, 18);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.MaxLength = 100;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(209, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dgUsuario
            // 
            this.dgUsuario.AllowUserToAddRows = false;
            this.dgUsuario.AllowUserToDeleteRows = false;
            this.dgUsuario.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xUsuario_codigo,
            this.xPersona_codigo,
            this.xUsuario_nombre,
            this.xUsuario_apellido,
            this.xUsuario_codArea,
            this.xUsuario_fechaCreacion,
            this.xUsuario_login,
            this.xUsuario_password,
            this.xUsuario_last,
            this.xUsuario_Session,
            this.xUsuario_fechaCese,
            this.xUsuario_estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgUsuario.EnableHeadersVisualStyles = false;
            this.dgUsuario.Location = new System.Drawing.Point(5, 78);
            this.dgUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgUsuario.MultiSelect = false;
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.ReadOnly = true;
            this.dgUsuario.RowHeadersVisible = false;
            this.dgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuario.Size = new System.Drawing.Size(836, 516);
            this.dgUsuario.TabIndex = 10;
            this.dgUsuario.DoubleClick += new System.EventHandler(this.dgUsuario_DoubleClick);
            // 
            // xUsuario_codigo
            // 
            this.xUsuario_codigo.DataPropertyName = "Seguc_iCodigo";
            this.xUsuario_codigo.HeaderText = "Codigo Usuario";
            this.xUsuario_codigo.Name = "xUsuario_codigo";
            this.xUsuario_codigo.ReadOnly = true;
            this.xUsuario_codigo.Visible = false;
            // 
            // xPersona_codigo
            // 
            this.xPersona_codigo.DataPropertyName = "per_codigo";
            this.xPersona_codigo.HeaderText = "Código Persona";
            this.xPersona_codigo.Name = "xPersona_codigo";
            this.xPersona_codigo.ReadOnly = true;
            this.xPersona_codigo.Visible = false;
            this.xPersona_codigo.Width = 150;
            // 
            // xUsuario_nombre
            // 
            this.xUsuario_nombre.DataPropertyName = "Seguc_vNombre";
            this.xUsuario_nombre.HeaderText = "Nombre";
            this.xUsuario_nombre.Name = "xUsuario_nombre";
            this.xUsuario_nombre.ReadOnly = true;
            this.xUsuario_nombre.Width = 200;
            // 
            // xUsuario_apellido
            // 
            this.xUsuario_apellido.DataPropertyName = "Seguc_vApellidos";
            this.xUsuario_apellido.HeaderText = "Apellidos";
            this.xUsuario_apellido.Name = "xUsuario_apellido";
            this.xUsuario_apellido.ReadOnly = true;
            this.xUsuario_apellido.Width = 200;
            // 
            // xUsuario_codArea
            // 
            this.xUsuario_codArea.DataPropertyName = "areas_codarea";
            this.xUsuario_codArea.HeaderText = "Código Área";
            this.xUsuario_codArea.Name = "xUsuario_codArea";
            this.xUsuario_codArea.ReadOnly = true;
            this.xUsuario_codArea.Visible = false;
            // 
            // xUsuario_fechaCreacion
            // 
            this.xUsuario_fechaCreacion.DataPropertyName = "Seguc_fFechaCreacion";
            this.xUsuario_fechaCreacion.HeaderText = "Fecha de Creación";
            this.xUsuario_fechaCreacion.Name = "xUsuario_fechaCreacion";
            this.xUsuario_fechaCreacion.ReadOnly = true;
            // 
            // xUsuario_login
            // 
            this.xUsuario_login.DataPropertyName = "Seguc_vLogin";
            this.xUsuario_login.HeaderText = "Login";
            this.xUsuario_login.Name = "xUsuario_login";
            this.xUsuario_login.ReadOnly = true;
            // 
            // xUsuario_password
            // 
            this.xUsuario_password.DataPropertyName = "Seguc_password";
            this.xUsuario_password.HeaderText = "Password";
            this.xUsuario_password.Name = "xUsuario_password";
            this.xUsuario_password.ReadOnly = true;
            this.xUsuario_password.Visible = false;
            // 
            // xUsuario_last
            // 
            this.xUsuario_last.DataPropertyName = "Seguc_vLast";
            this.xUsuario_last.HeaderText = "Last";
            this.xUsuario_last.Name = "xUsuario_last";
            this.xUsuario_last.ReadOnly = true;
            this.xUsuario_last.Visible = false;
            // 
            // xUsuario_Session
            // 
            this.xUsuario_Session.DataPropertyName = "Seguc_vSession";
            this.xUsuario_Session.HeaderText = "Session";
            this.xUsuario_Session.Name = "xUsuario_Session";
            this.xUsuario_Session.ReadOnly = true;
            this.xUsuario_Session.Visible = false;
            // 
            // xUsuario_fechaCese
            // 
            this.xUsuario_fechaCese.DataPropertyName = "Seguc_fFechaCese";
            this.xUsuario_fechaCese.HeaderText = "Fecha Cese";
            this.xUsuario_fechaCese.Name = "xUsuario_fechaCese";
            this.xUsuario_fechaCese.ReadOnly = true;
            // 
            // xUsuario_estado
            // 
            this.xUsuario_estado.DataPropertyName = "Seguc_bEstado";
            this.xUsuario_estado.HeaderText = "Estado";
            this.xUsuario_estado.Name = "xUsuario_estado";
            this.xUsuario_estado.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolEditar,
            this.toolImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNuevo
            // 
            this.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevo.Image = global::SGR.WinApp.Properties.Resources.add_new_document;
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(24, 24);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolEditar
            // 
            this.toolEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditar.Image = global::SGR.WinApp.Properties.Resources.new_file__1_;
            this.toolEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditar.Name = "toolEditar";
            this.toolEditar.Size = new System.Drawing.Size(24, 24);
            this.toolEditar.Text = "Editar";
            this.toolEditar.Click += new System.EventHandler(this.toolEditar_Click);
            // 
            // toolImprimir
            // 
            this.toolImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolImprimir.Image = global::SGR.WinApp.Properties.Resources.progress_report;
            this.toolImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImprimir.Name = "toolImprimir";
            this.toolImprimir.Size = new System.Drawing.Size(24, 24);
            this.toolImprimir.Text = "Imprimir";
            // 
            // Frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Usuario";
            this.Text = "Administrar Usuario";
            this.Load += new System.EventHandler(this.Frm_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPersona_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_codArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_last;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario_fechaCese;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xUsuario_estado;
    }
}