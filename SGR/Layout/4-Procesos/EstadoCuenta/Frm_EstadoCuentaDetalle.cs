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
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.EstadoCuenta
{
    public partial class Frm_EstadoCuentaDetalle : Form
    {
        private Mant_Per_Cont mant_Per_Cont;
        private Pago_CuentaCorrienteDataService Pago_CuentaCorrienteDataService = new Pago_CuentaCorrienteDataService();
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_TributoDataService Pred_TributoDataService = new Pred_TributoDataService();
        private List<Pago_CuentaCorriente> coleccion = new List<Pago_CuentaCorriente>();

        string alcabala = "";
        string arbitrio = "";
        string formulario = "";
        string predio = "";
        string predio_id = "0";
        string todos = "1";

        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_EstadoCuentaDetalle()
        {
            InitializeComponent();
        }

        public Frm_EstadoCuentaDetalle(Mant_Per_Cont mant_Per_Cont)
        {
            InitializeComponent();
            this.mant_Per_Cont = mant_Per_Cont;
        }

        private void llenarComboPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_vdescripcion";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_PeriodoDataService.listarCboPeriodov2();
        }

        private void mostrarTotal()
        {
            int cantidad;
            decimal total = 0;
            decimal pendiente = 0;
            cantidad = dataGridView1.RowCount;
            List<Liqu_DeudaDetalleTributo> Coleccion = new List<Liqu_DeudaDetalleTributo>();
            for (int i = 0; i < cantidad; i++)
            {
                total = total + (decimal)dataGridView1.Rows[i].Cells["deuda"].Value;
                pendiente = pendiente + (decimal)dataGridView1.Rows[i].Cells["pendiente"].Value;
            }
            lblPedienteT.Text = Convert.ToString(pendiente);
            lblCanceladoT.Text = Convert.ToString(total - pendiente);
            lblTotal.Text = Convert.ToString(total);
        }

        private void Frm_EstadoCuentaDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                cboPredio.Enabled = false;
                llenarComboPeriodo();
                llenarPredios(); 
                lblCodigo.Text = mant_Per_Cont.persona_ID;
                lblDocumento.Text = mant_Per_Cont.documento;
                lblNombre.Text = mant_Per_Cont.paterno + " " + mant_Per_Cont.materno + "," + mant_Per_Cont.nombres;
                //coleccion= Pago_CuentaCorrienteDataService.estadoCuentaPendiente, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                mostrarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void llenarPredios()
        {
            cboPredio.ValueMember = "Predio_id";
            cboPredio.DisplayMember = "direccion_completa";
            cboPredio.DataSource = Pago_CuentaCorrienteDataService.listarPrediosxPersona(mant_Per_Cont.persona_ID, Convert.ToInt32(cboPeriodo.SelectedValue.ToString().Trim()));
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;

            cboPredio.ValueMember = "Predio_id";
            cboPredio.DisplayMember = "direccion_completa";
            cboPredio.DataSource = Pago_CuentaCorrienteDataService.listarPrediosxPersona(mant_Per_Cont.persona_ID, Convert.ToInt32(cboPeriodo.SelectedValue.ToString().Trim()));
            cargarValores();
            if (!checkBox1.Checked)
            {
                
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "anio")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.anio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.anio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "mes")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.mes).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.mes).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "tributo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.tributo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.tributo).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "tipo_tributo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.tipo_tributo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.tipo_tributo).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "fecha_vence")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.fecha_vence).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.fecha_vence).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "estado")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.estado).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.estado).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "pendiente")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.pendiente).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.pendiente).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "pagado")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.pagado).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.pagado).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "deuda")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.total).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.total).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cargarValores();
            if (!checkBox1.Checked)
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;            
            try
            {
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.EstadoCuenta.rptEstadoDeuda.rdlc";

                cargarValores();
                if (!checkBox1.Checked)
                {
                    coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                    //dataGridView1.DataSource = coleccion;
                }
                else
                {
                    coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                    //dataGridView1.DataSource = coleccion;
                }
                limpiarValores();

                frmVisor.reportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));


                List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                elementoo.logoEmpresa = File.ReadAllBytes(_path);
                elementoo.convenio = "convenio";
                origen2.Add(elementoo);
                ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                frmVisor.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);

                ReportParameter[] param = new ReportParameter[9];
                param[0] = new ReportParameter("Documento", lblDocumento.Text);
                param[1] = new ReportParameter("Código", mant_Per_Cont.persona_ID);
                param[2] = new ReportParameter("NombreCompleto", lblNombre.Text);
                param[3] = new ReportParameter("Periodo", cboPeriodo.Text);

                String tributos = "";
                if (chkAlcabala.Checked == true)
                    tributos = tributos + "Alcabala ";
                if (chkArbitrio.Checked == true)
                    tributos = tributos + "Arbitrio ";
                if (chkFormulario.Checked == true)
                    tributos = tributos + "Formulario ";
                if (chkPredio.Checked == true)
                    tributos = tributos + "Predio ";
                if (chkTodos.Checked == true)
                    tributos = "Alcabala Arbitrio Formulario Predio";

                param[4] = new ReportParameter("Tributos", tributos);
                if (checkBox1.Checked == true)
                {
                    param[5] = new ReportParameter("Incluye", "Incluye cancelados.");
                }
                else
                {
                    param[5] = new ReportParameter("Incluye", "No incluye cancelados.");
                }
                param[6] = new ReportParameter("Predio", cboPredio.Text);
                param[7] = new ReportParameter("FechaImpresion", DateTime.Today.ToString());
                param[8] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);

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

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarValores();
                if (!checkBox1.Checked)
                {
                    coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                    dataGridView1.DataSource = coleccion;
                }
                else
                {
                    coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                    dataGridView1.DataSource = coleccion;
                }
                limpiarValores();
                mostrarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarValores()
        {
            if (chkPredio.Checked == true)
            {
                predio = "0008";
            }
            if (chkAlcabala.Checked == true)
            {
                alcabala = "0038";
            }
            if (chkArbitrio.Checked == true)
            {
                arbitrio = "0043";
                predio_id = cboPredio.SelectedValue.ToString().Trim();
            }
            if (chkFormulario.Checked == true)
            {
                formulario = "0016";
            }
            if (chkTodos.Checked == true)
            {
                todos = "";
            }
        }

        private void limpiarValores()
        {
            alcabala = "";
            arbitrio = "";
            formulario = "";
            predio = "";
            predio_id = "";
            todos = "1";
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked == true)
            {
                chkAlcabala.Checked = false;
                chkArbitrio.Checked = false;
                chkFormulario.Checked = false;
                chkPredio.Checked = false;

                chkAlcabala.Enabled = false;
                chkArbitrio.Enabled = false;
                chkFormulario.Enabled = false;
                chkPredio.Enabled = false;
                cboPredio.Enabled = false;
            }

            if (chkTodos.Checked == false)
            {
                chkAlcabala.Enabled = true;
                chkArbitrio.Enabled = true;
                chkFormulario.Enabled = true;
                chkPredio.Enabled = true;
            }

            cargarValores();
            if (!checkBox1.Checked)
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }

        private void chkPredio_CheckedChanged(object sender, EventArgs e)
        {
            cargarValores();
            if (chkArbitrio.Checked == true)
            {
                cboPredio.Enabled = true;
            }
            else
            {
                cboPredio.Enabled = false;
            }

            if (!checkBox1.Checked)
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }

        private void chkArbitrio_CheckedChanged(object sender, EventArgs e)
        {
            cargarValores();
            if (chkArbitrio.Checked == true)
            {
                cboPredio.Enabled = true;
            }
            else
            {
                cboPredio.Enabled = false;
            }

            if (!checkBox1.Checked)
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }

        private void chkFormulario_CheckedChanged(object sender, EventArgs e)
        {
            cargarValores();
            if (chkArbitrio.Checked == true)
            {
                cboPredio.Enabled = true;
            }
            else
            {
                cboPredio.Enabled = false;
            }

            if (!checkBox1.Checked)
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }

        private void chkAlcabala_CheckedChanged(object sender, EventArgs e)
        {
            cargarValores();
            if (chkArbitrio.Checked == true)
            {
                cboPredio.Enabled = true;
            }
            else
            {
                cboPredio.Enabled = false;
            }

            if (!checkBox1.Checked)
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }

        private void cboPredio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarValores();

            if (!checkBox1.Checked)
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaPendiente(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            else
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaCompleto(mant_Per_Cont.persona_ID, predio_id, predio, arbitrio, alcabala, formulario, todos, Convert.ToInt32(cboPeriodo.SelectedValue), 8);
                dataGridView1.DataSource = coleccion;
            }
            limpiarValores();
            mostrarTotal();
        }
    }
}