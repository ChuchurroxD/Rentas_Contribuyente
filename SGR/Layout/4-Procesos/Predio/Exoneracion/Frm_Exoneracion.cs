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
namespace SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion
{
    public partial class Frm_Exoneracion : Form
    {
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_Descuentos_ExoneracionDataService pred_Descuentos_ExoneracionDataService = new Pred_Descuentos_ExoneracionDataService();
        private List<Pred_Descuentos_Exoneracion> Coleccion;
        private SortOrder Orden = new SortOrder();
        private String contribuyente_id="";
        private String contribuyente_nombre = "";
        private int periodo = 0;
        private string user = "nada";
        public Frm_Exoneracion()
        {
            contribuyente_id = "1283";
            contribuyente_nombre = "hh";
            InitializeComponent();
            periodo= PeriodoDataService.GetPeriodoActivo();
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
            cboPeriodo.SelectedValue = periodo;
            Coleccion = pred_Descuentos_ExoneracionDataService.listartodos(periodo, contribuyente_id);
            dgvExoneracion.DataSource = Coleccion;
        }
        public Frm_Exoneracion(String idcon,String nomcont,int period)
        {
            contribuyente_id = idcon;
            contribuyente_nombre = nomcont;
            InitializeComponent();
            periodo = PeriodoDataService.GetPeriodoActivo();
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
            cboPeriodo.SelectedValue = period;
            Coleccion = pred_Descuentos_ExoneracionDataService.listartodos(periodo, contribuyente_id);
            dgvExoneracion.DataSource = Coleccion;
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {

            Frm_Exoneracion_Detalle Frm_Exoneracion_Detalle = new Frm_Exoneracion_Detalle(contribuyente_id, contribuyente_nombre);//8832
            Frm_Exoneracion_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_Exoneracion_Detalle.ShowDialog();
            Coleccion = pred_Descuentos_ExoneracionDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue), contribuyente_id);
            dgvExoneracion.DataSource = Coleccion;
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            if (dgvExoneracion.SelectedRows.Count>0)
            {
                    Frm_Exoneracion_Detalle Frm_Exoneracion_Detalle = new Frm_Exoneracion_Detalle(obtenerdatos(), contribuyente_id, contribuyente_nombre);
                    Frm_Exoneracion_Detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_Exoneracion_Detalle.ShowDialog();
                Coleccion = pred_Descuentos_ExoneracionDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue), contribuyente_id);
                dgvExoneracion.DataSource = Coleccion;
            }
            else
            {
                MessageBox.Show("Seleccione un  registro",Globales.Global_MessageBox);
            }
            
        }
        private Pred_Descuentos_Exoneracion obtenerdatos()
        {
            Pred_Descuentos_Exoneracion Pred_Descuentos_Exoneracion = new Pred_Descuentos_Exoneracion();
            Pred_Descuentos_Exoneracion.anio = (Int16)dgvExoneracion.SelectedRows[0].Cells["anio"].Value;
            //Pred_Descuentos_Exoneracion.base_imponible = (decimal)dgvExoneracion.SelectedRows[0].Cells["base_imponible"].Value;
            Pred_Descuentos_Exoneracion.estado = (bool)dgvExoneracion.SelectedRows[0].Cells["estado"].Value;
            //Pred_Descuentos_Exoneracion.codigo_exo = (string)dgvExoneracion.SelectedRows[0].Cells["codigo_exo"].Value;
            Pred_Descuentos_Exoneracion.condicion = (Int16)dgvExoneracion.SelectedRows[0].Cells["condicion"].Value;
            Pred_Descuentos_Exoneracion.condicion_descripcion = (String)dgvExoneracion.SelectedRows[0].Cells["condicion_descripcion"].Value;
            Pred_Descuentos_Exoneracion.contribuyente_ID = (String)dgvExoneracion.SelectedRows[0].Cells["contribuyente_IDD"].Value;
            //Pred_Descuentos_Exoneracion.deduccion = (Int32)dgvExoneracion.SelectedRows[0].Cells["deduccion"].Value;
            Pred_Descuentos_Exoneracion.des_exo_ID = (Int32)dgvExoneracion.SelectedRows[0].Cells["des_exo_ID"].Value;
            //Pred_Descuentos_Exoneracion.efec_descuento = (decimal)dgvExoneracion.SelectedRows[0].Cells["efec_descuento"].Value;
            Pred_Descuentos_Exoneracion.expediente = (String)dgvExoneracion.SelectedRows[0].Cells["expediente"].Value;
            Pred_Descuentos_Exoneracion.formularios = (decimal)dgvExoneracion.SelectedRows[0].Cells["formularios"].Value;
            //Pred_Descuentos_Exoneracion.impuesto_anual = (String)dgvExoneracion.SelectedRows[0].Cells["impuesto_anual"].Value;
            //Pred_Descuentos_Exoneracion.monto_afectado = (String)dgvExoneracion.SelectedRows[0].Cells["monto_afectado"].Value;
            Pred_Descuentos_Exoneracion.anioInicio = (Int16)dgvExoneracion.SelectedRows[0].Cells["anioInicio"].Value;
            Pred_Descuentos_Exoneracion.anioFin = (Int16)dgvExoneracion.SelectedRows[0].Cells["anioFin"].Value;
            Pred_Descuentos_Exoneracion.mesInicio = (Int16)dgvExoneracion.SelectedRows[0].Cells["mesInicio"].Value;
            Pred_Descuentos_Exoneracion.mesFin = (Int16)dgvExoneracion.SelectedRows[0].Cells["mesFin"].Value;
            Pred_Descuentos_Exoneracion.motivo = (Int16)dgvExoneracion.SelectedRows[0].Cells["motivo"].Value;
            Pred_Descuentos_Exoneracion.observaciones = (String)dgvExoneracion.SelectedRows[0].Cells["observaciones"].Value;
            Pred_Descuentos_Exoneracion.porcentaje_dcto = (decimal)dgvExoneracion.SelectedRows[0].Cells["porcentaje_dcto"].Value;
            Pred_Descuentos_Exoneracion.predio_ID = (String)dgvExoneracion.SelectedRows[0].Cells["predio_ID"].Value;
            Pred_Descuentos_Exoneracion.resolucion = (String)dgvExoneracion.SelectedRows[0].Cells["resolucion"].Value;
            Pred_Descuentos_Exoneracion.resol_imagen = (String)dgvExoneracion.SelectedRows[0].Cells["resol_imagen"].Value;
            Pred_Descuentos_Exoneracion.tipo = (Int16)dgvExoneracion.SelectedRows[0].Cells["tipo"].Value;
            Pred_Descuentos_Exoneracion.tipo_operacion = (Int16)dgvExoneracion.SelectedRows[0].Cells["tipo_operacion"].Value;
            Pred_Descuentos_Exoneracion.tributo_ID = (String)dgvExoneracion.SelectedRows[0].Cells["tributo_ID"].Value;
            Pred_Descuentos_Exoneracion.tributo_descripcion = (String)dgvExoneracion.SelectedRows[0].Cells["tributo_descripcion"].Value;
            return Pred_Descuentos_Exoneracion;
        }

        private void dgvExoneracion_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvExoneracion.Columns[e.ColumnIndex];

                if (dgvExoneracion.SortOrder == SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "predio_descripcion")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvExoneracion.DataSource = Coleccion.OrderBy(p => p.predio_descripcion).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvExoneracion.DataSource = Coleccion.OrderBy(p => p.predio_descripcion).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "tributo_descripcion")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvExoneracion.DataSource = Coleccion.OrderBy(p => p.tributo_descripcion).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvExoneracion.DataSource = Coleccion.OrderBy(p => p.tributo_descripcion).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "des_exo_ID")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvExoneracion.DataSource = Coleccion.OrderBy(p => p.des_exo_ID).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvExoneracion.DataSource = Coleccion.OrderBy(p => p.des_exo_ID).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                }

            }
        }
        
        private void Frm_Exoneracion_Load(object sender, EventArgs e)
        {
        }

        private void dgvExoneracion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tooleditar.PerformClick();
        }
        
        private void ActualizarCondicion(int condicion)
        {
            try {
                int id = 0;
                if (dgvExoneracion.SelectedRows.Count > 0)
                {
                    id = (Int32)dgvExoneracion.SelectedRows[0].Cells["des_exo_ID"].Value;
                    pred_Descuentos_ExoneracionDataService.UpdateCondicion(condicion, user, id);
                    this.Dispose();
                    MessageBox.Show("Se actualizó la condición correctamente", Globales.Global_MessageBox);
                }
                else
                {
                    MessageBox.Show("Seleccione un  registro");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(),Globales.Global_MessageBox);
            }
            
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion = pred_Descuentos_ExoneracionDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue), contribuyente_id);
            dgvExoneracion.DataSource = Coleccion;
        }
    }
}
