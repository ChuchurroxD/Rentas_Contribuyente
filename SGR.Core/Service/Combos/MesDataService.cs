using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model.Combos;
using SGR.Core.Repository.Combos;

namespace SGR.Core.Service.Combos
{
    public class MesDataService
    {
        MesRepository mes = new MesRepository();
        public List<Mes> listartodos()
        {
            try
            {
                return mes.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mes> listarTodosv2()
        {
            try
            {
                return mes.listarTodosv2();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
