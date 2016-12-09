namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Seguimiento_Fraccionamiento
{
    partial class Frm_FraccionamientoReporte
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
            this.xCrono_Fraccionamiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xinteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xamortizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xajuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xajusteAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFraccionamiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCrono_Fraccionamiento_id,
            this.xNroCuota,
            this.ximporte,
            this.xFechaVence,
            this.saldo,
            this.xinteres,
            this.xamortizacion,
            this.xcuota,
            this.xajuste,
            this.xajusteAcumulado,
            this.xFraccionamiento_id,
            this.xFechaPago});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 234);
            this.dataGridView1.TabIndex = 15;
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
            // ximporte
            // 
            this.ximporte.DataPropertyName = "importe";
            this.ximporte.HeaderText = "Cuota Pagar";
            this.ximporte.Name = "ximporte";
            this.ximporte.ReadOnly = true;
            this.ximporte.Width = 140;
            // 
            // xFechaVence
            // 
            this.xFechaVence.DataPropertyName = "FechaVence";
            this.xFechaVence.HeaderText = "Fecha Vencimiento";
            this.xFechaVence.Name = "xFechaVence";
            this.xFechaVence.ReadOnly = true;
            this.xFechaVence.Width = 170;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Visible = false;
            // 
            // xinteres
            // 
            this.xinteres.DataPropertyName = "interes";
            this.xinteres.HeaderText = "Interés";
            this.xinteres.Name = "xinteres";
            this.xinteres.ReadOnly = true;
            this.xinteres.Visible = false;
            // 
            // xamortizacion
            // 
            this.xamortizacion.DataPropertyName = "amortizacion";
            this.xamortizacion.HeaderText = "Amortización";
            this.xamortizacion.Name = "xamortizacion";
            this.xamortizacion.ReadOnly = true;
            this.xamortizacion.Visible = false;
            // 
            // xcuota
            // 
            this.xcuota.DataPropertyName = "cuota";
            this.xcuota.HeaderText = "Cuota";
            this.xcuota.Name = "xcuota";
            this.xcuota.ReadOnly = true;
            this.xcuota.Visible = false;
            // 
            // xajuste
            // 
            this.xajuste.DataPropertyName = "ajuste";
            this.xajuste.HeaderText = "Ajuste";
            this.xajuste.Name = "xajuste";
            this.xajuste.ReadOnly = true;
            this.xajuste.Visible = false;
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
            this.xFechaPago.Width = 150;
            // 
            // Frm_FraccionamientoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(591, 256);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_FraccionamientoReporte";
            this.Text = "Fraccionamiento Cuotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCrono_Fraccionamiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xinteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn xamortizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn xajuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn xajusteAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFraccionamiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaPago;
    }
}