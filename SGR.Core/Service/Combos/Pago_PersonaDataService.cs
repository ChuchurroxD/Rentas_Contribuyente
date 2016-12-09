using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model.Combos;
using SGR.Core.Repository.Combos;

namespace SGR.Core.Service.Combos
{
    public class Pago_PersonaDataService
    {
        Pago_PersonaRepository persona = new Pago_PersonaRepository();
        public List<Pago_Persona> listartodos(String persona)
        {
            try
            {
                return this.persona.listartodos(persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Persona> buscar(String busqueda)
        {
            try
            {
                return persona.buscar(busqueda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Persona> listarcontribuyentes(string busqueda)
        {
            try
            {
                return this.persona.listarcontribuyentes(busqueda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//listarcontribuyentesxPersona
        public List<Pago_Persona> listarcontribuyentesCodigo(string busqueda)
        {
            try
            {
                return this.persona.listarcontribuyentesCodigo(busqueda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago_Persona> listarcontribuyentesPN(String predio_id, int periodo, string busqueda)
        {
            try
            {
                return this.persona.listarcontribuyentesPN(predio_id, periodo, busqueda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//listarcontribuyentesxPersona
        public List<Pago_Persona> listarcontribuyentesPM(String predio_id, int periodo, String per_id, string busqueda)
        {
            try
            {
                return this.persona.listarcontribuyentesPM(predio_id, periodo, per_id, busqueda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//listarcontribuyentesxPersona

        public List<Pago_Persona> listarpersonaxID(string predio_id, Int32 periodo)
        {
            try
            {
                return this.persona.listarpersonaxID(predio_id, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//listarcontribuyentesxPersona
    }
}
