using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Entity.Model;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using SGR.WinApp.Layout._4_Procesos.Fraccionamiento.TipoFraccionamiento;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento
{
    public partial class Frm_FraccionamientoDetalle : Form
    {
        int codi=0;
        private Trib_TipoFraccionamientoDataService trib_TipoFraccionamiento = new Trib_TipoFraccionamientoDataService();
        private Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private Trib_TipoFraccionamientoDataService tipoFracc = new Trib_TipoFraccionamientoDataService();
        private List<Mant_Periodo> periodo = new List<Mant_Periodo>();
        public Frm_FraccionamientoDetalle()
        {
            InitializeComponent();
            cargarCombos();
        }
        public void cargarCombos()
        {
            periodo= periodos.GetAllMant_Periodo();
            cboAnioIni.DisplayMember = "Peric_canio";
            cboAnioIni.ValueMember = "Peric_canio";
            cboAnioIni.DataSource = periodo;

            cboAnioFin.DisplayMember = "Peric_canio";
            cboAnioFin.ValueMember = "Peric_canio";
            cboAnioFin.DataSource = periodo;

            cboModalidad.DisplayMember = "Multc_vDescripcion";
            cboModalidad.ValueMember = "Multc_cValor";
            cboModalidad.DataSource = tablas.GetCboConf_Multitabla("47");
        }
        public Frm_FraccionamientoDetalle(Trib_TipoFraccionamiento tributoFracc,int codigo)
        {
            InitializeComponent();
            this.codi = codigo;
            cargarCombos();
            
            cboAnioIni.SelectedValue = Convert.ToInt32(tributoFracc.TiFr_anio_inicio);
            cboAnioFin.SelectedValue = Convert.ToInt32(tributoFracc.TiFr_anio_fin);
            cboModalidad.SelectedValue = tributoFracc.TiFr_modalidad.Trim();

            txtBaseLegal.Text = tributoFracc.TiFr_base_legal;
            txtCuotaIni.Text = Convert.ToString(tributoFracc.TiFr_cuota_inicial);
            txtCuotaMinima.Text =Convert.ToString(tributoFracc.TiFr_cuota_minima);
            txtDerecho.Text = Convert.ToString(tributoFracc.TiFr_monto_derecho);
            txtDescuento.Text= Convert.ToString(tributoFracc.TiFr_descuento);
            txtFechaInicio.Value = tributoFracc.TiFr_fecha_inicio;
            txtFechaFin.Value = tributoFracc.TiFr_fecha_fin;
            txtInicial.Text = Convert.ToString(tributoFracc.TiFr_porce_inicial);
            txtIntComp.Text = Convert.ToString(tributoFracc.TiFr_interes_compensa);
            txtMaxUIT.Text = Convert.ToString(tributoFracc.TiFr_max_uit);
            txtNroCuotas.Text = Convert.ToString(tributoFracc.TiFr_max_cuotas);
            chkEstado.Checked = tributoFracc.TiFr_estado;
            chkInteres.Checked = tributoFracc.TiFr_interes_moratorio;
            dgvTributos.DataSource = trib_TipoFraccionamiento.listarTributosFraccionamiento(codi);

            //MessageBox.Show(Convert.ToString(cboModalidad.SelectedValue));
            //MessageBox.Show(Convert.ToString(cboAnioFin.SelectedValue));
            //MessageBox.Show(Convert.ToString(cboAnioIni.SelectedValue));
            //MessageBox.Show(tributoFracc.TiFr_modalidad); 

        }
        private void validadaCuotas(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTributoTipoFraccionamiento Frm_TributoFracc = new FrmTributoTipoFraccionamiento(codi);
                Frm_TributoFracc.StartPosition = FormStartPosition.CenterParent;
                Frm_TributoFracc.ShowDialog();
                dgvTributos.DataSource = trib_TipoFraccionamiento.listarTributosFraccionamiento(codi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cboAnioFin.Text.Equals("") || cboAnioIni.Text.Equals("") ||cboModalidad.Text.Equals("")
                    || txtBaseLegal.Text.Equals("") || txtCuotaIni.Text.Equals("") || txtCuotaMinima.Text.Equals("")
                    ||txtDescuento.Text.Equals("")||txtFechaFin.Text.Equals("")||txtFechaInicio.Text.Equals("")
                    ||txtIntComp.Text.Equals("")||txtNroCuotas.Text.Equals("")||txtMaxUIT.Text.Equals("")
                    || txtDerecho.Text.Equals("") || txtInicial.Text.Equals(""))                
                    MessageBox.Show("Por favor complete los campos", Globales.Global_MessageBox);
                else
                { 
                    Trib_TipoFraccionamiento elemento = new Trib_TipoFraccionamiento();
                    elemento.TiFr_anio_fin = Convert.ToInt32(cboAnioFin.SelectedValue);
                    elemento.TiFr_anio_inicio = Convert.ToInt32(cboAnioIni.SelectedValue);
                    elemento.TiFr_base_legal = txtBaseLegal.Text;
                    elemento.TiFr_cuota_inicial = Convert.ToDecimal(txtCuotaIni.Text);
                    elemento.TiFr_cuota_minima = Convert.ToDecimal(txtCuotaMinima.Text);
                    elemento.TiFr_descuento = Convert.ToDecimal(txtDescuento.Text);
                    elemento.TiFr_estado = chkEstado.Checked;
                    elemento.TiFr_fecha_fin = txtFechaFin.Value;
                    elemento.TiFr_fecha_inicio = txtFechaInicio.Value;
                    elemento.TiFr_interes_compensa = Convert.ToDecimal(txtIntComp.Text);
                    elemento.TiFr_interes_moratorio = chkInteres.Checked;
                    elemento.TiFr_max_cuotas = Convert.ToInt32(txtNroCuotas.Text);
                    elemento.TiFr_max_uit = Convert.ToInt32(txtMaxUIT.Text);
                    elemento.TiFr_modalidad = Convert.ToString(cboModalidad.SelectedValue);
                    elemento.TiFr_modalidadDesc = cboModalidad.SelectedText;
                    elemento.TiFr_monto_derecho = Convert.ToDecimal(txtDerecho.Text);
                    elemento.TiFr_porce_inicial = Convert.ToDecimal(txtInicial.Text);
                    try
                    {
                        if (codi == 0)
                        {
                            int resultado = tipoFracc.Insert(elemento);
                            if (resultado > 0)
                            {
                                tipoFracc.actualizarTributos(resultado);
                                MessageBox.Show("Se Insertó Correctamente", Globales.Global_MessageBox);
                                this.Close();
                            }
                        }
                        else
                        {
                            elemento.TiFr_tipo_fraccionamiento_ID = codi;
                            try { 
                                tipoFracc.Update(elemento);
                                MessageBox.Show("Se Insertó Correctamente",Globales.Global_MessageBox);
                                this.Close();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Error al actualizar datos", Globales.Global_MessageBox);
                            }
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error al Grabar", Globales.Global_MessageBox);
                    }                    
                }
            }
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            tipoFracc.EliminaTributosFracc();
            this.Close();
        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            int codigo = (Int32)dgvTributos.SelectedRows[0].Cells["cod"].Value;
            int resultado=tipoFracc.EliminaTributoFracc(codigo);
            if(resultado==1)
                MessageBox.Show("Se elimino correctamente el registro", Globales.Global_MessageBox);
            else
                MessageBox.Show("Ocurrio un error al eliminar el registro", Globales.Global_MessageBox);
            dgvTributos.DataSource = trib_TipoFraccionamiento.listarTributosFraccionamiento(codi);
        }

        private void Cancelar(object sender, FormClosedEventArgs e)
        {
            tipoFracc.EliminaTributosFracc();
            this.Close();
        }

        private void RecargarComboPeriodo(object sender, EventArgs e)
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
        }

        private void Frm_FraccionamientoDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
