using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Liqu_DeudaDetalleMontoDataService
    {

        private static Liqu_DeudaDetalleMontoRepository liqu_MontoDetalle = new Liqu_DeudaDetalleMontoRepository();

        public List<Liqu_DeudaDetalleMonto> listartodos(string persona,string periodo,string grupo_trib)
        {
            try
            {
                return liqu_MontoDetalle.listartodos(persona,periodo, grupo_trib);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_DeudaDetalleTributo> listartodos2(string persona,string periodo, string grupo_trib)
        {
            try
            {
                return liqu_MontoDetalle.listartodos2(persona,periodo,grupo_trib);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_DeudaDetalleTributo> listartodos3(string persona, string predio, string tributos,
            int anio_ini, int anio_fin, int mes_ini, int mes_fin)
        {
            try
            {
                return liqu_MontoDetalle.listartodos3(persona, predio, tributos,anio_ini,anio_fin,mes_ini,mes_fin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_DeudaDetalleTributo> listardetalleTributoporLiquidacion(Int32 liquidacion_id)
        {
            try
            {
                return liqu_MontoDetalle.listarTodosporLiquidacion(liquidacion_id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
    }
}
