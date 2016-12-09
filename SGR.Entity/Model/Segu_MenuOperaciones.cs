using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
  public  class Segu_MenuOperaciones
    {

        public Int32 Menu_iCodigo { get; set; }
        public string Menu_vMenu { get; set; }
        public string Menu_vFormulario { get; set; }

        public Int32 Moduc_iCodigo { get; set; }

        public Int32 Menu_iOperacionPadre { get; set; }
    }
}
