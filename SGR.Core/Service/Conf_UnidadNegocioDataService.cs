using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Conf_UnidadNegocioDataService
    {
        private static Conf_UnidadNegocioRepository Conf_UnidadNegocioRepository = new Conf_UnidadNegocioRepository();

        public List<Conf_UnidadNegocio> GetAllConf_UnidadNegocio()
        {
            return Conf_UnidadNegocioRepository.listartodos();
        }

        public int Insert(Conf_UnidadNegocio Conf_UnidadNegocio)
        {
            return Conf_UnidadNegocioRepository.Insert(Conf_UnidadNegocio);
        }
        public void Update(Conf_UnidadNegocio Conf_UnidadNegocio)
        {
            Conf_UnidadNegocioRepository.Update(Conf_UnidadNegocio);
        }
        public void DeleteByPrimaryKey(Int64 UnNec_iCodigo)
        {
            Conf_UnidadNegocioRepository.DeleteByPrimaryKey(UnNec_iCodigo);
        }

        public int GetExisteDescripcionNuevo(String UnNec_vDescripcion)
        {
            return Conf_UnidadNegocioRepository.GetExisteDescripcionNuevo(UnNec_vDescripcion); 
        }

        public int GetExisteDescripcionModificar(String UnNec_vDescripcion, Int64 UnNec_iCodigo)
        {
            return Conf_UnidadNegocioRepository.GetExisteDescripcionModificar(UnNec_iCodigo, UnNec_vDescripcion); 
        }
        public List<Conf_UnidadNegocio> GetActivosConf_UnidadNegocio()//para el combo
        {
            return Conf_UnidadNegocioRepository.listarActivos();
        }
        public List<Conf_UnidadNegocio> Getcoleccion(string whereSQL, string orderbySQL)
        {
            return Conf_UnidadNegocioRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);

        }
    }
}

