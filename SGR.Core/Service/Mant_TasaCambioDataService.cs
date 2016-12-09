using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Mant_TasaCambioDataService
    {
        Mant_TasaCambioRepsitory mant_TasaCambioRepsitory = new Mant_TasaCambioRepsitory();

        public List<Mant_TasaCambio> listarTodos()
        {
            try
            {
                return mant_TasaCambioRepsitory.listarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        public List<Mant_TasaCambio> Getcoleccion(string whereSQL, string orderbySQL)
        {
            try
            {
                return mant_TasaCambioRepsitory.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void insertarTasaCambio(Mant_TasaCambio mant_TasaCambio)
        {
            try
            {
                mant_TasaCambio.compararFecha(mant_TasaCambio.fecha.ToString(), mant_TasaCambioRepsitory.listarTodos());
                mant_TasaCambioRepsitory.Insert(mant_TasaCambio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateTasaCambio(Mant_TasaCambio mant_TasaCambio)
        {
            try
            {
                mant_TasaCambioRepsitory.Update(mant_TasaCambio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual List<Mant_TasaCambio> buscarByDate(string fecha)
        {
            return mant_TasaCambioRepsitory.buscarByDate(fecha);
        }
    }
}
