using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;

namespace SGR.Core
{
    public class Mant_CuadroValoresDataService
    {
        Mant_CuadroValoresRepository mant_CuadroValoresRepository = new Mant_CuadroValoresRepository();
        public List<Mant_CuadroValores> listartodos()
        {
            try
            {
                return mant_CuadroValoresRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int valida(Mant_CuadroValores cuadro_valores)
        {
            try
            {
                return mant_CuadroValoresRepository.valida(cuadro_valores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Mant_CuadroValores GetByPrimaryKey(Int32 cuadro_valores_id)
        {
            try
            {
                return mant_CuadroValoresRepository.GetByPrimaryKey(cuadro_valores_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_CuadroValores> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return mant_CuadroValoresRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int ExisteElementosPeriodoAnterior(int tipoConsulta)
        {
            try
            {
                return mant_CuadroValoresRepository.ExisteElementosPeriodoAnterior(tipoConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void CopiarElementosPeriodoAnterior(string ussr)
        {
            try
            {
                mant_CuadroValoresRepository.CopiarElementosPeriodoAnterior(ussr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Mant_CuadroValores cuadro_valores)
        {
            try
            {
                return mant_CuadroValoresRepository.Insert(cuadro_valores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_CuadroValores cuadro_valores)
        {
            try
            {
                mant_CuadroValoresRepository.Update(cuadro_valores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool DeleteByPrimaryKey(Int32 codigo)
        {
            try
            {
                return mant_CuadroValoresRepository.DeleteByPrimaryKey(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual List<Mant_CuadroValores> listarErroresCuadroValores(Int32 periodo)
        {
            try
            {
                return mant_CuadroValoresRepository.listarErroresCuadroValores(periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
