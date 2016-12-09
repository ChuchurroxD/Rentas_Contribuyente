using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Core;
using SGR.Entity;


namespace SGR.Core.Service
{
    public class Pago_OficinaDataService
    {
        Pago_OficinaRepository Pago_OficinaRepository = new Pago_OficinaRepository();

        public List<Pago_Oficina> llenarOficina()
        {
            try
            {
                return Pago_OficinaRepository.llenarOficina();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetExisteDescripcionNuevo(String descripcion)
        {
            try
            {
                return Pago_OficinaRepository.GetExisteDescripcionNuevo(descripcion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public int GetExisteDescripcionModificar(String descripcion, Int32 odigo)
        {
            try
            {
                return Pago_OficinaRepository.GetExisteDescripcionModificar(odigo, descripcion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public int Insert(Pago_Oficina Pago_Oficina)
        {
            try
            {
                return Pago_OficinaRepository.Insert(Pago_Oficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void Update(Pago_Oficina Pago_Oficina)
        {
            try
            {
                Pago_OficinaRepository.Update(Pago_Oficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public List<Pago_Oficina> listartodos()
        {
            try
            {
                return Pago_OficinaRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }


        public List<Pago_Oficina> listarxrol(string rol_id)
        {
            try
            {
                return Pago_OficinaRepository.listarxrol (rol_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Pago_Oficina> Getcoleccion(string whereSQL, string orderbySQL)
        {
            try
            {
                return Pago_OficinaRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteByPrimaryKey(Int32 id)
        {
            
            try
            {
                Pago_OficinaRepository.DeleteByPrimaryKey(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pago_Oficina> listarComboOficina()
        {
            try
            {
                return Pago_OficinaRepository.listarComboOficina();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Oficina> listarComboOficinaCajero(int oficina)
        {
            try
            {
                return Pago_OficinaRepository.listarComboOficinaCajero(oficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pago_Oficina> listarActivos()
        {
            try
            {
                return Pago_OficinaRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
