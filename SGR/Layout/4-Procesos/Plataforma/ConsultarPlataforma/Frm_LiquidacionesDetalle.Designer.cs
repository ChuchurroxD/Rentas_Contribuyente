using System;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    partial class Frm_LiquidacionesDetalle
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
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.abrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.may = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tributos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(12, 9);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(152, 15);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "Detalle de Liquidación";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.abrev,
            this.anio,
            this.ene,
            this.feb,
            this.mar,
            this.abr,
            this.may,
            this.jun,
            this.jul,
            this.ago,
            this.sep,
            this.oct,
            this.nov,
            this.dic,
            this.tot,
            this.tributos_ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 404);
            this.dataGridView1.TabIndex = 1;
            // 
            // abrev
            // 
            this.abrev.DataPropertyName = "abrev";
            this.abrev.HeaderText = "Tributo";
            this.abrev.Name = "abrev";
            this.abrev.ReadOnly = true;
            this.abrev.Width = 90;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 60;
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
            // sep
            // 
            this.sep.DataPropertyName = "sep";
            this.sep.HeaderText = "Set";
            this.sep.Name = "sep";
            this.sep.ReadOnly = true;
            this.sep.Width = 55;
            // 
            // oct
            // 
            this.oct.DataPropertyName = "oct";
            this.oct.HeaderText = "Oct";
            this.oct.Name = "oct";
            this.oct.ReadOnly = true;
            this.oct.Width = 50;
            // 
            // nov
            // 
            this.nov.DataPropertyName = "nov";
            this.nov.HeaderText = "Nov";
            this.nov.Name = "nov";
            this.nov.ReadOnly = true;
            this.nov.Width = 50;
            // 
            // dic
            // 
            this.dic.DataPropertyName = "dic";
            this.dic.HeaderText = "Dic";
            this.dic.Name = "dic";
            this.dic.ReadOnly = true;
            this.dic.Width = 50;
            // 
            // tot
            // 
            this.tot.DataPropertyName = "tot";
            this.tot.HeaderText = "Total";
            this.tot.Name = "tot";
            this.tot.ReadOnly = true;
            this.tot.Width = 70;
            // 
            // tributos_ID
            // 
            this.tributos_ID.DataPropertyName = "tributos_ID";
            this.tributos_ID.HeaderText = "Tributo ID";
            this.tributos_ID.Name = "tributos_ID";
            this.tributos_ID.ReadOnly = true;
            this.tributos_ID.Visible = false;
            // 
            // Frm_LiquidacionesDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LiquidacionesDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_LiquidacionesDetalle";
            this.Load += new System.EventHandler(this.Frm_LiquidacionesDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn abrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ene;
        private System.Windows.Forms.DataGridViewTextBoxColumn feb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn abr;
        private System.Windows.Forms.DataGridViewTextBoxColumn may;
        private System.Windows.Forms.DataGridViewTextBoxColumn jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ago;
        private System.Windows.Forms.DataGridViewTextBoxColumn sep;
        private System.Windows.Forms.DataGridViewTextBoxColumn oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn dic;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot;
        private System.Windows.Forms.DataGridViewTextBoxColumn tributos_ID;
    }
}