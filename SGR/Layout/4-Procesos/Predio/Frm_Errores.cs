using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Predio
{
    public partial class Frm_Errores : Form
    {
        public Frm_Errores()
        {
            InitializeComponent();
        }
        public Frm_Errores(List<Pred_UsoGeneral> lista1)
        {
            try
            {
                InitializeComponent();
                dgvErrores.Rows.Clear();
                for (int i = 0; i < lista1.Count; i++)
                {
                    dgvErrores.Rows.Add(lista1[i].descripcion);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Globales.Global_MessageBox); }

        }
        public Frm_Errores(List<Mant_Depreciacion> listaObserva)
        {
            try
            {
                InitializeComponent();
                dgvErrores.Rows.Clear();
                for (int i = 0; i < listaObserva.Count; i++)
                {
                    dgvErrores.Rows.Add(listaObserva[i].clasificacion_descripcion);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Globales.Global_MessageBox); }

        }
        private void dgvErrores_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvErrores.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
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
                    String descripcion = i.ToString() + " - " + (String)fila.Cells[0].Value;
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
    }
}
