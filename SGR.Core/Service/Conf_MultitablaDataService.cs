using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Conf_MultitablaDataService
    {
        private static Conf_MultitablaRepository Conf_MultitablaRepository = new Conf_MultitablaRepository();

        public List<Conf_Multitabla> GetAllConf_Multitabla(String Padre)
        {
            return Conf_MultitablaRepository.listartodos(Padre);
        }

        public int Insert(Conf_Multitabla conf_Multitabla)
        {
            return Conf_MultitablaRepository.Insert(conf_Multitabla);
        }
        public void Update(Conf_Multitabla conf_Multitabla)
        {
            Conf_MultitablaRepository.Update(conf_Multitabla);
        }
        public void DeleteByPrimaryKey(Int64 Mult_iCodigo)
        {
            Conf_MultitablaRepository.DeleteByPrimaryKey(Mult_iCodigo);
        }

        public int GetExisteDescripcionNuevo(String Mult_vDescripcion, String Mult_vDependencia)
        {
            return Conf_MultitablaRepository.GetExisteDescripcionNuevo(Mult_vDescripcion, Mult_vDependencia); ;
        }

        public int GetExisteDescripcionModificar(String Mult_vDescripcion, String Mult_vDependencia, Int64 Mult_iCodigo)
        {
            return Conf_MultitablaRepository.GetExisteDescripcionModificar(Mult_iCodigo, Mult_vDescripcion, Mult_vDependencia); ;
        }
        public List<Conf_Multitabla> GetCboConf_Multitabla(String Padre)
        {
            return Conf_MultitablaRepository.listarCbo(Padre);
        }
        public List<Conf_Multitabla> Getcoleccion(string whereSQL, string orderbySQL)
        {
            return Conf_MultitablaRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);

        }
        public List<Conf_Multitabla> listarCombo(String Multc_iDependenci)
        {
            return Conf_MultitablaRepository.listarCbo(Multc_iDependenci);

        }
        public Int32 GetMaxTablaDependiente(String Multc_iDependenci)
        {
            try {
                return Conf_MultitablaRepository.GetMaxTablaDependiente(Multc_iDependenci);
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }
        public List<Conf_Multitabla> listarCombov2(String Multc_iDependenci)
        {
            return Conf_MultitablaRepository.listarCbov2(Multc_iDependenci);

        }
    }
}
