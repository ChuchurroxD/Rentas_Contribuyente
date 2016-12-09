using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WindowsControls.VB;
using SGR.Entity.Model;
using SGR.Core.Service;
using System.Reflection;
using SGR.WinApp.Layout._1_Tablas_Maestras.Usuarios;
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial;

namespace SGR.WinApp.Sistema.Entorno
{
    public partial class barramenu : barrabase
    {
        public  Int32 valor = 0;

        public barramenu()
        {
            InitializeComponent();
        }

        private static barramenu _instancia;
        public static barramenu Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new barramenu();
                    // _instancia.valor = valorx;
                    _instancia.Disposed +=_instancia_Disposed;
                }
                return _instancia;
            }
        }

        private static void _instancia_Disposed(object sender, EventArgs e)
        {
            _instancia=null;
        }


        private Image  imagenmodulo(long  codmodulo)
        {
            Image  bmp=null;

            switch (codmodulo)
            {
            case 1:
             bmp = new Bitmap(SGR.WinApp.Properties.Resources.page_white_copy );
            
            break;
            case 2:
            bmp = new Bitmap(SGR.WinApp.Properties.Resources.coins);
            break;
            case 3:
            bmp = new Bitmap(SGR.WinApp.Properties.Resources.savesave);
            break;
            case 4:
            bmp = new Bitmap(SGR.WinApp.Properties.Resources.check);
            break;

            case 5:
            bmp = new Bitmap(SGR.WinApp.Properties.Resources.plugin);
            break;

            case 6:
            bmp = new Bitmap(SGR.WinApp.Properties.Resources.tables );
            break;

            case 7:
            bmp = new Bitmap(SGR.WinApp.Properties.Resources.tributos );
            break;

            default:
            bmp = new Bitmap(SGR.WinApp.Properties.Resources.education);
            break;
            }
            return bmp;

        }
        private void LoadModulos(Int32 role)
        {
            outlookPanelBar.Buttons.Clear();

            Conf_GrupoDataService Conf_GrupoDataService = new Conf_GrupoDataService();
            List<Conf_Grupo> Modulos = Conf_GrupoDataService.listarxrol  (GlobalesV1 .Global_int_idrol );
                                
         

            foreach (Conf_Grupo item in  Modulos)
            {
                OutlookBarButton btn = new OutlookBarButton();
                btn.ID="0";
                btn.Text =item.Grupc_vNombre;


                 var bmp = new Bitmap (SGR.WinApp.Properties.Resources.check );

                btn.Image =imagenmodulo(item.Grupc_iCodigo );
                btn.Code=item.Grupc_iCodigo.ToString();
                outlookPanelBar.Buttons.Add(btn);
                outlookPanelBar.Height+=40;
            }

            trvPanelOpciones.Height=Screen.PrimaryScreen.WorkingArea.Height -outlookPanelBar.Height-cpnlTitulo.Height-85;
            if (outlookPanelBar.Buttons.Count>0)
                outlookPanelBar.Buttons[0].Selected =true;

        }

        private void barramenu_Load(object sender, EventArgs e)
        {
            if (DesignMode == false)
            {
                LoadModulos(this.valor);
            }       
        
        }

        private void outlookPanelBar_ButtonClicked(object sender, EventArgs e)
        {
            if (Int16.Parse(outlookPanelBar.SelectedButton.Code) == 12)
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                Frm_RepGerencial frm_RepGerencial = new Frm_RepGerencial();
                frm_RepGerencial.StartPosition = FormStartPosition.CenterScreen;
                frm_RepGerencial.ShowDialog();
                //Frm_Liqui.StartPosition = FormStartPosition.CenterParent;
                //Frm_Liqui.ShowDialog();
            }
            else
            {
                lblPanelTitle.Text = outlookPanelBar.SelectedButton.Text;
                LoadOperacionesByModulo(Int16.Parse(outlookPanelBar.SelectedButton.Code));
            }            
        }

        private void LoadOperacionesByModulo(Int32 code)
        {

            Conf_TareaDataService Conf_TareaDataService = new Conf_TareaDataService();
            List<Conf_Tarea> Menus = Conf_TareaDataService.GetAllConf_Tarea(code ,GlobalesV1 .Global_int_idrol ); //code



            // menus.Add(new Segu_MenuOperaciones{Menu_iCodigo=1,Menu_vMenu="Usuarios" ,Menu_iOperacionPadre=0,Moduc_iCodigo=1 ,Menu_vFormulario="Form1" });


            trvPanelOpciones.Nodes.Clear();
            trvPanelOpciones.ImageList = lstImages;
            trvPanelOpciones.ImageIndex = 0;
            trvPanelOpciones.SelectedImageIndex = 0;
            trvPanelOpciones.ItemHeight = 20;

            TreeNode nodoPadre = new TreeNode(lblPanelTitle.Text);
            nodoPadre.Tag = "NP" + code.ToString ();

            foreach (Conf_Tarea item in Menus)
            {
                
                TreeNode nodoHijo = new TreeNode(item.Tarec_vNombre );
                if (item.Tarec_Padre  == 0)
                {
                    LoadSubOperaciones(Menus, nodoHijo,int.Parse ( item.Tarec_iCodigo.ToString ()) , 0);
                    nodoPadre.Nodes.Add(nodoHijo);
                }
            }

            trvPanelOpciones.Nodes.Add(nodoPadre);
            trvPanelOpciones.Nodes[0].Expand();
        }

        private IDockContent BuscarOperacion(string text)
        {
            foreach (IDockContent content in DockPanel.Documents)
            {
                if (content.DockHandler.TabText == text)
                {
                    return content;
                }
            }
            return null;
        }
        private DockContent CrearNuevaOperacion(Conf_Tarea operacion)
        {

   
            Type tipo = Type.GetType(string.Format("SGR.WinApp.{0}", operacion.Tarec_vUrl.TrimEnd ()));

            DockContent formulario = null;
            dynamic propiedadInstancia = tipo.GetProperty("Instancia", (BindingFlags.Public | BindingFlags.Static));

            if (propiedadInstancia != null)
            {
                formulario = (DockContent)propiedadInstancia.GetValue(null, null);
            }
            else
            {
                formulario = (DockContent)Activator.CreateInstance(tipo);
                formulario.Tag = operacion.Tarec_iCodigo;
                formulario.Text = formulario.Text + " " + operacion.Tarec_vNombre;

            }

            IDockContent dockTab = BuscarOperacion(operacion.Tarec_vNombre);
            while (dockTab != null)
            {
                dynamic tabPanel = (DockContent)dockTab;
                tabPanel.Text = operacion.Tarec_vNombre ;
                //tabPanel.CloseButton =
                //tabPanel.CloseButtonVisible = false;
                return tabPanel;
            }
            //

            //formulario.CloseButtonVisible = false;

            return formulario;
        }


        private void LoadSubOperaciones(List<Conf_Tarea> subOperaciones,TreeNode tn,Int32 codeOperacion , Int32 vRolx)
        {
            Func<int, List<Conf_Tarea>> values = codigo => subOperaciones.FindAll(op => op.Tarec_Padre  == codigo);

            List<Conf_Tarea> items = values(codeOperacion);
            if (items.Count != 0)
            {
                tn.Tag = "NP" + codeOperacion;
                foreach (Conf_Tarea item in items)
                {
                    //  If item.Rol.Contains(vRolx.ToString) Then
                    TreeNode node = new TreeNode(item.Tarec_vNombre);
                    dynamic a = values(int.Parse (item.Tarec_iCodigo.ToString ()));
                    if (a.Count != 0)
                    {
                        node.Tag = "NP" + item.Tarec_iCodigo.ToString();
                    }
                    else
                    {
                        node.Tag = "NH" + item.Tarec_iCodigo.ToString();
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                    }
                    tn.Nodes.Add(node);
                    LoadSubOperaciones(subOperaciones, node, int.Parse (item.Tarec_iCodigo.ToString ()), vRolx);
                    //  End If
                }
            }
            else
            {
                tn.Tag = "NH" + codeOperacion;
                tn.ImageIndex = 1;
                tn.SelectedImageIndex = 1;
            }
        }
        private void trvPanelOpciones_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (this.Cursor == Cursors.WaitCursor)
                {
                    MessageBox.Show("PROCESANDO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Cursor = Cursors.WaitCursor;
                //lo que hace el boton
                string codigo = e.Node.Tag.ToString();
                codigo = codigo.Substring(0, 2);
                if (codigo == "NH")
                {
                    codigo = e.Node.Tag.ToString();
                    codigo = codigo.Substring(2);
                    e.Node.EnsureVisible();

                    Conf_TareaDataService Conf_TareaDataService = new Conf_TareaDataService();
                  

                    Conf_Tarea operacion = Conf_TareaDataService.GetByPrimaryKey(int.Parse(codigo));

                   
                 //   operacion.Menu_vMenu="Usuarios";
                 //   operacion.Menu_vFormulario= "Layout._1_Tablas_Maestras.Sectores.Frm_sectores";//Layout._1_Tablas_Maestras.Sectores Layout._1_Tablas_Maestras.Usuarios.Frm_usuario


                    if ((operacion != null))
                    {
                        if (operacion.Tarec_vNombre.Trim().Length != 0)
                        {

                            DockContent viewPantalla = CrearNuevaOperacion(operacion);
                            viewPantalla.Show(DockPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }
        }
    }
}
