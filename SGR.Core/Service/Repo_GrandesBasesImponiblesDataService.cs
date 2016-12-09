using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Repo_GrandesBasesImponiblesDataService
    {
        private static Repo_GrandesBasesImponiblesRepository repo_GrandesBasesImponiblesRepository = new Repo_GrandesBasesImponiblesRepository();

        public List<Repo_GrandesBasesImponibles> generarReporte(int periodo_id, int top)
        {
            return repo_GrandesBasesImponiblesRepository.generarReporte(periodo_id, top);
        }
    }
}
