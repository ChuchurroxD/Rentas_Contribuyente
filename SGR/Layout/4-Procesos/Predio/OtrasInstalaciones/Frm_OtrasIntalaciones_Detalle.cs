using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Service;
namespace SGR.WinApp.Layout._4_Procesos.Predio.OtrasInstalaciones
{
    public partial class Frm_OtrasIntalaciones_Detalle : Form
    {
        private Pred_OtrasInstalaciones pred_OtrasInstalaciones;
        private Pred_OtrasIntalacionesDataService OtrasInstalacionesDataService = new Pred_OtrasIntalacionesDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private String Predio_Idd = "";
        private String usser = GlobalesV1.Global_str_Usuario;
        private int periodo = 0;
        private int periodofin = 0;
        public Frm_OtrasIntalaciones_Detalle()
        {
            InitializeComponent();
            cargarDatos();
            visibleElem(false);
            this.Predio_Idd = "0";
        }
        public Frm_OtrasIntalaciones_Detalle(String idPredio, int periodoo)
        {
            InitializeComponent();
            cargarDatos();
            visibleElem(false);
            this.Predio_Idd = idPredio;
            this.periodo = periodoo;
        }
        public Frm_OtrasIntalaciones_Detalle(String idPredio, int periodoo, int periodofin)
        {
            InitializeComponent();
            cargarDatos();
            visibleElem(false);
            this.Predio_Idd = idPredio;
            this.periodo = periodoo;
            this.periodofin = periodofin;
        }
        public Frm_OtrasIntalaciones_Detalle(Pred_OtrasInstalaciones pred_OtrasInstalacioness, int periodoo)
        {
            InitializeComponent();
            cargarDatos();
            this.pred_OtrasInstalaciones = pred_OtrasInstalacioness;
            txtId.Text = pred_OtrasInstalaciones.PrediosOtras_id.ToString();
            txtObservacion.Text = pred_OtrasInstalaciones.Observacion;
            Decimal a = Convert.ToDecimal(pred_OtrasInstalaciones.CantidadValor);
            txtCantidad.Text = a.ToString();
            txtPredioId.Text = pred_OtrasInstalaciones.Predio_id;
            txtValor.Text = pred_OtrasInstalaciones.ValorOtras.ToString();
            visibleElem(true);
            ckbEStado.Checked = pred_OtrasInstalaciones.Estado;
            cboCategoria.SelectedValue = pred_OtrasInstalaciones.OtrasValor_id.ToString();
            this.periodo = periodoo;
            if (cboCategoria.SelectedIndex == -1)
                cboCategoria.SelectedIndex = 0;
        }
        //public Frm_OtrasIntalaciones_Detalle(Pred_OtrasInstalaciones pred_OtrasInstalacioness, String Predio_ID)
        //{
        //    InitializeComponent();
        //    cargarDatos();
        //    this.pred_OtrasInstalaciones = pred_OtrasInstalacioness;
        //    txtId.Text = pred_OtrasInstalaciones.PrediosOtras_id.ToString();
        //    txtObservacion.Text = pred_OtrasInstalaciones.Observacion;
        //    txtCantidad.Text = pred_OtrasInstalaciones.CantidadValor.ToString();
        //    txtPredioId.Text = Predio_ID;//pred_OtrasInstalaciones.Predio_id;
        //    txtValor.Text = pred_OtrasInstalaciones.ValorOtras.ToString();
        //    visibleElem(true);
        //    ckbEStado.Checked = pred_OtrasInstalaciones.Estado;
        //    cboCategoria.SelectedValue = pred_OtrasInstalaciones.OtrasValor_id.ToString();
        //}
        private void visibleElem(bool visi)
        {
            txtId.Visible = false;
            txtPredioId.Visible = false;
            ckbEStado.Visible = visi;
        }
        private void cargarDatos()
        {
            txtObservacion.MaxLength = 290;
            cboCategoria.DisplayMember = "Multc_vDescripcion";
            cboCategoria.ValueMember = "Multc_cValor";
            cboCategoria.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("2");
        }
        private string VerificarDato(String dato)
        {
            lblCantidad.ForeColor = System.Drawing.Color.Black;
            lblObservacion.ForeColor = System.Drawing.Color.Black;
            lblValor.ForeColor = System.Drawing.Color.Black;
            lblCategoria.ForeColor = System.Drawing.Color.Black;
            if (txtObservacion.Text.Trim().Length == 0)
            {
                dato = dato + "Observación, ";
                lblObservacion.ForeColor = System.Drawing.Color.Red;
            }
            if (txtValor.Text.Trim().Length == 0)
            {
                dato = dato + "Valor, ";
                lblValor.ForeColor = System.Drawing.Color.Red;
            }
            if (txtCantidad.Text.Trim().Length == 0)
            {
                dato = dato + "Cantidad";
                lblCantidad.ForeColor = System.Drawing.Color.Red;
            }
            if (cboCategoria.SelectedIndex == -1)
            {
                dato = dato + "Categoría";
                lblCategoria.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                String dato = VerificarDato("");
                if (dato.Trim().Length == 0)
                {
                    if (obValidacion.validaNumeroDecimalValido(txtCantidad.Text))
                    {

                        MessageBox.Show("La Cantidad debe ser diferente de 0", Globales.Global_MessageBox);
                        return;
                    }
                    if (obValidacion.validaNumeroDecimalValido(txtValor.Text))
                    {
                        MessageBox.Show("El Valor debe ser diferente de 0", Globales.Global_MessageBox);
                        return;
                    }

                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        Pred_OtrasInstalaciones Pred_OtrasInstalacione = new Pred_OtrasInstalaciones();
                        Pred_OtrasInstalacione.Observacion = txtObservacion.Text.TrimEnd();
                        Pred_OtrasInstalacione.CantidadValor = Convert.ToDecimal(txtCantidad.Text.Trim());
                        Pred_OtrasInstalacione.ValorOtras = Convert.ToDecimal(txtValor.Text.Trim());
                        Pred_OtrasInstalacione.OtrasValor_id = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
                        Pred_OtrasInstalacione.registro_user_add = usser;
                        if (txtId.Text.Trim().Length == 0)
                        {

                            Pred_OtrasInstalacione.Estado = true;
                            Pred_OtrasInstalacione.Predio_id = Predio_Idd;
                            //cantidad = OtrasInstalacionesRepository.GetExisteNuevo(Pred_OtrasInstalacione.Observacion);
                            //if (cantidad > 0)
                            //{
                            //    MessageBox.Show("Ya existe instalación en el Predio", Globales.Global_MessageBox);
                            //}
                            //else
                            //{
                            if (periodofin == 0)
                                OtrasInstalacionesDataService.Insert(Pred_OtrasInstalacione, periodo);
                            else
                                OtrasInstalacionesDataService.InsertVariosAños(Pred_OtrasInstalacione, periodo, periodofin);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);

                            //}

                            this.Close();
                        }
                        else
                        {
                            Pred_OtrasInstalacione.Estado = ckbEStado.Checked;
                            Pred_OtrasInstalacione.Predio_id = txtPredioId.Text.Trim();
                            Pred_OtrasInstalacione.PrediosOtras_id = Int32.Parse(txtId.Text.Trim());
                            //cantidad = OtrasInstalacionesRepository.GetExisteModificar(Pred_OtrasInstalacione.Observacion, Pred_OtrasInstalacione.PrediosOtras_id);
                            //if (cantidad > 0)
                            //{
                            //    MessageBox.Show("Ya existe instalación en el Predio", Globales.Global_MessageBox);
                            //}
                            //else
                            //{
                            OtrasInstalacionesDataService.Update(Pred_OtrasInstalacione, periodo);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            //}

                            pred_OtrasInstalaciones = null;

                            this.Close();
                        }
                    }
                }
                else MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtValor.Text, Globales.Global_MessageBox);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtCantidad.Text, Globales.Global_MessageBox);
        }

        private void txtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conf_Multitabla oonf_Multitabla = new Conf_Multitabla();
            oonf_Multitabla = (Conf_Multitabla)cboCategoria.SelectedItem;
            txtObservacion.Text = oonf_Multitabla.Multc_vDescripcion;
        }
    }
}
