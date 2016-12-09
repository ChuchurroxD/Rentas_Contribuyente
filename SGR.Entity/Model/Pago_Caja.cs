using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity.Model
{
public  class Pago_Caja
{
public Int32 Caja_id{ get; set; }
public String Descripcion{ get; set; }
public Int32 idOficina{ get; set; }
public Boolean Estado{ get; set; }
public DateTime registro_fecha_add{ get; set; }
public string registro_user_add{ get; set; }
public String registro_pc_add{ get; set; }
public DateTime registro_fecha_update{ get; set; }
public string registro_user_update{ get; set; }
public String registro_pc_update{ get; set; }

        public String tipo { get; set; }
        // public void compararDescripcion(String descripcion, List<Pago_Caja> listaPago_Caja)
        //{
        //    foreach(Pago_Caja Pago_Caja in listaPago_Caja)
        //    {
        //        if (Pago_Caja.Descripcion.Equals(descripcion))
        //            throw new Exception("Ingrese otra descripcion, Descripcion repetida");
        //    }
        //}
}
}

