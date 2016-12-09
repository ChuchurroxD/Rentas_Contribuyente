using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model;
using SGR.Entity.Model.Combos;
using SGR.Entity;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Anulacion
{
    public partial class Frm_AnulacionDetalle : Form
    {
        private string contribuyente_id;
        private Pred_TributoDataService TributoDataService = new Pred_TributoDataService();
        private Pred_PredioDataService Pred_PredioDataService = new Pred_PredioDataService();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_Descuentos_ExoneracionDataService pred_Descuentos_ExoneracionDataService = new Pred_Descuentos_ExoneracionDataService();
        private Pred_AnulacionDataService pred_AnulacionDataService = new Pred_AnulacionDataService();
        private MesDataService mess = new MesDataService();
        private List<Mes> mesese = new List<Mes>();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
        private Mant_Per_Cont mant_per_cont;
        private Mant_ContribuyenteDataService mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();

        public Frm_AnulacionDetalle()
        {
            InitializeComponent();
        }

        public Frm_AnulacionDetalle(String contribuyente_id)
        {
            InitializeComponent();
            this.contribuyente_id = contribuyente_id;
            llenarNombre();
        }

        public void llenarNombre()
        {
            mant_per_cont = mant_ContribuyenteDataService.listarDatosPersonales(contribuyente_id, 31);
            txtNombreCompleto.Text = mant_per_cont.departamento;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_AnulacionDetalle_Load(object sender, EventArgs e)
        {
            llenarPredios();
            cboPredio.Enabled = false;
            llenarAnioMes();
            rbEquivocacion.Checked = true;
        }

        private void llenarPredios()
        {
            cboPredio.ValueMember = "Predio_id";
            cboPredio.DisplayMember = "direccion_completa";
            cboPredio.DataSource = Pred_PredioDataService.listarPrediosxPersona(contribuyente_id);
        }
        
        private string MesName(int mes, string name)
        {
            switch (mes)
            {
                case 1:
                    name = "Ene ";
                    break;
                case 2:
                    name = "Feb ";
                    break;
                case 3:
                    name = "Mar ";
                    break;
                case 4:
                    name = "Abr ";
                    break;
                case 5:
                    name = "May ";
                    break;
                case 6:
                    name = "Jun ";
                    break;
                case 7:
                    name = "Jul ";
                    break;
                case 8:
                    name = "Ago ";
                    break;
                case 9:
                    name = "Set ";
                    break;
                case 10:
                    name = "Oct ";
                    break;
                case 11:
                    name = "Nov ";
                    break;
                case 12:
                    name = "Dic ";
                    break;
            }
            return name;
        }

        private void rbtArbitrio_CheckedChanged(object sender, EventArgs e)
        {
            cboPredio.Enabled = true;
        }

        private void rbtPredio_CheckedChanged(object sender, EventArgs e)
        {
            cboPredio.Enabled = false;
        }

        private void llenarAnioMes()
        {
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

        private void cboAnioIni_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void cboMesFin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtObservacion.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una observación.");

                string tributo_id = "";
                string predio_id = "";
                Pred_Descuentos_Exoneracion pred_Descuentos_Exoneracion = new Pred_Descuentos_Exoneracion();

                pred_Descuentos_Exoneracion.contribuyente_ID = contribuyente_id;
                pred_Descuentos_Exoneracion.anioInicio = Convert.ToInt16(cboAnioIni.SelectedValue.ToString());
                pred_Descuentos_Exoneracion.mesInicio = Convert.ToInt16(cboMesIni.SelectedValue.ToString());
                pred_Descuentos_Exoneracion.anioFin = Convert.ToInt16(cboAnioFin.SelectedValue.ToString());
                pred_Descuentos_Exoneracion.mesFin = Convert.ToInt16(cboMesFin.SelectedValue.ToString());
                if (rbtPredio.Checked == true)
                {
                    tributo_id = "0008";
                    predio_id = "0";
                }

                if (rbtArbitrio.Checked == true)
                {
                    tributo_id = "0043";
                    predio_id = cboPredio.SelectedValue.ToString().Trim();
                }

                if (rbtFormulario.Checked == true)
                {
                    tributo_id = "0016";
                    predio_id = "0";
                }

                pred_Descuentos_Exoneracion.tributo_ID = tributo_id;

                if (pred_Descuentos_ExoneracionDataService.ExisteCuentaCorrienteParaExoneracion(pred_Descuentos_Exoneracion.mesInicio,
                       pred_Descuentos_Exoneracion.anioInicio, pred_Descuentos_Exoneracion.mesFin, pred_Descuentos_Exoneracion.anioFin,
                       pred_Descuentos_Exoneracion.contribuyente_ID, pred_Descuentos_Exoneracion.tributo_ID) == 0)
                {
                    throw new Exception("No hay cuenta corriente en esas fechas para el contribuyente en ese tributo");
                }

                if (MessageBox.Show("¿Desea guardar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Pred_Anulacion pred_Anulacion = new Pred_Anulacion();
                    pred_Anulacion.tributos_id = tributo_id;
                    pred_Anulacion.observacion = txtObservacion.Text.Trim();
                    pred_Anulacion.anioInicio = Convert.ToInt16(cboAnioIni.SelectedValue.ToString());
                    pred_Anulacion.mesInicio = Convert.ToInt16(cboMesIni.SelectedValue.ToString());
                    pred_Anulacion.anioFin = Convert.ToInt16(cboAnioFin.SelectedValue.ToString());
                    pred_Anulacion.mesFin = Convert.ToInt16(cboMesFin.SelectedValue.ToString());
                    pred_Anulacion.registro_user_add = GlobalesV1.Global_str_Usuario;
                    string tipoAnulacion = "";
                    if (rbEquivocacion.Checked == true)
                        tipoAnulacion = "Q";
                    if (rbCancelado.Checked == true)
                        tipoAnulacion = "B";
                    if (rbReclamo.Checked == true)
                        tipoAnulacion = "R";

                    pred_Anulacion.tipoAnulacion = tipoAnulacion;
                    pred_Anulacion.persona_id = contribuyente_id;
                    pred_Anulacion.predio_id = predio_id;
                    int anulacion_id = 0;
                    anulacion_id = pred_AnulacionDataService.Insert(pred_Anulacion);

                    MessageBox.Show("Se Grabó Correctamente");

                    dgvMes.DataSource = pred_AnulacionDataService.listarxExoneracion(anulacion_id);
                    TotalTotal();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            
        }

        private void TotalTotal()
        {
            int cantidad;
            decimal total = 0, val;
            cantidad = dgvMes.RowCount;
            if (cantidad == 0)
                lblTotal.Text = "Total: 0";
            for (int i = 0; i < cantidad; i++)
            {
                val = Convert.ToDecimal((String)dgvMes.Rows[i].Cells["xTotal"].Value);
                total = total + val;
            }

            lblTotal.Text = "Total: " + total.ToString();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int anulacion_id = 0;
            dgvMes.DataSource = pred_AnulacionDataService.listarxExoneracion(anulacion_id);
            TotalTotal();
        }

        private void rbtFormulario_CheckedChanged(object sender, EventArgs e)
        {
            cboPredio.Enabled = false;
        }
    }
}
