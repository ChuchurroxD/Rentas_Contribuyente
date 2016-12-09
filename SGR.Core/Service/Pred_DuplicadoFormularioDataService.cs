using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_DuplicadoFormularioDataService
    {
        Pred_DuplicadoFormularioRepository Pred_DuplicadoFormularioRepository = new Pred_DuplicadoFormularioRepository();
         public virtual void Generar(String PERSONA, String ini, string fin, string registro_user, int hp,int cantidad)
        {
            try
            {
                Pred_DuplicadoFormularioRepository.Generar( PERSONA,  ini,  fin,  registro_user,  hp, cantidad);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string Verificar(String PERSONA, String ini, string fin)
        {
            try
            {
                return Pred_DuplicadoFormularioRepository.Verificar(PERSONA, ini, fin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
