using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WindowsControls.VB.Office2007Renderer;

namespace SGR.WinApp.Sistema.Entorno
{
    public partial class MainPrincipal : barrabase
    {
        private bool EsCerrarSesion = false;
        private barramenu solutionExplorer;
        private DeserializeDockContent deserializeDockContent;
        private bool SaveLayout=true ;

        private static MainPrincipal _instancia;
        public static MainPrincipal Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new MainPrincipal();
                    _instancia.Disposed+=_instancia_Disposed; ;
                }
                return _instancia;
            }
        }

        private static void _instancia_Disposed(object sender, EventArgs e)
        {
            _instancia =null;
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(barramenu).ToString())
                return solutionExplorer;
            else
                return null;
        }



        public MainPrincipal()
        {
            InitializeComponent();
        }

        private void MainPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel)
            {
                string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
                if (SaveLayout)
                {
                    dockPanel1.SaveAsXml (configFile);
                }
                else if (File.Exists(configFile))
                {
                    File.Delete(configFile);
                }
            }

            if (!EsCerrarSesion)
            {
                Application.Exit();
            }
        }

        private void MainPrincipal_Load(object sender, EventArgs e)
        {
            solutionExplorer = barramenu.Instancia;

            deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);


            if (DesignMode == false)
            {
                ToolStripManager.Renderer = new Office2007Renderer();
            }
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            if (File.Exists(configFile))
            {
                dockPanel1.LoadFromXml(configFile, deserializeDockContent);
            }

            toolStripStatusLabel1.Text = "OFICINA:" + GlobalesV1.Global_str_oficina;
            toolStripStatusLabel2.Text = "ROL:" + GlobalesV1.Global_str_Rol ;
            toolStripStatusLabel3.Text = "USUARIO:" + GlobalesV1.Global_str_Usuario ;
        }

        private void panelDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solutionExplorer = barramenu.Instancia;
            solutionExplorer.Show(dockPanel1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
