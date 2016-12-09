using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class Mant_ArancelRustico
    {
        public int ArancelRustico_id { get; set; }
        public int idPeriodo { get; set; }
        public int Categoria_Rustico { get; set; }
        public string Categoria_RusticoDescripcion { get; set; }
        public decimal ValorRustico { get; set; }
        public int idGrupoRustico { get; set; }
        public string GrupoRusticoDescripcion { get; set; }
        public bool activo { get; set; }
        public DateTime registro_fecha_add { get; set; }
        public string registro_user_add { get; set; }
        public string registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public string registro_user_update { get; set; }
        public string registro_pc_update { get; set; }
    }
}
