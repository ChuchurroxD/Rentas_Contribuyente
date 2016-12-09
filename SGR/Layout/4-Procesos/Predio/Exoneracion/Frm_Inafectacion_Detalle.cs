using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion
{
    public partial class Frm_Inafectacion_Detalle : Form
    {
        private Pred_PredioContribuyenteDataService Pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        Decimal porcen;
        private String Predio_Idd = "";
        private int periodo = 0, caso = 0;
        private String usser = GlobalesV1.Global_str_Usuario, persona_id;

        public Frm_Inafectacion_Detalle()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {

                    cboPersona.Enabled = true;
                    if (caso == 1)
                    {
                        listarPersonaN(Predio_Idd, txtBusqueda.Text.TrimEnd());
                        cboPersona.SelectedValue = persona_id;
                    }
                    else if (caso == 2)
                    {
                        listarPersonaN(Predio_Idd, txtBusqueda.Text.TrimEnd());
                    }
                    else if
                        (caso == 3)
                    {
                        listarPersonaM(Predio_Idd, persona_id, txtBusqueda.Text.TrimEnd());
                        cboPersona.SelectedValue = persona_id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void listarTipoSelector()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            //llenarCboMultitabla(cboTipoAdquisicion, "Multc_vDescripcion", "Multc_cValor", "4");
            //llenarCboMultitabla(cboTipoPosesion, "Multc_vDescripcion", "Multc_cValor", "18");
            //llenarCboMultitabla(cboTipoContribuyente, "Multc_vDescripcion", "Multc_cValor", "75");
        }
        private void listarPersona()
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentes("");
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void listarPersonaN(String predio_id, string busqueda)
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentesPN(predio_id, periodo, busqueda); ;
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void listarPersonaM(String predio_id, String per_id, string busqueda)
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentesPM(predio_id, periodo, per_id, busqueda);
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
