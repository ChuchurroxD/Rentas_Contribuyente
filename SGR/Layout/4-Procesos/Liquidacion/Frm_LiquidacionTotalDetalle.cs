using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model;
using SGR.Entity.Model.Combos;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Liquidacion
{
    public partial class Frm_LiquidacionTotalDetalle : Form
    {
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private MesDataService mess = new MesDataService();
        private Liqu_LiquidacionDataService liquidacionDS = new Liqu_LiquidacionDataService();
        private Liqu_DeudaDetalleMontoDataService deudaDetallesds = new Liqu_DeudaDetalleMontoDataService();
        private List<Mant_Periodo> periodo = new List<Mant_Periodo>();
        private List<Mes> mesese = new List<Mes>();
        private string cod_per;
        string documento, nombres, domicilio;
            decimal totalDeuda, totalDeudaVencida;
        public Frm_LiquidacionTotalDetalle(string persona_ID,string documento,string nombres,string domicilio,
            decimal totalDeuda,decimal totalDeudaVencida)
        {
            InitializeComponent();
            cod_per = persona_ID;
            this.documento = documento;
            this.nombres = nombres;
            this.domicilio = domicilio;
            this.totalDeuda = totalDeuda;
            this.totalDeudaVencida = totalDeudaVencida;
            iniciarElementos();
            
        }
        public void iniciarElementos()
        {
            dataGridView1.DataSource = liquidacionDS.listarTributosAfectos(cod_per);
            List<Int32> parametros = new List<Int32>();
            parametros = liquidacionDS.listarRango(cod_per);
            periodo = periodos.GetAllMant_Periodo();
            cboAnioIni.DisplayMember = "Peric_canio";
            cboAnioIni.ValueMember = "Peric_canio";
            cboAnioIni.DataSource = periodo;

            cboAnioFin.DisplayMember = "Peric_canio";
            cboAnioFin.ValueMember = "Peric_canio";
            cboAnioFin.DataSource = periodo;

            mesese = mess.listartodos();
            cboMesIni.DisplayMember = "mes";
            cboMesIni.ValueMember = "mes_ID";
            cboMesIni.DataSource = mesese;

            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mesese;

            cboAnioIni.SelectedValue = parametros[0];
            cboMesIni.SelectedValue = Convert.ToString(parametros[1]);
            cboAnioFin.SelectedValue = parametros[2];
            cboMesFin.SelectedValue = Convert.ToString(parametros[3]);

            //dataGridView2.DataSource = new List<Liqu_DeudaDetalleTributo>();
            habilitarTributos();
            cargarDeuda();

            
            dataGridView3.DataSource = liquidacionDS.listartodos(cod_per);
            //dataGridView2.DataSource = new List<Liqu_DeudaDetalleTributo>();
            
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        public void cargarDeuda()
        {
            int cantidad;
            decimal total = 0;
            cantidad = dataGridView1.RowCount;
            List<Liqu_DeudaDetalleTributo> Coleccion = new List<Liqu_DeudaDetalleTributo>();
            for (int i = 0; i < cantidad; i++)
            {
                DataGridViewRow row1 = dataGridView1.Rows[i];
                DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadot"] as DataGridViewCheckBoxCell;
                bool disponible = false;
                disponible = Convert.ToBoolean(cellSelecion1.Value);
                string tributos = "";
                if (disponible)
                    tributos = tributos + "-" + (String)dataGridView1.Rows[i].Cells["xtributo_ID"].Value;
                Coleccion.AddRange(deudaDetallesds.listartodos3(cod_per, "0", tributos, Convert.ToInt32(cboAnioIni.SelectedValue),
                   Convert.ToInt32(cboAnioFin.SelectedValue), Convert.ToInt32(cboMesIni.SelectedValue),
                   Convert.ToInt32(cboMesFin.SelectedValue)));
            }
            dataGridView2.DataSource = Coleccion;
            int cantidad2;
            cantidad2 = dataGridView2.RowCount;
            for (int i = 0; i < cantidad2; i++)
            {
                total = total + (decimal)dataGridView2.Rows[i].Cells["xtot2"].Value;
            }
            txtTotal.Text = Convert.ToString(total);
        }
        private void RecargarComboPeriodo(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = periodo.Count;
            List<Mant_Periodo> periodo2 = new List<Mant_Periodo>();

            for (int i = 0; i < cantidad; i++)
            {
                if (Convert.ToInt32(periodo[i].Peric_canio) >= Convert.ToInt32(cboAnioIni.SelectedValue))
                {
                    Mant_Periodo peri = new Mant_Periodo();
                    peri.Peric_canio = periodo[i].Peric_canio;
                    periodo2.Add(peri);
                }
            }
            cboAnioFin.DisplayMember = "Peric_canio";
            cboAnioFin.ValueMember = "Peric_canio";
            cboAnioFin.DataSource = periodo2;
            cargarDeuda();
        }
        private void RecargarComboMes(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = mesese.Count;
            List<Mes> mes2 = new List<Mes>();
            if (Convert.ToInt32(cboAnioIni.SelectedValue) == Convert.ToInt32(cboAnioFin.SelectedValue))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(mesese[i].mes_ID) >= Convert.ToInt32(cboMesIni.SelectedValue))
                    {
                        Mes messssss = new Mes();
                        messssss.mes_ID = mesese[i].mes_ID;
                        messssss.mes = mesese[i].mes;
                        mes2.Add(messssss);
                    }
                }
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                        Mes messssss = new Mes();
                        messssss.mes_ID = mesese[i].mes_ID;
                        messssss.mes = mesese[i].mes;
                        mes2.Add(messssss);
                }
            }
            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mes2;
            cargarDeuda();
        }
        private void RecargarComboMes2(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = mesese.Count;
            List<Mes> mes2 = new List<Mes>();
            if (Convert.ToInt32(cboAnioIni.SelectedValue) == Convert.ToInt32(cboAnioFin.SelectedValue))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(mesese[i].mes_ID) >= Convert.ToInt32(cboMesIni.SelectedValue))
                    {
                        Mes messssss = new Mes();
                        messssss.mes_ID = mesese[i].mes_ID;
                        messssss.mes = mesese[i].mes;
                        mes2.Add(messssss);
                    }
                }
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Mes messssss = new Mes();
                    messssss.mes_ID = mesese[i].mes_ID;
                    messssss.mes = mesese[i].mes;
                    mes2.Add(messssss);
                }
            }
            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mes2;
            cargarDeuda();
        }
        public void inhabilitarTributos()
        {
            int cantidad;
            cantidad = dataGridView1.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                DataGridViewRow row1 = dataGridView1.Rows[i];
                DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadot"] as DataGridViewCheckBoxCell;
                //              bool disponible = false; //(bool)dataGridView1.Rows[i].Cells["xestado"].Value;
                //                disponible = Convert.ToBoolean(cellSelecion1.Value);
                cellSelecion1.Value = false;
            }
        }
        public void habilitarTributos()
        {
            int cantidad;
            cantidad = dataGridView1.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                DataGridViewRow row1 = dataGridView1.Rows[i];
                DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadot"] as DataGridViewCheckBoxCell;
                cellSelecion1.Value = true;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                habilitarTributos();
                cargarDeuda();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                inhabilitarTributos();
                cargarDeuda();
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cantidad;
            decimal total=0;
            cantidad = dataGridView1.RowCount;
            List<Liqu_DeudaDetalleTributo> Coleccion= new List<Liqu_DeudaDetalleTributo>();
            for (int i = 0; i < cantidad; i++)
            {                
                DataGridViewRow row1 = dataGridView1.Rows[i];
                DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadot"] as DataGridViewCheckBoxCell;
                bool disponible = false;
                disponible = Convert.ToBoolean(cellSelecion1.Value);
                string tributos = "";
                if (disponible)
                {
                    tributos = tributos + "-" + (String)dataGridView1.Rows[i].Cells["xtributo_ID"].Value;
                    Coleccion.AddRange(deudaDetallesds.listartodos3(cod_per, "0", tributos, Convert.ToInt32(cboAnioIni.SelectedValue),
                       Convert.ToInt32(cboAnioFin.SelectedValue), Convert.ToInt32(cboMesIni.SelectedValue),
                       Convert.ToInt32(cboMesFin.SelectedValue)));
                }
            }
            dataGridView2.DataSource = Coleccion;
            int cantidad2;
            cantidad2 = dataGridView2.RowCount;
            for (int i = 0; i < cantidad2; i++)
            {
                total = total + (decimal)dataGridView2.Rows[i].Cells["xtot2"].Value;               
            }
            txtTotal.Text = Convert.ToString(total);            
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;           
                if (MessageBox.Show("Confirmar Liquidación de Deuda?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        if (dataGridView2.RowCount > 0)
                    {
                        Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                        Liqu_Liquidacion resultado = new Liqu_Liquidacion();
                        string tributooo, tipo_ini, persona_ID, tributo_ID, predio_ID;
                        elemento.estado = "P";
                        elemento.Intereses = 0;
                        elemento.importe = 0;
                        elemento.Persona_id = cod_per;
                        elemento.registro_user_add = GlobalesV1.Global_str_Usuario;
                        tributooo = (string)dataGridView2.Rows[0].Cells["xtributos_ID"].Value;
                        resultado = liquidacionDS.Insert2(elemento, tributooo);
                        tipo_ini = resultado.tipo;
                        //MessageBox.Show(resultado.tipo + "--" + Convert.ToString(resultado.liquidacion_id));
                        if (resultado.liquidacion_id != 0)
                        {
                            int cantidad2;
                            cantidad2 = dataGridView2.RowCount;
                            int anio;
                            decimal ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic;
                            for (int i = 0; i < cantidad2; i++)
                            {
                                anio = (Int32)dataGridView2.Rows[i].Cells["xanio2"].Value;
                                persona_ID = (string)dataGridView2.Rows[i].Cells["xpersona_ID2"].Value;
                                predio_ID = (string)dataGridView2.Rows[i].Cells["xpredio_ID2"].Value;
                                tributo_ID = (string)dataGridView2.Rows[i].Cells["xtributos_ID"].Value;
                                ene = (decimal)dataGridView2.Rows[i].Cells["xene2"].Value;
                                if (ene > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 1, anio, ene);
                                feb = (decimal)dataGridView2.Rows[i].Cells["xfeb2"].Value;
                                if (feb > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 2, anio, feb);
                                mar = (decimal)dataGridView2.Rows[i].Cells["xmar2"].Value;
                                if (mar > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 3, anio, mar);
                                abr = (decimal)dataGridView2.Rows[i].Cells["xabr2"].Value;
                                if (abr > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 4, anio, abr);
                                may = (decimal)dataGridView2.Rows[i].Cells["xmay2"].Value;
                                if (may > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 5, anio, may);
                                jun = (decimal)dataGridView2.Rows[i].Cells["xjun2"].Value;
                                if (jun > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 6, anio, jun);
                                jul = (decimal)dataGridView2.Rows[i].Cells["xjul2"].Value;
                                if (jul > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 7, anio, jul);
                                ago = (decimal)dataGridView2.Rows[i].Cells["xago2"].Value;
                                if (ago > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 8, anio, ago);
                                sep = (decimal)dataGridView2.Rows[i].Cells["xsep2"].Value;
                                if (sep > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 9, anio, sep);
                                oct = (decimal)dataGridView2.Rows[i].Cells["xoct2"].Value;
                                if (oct > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 10, anio, oct);
                                nov = (decimal)dataGridView2.Rows[i].Cells["xnov2"].Value;
                                if (nov > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 11, anio, nov);
                                dic = (decimal)dataGridView2.Rows[i].Cells["xdic2"].Value;
                                if (dic > 0)
                                    liquidacionDS.InsertDetalle2(resultado.liquidacion_id, persona_ID, predio_ID, tributo_ID, 12, anio, dic);
                            }               
                                         
                            liquidacionDS.modificarEstadoFinal(resultado.liquidacion_id);
                            dataGridView3.DataSource = liquidacionDS.listartodos(cod_per);
                            MessageBox.Show("Liquidación Generada Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show("No especifico deuda a liquidar", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
           
        }

        private void cboMesFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDeuda();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xestadot")
                cargarDeuda();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView2.DataSource = new List<Liqu_DeudaDetalleTributo>();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dataGridView3.Columns[e.ColumnIndex].Name == "xanular")
            {
                if (MessageBox.Show("Desea Anular el registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                        int liquidacion_ID = (Int32)dataGridView3.Rows[e.RowIndex].Cells["xliquidacion"].Value;
                        if (liquidacionDS.eliminarLiquidacion(liquidacion_ID))
                            MessageBox.Show("Se Anulo Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error al Anular", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView3.DataSource = liquidacionDS.listartodos(cod_per);                    
                }                
            }
            if (dataGridView3.Columns[e.ColumnIndex].Name == "ximprimir")
            {
                //if (Cursor.Current == Cursors.WaitCursor)
                //    return;
                //Cursor.Current = Cursors.WaitCursor;
                var coleccion = new List<Liqu_Deuda>();
                int liquidacion_ID = (Int32)dataGridView3.Rows[e.RowIndex].Cells["xliquidacion"].Value;
                coleccion = liquidacionDS.mostrarLiquidacion(liquidacion_ID);
                decimal total = 0, interes = 0;
                for (int i = 0; i < coleccion.Count; i++)
                {
                    total = total + coleccion[i].monto;
                    interes = interes + coleccion[i].interes;
                }
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Liquidacion.rptLiquidacionDetalle.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[14];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                param[2] = new ReportParameter("Codigo", cod_per);
                param[3] = new ReportParameter("DNI", documento);
                param[4] = new ReportParameter("Nombres", nombres);
                param[5] = new ReportParameter("TipoEm", "PRED+ARBITR");
                param[6] = new ReportParameter("Domicilio", domicilio);
                param[7] = new ReportParameter("Predio", "Todos");
                param[8] = new ReportParameter("Ubicacion", " ");
                param[9] = new ReportParameter("total", Convert.ToString(total));
                param[10] = new ReportParameter("TotalIntereses", Convert.ToString(interes));
                param[11] = new ReportParameter("TotalLiquidar", Convert.ToString(interes + total));
                param[12] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                param[13] = new ReportParameter("liquidacion_ID", Convert.ToString(liquidacion_ID));

                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                int cantidad;
                decimal monto = 0;
                cantidad = dataGridView1.RowCount;
                List<Liqu_Deuda> Coleccion = new List<Liqu_Deuda>();
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row1 = dataGridView1.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadot"] as DataGridViewCheckBoxCell;
                    bool disponible = false;
                    disponible = Convert.ToBoolean(cellSelecion1.Value);
                    string tributos = "";
                    if (disponible)
                    {
                        tributos = tributos + "-" + (String)dataGridView1.Rows[i].Cells["xtributo_ID"].Value;
                        Coleccion.AddRange(liquidacionDS.verificarLiquidacio3(cod_per, "0", tributos, Convert.ToInt32(cboAnioIni.SelectedValue),
                           Convert.ToInt32(cboAnioFin.SelectedValue), Convert.ToInt32(cboMesIni.SelectedValue),
                           Convert.ToInt32(cboMesFin.SelectedValue)));
                    }
                }
                for (int i = 0; i < Coleccion.Count; i++)
                    monto = monto + Coleccion[i].total;
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Liquidacion.rptLiquidacionVerificacion.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] param = new ReportParameter[13];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                param[2] = new ReportParameter("Codigo", cod_per);
                param[3] = new ReportParameter("DNI", documento);
                param[4] = new ReportParameter("Nombres", nombres);
                param[5] = new ReportParameter("Domicilio", domicilio);
                param[6] = new ReportParameter("TipoEm", "PRED+ARBITR");
                param[7] = new ReportParameter("Predio", "Todos");
                param[8] = new ReportParameter("Ubicacion", " ");
                param[9] = new ReportParameter("TotalDeudaAnual", Convert.ToString(totalDeuda));
                param[10] = new ReportParameter("DeudaVencida", Convert.ToString(totalDeudaVencida));
                param[11] = new ReportParameter("DeudaConsultada", Convert.ToString(monto));
                param[12] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch(Exception ex)
            {

            }          
        }
    }
}
