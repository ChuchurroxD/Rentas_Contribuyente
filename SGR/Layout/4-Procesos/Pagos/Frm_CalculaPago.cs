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

namespace SGR.WinApp.Layout._4_Procesos.Pagos
{
    public partial class Frm_CalculaPago : Form
    {
        private Mant_BancoDataService Mant_BancoDataService = new Mant_BancoDataService();
        Liqu_LiquidacionDataService liquidacion = new Liqu_LiquidacionDataService();
        Liqu_Liquidacion elemento = new Liqu_Liquidacion();
        Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        Pago_PagosDataService pagos = new Pago_PagosDataService();
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private MesDataService mess = new MesDataService();
        private Liqu_LiquidacionDataService liquidacionDS = new Liqu_LiquidacionDataService();
        private Liqu_DeudaDetalleMontoDataService deudaDetallesds = new Liqu_DeudaDetalleMontoDataService();
        private List<Mant_Periodo> periodo = new List<Mant_Periodo>();
        private List<Mes> mesese = new List<Mes>();
        string cod_per,solesE, dolaresE, solesT, dolaresT, solesC,per,documento, direccion;
        int liqui=0;
        public Frm_CalculaPago(string persona,string codigo,string documento,string direccion)
        {
            InitializeComponent();
            cargarCombos();
            this.cod_per = codigo;
            this.documento = documento;
            this.direccion = direccion;
            this.per = persona;
            lblNombre.Text = persona;
            iniciarElementos();
            
        }
        public void iniciarElementos()
        {
            dataGridView1.DataSource = liquidacionDS.listarTributosAfectos(cod_per);
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("El contribuyente seleccionado no tiene deuda pendiente");
                this.Close();
            }
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

            cboBanco.DisplayMember = "descripcion";
            cboBanco.ValueMember = "banco_ID";
            cboBanco.DataSource = Mant_BancoDataService.listaActivos();

