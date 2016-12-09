using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity.Model
{
public  class Mant_Parametros
{
public Int32 parametros_ID{ get; set; }
public Int32 codigo{ get; set; }
public Int32 anio{ get; set; }
public String descripcion{ get; set; }
public decimal valor{ get; set; }
public Int32 valor1{ get; set; }
public Boolean estado{ get; set; }
public DateTime registro_fecha_add{ get; set; }
public string registro_user_add{ get; set; }
public String registro_pc_add{ get; set; }
public DateTime registro_fecha_update{ get; set; }
public string registro_user_update{ get; set; }
public String registro_pc_update{ get; set; }

}
}

