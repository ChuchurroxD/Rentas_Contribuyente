using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;
using SGR.Core.Service;
namespace SGR.Core.Repository
{
    public class Pred_PisosFisRepository
    {
        private const String nombreprocedimiento = "_Pred_PisosFis";
        private const String NombreTabla = "Pisos";
        private Database db = DatabaseFactory.CreateDatabase();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private int periodo;
        public List<Pred_Pisos> listarByPredioID(String predio_ID, string periodo)
        {
            try
            {
                var coleccion = new List<Pred_Pisos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Pisos
                        {
                            piso_ID = lector.GetInt32(lector.GetOrdinal("piso_ID")),
                            numero = lector.IsDBNull(lector.GetOrdinal("numero")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("numero")),
                            seccion = lector.IsDBNull(lector.GetOrdinal("seccion")) ? default(String) : lector.GetString(lector.GetOrdinal("seccion")),
                            fecha_construc = lector.IsDBNull(lector.GetOrdinal("fecha_construc")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_construc")),
                            antiguedad = lector.IsDBNull(lector.GetOrdinal("antiguedad")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("antiguedad")),
                            muro = lector.IsDBNull(lector.GetOrdinal("muro")) ? default(String) : lector.GetString(lector.GetOrdinal("muro")),
                            techo = lector.IsDBNull(lector.GetOrdinal("techo")) ? default(String) : lector.GetString(lector.GetOrdinal("techo")),
                            piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                            puerta = lector.IsDBNull(lector.GetOrdinal("puerta")) ? default(String) : lector.GetString(lector.GetOrdinal("puerta")),
                            revestimiento = lector.IsDBNull(lector.GetOrdinal("revestimiento")) ? default(String) : lector.GetString(lector.GetOrdinal("revestimiento")),
                            banio = lector.IsDBNull(lector.GetOrdinal("banio")) ? default(String) : lector.GetString(lector.GetOrdinal("banio")),
                            instalaciones = lector.IsDBNull(lector.GetOrdinal("instalaciones")) ? default(String) : lector.GetString(lector.GetOrdinal("instalaciones")),
                            valor_unitario = lector.IsDBNull(lector.GetOrdinal("valor_unitario")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_unitario")),
                            incremento = lector.IsDBNull(lector.GetOrdinal("incremento")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("incremento")),
                            porcent_depreci = lector.IsDBNull(lector.GetOrdinal("porcent_depreci")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("porcent_depreci")),
                            valor_unit_depreciado = lector.IsDBNull(lector.GetOrdinal("valor_unit_depreciado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_unit_depreciado")),
                            area_construida = lector.IsDBNull(lector.GetOrdinal("area_construida")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("area_construida")),
                            valor_construido = lector.IsDBNull(lector.GetOrdinal("valor_construido")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_construido")),
                            area_comun = lector.IsDBNull(lector.GetOrdinal("area_comun")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("area_comun")),
                            valor_comun = lector.IsDBNull(lector.GetOrdinal("valor_comun")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_comun")),
                            valor_construido_total = lector.IsDBNull(lector.GetOrdinal("valor_construido_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valor_construido_total")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            piso_clasificacion = lector.IsDBNull(lector.GetOrdinal("piso_clasificacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("piso_clasificacion")),
                            piso_material = lector.IsDBNull(lector.GetOrdinal("piso_material")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("piso_material")),
                            piso_estado = lector.IsDBNull(lector.GetOrdinal("piso_estado")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("piso_estado")),
                            condicion = lector.IsDBNull(lector.GetOrdinal("condicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("condicion")),
                            persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                            metros_alquilados = lector.IsDBNull(lector.GetOrdinal("metros_alquilados")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("metros_alquilados")),
                            clase = lector.IsDBNull(lector.GetOrdinal("clase")) ? default(String) : lector.GetString(lector.GetOrdinal("clase")),
                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //multitabla
                            clasificacion_id = lector.IsDBNull(lector.GetOrdinal("clasificacion_id")) ? default(String) : lector.GetString(lector.GetOrdinal("clasificacion_id")),
                            clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("clasificacion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("clasificacion_descripcion")),
                            material_id = lector.IsDBNull(lector.GetOrdinal("material_id")) ? default(String) : lector.GetString(lector.GetOrdinal("material_id")),
                            material_descripcion = lector.IsDBNull(lector.GetOrdinal("material_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("material_descripcion")),
                            estado_id = lector.IsDBNull(lector.GetOrdinal("estado_id")) ? default(String) : lector.GetString(lector.GetOrdinal("estado_id")),
                            estado_descripcion = lector.IsDBNull(lector.GetOrdinal("estado_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("estado_descripcion")),
                            condicion_id = lector.IsDBNull(lector.GetOrdinal("condicion_id")) ? default(String) : lector.GetString(lector.GetOrdinal("condicion_id")),
                            condicion_descripcion = lector.IsDBNull(lector.GetOrdinal("condicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("condicion_descripcion")),
                            antiguedad_id = lector.IsDBNull(lector.GetOrdinal("antiguedad_id")) ? default(String) : lector.GetString(lector.GetOrdinal("antiguedad_id")),
                            antiguedad_descripcion = lector.IsDBNull(lector.GetOrdinal("antiguedad_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("antiguedad_descripcion")),
                            //razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social"))

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
        public virtual int Insert(Pred_Pisos pisos, int periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "numero", DbType.Int32, pisos.numero);
                db.AddInParameter(SQL, "seccion", DbType.String, pisos.seccion);
                db.AddInParameter(SQL, "fecha_construc", DbType.DateTime, pisos.fecha_construc);
                //db.AddInParameter(SQL, "antiguedad", DbType.Int32, pisos.antiguedad_id);
                db.AddInParameter(SQL, "muro", DbType.String, pisos.muro);
                db.AddInParameter(SQL, "techo", DbType.String, pisos.techo);
                db.AddInParameter(SQL, "piso", DbType.String, pisos.piso);
                db.AddInParameter(SQL, "puerta", DbType.String, pisos.puerta);
                db.AddInParameter(SQL, "revestimiento", DbType.String, pisos.revestimiento);
                db.AddInParameter(SQL, "banio", DbType.String, pisos.banio);
                db.AddInParameter(SQL, "instalaciones", DbType.String, pisos.instalaciones);
                //  db.AddInParameter(SQL, "valor_unitario", DbType.Decimal, pisos.valor_unitario);
                db.AddInParameter(SQL, "incremento", DbType.Decimal, pisos.incremento);
                // db.AddInParameter(SQL, "porcent_depreci", DbType.Decimal, pisos.porcent_depreci);
                //db.AddInParameter(SQL, "valor_unit_depreciado", DbType.Decimal, pisos.valor_unit_depreciado);
                db.AddInParameter(SQL, "area_construida", DbType.Decimal, pisos.area_construida);
                // db.AddInParameter(SQL, "valor_construido", DbType.Decimal, pisos.valor_construido);
                db.AddInParameter(SQL, "area_comun", DbType.Decimal, pisos.area_comun);
                //db.AddInParameter(SQL, "valor_comun", DbType.Decimal, pisos.valor_comun);
                //db.AddInParameter(SQL, "valor_construido_total", DbType.Decimal, pisos.valor_construido_total);
                db.AddInParameter(SQL, "anio", DbType.Int16, pisos.anio);
                db.AddInParameter(SQL, "estado", DbType.Boolean, pisos.estado);
                db.AddInParameter(SQL, "predio_ID", DbType.String, pisos.predio_ID);
                db.AddInParameter(SQL, "piso_clasificacion", DbType.Int32, pisos.clasificacion_id);
                db.AddInParameter(SQL, "piso_material", DbType.Int32, pisos.material_id);
                db.AddInParameter(SQL, "piso_estado", DbType.Int32, pisos.estado_id);
                db.AddInParameter(SQL, "condicion", DbType.Int16, pisos.condicion_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, pisos.persona_ID);
                db.AddInParameter(SQL, "metros_alquilados", DbType.Decimal, pisos.metros_alquilados);
                db.AddInParameter(SQL, "clase", DbType.String, pisos.clase);
                db.AddInParameter(SQL, "registro_user", DbType.String, pisos.registro_user_add);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                //////var numerogenerado = (int)db.GetParameterValue(SQL, "piso_ID");
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Pred_Pisos pisos, int periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "piso_ID", DbType.Int32, pisos.piso_ID);
                db.AddInParameter(SQL, "numero", DbType.Int32, pisos.numero);
                db.AddInParameter(SQL, "seccion", DbType.String, pisos.seccion);
                db.AddInParameter(SQL, "fecha_construc", DbType.DateTime, pisos.fecha_construc);
                //db.AddInParameter(SQL, "antiguedad", DbType.Int32, pisos.antiguedad_id);
                db.AddInParameter(SQL, "muro", DbType.String, pisos.muro);
                db.AddInParameter(SQL, "techo", DbType.String, pisos.techo);
                db.AddInParameter(SQL, "piso", DbType.String, pisos.piso);
                db.AddInParameter(SQL, "puerta", DbType.String, pisos.puerta);
                db.AddInParameter(SQL, "revestimiento", DbType.String, pisos.revestimiento);
                db.AddInParameter(SQL, "banio", DbType.String, pisos.banio);
                db.AddInParameter(SQL, "instalaciones", DbType.String, pisos.instalaciones);
                //db.AddInParameter(SQL, "valor_unitario", DbType.Decimal, pisos.valor_unitario);
                db.AddInParameter(SQL, "incremento", DbType.Decimal, pisos.incremento);
                //db.AddInParameter(SQL, "porcent_depreci", DbType.Decimal, pisos.porcent_depreci);
                //db.AddInParameter(SQL, "valor_unit_depreciado", DbType.Decimal, pisos.valor_unit_depreciado);
                db.AddInParameter(SQL, "area_construida", DbType.Decimal, pisos.area_construida);
                //db.AddInParameter(SQL, "valor_construido", DbType.Decimal, pisos.valor_construido);
                db.AddInParameter(SQL, "area_comun", DbType.Decimal, pisos.area_comun);
                // db.AddInParameter(SQL, "valor_comun", DbType.Decimal, pisos.valor_comun);
                //  db.AddInParameter(SQL, "valor_construido_total", DbType.Decimal, pisos.valor_construido_total);
                db.AddInParameter(SQL, "anio", DbType.Int16, pisos.anio);
                db.AddInParameter(SQL, "estado", DbType.Boolean, pisos.estado);
                db.AddInParameter(SQL, "predio_ID", DbType.String, pisos.predio_ID);
                db.AddInParameter(SQL, "piso_clasificacion", DbType.Int32, pisos.clasificacion_id);
                db.AddInParameter(SQL, "piso_material", DbType.Int32, pisos.material_id);
                db.AddInParameter(SQL, "piso_estado", DbType.Int32, pisos.estado_id);
                db.AddInParameter(SQL, "condicion", DbType.Int16, pisos.condicion_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, pisos.persona_ID);
                db.AddInParameter(SQL, "metros_alquilados", DbType.Decimal, pisos.metros_alquilados);
                db.AddInParameter(SQL, "clase", DbType.String, pisos.clase);
                db.AddInParameter(SQL, "registro_user", DbType.String, pisos.registro_user_add);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
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

    }
}
