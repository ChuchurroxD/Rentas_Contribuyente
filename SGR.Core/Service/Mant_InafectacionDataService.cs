using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Mant_InafectacionDataService
    {
        Mant_InafectacionRepository mant_InafectacionRepository = new Mant_InafectacionRepository();
        public List<Mant_Inafectacion> listartodos()
        {
            return mant_InafectacionRepository.listartodos();
        }

        public List<Mant_Inafectacion> buscar(string busqueda)
        {
            return mant_InafectacionRepository.buscar(busqueda);
        }

        public virtual int Insert(Mant_Inafectacion mant_Inafectacion)
        {
            return mant_InafectacionRepository.Insert(mant_Inafectacion);
        }

        public virtual int Update(Mant_Inafectacion mant_Inafectacion)
        {
            return mant_InafectacionRepository.Update(mant_Inafectacion);
        }
    }
}
