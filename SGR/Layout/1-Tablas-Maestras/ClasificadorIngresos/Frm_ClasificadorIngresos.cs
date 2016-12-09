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
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ClasificadorIngresos
{
    public partial class Frm_ClasificadorIngresos : DockContent
    {
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private string nodeActivo;
        public Frm_ClasificadorIngresos()
        {
            InitializeComponent();
            cargarCombos();
            LoadOperacionesByModulo(Convert.ToString(cboPeriodo.SelectedValue));
        }

        public void cargarCombos()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = periodos.GetAllMant_Periodo();
            cboPeriodoCopiar.DisplayMember = "Peric_canio";
            cboPeriodoCopiar.ValueMember = "Peric_canio";
            cboPeriodoCopiar.DataSource = periodos.GetAllMant_Periodo();
        }


        private void LoadOperacionesByModulo(string peri)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                TreeNode nodoPadre = new TreeNode("Ingresos");
                trvIngresos.Nodes.Clear();
                nodeActivo = "";
                Trib_ClasificadorIngresosDataService ClasificadorIngresos = new Trib_ClasificadorIngresosDataService();

                List<Trib_ClasificadorIngresos> menus = new List<Trib_ClasificadorIngresos>();
                menus = ClasificadorIngresos.listarHijos("", peri);
                trvIngresos.Nodes.Clear();
                trvIngresos.ImageIndex = 0;
                trvIngresos.SelectedImageIndex = 0;
                trvIngresos.ItemHeight = 20;
                nodoPadre.Tag = "NP Ingresos";
                nodoPadre.Name = "0";

                foreach (Trib_ClasificadorIngresos item in menus)
                {
                    List<Trib_ClasificadorIngresos> menus2 = new List<Trib_ClasificadorIngresos>();
                    TreeNode nodoHijo = new TreeNode();
                    nodoHijo.Text = item.Tribc_vCodigo + " - " + item.Tribc_vDescripcion;
                    nodoHijo.Name = item.Tribc_vCodigo;
                    if (item.Tribc_bEstado) nodoHijo.ForeColor = System.Drawing.Color.Green; else nodoHijo.ForeColor = System.Drawing.Color.Red;
                    menus2 = ClasificadorIngresos.listarHijos(item.Tribc_vCodigo, peri);
                    foreach (Trib_ClasificadorIngresos item2 in menus2)
                    {
                        TreeNode nodoHijo2 = new TreeNode(item2.Tribc_vCodigo);
                        nodoHijo2.Text = item2.Tribc_vCodigo + " - " + item2.Tribc_vDescripcion;
                        nodoHijo2.Name = item2.Tribc_vCodigo;
                        if (item2.Tribc_bEstado) nodoHijo2.ForeColor = System.Drawing.Color.Green; else nodoHijo2.ForeColor = System.Drawing.Color.Red;
                        List<Trib_ClasificadorIngresos> menus3 = new List<Trib_ClasificadorIngresos>();
                        menus3 = ClasificadorIngresos.listarHijos(item2.Tribc_vCodigo, peri);
                        foreach (Trib_ClasificadorIngresos item3 in menus3)
                        {
                            TreeNode nodoHijo3 = new TreeNode();
                            nodoHijo3.Text = item3.Tribc_vCodigo + " - " + item3.Tribc_vDescripcion;
                            nodoHijo3.Name = item3.Tribc_vCodigo;
                            if (item3.Tribc_bEstado) nodoHijo3.ForeColor = System.Drawing.Color.Green; else nodoHijo3.ForeColor = System.Drawing.Color.Red;
                            List<Trib_ClasificadorIngresos> menus4 = new List<Trib_ClasificadorIngresos>();
                            menus4 = ClasificadorIngresos.listarHijos(item3.Tribc_vCodigo, peri);
                            foreach (Trib_ClasificadorIngresos item4 in menus4)
                            {
                                TreeNode nodoHijo4 = new TreeNode();
                                nodoHijo4.Text = item4.Tribc_vCodigo + " - " + item4.Tribc_vDescripcion;
                                nodoHijo4.Name = item4.Tribc_vCodigo;
                                if (item4.Tribc_bEstado) nodoHijo4.ForeColor = System.Drawing.Color.Green; else nodoHijo4.ForeColor = System.Drawing.Color.Red;
                                List<Trib_ClasificadorIngresos> menus5 = new List<Trib_ClasificadorIngresos>();
                                menus5 = ClasificadorIngresos.listarHijos(item4.Tribc_vCodigo, peri);
                                foreach (Trib_ClasificadorIngresos item5 in menus5)
                                {
                                    TreeNode nodoHijo5 = new TreeNode();
                                    nodoHijo5.Text = item5.Tribc_vCodigo + " - " + item5.Tribc_vDescripcion;
                                    nodoHijo5.Name = item5.Tribc_vCodigo;
                                    if (item5.Tribc_bEstado) nodoHijo5.ForeColor = System.Drawing.Color.Green; else nodoHijo5.ForeColor = System.Drawing.Color.Red;
                                    List<Trib_ClasificadorIngresos> menus6 = new List<Trib_ClasificadorIngresos>();
                                    menus6 = ClasificadorIngresos.listarHijos(item5.Tribc_vCodigo, peri);
                                    foreach (Trib_ClasificadorIngresos item6 in menus6)
                                    {
                                        TreeNode nodoHijo6 = new TreeNode();
                                        nodoHijo6.Text = item6.Tribc_vCodigo + " - " + item6.Tribc_vDescripcion;
                                        nodoHijo6.Name = item6.Tribc_vCodigo;
                                        if (item6.Tribc_bEstado) nodoHijo6.ForeColor = System.Drawing.Color.Green; else nodoHijo6.ForeColor = System.Drawing.Color.Red;


                                        nodoHijo5.Nodes.Add(nodoHijo6);
                                    }
                                    nodoHijo4.Nodes.Add(nodoHijo5);
                                }
                                nodoHijo3.Nodes.Add(nodoHijo4);
                            }
                            nodoHijo2.Nodes.Add(nodoHijo3);
                        }
                        nodoHijo.Nodes.Add(nodoHijo2);
                    }
                    nodoPadre.Nodes.Add(nodoHijo);
                }
                trvIngresos.Nodes.Add(nodoPadre);
                trvIngresos.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clasificadores", Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void ActivarItem(object sender, TreeNodeMouseClickEventArgs e)
        {
            nodeActivo = e.Node.Name.ToString();
            if (e.Node.ForeColor == System.Drawing.Color.Green)
                tooleliminar.Enabled = true;
            else
                tooleliminar.Enabled = false;
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (nodeActivo.Length != 10)
                {
                    Trib_ClasificadorIngresosDataService ClasificadorIngresos = new Trib_ClasificadorIngresosDataService();
                    if (nodeActivo == "")
                    {
                        Trib_ClasificadorIngresos elemento = new Trib_ClasificadorIngresos();
                        elemento.Tribc_vAnio = cboPeriodo.Text;
                        elemento.Tribc_vCodigo = "";
                        elemento.Tribc_vDescripcion = "";
                        Frm_ClasificadorIngresosDetalle frm_ClasificadorIngreso = new Frm_ClasificadorIngresosDetalle(elemento, 1);
                        frm_ClasificadorIngreso.StartPosition = FormStartPosition.CenterParent;
                        frm_ClasificadorIngreso.ShowDialog();
                        LoadOperacionesByModulo(cboPeriodo.Text);
                    }
                    else
                    {
                        Trib_ClasificadorIngresos elemento = ClasificadorIngresos.GetByPrimaryKey(nodeActivo, cboPeriodo.Text);
                        Frm_ClasificadorIngresosDetalle frm_ClasificadorIngreso = new Frm_ClasificadorIngresosDetalle(elemento, 1);
                        frm_ClasificadorIngreso.StartPosition = FormStartPosition.CenterParent;
                        frm_ClasificadorIngreso.ShowDialog();
                        LoadOperacionesByModulo(cboPeriodo.Text);
                    }
                }
                else
                    MessageBox.Show("No se puede agregar un nuevo nivel de clasificador", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            if (nodeActivo == "")
                MessageBox.Show("Este elemento no se puede editar", Globales.Global_MessageBox);
            else
            {
                Trib_ClasificadorIngresosDataService ClasificadorIngresos = new Trib_ClasificadorIngresosDataService();
                Trib_ClasificadorIngresos elemento = ClasificadorIngresos.GetByPrimaryKey(nodeActivo, cboPeriodo.Text);
                Frm_ClasificadorIngresosDetalle frm_ClasificadorIngreso = new Frm_ClasificadorIngresosDetalle(elemento, 2);
                frm_ClasificadorIngreso.StartPosition = FormStartPosition.CenterParent;
                frm_ClasificadorIngreso.ShowDialog();
                LoadOperacionesByModulo(cboPeriodo.Text);
            }
        }

        private void recargarGrilla(object sender, EventArgs e)
        {
            LoadOperacionesByModulo(cboPeriodo.Text);
        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            Trib_ClasificadorIngresosDataService ClasificadorIngresos = new Trib_ClasificadorIngresosDataService();
            Trib_ClasificadorIngresos elemento = new Trib_ClasificadorIngresos();
            elemento = ClasificadorIngresos.GetByPrimaryKey(nodeActivo, Convert.ToString(cboPeriodo.SelectedValue));
            if (ClasificadorIngresos.DeleteByPrimaryKey(elemento.Tribc_vCodigo, elemento.Tribc_vAnio))
            {
                MessageBox.Show("Se actualizó correctamente", Globales.Global_MessageBox);
                LoadOperacionesByModulo(cboPeriodo.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;            
            try
            {
                string periodoActual, periodoAnterior;
                periodoActual = Convert.ToString(cboPeriodoCopiar.SelectedValue);
                periodoAnterior = Convert.ToString(cboPeriodo.SelectedValue);
                if (!periodoActual.Equals(periodoAnterior))
                {
                    if (MessageBox.Show("Al copiar los clasificadores, se eliminará los registros del periodo destino\n Confirmar Grabación", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        Trib_ClasificadorIngresosDataService ClasificadorIngresos = new Trib_ClasificadorIngresosDataService();
                        ClasificadorIngresos.copiarClasificadores(periodoAnterior, periodoActual);
                        MessageBox.Show("Se copió correctamente los clasificadores", Globales.Global_MessageBox);
                    }
                }
                else
                {
                    MessageBox.Show("Escoja un periodo distinto al que copiar", Globales.Global_MessageBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al copiar los clasificadores", Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void cboPeriodoCopiar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 