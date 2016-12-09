using SGR.Core.Service;
using SGR.Entity;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Web;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using System.Drawing;

namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo
{
    public partial class Frm_CalculoIndividulPredio : Form
    {
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Mant_DepreciacionDataService DepreciacionDataService = new Mant_DepreciacionDataService();
        private Pred_TributoDataService TributoDataService = new Pred_TributoDataService();
        private Mant_ParametrosDataService ParametrosDataService = new Mant_ParametrosDataService();
        private Mant_ParametroMesDataService ParametroMesDataService = new Mant_ParametroMesDataService();
        private Pred_PredioContribuyenteDataService PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private Pred_PredioDataService PredioDataService = new Pred_PredioDataService();

        private Pred_FiscalizacionDataService FiscalizacionDataService = new Pred_FiscalizacionDataService();
        private List<Mes> mesese = new List<Mes>();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
        private Pred_PrredioArbitrioDataService PrredioArbitrioDataService = new Pred_PrredioArbitrioDataService();
        private Proc_CuentaCorritenteDataService Proc_CuentaCorritenteDataService = new Proc_CuentaCorritenteDataService();
        private int grptrib_id;
        private String contrib_id;
        private String predio_id;
        private String usser = GlobalesV1.Global_str_Usuario;
        private int periodo;
        public Frm_CalculoIndividulPredio(String Contribuyente, String contr_name, int perio, String grptrib_name, int grptrib_idg, String predio_id)
        {
            InitializeComponent();
            lblContribuyente.Text = contr_name;
            lblTributo.Text = grptrib_name;
            this.grptrib_id = grptrib_idg;
            this.contrib_id = Contribuyente;
            this.predio_id = predio_id;
            this.periodo = perio;
            if (grptrib_id == 1)
                dgvCtaCorriente.DataSource = Proc_CuentaCorritenteDataService.listarPredialArbIndiv(contrib_id, "0008", 2, "");
            else if (grptrib_id == 2 && predio_id.Length > 0)
                dgvCtaCorriente.DataSource = Proc_CuentaCorritenteDataService.listarPredialArbIndiv(contrib_id, "0043", 3, predio_id);
            else if (grptrib_id == 2 && predio_id.Length == 0)
                dgvCtaCorriente.DataSource = Proc_CuentaCorritenteDataService.listarPredialArbxPersona(contrib_id, "0043");
        }
        public Frm_CalculoIndividulPredio()
        {
            InitializeComponent();
            //dgvCtaCorriente.DataSource=Proc_CuentaCorritenteDataService.listarPredial( "3545","0008");
        }
        private int CargarGrilla(List<Mant_Depreciacion> lista)
        {
            int num = 0;
            dgvErrores.Rows.Clear();
            try
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, lista[i].clasificacion_descripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            return num;
        }
        private int CargarGrilla(List<Mant_Depreciacion> lista, String cadena1, List<Mant_ParametroMes> listapm, List<Pred_Predio> listaarancel)
        {
            int num = 0;
            dgvErrores.Rows.Clear();
            try
            {

                for (int i = 0; i < lista.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, lista[i].clasificacion_descripcion);
                }
                if (String.Compare(cadena1, "") != 0)
                {
                    num++;
                    dgvErrores.Rows.Add(num, cadena1);
                }
                for (int i = 0; i < listapm.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, listapm[i].tipoAbreviatura);
                }
                for (int i = 0; i < listaarancel.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, listaarancel[i].norte);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            return num;
        }
        private int CargarGrilla1(String cadena1, List<Mant_ParametroMes> listapm, List<Mant_TablaArancel> listaArbDe, string cantidadArbitrios, List<Mant_TablaArancel> listaArbitrioCount)
        {
            int num = 0;
            dgvErrores.Rows.Clear();
            try
            {
                if (String.Compare(cadena1, "") != 0)
                {
                    num++;
                    dgvErrores.Rows.Add(num, cadena1);
                }
                for (int i = 0; i < listapm.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, listapm[i].tipoAbreviatura);
                }
                for (int i = 0; i < listaArbDe.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, listaArbDe[i].Descripcion);
                }

                if (cantidadArbitrios.Trim().Length != 0)
                {
                    num++;
                    dgvErrores.Rows.Add(num, cantidadArbitrios);
                }
                for (int i = 0; i < listaArbitrioCount.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, listaArbitrioCount[i].Descripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            return num;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int resultado = 0;
                if (grptrib_id == 1)//predial
                {
                    if (dgvCtaCorriente.RowCount > 0)
                    {
                        if (Proc_CuentaCorritenteDataService.VerificarExisteCtaCTeIndividual(contrib_id, "0008", 6, "0") == 0)
                        {
                            if (MessageBox.Show("Desea Generar cta cte otra vez?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                resultado = PredioDataService.GenerarCalculoPredialIndividual(contrib_id, usser);
                                MessageBox.Show("Se genero el cálculo correctamente", Globales.Global_MessageBox);
                            }
                        }
                        else
                            MessageBox.Show("No puede modificar cta cte para la persona, porque ya hizo un abono", Globales.Global_MessageBox);
                    }
                    else
                    {
                        resultado = PredioDataService.GenerarCalculoPredialIndividual(contrib_id, usser);
                        MessageBox.Show("Se genero el cálculo correctamente", Globales.Global_MessageBox);
                    }

                    dgvCtaCorriente.DataSource = Proc_CuentaCorritenteDataService.listarPredialArbIndiv(contrib_id, "0008", 2, "");
                }
                else if (grptrib_id == 2 && predio_id.Length > 0)//exitse predio
                {
                    if (dgvCtaCorriente.RowCount > 0)
                    {
                        if (Proc_CuentaCorritenteDataService.VerificarExisteCtaCTeIndividual(contrib_id, "0043", 7, predio_id) == 0)
                        {
                            if (MessageBox.Show("Desea Generar cta cte otra vez?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                PrredioArbitrioDataService.copiarArbitrioANteriores(predio_id, usser); //COPIAR PREDIOARBITRIO DEÑ AÑO PASADO
                                PrredioArbitrioDataService.GenerarCalculoIndividual(predio_id, usser, contrib_id);
                                dgvCtaCorriente.DataSource = Proc_CuentaCorritenteDataService.listarPredialArbIndiv(contrib_id, "0043", 3, predio_id);
                                if (dgvCtaCorriente.RowCount > 0)
                                    MessageBox.Show("Se genero el cálculo correctamente", Globales.Global_MessageBox);
                                else
                                    MessageBox.Show("No hay cálculo predial, o porque o tiene predio, o porque lo ha adquirido en este año", Globales.Global_MessageBox);
                            }
                        }
                        else
                            MessageBox.Show("No puede modificar cta cte para la persona, porque ya hizo un abono", Globales.Global_MessageBox);
                    }
                    else
                    {
                        PrredioArbitrioDataService.copiarArbitrioANteriores(predio_id, usser);
                        PrredioArbitrioDataService.GenerarCalculoIndividual(predio_id, usser, contrib_id);
                        dgvCtaCorriente.DataSource = Proc_CuentaCorritenteDataService.listarPredialArbIndiv(contrib_id, "0043", 3, predio_id);
                        if (dgvCtaCorriente.RowCount > 0)
                            MessageBox.Show("Se genero el cálculo correctamente", Globales.Global_MessageBox);
                        else
                            MessageBox.Show("No hay cálculo predial, o porque o tiene predio, o porque lo ha adquirido en este año", Globales.Global_MessageBox);

                    }

                }
                else if (grptrib_id == 2 && predio_id.Length == 0)//exitse predio
                {
                    if (dgvCtaCorriente.RowCount > 0)
                    {
                        if (Proc_CuentaCorritenteDataService.VerificarExisteCtaCTeIndividual(contrib_id, "0043", 9, "0") == 0)
                        {
                            if (MessageBox.Show("Desea Generar cta cte otra vez?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                PrredioArbitrioDataService.copiarArbitrioPersona(usser, contrib_id);
                                PrredioArbitrioDataService.GenerarCalculoXPersona(usser, contrib_id);
                                MessageBox.Show("Se genero el cálculo correctamente", Globales.Global_MessageBox);
                            }
                        }
                        else
                            MessageBox.Show("No puede modificar cta cte para la persona, porque ya hizo un abono", Globales.Global_MessageBox);
                    }
                    else
                    {
                        PrredioArbitrioDataService.copiarArbitrioPersona(usser, contrib_id);
                        PrredioArbitrioDataService.GenerarCalculoXPersona(usser, contrib_id);
                        MessageBox.Show("Se genero el cálculo correctamente", Globales.Global_MessageBox);
                    }
                    dgvCtaCorriente.DataSource = Proc_CuentaCorritenteDataService.listarPredialArbxPersona(contrib_id, "0043");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            String totalParametroxAnioxCodigo = "";
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                List<Mant_Depreciacion> lista;
                List<Mant_ParametroMes> listapm;
                List<Pred_Predio> listaarancel;
                List<Mant_TablaArancel> listaArbitrioDesc;
                List<Mant_TablaArancel> listaArbitrioCount = new List<Mant_TablaArancel>();
                if (grptrib_id == 1)//predial
                {
                    //lista = DepreciacionDataService.listarErroresDepreciacion(periodo);
                    //listapm = ParametroMesDataService.listarerrores(periodo, 4, grptrib_id, "0008");
                    //listaarancel = PredioDataService.listarerrores(periodo);
                    //if (ParametrosDataService.totalParametroxAnioxCodigo(periodo, 4) != 1)
                    //{
                    //    totalParametroxAnioxCodigo = "No hay o hay más de un parámetro en ese año";
                    //}
                    //if (CargarGrilla(lista, totalParametroxAnioxCodigo, listapm, listaarancel) == 0)
                    //{
                    if (dgvCtaCorriente.RowCount > 0)
                    {
                        MessageBox.Show("Ya hay Cuenta Corriente", Globales.Global_MessageBox);
                        return;
                    }
                    lista = FiscalizacionDataService.verificarParametroParaCalculoInndividual(contrib_id);
                    if (CargarGrilla(lista) == 0)
                    {
                        //Se habilito para copiar de un periodo
                        btnCalcular.Enabled = true;
                        btnExcelErrores.Enabled = false;
                        //MessageBox.Show("Termino la verificación", Globales.Global_MessageBox);
                    }
                    else
                    {
                        btnCalcular.Enabled = false;
                        btnExcelErrores.Enabled = true;
                    }
                }
                else if (grptrib_id == 2 && predio_id.Trim().Length > 0)//exitse predio
                {
                    listapm = ParametroMesDataService.listarerrores(periodo, 7, grptrib_id, "0043");
                    listaArbitrioDesc = PrredioArbitrioDataService.verificarArbitrioANteriores(predio_id);
                    string cantidadArbitrios = "";
                    if (ParametrosDataService.totalParametroxAnioxCodigo(periodo, 7) != 1)
                    {
                        totalParametroxAnioxCodigo = "No hay o hay más de un parámetro en ese año";
                    }
                    if (PrredioArbitrioDataService.cantidadArbitrioANteriores(predio_id) == 0)
                    {
                        cantidadArbitrios = "No hay arbitrio para ese predio " + predio_id;
                    }

                    if (CargarGrilla1(totalParametroxAnioxCodigo, listapm, listaArbitrioDesc, cantidadArbitrios, listaArbitrioCount) == 0)
                    {
                        //Se habilito para copiar de un periodo
                        btnCalcular.Enabled = true;
                        btnExcelErrores.Enabled = false;
                    }
                    else
                    {
                        btnCalcular.Enabled = false;
                        btnExcelErrores.Enabled = true;
                    }
                }
                else if (grptrib_id == 2 && predio_id.Length == 0)//exitse predio
                {
                    listapm = ParametroMesDataService.listarerrores(periodo, 7, grptrib_id, "0043");
                    listaArbitrioDesc = PrredioArbitrioDataService.verificarArbitrioPersona(contrib_id);
                    listaArbitrioCount = PrredioArbitrioDataService.cantidadArbitrioPersona(contrib_id);
                    if (ParametrosDataService.totalParametroxAnioxCodigo(periodo, 7) != 1)
                    {
                        totalParametroxAnioxCodigo = "No hay o hay más de un parámetro en ese año";
                    }
                    if (CargarGrilla1(totalParametroxAnioxCodigo, listapm, listaArbitrioDesc, "", listaArbitrioCount) == 0)
                    {
                        //Se habilito para copiar de un periodo
                        btnCalcular.Enabled = true;
                        btnExcelErrores.Enabled = false;
                    }
                    else
                    {
                        btnCalcular.Enabled = false;
                        btnExcelErrores.Enabled = true;
                    }
                }
                MessageBox.Show("Termino la verificación", Globales.Global_MessageBox);
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

        private void btnExcelErrores_Click(object sender, EventArgs e)
        {

            ExportToTxt();
            //Response.Clear();
            //Response.Buffer = true;
            //Response.ClearContent();
            //Response.ClearHeaders();
            //Response.Charset = "";
            //string FileName = "Vithal" + DateTime.Now + ".xls";
            //StringWriter strwritter = new StringWriter();
            //HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.ContentType = "application/vnd.ms-excel";
            //Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
            //GridView1.GridLines = GridLines.Both;
            //GridView1.HeaderStyle.Font.Bold = true;
            //GridView1.RenderControl(htmltextwrtter);
            //Response.Write(strwritter.ToString());
            //Response.End();
        }
        private void ExportToTxt()
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DateTime fechaHoy = DateTime.Now;
                string cadena = fechaHoy.Year.ToString() + fechaHoy.Month.ToString() + fechaHoy.Day.ToString() +
                               fechaHoy.Hour.ToString() + fechaHoy.Minute.ToString() + fechaHoy.Second.ToString();
                System.IO.StreamWriter escribir = new System.IO.StreamWriter("D:\\Errores" + cadena + ".txt");
                int i = 0;
                foreach (DataGridViewRow fila in this.dgvErrores.Rows)
                {
                    i++;
                    String descripcion = i.ToString() + " - " + (String)fila.Cells[1].Value;
                    escribir.WriteLine(descripcion);
                }
                escribir.Close();
                MessageBox.Show("Se generaro el archivo en el discoD ocn el nombre de 'Errores" + cadena + "'", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void dgvCtaCorriente_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvCtaCorriente.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
