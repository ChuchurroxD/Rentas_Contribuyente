namespace SGR.WinApp.Sistema.Entorno
{
    partial class barramenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barramenu));
            this.cpnlTitulo = new WindowsControls.VB.CloudToolkit.CloudPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cloudPanel1 = new WindowsControls.VB.CloudToolkit.CloudPanel();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.trvPanelOpciones = new System.Windows.Forms.TreeView();
            this.outlookPanelBar = new WindowsControls.VB.OutlookBar();
            this.lstImages = new System.Windows.Forms.ImageList(this.components);
            this.cpnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cloudPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpnlTitulo
            // 
            this.cpnlTitulo.Controls.Add(this.splitContainer1);
            this.cpnlTitulo.Controls.Add(this.outlookPanelBar);
            this.cpnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.cpnlTitulo.Name = "cpnlTitulo";
            this.cpnlTitulo.Size = new System.Drawing.Size(234, 626);
            this.cpnlTitulo.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cloudPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.trvPanelOpciones);
            this.splitContainer1.Size = new System.Drawing.Size(234, 588);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 1;
            // 
            // cloudPanel1
            // 
            this.cloudPanel1.Controls.Add(this.lblPanelTitle);
            this.cloudPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cloudPanel1.Location = new System.Drawing.Point(0, 0);
            this.cloudPanel1.Name = "cloudPanel1";
            this.cloudPanel1.Size = new System.Drawing.Size(234, 42);
            this.cloudPanel1.TabIndex = 0;
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.AutoSize = true;
            this.lblPanelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPanelTitle.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPanelTitle.Location = new System.Drawing.Point(12, 9);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(199, 24);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "PANEL DE CONTROL";
            // 
            // trvPanelOpciones
            // 
            this.trvPanelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.trvPanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.trvPanelOpciones.Name = "trvPanelOpciones";
            this.trvPanelOpciones.Size = new System.Drawing.Size(234, 500);
            this.trvPanelOpciones.TabIndex = 0;
            this.trvPanelOpciones.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvPanelOpciones_NodeMouseClick);
            // 
            // outlookPanelBar
            // 
            this.outlookPanelBar.ButtonColorHoveringBottom = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonColorHoveringTop = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonColorPassiveBottom = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonColorPassiveTop = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonColorSelectedAndHoveringBottom = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonColorSelectedAndHoveringTop = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonColorSelectedBottom = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonColorSelectedTop = System.Drawing.Color.Empty;
            this.outlookPanelBar.ButtonHeight = 35;
            this.outlookPanelBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outlookPanelBar.ForeColorSelected = System.Drawing.Color.Empty;
            this.outlookPanelBar.Location = new System.Drawing.Point(0, 588);
            this.outlookPanelBar.MinimumSize = new System.Drawing.Size(15, 38);
            this.outlookPanelBar.Name = "outlookPanelBar";
            this.outlookPanelBar.OutlookBarLineColor = System.Drawing.Color.Empty;
            this.outlookPanelBar.Size = new System.Drawing.Size(234, 38);
            this.outlookPanelBar.TabIndex = 0;
            this.outlookPanelBar.Text = "outlookBar1";
            this.outlookPanelBar.ButtonClicked += new WindowsControls.VB.OutlookBar.ButtonClickedEventHandler(this.outlookPanelBar_ButtonClicked);
            // 
            // lstImages
            // 
            this.lstImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImages.ImageStream")));
            this.lstImages.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImages.Images.SetKeyName(0, "battery.ico");
            this.lstImages.Images.SetKeyName(1, "book_blue_find.ico");
            // 
            // barramenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 626);
            this.Controls.Add(this.cpnlTitulo);
            this.Name = "barramenu";
            this.Text = "SNET";
            this.Load += new System.EventHandler(this.barramenu_Load);
            this.cpnlTitulo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cloudPanel1.ResumeLayout(false);
            this.cloudPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsControls.VB.CloudToolkit.CloudPanel cpnlTitulo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private WindowsControls.VB.CloudToolkit.CloudPanel cloudPanel1;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.TreeView trvPanelOpciones;
        private WindowsControls.VB.OutlookBar outlookPanelBar;
        private System.Windows.Forms.ImageList lstImages;
    }
}