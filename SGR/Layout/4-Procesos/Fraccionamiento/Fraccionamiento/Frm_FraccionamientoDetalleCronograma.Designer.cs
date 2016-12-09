namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento
{
    partial class Frm_FraccionamientoDetalleCronograma
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xCrono_Fraccionamiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xinteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xamortizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xajuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xajusteAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFraccionamiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblDocumento);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Contribuyente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(395, 50);
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
            this.label3.Location = new System.Drawing.Point(338, 50);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 335);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cronograma de Pagos";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(417, 305);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(64, 15);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cancelar";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(278, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 15);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Guardar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCrono_Fraccionamiento_id,
            this.xNroCuota,
            this.xFechaVence,
            this.saldo,
            this.xinteres,
            this.xamortizacion,
            this.xcuota,
            this.ximporte,
            this.xajuste,
            this.xajusteAcumulado,
            this.xFraccionamiento_id,
            this.xFechaPago});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(5, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 267);
            this.dataGridView1.TabIndex = 14;
            // 
            // xCrono_Fraccionamiento_id
            // 
            this.xCrono_Fraccionamiento_id.DataPropertyName = "Crono_Fraccionamiento_id";
            this.xCrono_Fraccionamiento_id.HeaderText = "id";
            this.xCrono_Fraccionamiento_id.Name = "xCrono_Fraccionamiento_id";
            this.xCrono_Fraccionamiento_id.ReadOnly = true;
            this.xCrono_Fraccionamiento_id.Visible = false;
            this.xCrono_Fraccionamiento_id.Width = 70;
            // 
            // xNroCuota
            // 
            this.xNroCuota.DataPropertyName = "NroCuota";
            this.xNroCuota.HeaderText = "Nro Cuota";
            this.xNroCuota.Name = "xNroCuota";
            this.xNroCuota.ReadOnly = true;
            // 
            // xFechaVence
            // 
            this.xFechaVence.DataPropertyName = "FechaVence";
            this.xFechaVence.HeaderText = "Fecha Vencimiento";
            this.xFechaVence.Name = "xFechaVence";
            this.xFechaVence.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // xinteres
            // 
            this.xinteres.DataPropertyName = "interes";
            this.xinteres.HeaderText = "Interés";
            this.xinteres.Name = "xinteres";
            this.xinteres.ReadOnly = true;
            // 
            // xamortizacion
            // 
            this.xamortizacion.DataPropertyName = "amortizacion";
            this.xamortizacion.HeaderText = "Amortización";
            this.xamortizacion.Name = "xamortizacion";
            this.xamortizacion.ReadOnly = true;
            // 
            // xcuota
            // 
            this.xcuota.DataPropertyName = "cuota";
            this.xcuota.HeaderText = "Cuota";
            this.xcuota.Name = "xcuota";
            this.xcuota.ReadOnly = true;
            // 
            // ximporte
            // 
            this.ximporte.DataPropertyName = "importe";
            this.ximporte.HeaderText = "Cuota Pagar";
            this.ximporte.Name = "ximporte";
            this.ximporte.ReadOnly = true;
            this.ximporte.Width = 110;
            // 
            // xajuste
            // 
            this.xajuste.DataPropertyName = "ajuste";
            this.xajuste.HeaderText = "Ajuste";
            this.xajuste.Name = "xajuste";
            this.xajuste.ReadOnly = true;
            // 
            // xajusteAcumulado
            // 
            this.xajusteAcumulado.DataPropertyName = "ajusteAcumulado";
            this.xajusteAcumulado.HeaderText = "Ajuste Acumulado";
            this.xajusteAcumulado.Name = "xajusteAcumulado";
            this.xajusteAcumulado.ReadOnly = true;
            this.xajusteAcumulado.Visible = false;
            // 
            // xFraccionamiento_id
            // 
            this.xFraccionamiento_id.DataPropertyName = "Fraccionamiento_id";
            this.xFraccionamiento_id.HeaderText = "Fracc";
            this.xFraccionamiento_id.Name = "xFraccionamiento_id";
            this.xFraccionamiento_id.ReadOnly = true;
            this.xFraccionamiento_id.Visible = false;
            // 
            // xFechaPago
            // 
            this.xFechaPago.DataPropertyName = "FechaPago";
            this.xFechaPago.HeaderText = "Fecha pago";
            this.xFechaPago.Name = "xFechaPago";
            this.xFechaPago.ReadOnly = true;
            this.xFechaPago.Visible = false;
            // 
            // Frm_FraccionamientoDetalleCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_FraccionamientoDetalleCronograma";
            this.Text = "Fraccionamiento Cronograma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCrono_Fraccionamiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xinteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn xamortizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn xajuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn xajusteAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFraccionamiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaPago;
    }
}