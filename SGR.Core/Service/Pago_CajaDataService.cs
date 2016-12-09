using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Pago_CajaDataService
    {
        Pago_CajaRepository Pago_CajaRepository = new Pago_CajaRepository();

        public void insert(Pago_Caja Pago_Caja)
        {
            try
            {
                if (Pago_CajaRepository.compararDescripcion(Pago_Caja.Descripcion) > 0)
                    throw new Exception("Ingrese otra descripcion, descripcion repetida");
                Pago_CajaRepository.Insert(Pago_Caja);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(Pago_Caja Pago_Caja)
        {
            try
            {
                if (Pago_CajaRepository.compararDescripcionModificar(Pago_Caja.Descripcion, Pago_Caja.Caja_id) > 0)
                    throw new Exception("Ingrese otra descripcion, descripcion repetida");
                Pago_CajaRepository.Update(Pago_Caja);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Caja> getColeccion(string whereSQL, string orderbySQL)
        {
            try { 
                return Pago_CajaRepository.Getcoleccion(whereSQL, orderbySQL);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Pago_Caja> listarDescripcion()
        {
            try
            {
                return Pago_CajaRepository.GetAllDescripcion();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void deletebycodigo(int codigo)
        {
            try
            {
                Pago_CajaRepository.DeleteByPrimaryKey(codigo);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Oficina> llenarOficina()
        {
            try
            {
                Pago_OficinaRepository Pago_OficinaRepository = new Pago_OficinaRepository();
                return Pago_OficinaRepository.llenarOficina();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Caja> llenarcomboCajav2()
        {
            try
            {
                return Pago_CajaRepository.llenarCombov2();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
