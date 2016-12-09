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
namespace SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion
{

    public partial class Frm_Exoneracion_Detalle : Form
    {
        private Pred_PredioDataService Pred_PredioDataService = new Pred_PredioDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_Descuentos_ExoneracionDataService pred_Descuentos_ExoneracionDataService = new Pred_Descuentos_ExoneracionDataService();
        private Pred_TributoDataService TributoDataService = new Pred_TributoDataService();
        private MesDataService mess = new MesDataService();
        private List<Mes> mesese = new List<Mes>();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private Pred_DetalleExoneracionDataService DetalleExoneracionDataService = new Pred_DetalleExoneracionDataService();
        private Pred_PredioContribuyenteDataService PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private String resoluc = "";
        private string user = GlobalesV1.Global_str_Usuario;
        private int idExoneracion = 0;
        //public Frm_Exoneracion_Detalle()
        //{
        //    InitializeComponent();

        //    cargarcheckListTributo();
        //}
        public Frm_Exoneracion_Detalle(String id_per, String per_nombre)
        {
            InitializeComponent();
            //lblPeriodo.Text = periodo.ToString();
            cargarTipoSelector(id_per);
            lblNombre.Text = per_nombre;
            txtContribuyente_id.Text = id_per;
            ckbEstado.Checked = true;
            ckbEstado.Visible = false;
        }
        //private void cargarcheckListTributo(String Predio_Id)
        //{
        //    List<Pred_Tributo> lista= TributoDataService.listarTributoParaExoneracion(Predio_Id);
        //    for (int i = 0; i < lista.Count; i++)
        //      cklTributosExoneracion.Items.Add(lista[i].descripcion);

