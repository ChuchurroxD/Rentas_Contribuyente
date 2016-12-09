namespace SGR.WinApp.Layout._4_Procesos.Liquidacion
{
    partial class FrmListadoLiquidacion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAnular = new System.Windows.Forms.ToolStripLabel();
            this.toolAnularPendientes = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xliquidacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpersona_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrazon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xintereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_fecha_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xregistro_pc_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAnular,
            this.toolAnularPendientes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAnular
            // 
            this.toolAnular.Image = global::SGR.WinApp.Properties.Resources.anular;
            this.toolAnular.Name = "toolAnular";
            this.toolAnular.Size = new System.Drawing.Size(58, 22);
            this.toolAnular.Text = "Anular";
            this.toolAnular.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolAnularPendientes
            // 
            this.toolAnularPendientes.Image = global::SGR.WinApp.Properties.Resources.anular;
            this.toolAnularPendientes.Name = "toolAnularPendientes";
            this.toolAnularPendientes.Size = new System.Drawing.Size(119, 22);
            this.toolAnularPendientes.Text = "Anular Pendientes";
            this.toolAnularPendientes.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xliquidacion_id,
            this.xtipo,
            this.xpersona_id,
            this.xrazon_social,
            this.ximporte,
            this.xintereses,
            this.xtotal,
            this.xfecha,
            this.xestado,
            this.xregistro_ip,
            this.xregistro_fecha_add,
            this.xregistro_user_add,
            this.xregistro_pc_add,
            this.xregistro_fecha_update,
            this.xregistro_user_update,
            this.xregistro_pc_update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(808, 391);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CambiarPosicion);
            // 
            // xliquidacion_id
            // 
            this.xliquidacion_id.DataPropertyName = "liquidacion_id";
            this.xliquidacion_id.HeaderText = "Liquidacion ID";
            this.xliquidacion_id.Name = "xliquidacion_id";
            this.xliquidacion_id.ReadOnly = true;
            this.xliquidacion_id.Visible = false;
            // 
            // xtipo
            // 
            this.xtipo.DataPropertyName = "tipo";
            this.xtipo.HeaderText = "Tipo";
            this.xtipo.Name = "xtipo";
            this.xtipo.ReadOnly = true;
            // 
            // xpersona_id
            // 
            this.xpersona_id.DataPropertyName = "persona_id";
            this.xpersona_id.HeaderText = "Contribuyente Id";
            this.xpersona_id.Name = "xpersona_id";
            this.xpersona_id.ReadOnly = true;
            this.xpersona_id.Visible = false;
            // 
            // xrazon_social
            // 
            this.xrazon_social.DataPropertyName = "razon_social";
            this.xrazon_social.HeaderText = "Contribuyente";
            this.xrazon_social.Name = "xrazon_social";
            this.xrazon_social.ReadOnly = true;
            this.xrazon_social.Width = 200;
            // 
            // ximporte
            // 
            this.ximporte.DataPropertyName = "importe";
            this.ximporte.HeaderText = "Importe";
            this.ximporte.Name = "ximporte";
            this.ximporte.ReadOnly = true;
            // 
            // xintereses
            // 
            this.xintereses.DataPropertyName = "intereses";
            this.xintereses.HeaderText = "Intereses";
            this.xintereses.Name = "xintereses";
            this.xintereses.ReadOnly = true;
            // 
            // xtotal
            // 
            this.xtotal.DataPropertyName = "total_final";
            this.xtotal.HeaderText = "Total";
            this.xtotal.Name = "xtotal";
            this.xtotal.ReadOnly = true;
            // 
            // xfecha
            // 
            this.xfecha.DataPropertyName = "fecha";
            this.xfecha.HeaderText = "Fecha";
            this.xfecha.Name = "xfecha";
            this.xfecha.ReadOnly = true;
            // 
            // xestado
            // 
            this.xestado.DataPropertyName = "estado";
            this.xestado.HeaderText = "Estado";
            this.xestado.Name = "xestado";
            this.xestado.ReadOnly = true;
            // 
            // xregistro_ip
            // 
            this.xregistro_ip.DataPropertyName = "registro_ip";
            this.xregistro_ip.HeaderText = "registro_ip";
            this.xregistro_ip.Name = "xregistro_ip";
            this.xregistro_ip.ReadOnly = true;
            this.xregistro_ip.Visible = false;
            // 
            // xregistro_fecha_add
            // 
            this.xregistro_fecha_add.DataPropertyName = "registro_fecha_add";
            this.xregistro_fecha_add.HeaderText = "registro_fecha_add";
            this.xregistro_fecha_add.Name = "xregistro_fecha_add";
            this.xregistro_fecha_add.ReadOnly = true;
            this.xregistro_fecha_add.Visible = false;
            // 
            // xregistro_user_add
            // 
            this.xregistro_user_add.DataPropertyName = "registro_user_add";
            this.xregistro_user_add.HeaderText = "registro_user_add";
            this.xregistro_user_add.Name = "xregistro_user_add";
            this.xregistro_user_add.ReadOnly = true;
            this.xregistro_user_add.Visible = false;
            // 
            // xregistro_pc_add
            // 
            this.xregistro_pc_add.DataPropertyName = "registro_pc_add";
            this.xregistro_pc_add.HeaderText = "registro_pc_add";
            this.xregistro_pc_add.Name = "xregistro_pc_add";
            this.xregistro_pc_add.ReadOnly = true;
            this.xregistro_pc_add.Visible = false;
            // 
            // xregistro_fecha_update
            // 
            this.xregistro_fecha_update.DataPropertyName = "registro_fecha_update";
            this.xregistro_fecha_update.HeaderText = "registro_fecha_update";
            this.xregistro_fecha_update.Name = "xregistro_fecha_update";
            this.xregistro_fecha_update.ReadOnly = true;
            this.xregistro_fecha_update.Visible = false;
            // 
            // xregistro_user_update
            // 
            this.xregistro_user_update.DataPropertyName = "registro_user_update";
            this.xregistro_user_update.HeaderText = "registro_user_update";
            this.xregistro_user_update.Name = "xregistro_user_update";
            this.xregistro_user_update.ReadOnly = true;
            this.xregistro_user_update.Visible = false;
            // 
            // xregistro_pc_update
            // 
            this.xregistro_pc_update.DataPropertyName = "registro_pc_update";
            this.xregistro_pc_update.HeaderText = "registro_pc_update";
            this.xregistro_pc_update.Name = "xregistro_pc_update";
            this.xregistro_pc_update.ReadOnly = true;
            this.xregistro_pc_update.Visible = false;
            // 
            // FrmListadoLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(837, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmListadoLiquidacion";
            this.Text = "FrmListadoLiquidacion";
            this.Load += new System.EventHandler(this.FrmListadoLiquidacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xliquidacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpersona_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrazon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn xintereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_fecha_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_user_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn xregistro_pc_update;
        private System.Windows.Forms.ToolStripLabel toolAnular;
        private System.Windows.Forms.ToolStripLabel toolAnularPendientes;
    }
}