using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Conf_UbicacionDataService
    {
        private static Conf_UbicacionRepository Conf_UbicacionRepository = new Conf_UbicacionRepository();

        public List<Conf_Ubicacion> GetAllConf_Ubicacion()
        {
            return Conf_UbicacionRepository.listartodos();
        }

        public int Insert(Conf_Ubicacion Conf_Ubicacion)
        {
            return Conf_UbicacionRepository.Insert(Conf_Ubicacion);
        }
        public void Update(Conf_Ubicacion Conf_Ubicacion)
        {
            Conf_UbicacionRepository.Update(Conf_Ubicacion);
        }
        public void DeleteByPrimaryKey(Int64 UnNec_iCodigo)
        {
            Conf_UbicacionRepository.DeleteByPrimaryKey(UnNec_iCodigo);
        }

        public int GetExisteDescripcionNuevo(String UnNec_vDescripcion)
        {
            return Conf_UbicacionRepository.GetExisteDescripcionNuevo(UnNec_vDescripcion); 
        }

        public int GetExisteDescripcionModificar(String UnNec_vDescripcion, Int64 UnNec_iCodigo)
        {
            return Conf_UbicacionRepository.GetExisteDescripcionModificar(UnNec_iCodigo, UnNec_vDescripcion); 
        }
        public List<Conf_Ubicacion> GetDepartamentos()//para el combo de departamntos
        {
            return Conf_UbicacionRepository.listarDepartamentos();
        }
        public List<Conf_Ubicacion> GetProvincia(string dep, int tipo)//para el combo de provincias y distritos
        {
            return Conf_UbicacionRepository.listarProvincia(dep, tipo);
        }
        public Int32 GetExistUbicacionId(string Ubicacion_id)
        {
            return Conf_UbicacionRepository.GetExisteUbicacionId(Ubicacion_id); 
        }
    }
}