        //}
        public Frm_Exoneracion_Detalle(Pred_Descuentos_Exoneracion pred_Descuentos_Exoneracion, String id_per, String per_nombre)
        {
            InitializeComponent();
            cargarTipoSelector(id_per);
            OcultarEditar();
            CargarDatos(pred_Descuentos_Exoneracion, per_nombre, id_per);
            dgvMes.DataSource = DetalleExoneracionDataService.listarxExoneracion(pred_Descuentos_Exoneracion.des_exo_ID);
            TotalTotal();
        }
        private void CargarDatos(Pred_Descuentos_Exoneracion pred_Descuentos_Exoneracion, string nombre, String idper)
        {
            lblNombre.Text = nombre;
            cboPredio.SelectedValue = pred_Descuentos_Exoneracion.predio_ID;
            //txtcodigo.Text = pred_Descuentos_Exoneracion.codigo_exo;
            txtPorcentaje.Text = pred_Descuentos_Exoneracion.porcentaje_dcto.ToString();
            txtExpediente.Text = pred_Descuentos_Exoneracion.expediente;
            cboTipo.SelectedValue = pred_Descuentos_Exoneracion.tipo.ToString();
            cboTipoOperacion.SelectedValue = pred_Descuentos_Exoneracion.tipo_operacion.ToString();
            cboMotivo.SelectedValue = pred_Descuentos_Exoneracion.motivo.ToString();
            //txtCondicion_Id.Text = pred_Descuentos_Exoneracion.condicion.ToString();
            txtResolucion.Text = pred_Descuentos_Exoneracion.resolucion;
            resoluc = pred_Descuentos_Exoneracion.resol_imagen;
            //lblPeriodo.Text = pred_Descuentos_Exoneracion.anio.ToString();
            txtObservacion.Text = pred_Descuentos_Exoneracion.observaciones;
            ckbEstado.Checked = pred_Descuentos_Exoneracion.estado;
            //txtFormulario.Text = pred_Descuentos_Exoneracion.formularios.ToString();

            cboAnioIni.SelectedValue = Convert.ToInt32(pred_Descuentos_Exoneracion.anioInicio);
            cboMesIni.SelectedValue = pred_Descuentos_Exoneracion.mesInicio.ToString();
            cboAnioFin.SelectedValue = Convert.ToInt32(pred_Descuentos_Exoneracion.anioFin);
            cboMesFin.SelectedValue = pred_Descuentos_Exoneracion.mesFin.ToString();
            cboTributo.DisplayMember = "descripcion";
            cboTributo.ValueMember = "tributos_ID";
            cboTributo.DataSource = TributoDataService.listarTRibuto1y2Edit();
            cboTributo.SelectedValue = pred_Descuentos_Exoneracion.tributo_ID.Trim();
            idExoneracion = pred_Descuentos_Exoneracion.des_exo_ID;
            txtIdOculto.Text = pred_Descuentos_Exoneracion.des_exo_ID.ToString();
            lblNombre.Text = nombre;
            txtContribuyente_id.Text = idper;
        }
        private void btnResolucion_Click(object sender, EventArgs e)
        {
            ofdResolucion.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            ofdResolucion.Title = "Seleccione una imagen";
            ofdResolucion.ShowDialog();
        }
        private void cargarTipoSelector(String id_per)
        {
            llenarCboMultitabla(cboMotivo, "Multc_vDescripcion", "Multc_cValor", "10");
            llenarCboMultitabla(cboTipo, "Multc_vDescripcion", "Multc_cValor", "69");
            llenarCboMultitabla(cboTipoOperacion, "Multc_vDescripcion", "Multc_cValor", "44");
            cboPredio.ValueMember = "Predio_id";
            cboPredio.DisplayMember = "direccion_completa";
            cboPredio.DataSource = Pred_PredioDataService.listarPrediosxPersona(id_per);
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

            //cboTributo.DisplayMember = "descripcion";
            //cboTributo.ValueMember = "tributos_ID";
            //cboTributo.DataSource = TributoDataService.listarTributoTipo1y2();
        }
        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            try
            {
                cbo.DisplayMember = display;
                cbo.ValueMember = valor;
                cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private String verificarTextos(String dato)
        {
            if (txtExpediente.Text.Trim().Length == 0)
                dato = dato + " Expediente,";
            if (txtPorcentaje.Text.Trim().Length == 0)
                dato = dato + " Porcentaje,";
            //if (txtFormulario.Text.Trim().Length == 0)
            //    dato = dato + " Formulario,";
            if (txtResolucion.Text.Trim().Length == 0)
                dato = dato + " Nº Resolución,";
            return dato;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String dato = "";
                String msj = "";
                //if (resoluc.Trim().Length == 0)
                //{
                //    MessageBox.Show("Debe de subir un archivo de resolución",Globales.Global_MessageBox);
                //    return;
                //}
                if (resoluc.Trim().Length == 0)
                    msj = "Falta Resolución, Desea Guardar?";
                else
                    msj = "Desea Guardar?";
                if (cboTributo.SelectedIndex == -1 && txtIdOculto.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Falta llenar combo tributo", Globales.Global_MessageBox);
                    return;
                }
                Pred_Descuentos_Exoneracion pred_Descuentos_Exoneracion = new Pred_Descuentos_Exoneracion();
                dato = verificarTextos("");
                if (dato.Length != 0)
                {
                    MessageBox.Show("Falta llenar " + dato, Globales.Global_MessageBox);
                    return;
                }
                if (Convert.ToInt32(cboTipo.SelectedValue) == 1 && cboPredio.Items.Count != 1)
                {
                    MessageBox.Show("Debe tener solo un predio registrado", Globales.Global_MessageBox);
                    return;
                }
                if (Convert.ToInt32(cboTipo.SelectedValue) == 1 && cboPredio.Items.Count == 1 && !PredioContribuyenteDataService.obtenerSISePuedeExonerar(Convert.ToString(cboPredio.SelectedValue)))
                {
                    MessageBox.Show("SU predio vale mas que 50 UIT", Globales.Global_MessageBox);
                    return;
                }
                pred_Descuentos_Exoneracion.resolucion = txtResolucion.Text.Trim();
                pred_Descuentos_Exoneracion.resol_imagen = resoluc;
                pred_Descuentos_Exoneracion.observaciones = txtObservacion.Text;
                pred_Descuentos_Exoneracion.estado = ckbEstado.Checked;
                pred_Descuentos_Exoneracion.expediente = txtExpediente.Text.Trim();
                pred_Descuentos_Exoneracion.motivo = Convert.ToInt16(cboMotivo.SelectedValue);
                //VERIFICAR SI EXISTE CUENTA CORRIENTE
                if (txtIdOculto.Text.Trim().Length == 0)//nuevo
                {
                    pred_Descuentos_Exoneracion.contribuyente_ID = txtContribuyente_id.Text.Trim();
                    pred_Descuentos_Exoneracion.anioInicio = Convert.ToInt16(cboAnioIni.SelectedValue.ToString());
                    pred_Descuentos_Exoneracion.mesInicio = Convert.ToInt16(cboMesIni.SelectedValue.ToString());
                    pred_Descuentos_Exoneracion.anioFin = Convert.ToInt16(cboAnioFin.SelectedValue.ToString());
                    pred_Descuentos_Exoneracion.mesFin = Convert.ToInt16(cboMesFin.SelectedValue.ToString());
                    pred_Descuentos_Exoneracion.tributo_ID = cboTributo.SelectedValue.ToString();
                    if (pred_Descuentos_ExoneracionDataService.ExisteCuentaCorrienteParaExoneracion(pred_Descuentos_Exoneracion.mesInicio,
                        pred_Descuentos_Exoneracion.anioInicio, pred_Descuentos_Exoneracion.mesFin, pred_Descuentos_Exoneracion.anioFin,
                        pred_Descuentos_Exoneracion.contribuyente_ID, pred_Descuentos_Exoneracion.tributo_ID) == 0)
                    {
                        MessageBox.Show("No hay cuenta corriente en esas fechas para el contribuyente en ese tributo", Globales.Global_MessageBox);
                        return;
                    }
                    dato = pred_Descuentos_ExoneracionDataService.ExisteParametroParaExoneracion();
                    if (dato.Trim().Length != 0)
                    {
                        MessageBox.Show(dato, Globales.Global_MessageBox);
                        return;
                    }

                }
                if (MessageBox.Show(msj, Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtIdOculto.Text.Trim().Length == 0)//nuevo
                    {
                        pred_Descuentos_Exoneracion.tipo = Convert.ToInt16(cboTipo.SelectedValue);
                        pred_Descuentos_Exoneracion.tipo_operacion = Convert.ToInt16(cboTipoOperacion.SelectedValue);
                        pred_Descuentos_Exoneracion.porcentaje_dcto = Convert.ToDecimal(txtPorcentaje.Text);
                        //pred_Descuentos_Exoneracion.formularios = Convert.ToDecimal(txtFormulario.Text);
                        pred_Descuentos_Exoneracion.registro_user_add = user;

                        //if (String.Compare(cboTributo.SelectedValue.ToString().Trim(), "0008") == 0)
                        //{
                        //    pred_Descuentos_Exoneracion.predio_ID = "0";
                        //}
                        //else
                        //{
                        //    pred_Descuentos_Exoneracion.predio_ID = cboPredio.SelectedValue.ToString();
                        //}
                        pred_Descuentos_Exoneracion.predio_ID = cboPredio.SelectedValue.ToString();
                        idExoneracion = pred_Descuentos_ExoneracionDataService.Insert(pred_Descuentos_Exoneracion);
                        if (idExoneracion == 0)
                        {
                            MessageBox.Show("Ocurrio un error con la exoneraciòn", Globales.Global_MessageBox);
                            return;
                        }
                        dgvMes.DataSource = DetalleExoneracionDataService.listarxExoneracion(idExoneracion);
                        TotalTotal();
                        MessageBox.Show("Se Grabó correctamente", Globales.Global_MessageBox);
                    }
                    else//modificar
                    {
                        pred_Descuentos_Exoneracion.registro_user_update = user;
                        pred_Descuentos_Exoneracion.des_exo_ID = Convert.ToInt32(txtIdOculto.Text);
                        pred_Descuentos_ExoneracionDataService.Update(pred_Descuentos_Exoneracion);
                        this.Dispose();
                        MessageBox.Show("Se Grabó correctamente", Globales.Global_MessageBox);
                    }
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                }


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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private string subirImagen(string origen, string nombreArchivo)
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;
                //string destino = Globales.DireccionMapaCasa;// "D:\\sgr_11_05_2016\\SGR\\SGR\\Resources\\casamapa";
                string destino = System.IO.Directory.GetCurrentDirectory() + "\\resolucion";
                string cadena = fechaHoy.Year.ToString() + fechaHoy.Month.ToString() + fechaHoy.Day.ToString() +
                               fechaHoy.Hour.ToString() + fechaHoy.Minute.ToString() + fechaHoy.Second.ToString();
                if (!System.IO.Directory.Exists(destino))
                {
                    System.IO.Directory.CreateDirectory(destino);
                }
                System.IO.File.Copy(origen, destino + "\\" + cadena + nombreArchivo, true);
                return destino + "\\" + cadena + nombreArchivo;
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.ToString(), Globales.Global_MessageBox);
            }
            return "";
        }

