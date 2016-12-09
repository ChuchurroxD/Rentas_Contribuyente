using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Repository;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Entity.Model.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.VisualBasic;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento
{
    public partial class Frm_FraccionamientoDetalleCronograma : Form
    {
        Frac_FraccionamientoDataService fracc = new Frac_FraccionamientoDataService();
        string nombres,documento,persona;
        Frac_FraccionamientoDetalle elemento;
        List<Frac_Cronograma> arreglo1;
        List<Frac_Cronograma> arreglo1_1;
        List<Frac_FraccionamientoParametros> arreglo2;
        public Frm_FraccionamientoDetalleCronograma(string nombres, string documento, string persona,
            Frac_FraccionamientoDetalle elemento, List<Frac_Cronograma> arreglo1, List<Frac_FraccionamientoParametros> arreglo2,
            List<Frac_Cronograma> arreglo1_1)
        {
            InitializeComponent();
            dataGridView1.DataSource = arreglo1_1;
            this.arreglo1 = arreglo1;
            this.arreglo1_1 = arreglo1_1;
            this.elemento = elemento;
            this.arreglo2 = arreglo2;
            this.nombres = nombres;
            this.documento = documento;
            this.persona = persona;
            lblNombre.Text = nombres;
            lblDocumento.Text = documento;
            lblCodigo.Text = persona;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            try
            {

                int resultado = fracc.Insert(elemento);
                for (int i = 0; i < arreglo1.Count(); i++)
                {
                    arreglo1[i].Fraccionamiento_id = resultado;
                    fracc.InsertDetalle(arreglo1[i]);

                }
                for (int i = 0; i < arreglo2.Count(); i++)
                {

                    fracc.insertCta(arreglo2[i].persona_ID, arreglo2[i].anio_ini, arreglo2[i].anio_fin,
                        arreglo2[i].mes_ini, arreglo2[i].mes_fin, arreglo2[i].tributo_ID, resultado);
                }
                for (int i = 0; i < arreglo1.Count(); i++)
                {
                    arreglo1[i].Fraccionamiento_id = resultado;
                    fracc.UpdateCouta(arreglo1[i]);

                }
                MessageBox.Show("Fraccionamiento Generado Correctamente", Globales.Global_MessageBox);
                this.Close();
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
    }
}
