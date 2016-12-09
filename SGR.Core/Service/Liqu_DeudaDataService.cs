using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Liqu_DeudaDataService
    {

        Liqu_DeudadRepository Liqu_deuda = new Liqu_DeudadRepository();
        public List<Liqu_Deuda> listartodos(String persona_ID)
        {
            try
            {
                return Liqu_deuda.listartodos(persona_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
