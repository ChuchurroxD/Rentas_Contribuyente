using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;
using SGR.Entity;
using SGR.Core.Service;
namespace SGR.Core.Repository
{
    public class Pred_FiscalizacionRepository
    {
        private const String nombreprocedimiento = "_Pred_Fiscalizacion";
        private Database db = DatabaseFactory.CreateDatabase();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private int periodo;

        public List<Pred_Predio> listarpredios(string persona_ID, string idPeriodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "periodo", DbType.String, idPeriodo);
                SQL.CommandTimeout = 600;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {

                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            junta_via_ID = lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                            catastro = lector.IsDBNull(lector.GetOrdinal("catastro")) ? default(String) : lector.GetString(lector.GetOrdinal("catastro")),
                            interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                            mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                            lote = lector.IsDBNull(lector.GetOrdinal("lote")) ? default(String) : lector.GetString(lector.GetOrdinal("lote")),
                            edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                            piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                            dpto = lector.IsDBNull(lector.GetOrdinal("dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("dpto")),
                            tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            kilometro = lector.IsDBNull(lector.GetOrdinal("kilometro")) ? default(String) : lector.GetString(lector.GetOrdinal("kilometro")),
                            nombre_predio = lector.IsDBNull(lector.GetOrdinal("nombre_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre_predio")),
                            //lado = lector.GetInt32(lector.GetOrdinal("lado")),
                            referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                            frente_a = lector.IsDBNull(lector.GetOrdinal("frente_a")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("frente_a")),
                            frente_metros = lector.IsDBNull(lector.GetOrdinal("frente_metros")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("frente_metros")),
                            num_personas = lector.GetInt32(lector.GetOrdinal("num_personas")),
                            fecha_terreno = lector.IsDBNull(lector.GetOrdinal("fecha_terreno")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_terreno")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_operacion")),
                            terreno_sin_construir = lector.IsDBNull(lector.GetOrdinal("terreno_sin_construir")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("terreno_sin_construir")),
                            area_terreno = lector.GetDecimal(lector.GetOrdinal("area_terreno")),
                            area_construida = lector.GetDecimal(lector.GetOrdinal("area_construida")),
                            anios_antiguedad = lector.GetInt32(lector.GetOrdinal("anios_antiguedad")),
                            tipo_inmueble = lector.IsDBNull(lector.GetOrdinal("tipo_inmueble")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_inmueble")),
                            tipo_predio = lector.IsDBNull(lector.GetOrdinal("tipo_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            estado_predio = lector.IsDBNull(lector.GetOrdinal("estado_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("estado_predio")),
                            uso_predio = lector.IsDBNull(lector.GetOrdinal("uso_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("uso_predio")),
                            uso_codigo = lector.IsDBNull(lector.GetOrdinal("uso_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("uso_codigo")),
                            num_ficha = lector.IsDBNull(lector.GetOrdinal("num_ficha")) ? default(String) : lector.GetString(lector.GetOrdinal("num_ficha")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                            clase_edificacion = lector.IsDBNull(lector.GetOrdinal("clase_edificacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("clase_edificacion")),
                            fecha_adquisicion = lector.IsDBNull(lector.GetOrdinal("fecha_adquisicion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_adquisicion")),
                            exo_predial = lector.IsDBNull(lector.GetOrdinal("exo_predial")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("exo_predial")),

                            exo_predial_porcentaje = lector.IsDBNull(lector.GetOrdinal("exo_predial_porcentaje")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("exo_predial_porcentaje")),
                            exo_anio = lector.IsDBNull(lector.GetOrdinal("exo_anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("exo_anio")),
                            motivo_exoneracion = lector.IsDBNull(lector.GetOrdinal("motivo_exoneracion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("motivo_exoneracion")),
                            porcen_area_comun = lector.GetDecimal(lector.GetOrdinal("porcen_area_comun")),
                            valor_referencial = lector.IsDBNull(lector.GetOrdinal("valor_referencial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_referencial")),

                            valor_terreno = lector.GetDecimal(lector.GetOrdinal("valor_terreno")),
                            valor_construccion = lector.GetDecimal(lector.GetOrdinal("valor_construccion")),
                            valor_otra_instalacion = lector.IsDBNull(lector.GetOrdinal("valor_otra_instalacion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_otra_instalacion")),
                            valor_area_comun = lector.IsDBNull(lector.GetOrdinal("valor_area_comun")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_area_comun")),
                            total_autovaluo = lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            impuesto_predial = lector.IsDBNull(lector.GetOrdinal("impuesto_predial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("impuesto_predial")),

                            alcabala = lector.IsDBNull(lector.GetOrdinal("alcabala")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            anio_adquisicion = lector.IsDBNull(lector.GetOrdinal("anio_adquisicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio_adquisicion")),
                            fecha_inscripcion = lector.IsDBNull(lector.GetOrdinal("fecha_inscripcion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_inscripcion")),
                            anio_inscripcion = lector.IsDBNull(lector.GetOrdinal("anio_inscripcion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio_inscripcion")),
                            clasificacion_rustico = lector.IsDBNull(lector.GetOrdinal("clasificacion_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("clasificacion_rustico")),
                            categoria_rustico = lector.IsDBNull(lector.GetOrdinal("categoria_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("categoria_rustico")),
                            tipo_rustico = lector.IsDBNull(lector.GetOrdinal("tipo_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_rustico")),
                            uso_rustico = lector.IsDBNull(lector.GetOrdinal("uso_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("uso_rustico")),
                            hectareas = lector.IsDBNull(lector.GetOrdinal("hectareas")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("hectareas")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            alquiler = lector.IsDBNull(lector.GetOrdinal("alquiler")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("alquiler")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            lista_negra = lector.IsDBNull(lector.GetOrdinal("lista_negra")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("lista_negra")),
                            nuevo_uso = lector.IsDBNull(lector.GetOrdinal("nuevo_uso")) ? default(String) : lector.GetString(lector.GetOrdinal("nuevo_uso")),
                            sector = lector.IsDBNull(lector.GetOrdinal("sector")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("sector")),
                            nuevo_frente_a = lector.IsDBNull(lector.GetOrdinal("nuevo_frente_a")) ? default(String) : lector.GetString(lector.GetOrdinal("nuevo_frente_a")),
                            validado = lector.IsDBNull(lector.GetOrdinal("validado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("validado")),

                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            unidad_idep = lector.IsDBNull(lector.GetOrdinal("unidad_idep")) ? default(String) : lector.GetString(lector.GetOrdinal("unidad_idep")),
                            num_uni_indep = lector.IsDBNull(lector.GetOrdinal("num_uni_indep")) ? default(String) : lector.GetString(lector.GetOrdinal("num_uni_indep")),
                            arancel = lector.IsDBNull(lector.GetOrdinal("arancel")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("arancel")),
                            Fiscalizado = lector.IsDBNull(lector.GetOrdinal("Fiscalizado")) ? default(String) : lector.GetString(lector.GetOrdinal("Fiscalizado")),
                            id_alicuota = lector.IsDBNull(lector.GetOrdinal("id_alicuota")) ? default(String) : lector.GetString(lector.GetOrdinal("id_alicuota")),
                            norte = lector.IsDBNull(lector.GetOrdinal("norte")) ? default(String) : lector.GetString(lector.GetOrdinal("norte")),
                            sur = lector.IsDBNull(lector.GetOrdinal("sur")) ? default(String) : lector.GetString(lector.GetOrdinal("sur")),
                            este = lector.IsDBNull(lector.GetOrdinal("este")) ? default(String) : lector.GetString(lector.GetOrdinal("este")),
                            oeste = lector.IsDBNull(lector.GetOrdinal("oeste")) ? default(String) : lector.GetString(lector.GetOrdinal("oeste")),
                            Condicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Condicion_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("Condicion_Rustico")),
                            Adquisicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Adquisicion_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("Adquisicion_Rustico")),
                            GrupoTierra_Rustico = lector.IsDBNull(lector.GetOrdinal("GrupoTierra_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("GrupoTierra_Rustico")),
                            casa = lector.IsDBNull(lector.GetOrdinal("casa")) ? default(String) : lector.GetString(lector.GetOrdinal("casa")),
                            mapa = lector.IsDBNull(lector.GetOrdinal("mapa")) ? default(String) : lector.GetString(lector.GetOrdinal("mapa")),
                            Via_ID = lector.IsDBNull(lector.GetOrdinal("Via_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Via_ID")),
                            Junta_ID = lector.IsDBNull(lector.GetOrdinal("Junta_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Junta_ID")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("lado")),
                            condicionPropietario = lector.IsDBNull(lector.GetOrdinal("condicionPropietario")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("condicionPropietario")),
                            Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion"))


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
        public List<Mant_Depreciacion> verificarArancelDepreciacion(string predio_ID, string periodoini, string periodofin)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Depreciacion
                        {
                            clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
                        });
                        //}

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
        public void HacerCambios(string periodoini, string periodofin, string persona_ID, string predio_ID, string usser, string año)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "periodo", DbType.String, año);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "registro_user", DbType.String, usser);
                SQL.CommandTimeout = 600;
                int huboexit = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Depreciacion> verificarParametroParaCalculoInndividual(string persona_ID)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Depreciacion
                        {
                            clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
                        });
                        //}

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
        public List<Mant_Depreciacion> verificarParametroParaPredioNuevo(string periodo, string predio_ID)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Depreciacion
                        {
                            clasificacion_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("descripcion"))
                        });
                        //}

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
        public void GenerarCtaCorrienteIniacial(string periodo, string predio_ID)
        {
            try
            {
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 7);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                SQL.CommandTimeout = 600;
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //listar fiscalizados
        public List<Pred_Predio> listarprediosUltiosHistoricos(String per_id, int periodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "persona_ID", DbType.String, per_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            junta_via_ID = lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                            catastro = lector.IsDBNull(lector.GetOrdinal("catastro")) ? default(String) : lector.GetString(lector.GetOrdinal("catastro")),
                            interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                            mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                            lote = lector.IsDBNull(lector.GetOrdinal("lote")) ? default(String) : lector.GetString(lector.GetOrdinal("lote")),
                            edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                            piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                            dpto = lector.IsDBNull(lector.GetOrdinal("dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("dpto")),
                            tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            kilometro = lector.IsDBNull(lector.GetOrdinal("kilometro")) ? default(String) : lector.GetString(lector.GetOrdinal("kilometro")),
                            nombre_predio = lector.IsDBNull(lector.GetOrdinal("nombre_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre_predio")),
                            //lado = lector.GetInt32(lector.GetOrdinal("lado")),
                            referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                            frente_a = lector.IsDBNull(lector.GetOrdinal("frente_a")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("frente_a")),
                            frente_metros = lector.IsDBNull(lector.GetOrdinal("frente_metros")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("frente_metros")),
                            num_personas = lector.GetInt32(lector.GetOrdinal("num_personas")),
                            fecha_terreno = lector.IsDBNull(lector.GetOrdinal("fecha_terreno")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_terreno")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_operacion")),
                            terreno_sin_construir = lector.IsDBNull(lector.GetOrdinal("terreno_sin_construir")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("terreno_sin_construir")),
                            area_terreno = lector.GetDecimal(lector.GetOrdinal("area_terreno")),
                            area_construida = lector.GetDecimal(lector.GetOrdinal("area_construida")),
                            anios_antiguedad = lector.GetInt32(lector.GetOrdinal("anios_antiguedad")),
                            tipo_inmueble = lector.IsDBNull(lector.GetOrdinal("tipo_inmueble")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_inmueble")),
                            tipo_predio = lector.IsDBNull(lector.GetOrdinal("tipo_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            estado_predio = lector.IsDBNull(lector.GetOrdinal("estado_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("estado_predio")),
                            uso_predio = lector.IsDBNull(lector.GetOrdinal("uso_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("uso_predio")),
                            uso_codigo = lector.IsDBNull(lector.GetOrdinal("uso_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("uso_codigo")),
                            num_ficha = lector.IsDBNull(lector.GetOrdinal("num_ficha")) ? default(String) : lector.GetString(lector.GetOrdinal("num_ficha")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                            clase_edificacion = lector.IsDBNull(lector.GetOrdinal("clase_edificacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("clase_edificacion")),
                            fecha_adquisicion = lector.IsDBNull(lector.GetOrdinal("fecha_adquisicion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_adquisicion")),
                            exo_predial = lector.IsDBNull(lector.GetOrdinal("exo_predial")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("exo_predial")),
                            exo_predial_porcentaje = lector.IsDBNull(lector.GetOrdinal("exo_predial_porcentaje")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("exo_predial_porcentaje")),
                            exo_anio = lector.IsDBNull(lector.GetOrdinal("exo_anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("exo_anio")),
                            motivo_exoneracion = lector.IsDBNull(lector.GetOrdinal("motivo_exoneracion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("motivo_exoneracion")),
                            porcen_area_comun = lector.GetDecimal(lector.GetOrdinal("porcen_area_comun")),
                            valor_referencial = lector.IsDBNull(lector.GetOrdinal("valor_referencial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_referencial")),
                            valor_terreno = lector.GetDecimal(lector.GetOrdinal("valor_terreno")),
                            valor_construccion = lector.GetDecimal(lector.GetOrdinal("valor_construccion")),
                            valor_otra_instalacion = lector.IsDBNull(lector.GetOrdinal("valor_otra_instalacion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_otra_instalacion")),
                            valor_area_comun = lector.IsDBNull(lector.GetOrdinal("valor_area_comun")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_area_comun")),
                            total_autovaluo = lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            impuesto_predial = lector.IsDBNull(lector.GetOrdinal("impuesto_predial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("impuesto_predial")),
                            alcabala = lector.IsDBNull(lector.GetOrdinal("alcabala")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            anio_adquisicion = lector.IsDBNull(lector.GetOrdinal("anio_adquisicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio_adquisicion")),
                            fecha_inscripcion = lector.IsDBNull(lector.GetOrdinal("fecha_inscripcion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_inscripcion")),
                            anio_inscripcion = lector.IsDBNull(lector.GetOrdinal("anio_inscripcion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio_inscripcion")),
                            clasificacion_rustico = lector.IsDBNull(lector.GetOrdinal("clasificacion_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("clasificacion_rustico")),
                            categoria_rustico = lector.IsDBNull(lector.GetOrdinal("categoria_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("categoria_rustico")),
                            tipo_rustico = lector.IsDBNull(lector.GetOrdinal("tipo_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_rustico")),
                            uso_rustico = lector.IsDBNull(lector.GetOrdinal("uso_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("uso_rustico")),
                            hectareas = lector.IsDBNull(lector.GetOrdinal("hectareas")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("hectareas")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            alquiler = lector.IsDBNull(lector.GetOrdinal("alquiler")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("alquiler")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            lista_negra = lector.IsDBNull(lector.GetOrdinal("lista_negra")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("lista_negra")),
                            nuevo_uso = lector.IsDBNull(lector.GetOrdinal("nuevo_uso")) ? default(String) : lector.GetString(lector.GetOrdinal("nuevo_uso")),
                            sector = lector.IsDBNull(lector.GetOrdinal("sector")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("sector")),
                            nuevo_frente_a = lector.IsDBNull(lector.GetOrdinal("nuevo_frente_a")) ? default(String) : lector.GetString(lector.GetOrdinal("nuevo_frente_a")),
                            validado = lector.IsDBNull(lector.GetOrdinal("validado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("validado")),

                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            unidad_idep = lector.IsDBNull(lector.GetOrdinal("unidad_idep")) ? default(String) : lector.GetString(lector.GetOrdinal("unidad_idep")),
                            num_uni_indep = lector.IsDBNull(lector.GetOrdinal("num_uni_indep")) ? default(String) : lector.GetString(lector.GetOrdinal("num_uni_indep")),
                            arancel = lector.IsDBNull(lector.GetOrdinal("arancel")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("arancel")),
                            Fiscalizado = lector.IsDBNull(lector.GetOrdinal("Fiscalizado")) ? default(String) : lector.GetString(lector.GetOrdinal("Fiscalizado")),
                            id_alicuota = lector.IsDBNull(lector.GetOrdinal("id_alicuota")) ? default(String) : lector.GetString(lector.GetOrdinal("id_alicuota")),
                            norte = lector.IsDBNull(lector.GetOrdinal("norte")) ? default(String) : lector.GetString(lector.GetOrdinal("norte")),
                            sur = lector.IsDBNull(lector.GetOrdinal("sur")) ? default(String) : lector.GetString(lector.GetOrdinal("sur")),
                            este = lector.IsDBNull(lector.GetOrdinal("este")) ? default(String) : lector.GetString(lector.GetOrdinal("este")),
                            oeste = lector.IsDBNull(lector.GetOrdinal("oeste")) ? default(String) : lector.GetString(lector.GetOrdinal("oeste")),
                            Condicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Condicion_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("Condicion_Rustico")),
                            Adquisicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Adquisicion_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("Adquisicion_Rustico")),
                            GrupoTierra_Rustico = lector.IsDBNull(lector.GetOrdinal("GrupoTierra_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("GrupoTierra_Rustico")),
                            casa = lector.IsDBNull(lector.GetOrdinal("casa")) ? default(String) : lector.GetString(lector.GetOrdinal("casa")),
                            mapa = lector.IsDBNull(lector.GetOrdinal("mapa")) ? default(String) : lector.GetString(lector.GetOrdinal("mapa")),
                            Via_ID = lector.IsDBNull(lector.GetOrdinal("Via_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Via_ID")),
                            Junta_ID = lector.IsDBNull(lector.GetOrdinal("Junta_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Junta_ID")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("lado")),
                            condicionPropietario = lector.IsDBNull(lector.GetOrdinal("condicionPropietario")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("condicionPropietario"))
                            //Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion"))
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

        public List<Pred_Predio> listarprediosAcitvoNoActivo(string persona_ID, string idPeriodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "periodo", DbType.String, idPeriodo);
                SQL.CommandTimeout = 600;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {

                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            junta_via_ID = lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                            num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                            catastro = lector.IsDBNull(lector.GetOrdinal("catastro")) ? default(String) : lector.GetString(lector.GetOrdinal("catastro")),
                            interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                            mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                            lote = lector.IsDBNull(lector.GetOrdinal("lote")) ? default(String) : lector.GetString(lector.GetOrdinal("lote")),
                            edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                            piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                            dpto = lector.IsDBNull(lector.GetOrdinal("dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("dpto")),
                            tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                            cuadra = lector.IsDBNull(lector.GetOrdinal("cuadra")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("cuadra")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            kilometro = lector.IsDBNull(lector.GetOrdinal("kilometro")) ? default(String) : lector.GetString(lector.GetOrdinal("kilometro")),
                            nombre_predio = lector.IsDBNull(lector.GetOrdinal("nombre_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre_predio")),
                            //lado = lector.GetInt32(lector.GetOrdinal("lado")),
                            referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                            frente_a = lector.IsDBNull(lector.GetOrdinal("frente_a")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("frente_a")),
                            frente_metros = lector.IsDBNull(lector.GetOrdinal("frente_metros")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("frente_metros")),
                            num_personas = lector.GetInt32(lector.GetOrdinal("num_personas")),
                            fecha_terreno = lector.IsDBNull(lector.GetOrdinal("fecha_terreno")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_terreno")),
                            tipo_operacion = lector.IsDBNull(lector.GetOrdinal("tipo_operacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_operacion")),
                            terreno_sin_construir = lector.IsDBNull(lector.GetOrdinal("terreno_sin_construir")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("terreno_sin_construir")),
                            area_terreno = lector.GetDecimal(lector.GetOrdinal("area_terreno")),
                            area_construida = lector.GetDecimal(lector.GetOrdinal("area_construida")),
                            anios_antiguedad = lector.GetInt32(lector.GetOrdinal("anios_antiguedad")),
                            tipo_inmueble = lector.IsDBNull(lector.GetOrdinal("tipo_inmueble")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_inmueble")),
                            tipo_predio = lector.IsDBNull(lector.GetOrdinal("tipo_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            estado_predio = lector.IsDBNull(lector.GetOrdinal("estado_predio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("estado_predio")),
                            uso_predio = lector.IsDBNull(lector.GetOrdinal("uso_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("uso_predio")),
                            uso_codigo = lector.IsDBNull(lector.GetOrdinal("uso_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("uso_codigo")),
                            num_ficha = lector.IsDBNull(lector.GetOrdinal("num_ficha")) ? default(String) : lector.GetString(lector.GetOrdinal("num_ficha")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_adquisicion")),
                            clase_edificacion = lector.IsDBNull(lector.GetOrdinal("clase_edificacion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("clase_edificacion")),
                            fecha_adquisicion = lector.IsDBNull(lector.GetOrdinal("fecha_adquisicion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_adquisicion")),
                            exo_predial = lector.IsDBNull(lector.GetOrdinal("exo_predial")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("exo_predial")),

                            exo_predial_porcentaje = lector.IsDBNull(lector.GetOrdinal("exo_predial_porcentaje")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("exo_predial_porcentaje")),
                            exo_anio = lector.IsDBNull(lector.GetOrdinal("exo_anio")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("exo_anio")),
                            motivo_exoneracion = lector.IsDBNull(lector.GetOrdinal("motivo_exoneracion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("motivo_exoneracion")),
                            porcen_area_comun = lector.GetDecimal(lector.GetOrdinal("porcen_area_comun")),
                            valor_referencial = lector.IsDBNull(lector.GetOrdinal("valor_referencial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_referencial")),

                            valor_terreno = lector.GetDecimal(lector.GetOrdinal("valor_terreno")),
                            valor_construccion = lector.GetDecimal(lector.GetOrdinal("valor_construccion")),
                            valor_otra_instalacion = lector.IsDBNull(lector.GetOrdinal("valor_otra_instalacion")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_otra_instalacion")),
                            valor_area_comun = lector.IsDBNull(lector.GetOrdinal("valor_area_comun")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_area_comun")),
                            total_autovaluo = lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            impuesto_predial = lector.IsDBNull(lector.GetOrdinal("impuesto_predial")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("impuesto_predial")),

                            alcabala = lector.IsDBNull(lector.GetOrdinal("alcabala")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            anio_adquisicion = lector.IsDBNull(lector.GetOrdinal("anio_adquisicion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio_adquisicion")),
                            fecha_inscripcion = lector.IsDBNull(lector.GetOrdinal("fecha_inscripcion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_inscripcion")),
                            anio_inscripcion = lector.IsDBNull(lector.GetOrdinal("anio_inscripcion")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("anio_inscripcion")),
                            clasificacion_rustico = lector.IsDBNull(lector.GetOrdinal("clasificacion_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("clasificacion_rustico")),
                            categoria_rustico = lector.IsDBNull(lector.GetOrdinal("categoria_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("categoria_rustico")),
                            tipo_rustico = lector.IsDBNull(lector.GetOrdinal("tipo_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_rustico")),
                            uso_rustico = lector.IsDBNull(lector.GetOrdinal("uso_rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("uso_rustico")),
                            hectareas = lector.IsDBNull(lector.GetOrdinal("hectareas")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("hectareas")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            alquiler = lector.IsDBNull(lector.GetOrdinal("alquiler")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("alquiler")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            lista_negra = lector.IsDBNull(lector.GetOrdinal("lista_negra")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("lista_negra")),
                            nuevo_uso = lector.IsDBNull(lector.GetOrdinal("nuevo_uso")) ? default(String) : lector.GetString(lector.GetOrdinal("nuevo_uso")),
                            sector = lector.IsDBNull(lector.GetOrdinal("sector")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("sector")),
                            nuevo_frente_a = lector.IsDBNull(lector.GetOrdinal("nuevo_frente_a")) ? default(String) : lector.GetString(lector.GetOrdinal("nuevo_frente_a")),
                            validado = lector.IsDBNull(lector.GetOrdinal("validado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("validado")),

                            registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                            registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            unidad_idep = lector.IsDBNull(lector.GetOrdinal("unidad_idep")) ? default(String) : lector.GetString(lector.GetOrdinal("unidad_idep")),
                            num_uni_indep = lector.IsDBNull(lector.GetOrdinal("num_uni_indep")) ? default(String) : lector.GetString(lector.GetOrdinal("num_uni_indep")),
                            arancel = lector.IsDBNull(lector.GetOrdinal("arancel")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("arancel")),
                            Fiscalizado = lector.IsDBNull(lector.GetOrdinal("Fiscalizado")) ? default(String) : lector.GetString(lector.GetOrdinal("Fiscalizado")),
                            id_alicuota = lector.IsDBNull(lector.GetOrdinal("id_alicuota")) ? default(String) : lector.GetString(lector.GetOrdinal("id_alicuota")),
                            norte = lector.IsDBNull(lector.GetOrdinal("norte")) ? default(String) : lector.GetString(lector.GetOrdinal("norte")),
                            sur = lector.IsDBNull(lector.GetOrdinal("sur")) ? default(String) : lector.GetString(lector.GetOrdinal("sur")),
                            este = lector.IsDBNull(lector.GetOrdinal("este")) ? default(String) : lector.GetString(lector.GetOrdinal("este")),
                            oeste = lector.IsDBNull(lector.GetOrdinal("oeste")) ? default(String) : lector.GetString(lector.GetOrdinal("oeste")),
                            Condicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Condicion_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("Condicion_Rustico")),
                            Adquisicion_Rustico = lector.IsDBNull(lector.GetOrdinal("Adquisicion_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("Adquisicion_Rustico")),
                            GrupoTierra_Rustico = lector.IsDBNull(lector.GetOrdinal("GrupoTierra_Rustico")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("GrupoTierra_Rustico")),
                            casa = lector.IsDBNull(lector.GetOrdinal("casa")) ? default(String) : lector.GetString(lector.GetOrdinal("casa")),
                            mapa = lector.IsDBNull(lector.GetOrdinal("mapa")) ? default(String) : lector.GetString(lector.GetOrdinal("mapa")),
                            Via_ID = lector.IsDBNull(lector.GetOrdinal("Via_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Via_ID")),
                            Junta_ID = lector.IsDBNull(lector.GetOrdinal("Junta_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("Junta_ID")),
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("lado")),
                            condicionPropietario = lector.IsDBNull(lector.GetOrdinal("condicionPropietario")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("condicionPropietario")),
                            //Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion"))


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