            cboAnioIni.SelectedValue = parametros[0];
            cboMesIni.SelectedValue = Convert.ToString( parametros[1]);
            cboAnioFin.SelectedValue = parametros[2];
            cboMesFin.SelectedValue = Convert.ToString(parametros[3]);
            dataGridView2.DataSource = new List<Liqu_DeudaDetalleTributo>();
            habilitarTributos();            
            cargarDeuda();
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
        public void inhabilitarTributos()
        {
            int cantidad;
            cantidad = dataGridView1.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                DataGridViewRow row1 = dataGridView1.Rows[i];
                DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xestadot"] as DataGridViewCheckBoxCell;
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
        private void cboAnioIni_SelectedIndexChanged(object sender, EventArgs e)
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
        private void cboMesIni_SelectedIndexChanged(object sender, EventArgs e)
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
        private void cboAnioFin_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtDolaresE_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtDolaresE.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtDolaresE.Text);
                    dolaresE = txtDolaresE.Text;
                    txtTotalE.Text = Convert.ToString(Convert.ToDecimal(txtSolesE.Text) + Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresE.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    soles = Convert.ToDecimal(dolaresE);
                    txtDolaresE.Text = dolaresE;
                    txtDolaresE.Select(txtDolaresE.Text.Length, 0);
                }
            }
        }

        private void txtSolesT_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtSolesT.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtSolesT.Text);
                    solesT = txtSolesT.Text;
                    txtTotalT.Text = Convert.ToString(Convert.ToDecimal(txtSolesT.Text) + Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresT.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    txtSolesT.Text = solesT;
                    txtSolesT.Select(txtSolesT.Text.Length, 0);
                }
            }
        }

        private void txtDolaresT_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtDolaresT.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtDolaresT.Text);
                    dolaresT = txtDolaresT.Text;
                    txtTotalT.Text = Convert.ToString(Convert.ToDecimal(txtSolesT.Text) + Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresT.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    soles = Convert.ToDecimal(dolaresT);
                    txtDolaresT.Text = dolaresT;
                    txtDolaresT.Select(txtDolaresT.Text.Length, 0);
                }
            }
        }

        private void txtTotalC_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtTotalC.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtTotalC.Text);
                    solesC = txtTotalC.Text;
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    txtTotalC.Text = solesC;
                    txtTotalC.Select(txtTotalC.Text.Length, 0);
                }
            }
        }

        private void txtSolesE_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtSolesE.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtSolesE.Text);
                    solesE = txtSolesE.Text;
                    txtTotalE.Text = Convert.ToString(Convert.ToDecimal(txtSolesE.Text) + Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresE.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    soles = Convert.ToDecimal(solesE);
                    txtSolesE.Text = solesE;
                    txtSolesE.Select(txtSolesE.Text.Length, 0);
                }
            }
        }

        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboTarjeta.Enabled = chkTarjeta.Checked;
            txtSolesT.Enabled = chkTarjeta.Checked;
            txtDolaresT.Enabled = chkTarjeta.Checked;
            if (!chkTarjeta.Checked)
            {
                txtTotalT.Text = "0";
                txtSolesT.Text = "0";
                txtDolaresT.Text = "0";
                txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
            }
        }

        private void chkCheque_CheckedChanged(object sender, EventArgs e)
        {
            cboBanco.Enabled = chkCheque.Checked;
            txtCheque.Enabled = chkCheque.Checked;
            txtTotalC.Enabled = chkCheque.Checked;
            if (!chkCheque.Checked)
            {
                txtTotalC.Text = "0";
                txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            habilitarTributos();
        }

        private void Frm_CalculaPago_Load(object sender, EventArgs e)
        {
            habilitarTributos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xestadot")
                cargarDeuda();
        }

        private void cboMesFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDeuda();
        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            txtSolesE.Enabled = chkEfectivo.Checked;
            txtDolaresE.Enabled = chkEfectivo.Checked;
            if (!chkEfectivo.Checked)
            {
                txtTotalE.Text = "0";
                txtSolesE.Text = "0";
                txtDolaresE.Text = "0";
                txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
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
                param[4] = new ReportParameter("Nombres", per);
                param[5] = new ReportParameter("Domicilio", direccion);
                param[6] = new ReportParameter("TipoEm", "PRED+ARBITR");
                param[7] = new ReportParameter("Predio", "Todos");
                param[8] = new ReportParameter("Ubicacion", " ");
                param[9] = new ReportParameter("TotalDeudaAnual", Convert.ToString(monto));
                param[10] = new ReportParameter("DeudaVencida", Convert.ToString(monto));
                param[11] = new ReportParameter("DeudaConsultada", Convert.ToString(monto));
                param[12] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            int resultado;
            try
            {
                if (Convert.ToDecimal(txtSaldo.Text) == Convert.ToDecimal("0"))
                {
                    if (!txtTasa.Text.Equals(""))
                    {
                        if (Convert.ToDecimal(txtTotalP.Text) != 0)
                        {


                            List<int> listaPagos = new List<int>();
                            decimal totalPago = Convert.ToDecimal(txtTotalP.Text);
                            decimal dolaresE2, solesE2, dolaresT2, solesT2, solesC2, tasaaa;
                            tasaaa = Convert.ToDecimal(txtTasa.Text);
                            dolaresE2 = Convert.ToDecimal(txtDolaresE.Text);
                            solesE2 = Convert.ToDecimal(txtSolesE.Text);
                            dolaresT2 = Convert.ToDecimal(txtDolaresT.Text);
                            solesT2 = Convert.ToDecimal(txtSolesT.Text);
                            solesC2 = Convert.ToDecimal(txtTotalC.Text);
                            List<Liqu_LiquidacionTributos> listado = new List<Liqu_LiquidacionTributos>();
                            listado = pagos.cargarTributosPago(liqui);
                            decimal montoAcumulado = 0;
                            int cantidad = listado.Count;
                            int iteraciones = cantidad / 10;
                            if (cantidad % 10 > 0)
                                iteraciones++;
                            for (int i = 0; i < iteraciones; i++)
                            {
                                montoAcumulado = 0;
                                resultado = pagos.registrarPagoLiquidacion(liqui, per,
                                0, "1", Convert.ToDecimal(txtTasa.Text), 0, 1, cod_per, true);
                                for (int o = 10 * i; o < (i + 1) * 10 && o != cantidad; o++)
                                {
                                    if (resultado != 0)
                                    {
                                        pagos.registrarPagoLiquidacionDetalleTributoNuevo(resultado, listado[o].detalleLiquidacion);
                                        montoAcumulado = montoAcumulado + listado[o].montoPago;
                                    }
                                    else
                                        MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                }
                                listaPagos.Add(resultado);
                                if (solesE2 >= montoAcumulado)
                                {
                                    pagos.registrarPagoLiquidacionDetalle(resultado, 1, montoAcumulado, 0, "");
                                    solesE2 = solesE2 - montoAcumulado;
                                }
                                else
                                {
                                    if (solesE2 + (dolaresE2 * tasaaa) >= montoAcumulado)
                                    {
                                        pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, (montoAcumulado - solesE2) / tasaaa, "");
                                        solesE2 = 0;
                                        dolaresE2 = dolaresE2 - (montoAcumulado - solesE2) / tasaaa;
                                    }
                                    else
                                    {
                                        if (solesE2 + (dolaresE2 * tasaaa) + solesT2 >= montoAcumulado)
                                        {
                                            if (solesE2 + dolaresE2 > 0)
                                            {
                                                pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, dolaresE2, "");
                                                solesE2 = 0; dolaresE2 = 0;
                                            }
                                            pagos.registrarPagoLiquidacionDetalle(resultado, 2, montoAcumulado - solesE2 - (dolaresE2 * tasaaa), 0, cboTarjeta.Text);
                                            solesT2 = solesT2 - (montoAcumulado - solesE2 - (dolaresE2 * tasaaa));
                                        }
                                        else
                                        {
                                            if (solesE2 + (dolaresE2 * tasaaa) + solesT2 + (dolaresT2 * tasaaa) >= montoAcumulado)
                                            {
                                                if (solesE2 + dolaresE2 > 0)
                                                {
                                                    pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, dolaresE2, "");
                                                    solesE2 = 0; dolaresE2 = 0;
                                                }
                                                pagos.registrarPagoLiquidacionDetalle(resultado, 2, montoAcumulado - solesE2 - (dolaresE2 * tasaaa), (montoAcumulado - solesT2 - solesE2) / tasaaa - dolaresE2, cboTarjeta.Text);
                                                solesT2 = 0;
                                                dolaresT2 = dolaresT2 - ((montoAcumulado - solesE2 - solesT2) / tasaaa - dolaresE2);
                                            }
                                            else
                                            {
                                                if (solesE2 + dolaresE2 > 0)
                                                {
                                                    pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, dolaresE2, "");
                                                    solesE2 = 0; dolaresE2 = 0;
                                                }
                                                if (solesT2 + dolaresT2 > 0)
                                                {
                                                    pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT2, dolaresT2, cboTarjeta.Text);
                                                    solesT2 = 0; dolaresT2 = 0;
                                                }
                                                pagos.registrarPagoLiquidacionDetalle(resultado, 3, solesC2, 0, Convert.ToString((Int32)cboBanco.SelectedValue) + "-" + txtCheque.Text);
                                                solesC2 = 0;
                                            }
                                        }
                                    }
                                }
                            }
                            pagos.actualizarCuentaCorriente(liqui);
                            MessageBox.Show("Pago realizado correctamente");
                            for (int num = 0; num < iteraciones; num++)
                                generarRecibo(listaPagos[num]);
                            this.Close();



                            //      resultado = pagos.registrarPagoLiquidacion(liqui, per,
                            //Convert.ToDecimal(txtTotalP.Text), "1", Convert.ToDecimal(txtTasa.Text), 0, 1, cod_per, true);
                            //      if (resultado != 0)
                            //      {
                            //          decimal solesE, dolaresE, solesT, dolaresT, solesC;
                            //          solesE = Convert.ToDecimal(txtSolesE.Text);
                            //          solesT = Convert.ToDecimal(txtSolesT.Text);
                            //          solesC = Convert.ToDecimal(txtTotalC.Text);
                            //          dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                            //          dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                            //          if (solesE + dolaresE != Convert.ToDecimal(0))
                            //          {
                            //              if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                            //                  MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                            //          }
                            //          if (solesT + dolaresT != Convert.ToDecimal(0))
                            //          {
                            //              if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                            //                  MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                            //          }
                            //          if (solesC != Convert.ToDecimal(0))
                            //          {
                            //              if (pagos.registrarPagoLiquidacionDetalle(resultado, 3, solesC, 0, Convert.ToString((Int32)cboBanco.SelectedValue)+"-"+txtCheque.Text) == 0)
                            //                  MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                            //          }
                            //  pagos.registrarPagoLiquidacionDetalleTributo(liqui, resultado);
                            //          pagos.actualizarCuentaCorriente(Convert.ToInt32(liqui));
                            //          MessageBox.Show("Pago realizado correctamente");
                            //          generarRecibo(resultado);
                            //  this.Close();
                            //      }
                            //      else
                            //          MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);                                  
                        }
                        else
                            MessageBox.Show("Debe existir deuda para poder pagar", Globales.Global_MessageBox);
                    }
                    else
                        MessageBox.Show("Por favor registre la tasa de cambio", Globales.Global_MessageBox);
                }
                else
                    MessageBox.Show("El saldo debe ser 0 por favor revise los montos", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el pago", Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        public void generarRecibo(int pago_id)
        {
            try
            {
                List<Pago_ReciboPago> coleccion = new List<Pago_ReciboPago>();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                coleccion = pagos.listarRecibo(pago_id);
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Pagos.rptPagos.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Fecha", DateTime.Now.ToShortDateString().Trim());
                param[1] = new ReportParameter("Ruc", Globales.RucEmpresa);
                param[2] = new ReportParameter("N", GlobalesV1.Global_str_Usuario);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView2.DataSource = new List<Liqu_DeudaDetalleTributo>();
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
                        elemento.importe = Convert.ToDecimal(txtTotal.Text);
                        elemento.Persona_id = cod_per;
                        tributooo = (string)dataGridView2.Rows[0].Cells["xtributos_ID"].Value;
                        resultado = liquidacionDS.Insert2(elemento, tributooo);
                        liqui = resultado.liquidacion_id;
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

                            MessageBox.Show("Cobranza Generada: \n Indique métodos de pago");
                           
                            if (elemento.importe > 0)
                            {
                                chkEfectivo.Checked = true;
                                txtTotalP.Text = Convert.ToString(elemento.importe);
                                txtSolesE.Text = Convert.ToString(elemento.importe);
                                txtTotalE.Text = Convert.ToString(elemento.importe);
                                txtSolesT.Text = "0";
                                txtDolaresT.Text = "0";
                                txtDolaresE.Text = "0";
                                txtTotalC.Text = "0";
                                txtTotalT.Text = "0";
                                txtSaldo.Text = "0";
                                solesE = Convert.ToString(elemento.total_final);
                                button1.Enabled = true;
                                groupBox1.Enabled = false;
                            }
                            else
                                reiniciar();
                        }
                    }
                    else
                        MessageBox.Show("No especifico deuda a liquidar");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        public void cargarCombos()
        {
            try
            {
                cboTarjeta.DisplayMember = "Multc_vDescripcion";
                cboTarjeta.ValueMember = "Multc_cValor";
                cboTarjeta.DataSource = tablas.GetCboConf_Multitabla("31");
                Pago_Parametros elemento = new Pago_Parametros();
                elemento = pagos.obtenerParametros();
                txtFecha.Value = elemento.fecha;
                txtTasa.Text = Convert.ToString(elemento.precioVenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor registre la tasa de cambio para el día de hoy", Globales.Global_MessageBox);
                this.Close();
            }
        }
        public void reiniciar()
        {
            chkEfectivo.Checked = true;
            chkTarjeta.Enabled = false;
            chkTarjeta.Checked = false;
            chkCheque.Enabled = false;
            chkCheque.Checked = false;
            cboBanco.Enabled = false;
            txtCheque.Enabled = false;
            cboTarjeta.Enabled = false;
        }
    }
}
