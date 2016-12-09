using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
namespace SGR.Core.Repository
{
    public class Pred_Descuentos_ExoneracionRepository
    {
        private const String nombreprocedimiento = "_Pred_Descuentos_Exoneraciones";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Pred_Descuentos_Exoneracion> listartodos(Int32 periodo, String contribuyente_ID)
        {
            try
            {
                var coleccion = new List<Pred_Descuentos_Exoneracion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "anio", DbType.String, periodo);
                db.AddInParameter(SQL, "contribuyente_ID", DbType.String, contribuyente_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Descuentos_Exoneracion
                        {
                            des_exo_ID = lector.GetInt32(lector.GetOrdinal("des_exo_ID")),
                            //codigo_exo = lector.IsDBNull(lector.GetOrdinal("codigo_exo")) ? default(String) : lector.GetString(lector.GetOrdinal("codigo_exo")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_operacion")),
                            tipo = lector.GetInt16(lector.GetOrdinal("tipo")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            resolucion = lector.IsDBNull(lector.GetOrdinal("resolucion")) ? default(String) : lector.GetString(lector.GetOrdinal("resolucion")),
                            resol_imagen = lector.IsDBNull(lector.GetOrdinal("resol_imagen")) ? default(String) : lector.GetString(lector.GetOrdinal("resol_imagen")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            //fecha_inicio = lector.IsDBNull(lector.GetOrdinal("fecha_inicio")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_inicio")),
                            //fecha_fin = lector.IsDBNull(lector.GetOrdinal("fecha_fin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_fin")),
                            anioInicio = lector.IsDBNull(lector.GetOrdinal("anioInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioInicio")),
                            mesInicio = lector.IsDBNull(lector.GetOrdinal("mesInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mesInicio")),
                            anioFin = lector.IsDBNull(lector.GetOrdinal("anioFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioFin")),
                            mesFin = lector.IsDBNull(lector.GetOrdinal("mesFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mesFin")),
                            porcentaje_dcto = lector.IsDBNull(lector.GetOrdinal("porcentaje_dcto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("porcentaje_dcto")),
                            efec_descuento = lector.IsDBNull(lector.GetOrdinal("efec_descuento")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("efec_descuento")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            condicion = lector.IsDBNull(lector.GetOrdinal("condicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("condicion")),
                            contribuyente_ID = lector.IsDBNull(lector.GetOrdinal("contribuyente_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("contribuyente_ID")),
                            predio_ID = lector.IsDBNull(lector.GetOrdinal("predio_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.IsDBNull(lector.GetOrdinal("tributo_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_ID")),
                            motivo = lector.IsDBNull(lector.GetOrdinal("motivo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("motivo")),
                            base_imponible = lector.IsDBNull(lector.GetOrdinal("base_imponible")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            deduccion = lector.IsDBNull(lector.GetOrdinal("deduccion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("deduccion")),
                            monto_afectado = lector.IsDBNull(lector.GetOrdinal("monto_afectado")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_afectado")),
                            impuesto_anual = lector.IsDBNull(lector.GetOrdinal("impuesto_anual")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("impuesto_anual")),
                            formularios = lector.IsDBNull(lector.GetOrdinal("formularios")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("formularios")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            tipo_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_descripcion")),
                            tipo_operacion_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_operacion_descripcion")),
                            motivo_descripcion = lector.IsDBNull(lector.GetOrdinal("motivo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("motivo_descripcion")),
                            condicion_descripcion = lector.IsDBNull(lector.GetOrdinal("condicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("condicion_descripcion")),
                            predio_descripcion = lector.IsDBNull(lector.GetOrdinal("predio_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_descripcion")),
                            tributo_descripcion = lector.IsDBNull(lector.GetOrdinal("tributo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_descripcion"))

                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Pred_Descuentos_Exoneracion> ObtenerPorcontribuyente_ID(String contribuyente_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "contribuyente_ID", DbType.String);
                var coleccion = new List<Pred_Descuentos_Exoneracion>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Descuentos_Exoneracion
                        {
                            des_exo_ID = lector.GetInt32(lector.GetOrdinal("des_exo_ID")),
                            //codigo_exo = lector.IsDBNull(lector.GetOrdinal("codigo_exo")) ? default(String) : lector.GetString(lector.GetOrdinal("codigo_exo")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_operacion")),
                            tipo = lector.GetInt16(lector.GetOrdinal("tipo")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            resolucion = lector.IsDBNull(lector.GetOrdinal("resolucion")) ? default(String) : lector.GetString(lector.GetOrdinal("resolucion")),
                            resol_imagen = lector.IsDBNull(lector.GetOrdinal("resol_imagen")) ? default(String) : lector.GetString(lector.GetOrdinal("resol_imagen")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            //fecha_inicio = lector.IsDBNull(lector.GetOrdinal("fecha_inicio")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_inicio")),
                            //fecha_fin = lector.IsDBNull(lector.GetOrdinal("fecha_fin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_fin")),
                            anioInicio = lector.IsDBNull(lector.GetOrdinal("anioInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioInicio")),
                            mesInicio = lector.IsDBNull(lector.GetOrdinal("mesInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("medInicio")),
                            anioFin = lector.IsDBNull(lector.GetOrdinal("anioFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioFin")),
                            mesFin = lector.IsDBNull(lector.GetOrdinal("mesFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mesFin")),
                            porcentaje_dcto = lector.IsDBNull(lector.GetOrdinal("porcentaje_dcto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("porcentaje_dcto")),
                            efec_descuento = lector.IsDBNull(lector.GetOrdinal("efec_descuento")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("efec_descuento")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            condicion = lector.IsDBNull(lector.GetOrdinal("condicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("condicion")),
                            contribuyente_ID = lector.IsDBNull(lector.GetOrdinal("contribuyente_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("contribuyente_ID")),
                            predio_ID = lector.IsDBNull(lector.GetOrdinal("predio_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.IsDBNull(lector.GetOrdinal("tributo_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_ID")),
                            motivo = lector.IsDBNull(lector.GetOrdinal("motivo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("motivo")),
                            base_imponible = lector.IsDBNull(lector.GetOrdinal("base_imponible")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            deduccion = lector.IsDBNull(lector.GetOrdinal("deduccion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("deduccion")),
                            monto_afectado = lector.IsDBNull(lector.GetOrdinal("monto_afectado")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_afectado")),
                            impuesto_anual = lector.IsDBNull(lector.GetOrdinal("impuesto_anual")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("impuesto_anual")),
                            formularios = lector.IsDBNull(lector.GetOrdinal("formularios")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("formularios")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            tipo_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_descripcion")),
                            tipo_operacion_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_operacion_descripcion")),
                            motivo_descripcion = lector.IsDBNull(lector.GetOrdinal("motivo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("motivo_descripcion")),
                            condicion_descripcion = lector.IsDBNull(lector.GetOrdinal("condicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("condicion_descripcion")),
                            predio_descripcion = lector.IsDBNull(lector.GetOrdinal("predio_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_descripcion")),
                            tributo_descripcion = lector.IsDBNull(lector.GetOrdinal("tributo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_descripcion"))

                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public virtual bool EliminarPorcontribuyente_ID(String contribuyente_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "contribuyente_ID", DbType.String);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Pred_Descuentos_Exoneracion GetByPrimaryKey(Int32 des_exo_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "des_exo_ID", DbType.Int32, des_exo_ID);
                var Pred_Descuentos_Exoneracion = default(Pred_Descuentos_Exoneracion);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_Descuentos_Exoneracion = new Pred_Descuentos_Exoneracion
                        {
                            //des_exo_ID = lector.GetInt32(lector.GetOrdinal("des_exo_ID")),
                            ////codigo_exo = lector.IsDBNull(lector.GetOrdinal("codigo_exo")) ? default(String) : lector.GetString(lector.GetOrdinal("codigo_exo")),
                            //tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_operacion")),
                            //tipo = lector.GetInt16(lector.GetOrdinal("tipo")),
                            //fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            //expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            //resolucion = lector.IsDBNull(lector.GetOrdinal("resolucion")) ? default(String) : lector.GetString(lector.GetOrdinal("resolucion")),
                            //resol_imagen = lector.IsDBNull(lector.GetOrdinal("resol_imagen")) ? default(String) : lector.GetString(lector.GetOrdinal("resol_imagen")),
                            //anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            ////fecha_inicio = lector.IsDBNull(lector.GetOrdinal("fecha_inicio")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_inicio")),
                            ////fecha_fin = lector.IsDBNull(lector.GetOrdinal("fecha_fin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_fin")),
                            //anioInicio = lector.IsDBNull(lector.GetOrdinal("anioInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioInicio")),
                            //mesInicio = lector.IsDBNull(lector.GetOrdinal("mesInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("medInicio")),
                            //anioFin = lector.IsDBNull(lector.GetOrdinal("anioFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioFin")),
                            //mesFin = lector.IsDBNull(lector.GetOrdinal("mesFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mesFin")),
                            //porcentaje_dcto = lector.IsDBNull(lector.GetOrdinal("porcentaje_dcto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("porcentaje_dcto")),
                            //efec_descuento = lector.IsDBNull(lector.GetOrdinal("efec_descuento")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("efec_descuento")),
                            //observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            //estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            //condicion = lector.IsDBNull(lector.GetOrdinal("condicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("condicion")),
                            //contribuyente_ID = lector.IsDBNull(lector.GetOrdinal("contribuyente_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("contribuyente_ID")),
                            //predio_ID = lector.IsDBNull(lector.GetOrdinal("predio_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_ID")),
                            //tributo_ID = lector.IsDBNull(lector.GetOrdinal("tributo_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_ID")),
                            //motivo = lector.IsDBNull(lector.GetOrdinal("motivo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("motivo")),
                            base_imponible = lector.IsDBNull(lector.GetOrdinal("base_imponible")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            efec_descuento = lector.IsDBNull(lector.GetOrdinal("efec_descuento")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("efec_descuento")),
                            deduccion = lector.IsDBNull(lector.GetOrdinal("deduccion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("deduccion")),
                            //monto_afectado = lector.IsDBNull(lector.GetOrdinal("monto_afectado")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_afectado")),
                            //impuesto_anual = lector.IsDBNull(lector.GetOrdinal("impuesto_anual")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("impuesto_anual")),
                            formularios = lector.IsDBNull(lector.GetOrdinal("formularios")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("formularios")),
                            ////registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            ////registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            ////registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            ////registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            ////registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            ////registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            //tipo_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_descripcion")),
                            //tipo_operacion_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_operacion_descripcion")),
                            //motivo_descripcion = lector.IsDBNull(lector.GetOrdinal("motivo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("motivo_descripcion")),
                            //condicion_descripcion = lector.IsDBNull(lector.GetOrdinal("condicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("condicion_descripcion")),
                            //predio_descripcion = lector.IsDBNull(lector.GetOrdinal("predio_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_descripcion")),
                            //tributo_descripcion = lector.IsDBNull(lector.GetOrdinal("tributo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_descripcion"))

                        };
                    }
                }
                SQL.Dispose();
                return Pred_Descuentos_Exoneracion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual int Insert(Pred_Descuentos_Exoneracion Pred_Descuentos_Exoneracion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "codigo_exo", DbType.String, Pred_Descuentos_Exoneracion.codigo_exo);
                db.AddInParameter(SQL, "tipo_operacion", DbType.Int16, Pred_Descuentos_Exoneracion.tipo_operacion);
                db.AddInParameter(SQL, "tipo", DbType.Int16, Pred_Descuentos_Exoneracion.tipo);
                //db.AddInParameter(SQL, "fecha", DbType.DateTime, Pred_Descuentos_Exoneracion.fecha);
                db.AddInParameter(SQL, "expediente", DbType.String, Pred_Descuentos_Exoneracion.expediente);
                db.AddInParameter(SQL, "resolucion", DbType.String, Pred_Descuentos_Exoneracion.resolucion);
                db.AddInParameter(SQL, "resol_imagen", DbType.String, Pred_Descuentos_Exoneracion.resol_imagen);
                //db.AddInParameter(SQL, "anio", DbType.Int16, Pred_Descuentos_Exoneracion.anio);
                //db.AddInParameter(SQL, "fecha_inicio", DbType.DateTime, Pred_Descuentos_Exoneracion.fecha_inicio);
                //db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, Pred_Descuentos_Exoneracion.fecha_fin);
                db.AddInParameter(SQL, "porcentaje_dcto", DbType.Decimal, Pred_Descuentos_Exoneracion.porcentaje_dcto);
                //db.AddInParameter(SQL, "efec_descuento", DbType.Decimal, Pred_Descuentos_Exoneracion.efec_descuento);
                db.AddInParameter(SQL, "observaciones", DbType.String, Pred_Descuentos_Exoneracion.observaciones);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_Descuentos_Exoneracion.estado);
                db.AddInParameter(SQL, "condicion", DbType.String, Pred_Descuentos_Exoneracion.condicion);
                db.AddInParameter(SQL, "contribuyente_ID", DbType.String, Pred_Descuentos_Exoneracion.contribuyente_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, Pred_Descuentos_Exoneracion.predio_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, Pred_Descuentos_Exoneracion.tributo_ID);
                db.AddInParameter(SQL, "motivo", DbType.Int16, Pred_Descuentos_Exoneracion.motivo);
                //db.AddInParameter(SQL, "formularios", DbType.Decimal, Pred_Descuentos_Exoneracion.formularios);
                db.AddInParameter(SQL, "anioFin", DbType.Int16, Pred_Descuentos_Exoneracion.anioFin);
                db.AddInParameter(SQL, "anioInicio", DbType.Int16, Pred_Descuentos_Exoneracion.anioInicio);
                db.AddInParameter(SQL, "mesFin", DbType.Int16, Pred_Descuentos_Exoneracion.mesFin);
                db.AddInParameter(SQL, "mesInicio", DbType.Int16, Pred_Descuentos_Exoneracion.mesInicio);
                //db.AddInParameter(SQL, "base_imponible", DbType.Decimal, Pred_Descuentos_Exoneracion.base_imponible);
                //db.AddInParameter(SQL, "deduccion", DbType.Decimal, Pred_Descuentos_Exoneracion.deduccion);
                //db.AddInParameter(SQL, "monto_afectado", DbType.Decimal, Pred_Descuentos_Exoneracion.monto_afectado);
                //db.AddInParameter(SQL, "impuesto_anual", DbType.Decimal, Pred_Descuentos_Exoneracion.impuesto_anual);
                //db.AddInParameter(SQL, "formularios", DbType.Decimal, Pred_Descuentos_Exoneracion.formularios);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Pred_Descuentos_Exoneracion.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Pred_Descuentos_Exoneracion.registro_pc_add);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Pred_Descuentos_Exoneracion.registro_user_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Pred_Descuentos_Exoneracion.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Pred_Descuentos_Exoneracion.registro_pc_update);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_Descuentos_Exoneracion.registro_user_add);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Pred_Descuentos_Exoneracion Pred_Descuentos_Exoneracion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "des_exo_ID", DbType.Int32, Pred_Descuentos_Exoneracion.des_exo_ID);
                //db.AddInParameter(SQL, "codigo_exo", DbType.String, Pred_Descuentos_Exoneracion.codigo_exo);
                //db.AddInParameter(SQL, "tipo_operacion", DbType.Int32, Pred_Descuentos_Exoneracion.tipo_operacion);
                //db.AddInParameter(SQL, "tipo", DbType.Int16, Pred_Descuentos_Exoneracion.tipo);
                //db.AddInParameter(SQL, "fecha", DbType.DateTime, Pred_Descuentos_Exoneracion.fecha);
                db.AddInParameter(SQL, "expediente", DbType.String, Pred_Descuentos_Exoneracion.expediente);
                db.AddInParameter(SQL, "resolucion", DbType.String, Pred_Descuentos_Exoneracion.resolucion);
                db.AddInParameter(SQL, "resol_imagen", DbType.String, Pred_Descuentos_Exoneracion.resol_imagen);
                //db.AddInParameter(SQL, "anio", DbType.Int16, Pred_Descuentos_Exoneracion.anio);
                //db.AddInParameter(SQL, "fecha_inicio", DbType.DateTime, Pred_Descuentos_Exoneracion.fecha_inicio);
                //db.AddInParameter(SQL, "fecha_fin", DbType.DateTime, Pred_Descuentos_Exoneracion.fecha_fin);
                //db.AddInParameter(SQL, "porcentaje_dcto", DbType.Decimal, Pred_Descuentos_Exoneracion.porcentaje_dcto);
                //db.AddInParameter(SQL, "efec_descuento", DbType.Decimal, Pred_Descuentos_Exoneracion.efec_descuento);
                db.AddInParameter(SQL, "observaciones", DbType.String, Pred_Descuentos_Exoneracion.observaciones);
                db.AddInParameter(SQL, "estado", DbType.String, Pred_Descuentos_Exoneracion.estado);
                //db.AddInParameter(SQL, "condicion", DbType.String, Pred_Descuentos_Exoneracion.condicion);
                //db.AddInParameter(SQL, "contribuyente_ID", DbType.String, Pred_Descuentos_Exoneracion.contribuyente_ID);
                //db.AddInParameter(SQL, "predio_ID", DbType.String, Pred_Descuentos_Exoneracion.predio_ID);
                //db.AddInParameter(SQL, "tributo_ID", DbType.String, Pred_Descuentos_Exoneracion.tributo_ID);
                db.AddInParameter(SQL, "motivo", DbType.String, Pred_Descuentos_Exoneracion.motivo);
                //db.AddInParameter(SQL, "base_imponible", DbType.Decimal, Pred_Descuentos_Exoneracion.base_imponible);
                //db.AddInParameter(SQL, "deduccion", DbType.Decimal, Pred_Descuentos_Exoneracion.deduccion);
                //db.AddInParameter(SQL, "monto_afectado", DbType.Decimal, Pred_Descuentos_Exoneracion.monto_afectado);
                //db.AddInParameter(SQL, "impuesto_anual", DbType.Decimal, Pred_Descuentos_Exoneracion.impuesto_anual);
                //db.AddInParameter(SQL, "formularios", DbType.Decimal, Pred_Descuentos_Exoneracion.formularios);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, Pred_Descuentos_Exoneracion.registro_fecha_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, Pred_Descuentos_Exoneracion.registro_pc_add);
                //db.AddInParameter(SQL, "registro_user_add", DbType.Int32, Pred_Descuentos_Exoneracion.registro_user_add);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, Pred_Descuentos_Exoneracion.registro_fecha_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, Pred_Descuentos_Exoneracion.registro_pc_update);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_Descuentos_Exoneracion.registro_user_update);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual bool DeleteByPrimaryKey(Int32 des_exo_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "des_exo_ID", DbType.Int32, des_exo_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual bool DeleteAll()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 6);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void UpdateCondicion(int condicion, String user, int id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "des_exo_ID", DbType.Int32, id);
                db.AddInParameter(SQL, "condicion", DbType.String, condicion);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, user);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 9);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Int32 ExisteCuentaCorrienteParaExoneracion(int mesInicio, int anioInicio, int mesFin, int anioFin, String contribuyente_ID, String tributo_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "mesInicio", DbType.String, mesInicio);
                db.AddInParameter(SQL, "anioInicio", DbType.String, anioInicio);
                db.AddInParameter(SQL, "mesFin", DbType.String, mesFin);
                db.AddInParameter(SQL, "anioFin", DbType.String, anioFin);
                db.AddInParameter(SQL, "contribuyente_ID", DbType.String, contribuyente_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                Int32 total = 0;
                total = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual String ExisteParametroParaExoneracion()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                return Convert.ToString(db.ExecuteScalar(SQL));
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Descuentos_Exoneracion> listarPreExon(string periodo, string razon_social, String tipo_operacion, bool todosAnios)
        {
            try
            {
                var coleccion = new List<Pred_Descuentos_Exoneracion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                if (todosAnios)
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
                else
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "anio", DbType.String, periodo);
                db.AddInParameter(SQL, "razon_social", DbType.String, razon_social);
                db.AddInParameter(SQL, "tipo_operacion", DbType.String, tipo_operacion);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Descuentos_Exoneracion
                        {
                            des_exo_ID = lector.GetInt32(lector.GetOrdinal("des_exo_ID")),
                            //codigo_exo = lector.IsDBNull(lector.GetOrdinal("codigo_exo")) ? default(String) : lector.GetString(lector.GetOrdinal("codigo_exo")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_operacion")),
                            tipo = lector.GetInt16(lector.GetOrdinal("tipo")),
                            fecha = lector.GetDateTime(lector.GetOrdinal("fecha")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            resolucion = lector.IsDBNull(lector.GetOrdinal("resolucion")) ? default(String) : lector.GetString(lector.GetOrdinal("resolucion")),
                            resol_imagen = lector.IsDBNull(lector.GetOrdinal("resol_imagen")) ? default(String) : lector.GetString(lector.GetOrdinal("resol_imagen")),
                            anio = lector.GetInt16(lector.GetOrdinal("anio")),
                            //fecha_inicio = lector.IsDBNull(lector.GetOrdinal("fecha_inicio")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_inicio")),
                            //fecha_fin = lector.IsDBNull(lector.GetOrdinal("fecha_fin")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_fin")),
                            anioInicio = lector.IsDBNull(lector.GetOrdinal("anioInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioInicio")),
                            mesInicio = lector.IsDBNull(lector.GetOrdinal("mesInicio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mesInicio")),
                            anioFin = lector.IsDBNull(lector.GetOrdinal("anioFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anioFin")),
                            mesFin = lector.IsDBNull(lector.GetOrdinal("mesFin")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("mesFin")),
                            porcentaje_dcto = lector.IsDBNull(lector.GetOrdinal("porcentaje_dcto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("porcentaje_dcto")),
                            efec_descuento = lector.IsDBNull(lector.GetOrdinal("efec_descuento")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("efec_descuento")),
                            observaciones = lector.IsDBNull(lector.GetOrdinal("observaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("observaciones")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            condicion = lector.IsDBNull(lector.GetOrdinal("condicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("condicion")),
                            contribuyente_ID = lector.IsDBNull(lector.GetOrdinal("contribuyente_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("contribuyente_ID")),
                            predio_ID = lector.IsDBNull(lector.GetOrdinal("predio_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_ID")),
                            tributo_ID = lector.IsDBNull(lector.GetOrdinal("tributo_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_ID")),
                            motivo = lector.IsDBNull(lector.GetOrdinal("motivo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("motivo")),
                            base_imponible = lector.IsDBNull(lector.GetOrdinal("base_imponible")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            deduccion = lector.IsDBNull(lector.GetOrdinal("deduccion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("deduccion")),
                            monto_afectado = lector.IsDBNull(lector.GetOrdinal("monto_afectado")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_afectado")),
                            impuesto_anual = lector.IsDBNull(lector.GetOrdinal("impuesto_anual")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("impuesto_anual")),
                            formularios = lector.IsDBNull(lector.GetOrdinal("formularios")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("formularios")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            tipo_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_descripcion")),
                            tipo_operacion_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_operacion_descripcion")),
                            motivo_descripcion = lector.IsDBNull(lector.GetOrdinal("motivo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("motivo_descripcion")),
                            condicion_descripcion = lector.IsDBNull(lector.GetOrdinal("condicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("condicion_descripcion")),
                            predio_descripcion = lector.IsDBNull(lector.GetOrdinal("predio_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_descripcion")),
                            tributo_descripcion = lector.IsDBNull(lector.GetOrdinal("tributo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tributo_descripcion"))

                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
