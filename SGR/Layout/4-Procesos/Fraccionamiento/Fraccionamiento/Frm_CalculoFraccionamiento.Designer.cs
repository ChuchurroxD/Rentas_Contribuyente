namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento
{
    partial class Frm_CalculoFraccionamiento
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
            this.cboAnioFraccionamiento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNroFraccionamiento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultadoFrac = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtContFracc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAnioFraccionamiento
            // 
            this.cboAnioFraccionamiento.FormattingEnabled = true;
            this.cboAnioFraccionamiento.Location = new System.Drawing.Point(351, 29);
            this.cboAnioFraccionamiento.Name = "cboAnioFraccionamiento";
            this.cboAnioFraccionamiento.Size = new System.Drawing.Size(79, 21);
            this.cboAnioFraccionamiento.TabIndex = 31;
            this.cboAnioFraccionamiento.SelectedIndexChanged += new System.EventHandler(this.cboAnioFraccionamiento_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Año:";
            // 
            // txtNroFraccionamiento
            // 
            this.txtNroFraccionamiento.Location = new System.Drawing.Point(216, 32);
            this.txtNroFraccionamiento.Name = "txtNroFraccionamiento";
            this.txtNroFraccionamiento.Size = new System.Drawing.Size(72, 20);
            this.txtNroFraccionamiento.TabIndex = 29;
            this.txtNroFraccionamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroFraccionamiento_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Número de Fraccionamiento:";
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(571, 212);
            this.dataGridView1.TabIndex = 32;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.lblResultadoFrac);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtContFracc);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cboAnioFraccionamiento);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtNroFraccionamiento);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 137);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Fraccionamiento";
            // 
            // lblResultadoFrac
            // 
            this.lblResultadoFrac.AutoSize = true;
            this.lblResultadoFrac.Location = new System.Drawing.Point(18, 91);
            this.lblResultadoFrac.Name = "lblResultadoFrac";
            this.lblResultadoFrac.Size = new System.Drawing.Size(120, 15);
            this.lblResultadoFrac.TabIndex = 39;
            this.lblResultadoFrac.Text = "Resultado............";
            this.lblResultadoFrac.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Image = global::SGR.WinApp.Properties.Resources.search;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(185, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 30);
            this.button3.TabIndex = 38;
            this.button3.Text = "Cargar Cronograma";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtContFracc
            // 
            this.txtContFracc.Enabled = false;
            this.txtContFracc.Location = new System.Drawing.Point(123, 62);
            this.txtContFracc.Name = "txtContFracc";
            this.txtContFracc.Size = new System.Drawing.Size(426, 20);
            this.txtContFracc.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Contribuyente:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Image = global::SGR.WinApp.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(181, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "Anular Fraccionamiento";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_CalculoFraccionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(605, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_CalculoFraccionamiento";
            this.Text = "Anular Fraccionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnioFraccionamiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNroFraccionamiento;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContFracc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblResultadoFrac;
        private System.Windows.Forms.Button button3;
    }
}