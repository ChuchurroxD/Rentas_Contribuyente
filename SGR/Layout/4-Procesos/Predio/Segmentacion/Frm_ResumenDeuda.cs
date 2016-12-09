using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model;
using SGR.Entity.Model.Combos;
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Segmentacion
{
    public partial class Frm_ResumenDeuda : DockContent
    {
        private List<Pred_ResumenDeuda> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private List<Mes> mesese = new List<Mes>();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
        private MesDataService mess = new MesDataService();
        private Pred_PredioDataService PredioDataService = new Pred_PredioDataService();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        public Frm_ResumenDeuda()
        {
            try
            {
                InitializeComponent();

                periodos = PeriodoDataService.GetAllMant_Periodo();
                cboAnioIni.DisplayMember = "Peric_canio";
                cboAnioIni.ValueMember = "Peric_canio";
                cboAnioIni.DataSource = periodos;

                cboAnioFin.DisplayMember = "Peric_canio";
                cboAnioFin.ValueMember = "Peric_canio";
                cboAnioFin.DataSource = periodos;

                mesese = mess.listartodos();
                cboMesIni.DisplayMember = "mes";
                cboMesIni.ValueMember = "mes_ID";
                cboMesIni.DataSource = mesese;

                cboMesFin.DisplayMember = "mes";
                cboMesFin.ValueMember = "mes_ID";
                cboMesFin.DataSource = mesese;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboAnioIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                cantidad = periodos.Count;
                List<Mant_Periodo> periodo2 = new List<Mant_Periodo>();

                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(periodos[i].Peric_canio) >= Convert.ToInt32(cboAnioIni.SelectedValue))
                    {
                        Mant_Periodo peri = new Mant_Periodo();
                        peri.Peric_canio = periodos[i].Peric_canio;
                        periodo2.Add(peri);
                    }
                }
                cboAnioFin.DisplayMember = "Peric_canio";
                cboAnioFin.ValueMember = "Peric_canio";
                cboAnioFin.DataSource = periodo2;
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboMesIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }

        private void cboAnioFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
        private void buscar()
        {
            try
            {
                int clase=0;
        if (rbtPendientes.Checked)
            clase=2;
        else if (radioButton2.Checked)
            clase = 3;
        else if (radioButton3.Checked)//total
            clase = 1;
                string anioIni = cboAnioIni.SelectedValue.ToString();
                string anioFin = cboAnioFin.SelectedValue.ToString();
                string mesIni = cboMesIni.SelectedValue.ToString();
                string mesFin = cboMesFin.SelectedValue.ToString();

                if (cboAnioIni.SelectedIndex == -1 || cboAnioFin.SelectedIndex == -1 || cboMesIni.SelectedIndex == -1 || cboMesFin.SelectedIndex == -1)
                    return;
                String cadena = txtPersona.Text.TrimEnd();
                String cad1 = "%";
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                char[] array = cadena.ToCharArray();
                int j = 0;
                for (int i = 0; i < cadena.Length; i++)
                {

                    if (array[i] == ' ')
                    {
                        j++;
                    }
                    if (j == 0 && array[i] != ' ')
                    {
                        cad1 = cad1 + array[i];
                    }
                    if (j == 1 && array[i] != ' ')
                    {
                        cad2 = cad2 + array[i];
                    }
                    if (j == 2 && array[i] != ' ')
                    {
                        cad3 = cad3 + array[i];
                    }
                    if (j == 3 && array[i] != ' ')
                    {
                        cad4 = cad4 + array[i];
                    }
                }
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                Coleccion = PredioDataService.ListarResumenDeuda(anioIni, anioFin, mesIni, mesFin, cad1, cad2, cad3, cad4, clase);
                dgvResumenDeuda.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }

        private void dgvResumenDeuda_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvResumenDeuda.Columns[e.ColumnIndex];

                if (dgvResumenDeuda.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "ABONO")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.ABONO).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.ABONO).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "cargo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.cargo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.cargo).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "DEUDA")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.DEUDA).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.DEUDA).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "direccion_completa")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.direccion_completa).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.direccion_completa).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "interes_cobrado")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.interes_cobrado).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.interes_cobrado).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "anio")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.anio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.anio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "mes")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.mes).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.mes).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "NombreCompleto")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.NombreCompleto).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.NombreCompleto).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "persona_ID")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.persona_ID).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.persona_ID).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "predio_ID")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.predio_ID).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.predio_ID).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "tributo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.tributo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvResumenDeuda.DataSource = Coleccion.OrderBy(p => p.tributo).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }

            }
        }

        private void txtPersona_TextChanged(object sender, EventArgs e)
        {
            string per = txtPersona.Text;
            if (per.Trim().Length != 0)
                button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                string clase = "";
                if (rbtPendientes.Checked)
                    clase = "Peendiente";
                else if (radioButton2.Checked)
                    clase = "Pagado";
                else if (radioButton3.Checked)//total
                    clase = "Todos";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Predio.Segmentacion.rptResumenDeuda.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Coleccion));


                List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                elementoo.logoEmpresa = File.ReadAllBytes(_path);
                elementoo.convenio = "convenio";
                origen2.Add(elementoo);
                ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);
                ReportParameter[] paramsx = new ReportParameter[6];
                paramsx[0] = new ReportParameter("Concepto", clase);
                paramsx[1] = new ReportParameter("AnioInicial", cboAnioIni.SelectedValue.ToString());
                paramsx[2] = new ReportParameter("MesInicial", cboMesIni.SelectedValue.ToString());
                paramsx[3] = new ReportParameter("AnioFinal", cboAnioFin.SelectedValue.ToString());
                paramsx[4] = new ReportParameter("MesFinal", cboMesFin.SelectedValue.ToString());
                paramsx[5] = new ReportParameter("PersonaBusqueda",txtPersona.Text );
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rbtPendientes_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {//pagados

            button1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            buscar();
            button1.Enabled = true;

        }
    }
}
