using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Pago_CajeroCajaDataService
    {
        Pago_CajeroCajaRepository Pago_CajeroCajaRepository = new Pago_CajeroCajaRepository();
        public void insertar(Pago_CajeroCaja Pago_CajeroCaja)
        {
            try
            {
                Pago_CajeroCajaRepository.Insert(Pago_CajeroCaja);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificar(Pago_CajeroCaja Pago_CajeroCaja)
        {
            try
            {
                Pago_CajeroCajaRepository.Update(Pago_CajeroCaja);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CajeroCaja> listartodos()
        {
            try
            {
                return Pago_CajeroCajaRepository.listartodos();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_CajeroCaja> getColeccion(string where, string order)
        {
            try
            {
                return Pago_CajeroCajaRepository.Getcoleccion(where, order);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Caja> llenarComboCaja()
        {
            try
            {
                Pago_CajaRepository Pago_CajaRepository = new Pago_CajaRepository();
                return Pago_CajaRepository.llenarcomboCaja();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Caja> llenarComboCajaporCajero(string persona_id)
        {
            try
            {
                Pago_CajaRepository Pago_CajaRepository = new Pago_CajaRepository();
                return Pago_CajaRepository.llenarComboCajaporCajero(persona_id);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Cajero> llenarComboCajero()
        {
            try
            {
                Pago_CajeroRepository Pago_CajeroRepository = new Pago_CajeroRepository();
                return Pago_CajeroRepository.llenarcomboCajero();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
