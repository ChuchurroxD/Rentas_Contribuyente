using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Core;
using SGR.Entity;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Drawing;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Compensación
{
    public partial class Frm_Compensacion_Detalle : Form
    {
        Liqu_DeudaDetalleMontoDataService deudaMontoDetalle = new Liqu_DeudaDetalleMontoDataService();
        //Liqu_LiquidacionDataService liquidacion_opera = new Liqu_LiquidacionDataService();
        Liqu_CompensacionDataService liqu_CompensacionDataService = new Liqu_CompensacionDataService();

        string predio, persona, tributo_id;
        decimal restante = 0;
        decimal montoResultante = 0;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                int cantidad;
                decimal montoPagar;
                montoResultante = 0;
                decimal ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic;
                montoPagar = Convert.ToDecimal(txtPagoMonto.Text);
                if (montoPagar > 0)
                {
                    cantidad = dgPositivos.RowCount;
                    for (int i = 0; i < cantidad; i++)
                    {
                        DataGridViewRow row1 = dgPositivos.Rows[i];
                        DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestado"] as DataGridViewCheckBoxCell;
                        bool disponible = false;
                        disponible = Convert.ToBoolean(cellSelecion1.Value);
                        if (disponible)
                        {
                            ene = (decimal)dgPositivos.Rows[i].Cells["xene"].Value;
                            if (montoPagar > 0 && ene > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xene"] as DataGridViewTextBoxCell;
                                if (montoPagar >= ene)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - ene;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            feb = (decimal)dgPositivos.Rows[i].Cells["xfeb"].Value;
                            if (montoPagar > 0 && feb > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xfeb"] as DataGridViewTextBoxCell;
                                if (montoPagar >= feb)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - feb;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            mar = (decimal)dgPositivos.Rows[i].Cells["xmar"].Value;
                            if (montoPagar > 0 && mar > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xmar"] as DataGridViewTextBoxCell;
                                if (montoPagar >= mar)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - mar;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            abr = (decimal)dgPositivos.Rows[i].Cells["xabr"].Value;
                            if (montoPagar > 0 && abr > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xabr"] as DataGridViewTextBoxCell;
                                if (montoPagar >= abr)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - abr;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            may = (decimal)dgPositivos.Rows[i].Cells["xmay"].Value;
                            if (montoPagar > 0 && may > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xmay"] as DataGridViewTextBoxCell;
                                if (montoPagar >= may)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - may;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            jun = (decimal)dgPositivos.Rows[i].Cells["xjun"].Value;
                            if (montoPagar > 0 && jun > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xjun"] as DataGridViewTextBoxCell;
                                if (montoPagar >= jun)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - jun;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            jul = (decimal)dgPositivos.Rows[i].Cells["xjul"].Value;
                            if (montoPagar > 0 && jul > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xjul"] as DataGridViewTextBoxCell;
                                if (montoPagar >= jul)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - jul;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            ago = (decimal)dgPositivos.Rows[i].Cells["xago"].Value;
                            if (montoPagar > 0 && ago > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xago"] as DataGridViewTextBoxCell;
                                if (montoPagar >= ago)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - ago;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            sep = (decimal)dgPositivos.Rows[i].Cells["xsep"].Value;
                            if (montoPagar > 0 && sep > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xsep"] as DataGridViewTextBoxCell;
                                if (montoPagar >= sep)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - sep;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            oct = (decimal)dgPositivos.Rows[i].Cells["xoct"].Value;
                            if (montoPagar > 0 && oct > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xoct"] as DataGridViewTextBoxCell;
                                if (montoPagar >= oct)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - oct;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            nov = (decimal)dgPositivos.Rows[i].Cells["xnov"].Value;
                            if (montoPagar > 0 && nov > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xnov"] as DataGridViewTextBoxCell;
                                if (montoPagar >= nov)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - nov;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                            dic = (decimal)dgPositivos.Rows[i].Cells["xdic"].Value;
                            if (montoPagar > 0 && dic > 0)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xdic"] as DataGridViewTextBoxCell;
                                if (montoPagar >= dic)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagar = montoPagar - dic;
                                }
                                else
                                {
                                    restante = montoPagar;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagar = 0;
                                }
                            }
                        }
                    }
                    if (montoPagar > 0)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgPositivos.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestado"] as DataGridViewCheckBoxCell;
                            bool disponible = false;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (!disponible)
                            {
                                if (montoPagar > 0)
                                    cellSelecion1.Value = true;
                                ene = (decimal)dgPositivos.Rows[i].Cells["xene"].Value;
                                if (montoPagar > 0 && ene > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xene"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= ene)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - ene;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                feb = (decimal)dgPositivos.Rows[i].Cells["xfeb"].Value;
                                if (montoPagar > 0 && feb > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xfeb"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= feb)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - feb;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                mar = (decimal)dgPositivos.Rows[i].Cells["xmar"].Value;
                                if (montoPagar > 0 && mar > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xmar"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= mar)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - mar;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                abr = (decimal)dgPositivos.Rows[i].Cells["xabr"].Value;
                                if (montoPagar > 0 && abr > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xabr"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= abr)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - abr;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                may = (decimal)dgPositivos.Rows[i].Cells["xmay"].Value;
                                if (montoPagar > 0 && may > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xmay"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= may)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - may;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                jun = (decimal)dgPositivos.Rows[i].Cells["xjun"].Value;
                                if (montoPagar > 0 && jun > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xjun"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= jun)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - jun;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                jul = (decimal)dgPositivos.Rows[i].Cells["xjul"].Value;
                                if (montoPagar > 0 && jul > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xjul"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= jul)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - jul;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                ago = (decimal)dgPositivos.Rows[i].Cells["xago"].Value;
                                if (montoPagar > 0 && ago > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xago"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= ago)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - ago;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                sep = (decimal)dgPositivos.Rows[i].Cells["xsep"].Value;
                                if (montoPagar > 0 && sep > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xsep"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= sep)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - sep;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                oct = (decimal)dgPositivos.Rows[i].Cells["xoct"].Value;
                                if (montoPagar > 0 && oct > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xoct"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= oct)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - oct;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                nov = (decimal)dgPositivos.Rows[i].Cells["xnov"].Value;
                                if (montoPagar > 0 && nov > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xnov"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= nov)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - nov;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                                dic = (decimal)dgPositivos.Rows[i].Cells["xdic"].Value;
                                if (montoPagar > 0 && dic > 0)
                                {
                                    DataGridViewRow row = dgPositivos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xdic"] as DataGridViewTextBoxCell;
                                    if (montoPagar >= dic)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagar = montoPagar - dic;
                                    }
                                    else
                                    {
                                        restante = montoPagar;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagar = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("El monto a liquidar debe ser mayor de 0", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (montoPagar > 0)
                {
                    lblMensajes.Text = "Luego de cubrir los pagos requeridos le restan: S/. " + Convert.ToString(montoPagar);
                    //aca generar negativo
                }
                else
                {
                    lblMensajes.Text = "";
                }
                montoResultante = montoPagar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            if (txtExpediente.Text.Trim().Length <= 0)
                throw new Exception("Debe ingresar un expediente");
            if (rchtObservación.Text.Trim().Length <= 0)
                throw new Exception("Debe ingresar una observación.");

            try
            {
                if (MessageBox.Show("Confirmar Compensación de Deuda?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    Liqu_Compensacion liqu_Compensacion = new Liqu_Compensacion();
                    liqu_Compensacion.persona_id = persona;
                    liqu_Compensacion.predio_ID = predio;

                    //if (tributo_id.CompareTo("1") == 1)
                    //{
                    //    tributos_id = "0008";
                    //}
                    //if (tributo_id.CompareTo("2") == 1)
                    //{
                    //    tributos_id = "0043";
                    //}
                    liqu_Compensacion.tributos_id = tributo_id;
                    liqu_Compensacion.registro_user_add = GlobalesV1.Global_str_Usuario;
                    liqu_Compensacion.expediente = txtExpediente.Text.Trim();
                    liqu_Compensacion.observacion = rchtObservación.Text.Trim();

                    int resultado = liqu_CompensacionDataService.Insert(liqu_Compensacion);//liquidacion_opera.Insert(elemento);

                    if (resultado != 0)
                    {
                        int cantidad;
                        decimal montoPagar;
                        montoPagar = Convert.ToDecimal(txtPagoMonto.Text);
                        cantidad = dgPositivos.RowCount;

                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgPositivos.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestado"] as DataGridViewCheckBoxCell;
                            bool disponible = false; //(bool)dataGridView1.Rows[i].Cells["xestado"].Value;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (disponible)
                            {
                                DataGridViewRow row = dgPositivos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xene"] as DataGridViewTextBoxCell;
                                
                                int anio = (int)dgPositivos.Rows[i].Cells["xanio"].Value;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), predio);
                                //liquidacion_opera.InsertDetalle3(resultado, persona, predio, 1, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), montoPagar, predio);

                                    cellSelecion = row.Cells["xfeb"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(2), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(2), montoPagar, predio);

                                cellSelecion = row.Cells["xmar"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(3), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(3), montoPagar, predio);

                                cellSelecion = row.Cells["xabr"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(4), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), montoPagar, predio);

                                cellSelecion = row.Cells["xmay"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(5), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(5), montoPagar, predio);

                                cellSelecion = row.Cells["xjun"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(6), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(6), montoPagar, predio);

                                cellSelecion = row.Cells["xjul"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(7), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(7), montoPagar, predio);

                                cellSelecion = row.Cells["xago"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(8), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(8), montoPagar, predio);

                                cellSelecion = row.Cells["xsep"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(9), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(9), montoPagar, predio);

                                cellSelecion = row.Cells["xoct"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(10), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(10), montoPagar, predio);

                                cellSelecion = row.Cells["xnov"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(11), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(11), montoPagar, predio);

                                cellSelecion = row.Cells["xdic"] as DataGridViewTextBoxCell;
                                    if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(12), predio);
                                else
                                        if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(12), montoPagar, predio);

                            }
                        }
                        MessageBox.Show("Compensacion correctamente registrada", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(montoResultante > 0)
                        {
                            liqu_CompensacionDataService.insertarCompensacionFaltante(liqu_Compensacion, montoResultante);
                        }
                        this.Close();
                    }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarNegativos();
                int cantidad;
                decimal montoPagarN;
                montoResultante = 0;
                decimal ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic;
                montoPagarN = Convert.ToDecimal(txtPagoMontoN.Text);
                if (montoPagarN > 0)
                {
                    cantidad = dgNegativos.RowCount;
                    for (int i = 0; i < cantidad; i++)
                    {
                        DataGridViewRow row1 = dgNegativos.Rows[i];
                        DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadoN"] as DataGridViewCheckBoxCell;
                        bool disponible = false;
                        disponible = Convert.ToBoolean(cellSelecion1.Value);
                        if (disponible)
                        {
                            ene = (decimal)dgNegativos.Rows[i].Cells["xeneN"].Value;
                            if (montoPagarN > 0 && ene > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xeneN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= ene)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - ene;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            feb = (decimal)dgNegativos.Rows[i].Cells["xfebN"].Value;
                            if (montoPagarN > 0 && feb > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xfebN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= feb)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - feb;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            mar = (decimal)dgNegativos.Rows[i].Cells["xmarN"].Value;
                            if (montoPagarN > 0 && mar > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xmarN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= mar)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - mar;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            abr = (decimal)dgNegativos.Rows[i].Cells["xabrN"].Value;
                            if (montoPagarN > 0 && abr > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xabrN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= abr)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - abr;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            may = (decimal)dgNegativos.Rows[i].Cells["xmayN"].Value;
                            if (montoPagarN > 0 && may > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xmayN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= may)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - may;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            jun = (decimal)dgNegativos.Rows[i].Cells["xjunN"].Value;
                            if (montoPagarN > 0 && jun > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xjunN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= jun)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - jun;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            jul = (decimal)dgNegativos.Rows[i].Cells["xjulN"].Value;
                            if (montoPagarN > 0 && jul > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xjulN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= jul)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - jul;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            ago = (decimal)dgNegativos.Rows[i].Cells["xagoN"].Value;
                            if (montoPagarN > 0 && ago > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xagoN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= ago)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - ago;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            sep = (decimal)dgNegativos.Rows[i].Cells["xsepN"].Value;
                            if (montoPagarN > 0 && sep > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xsepN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= sep)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - sep;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            oct = (decimal)dgNegativos.Rows[i].Cells["xoctN"].Value;
                            if (montoPagarN > 0 && oct > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xoctN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= oct)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - oct;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            nov = (decimal)dgNegativos.Rows[i].Cells["xnovN"].Value;
                            if (montoPagarN > 0 && nov > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xnovN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= nov)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - nov;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                            dic = (decimal)dgNegativos.Rows[i].Cells["xdicN"].Value;
                            if (montoPagarN > 0 && dic > 0)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xdicN"] as DataGridViewTextBoxCell;
                                if (montoPagarN >= dic)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarN = montoPagarN - dic;
                                }
                                else
                                {
                                    restante = montoPagarN;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarN = 0;
                                }
                            }
                        }
                    }
                    if (montoPagarN > 0)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgNegativos.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadoN"] as DataGridViewCheckBoxCell;
                            bool disponible = false;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (!disponible)
                            {
                                if (montoPagarN > 0)
                                    cellSelecion1.Value = true;
                                ene = (decimal)dgNegativos.Rows[i].Cells["xeneN"].Value;
                                if (montoPagarN > 0 && ene > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xeneN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= ene)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - ene;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                feb = (decimal)dgNegativos.Rows[i].Cells["xfebN"].Value;
                                if (montoPagarN > 0 && feb > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xfebN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= feb)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - feb;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                mar = (decimal)dgNegativos.Rows[i].Cells["xmarN"].Value;
                                if (montoPagarN > 0 && mar > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xmarN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= mar)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - mar;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                abr = (decimal)dgNegativos.Rows[i].Cells["xabrN"].Value;
                                if (montoPagarN > 0 && abr > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xabrN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= abr)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - abr;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                may = (decimal)dgNegativos.Rows[i].Cells["xmayN"].Value;
                                if (montoPagarN > 0 && may > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xmayN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= may)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - may;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                jun = (decimal)dgNegativos.Rows[i].Cells["xjunN"].Value;
                                if (montoPagarN > 0 && jun > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xjunN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= jun)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - jun;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                jul = (decimal)dgNegativos.Rows[i].Cells["xjulN"].Value;
                                if (montoPagarN > 0 && jul > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xjulN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= jul)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - jul;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                ago = (decimal)dgNegativos.Rows[i].Cells["xagoN"].Value;
                                if (montoPagarN > 0 && ago > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xagoN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= ago)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - ago;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                sep = (decimal)dgNegativos.Rows[i].Cells["xsepN"].Value;
                                if (montoPagarN > 0 && sep > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xsepN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= sep)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - sep;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                oct = (decimal)dgNegativos.Rows[i].Cells["xoctN"].Value;
                                if (montoPagarN > 0 && oct > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xoctN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= oct)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - oct;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                nov = (decimal)dgNegativos.Rows[i].Cells["xnovN"].Value;
                                if (montoPagarN > 0 && nov > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xnovN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= nov)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - nov;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                                dic = (decimal)dgNegativos.Rows[i].Cells["xdicN"].Value;
                                if (montoPagarN > 0 && dic > 0)
                                {
                                    DataGridViewRow row = dgNegativos.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["xdicN"] as DataGridViewTextBoxCell;
                                    if (montoPagarN >= dic)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarN = montoPagarN - dic;
                                    }
                                    else
                                    {
                                        restante = montoPagarN;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarN = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("El monto a compensar debe ser mayor de 0", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (montoPagarN > 0)
                {
                    lblMensajesN.Text = "Luego de cubrir los pagos requeridos le restan: S/. " + Convert.ToString(montoPagarN);
                }
                else
                {
                    lblMensajesN.Text = "";
                }
                montoResultante = montoPagarN;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular");
            }
        }

        public Frm_Compensacion_Detalle(string persona_ID, string predio_ID, string grupo_trib, string nombres, string documento, string persona, string direccCompleta)
        {
            InitializeComponent();
            this.predio = predio_ID;
            this.persona = persona_ID;
            this.tributo_id = grupo_trib;
            lblCodigo.Text = persona;
            lblDireccion.Text = direccCompleta;
            lblNombre.Text = nombres;
            lblDocumento.Text = documento;
            //dataGridView1.DataSource = deudaMontoDetalle.listartodos(persona_ID, predio, grupo_trib);
            dgPositivos.DataSource = liqu_CompensacionDataService.listarDetallePositivos(persona_ID, predio, tributo_id);
            dgNegativos.DataSource = liqu_CompensacionDataService.listarDetallePositivos(persona_ID, predio, tributo_id);
            dgFaltantes.DataSource = liqu_CompensacionDataService.listarDetallePositivos(persona_ID, predio, tributo_id);
            txtPagoMontoN.Text = liqu_CompensacionDataService.montoCompensar(persona_ID, predio, tributo_id).ToString();
            txtPagoMontoN.Enabled = false;
            txtPagoMontoF.Text = liqu_CompensacionDataService.montoFaltante(persona_ID, predio, tributo_id).ToString();
            txtPagoMontoF.Enabled = false;
        }

        private void lnkCompensarNegativos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            if (txtExpediente.Text.Trim().Length <= 0)
                throw new Exception("Debe ingresar un expediente");
            if (rchtObservación.Text.Trim().Length <= 0)
                throw new Exception("Debe ingresar una observación.");

            try
            {
                if (MessageBox.Show("Confirmar Compensación de Deuda?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    Liqu_Compensacion liqu_Compensacion = new Liqu_Compensacion();
                    liqu_Compensacion.persona_id = persona;
                    liqu_Compensacion.tributos_id = tributo_id;
                    liqu_Compensacion.registro_user_add = GlobalesV1.Global_str_Usuario;
                    liqu_Compensacion.expediente = txtExpediente.Text.Trim();
                    liqu_Compensacion.observacion = rchtObservación.Text.Trim();

                    int resultado = liqu_CompensacionDataService.Insert(liqu_Compensacion);//liquidacion_opera.Insert(elemento);

                    if (resultado != 0)
                    {
                        int cantidad;
                        decimal montoPagar;
                        montoPagar = Convert.ToDecimal(txtPagoMontoN.Text);
                        cantidad = dgNegativos.RowCount;

                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgNegativos.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadoN"] as DataGridViewCheckBoxCell;
                            bool disponible = false; //(bool)dataGridView1.Rows[i].Cells["xestado"].Value;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (disponible)
                            {
                                DataGridViewRow row = dgNegativos.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xeneN"] as DataGridViewTextBoxCell;

                                int anio = (int)dgNegativos.Rows[i].Cells["xanioN"].Value;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), predio);
                                //liquidacion_opera.InsertDetalle3(resultado, persona, predio, 1, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), montoPagar, predio);

                                cellSelecion = row.Cells["xfebN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(2), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(2), montoPagar, predio);

                                cellSelecion = row.Cells["xmarN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(3), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(3), montoPagar, predio);

                                cellSelecion = row.Cells["xabrN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(4), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), montoPagar, predio);

                                cellSelecion = row.Cells["xmayN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(5), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(5), montoPagar, predio);

                                cellSelecion = row.Cells["xjunN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(6), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(6), montoPagar, predio);

                                cellSelecion = row.Cells["xjulN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(7), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(7), montoPagar, predio);

                                cellSelecion = row.Cells["xagoN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(8), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(8), montoPagar, predio);

                                cellSelecion = row.Cells["xsepN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(9), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(9), montoPagar, predio);

                                cellSelecion = row.Cells["xoctN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(10), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(10), montoPagar, predio);

                                cellSelecion = row.Cells["xnovN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(11), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(11), montoPagar, predio);

                                cellSelecion = row.Cells["xdicN"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(12), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(12), montoPagar, predio);

                            }
                        }
                        liqu_CompensacionDataService.compensarNegativos(persona, tributo_id, predio, montoPagar, montoResultante);
                        MessageBox.Show("Compensacion correctamente registrada", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }                    
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

        public void limpiar()
        {

            for (int i = 0; i < dgPositivos.RowCount; i++)
            {
                DataGridViewRow row = dgPositivos.Rows[i];
                DataGridViewTextBoxCell cellSelecion = row.Cells["xene"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xfeb"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xmar"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xabr"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xmay"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xjun"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xjul"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xago"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xsep"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xoct"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xnov"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xdic"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
            }
        }

        private void btnCalcularF_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarFaltantes();
                int cantidad;
                decimal montoPagarF;
                montoResultante = 0;
                decimal ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic;
                montoPagarF = Convert.ToDecimal(txtPagoMontoF.Text);
                if (montoPagarF > 0)
                {
                    cantidad = dgFaltantes.RowCount;
                    for (int i = 0; i < cantidad; i++)
                    {
                        DataGridViewRow row1 = dgFaltantes.Rows[i];
                        DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["estadoF"] as DataGridViewCheckBoxCell;
                        bool disponible = false;
                        disponible = Convert.ToBoolean(cellSelecion1.Value);
                        if (disponible)
                        {
                            ene = (decimal)dgFaltantes.Rows[i].Cells["eneF"].Value;
                            if (montoPagarF > 0 && ene > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["eneF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= ene)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - ene;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            feb = (decimal)dgFaltantes.Rows[i].Cells["febF"].Value;
                            if (montoPagarF > 0 && feb > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["febF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= feb)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - feb;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            mar = (decimal)dgFaltantes.Rows[i].Cells["marF"].Value;
                            if (montoPagarF > 0 && mar > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["marF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= mar)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - mar;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            abr = (decimal)dgFaltantes.Rows[i].Cells["abrF"].Value;
                            if (montoPagarF > 0 && abr > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["abrF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= abr)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - abr;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            may = (decimal)dgFaltantes.Rows[i].Cells["mayF"].Value;
                            if (montoPagarF > 0 && may > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["mayF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= may)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - may;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            jun = (decimal)dgFaltantes.Rows[i].Cells["junF"].Value;
                            if (montoPagarF > 0 && jun > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["junF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= jun)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - jun;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            jul = (decimal)dgFaltantes.Rows[i].Cells["julF"].Value;
                            if (montoPagarF > 0 && jul > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["julF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= jul)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - jul;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            ago = (decimal)dgFaltantes.Rows[i].Cells["agoF"].Value;
                            if (montoPagarF > 0 && ago > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["agoF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= ago)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - ago;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            sep = (decimal)dgFaltantes.Rows[i].Cells["sepF"].Value;
                            if (montoPagarF > 0 && sep > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["sepF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= sep)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - sep;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            oct = (decimal)dgFaltantes.Rows[i].Cells["octF"].Value;
                            if (montoPagarF > 0 && oct > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["octF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= oct)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - oct;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            nov = (decimal)dgFaltantes.Rows[i].Cells["novF"].Value;
                            if (montoPagarF > 0 && nov > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["novF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= nov)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - nov;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                            dic = (decimal)dgFaltantes.Rows[i].Cells["dicF"].Value;
                            if (montoPagarF > 0 && dic > 0)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["dicF"] as DataGridViewTextBoxCell;
                                if (montoPagarF >= dic)
                                {
                                    cellSelecion.Style.BackColor = Color.Green;
                                    montoPagarF = montoPagarF - dic;
                                }
                                else
                                {
                                    restante = montoPagarF;
                                    cellSelecion.Style.BackColor = Color.Yellow;
                                    montoPagarF = 0;
                                }
                            }
                        }
                    }
                    if (montoPagarF > 0)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgFaltantes.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["estadoF"] as DataGridViewCheckBoxCell;
                            bool disponible = false;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (!disponible)
                            {
                                if (montoPagarF > 0)
                                    cellSelecion1.Value = true;
                                ene = (decimal)dgFaltantes.Rows[i].Cells["eneF"].Value;
                                if (montoPagarF > 0 && ene > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["eneF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= ene)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - ene;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                feb = (decimal)dgFaltantes.Rows[i].Cells["febF"].Value;
                                if (montoPagarF > 0 && feb > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["febF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= feb)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - feb;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                mar = (decimal)dgFaltantes.Rows[i].Cells["marF"].Value;
                                if (montoPagarF > 0 && mar > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["marF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= mar)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - mar;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                abr = (decimal)dgFaltantes.Rows[i].Cells["abrF"].Value;
                                if (montoPagarF > 0 && abr > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["abrF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= abr)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - abr;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                may = (decimal)dgFaltantes.Rows[i].Cells["mayF"].Value;
                                if (montoPagarF > 0 && may > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["mayF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= may)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - may;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                jun = (decimal)dgFaltantes.Rows[i].Cells["junF"].Value;
                                if (montoPagarF > 0 && jun > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["junF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= jun)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - jun;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                jul = (decimal)dgFaltantes.Rows[i].Cells["julF"].Value;
                                if (montoPagarF > 0 && jul > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["julF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= jul)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - jul;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                ago = (decimal)dgFaltantes.Rows[i].Cells["agoF"].Value;
                                if (montoPagarF > 0 && ago > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["agoF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= ago)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - ago;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                sep = (decimal)dgFaltantes.Rows[i].Cells["sepF"].Value;
                                if (montoPagarF > 0 && sep > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["sepF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= sep)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - sep;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                oct = (decimal)dgFaltantes.Rows[i].Cells["octF"].Value;
                                if (montoPagarF > 0 && oct > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["octF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= oct)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - oct;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                nov = (decimal)dgFaltantes.Rows[i].Cells["novF"].Value;
                                if (montoPagarF > 0 && nov > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["novF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= nov)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - nov;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                                dic = (decimal)dgFaltantes.Rows[i].Cells["dicF"].Value;
                                if (montoPagarF > 0 && dic > 0)
                                {
                                    DataGridViewRow row = dgFaltantes.Rows[i];
                                    DataGridViewTextBoxCell cellSelecion = row.Cells["dicF"] as DataGridViewTextBoxCell;
                                    if (montoPagarF >= dic)
                                    {
                                        cellSelecion.Style.BackColor = Color.Green;
                                        montoPagarF = montoPagarF - dic;
                                    }
                                    else
                                    {
                                        restante = montoPagarF;
                                        cellSelecion.Style.BackColor = Color.Yellow;
                                        montoPagarF = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("El monto a compensar debe ser mayor de 0", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (montoPagarF > 0)
                {
                    lblMensajesN.Text = "Luego de cubrir los pagos requeridos le restan: S/. " + Convert.ToString(montoPagarF);
                }
                else
                {
                    lblMensajesN.Text = "";
                }
                montoResultante = montoPagarF;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular");
            }
        }

        private void lnkCompensarFaltantes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            if (txtExpediente.Text.Trim().Length <= 0)
                throw new Exception("Debe ingresar un expediente");
            if (rchtObservación.Text.Trim().Length <= 0)
                throw new Exception("Debe ingresar una observación.");

            try
            {
                if (MessageBox.Show("Confirmar Compensación de Deuda?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    Liqu_Compensacion liqu_Compensacion = new Liqu_Compensacion();
                    liqu_Compensacion.persona_id = persona;
                    liqu_Compensacion.tributos_id = tributo_id;
                    liqu_Compensacion.registro_user_add = GlobalesV1.Global_str_Usuario;
                    liqu_Compensacion.expediente = txtExpediente.Text.Trim();
                    liqu_Compensacion.observacion = rchtObservación.Text.Trim();

                    int resultado = liqu_CompensacionDataService.Insert(liqu_Compensacion);//liquidacion_opera.Insert(elemento);

                    if (resultado != 0)
                    {
                        int cantidad;
                        decimal montoPagar;
                        montoPagar = Convert.ToDecimal(txtPagoMontoF.Text);
                        cantidad = dgFaltantes.RowCount;

                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgFaltantes.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["estadoF"] as DataGridViewCheckBoxCell;
                            bool disponible = false; //(bool)dataGridView1.Rows[i].Cells["xestado"].Value;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (disponible)
                            {
                                DataGridViewRow row = dgFaltantes.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["eneF"] as DataGridViewTextBoxCell;

                                int anio = (int)dgFaltantes.Rows[i].Cells["anioF"].Value;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), predio);
                                //liquidacion_opera.InsertDetalle3(resultado, persona, predio, 1, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), montoPagar, predio);

                                cellSelecion = row.Cells["febF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(2), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(2), montoPagar, predio);

                                cellSelecion = row.Cells["marF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(3), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(3), montoPagar, predio);

                                cellSelecion = row.Cells["abrF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(4), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(1), montoPagar, predio);

                                cellSelecion = row.Cells["mayF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(5), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(5), montoPagar, predio);

                                cellSelecion = row.Cells["junF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(6), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(6), montoPagar, predio);

                                cellSelecion = row.Cells["julF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(7), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(7), montoPagar, predio);

                                cellSelecion = row.Cells["agoF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(8), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(8), montoPagar, predio);

                                cellSelecion = row.Cells["sepF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(9), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(9), montoPagar, predio);

                                cellSelecion = row.Cells["octF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(10), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(10), montoPagar, predio);

                                cellSelecion = row.Cells["novF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(11), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(11), montoPagar, predio);

                                cellSelecion = row.Cells["dicF"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liqu_CompensacionDataService.Insert_Detalle1(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(12), predio);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liqu_CompensacionDataService.Insert_Detalle2(resultado, persona, tributo_id, Convert.ToInt16(anio), Convert.ToInt16(12), montoPagar, predio);

                            }
                        }
                        liqu_CompensacionDataService.compensarFaltantes(persona, tributo_id, predio, montoPagar, montoResultante);
                        MessageBox.Show("Compensacion correctamente registrada", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
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

        public void limpiarNegativos()
        {
            for (int i = 0; i < dgNegativos.RowCount; i++)
            {
                DataGridViewRow row = dgNegativos.Rows[i];
                DataGridViewTextBoxCell cellSelecion = row.Cells["xeneN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xfebN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xmarN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xabrN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xmayN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xjunN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xjulN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xagoN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xsepN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xoctN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xnovN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["xdicN"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
            }
        }
        public void limpiarFaltantes()
        {
            for (int i = 0; i < dgFaltantes.RowCount; i++)
            {
                DataGridViewRow row = dgFaltantes.Rows[i];
                DataGridViewTextBoxCell cellSelecion = row.Cells["eneF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["febF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["marF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["abrF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["mayF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["junF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["julF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["agoF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["sepF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["octF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["novF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
                cellSelecion = row.Cells["dicF"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.White;
            }
        }
    }
}
