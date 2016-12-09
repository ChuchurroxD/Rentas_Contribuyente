using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Mant_ParametrosDataService
    {
        Mant_ParametrosRepository Mant_ParametrosRepository = new Mant_ParametrosRepository();

        public void insertar(Mant_Parametros Mant_Parametros)
        {
            try
            {
                if (Mant_ParametrosRepository.compararDescripcion(Mant_Parametros.descripcion) > 0)
                {
                    throw new Exception("Cambie de descripción, Descripción Repetida");
                }
                Mant_ParametrosRepository.Insert(Mant_Parametros);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificar(Mant_Parametros Mant_Parametros)
        {
            try
            {
                Mant_ParametrosRepository.Update(Mant_Parametros);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertarv2(Mant_Parametros Mant_Parametros)
        {
            try
            {
                Mant_ParametrosRepository.insertarv2(Mant_Parametros);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Parametros> listartodos(Int32 anio)
        {
            try
            {
                return Mant_ParametrosRepository.listartodos(anio);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> llenarComboPeriodo()
        {
            try
            {
                Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
                return Mant_PeriodoDataService.llenarPeriodo();   
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> llenarComboPeriodoporDescripcion(Int32 codigo)
        {
            try
            {
                return Mant_ParametrosRepository.llenarcomboporDescripcion(codigo);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Parametros> llenarComboDescripcion()
        {
            try
            {
                return Mant_ParametrosRepository.llenarComboDescripcion();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Parametros> getColeccion(string where, string orderby, Int32 anio)
        {
            try
            {
                return Mant_ParametrosRepository.Getcoleccion(where, orderby,anio);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Int32 totalParametroxAnioxCodigo(int anio, int codigo)
        {
            try
            {
                return Mant_ParametrosRepository.totalParametroxAnioxCodigo(anio, codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
