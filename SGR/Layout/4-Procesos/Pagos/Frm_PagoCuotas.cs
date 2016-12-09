using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Pagos
{
    public partial class Frm_PagoCuotas : DockContent
    {
        private Pago_PagoDataService Pago_PagoDataService = new Pago_PagoDataService();
        Pago_PagosDataService pagos = new Pago_PagosDataService();
        private List<Pago_Pago> coleccion;
        public Frm_PagoCuotas()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {                
                //coleccion = Pago_PagoDataService.consultarPagosPorFechaPago(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim());
                //dgvPagos.DataSource = coleccion;

                coleccion = Pago_PagoDataService.consultarPagoAnular(txtCodPago.Text);
                dgvPagos.DataSource = coleccion;

                //if (MessageBox.Show("Confirma Anulación de Pago?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 //   pagos.anularPago(txtCodPago.Text);
                //MessageBox.Show("Pago Anulado Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al anular el Pago", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void dgvPagos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            if (this.dgvPagos.Columns[e.ColumnIndex].Name == "xanular")
            {
                try
                {
                    if (MessageBox.Show("Confirma Anulación de Pago?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String codigo_voucher;
                        codigo_voucher = (String)dgvPagos.Rows[e.RowIndex].Cells["voucher"].Value;
                        pagos.anularPago(codigo_voucher);
                        coleccion = Pago_PagoDataService.consultarPagoAnular(txtCodPago.Text);
                        dgvPagos.DataSource = coleccion;
                        txtCodPago.Clear();
                    }
                      
                    MessageBox.Show("Pago Anulado Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
    }
}
