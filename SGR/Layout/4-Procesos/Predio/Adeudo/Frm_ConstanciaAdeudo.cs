using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Adeudo
{
    public partial class Frm_ConstanciaAdeudo : DockContent
    {

        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_ConstanciaAdeudoDataService ConstanciaAdeudoDataService = new Pred_ConstanciaAdeudoDataService();
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        private Pred_ConstanciaNoDebeDataService ConstanciaNoDebeDataService = new Pred_ConstanciaNoDebeDataService();
        private Mant_ContribuyenteDataService Mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();

        public Frm_ConstanciaAdeudo()
        {
            try
            {
                InitializeComponent();
                cboAño.DisplayMember = "Peric_canio";
                cboAño.ValueMember = "Peric_canio";
                cboAño.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        //private void toolnuevo_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Frm_ConstanciaAdeudoDetalle grm_ConstanciaAdeudoDetalle = new Frm_ConstanciaAdeudoDetalle();
        //        grm_ConstanciaAdeudoDetalle.StartPosition = FormStartPosition.CenterParent;
        //        grm_ConstanciaAdeudoDetalle.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
        //    }

        //}

        //private void tooleditar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Frm_ConstanciaAdeudoDetalle grm_ConstanciaAdeudoDetalle = new Frm_ConstanciaAdeudoDetalle();
        //        grm_ConstanciaAdeudoDetalle.StartPosition = FormStartPosition.CenterParent;
        //        grm_ConstanciaAdeudoDetalle.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
        //    }
        //}

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo = 0;
                if (rbtAlcala.Checked)
                    tipo = 9;
                else if (rbtP.Checked)
                    tipo = 8;
                else tipo = 7;
                dgvConstanciaNoDebe.DataSource = ConstanciaNoDebeDataService.listartodos(txtbusqueda.Text.TrimEnd(), Convert.ToInt32(cboAño.SelectedValue), tipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnListar.PerformClick();
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtbusqueda.Text.Trim().Length > 0)
                {
                    btnListar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void rbtP_CheckedChanged(object sender, EventArgs e)
        {
            btnListar.PerformClick();
        }

        private void rbtAlcala_CheckedChanged(object sender, EventArgs e)
        {
            btnListar.PerformClick();
        }

        private void rbtT_CheckedChanged(object sender, EventArgs e)
        {
            btnListar.PerformClick();
        }

        private void dgvConstanciaNoDebe_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvConstanciaNoDebe.Columns[e.ColumnIndex].Name == "Im" && dgvConstanciaNoDebe.RowCount > 0)
                {
                    CArgraRep("Usuario");
                    //CArgraRep("Notaría");
                    //CArgraRep("Municipalidad");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void CArgraRep(String Pie)
        {

            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            Int32 Cons = (Int32)dgvConstanciaNoDebe.SelectedRows[0].Cells["idConstancia"].Value;
            string Per = (string)dgvConstanciaNoDebe.SelectedRows[0].Cells["IdPersona"].Value;
            Int32 idAlcabala = (Int32)dgvConstanciaNoDebe.SelectedRows[0].Cells["idAlcabala"].Value;
            Pred_ConstanciaNoDebe Pred_ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
            Mant_Per_Cont ant_Per_Cont = new Mant_Per_Cont();
            Mant_Per_Cont conyuge_Per_Cont = new Mant_Per_Cont();
            Mant_Per_Cont rep_Per_Cont = new Mant_Per_Cont();
            ant_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(Per, 31);
            conyuge_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(Per, 32);
            rep_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(Per, 33);
            Pred_ConstanciaNoDebe = ConstanciaNoDebeDataService.getByPrimaryKey(Cons);
            if (idAlcabala == 0)
            { //predial

                Pred_ConstanciaNoDebe = ConstanciaNoDebeDataService.getByPrimaryKey(Cons);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Predial.rdlc";
                ReportParameter[] paramsxf = new ReportParameter[23];
                paramsxf[0] = new ReportParameter("Nombre", ant_Per_Cont.departamento);
                paramsxf[1] = new ReportParameter("Documento", ant_Per_Cont.documento);
                paramsxf[2] = new ReportParameter("DireccionFiscal", ant_Per_Cont.provincia);
                paramsxf[3] = new ReportParameter("NroConstancia", Pred_ConstanciaNoDebe.Transferencia);
                paramsxf[4] = new ReportParameter("CodigoPredial", Pred_ConstanciaNoDebe.idPredio);
                paramsxf[5] = new ReportParameter("DireccionPredio", "");
                paramsxf[6] = new ReportParameter("AreaTotal", "");
                paramsxf[7] = new ReportParameter("FechaMinuta", "");
                paramsxf[8] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsxf[9] = new ReportParameter("Obligacion", Pred_ConstanciaNoDebe.Obligacion);
                paramsxf[10] = new ReportParameter("Descripcion", Pred_ConstanciaNoDebe.Descripcion);
                paramsxf[11] = new ReportParameter("ImpuestoRecibo", Pred_ConstanciaNoDebe.ImpuestoRecibo.ToString());
                paramsxf[12] = new ReportParameter("TramiteRecibo", Pred_ConstanciaNoDebe.TramiteRecibo);
                paramsxf[13] = new ReportParameter("Expediente", Pred_ConstanciaNoDebe.Expediente);
                if (conyuge_Per_Cont == null)
                {

                    //--conyuge_Per_Cont
                    paramsxf[14] = new ReportParameter("NombreCon", "-");
                    paramsxf[15] = new ReportParameter("DocumentoCon", "-");
                    paramsxf[16] = new ReportParameter("DireccionFiscalCon", "-");
                }
                else
                {

                    //--conyuge_Per_Cont
                    paramsxf[14] = new ReportParameter("NombreCon", conyuge_Per_Cont.departamento);
                    paramsxf[15] = new ReportParameter("DocumentoCon", conyuge_Per_Cont.documento);
                    paramsxf[16] = new ReportParameter("DireccionFiscalCon", conyuge_Per_Cont.provincia);
                }
                if (rep_Per_Cont == null)
                {
                    //representante
                    paramsxf[17] = new ReportParameter("NombreRep", "-");
                    paramsxf[18] = new ReportParameter("DocumentoRep", "-");
                    paramsxf[19] = new ReportParameter("DireccionFiscalRep", "-");
                }
                else
                {

                    //representante
                    paramsxf[17] = new ReportParameter("NombreRep", rep_Per_Cont.departamento);
                    paramsxf[18] = new ReportParameter("DocumentoRep", rep_Per_Cont.documento);
                    paramsxf[19] = new ReportParameter("DireccionFiscalRep", rep_Per_Cont.provincia);
                }

                paramsxf[20] = new ReportParameter("Pie", Pie);
                paramsxf[21] = new ReportParameter("Periodo", Pred_ConstanciaNoDebe.idPeriodo.ToString());

                paramsxf[22] = new ReportParameter("CodigoPersona", Per);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsxf);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            else
            {

                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                Certificado_Alcabala = Certificado_AlcabalaDataService.GetByPrimaryKey(Pred_ConstanciaNoDebe.idAlcabala);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Alcabala.rdlc";
                ReportParameter[] paramsx = new ReportParameter[28];

                paramsx[0] = new ReportParameter("Nombre", ant_Per_Cont.departamento);
                paramsx[1] = new ReportParameter("Documento", ant_Per_Cont.documento);
                paramsx[2] = new ReportParameter("DireccionFiscal", ant_Per_Cont.provincia);
                paramsx[3] = new ReportParameter("Valuo", Certificado_Alcabala.valuo.ToString());
                paramsx[4] = new ReportParameter("CompraVenta", Certificado_Alcabala.valor_venta.ToString());
                paramsx[5] = new ReportParameter("Terreno", Certificado_Alcabala.valorTerreno.ToString());
                paramsx[6] = new ReportParameter("UITAlcabala", Certificado_Alcabala.uits.ToString());
                paramsx[7] = new ReportParameter("Saldo", Certificado_Alcabala.valor_afecto.ToString());
                paramsx[8] = new ReportParameter("Impuesto", Certificado_Alcabala.alcabala.ToString());
                paramsx[9] = new ReportParameter("NroConstancia", Pred_ConstanciaNoDebe.Transferencia);
                paramsx[10] = new ReportParameter("CodigoPredial", Pred_ConstanciaNoDebe.idPredio);
                paramsx[11] = new ReportParameter("DireccionPredio", Certificado_Alcabala.direccion_completa);
                paramsx[12] = new ReportParameter("AreaTotal", Certificado_Alcabala.area.ToString());
                paramsx[13] = new ReportParameter("FechaMinuta", Certificado_Alcabala.fecha_tramite.ToString());
                paramsx[14] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsx[15] = new ReportParameter("Obligacion", Pred_ConstanciaNoDebe.Obligacion);
                paramsx[16] = new ReportParameter("Descripcion", Pred_ConstanciaNoDebe.Descripcion);
                paramsx[17] = new ReportParameter("ImpuestoRecibo", Pred_ConstanciaNoDebe.ImpuestoRecibo.ToString());
                paramsx[18] = new ReportParameter("TramiteRecibo", Pred_ConstanciaNoDebe.TramiteRecibo);
                paramsx[19] = new ReportParameter("Expediente", Pred_ConstanciaNoDebe.Expediente);
                if (conyuge_Per_Cont == null)
                {

                    //--conyuge_Per_Cont
                    paramsx[20] = new ReportParameter("NombreCon", "-");
                    paramsx[21] = new ReportParameter("DocumentoCon", "-");
                    paramsx[22] = new ReportParameter("DireccionFiscalCon", "-");
                }
                else
                {
                    //--conyuge_Per_Cont
                    paramsx[20] = new ReportParameter("NombreCon", conyuge_Per_Cont.departamento);
                    paramsx[21] = new ReportParameter("DocumentoCon", conyuge_Per_Cont.documento);
                    paramsx[22] = new ReportParameter("DireccionFiscalCon", conyuge_Per_Cont.provincia);

                }
                if (rep_Per_Cont == null)
                {
                    //representante
                    paramsx[23] = new ReportParameter("NombreRep", "-");
                    paramsx[24] = new ReportParameter("DocumentoRep", "-");
                    paramsx[25] = new ReportParameter("DireccionFiscalRep", "-");
                }
                else
                {

                    //representante
                    paramsx[23] = new ReportParameter("NombreRep", rep_Per_Cont.departamento);
                    paramsx[24] = new ReportParameter("DocumentoRep", rep_Per_Cont.documento);
                    paramsx[25] = new ReportParameter("DireccionFiscalRep", rep_Per_Cont.provincia);

                }

                paramsx[26] = new ReportParameter("Pie", Pie);

                paramsx[27] = new ReportParameter("CodigoPersona", Per);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ConstanciaAdeudoDetalle frm_ConstanciaAdeudoDetalle = new Frm_ConstanciaAdeudoDetalle(obtenerObjeto());
                frm_ConstanciaAdeudoDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_ConstanciaAdeudoDetalle.ShowDialog();
                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Adeudo frm_Adeudo = new Frm_Adeudo();
                frm_Adeudo.StartPosition = FormStartPosition.CenterParent;
                frm_Adeudo.ShowDialog();
                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private Pred_ConstanciaNoDebe obtenerObjeto()
        {
            try
            {
                Pred_ConstanciaNoDebe ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
                ConstanciaNoDebe.idConstancia = (Int32)dgvConstanciaNoDebe.SelectedRows[0].Cells["idConstancia"].Value;
                ConstanciaNoDebe.Descripcion = (string)dgvConstanciaNoDebe.SelectedRows[0].Cells["Descripcion"].Value;
                ConstanciaNoDebe.Obligacion = (string)dgvConstanciaNoDebe.SelectedRows[0].Cells["Obligacion"].Value;
                ConstanciaNoDebe.estado = (bool)dgvConstanciaNoDebe.SelectedRows[0].Cells["estado"].Value;
                ConstanciaNoDebe.Persona = (string)dgvConstanciaNoDebe.SelectedRows[0].Cells["Persona"].Value;
                ConstanciaNoDebe.TramiteRecibo = (string)dgvConstanciaNoDebe.SelectedRows[0].Cells["TramiteRecibo"].Value;
                ConstanciaNoDebe.TramiteImporte = (decimal)dgvConstanciaNoDebe.SelectedRows[0].Cells["TramiteImporte"].Value;
                ConstanciaNoDebe.ImpuestoRecibo = (string)dgvConstanciaNoDebe.SelectedRows[0].Cells["ImpuestoRecibo"].Value;
                ConstanciaNoDebe.ImpuestoImporte = (decimal)dgvConstanciaNoDebe.SelectedRows[0].Cells["ImpuestoImporte"].Value;
                ConstanciaNoDebe.Expediente = (string)dgvConstanciaNoDebe.SelectedRows[0].Cells["Expediente"].Value;
                return ConstanciaNoDebe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
    }
}
