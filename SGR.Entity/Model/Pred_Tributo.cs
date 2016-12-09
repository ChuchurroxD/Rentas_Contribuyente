using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity.Model
{
public  class Pred_Tributo
{
public String tributos_ID{ get; set; }
public String descripcion{ get; set; }
public decimal importe{ get; set; }
public Boolean activo{ get; set; }
public String abrev{ get; set; }
public string tipo_tributo{ get; set; }
public decimal porce_uit{ get; set; }
public String clai_codigo{ get; set; }
public String cod_contable{ get; set; }
public String are_codigo{ get; set; }
public decimal porce_area{ get; set; }
public String fuente{ get; set; }
public Byte cobro_interes{ get; set; }
        public string tipo { get; set; }
        public string tipocl { get; set; }
        public string area { get; set; }

        //public void compararDescripcion(string descripcion, List<Pred_Tributo> lista)
        //{
        //    foreach(Pred_Tributo Pred_Tributo1 in lista){
        //        if(Pred_Tributo1.descripcion.Equals(descripcion))
        //        {
        //            throw new Exception("Cambiar de descripcion, descripcion igual");
        //        }
        //    }
        //}
        //public void compararCodigo(string codigo, List<Pred_Tributo> lista)
        //{
        //    foreach(Pred_Tributo pred_Tributo in lista)
        //    {
        //        if (pred_Tributo.tributos_ID.Equals(codigo))
        //            throw new Exception("Cambiar el codigo, codigo repetido");
        //    }
        //}
}
}

