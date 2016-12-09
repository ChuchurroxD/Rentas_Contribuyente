using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Emi_MasivoDataService
    {
        private static Emi_MasivoRepository emi_MasivoRepository = new Emi_MasivoRepository();
        

        public List<Emi_Masivo> listartodos(Int32 sector)
        {
            try
            {
                return emi_MasivoRepository.listartodos(sector);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Emi_Masivo> listarNuevaImpresion(String persona, Int32 sector)
        {
            try
            {
                return emi_MasivoRepository.listarNuevaImpresion(persona, sector);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
