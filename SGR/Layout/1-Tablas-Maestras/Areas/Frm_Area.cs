using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Areas
{

    public partial class Frm_Area : DockContent
    {

        private string nodeActivo = "";

        Orga_AreaDataService area = new Orga_AreaDataService();
        public Frm_Area()
        {
            InitializeComponent();
            LoadOperacionesByModulo();
        }
        private void LoadOperacionesByModulo()
        {
            
            try
            {
                TreeNode nodoPadre = new TreeNode("Areas");

                List<Orga_Area> menus = new List<Orga_Area>();
                menus = area.listarHijos("");
                trvIngresos.Nodes.Clear();
                trvIngresos.ImageIndex = 0;
                trvIngresos.SelectedImageIndex = 0;
                trvIngresos.ItemHeight = 20;
                nodoPadre.Tag = "NP Areas";

                foreach (Orga_Area item in menus)
                {
                    List<Orga_Area> menus2 = new List<Orga_Area>();
                    TreeNode nodoHijo = new TreeNode();
                    nodoHijo.Text = item.Areac_vCodigo + " - " + item.Areac_vDescripcion;
                    nodoHijo.Name = item.Areac_vCodigo;
                    if (item.Areac_bactivo) nodoHijo.ForeColor = System.Drawing.Color.Green; else nodoHijo.ForeColor = System.Drawing.Color.Red;
                    menus2 = area.listarHijos(item.Areac_vCodigo);
                    foreach (Orga_Area item2 in menus2)
                    {
                        TreeNode nodoHijo2 = new TreeNode(item2.Areac_vCodigo);
                        nodoHijo2.Text = item2.Areac_vCodigo + " - " + item2.Areac_vDescripcion;
                        nodoHijo2.Name = item2.Areac_vCodigo;
                        if (item2.Areac_bactivo) nodoHijo2.ForeColor = System.Drawing.Color.Green; else nodoHijo2.ForeColor = System.Drawing.Color.Red;
                        nodoHijo.Nodes.Add(nodoHijo2);
                    }
                    nodoPadre.Nodes.Add(nodoHijo);
                }
                trvIngresos.Nodes.Add(nodoPadre);
                trvIngresos.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar areas", Globales.Global_MessageBox);
            }
           
        }
        private void SeleccionarElemento(object sender, TreeNodeMouseClickEventArgs e)
        {
            nodeActivo = e.Node.Name.ToString();
            if (e.Node.ForeColor == System.Drawing.Color.Green)
                tooleliminar.Enabled = true;
            else
                tooleliminar.Enabled = false;
        }
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            if (nodeActivo.Length != 4)
            {
                Orga_AreaDataService Areas = new Orga_AreaDataService();
                if (nodeActivo == "")
                {
                    Orga_Area elemento = new Orga_Area();

                    elemento.Areac_vCodigo = "";
                    elemento.Areac_vDescripcion = "";
                    Frm_AreaDetalle frmAreaDetalle = new Frm_AreaDetalle(elemento, 1);
                    frmAreaDetalle.StartPosition = FormStartPosition.CenterParent;
                    frmAreaDetalle.ShowDialog();
                    LoadOperacionesByModulo();
                }
                else
                {
                    Orga_Area elemento = Areas.GetByPrimaryKey(nodeActivo);
                    Frm_AreaDetalle frm_areaDetalle = new Frm_AreaDetalle(elemento, 1);
                    frm_areaDetalle.StartPosition = FormStartPosition.CenterParent;
                    frm_areaDetalle.ShowDialog();
                    LoadOperacionesByModulo();
                }
            }
            else
                MessageBox.Show("No se puede agregar un nuevo nivel de clasificador", Globales.Global_MessageBox);
        }
        private void tooleditar_Click(object sender, EventArgs e)
        {

            if (nodeActivo == "")
                MessageBox.Show("Este elemento no se puede editar", Globales.Global_MessageBox);
            else
            {
                Orga_AreaDataService Areas = new Orga_AreaDataService();
                Orga_Area elemento = Areas.GetByPrimaryKey(nodeActivo);
                Frm_AreaDetalle frm_AreaDetalle = new Frm_AreaDetalle(elemento, 2);
                frm_AreaDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_AreaDetalle.ShowDialog();
                LoadOperacionesByModulo();
            }
        }
        private void tooleliminar_Click(object sender, EventArgs e)
        {
            Orga_AreaDataService AreaDS = new Orga_AreaDataService();
            if (AreaDS.DeleteByPrimaryKey(nodeActivo))
            {
                MessageBox.Show("Se elimino correctamente", Globales.Global_MessageBox);
                LoadOperacionesByModulo();
            }
        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                List<Orga_Area> coleccion = new List<Orga_Area>();
                coleccion = area.listarAreaReporte();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Areas.rptAreas.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSAreas", coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
