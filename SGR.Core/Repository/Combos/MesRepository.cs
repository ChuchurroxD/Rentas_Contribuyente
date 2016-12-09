using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model.Combos;

namespace SGR.Core.Repository.Combos
{
    public class MesRepository
    {
        public List<Mes> listartodos()
        {
            var coleccion = new List<Mes>();
            coleccion.Add(new Mes
                        {
                            mes_ID = "1",
                            mes = "Enero"
                        });
            coleccion.Add(new Mes
            {
                mes_ID = "2",
                mes = "Febrero"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "3",
                mes = "Marzo"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "4",
                mes = "Abril"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "5",
                mes = "Mayo"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "6",
                mes = "Junio"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "7",
                mes = "Julio"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "8",
                mes = "Agosto"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "9",
                mes = "Setiembre"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "10",
                mes = "Octubre"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "11",
                mes = "Noviembre"
            });
            coleccion.Add(new Mes
            {
                mes_ID = "12",
                mes = "Diciembre"
            });
            return coleccion;           
        }
        public List<Mes> listarTodosv2()
        {
            var coleccion = listartodos();
            coleccion.Add(new Mes
            {
                mes_ID = "0",
                mes = "TODOS"
            });
            return coleccion;
        }
    }
}
