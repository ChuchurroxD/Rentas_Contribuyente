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
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Seguimiento_Fraccionamiento
{
    public partial class Frm_FraccionamientoReporte : Form
    {
        Frac_FraccionamientoDataService fracc = new Frac_FraccionamientoDataService();
        public Frm_FraccionamientoReporte(int fraccionamiento_ID)
        {
            InitializeComponent();
            cargarGrilla(fraccionamiento_ID);
        }
        public void cargarGrilla(int fraccionamiento_ID)
        {   
            dataGridView1.DataSource = fracc.listarCronograma(fraccionamiento_ID);
        }
    }
}
