using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity

{


    public class Segu_Permiso
    {
        public Int64 Permc_iCodigo { get; set; }
        public Conf_Rol Roleo_oRol { get; set; }
        public Conf_Tarea Tareo_oTarea { get; set; }
        public Boolean Permc_bActivo { get; set; }

    }
}

