namespace SGR.WinApp.Sistema.Entorno
{
    partial class barrabase
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flotanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acoplableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarAutomaticamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flotanteToolStripMenuItem,
            this.acoplableToolStripMenuItem,
            this.ocultarAutomaticamenteToolStripMenuItem,
            this.ocultarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 92);
            // 
            // flotanteToolStripMenuItem
            // 
            this.flotanteToolStripMenuItem.Name = "flotanteToolStripMenuItem";
            this.flotanteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.flotanteToolStripMenuItem.Text = "Flotante";
            this.flotanteToolStripMenuItem.Click += new System.EventHandler(this.flotanteToolStripMenuItem_Click);
            // 
            // acoplableToolStripMenuItem
            // 
            this.acoplableToolStripMenuItem.Name = "acoplableToolStripMenuItem";
            this.acoplableToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.acoplableToolStripMenuItem.Text = "Acoplable";
            this.acoplableToolStripMenuItem.Click += new System.EventHandler(this.acoplableToolStripMenuItem_Click);
            // 
            // ocultarAutomaticamenteToolStripMenuItem
            // 
            this.ocultarAutomaticamenteToolStripMenuItem.Name = "ocultarAutomaticamenteToolStripMenuItem";
            this.ocultarAutomaticamenteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ocultarAutomaticamenteToolStripMenuItem.Text = "Ocultar Automaticamente";
            this.ocultarAutomaticamenteToolStripMenuItem.Click += new System.EventHandler(this.ocultarAutomaticamenteToolStripMenuItem_Click);
            // 
            // ocultarToolStripMenuItem
            // 
            this.ocultarToolStripMenuItem.Name = "ocultarToolStripMenuItem";
            this.ocultarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ocultarToolStripMenuItem.Text = "Ocultar";
            // 
            // barrabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "barrabase";
            this.Text = "barrabase";
            this.DockStateChanged += new System.EventHandler(this.barrabase_DockStateChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flotanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acoplableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarAutomaticamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarToolStripMenuItem;
    }
}