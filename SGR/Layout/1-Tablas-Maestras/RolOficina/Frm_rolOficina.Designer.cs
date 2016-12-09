namespace SGR.WinApp.Layout._1_Tablas_Maestras.RolOficina
{
    partial class Frm_rolOficina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgRolOficina = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolEditar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.rol_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficina_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficina_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRolOficina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRolOficina
            // 
            this.dgRolOficina.AllowUserToAddRows = false;
            this.dgRolOficina.AllowUserToDeleteRows = false;
            this.dgRolOficina.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRolOficina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRolOficina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRolOficina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rol_id,
            this.rol_descripcion,
            this.oficina_id,
            this.oficina_descripcion,
            this.estado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRolOficina.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgRolOficina.EnableHeadersVisualStyles = false;
            this.dgRolOficina.Location = new System.Drawing.Point(0, 87);
            this.dgRolOficina.Margin = new System.Windows.Forms.Padding(2);
            this.dgRolOficina.MultiSelect = false;
            this.dgRolOficina.Name = "dgRolOficina";
            this.dgRolOficina.ReadOnly = true;
            this.dgRolOficina.RowHeadersVisible = false;
            this.dgRolOficina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRolOficina.Size = new System.Drawing.Size(543, 469);
            this.dgRolOficina.TabIndex = 15;
            this.dgRolOficina.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgRolOficina_ColumnHeaderMouseClick);
            this.dgRolOficina.DoubleClick += new System.EventHandler(this.dgRolOficina_DoubleClick);
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
            this.groupBox1.Size = new System.Drawing.Size(660, 58);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcciones de Busqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(158, 21);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.MaxLength = 100;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(209, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda:";
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
            this.toolStrip1.Size = new System.Drawing.Size(660, 27);
            this.toolStrip1.TabIndex = 13;
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
            // rol_id
            // 
            this.rol_id.DataPropertyName = "rol_id";
            this.rol_id.HeaderText = "Rol ID";
            this.rol_id.Name = "rol_id";
            this.rol_id.ReadOnly = true;
            this.rol_id.Visible = false;
            // 
            // rol_descripcion
            // 
            this.rol_descripcion.DataPropertyName = "rol_descripcion";
            this.rol_descripcion.HeaderText = "Rol";
            this.rol_descripcion.Name = "rol_descripcion";
            this.rol_descripcion.ReadOnly = true;
            this.rol_descripcion.Width = 200;
            // 
            // oficina_id
            // 
            this.oficina_id.DataPropertyName = "oficina_id";
            this.oficina_id.HeaderText = "Oficina ID";
            this.oficina_id.Name = "oficina_id";
            this.oficina_id.ReadOnly = true;
            this.oficina_id.Visible = false;
            // 
            // oficina_descripcion
            // 
            this.oficina_descripcion.DataPropertyName = "oficina_descripcion";
            this.oficina_descripcion.HeaderText = "Oficina";
            this.oficina_descripcion.Name = "oficina_descripcion";
            this.oficina_descripcion.ReadOnly = true;
            this.oficina_descripcion.Width = 200;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Activo";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Frm_rolOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 558);
            this.Controls.Add(this.dgRolOficina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_rolOficina";
            this.Text = "GESTIONAR ROL OFICINA";
            this.Load += new System.EventHandler(this.Frm_rolOficina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRolOficina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRolOficina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolEditar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficina_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficina_descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
    }
}