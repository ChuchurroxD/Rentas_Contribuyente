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
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Adeudo
{
    public partial class Frm_Adeudo : DockContent
    {
        private String per_id_global;
        private String pred_id_global;
        private Pred_ConstanciaAdeudoDataService ConstanciaAdeudoDataService = new Pred_ConstanciaAdeudoDataService();
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        private Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private string usser = GlobalesV1.Global_str_Usuario;
        private Pred_ConstanciaNoDebeDataService ConstanciaNoDebeDataService = new Pred_ConstanciaNoDebeDataService();
        private int idCOnstancia = 0;
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Mant_ContribuyenteDataService Mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        private Pred_PredioDataService Pred_PredioDataService = new Pred_PredioDataService();
        public Frm_Adeudo()
        {
            try
            {

                InitializeComponent();
                txtObligacion.MaxLength = 995;
                txtDescripcion.MaxLength = 995;
                txtTramiteImporte.MaxLength = 19;
                txtTramiteRecibo.MaxLength = 19;
                comboBusquedaAnio.DisplayMember = "Peric_canio";
                comboBusquedaAnio.ValueMember = "Peric_canio";
                comboBusquedaAnio.DataSource = mant_PeriodoDataService.llenarPeriodo();
                cboAnioPredial.DisplayMember = "Peric_canio";
                cboAnioPredial.ValueMember = "Peric_canio";
                cboAnioPredial.DataSource = mant_PeriodoDataService.llenarPeriodo();
                DateTime fechaHoy = DateTime.Now;
                comboBusquedaAnio.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                txtTransferencia.Text = ConstanciaNoDebeDataService.getTransferencia();
            }
            catch (Exception ex)
            {
                //MessageBox.Show()
            }
            ////dgvArbitrios.DataSource = ConstanciaAdeudoDataService.listarDeuda("1", "0043", "2011035800261001", "2");
            //dgvPredios.DataSource = ConstanciaAdeudoDataService.listarDeuda("1", "0008", "0", "1");
            ////sumarTotal(dgvArbitrios, "xTotalArbitrios", lblTotalArbitrios);
            //sumarTotal(dgvPredios, "xTotalPredial", lblTotalPredial);
        }
        public Frm_Adeudo(String per_id, String pred_id, String direccion, String per_nombre)
        {
            InitializeComponent();
            this.per_id_global = per_id;
            this.pred_id_global = pred_id;
            //txtDireccion.Text = direccion;
            //txtContribuyente.Text = per_nombre;
            //dgvArbitrios.DataSource = ConstanciaAdeudoDataService.listarDeuda(per_id_global, "0043", pred_id, "2");
            dgvPredios.DataSource = ConstanciaAdeudoDataService.listarDeuda(per_id_global, "0008", "0", "1");
            //sumarTotal(dgvArbitrios, "xTotalArbitrios", lblTotalArbitrios);
            sumarTotal(dgvPredios, "xTotalPredial", lblTotalPredial);
            rbtP.Checked = true;
        }
        private void sumarTotal(DataGridView dgv, String check, Label lbl)
        {
            try
            {
                int cantidad;
                cantidad = dgv.RowCount;
                decimal valor = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgv.Rows[i];
                    valor = (decimal)row.Cells[check].Value;

                }
                lbl.Text = valor.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show()
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboPersona.Enabled = true;
                    cboPersona.DisplayMember = "persona_Desc";
                    cboPersona.ValueMember = "persona_ID";
                    if (rbtRazonSocial.Checked)
                        cboPersona.DataSource = persona.listarcontribuyentes(txtBusqueda.Text.TrimEnd());
                    else
                        cboPersona.DataSource = persona.listarcontribuyentesCodigo(txtBusqueda.Text.Trim());
                    this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtBusqueda.Text.Trim().Length > 0)
                {

                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPersona.SelectedIndex != -1)
                {
                    dgvPredios.DataSource = ConstanciaAdeudoDataService.listarDeuda(cboPersona.SelectedValue.ToString(), "0008", "0", "1");
                    sumarTotal(dgvPredios, "xTotalPredial", lblTotalPredial);
                    dgvAlcabalListado.DataSource = Certificado_AlcabalaDataService.listarPagadosxPersona(Convert.ToInt16(comboBusquedaAnio.SelectedValue), cboPersona.SelectedValue.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBusquedaAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPersona.SelectedIndex != -1)
                    dgvAlcabalListado.DataSource = Certificado_AlcabalaDataService.listarPagadosxPersona(Convert.ToInt16(comboBusquedaAnio.SelectedValue), cboPersona.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbtP_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Clear();
            this.tabControl1.Controls.Add(this.tbpPredial);
            string obli;
            txtDescripcion.Text = "";
            if (dgvPredio.SelectedRows.Count == 0)
            {
                obli = "NO PRESENTA OBLIGACIONES TRIBUTARIAS PENDIENTES  DE PAGO POR CONCEPTO DE IMPUESTO  AL PATRIMONIO PREDIAL CORRESPONDIENTE AL INMUEBLE UBICADO EN JURISDICCIÓN DEL DISTRITO DE MOCHE, PROVINCIA DE TRUJIILLO, DEPARTAMENTO DE LA LIBERTAD ";

            }
            else
            {
                string direccion = (string)dgvPredio.SelectedRows[0].Cells["direccion_completa_"].Value;
                decimal areaterr = (decimal)dgvPredio.SelectedRows[0].Cells["area_terreno"].Value;
                string nombre_predio = (string)dgvPredio.SelectedRows[0].Cells["nombre_predio"].Value;
                obli = "NO PRESENTA OBLIGACIONES TRIBUTARIAS PENDIENTES  DE PAGO POR CONCEPTO DE IMPUESTO  AL PATRIMONIO PREDIAL CORRESPONDIENTE AL INMUEBLE UBICADO EN " +
                   direccion + " CON NOMBRE '" + nombre_predio + "' CON ÁREA DE " + areaterr +
                   "JURISDICCIÓN DEL DISTRITO DE MOCHE, PROVINCIA DE TRUJIILLO, DEPARTAMENTO DE LA LIBERTAD ";

            }
            txtObligacion.Text = obli;
        }

        private void rbtAlcala_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Clear();
            this.tabControl1.Controls.Add(this.tbpAlcabala);
            if (dgvAlcabalListado.SelectedRows.Count > 0)
            {
                string vendedor_name = (string)dgvAlcabalListado.SelectedRows[0].Cells["vendedor_name"].Value;
                string comprador_name = (string)dgvAlcabalListado.SelectedRows[0].Cells["comprador_name"].Value;
                decimal area = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["area"].Value;
                decimal condomino = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["condomino"].Value;
                string direccion_completa = (string)dgvAlcabalListado.SelectedRows[0].Cells["direccion_completa"].Value;
                DateTime fecha_tramite = (DateTime)dgvAlcabalListado.SelectedRows[0].Cells["fecha_tramite"].Value;

                txtDescripcion.Text = "LA ADQUISICIÓN DEL REFERIDO INMUEBLE PROVIENE DE MINUTA....................................." +
                " QUE CELEBRAN UNA PARTE SR(A) " + vendedor_name +
                " QUIEN EN ADELANTE SE LE DENOMINARÁ EL VENDEDOR Y DE OTRA PARTE SR(A) " + comprador_name +
                " QUIEN(ES) EN ADELANTE SE LES(S) DENOMINARÁ EL COMPRADOR DE FECHA " + fecha_tramite.ToString();
                txtObligacion.Text = "NO PRESENTA OBLIGACIONES TRIBUTARIAS PENDIENTE DE PAGO POR CONCEPTO DE IMPUESTO DE ALCABALA " +
                    "CORRESPONDIENTE AL INMUEBLE UBICADO " + direccion_completa + " CON UN ÁREA DE " + (area).ToString() + ",JURISDICCIÓN DEL DISTRITO DE MOCHE, " +
                "PROVINCIA DE TRUJIILLO, DEPARTAMENTO DE LA LIBERTAD.";

            }
            else
            {
                txtDescripcion.Text = "LA ADQUISICIÓN DEL REFERIDO INMUEBLE PROVIENE DE MINUTA....................................." +
                    " QUE CELEBRAN UNA PARTE SR(A)............................................................." +
                    " QUIEN EN ADELANTE SE LE DENOMINARÁ....................Y DE OTRA PARTE SR(A)..............." +
                    " QUIEN(ES) EN ADELANTE SE LES(S) DENOMINARÁ.............LA ASOCIACIÓN DE FECHA ";
                txtObligacion.Text = "NO PRESENTA OBLIGACIONES TRIBUTARIAS PENDIENTE DE PAGO POR CONCEPTO DE IMPUESTO DE ALCABALA CORRESPONDIENTE AL INMUEBLE UBICADO ";

            }

        }

        private string verificar(string dato)
        {
            //lblAño.ForeColor = System.Drawing.Color.Black;
            lblContribuyente.ForeColor = System.Drawing.Color.Black;
            lblExpediente.ForeColor = System.Drawing.Color.Black;
            //lblTransferencia.ForeColor = System.Drawing.Color.Black;
            //if (txtAño.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Año, ";
            //    lblAño.ForeColor = System.Drawing.Color.Red;
            //}
            if (cboPersona.SelectedIndex == -1)
            {
                dato = dato + "Contribuyente, ";
                lblContribuyente.ForeColor = System.Drawing.Color.Red;
            }
            if (txtExpediente.Text.Trim().Length == 0)
            {
                dato = dato + "Expediente";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtTransferencia.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Transferencia, ";
            //    lblTransferencia.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtTramiteImporte.Text.Trim().Length == 0)
            {
                dato = dato + "Importe de trámite, ";
                lblTramiteImporte.ForeColor = System.Drawing.Color.Red;
            }
            if (txtTramiteRecibo.Text.Trim().Length == 0)
            {
                dato = dato + "Recibo de trámite, ";
                lblTramiteRecibo.ForeColor = System.Drawing.Color.Red;
            }
            if (txtImpuestoImporte.Text.Trim().Length == 0)
            {
                dato = dato + "Importe de Impuesto, ";
                lblImpuestoImporte.ForeColor = System.Drawing.Color.Red;
            }
            if (txtImpuestoRecibo.Text.Trim().Length == 0)
            {
                dato = dato + "Recibo de Impuesto ";
                lblImpuestoRecibo.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnGenerarContanciaPre_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = verificar("");
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
                    return;
                }
                if (cboPersona.SelectedIndex != -1 && dgvPredios.RowCount == 0)
                {

                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Pred_ConstanciaNoDebe ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
                        //ConstanciaNoDebe.CompraVenta = Convert.ToDecimal(txtPorcentajeContenido.Text.Trim());
                        //ConstanciaNoDebe.a = txtAño.Text; ConstanciaNoDebe;
                        ConstanciaNoDebe.Descripcion = txtDescripcion.Text;
                        ConstanciaNoDebe.estado = ckbEstado.Checked;
                        ConstanciaNoDebe.Expediente = txtExpediente.Text;
                        //ConstanciaNoDebe.idPeriodo = PeriodoDataService.GetPeriodoActivo();
                        ConstanciaNoDebe.idPeriodo = Convert.ToInt32(cboAnioPredial.SelectedValue.ToString().Trim());
                        ConstanciaNoDebe.IdPersona = cboPersona.SelectedValue.ToString();
                        ConstanciaNoDebe.ImpuestoImporte = Convert.ToDecimal(txtImpuestoImporte.Text);
                        ConstanciaNoDebe.ImpuestoRecibo = txtImpuestoRecibo.Text;
                        ConstanciaNoDebe.Obligacion = txtObligacion.Text;
                        ConstanciaNoDebe.registro_user_add = usser;
                        ConstanciaNoDebe.registro_user_update = usser;
                        //ConstanciaNoDebe.Saldo = txtAño.Text;
                        //ConstanciaNoDebe.Tipo = txtAño.Text;
                        ConstanciaNoDebe.TramiteImporte = Convert.ToDecimal(txtTramiteImporte.Text);
                        ConstanciaNoDebe.TramiteRecibo = txtTramiteRecibo.Text;
                        ConstanciaNoDebe.Transferencia = txtTransferencia.Text.Trim();
                        if (dgvPredio.SelectedRows.Count > 0)
                            ConstanciaNoDebe.idPredio = (string)dgvPredio.SelectedRows[0].Cells["predio_ID_"].Value;
                        else
                            ConstanciaNoDebe.idPredio = "0";
                        //ConstanciaNoDebe.UIT = txtAño.Text;
                        //ConstanciaNoDebe.Valuo = txtAño.Text;
                        idCOnstancia = ConstanciaNoDebeDataService.InsertP(ConstanciaNoDebe);
                        txtBusqueda.Enabled = false;
                        BtnBuscar.Enabled = false;
                        cboPersona.Enabled = false;
                        btnGenerarContanciaPre.Enabled = false;
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                        this.Dispose();
                    }
                }
                else
                    MessageBox.Show("Hay deuda pendiente", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnVerConstancia_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (idCOnstancia > 0)
                {
                    Predialrpt("Usuario");
                    //Predialrpt("Municipalidad");
                    //Predialrpt("Notaria");
                }
                else
                    MessageBox.Show("No hay alcabala generada", Globales.Global_MessageBox);
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

        private void btnGenerarConstanciaAlcabala_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = verificar("");
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
                    return;
                }
                if (cboPersona.SelectedIndex != -1 && dgvAlcabalListado.SelectedRows.Count > 0)
                {

                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Pred_ConstanciaNoDebe ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
                        //ConstanciaNoDebe.CompraVenta = Convert.ToDecimal(txtPorcentajeContenido.Text.Trim());
                        //ConstanciaNoDebe.a = txtAño.Text; ConstanciaNoDebe;
                        ConstanciaNoDebe.Descripcion = txtDescripcion.Text;
                        ConstanciaNoDebe.estado = ckbEstado.Checked;
                        ConstanciaNoDebe.Expediente = txtExpediente.Text;
                        ConstanciaNoDebe.idPeriodo = PeriodoDataService.GetPeriodoActivo();
                        ConstanciaNoDebe.IdPersona = cboPersona.SelectedValue.ToString();
                        ConstanciaNoDebe.ImpuestoImporte = Convert.ToDecimal(txtImpuestoImporte.Text);
                        ConstanciaNoDebe.ImpuestoRecibo = txtImpuestoRecibo.Text;
                        ConstanciaNoDebe.Obligacion = txtObligacion.Text;
                        ConstanciaNoDebe.registro_user_add = usser;
                        ConstanciaNoDebe.registro_user_update = usser;
                        //ConstanciaNoDebe.Saldo = txtAño.Text;
                        //ConstanciaNoDebe.Tipo = txtAño.Text;
                        ConstanciaNoDebe.TramiteImporte = Convert.ToDecimal(txtTramiteImporte.Text);
                        ConstanciaNoDebe.TramiteRecibo = txtTramiteRecibo.Text;
                        ConstanciaNoDebe.Transferencia = txtTransferencia.Text.Trim();
                        ConstanciaNoDebe.idPredio = (string)dgvAlcabalListado.SelectedRows[0].Cells["predio_id"].Value;
                        ConstanciaNoDebe.idAlcabala = (int)dgvAlcabalListado.SelectedRows[0].Cells["certalcabala_id"].Value;
                        //ConstanciaNoDebe.UIT = txtAño.Text;
                        //ConstanciaNoDebe.Valuo = txtAño.Text;
                        idCOnstancia = ConstanciaNoDebeDataService.InsertA(ConstanciaNoDebe);
                        txtBusqueda.Enabled = false;
                        BtnBuscar.Enabled = false;
                        cboPersona.Enabled = false;
                        btnGenerarConstanciaAlcabala.Enabled = false;
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                    }
                }
                else
                    MessageBox.Show("No hay alcabla generada", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }

        private void btnVerConstanciaAlcabala_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (idCOnstancia > 0)
                {
                    Alcabalarpt("Usuario");
                    //Alcabalarpt("Notaria");
                    //Alcabalarpt("Municipalidad");
                }
                else
                    MessageBox.Show("No hay alcabala generada", Globales.Global_MessageBox);
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

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTodos.Checked)
                cargarPredios();
        }

        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
                cargarPredios();
        }

        private void cboAnioPredial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cargarPredios();
            }
            catch (Exception ex)
            {
            }
        }
        private void cargarPredios()
        {
            try
            {
                if (cboPersona.SelectedIndex != -1)
                {
                    int tipo;
                    if (rbtActivos.Checked)
                        tipo = 28;
                    else
                        tipo = 29;
                    dgvPredio.DataSource = Pred_PredioDataService.listarParaCtaAdeudo(tipo, cboPersona.SelectedValue.ToString(), cboAnioPredial.SelectedValue.ToString());

                }
                else
                    dgvPredio.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }


        }

        private void dgvAlcabalListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (rbtAlcala.Checked)
                {
                    string vendedor_name = (string)dgvAlcabalListado.SelectedRows[0].Cells["vendedor_name"].Value;
                    string comprador_name = (string)dgvAlcabalListado.SelectedRows[0].Cells["comprador_name"].Value;
                    decimal area = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["area"].Value;
                    decimal condomino = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["condomino"].Value;
                    string direccion_completa = (string)dgvAlcabalListado.SelectedRows[0].Cells["direccion_completa"].Value;
                    DateTime fecha_tramite = (DateTime)dgvAlcabalListado.SelectedRows[0].Cells["fecha_tramite"].Value;

                    txtDescripcion.Text = "LA ADQUISICIÓN DEL REFERIDO INMUEBLE PROVIENE DE MINUTA....................................." +
                    " QUE CELEBRAN UNA PARTE SR(A) " + vendedor_name +
                    " QUIEN EN ADELANTE SE LE DENOMINARÁ EL VENDEDOR Y DE OTRA PARTE SR(A) " + comprador_name +
                    " QUIEN(ES) EN ADELANTE SE LES(S) DENOMINARÁ EL COMPRADOR DE FECHA " + fecha_tramite.ToString();
                    txtObligacion.Text = "NO PRESENTA OBLIGACIONES TRIBUTARIAS PENDIENTS DE PAGO POR CONCEPTO DE IMPUESTO DE ALCABALA " +
                        "CORRESPONDIENTE AL INMUEBLE UBICADO " + direccion_completa + " CON UN ÁREA DE " + (area).ToString() + ",JURISDICCIÓN DEL DISTRITO DE MOCHE, " +
                    "PROVINCIA DE TRUJIILLO, DEPARTAMENTO DE LA LIBERTAD.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (rbtP.Checked)
                {
                    string obli;
                    txtDescripcion.Text = "";

                    string direccion = (string)dgvPredio.SelectedRows[0].Cells["direccion_completa_"].Value;
                    decimal areaterr = (decimal)dgvPredio.SelectedRows[0].Cells["area_terreno"].Value;
                    string nombre_predio = (string)dgvPredio.SelectedRows[0].Cells["nombre_predio"].Value;
                    obli = "NO PRESENTA OBLIGACIONES TRIBUTARIAS PENDIENTES  DE PAGO POR CONCEPTO DE IMPUESTO  AL PATRIMONIO PREDIAL CORRESPONDIENTE AL INMUEBLE UBICADO EN" +
                       direccion + " CON NOMBRE '" + nombre_predio + "' CON ÁREA DE " + areaterr +
                       "JURISDICCIÓN DEL DISTRITO DE MOCHE, PROVINCIA DE TRUJIILLO, DEPARTAMENTO DE LA LIBERTAD ";

                    txtObligacion.Text = obli;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
        private void Alcabalarpt(string pie)
        {

            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            Pred_ConstanciaNoDebe Pred_ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
            Mant_Per_Cont ant_Per_Cont = new Mant_Per_Cont();
            Mant_Per_Cont conyuge_Per_Cont = new Mant_Per_Cont();
            Mant_Per_Cont rep_Per_Cont = new Mant_Per_Cont();
            ant_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(cboPersona.SelectedValue.ToString(), 31);
            conyuge_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(cboPersona.SelectedValue.ToString(), 32);
            rep_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(cboPersona.SelectedValue.ToString(), 33);
            Pred_ConstanciaNoDebe = ConstanciaNoDebeDataService.getByPrimaryKey(idCOnstancia);
            Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
            Certificado_Alcabala = Certificado_AlcabalaDataService.GetByPrimaryKey(Pred_ConstanciaNoDebe.idAlcabala);
            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
            frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Alcabala.rdlc";
            ReportParameter[] paramsx = new ReportParameter[28];

            paramsx[0] = new ReportParameter("Nombre", ant_Per_Cont.departamento);
            paramsx[1] = new ReportParameter("Documento", ant_Per_Cont.documento);
            paramsx[2] = new ReportParameter("DireccionFiscal", ant_Per_Cont.provincia);
            //paramsx[0] = new ReportParameter("Nombre", Certificado_Alcabala.comprador_name);
            //paramsx[1] = new ReportParameter("Documento", Certificado_Alcabala.documento);
            //paramsx[2] = new ReportParameter("DireccionFiscal", Certificado_Alcabala.OtraDireccion);
            paramsx[3] = new ReportParameter("Valuo", Certificado_Alcabala.valuo.ToString());
            paramsx[4] = new ReportParameter("CompraVenta", Certificado_Alcabala.valor_venta.ToString());
            paramsx[5] = new ReportParameter("Terreno", Certificado_Alcabala.valorTerreno.ToString());
            paramsx[6] = new ReportParameter("UITAlcabala", Certificado_Alcabala.uits.ToString());
            paramsx[7] = new ReportParameter("Saldo", Certificado_Alcabala.valor_afecto.ToString());
            paramsx[8] = new ReportParameter("Impuesto", Certificado_Alcabala.alcabala.ToString());
            paramsx[9] = new ReportParameter("NroConstancia", Pred_ConstanciaNoDebe.Transferencia.ToString());
            paramsx[10] = new ReportParameter("CodigoPredial", Pred_ConstanciaNoDebe.idPredio);
            paramsx[11] = new ReportParameter("DireccionPredio", Certificado_Alcabala.direccion_completa);
            paramsx[12] = new ReportParameter("AreaTotal", (Certificado_Alcabala.area * Certificado_Alcabala.condomino / 100).ToString());
            paramsx[13] = new ReportParameter("FechaMinuta", Certificado_Alcabala.fecha_tramite.ToString());
            paramsx[14] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
            paramsx[15] = new ReportParameter("Obligacion", Pred_ConstanciaNoDebe.Obligacion);
            paramsx[16] = new ReportParameter("Descripcion", Pred_ConstanciaNoDebe.Descripcion);
            paramsx[17] = new ReportParameter("ImpuestoRecibo", Pred_ConstanciaNoDebe.ImpuestoRecibo.ToString());
            paramsx[18] = new ReportParameter("TramiteRecibo", Pred_ConstanciaNoDebe.TramiteRecibo);
            paramsx[19] = new ReportParameter("Expediente", Pred_ConstanciaNoDebe.Expediente);
            if (conyuge_Per_Cont == null)
            {

                //--conyuge_Per_Cont
                paramsx[20] = new ReportParameter("NombreCon", "-");
                paramsx[21] = new ReportParameter("DocumentoCon", "-");
                paramsx[22] = new ReportParameter("DireccionFiscalCon", "-");
            }
            else
            {
                //--conyuge_Per_Cont
                paramsx[20] = new ReportParameter("NombreCon", conyuge_Per_Cont.departamento);
                paramsx[21] = new ReportParameter("DocumentoCon", conyuge_Per_Cont.documento);
                paramsx[22] = new ReportParameter("DireccionFiscalCon", conyuge_Per_Cont.provincia);

            }
            if (rep_Per_Cont == null)
            {
                //representante
                paramsx[23] = new ReportParameter("NombreRep", "-");
                paramsx[24] = new ReportParameter("DocumentoRep", "-");
                paramsx[25] = new ReportParameter("DireccionFiscalRep", "-");
            }
            else
            {

                //representante
                paramsx[23] = new ReportParameter("NombreRep", rep_Per_Cont.departamento);
                paramsx[24] = new ReportParameter("DocumentoRep", rep_Per_Cont.documento);
                paramsx[25] = new ReportParameter("DireccionFiscalRep", rep_Per_Cont.provincia);

            }

            paramsx[26] = new ReportParameter("Pie", pie);
            paramsx[27] = new ReportParameter("CodigoPersona", cboPersona.SelectedValue.ToString());
            frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
            frm_Visor_Global.reportViewer1.RefreshReport();
            frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
            frm_Visor_Global.ShowDialog();
        }
        private void Predialrpt(string pie)
        {

            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            Mant_Per_Cont ant_Per_Cont = new Mant_Per_Cont();
            Mant_Per_Cont conyuge_Per_Cont = new Mant_Per_Cont();
            Mant_Per_Cont rep_Per_Cont = new Mant_Per_Cont();

            Pred_ConstanciaNoDebe Pred_ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
            ant_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(cboPersona.SelectedValue.ToString(), 31);
            conyuge_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(cboPersona.SelectedValue.ToString(), 32);
            rep_Per_Cont = Mant_ContribuyenteDataService.listarDatosPersonales(cboPersona.SelectedValue.ToString(), 33);
            Pred_ConstanciaNoDebe = ConstanciaNoDebeDataService.getByPrimaryKey(idCOnstancia);
            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
            frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Predial.rdlc";
            ReportParameter[] paramsxf = new ReportParameter[23];
            paramsxf[0] = new ReportParameter("Nombre", ant_Per_Cont.departamento);
            paramsxf[1] = new ReportParameter("Documento", ant_Per_Cont.documento);
            paramsxf[2] = new ReportParameter("DireccionFiscal", ant_Per_Cont.provincia);
            paramsxf[3] = new ReportParameter("NroConstancia", Pred_ConstanciaNoDebe.Transferencia.ToString());
            paramsxf[4] = new ReportParameter("CodigoPredial", Pred_ConstanciaNoDebe.idPredio);
            paramsxf[5] = new ReportParameter("DireccionPredio", "");
            paramsxf[6] = new ReportParameter("AreaTotal", "");
            paramsxf[7] = new ReportParameter("FechaMinuta", "");
            paramsxf[8] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
            paramsxf[9] = new ReportParameter("Obligacion", Pred_ConstanciaNoDebe.Obligacion);
            paramsxf[10] = new ReportParameter("Descripcion", Pred_ConstanciaNoDebe.Descripcion);
            paramsxf[11] = new ReportParameter("ImpuestoRecibo", Pred_ConstanciaNoDebe.ImpuestoRecibo.ToString());
            paramsxf[12] = new ReportParameter("TramiteRecibo", Pred_ConstanciaNoDebe.TramiteRecibo);
            paramsxf[13] = new ReportParameter("Expediente", Pred_ConstanciaNoDebe.Expediente);
            if (conyuge_Per_Cont == null)
            {

                //--conyuge_Per_Cont
                paramsxf[14] = new ReportParameter("NombreCon", "-");
                paramsxf[15] = new ReportParameter("DocumentoCon", "-");
                paramsxf[16] = new ReportParameter("DireccionFiscalCon", "-");
            }
            else
            {

                //--conyuge_Per_Cont
                paramsxf[14] = new ReportParameter("NombreCon", conyuge_Per_Cont.departamento);
                paramsxf[15] = new ReportParameter("DocumentoCon", conyuge_Per_Cont.documento);
                paramsxf[16] = new ReportParameter("DireccionFiscalCon", conyuge_Per_Cont.provincia);
            }
            if (rep_Per_Cont == null)
            {
                //representante
                paramsxf[17] = new ReportParameter("NombreRep", "-");
                paramsxf[18] = new ReportParameter("DocumentoRep", "-");
                paramsxf[19] = new ReportParameter("DireccionFiscalRep", "-");
            }
            else
            {

                //representante
                paramsxf[17] = new ReportParameter("NombreRep", rep_Per_Cont.departamento);
                paramsxf[18] = new ReportParameter("DocumentoRep", rep_Per_Cont.documento);
                paramsxf[19] = new ReportParameter("DireccionFiscalRep", rep_Per_Cont.provincia);
            }
            paramsxf[20] = new ReportParameter("Pie", pie);
            paramsxf[21] = new ReportParameter("Periodo", Pred_ConstanciaNoDebe.idPeriodo.ToString());

            paramsxf[22] = new ReportParameter("CodigoPersona", cboPersona.SelectedValue.ToString());
            frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsxf);
            frm_Visor_Global.reportViewer1.RefreshReport();
            frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
            frm_Visor_Global.ShowDialog();


        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtCod_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void rbtRazonSocial_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void btnCancelarPre_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelarAlcabala_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
