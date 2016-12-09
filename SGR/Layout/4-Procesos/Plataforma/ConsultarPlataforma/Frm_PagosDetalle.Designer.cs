namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    partial class Frm_PagosDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.medioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTributoPago = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tributos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributo_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.may = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTributoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medioPago,
            this.soles,
            this.dolares});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Location = new System.Drawing.Point(5, 39);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(876, 170);
            this.dgvDetalle.TabIndex = 0;
            // 
            // medioPago
            // 
            this.medioPago.DataPropertyName = "FormaPago_descripcion";
            this.medioPago.HeaderText = "Medio Pago";
            this.medioPago.Name = "medioPago";
            this.medioPago.ReadOnly = true;
            this.medioPago.Width = 250;
            // 
            // soles
            // 
            this.soles.DataPropertyName = "Pago_Soles";
            this.soles.HeaderText = "Soles (S/.)";
            this.soles.Name = "soles";
            this.soles.ReadOnly = true;
            this.soles.Width = 150;
            // 
            // dolares
            // 
            this.dolares.DataPropertyName = "Pago_dolares";
            this.dolares.HeaderText = "Dolares ($)";
            this.dolares.Name = "dolares";
            this.dolares.ReadOnly = true;
            this.dolares.Width = 150;
            // 
            // dgvTributoPago
            // 
            this.dgvTributoPago.AllowUserToAddRows = false;
            this.dgvTributoPago.AllowUserToDeleteRows = false;
            this.dgvTributoPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTributoPago.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTributoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTributoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTributoPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tributos_ID,
            this.tributo_descripcion,
            this.anio,
            this.ene,
            this.feb,
            this.mar,
            this.abr,
            this.may,
            this.jun,
            this.jul,
            this.ago,
            this.set,
            this.oct,
            this.nov,
            this.dic,
            this.monto_pago});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTributoPago.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTributoPago.EnableHeadersVisualStyles = false;
            this.dgvTributoPago.Location = new System.Drawing.Point(5, 215);
            this.dgvTributoPago.Name = "dgvTributoPago";
            this.dgvTributoPago.ReadOnly = true;
            this.dgvTributoPago.RowHeadersVisible = false;
            this.dgvTributoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTributoPago.Size = new System.Drawing.Size(876, 185);
            this.dgvTributoPago.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Pagos";
            // 
            // tributos_ID
            // 
            this.tributos_ID.DataPropertyName = "tributos_ID";
            this.tributos_ID.HeaderText = "Código";
            this.tributos_ID.Name = "tributos_ID";
            this.tributos_ID.ReadOnly = true;
            this.tributos_ID.Visible = false;
            this.tributos_ID.Width = 60;
            // 
            // tributo_descripcion
            // 
            this.tributo_descripcion.DataPropertyName = "tributo_descripcion";
            this.tributo_descripcion.HeaderText = "Tributo";
            this.tributo_descripcion.Name = "tributo_descripcion";
            this.tributo_descripcion.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 50;
            // 
            // ene
            // 
            this.ene.DataPropertyName = "ene";
            this.ene.HeaderText = "Ene";
            this.ene.Name = "ene";
            this.ene.ReadOnly = true;
            this.ene.Width = 55;
            // 
            // feb
            // 
            this.feb.DataPropertyName = "feb";
            this.feb.HeaderText = "Feb";
            this.feb.Name = "feb";
            this.feb.ReadOnly = true;
            this.feb.Width = 55;
            // 
            // mar
            // 
            this.mar.DataPropertyName = "mar";
            this.mar.HeaderText = "Mar";
            this.mar.Name = "mar";
            this.mar.ReadOnly = true;
            this.mar.Width = 55;
            // 
            // abr
            // 
            this.abr.DataPropertyName = "abr";
            this.abr.HeaderText = "Abr";
            this.abr.Name = "abr";
            this.abr.ReadOnly = true;
            this.abr.Width = 55;
            // 
            // may
            // 
            this.may.DataPropertyName = "may";
            this.may.HeaderText = "May";
            this.may.Name = "may";
            this.may.ReadOnly = true;
            this.may.Width = 55;
            // 
            // jun
            // 
            this.jun.DataPropertyName = "jun";
            this.jun.HeaderText = "Jun";
            this.jun.Name = "jun";
            this.jun.ReadOnly = true;
            this.jun.Width = 55;
            // 
            // jul
            // 
            this.jul.DataPropertyName = "jul";
            this.jul.HeaderText = "Jul";
            this.jul.Name = "jul";
            this.jul.ReadOnly = true;
            this.jul.Width = 55;
            // 
            // ago
            // 
            this.ago.DataPropertyName = "ago";
            this.ago.HeaderText = "Ago";
            this.ago.Name = "ago";
            this.ago.ReadOnly = true;
            this.ago.Width = 55;
            // 
            // set
            // 
            this.set.DataPropertyName = "set";
            this.set.HeaderText = "Set";
            this.set.Name = "set";
            this.set.ReadOnly = true;
            this.set.Width = 55;
            // 
            // oct
            // 
            this.oct.DataPropertyName = "oct";
            this.oct.HeaderText = "Oct";
            this.oct.Name = "oct";
            this.oct.ReadOnly = true;
            this.oct.Width = 55;
            // 
            // nov
            // 
            this.nov.DataPropertyName = "nov";
            this.nov.HeaderText = "Nov";
            this.nov.Name = "nov";
            this.nov.ReadOnly = true;
            this.nov.Width = 55;
            // 
            // dic
            // 
            this.dic.DataPropertyName = "dic";
            this.dic.HeaderText = "Dic";
            this.dic.Name = "dic";
            this.dic.ReadOnly = true;
            this.dic.Width = 55;
            // 
            // monto_pago
            // 
            this.monto_pago.DataPropertyName = "monto_pago";
            this.monto_pago.HeaderText = "Total";
            this.monto_pago.Name = "monto_pago";
            this.monto_pago.ReadOnly = true;
            this.monto_pago.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(767, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(816, 411);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // Frm_PagosDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 435);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTributoPago);
            this.Controls.Add(this.dgvDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PagosDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PagosDetalle";
            this.Load += new System.EventHandler(this.Frm_PagosDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTributoPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridView dgvTributoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn soles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributo_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ene;
        private System.Windows.Forms.DataGridViewTextBoxColumn feb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn abr;
        private System.Windows.Forms.DataGridViewTextBoxColumn may;
        private System.Windows.Forms.DataGridViewTextBoxColumn jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ago;
        private System.Windows.Forms.DataGridViewTextBoxColumn set;
        private System.Windows.Forms.DataGridViewTextBoxColumn oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn dic;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_pago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
    }
}