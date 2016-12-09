using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Usuarios
{
    public partial class Frm_usuarios : DockContent
    {
        public Frm_usuarios()
        {
            InitializeComponent();
        }

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {

            
            Segu_UsuarioDataService Segu_UsuarioDataService = new Segu_UsuarioDataService();
            dataGridView1.DataSource =Segu_UsuarioDataService.GetAllSegu_Usuarios();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            Frm_usuarios_detalle Frm_usuarios_detalle = new Frm_usuarios_detalle();
            Frm_usuarios_detalle.StartPosition=FormStartPosition.CenterParent;
            Frm_usuarios_detalle.ShowDialog();

        }

        private void toolmantenedores_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolGrabar_Click(object sender, EventArgs e)
        {

        }
    }
}
