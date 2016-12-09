using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._5_Reportes_Gestion
{
    public partial class Frm_Visor_Global : Form
    {
        public Frm_Visor_Global()
        {
            InitializeComponent();
        }

        private void Frm_Visor_Global_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
