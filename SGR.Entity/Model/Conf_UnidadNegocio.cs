using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity

{


    public class Conf_UnidadNegocio
    {
        public Int64 UnNec_iCodigo { get; set; }
        public String UnNec_vDescripcion { get; set; }
        public Boolean UnNegoc_bActivo { get; set; }
        public int obtenerIndice(Int64 codigo, List<Conf_UnidadNegocio> lista)
        { int i = 0;
            foreach (Conf_UnidadNegocio conf_UnidadNegocio in lista)
            {
                if (codigo==conf_UnidadNegocio.UnNec_iCodigo)
                break;
                i++;
                
            }
            return i;
        }
    }
}

