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
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo
{
    public partial class Frm_Predio_Masivo : DockContent
    {
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Mant_DepreciacionDataService DepreciacionDataService = new Mant_DepreciacionDataService();
        private Pred_TributoDataService TributoDataService = new Pred_TributoDataService();
        private Mant_ParametrosDataService ParametrosDataService = new Mant_ParametrosDataService();
        private Mant_ParametroMesDataService ParametroMesDataService = new Mant_ParametroMesDataService();
        private Pred_PredioContribuyenteDataService PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private Pred_PredioDataService PredioDataService = new Pred_PredioDataService();
        private Proc_CuentaCorritenteDataService Proc_CuentaCorritenteDataService = new Proc_CuentaCorritenteDataService();
        private Pred_PrredioArbitrioDataService Pred_PrredioArbitrioDataService = new Pred_PrredioArbitrioDataService();
        private Int32 periodoActivo;
        private string usser = "nada";
        public Frm_Predio_Masivo()
        {
            InitializeComponent();
            listarTipoSelector();
            periodoActivo = PeriodoDataService.GetPeriodoActivo();
            cboPeriodo.SelectedValue = PeriodoDataService.GetPeriodoActivo();
            usser = GlobalesV1.Global_str_Usuario;
        }
        private void listarTipoSelector()
        {
            //cboPeriodo.DisplayMember = "Peric_canio";
            //cboPeriodo.ValueMember = "Peric_canio";
            //cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
            cargarcbpIndividual(cboPeriodo, "Peric_canio", "Peric_canio");
            cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
            cargarcbpIndividual(cboPeriodoAntiguo, "Peric_canio", "Peric_canio");
            cboPeriodoAntiguo.DataSource = PeriodoDataService.llenarPeriodo();
            //cargarcbpIndividual(cboTributo, "tributos_ID", "descripcion");
            //cboTributo.DataSource = TributoDataService.listarTributoCbo();
        }
        private void cargarcbpIndividual(ComboBox cbo, String display, String value)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            String totalParametroxAnioxCodigo = "";
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int tipo = (rbtPredio.Checked) ? 4 : 5;
                if (Proc_CuentaCorritenteDataService.VerificarExisteCtaCTe(periodoActivo, tipo) != 0)
                {
                    MessageBox.Show("Ya se ha generado cálculo", Globales.Global_MessageBox);
                    return;
                }
                List<Mant_Depreciacion> lista = new List<Mant_Depreciacion>();
                List<Mant_ParametroMes> listapm = new List<Mant_ParametroMes>();
                List<Pred_Predio> listaarancel = new List<Pred_Predio>();
                List<Mant_TablaArancel> listaArbitrioDesc = new List<Mant_TablaArancel>();
                List<Mant_TablaArancel> listaArbitrioCant = new List<Mant_TablaArancel>();
                if (rbtArbitrio.Checked)
                {
                    listapm = ParametroMesDataService.listarerrores(Convert.ToInt32(cboPeriodo.SelectedValue.ToString()), 7, 1, "0043");
                    listaArbitrioDesc = Pred_PrredioArbitrioDataService.verificarArbitriomASIVO(Convert.ToInt32(cboPeriodoAntiguo.SelectedValue.ToString()), Convert.ToInt32(cboPeriodo.SelectedValue.ToString()));
                    //listaArbitrioCant = Pred_PrredioArbitrioDataService.cantidadArbitriomASIVO(Convert.ToInt32(cboPeriodoAntiguo.SelectedValue.ToString()));
                }
                else if (rbtPredio.Checked)
                {
                    listapm = ParametroMesDataService.listarerrores(Convert.ToInt32(cboPeriodo.SelectedValue.ToString()), 4, 1, "0008");
                    listaarancel = PredioDataService.listarerrores(Convert.ToInt32(cboPeriodo.SelectedValue.ToString()));
                    lista = DepreciacionDataService.listarErroresDepreciacion(Convert.ToInt32(cboPeriodo.SelectedValue.ToString()));
                }


                if (ParametrosDataService.totalParametroxAnioxCodigo(periodoActivo, 4) != 1)
                {
                    totalParametroxAnioxCodigo = "No hay o hay más de un parámetro en ese año";
                }
                if (CargarGrilla(lista, totalParametroxAnioxCodigo, listapm, listaarancel, listaArbitrioDesc, listaArbitrioCant) == 0)
                {
                    //Se habilito para copiar de un periodo
                    MessageBox.Show("Ya se verificó y no hay errores", Globales.Global_MessageBox);
                    btnCopiar.Enabled = true;
                    btnExcelErrores.Enabled = false;
                }
                else
                {
                    btnCopiar.Enabled = false;
                    btnExcelErrores.Enabled = true;
                }
                //btnCopiar.Enabled = false;
                //btnGenerarCalculoMasivo.Enabled = false;
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
        private int CargarGrilla(List<Mant_Depreciacion> lista, String cadena1, List<Mant_ParametroMes> listapm, List<Pred_Predio> listaarancel, List<Mant_TablaArancel> listaArbDe, List<Mant_TablaArancel> listaArbCanti)
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
                for (int i = 0; i < listaArbDe.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, listaArbDe[i].Descripcion);
                }
                for (int i = 0; i < listaArbCanti.Count; i++)
                {
                    num++;
                    dgvErrores.Rows.Add(num, listaArbCanti[i].Descripcion);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            return num;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (rbtArbitrio.Checked)
                {
                    Pred_PrredioArbitrioDataService.copiarArbitriomASIVO(Convert.ToInt32(cboPeriodoAntiguo.SelectedValue), Convert.ToInt32(cboPeriodo.SelectedValue), usser);
                }
                if (rbtPredio.Checked)
                {
                    PredioDataService.COpiarPredio_Piso_predContribuyente(Convert.ToInt32(cboPeriodoAntiguo.SelectedValue), Convert.ToInt32(cboPeriodo.SelectedValue), usser);
                }
                MessageBox.Show("Se copiarón los datos correctamente", Globales.Global_MessageBox);
                btnGenerarCalculoMasivo.Enabled = true;
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
        private void btnGenerarCalculoMasivo_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int tipo = (rbtPredio.Checked) ? 4 : 5;
                if (rbtPredio.Checked)
                {
                    //if (Proc_CuentaCorritenteDataService.VerificarExisteCtaCTe(Convert.ToInt32(cboPeriodo.SelectedValue), tipo) == 0)
                    //{
                    if (MessageBox.Show("Desea Generar cta cte?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PredioDataService.GenerarPredioMasivo(Convert.ToInt32(cboPeriodoAntiguo.SelectedValue), Convert.ToInt32(cboPeriodo.SelectedValue), usser);
                        MessageBox.Show("Se generó cuenta corriente", Globales.Global_MessageBox);
                    }
                    //}
                    //else
                    //    MessageBox.Show("No puede modificar cta cte para la persona, porque ya hizo un abono", Globales.Global_MessageBox);

                }
                else
                {
                    //if (Proc_CuentaCorritenteDataService.VerificarExisteCtaCTe(Convert.ToInt32(cboPeriodo.SelectedValue), tipo) == 0)
                    //{
                    if (MessageBox.Show("Desea Generar cta cte?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Pred_PrredioArbitrioDataService.GenerarCalculoMasivo(usser, Convert.ToInt32(cboPeriodo.SelectedValue));
                        MessageBox.Show("Se generó cuenta corriente", Globales.Global_MessageBox);
                    }
                    //}
                    //else
                    //    MessageBox.Show("No puede modificar cta cte para la persona, porque ya hizo un abono", Globales.Global_MessageBox);

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

        private void rbtPredio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExcelErrores_Click(object sender, EventArgs e)
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

        private void rbtArbitrio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

