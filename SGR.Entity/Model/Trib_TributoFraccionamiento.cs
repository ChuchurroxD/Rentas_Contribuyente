using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Trib_TributoFraccionamiento
    {
        public Int32 TrFrc_icod { get; set; }
        public String TrFrc_vtrib { get; set; }
        public String TrFrc_vtribDesc { get; set; }
        public String TrFrc_vabrev { get; set; }
        public decimal TrFrc_dimporte { get; set; }
        public String TrFrc_vgrupo { get; set; }
        public String TrFrc_vgrupodesc { get; set; }
        
    }
}
