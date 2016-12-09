using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Mant_PeriodoDataService
    {
        private static Mant_PeriodoRepository Mant_PeriodoRepository = new Mant_PeriodoRepository();

        public List<Mant_Periodo> GetAllMant_Periodo()
        {
            try
            {
                return Mant_PeriodoRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Insert(Mant_Periodo Mant_Periodo)
        {
            try
            {
                return Mant_PeriodoRepository.Insert(Mant_Periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Mant_Periodo Mant_Periodo)
        {
            try
            {
                Mant_PeriodoRepository.Update(Mant_Periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteByPrimaryKey(String Peric_canio)
        {
            try
            {
                Mant_PeriodoRepository.DeleteByPrimaryKey(Peric_canio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetExisteAnioNuevo(int Peric_canio)
        {
            try
            {
                return Mant_PeriodoRepository.GetExisteAnioNuevo(Peric_canio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> Getcoleccion(string whereSQL, string orderbySQL)
        {
            try
            {
                return Mant_PeriodoRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Mant_Periodo> llenarPeriodo()
        {
            try {
                return Mant_PeriodoRepository.llenarPeriodo();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           

        }//
        public int GetPeriodoActivo()
        {
            try
            {
                return Mant_PeriodoRepository.GetPeriodoActivo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//()
        public int ExistePeriodoActivoNuevo()
        {
            try
            {
                return Mant_PeriodoRepository.ExistePeriodoActivoNuevo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//ExistePeriodoActivoNuevo()
        public int ExistePeriodoActivoModificar(int periodo)
        {
            try
            {
                return Mant_PeriodoRepository.ExistePeriodoActivoModificar(periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//ExistePeriodoActivoNuevo()
        public List<Mant_Periodo> listarCboPeriodov2()
        {
            try
            {
                return Mant_PeriodoRepository.listarPeriodov2();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

