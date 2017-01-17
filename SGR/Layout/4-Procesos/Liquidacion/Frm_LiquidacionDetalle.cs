using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Core;
using SGR.Entity;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Drawing;

namespace SGR.WinApp.Layout._4_Procesos.Liquidacion
{
    public partial class Frm_LiquidacionDetalle : Form
    {
        Liqu_DeudaDetalleMontoDataService deudaMontoDetalle = new Liqu_DeudaDetalleMontoDataService();
        Liqu_LiquidacionDataService liquidacion_opera = new Liqu_LiquidacionDataService();
        string predio, persona, grupo;
        decimal restante = 0;
        public Frm_LiquidacionDetalle(string persona_ID, string predio_ID, string grupo_trib, string nombres, string documento, string persona, string direccCompleta)
        {
            InitializeComponent();
            this.predio = predio_ID;
            this.persona = persona_ID;
            this.grupo = grupo_trib;
            lblCodigo.Text = persona;
            lblDireccion.Text = direccCompleta;
            lblNombre.Text = nombres;
            lblDocumento.Text = documento;
            dataGridView1.DataSource = deudaMontoDetalle.listartodos(persona_ID, predio, grupo_trib);
            //dataGridView2.DataSource = deudaMontoDetalle.listartodos2(persona_ID, predio, grupo_trib);

        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1)
            //    return;

