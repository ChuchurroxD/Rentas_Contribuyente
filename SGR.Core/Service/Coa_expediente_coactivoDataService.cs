using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Coa_expediente_coactivoDataService
    {

        Coa_expediente_coactivoRepository Coa_expediente_coactivoRepository = new Coa_expediente_coactivoRepository();
        public void anular(int idcoactivo)
        {
            try
            {
                 Coa_expediente_coactivoRepository.anular(idcoactivo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Coa_expediente_coactivo> listartodos(DateTime fechaini, DateTime fechafin, string persona_ID, string namepersona, string anio_expediente,
            string EXP_ESTADO, string descripcion_exp)
        {
            try
            {
                return Coa_expediente_coactivoRepository.listartodos(fechaini, fechafin, persona_ID, namepersona, anio_expediente,
             EXP_ESTADO, descripcion_exp);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Coa_expediente_coactivo GetByPrimaryKey(String expediente_coactivo_ID, Int32 anio_expediente)
        {
            try
            {
                return Coa_expediente_coactivoRepository.GetByPrimaryKey(expediente_coactivo_ID, anio_expediente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual int Insert(Coa_expediente_coactivo expediente_coactivo)
        {
            try
            {
                return Coa_expediente_coactivoRepository.Insert(expediente_coactivo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Coa_expediente_coactivo expediente_coactivo)
        {
            try
            {
                Coa_expediente_coactivoRepository.Update(expediente_coactivo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
