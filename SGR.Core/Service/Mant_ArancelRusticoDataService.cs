using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Mant_ArancelRusticoDataService
    {
        Mant_ArancelRusticoRepository mant_ArancelRusticoRepository = new Mant_ArancelRusticoRepository();
        public List<Mant_ArancelRustico> listarTodos(Int32 idPeriodo)
        {
            try
            {
                return mant_ArancelRusticoRepository.listarTodos(idPeriodo);
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
                return mant_ArancelRusticoRepository.ExisteElementosPeriodoAnterior(tipoConsulta);
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
                mant_ArancelRusticoRepository.CopiarElementosPeriodoAnterior(ussr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void insertarArancelRustico(Mant_ArancelRustico mant_ArancelRustico)
        {
            if (mant_ArancelRusticoRepository.compararRegistros(mant_ArancelRustico.Categoria_Rustico, mant_ArancelRustico.idGrupoRustico, mant_ArancelRustico.idPeriodo) > 0)
            {
                throw new Exception("Datos ya Existentes");
            }else
            {
                mant_ArancelRusticoRepository.Insert(mant_ArancelRustico);
            }
        }

        public void updateArancelRustico(Mant_ArancelRustico mant_ArancelRustico)
        {
            if (mant_ArancelRusticoRepository.compararRegistrosModificar(mant_ArancelRustico.Categoria_Rustico, mant_ArancelRustico.idGrupoRustico, mant_ArancelRustico.idPeriodo, mant_ArancelRustico.ArancelRustico_id) > 0)
            {
                throw new Exception("Datos ya Existentes");
            }
            else
            {
                mant_ArancelRusticoRepository.Update(mant_ArancelRustico);
            }            
        }

        public void deletebyprimarykey(int ArancelRustico_id)
        {
            mant_ArancelRusticoRepository.DeleteByPrimaryKey(ArancelRustico_id);
        }
        public List<Conf_Multitabla> llenarComboGrupoRustico()
        {
            return mant_ArancelRusticoRepository.llenarComboGrupoRustico();
        }
        public List<Conf_Multitabla> llenarComboCategoriaRustico()
        {
            return mant_ArancelRusticoRepository.llenarComboCategoriaRustico();
        }
        public decimal GetMontoRustico(string idGrupoRustico, int anio, string Categoria_Rustico)

        {
            return mant_ArancelRusticoRepository.GetMontoRustico(idGrupoRustico, anio, Categoria_Rustico);
        }
    }
}