            //if (dataGridView1.Columns[e.ColumnIndex].Name == "xestado")
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //    DataGridViewCheckBoxCell cellSelecion = row.Cells["xestado"] as DataGridViewCheckBoxCell;
            //    if (Convert.ToBoolean(cellSelecion.Value))
            //        cellSelecion.Value = false;
            //    else
            //        cellSelecion.Value = true;
            //}
        }
        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1)
        //        return;
        //    decimal montoImpuesto = Convert.ToDecimal(txtPagoTributo.Text);
        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xeene")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xeene"] as DataGridViewCheckBoxCell;
        //        decimal ene = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xene2"].Value;
        //        if (ene > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - ene;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + ene;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }
        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xefeb")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xefeb"] as DataGridViewCheckBoxCell;
        //        decimal feb = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xfeb2"].Value;
        //        if (feb > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - feb;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + feb;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xemar")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xemar"] as DataGridViewCheckBoxCell;
        //        decimal mar = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xmar2"].Value;
        //        if (mar > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - mar;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + mar;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xeabr")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xeabr"] as DataGridViewCheckBoxCell;
        //        decimal abr = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xabr2"].Value;
        //        if (abr > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - abr;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + abr;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xemay")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xemay"] as DataGridViewCheckBoxCell;
        //        decimal may = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xmay2"].Value;
        //        if (may > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - may;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + may;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xejun")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xejun"] as DataGridViewCheckBoxCell;
        //        decimal jun = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xjun2"].Value;
        //        if (jun > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - jun;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + jun;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xejul")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xejul"] as DataGridViewCheckBoxCell;
        //        decimal jul = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xjul2"].Value;
        //        if (jul > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - jul;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + jul;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xeago")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xeago"] as DataGridViewCheckBoxCell;
        //        decimal ago = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xago2"].Value;
        //        if (ago > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - ago;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + ago;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xesep")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xesep"] as DataGridViewCheckBoxCell;
        //        decimal sep = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xsep2"].Value;
        //        if (sep > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - sep;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + sep;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xeoct")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xeoct"] as DataGridViewCheckBoxCell;
        //        decimal oct = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xoct2"].Value;
        //        if (oct > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - oct;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + oct;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xenov")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xenov"] as DataGridViewCheckBoxCell;
        //        decimal nov = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xnov2"].Value;
        //        if (nov > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - nov;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + nov;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }

        //    if (dataGridView2.Columns[e.ColumnIndex].Name == "xedic")
        //    {
        //        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
        //        DataGridViewCheckBoxCell cellSelecion = row.Cells["xedic"] as DataGridViewCheckBoxCell;
        //        decimal dic = (decimal)dataGridView2.Rows[e.RowIndex].Cells["xdic2"].Value;
        //        if (dic > 0)
        //        {
        //            if (Convert.ToBoolean(cellSelecion.Value))
        //            {
        //                montoImpuesto = montoImpuesto - dic;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //            else
        //            {
        //                montoImpuesto = montoImpuesto + dic;
        //                txtPagoTributo.Text = Convert.ToString(montoImpuesto);
        //            }
        //        }
        //    }
        //}
        public void limpiar()
        {

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
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
        private void validaDecimal(object sender, KeyEventArgs e)
        {
            ValidarCampoDecimal((TextBox)sender);
        }
        public static bool ValidarCampoDecimal(TextBox CajaDeTexto)
        {
            try
            {
                decimal d = Convert.ToDecimal(CajaDeTexto.Text);
                return true;
            }
            catch (Exception ex)
            {
                CajaDeTexto.Text = "0";
                CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                int cantidad;
                decimal montoPagar;
                decimal ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, dic;
                montoPagar = Convert.ToDecimal(txtPagoMonto.Text);
                if (montoPagar > 0)
                {
                    cantidad = dataGridView1.RowCount;
                    for (int i = 0; i < cantidad; i++)
                    {
                        DataGridViewRow row1 = dataGridView1.Rows[i];
                        DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestado"] as DataGridViewCheckBoxCell;
                        bool disponible = false;
                        disponible = Convert.ToBoolean(cellSelecion1.Value);
                        if (disponible)
                        {
                            ene = (decimal)dataGridView1.Rows[i].Cells["xene"].Value;
                            if (montoPagar > 0 && ene > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            feb = (decimal)dataGridView1.Rows[i].Cells["xfeb"].Value;
                            if (montoPagar > 0 && feb > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            mar = (decimal)dataGridView1.Rows[i].Cells["xmar"].Value;
                            if (montoPagar > 0 && mar > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            abr = (decimal)dataGridView1.Rows[i].Cells["xabr"].Value;
                            if (montoPagar > 0 && abr > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            may = (decimal)dataGridView1.Rows[i].Cells["xmay"].Value;
                            if (montoPagar > 0 && may > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            jun = (decimal)dataGridView1.Rows[i].Cells["xjun"].Value;
                            if (montoPagar > 0 && jun > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            jul = (decimal)dataGridView1.Rows[i].Cells["xjul"].Value;
                            if (montoPagar > 0 && jul > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            ago = (decimal)dataGridView1.Rows[i].Cells["xago"].Value;
                            if (montoPagar > 0 && ago > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            sep = (decimal)dataGridView1.Rows[i].Cells["xsep"].Value;
                            if (montoPagar > 0 && sep > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            oct = (decimal)dataGridView1.Rows[i].Cells["xoct"].Value;
                            if (montoPagar > 0 && oct > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            nov = (decimal)dataGridView1.Rows[i].Cells["xnov"].Value;
                            if (montoPagar > 0 && nov > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            dic = (decimal)dataGridView1.Rows[i].Cells["xdic"].Value;
                            if (montoPagar > 0 && dic > 0)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
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
                            DataGridViewRow row1 = dataGridView1.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestado"] as DataGridViewCheckBoxCell;
                            bool disponible = false;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (!disponible)
                            {
                                if (montoPagar > 0)
                                    cellSelecion1.Value = true;
                                ene = (decimal)dataGridView1.Rows[i].Cells["xene"].Value;
                                if (montoPagar > 0 && ene > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                feb = (decimal)dataGridView1.Rows[i].Cells["xfeb"].Value;
                                if (montoPagar > 0 && feb > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                mar = (decimal)dataGridView1.Rows[i].Cells["xmar"].Value;
                                if (montoPagar > 0 && mar > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                abr = (decimal)dataGridView1.Rows[i].Cells["xabr"].Value;
                                if (montoPagar > 0 && abr > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                may = (decimal)dataGridView1.Rows[i].Cells["xmay"].Value;
                                if (montoPagar > 0 && may > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                jun = (decimal)dataGridView1.Rows[i].Cells["xjun"].Value;
                                if (montoPagar > 0 && jun > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                jul = (decimal)dataGridView1.Rows[i].Cells["xjul"].Value;
                                if (montoPagar > 0 && jul > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                ago = (decimal)dataGridView1.Rows[i].Cells["xago"].Value;
                                if (montoPagar > 0 && ago > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                sep = (decimal)dataGridView1.Rows[i].Cells["xsep"].Value;
                                if (montoPagar > 0 && sep > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                oct = (decimal)dataGridView1.Rows[i].Cells["xoct"].Value;
                                if (montoPagar > 0 && oct > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                nov = (decimal)dataGridView1.Rows[i].Cells["xnov"].Value;
                                if (montoPagar > 0 && nov > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                                dic = (decimal)dataGridView1.Rows[i].Cells["xdic"].Value;
                                if (montoPagar > 0 && dic > 0)
                                {
                                    DataGridViewRow row = dataGridView1.Rows[i];
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
                }
                else
                {
                    lblMensajes.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular");
            }


        }
        //private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    if (Cursor.Current == Cursors.WaitCursor)
        //        return;
        //    Cursor.Current = Cursors.WaitCursor;
        //    try
        //    {
        //        if (MessageBox.Show("Confirmar Liquidación de Deuda?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            Liqu_Liquidacion elemento = new Liqu_Liquidacion();
        //            elemento.estado = "P";
        //            elemento.Intereses = 0;
        //            elemento.tipo = grupo;
        //            elemento.importe = 0;
        //            elemento.registro_user_add = GlobalesV1.Global_str_Usuario;
        //            elemento.Persona_id = persona;
        //            int resultado = liquidacion_opera.Insert(elemento);
        //            if (resultado != 0)
        //            {
        //                for (int i = 0; i < dataGridView1.RowCount; i++)
        //                {
        //                    int anio = (int)dataGridView2.Rows[i].Cells["xanio2"].Value;
        //                    string tributo_ID = (string)dataGridView2.Rows[i].Cells["xtributos_ID"].Value;
        //                    DataGridViewRow row1 = dataGridView2.Rows[i];
        //                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xeene"] as DataGridViewCheckBoxCell;
        //                    bool disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xene2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 1, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xefeb"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xfeb2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 2, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xemar"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xmar2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 3, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xeabr"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xabr2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 4, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xemay"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xmay2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 5, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xejun"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xjun2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 6, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xejul"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xjul2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 7, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xeago"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xago2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 8, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xesep"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xsep2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 9, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xeoct"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xoct2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 10, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xenov"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xnov2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 11, anio, tributo_ID);
        //                    }
        //                    cellSelecion1 = row1.Cells["xedic"] as DataGridViewCheckBoxCell;
        //                    disponible = Convert.ToBoolean(cellSelecion1.Value);
        //                    if (disponible)
        //                    {
        //                        decimal ene = (decimal)dataGridView2.Rows[i].Cells["xdic2"].Value;
        //                        if (ene > 0)
        //                            liquidacion_opera.InsertDetalle5(resultado, persona, predio, 12, anio, tributo_ID);
        //                    }

        //                }
        //                liquidacion_opera.modificarEstadoFinal(resultado);
        //                MessageBox.Show("Liquidación correctamente generada", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                this.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error en la liquidación", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    finally
        //    {
        //        Cursor.Current = Cursors.Default;
        //    }
        //}
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Frm_LiquidacionDetalle_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                if (MessageBox.Show("Confirmar Liquidación de Deuda?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    elemento.estado = "P";
                    elemento.Intereses = 0;
                    elemento.tipo = grupo;
                    elemento.importe = 0;
                    elemento.Persona_id = persona;
                    elemento.registro_user_add = GlobalesV1.Global_str_Usuario;
                    int resultado = liquidacion_opera.Insert(elemento);
                    if (resultado != 0)
                    {
                        int cantidad;
                        decimal montoPagar;
                        montoPagar = Convert.ToDecimal(txtPagoMonto.Text);
                        cantidad = dataGridView1.RowCount;
                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dataGridView1.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestado"] as DataGridViewCheckBoxCell;
                            bool disponible = false; //(bool)dataGridView1.Rows[i].Cells["xestado"].Value;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (disponible)
                            {
                                DataGridViewRow row = dataGridView1.Rows[i];
                                DataGridViewTextBoxCell cellSelecion = row.Cells["xene"] as DataGridViewTextBoxCell;
                                int anio = (int)dataGridView1.Rows[i].Cells["xanio"].Value;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 1, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 1, anio, grupo, restante);

                                cellSelecion = row.Cells["xfeb"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 2, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 2, anio, grupo, restante);

                                cellSelecion = row.Cells["xmar"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 3, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 3, anio, grupo, restante);

                                cellSelecion = row.Cells["xabr"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 4, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 4, anio, grupo, restante);

                                cellSelecion = row.Cells["xmay"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 5, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 5, anio, grupo, restante);

                                cellSelecion = row.Cells["xjun"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 6, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 6, anio, grupo, restante);

                                cellSelecion = row.Cells["xjul"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 7, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 7, anio, grupo, restante);

                                cellSelecion = row.Cells["xago"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 8, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 8, anio, grupo, restante);

                                cellSelecion = row.Cells["xsep"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 9, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 9, anio, grupo, restante);

                                cellSelecion = row.Cells["xoct"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 10, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 10, anio, grupo, restante);

                                cellSelecion = row.Cells["xnov"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 11, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 11, anio, grupo, restante);

                                cellSelecion = row.Cells["xdic"] as DataGridViewTextBoxCell;
                                if (cellSelecion.Style.BackColor.Equals(Color.Green))
                                    liquidacion_opera.InsertDetalle3(resultado, persona, predio, 12, anio, grupo);
                                else
                                    if (cellSelecion.Style.BackColor.Equals(Color.Yellow))
                                    liquidacion_opera.InsertDetalle4(resultado, persona, predio, 12, anio, grupo, restante);

                            }
                        }
                        liquidacion_opera.modificarEstadoFinal(resultado);
                        MessageBox.Show("Liquidación correctamente registrada", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al realizar Liquidación", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}