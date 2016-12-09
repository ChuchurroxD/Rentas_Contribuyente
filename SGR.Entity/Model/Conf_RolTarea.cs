using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Conf_RolTarea
    {
        public Int64 rol_id { get; set; }
        public String rol_descripcion { get; set; }
        public Int64 tarea_id { get; set; }
        public String tar_descripcion { get; set; }
        public Boolean estado { get; set; }
    }
}
