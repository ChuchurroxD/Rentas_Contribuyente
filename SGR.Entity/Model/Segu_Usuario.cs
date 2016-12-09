using System;
using System.Collections.Generic;
using System.Text;

namespace SGR.Entity
{
public  class Segu_Usuario  
{
        public string  per_codigo { get; set; }
        public Int32 Seguc_iCodigo { get; set; }//eliminar
        public String Seguc_vNombre { get; set; }//eliminar
        public String Seguc_vApellidos { get; set; }
        public String areas_codarea { get; set; }
        public DateTime Seguc_fFechaCreacion{ get; set; }//Agregado
        public String Seguc_vLogin { get; set; }
        public String Seguc_password { get; set; }
        public String Seguc_vLast { get; set; }
        public String Seguc_vSession { get; set; }
        public DateTime Seguc_fFechaCese { get; set; }
        public Boolean Seguc_bEstado { get; set; }
        //public Conf_UnidadNegocio UnNeo_oUnidadNegocio { get; set; }
        //public Mant_Persona Perso_oPersona { get; set; }
    }
}

