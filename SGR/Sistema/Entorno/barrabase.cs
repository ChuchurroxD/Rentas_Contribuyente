using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Sistema.Entorno
{
    public partial class barrabase : DockContent
    {
        public barrabase()
        {
            InitializeComponent();
        }

        private void barrabase_DockStateChanged(object sender, EventArgs e)
        {

            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
            {
                item.Checked=false;            
            }



            switch (DockState)
            {
            case DockState.DockTop:
            break; // TODO: might not be correct. Was : Exit Select
            case DockState.DockRight:
            break; // TODO: might not be correct. Was : Exit Select
            case DockState.DockBottom:          
            break; // TODO: might not be correct. Was : Exit Select            
            case DockState.DockLeft:
            acoplableToolStripMenuItem.Checked=true;
            break; // TODO: might not be correct. Was : Exit Select

            case DockState.DockTopAutoHide:
            break; // TODO: might not be correct. Was : Exit Select
            case DockState.DockRightAutoHide:
            break; // TODO: might not be correct. Was : Exit Select
            
            case DockState.DockBottomAutoHide:
            break; // TODO: might not be correct. Was : Exit Select
            

            

            case DockState.DockLeftAutoHide:
            ocultarAutomaticamenteToolStripMenuItem.Checked=true;
            break;

            case DockState.Float:
            flotanteToolStripMenuItem.Checked=true;
            break;

            default:
            break; // TODO: might not be correct. Was : Exit Select

          
            }
        }

        private void flotanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockState = WeifenLuo.WinFormsUI.Docking.DockState.Float;
        }

        private void acoplableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockState = ShowHint;
        }

        private void ocultarAutomaticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            switch (DockState)
            {
            case DockState.DockBottom:
            DockState = WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide;
            break; // TODO: might not be correct. Was : Exit Select

            case DockState.DockLeft:
            DockState = WeifenLuo.WinFormsUI.Docking.DockState.DockLeftAutoHide;
            break; // TODO: might not be correct. Was : Exit Select


            case DockState.DockRight:
            DockState = WeifenLuo.WinFormsUI.Docking.DockState.DockRightAutoHide;
            break; // TODO: might not be correct. Was : Exit Select


            case DockState.DockRightAutoHide:
            break; // TODO: might not be correct. Was : Exit Select


            case DockState.DockTop:
            DockState = WeifenLuo.WinFormsUI.Docking.DockState.DockTopAutoHide;
            break; // TODO: might not be correct. Was : Exit Select


            default:
            break; // TODO: might not be correct. Was : Exit Select

            }
        }
    }
}
