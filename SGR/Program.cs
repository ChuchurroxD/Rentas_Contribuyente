using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGR.WinApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.D:\PROYECTO_MOCHE\Rentas_Contribuyente\SGR\Layout\4-Procesos\Fraccionamiento\Fraccionamiento\Frm_CalculoFraccionamiento.cs
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SGR.WinApp.Sistema.Entorno.Login());
            //Application.Run(new SGR.WinApp.Layout._4_Procesos.Multa.Frm_MultasAdministrativas());
            //Application.Run(new SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo.Frm_CalculoPorPersonaAnios());
        }
    }
}
