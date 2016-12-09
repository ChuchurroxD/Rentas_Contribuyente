using SGR.Core.Repository;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Mant_ParametroMesDataService
    {
        Mant_ParametroMesRepository mant_ParametroMesRepository = new Mant_ParametroMesRepository();
        Mant_ParametroMes mant_ParametroMes = new Mant_ParametroMes();
        public List<Mant_ParametroMes> listartodos(Int32 periodo_id)
        {
            try
            {
                
                return mant_ParametroMesRepository.listartodos(periodo_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Mant_ParametroMes GetByPrimaryKey()
        {
            try
            {
                return mant_ParametroMesRepository.GetByPrimaryKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_ParametroMes> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return mant_ParametroMesRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Insert(Mant_ParametroMes parametro_mes)
        {
            if (mant_ParametroMesRepository.compararMes(parametro_mes.periodo_id,parametro_mes.tipo.ToString(),parametro_mes.mes) > 0)
            {
                throw new Exception("Datos ya Existentes");
            }
            else
            {
                mant_ParametroMesRepository.Insert(parametro_mes);
            }
        }
        public virtual int VerificaMes(Mant_ParametroMes parametro_mes)
        {
            try
            {
                return mant_ParametroMesRepository.compararMes(parametro_mes.mes, parametro_mes.tipo.ToString(), parametro_mes.periodo_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_ParametroMes parametro_mes)
        {
            if (mant_ParametroMesRepository.compararMesModificar(parametro_mes.mes, parametro_mes.parametro_mes_ID, parametro_mes.periodo_id, parametro_mes.tipo.ToString()) > 0)
            {
                throw new Exception("Datos ya Existentes");
            }
            else
            {
                mant_ParametroMesRepository.Update(parametro_mes);
            }
        }
        public virtual int VerificarModificarMes(Mant_ParametroMes parametro_mes)
        {
            try
            {
                return mant_ParametroMesRepository.compararMesModificar(parametro_mes.mes, parametro_mes.parametro_mes_ID, parametro_mes.periodo_id, parametro_mes.tipo.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Int32 existeFechaVencimientoxPeriodoMes(Int32 periodo)
        {
            try
            {
                return mant_ParametroMesRepository.existeFechaVencimientoxPeriodoMes(periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_ParametroMes> listarerrores(Int32 periodo_id, int codigo, int tipo,String tributo_id)
        {
            try
            {
                return mant_ParametroMesRepository.listarerrores(periodo_id,codigo,tipo, tributo_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
