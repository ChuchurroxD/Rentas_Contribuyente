using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;


namespace SGR.Core.Service
{
    public class Pago_CajeroDataService
    {
        Pago_CajeroRepository pago_Cajero = new Pago_CajeroRepository();
        public List<Pago_Cajero> listartodos()
        {
            try
            {
                return pago_Cajero.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Pago_Cajero GetByPrimaryKey(String Persona_id)
        {
            try
            {
                return pago_Cajero.GetByPrimaryKey(Persona_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pago_Cajero> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return pago_Cajero.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Pago_Cajero Cajero)
        {
            try
            {
                return pago_Cajero.Insert(Cajero);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pago_Cajero Cajero)
        {
            try
            {
                pago_Cajero.Update(Cajero);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Cajero> llenarcomboCajerov2()
        {
            try
            {
                return pago_Cajero.llenarcomboCajerov2();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