        private void ofdResolucion_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                resoluc = subirImagen(ofdResolucion.FileName, ofdResolucion.SafeFileName);
                MessageBox.Show("Se subió correctamente la resolución");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
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
            CargarTributo();
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
            CargarTributo();
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
            CargarTributo();
        }
        private void cboMesFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTributo();
        }
        private void txtFormulario_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtPorcentaje.Text, Globales.Global_MessageBox);
        }
        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtPorcentaje.Text, Globales.Global_MessageBox);
        }
        private void OcultarEditar()
        {
            cboAnioFin.Enabled = false;
            cboAnioIni.Enabled = false;
            cboMesIni.Enabled = false;
            cboMesFin.Enabled = false;
            cboPredio.Enabled = false;
            cboTipo.Enabled = false;
            cboTributo.Enabled = false;
            cboTipoOperacion.Enabled = false;
            //txtFormulario.Enabled = false;
            txtPorcentaje.Enabled = false;


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
        private void CargarTributo()
        {
            try
            {
                if (cboAnioFin.SelectedValue != null || cboAnioIni.SelectedValue != null || cboMesIni.SelectedValue != null || cboMesFin.SelectedValue != null)
                {
                    cboTributo.DisplayMember = "descripcion";
                    cboTributo.ValueMember = "tributos_ID";
                    cboTributo.DataSource = TributoDataService.listarTributoTipo1y2(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(),
                    cboMesIni.SelectedValue.ToString(), cboMesFin.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                if (idExoneracion > 0)
                {
                    string observacion = "--";
                    if (txtObservacion.Text.Trim().Length != 0)
                    {
                        observacion = txtObservacion.Text;
                    }
                    Pred_Descuentos_Exoneracion Descuentos_Exoneracion = new Pred_Descuentos_Exoneracion();
                    Descuentos_Exoneracion = pred_Descuentos_ExoneracionDataService.GetByPrimaryKey(idExoneracion);
                    Conf_Multitabla conf_Multitabla = new Conf_Multitabla();
                    conf_Multitabla = (Conf_Multitabla)cboTipoOperacion.SelectedItem;
                    Pred_Tributo pred_Tributo = new Pred_Tributo();
                    pred_Tributo = (Pred_Tributo)cboTributo.SelectedItem;
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Exoneracion.Reporte_ExonIndiv.rdlc";
                    ReportParameter[] paramsx = new ReportParameter[19];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    paramsx[2] = new ReportParameter("Periodo", cboAnioIni.SelectedValue.ToString());
                    paramsx[3] = new ReportParameter("Titulo", conf_Multitabla.Multc_vDescripcion);
                    paramsx[4] = new ReportParameter("Numero", "2016");
                    paramsx[5] = new ReportParameter("Codigo", idExoneracion.ToString());
                    paramsx[6] = new ReportParameter("Contribuyente", lblNombre.Text);
                    paramsx[7] = new ReportParameter("Inicio", MesName(Convert.ToInt32(cboMesIni.SelectedValue), "") + cboAnioIni.SelectedValue.ToString());
                    paramsx[8] = new ReportParameter("Fin", MesName(Convert.ToInt32(cboMesFin.SelectedValue), "") + cboAnioFin.SelectedValue.ToString());
                    paramsx[9] = new ReportParameter("Observacion", observacion);
                    paramsx[10] = new ReportParameter("Item", "1");
                    paramsx[11] = new ReportParameter("ConceptoBaseImponible", Descuentos_Exoneracion.deduccion.ToString());
                    paramsx[12] = new ReportParameter("CodigoTributo", pred_Tributo.tributos_ID);
                    paramsx[13] = new ReportParameter("NombreTributo", pred_Tributo.descripcion);
                    paramsx[14] = new ReportParameter("BaseImponibleTributo", Descuentos_Exoneracion.base_imponible.ToString());
                    paramsx[15] = new ReportParameter("Formulario", Descuentos_Exoneracion.formularios.ToString());
                    paramsx[16] = new ReportParameter("ImpuestoAnual", "0");
                    paramsx[17] = new ReportParameter("MontoAfectado", Descuentos_Exoneracion.efec_descuento.ToString());
                    paramsx[18] = new ReportParameter("ConceptoDescripcion", conf_Multitabla.Multc_vDescripcion);
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
                else
                    MessageBox.Show("No hay exoneración", Globales.Global_MessageBox);
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
        private void cboTipoOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtPorcentaje.Text = "100";
            String TIPOoPE = cboTipoOperacion.SelectedValue.ToString();
            if (TIPOoPE == "1")//ES SOLO EXONERACION
            {
                txtPorcentaje.Enabled = true;
            }
            else
            {
                txtPorcentaje.Enabled = false;
            }
        }

        private void btnResolucionVer_Click(object sender, EventArgs e)
        {
            if (resoluc.Trim().Length != 0)
            {
                Frm_Resolucion Frm_Resolucion = new Frm_Resolucion(resoluc);//8832
                Frm_Resolucion.StartPosition = FormStartPosition.CenterParent;
                Frm_Resolucion.ShowDialog();
            }
            else
                MessageBox.Show("No hay resolución", Globales.Global_MessageBox);
        }

        //int i;
        //String s = "";
        //for (i = 0; i <= (cklTributosExoneracion.Items.Count - 1); i++)
        //{
        //    if (cklTributosExoneracion.GetItemChecked(i))
        //    {
        //        s = cklTributosExoneracion.Items[i].ToString();
        //        pred_Descuentos_Exoneracion.tributo_ID = s.Substring(0, 4);
        //        pred_Descuentos_ExoneracionDataService.Insert(pred_Descuentos_Exoneracion);
        //    }
        //}
    }
}
