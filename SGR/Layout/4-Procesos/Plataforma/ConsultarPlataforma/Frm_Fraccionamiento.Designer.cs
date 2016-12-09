namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fraccionamiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_legal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_acogida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deuda_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorcuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fraccionamiento_id,
            this.base_legal,
            this.fecha_acogida,
            this.periodos,
            this.deuda_total,
            this.inicial,
            this.saldo,
            this.Valorcuota,
            this.nroCuotas,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 419);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // fraccionamiento_id
            // 
            this.fraccionamiento_id.DataPropertyName = "fraccionamiento_id";
            this.fraccionamiento_id.FillWeight = 58.29304F;
            this.fraccionamiento_id.HeaderText = "Codigo";
            this.fraccionamiento_id.Name = "fraccionamiento_id";
            this.fraccionamiento_id.ReadOnly = true;
            // 
            // base_legal
            // 
            this.base_legal.DataPropertyName = "base_legal";
            this.base_legal.FillWeight = 253.0648F;
            this.base_legal.HeaderText = "Base Legal";
            this.base_legal.Name = "base_legal";
            this.base_legal.ReadOnly = true;
            // 
            // fecha_acogida
            // 
            this.fecha_acogida.DataPropertyName = "fecha_acogida";
            this.fecha_acogida.FillWeight = 81.21828F;
            this.fecha_acogida.HeaderText = "Fecha Acogida";
            this.fecha_acogida.Name = "fecha_acogida";
            this.fecha_acogida.ReadOnly = true;
            // 
            // periodos
            // 
            this.periodos.DataPropertyName = "periodos";
            this.periodos.FillWeight = 100.3306F;
            this.periodos.HeaderText = "Periodos";
            this.periodos.Name = "periodos";
            this.periodos.ReadOnly = true;
            // 
            // deuda_total
            // 
            this.deuda_total.DataPropertyName = "deuda_total";
            this.deuda_total.FillWeight = 79.50345F;
            this.deuda_total.HeaderText = "Deuda Total";
            this.deuda_total.Name = "deuda_total";
            this.deuda_total.ReadOnly = true;
            // 
            // inicial
            // 
            this.inicial.DataPropertyName = "inicial";
            this.inicial.FillWeight = 77.23545F;
            this.inicial.HeaderText = "Inicial";
            this.inicial.Name = "inicial";
            this.inicial.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.FillWeight = 74.79395F;
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // Valorcuota
            // 
            this.Valorcuota.DataPropertyName = "valorcuota";
            this.Valorcuota.FillWeight = 72.16565F;
            this.Valorcuota.HeaderText = "Cuota";
            this.Valorcuota.Name = "Valorcuota";
            this.Valorcuota.ReadOnly = true;
            // 
            // nroCuotas
            // 
            this.nroCuotas.DataPropertyName = "nroCuotas";
            this.nroCuotas.FillWeight = 69.3363F;
            this.nroCuotas.HeaderText = "Nro Cuotas";
            this.nroCuotas.Name = "nroCuotas";
            this.nroCuotas.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.FillWeight = 134.0585F;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Frm_Fraccionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 435);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Fraccionamiento";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Fraccionamiento";
            this.Load += new System.EventHandler(this.Frm_Fraccionamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fraccionamiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_legal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_acogida;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn deuda_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorcuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}