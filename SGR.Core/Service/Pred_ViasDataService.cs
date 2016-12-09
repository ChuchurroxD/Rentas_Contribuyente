using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Pred_ViasDataService
    {
        Pred_ViasRepository pred_ViasRepository = new Pred_ViasRepository();
        Conf_UbicacionRepository conf_UbicacionRepository = new Conf_UbicacionRepository();
        public List<Pred_Vias> listarTodos()
        {
            return pred_ViasRepository.listarTodos();
        }

        public List<Pred_Vias> Getcoleccion(string whereSQL, string orderbySQL)
        {
            return pred_ViasRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);
        }

        public void insertarVias(Pred_Vias pred_Vias)
        {
            pred_Vias.compararCodigoVia(pred_Vias.Via_id,pred_ViasRepository.listarTodos());
            pred_Vias.compararDescripcion(pred_Vias.Descripcion, pred_ViasRepository.listarTodos());
            pred_ViasRepository.Insert(pred_Vias);
        }

        public void updateVias(Pred_Vias pred_Vias)
        {
            pred_Vias.compararDescripcion(pred_Vias.Descripcion, pred_ViasRepository.listarTodos());
            pred_ViasRepository.Update(pred_Vias);
        }

        public void deletebyprimarykey(string Via_id)
        {
            pred_ViasRepository.DeleteByPrimaryKey(Via_id);
        }

        public List<Pred_TipoVia> llenarTipoVia()
        {
            return pred_ViasRepository.llenarTipoVia();
        }

        public List<Pred_Vias> listarViasCbo()
        {
            return pred_ViasRepository.listarViasCbo();
        }
        //
        public List<Pred_Vias> listarViasCboCodAntiguo(String CodAnt)
        {
            return pred_ViasRepository.listarViasCboCodAntiguo(CodAnt);
        }

        public List<Pred_Vias> listarViasPorSector(string junta_id,int oficina)
        {
            return pred_ViasRepository.listarViasPorSector(junta_id,oficina);
        }
        public List<Pred_Vias> listarViasPorSectorv2(string junta_id)
        {
            try
            {
                return pred_ViasRepository.listarViasPorSectorv2(junta_id);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetIdViaMax()
        {
            try
            {
                return pred_ViasRepository.GetIdViaMax();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
