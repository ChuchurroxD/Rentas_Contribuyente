using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.WinApp.Sistema.Globales;
namespace SGR.WinApp.Sistema.Globales
{
    public class Validaciones
    {
        public void validaNumeroEntero(KeyPressEventArgs e,String msj)
        {
            
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten números", msj, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public void ValidarNumeroDecimal(KeyPressEventArgs e, String txt,String msj)
        {
            decimal Dft = 0;
            string Comprobar = txt + e.KeyChar.ToString();
            bool EsNumerico = decimal.TryParse(Comprobar, out Dft);
            if (((((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 46 && (e.KeyChar != (char)Keys.Back)) || (!EsNumerico && e.KeyChar != (char)Keys.Back)))&& !(char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten números decimales validos", msj, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            //if (((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 46 && (e.KeyChar != (char)Keys.Back)) || (!EsNumerico && e.KeyChar != (char)Keys.Back))
            //{
            //    MessageBox.Show("Solo se permiten números decimales validos", msj, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }
        public void ValidaLetras(KeyPressEventArgs e, String msj)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space)&& !(char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", msj, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public bool validaNumeroEnteroValido(String texto)//numero entero diferente de 0
        {
            int numero;
            numero = Convert.ToInt32(texto);
            if (numero == 0)
                return true;
            return false;
        }

        public bool validaNumeroDecimalValido(String texto)//numero decimal diferente de 0
        {
            decimal numero;
            numero = Convert.ToDecimal(texto);
            if (numero == 0)
                return true;
            return false;
        }
        public bool validaAnio(String texto)
        {
            int numero;
            numero = Convert.ToInt32(texto);
            DateTime fechaHoy = DateTime.Now;
            if (numero <= 1900 || numero> fechaHoy.Year)
                        return true;
            return false;
        }
    }
}