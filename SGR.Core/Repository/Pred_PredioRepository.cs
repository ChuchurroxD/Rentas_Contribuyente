using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Pred_PredioRepository
    {
        private const String nombreprocedimiento = "_Pred_Predio";
        private const String NombreTabla = "Predio";
        private Database db = DatabaseFactory.CreateDatabase();
        private DbConnection connection;
        private DbTransaction tss;
        //        Database database = DatabaseFactory.CreateDatabase(“DBConn”);

        //using (DbConnection connection = database.CreateConnection())
        //{
        //DbTransaction transaction = null;
        //DbTransaction tran = cnn.BeginTransaction()
        public List<Pred_Predio> listartodos()
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                //db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                //db.AddInParameter(SQL, "per_id", DbType.String, per_id);
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
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("lado"))


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



        public List<Pred_Predio> listarbuscados(String per_id, int periodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "per_id", DbType.String, per_id);
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


        public virtual Pred_Predio GetByPrimaryKey(String predio_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                var Predio = default(Pred_Predio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Predio = new Pred_Predio
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
                            lado = lector.GetInt32(lector.GetOrdinal("lado")),
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
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            alquiler = lector.GetBoolean(lector.GetOrdinal("alquiler")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            lista_negra = lector.GetBoolean(lector.GetOrdinal("lista_negra")),
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
                            Via_ID = lector.GetInt32(lector.GetOrdinal("Via_ID")),
                            Junta_ID = lector.GetInt32(lector.GetOrdinal("Junta_ID")),

                        };
                    }
                }
                SQL.Dispose();
                return Predio;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual string Insert(Pred_Predio Predio, int periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "clasificacion_rustico", DbType.Int16, Predio.clasificacion_rustico);
                db.AddInParameter(SQL, "categoria_rustico", DbType.Int16, Predio.categoria_rustico);
                db.AddInParameter(SQL, "tipo_rustico", DbType.Int16, Predio.tipo_rustico);
                db.AddInParameter(SQL, "uso_rustico", DbType.Int16, Predio.uso_rustico);
                db.AddInParameter(SQL, "predio_ID", DbType.String, "a");
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Predio.junta_via_ID);
                db.AddInParameter(SQL, "num_via", DbType.String, Predio.num_via);
                db.AddInParameter(SQL, "catastro", DbType.String, Predio.catastro);
                db.AddInParameter(SQL, "interior", DbType.String, Predio.interior);
                db.AddInParameter(SQL, "mz", DbType.String, Predio.mz);
                db.AddInParameter(SQL, "lote", DbType.String, Predio.lote);
                db.AddInParameter(SQL, "edificio", DbType.String, Predio.edificio);
                db.AddInParameter(SQL, "piso", DbType.String, Predio.piso);
                db.AddInParameter(SQL, "dpto", DbType.String, Predio.dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, Predio.tienda);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, Predio.cuadra);
                //db.AddInParameter(SQL, "direccion_completa", DbType.String, Predio.direccion_completa);
                db.AddInParameter(SQL, "kilometro", DbType.String, Predio.kilometro);
                db.AddInParameter(SQL, "nombre_predio", DbType.String, Predio.nombre_predio);
                //db.AddInParameter(SQL, "lado", DbType.Int32, Predio.lado);
                db.AddInParameter(SQL, "referencia", DbType.String, Predio.referencia);
                db.AddInParameter(SQL, "frente_a", DbType.Int32, Predio.frente_a);
                db.AddInParameter(SQL, "frente_metros", DbType.Decimal, Predio.frente_metros);
                db.AddInParameter(SQL, "num_personas", DbType.Int32, Predio.num_personas);
                db.AddInParameter(SQL, "fecha_terreno", DbType.DateTime, Predio.fecha_terreno);
                db.AddInParameter(SQL, "tipo_operacion", DbType.Int32, Predio.tipo_operacion);
                db.AddInParameter(SQL, "terreno_sin_construir", DbType.Boolean, Predio.terreno_sin_construir);
                db.AddInParameter(SQL, "area_terreno", DbType.Decimal, Predio.area_terreno);
                db.AddInParameter(SQL, "area_construida", DbType.Decimal, Predio.area_construida);
                db.AddInParameter(SQL, "anios_antiguedad", DbType.Int32, Predio.anios_antiguedad);
                db.AddInParameter(SQL, "tipo_inmueble", DbType.Int32, Predio.tipo_inmueble);
                db.AddInParameter(SQL, "tipo_predio", DbType.Int32, Predio.tipo_predio);
                db.AddInParameter(SQL, "estado_predio", DbType.Int32, Predio.estado_predio);
                db.AddInParameter(SQL, "uso_predio", DbType.String, Predio.uso_predio);
                db.AddInParameter(SQL, "uso_codigo", DbType.String, Predio.uso_codigo);
                db.AddInParameter(SQL, "num_ficha", DbType.String, Predio.num_ficha);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, Predio.tipo_adquisicion);
                db.AddInParameter(SQL, "clase_edificacion", DbType.Int32, Predio.clase_edificacion);
                db.AddInParameter(SQL, "fecha_adquisicion", DbType.DateTime, Predio.fecha_adquisicion);
                //db.AddInParameter(SQL, "exo_predial", DbType.Int32, Predio.exo_predial);
                //db.AddInParameter(SQL, "exo_predial_porcentaje", DbType.Decimal, Predio.exo_predial_porcentaje);
                //db.AddInParameter(SQL, "exo_anio", DbType.Int16, Predio.exo_anio);
                //db.AddInParameter(SQL, "motivo_exoneracion", DbType.Int32, Predio.motivo_exoneracion);
                db.AddInParameter(SQL, "porcen_area_comun", DbType.Decimal, Predio.porcen_area_comun);
                db.AddInParameter(SQL, "condicionPropietario", DbType.Int32, Predio.condicionPropietario);
                //db.AddInParameter(SQL, "valor_referencial", DbType.Decimal, Predio.valor_referencial);
                //db.AddInParameter(SQL, "valor_terreno", DbType.Decimal, Predio.valor_terreno);
                //db.AddInParameter(SQL, "valor_construccion", DbType.Decimal, Predio.valor_construccion);
                //db.AddInParameter(SQL, "valor_otra_instalacion", DbType.Decimal, Predio.valor_otra_instalacion);
                //db.AddInParameter(SQL, "valor_area_comun", DbType.Decimal, Predio.valor_area_comun);
                //db.AddInParameter(SQL, "total_autovaluo", DbType.Decimal, Predio.total_autovaluo);
                //db.AddInParameter(SQL, "impuesto_predial", DbType.Decimal, Predio.impuesto_predial);
                //db.AddInParameter(SQL, "alcabala", DbType.Decimal, Predio.alcabala);
                db.AddInParameter(SQL, "anio_adquisicion", DbType.Int16, Predio.anio_adquisicion);
                //db.AddInParameter(SQL, "fecha_inscripcion", DbType.DateTime, Predio.fecha_inscripcion);
                //db.AddInParameter(SQL, "anio_inscripcion", DbType.Int16, Predio.anio_inscripcion);
                db.AddInParameter(SQL, "hectareas", DbType.Decimal, Predio.hectareas);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Predio.estado);
                db.AddInParameter(SQL, "alquiler", DbType.Boolean, Predio.alquiler);
                db.AddInParameter(SQL, "expediente", DbType.String, Predio.expediente);
                db.AddInParameter(SQL, "lista_negra", DbType.Boolean, Predio.lista_negra);
                //db.AddInParameter(SQL, "nuevo_uso", DbType.String, Predio.nuevo_uso);
                db.AddInParameter(SQL, "sector", DbType.Int32, Predio.sector);
                //db.AddInParameter(SQL, "nuevo_frente_a", DbType.String, Predio.nuevo_frente_a);
                db.AddInParameter(SQL, "validado", DbType.Boolean, Predio.validado);
                db.AddInParameter(SQL, "registro_user", DbType.String, Predio.registro_user_add);
                //db.AddInParameter(SQL, "unidad_idep", DbType.String, Predio.unidad_idep);
                //db.AddInParameter(SQL, "num_uni_indep", DbType.String, Predio.num_uni_indep);
                db.AddInParameter(SQL, "arancel", DbType.Decimal, Predio.arancel);
                db.AddInParameter(SQL, "Fiscalizado", DbType.String, Predio.Fiscalizado);
                //db.AddInParameter(SQL, "id_alicuota", DbType.String, Predio.id_alicuota);
                db.AddInParameter(SQL, "norte", DbType.String, Predio.norte);
                db.AddInParameter(SQL, "sur", DbType.String, Predio.sur);
                db.AddInParameter(SQL, "este", DbType.String, Predio.este);
                db.AddInParameter(SQL, "oeste", DbType.String, Predio.oeste);
                db.AddInParameter(SQL, "Condicion_Rustico", DbType.Int16, Predio.Condicion_Rustico);
                db.AddInParameter(SQL, "Adquisicion_Rustico", DbType.Int16, Predio.Adquisicion_Rustico);
                db.AddInParameter(SQL, "GrupoTierra_Rustico", DbType.Int16, Predio.GrupoTierra_Rustico);
                db.AddInParameter(SQL, "mapa", DbType.String, Predio.mapa);
                db.AddInParameter(SQL, "casa", DbType.String, Predio.casa);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "lado", DbType.String, Predio.lado);
                db.AddInParameter(SQL, "DescripcionHistorial", DbType.String, Predio.DescripcionHistorial);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                string huboexito = Convert.ToString(db.ExecuteScalar(SQL));
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error al agregar al");
                //}
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string InsertTemporal(Pred_Predio Predio, int periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "clasificacion_rustico", DbType.Int16, Predio.clasificacion_rustico);
                db.AddInParameter(SQL, "categoria_rustico", DbType.Int16, Predio.categoria_rustico);
                db.AddInParameter(SQL, "tipo_rustico", DbType.Int16, Predio.tipo_rustico);
                db.AddInParameter(SQL, "uso_rustico", DbType.Int16, Predio.uso_rustico);
                db.AddInParameter(SQL, "predio_ID", DbType.String, "0");
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Predio.junta_via_ID);
                db.AddInParameter(SQL, "num_via", DbType.String, Predio.num_via);
                db.AddInParameter(SQL, "catastro", DbType.String, Predio.catastro);
                db.AddInParameter(SQL, "interior", DbType.String, Predio.interior);
                db.AddInParameter(SQL, "mz", DbType.String, Predio.mz);
                db.AddInParameter(SQL, "lote", DbType.String, Predio.lote);
                db.AddInParameter(SQL, "edificio", DbType.String, Predio.edificio);
                db.AddInParameter(SQL, "piso", DbType.String, Predio.piso);
                db.AddInParameter(SQL, "dpto", DbType.String, Predio.dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, Predio.tienda);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, Predio.cuadra);
                //db.AddInParameter(SQL, "direccion_completa", DbType.String, Predio.direccion_completa);
                db.AddInParameter(SQL, "kilometro", DbType.String, Predio.kilometro);
                db.AddInParameter(SQL, "nombre_predio", DbType.String, Predio.nombre_predio);
                //db.AddInParameter(SQL, "lado", DbType.Int32, Predio.lado);
                db.AddInParameter(SQL, "referencia", DbType.String, Predio.referencia);
                db.AddInParameter(SQL, "frente_a", DbType.Int32, Predio.frente_a);
                db.AddInParameter(SQL, "frente_metros", DbType.Decimal, Predio.frente_metros);
                db.AddInParameter(SQL, "num_personas", DbType.Int32, Predio.num_personas);
                db.AddInParameter(SQL, "fecha_terreno", DbType.DateTime, Predio.fecha_terreno);
                db.AddInParameter(SQL, "tipo_operacion", DbType.Int32, Predio.tipo_operacion);
                db.AddInParameter(SQL, "terreno_sin_construir", DbType.Boolean, Predio.terreno_sin_construir);
                db.AddInParameter(SQL, "area_terreno", DbType.Decimal, Predio.area_terreno);
                db.AddInParameter(SQL, "area_construida", DbType.Decimal, Predio.area_construida);
                db.AddInParameter(SQL, "anios_antiguedad", DbType.Int32, Predio.anios_antiguedad);
                db.AddInParameter(SQL, "tipo_inmueble", DbType.Int32, Predio.tipo_inmueble);
                db.AddInParameter(SQL, "tipo_predio", DbType.Int32, Predio.tipo_predio);
                db.AddInParameter(SQL, "estado_predio", DbType.Int32, Predio.estado_predio);
                db.AddInParameter(SQL, "uso_predio", DbType.String, Predio.uso_predio);
                db.AddInParameter(SQL, "uso_codigo", DbType.String, Predio.uso_codigo);
                db.AddInParameter(SQL, "num_ficha", DbType.String, Predio.num_ficha);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, Predio.tipo_adquisicion);
                db.AddInParameter(SQL, "clase_edificacion", DbType.Int32, Predio.clase_edificacion);
                db.AddInParameter(SQL, "fecha_adquisicion", DbType.DateTime, Predio.fecha_adquisicion);
                //db.AddInParameter(SQL, "exo_predial", DbType.Int32, Predio.exo_predial);
                //db.AddInParameter(SQL, "exo_predial_porcentaje", DbType.Decimal, Predio.exo_predial_porcentaje);
                //db.AddInParameter(SQL, "exo_anio", DbType.Int16, Predio.exo_anio);
                //db.AddInParameter(SQL, "motivo_exoneracion", DbType.Int32, Predio.motivo_exoneracion);
                db.AddInParameter(SQL, "porcen_area_comun", DbType.Decimal, Predio.porcen_area_comun);
                db.AddInParameter(SQL, "condicionPropietario", DbType.Int32, Predio.condicionPropietario);
                //db.AddInParameter(SQL, "valor_referencial", DbType.Decimal, Predio.valor_referencial);
                //db.AddInParameter(SQL, "valor_terreno", DbType.Decimal, Predio.valor_terreno);
                //db.AddInParameter(SQL, "valor_construccion", DbType.Decimal, Predio.valor_construccion);
                //db.AddInParameter(SQL, "valor_otra_instalacion", DbType.Decimal, Predio.valor_otra_instalacion);
                //db.AddInParameter(SQL, "valor_area_comun", DbType.Decimal, Predio.valor_area_comun);
                //db.AddInParameter(SQL, "total_autovaluo", DbType.Decimal, Predio.total_autovaluo);
                //db.AddInParameter(SQL, "impuesto_predial", DbType.Decimal, Predio.impuesto_predial);
                //db.AddInParameter(SQL, "alcabala", DbType.Decimal, Predio.alcabala);
                db.AddInParameter(SQL, "anio_adquisicion", DbType.Int16, Predio.anio_adquisicion);
                //db.AddInParameter(SQL, "fecha_inscripcion", DbType.DateTime, Predio.fecha_inscripcion);
                //db.AddInParameter(SQL, "anio_inscripcion", DbType.Int16, Predio.anio_inscripcion);
                db.AddInParameter(SQL, "hectareas", DbType.Decimal, Predio.hectareas);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Predio.estado);
                db.AddInParameter(SQL, "alquiler", DbType.Boolean, Predio.alquiler);
                db.AddInParameter(SQL, "expediente", DbType.String, Predio.expediente);
                db.AddInParameter(SQL, "lista_negra", DbType.Boolean, Predio.lista_negra);
                //db.AddInParameter(SQL, "nuevo_uso", DbType.String, Predio.nuevo_uso);
                db.AddInParameter(SQL, "sector", DbType.Int32, Predio.sector);
                //db.AddInParameter(SQL, "nuevo_frente_a", DbType.String, Predio.nuevo_frente_a);
                db.AddInParameter(SQL, "validado", DbType.Boolean, Predio.validado);
                db.AddInParameter(SQL, "registro_user", DbType.String, Predio.registro_user_add);
                //db.AddInParameter(SQL, "unidad_idep", DbType.String, Predio.unidad_idep);
                //db.AddInParameter(SQL, "num_uni_indep", DbType.String, Predio.num_uni_indep);
                db.AddInParameter(SQL, "arancel", DbType.Decimal, Predio.arancel);
                db.AddInParameter(SQL, "Fiscalizado", DbType.String, Predio.Fiscalizado);
                //db.AddInParameter(SQL, "id_alicuota", DbType.String, Predio.id_alicuota);
                db.AddInParameter(SQL, "norte", DbType.String, Predio.norte);
                db.AddInParameter(SQL, "sur", DbType.String, Predio.sur);
                db.AddInParameter(SQL, "este", DbType.String, Predio.este);
                db.AddInParameter(SQL, "oeste", DbType.String, Predio.oeste);
                db.AddInParameter(SQL, "Condicion_Rustico", DbType.Int16, Predio.Condicion_Rustico);
                db.AddInParameter(SQL, "Adquisicion_Rustico", DbType.Int16, Predio.Adquisicion_Rustico);
                db.AddInParameter(SQL, "GrupoTierra_Rustico", DbType.Int16, Predio.GrupoTierra_Rustico);
                db.AddInParameter(SQL, "mapa", DbType.String, Predio.mapa);
                db.AddInParameter(SQL, "casa", DbType.String, Predio.casa);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "lado", DbType.String, Predio.lado);
                db.AddInParameter(SQL, "DescripcionHistorial", DbType.String, Predio.DescripcionHistorial);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                string huboexito = Convert.ToString(db.ExecuteScalar(SQL));
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error al agregar al");
                //}
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_Predio Predio, int periodo)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "DescripcionHistorial", DbType.String, Predio.DescripcionHistorial);
                db.AddInParameter(SQL, "clasificacion_rustico", DbType.Int16, Predio.clasificacion_rustico);
                db.AddInParameter(SQL, "categoria_rustico", DbType.Int16, Predio.categoria_rustico);
                db.AddInParameter(SQL, "tipo_rustico", DbType.Int16, Predio.tipo_rustico);
                db.AddInParameter(SQL, "uso_rustico", DbType.Int16, Predio.uso_rustico);
                db.AddInParameter(SQL, "predio_ID", DbType.String, Predio.predio_ID);
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Predio.junta_via_ID);
                db.AddInParameter(SQL, "num_via", DbType.String, Predio.num_via);
                db.AddInParameter(SQL, "catastro", DbType.String, Predio.catastro);
                db.AddInParameter(SQL, "interior", DbType.String, Predio.interior);
                db.AddInParameter(SQL, "mz", DbType.String, Predio.mz);
                db.AddInParameter(SQL, "lote", DbType.String, Predio.lote);
                db.AddInParameter(SQL, "edificio", DbType.String, Predio.edificio);
                db.AddInParameter(SQL, "piso", DbType.String, Predio.piso);
                db.AddInParameter(SQL, "dpto", DbType.String, Predio.dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, Predio.tienda);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, Predio.cuadra);
                //db.AddInParameter(SQL, "direccion_completa", DbType.String, Predio.direccion_completa);
                //db.AddInParameter(SQL, "kilometro", DbType.String, Predio.kilometro);
                db.AddInParameter(SQL, "nombre_predio", DbType.String, Predio.nombre_predio);
                //db.AddInParameter(SQL, "lado", DbType.Int32, Predio.lado);
                db.AddInParameter(SQL, "referencia", DbType.String, Predio.referencia);
                db.AddInParameter(SQL, "frente_a", DbType.Int32, Predio.frente_a);
                db.AddInParameter(SQL, "frente_metros", DbType.Decimal, Predio.frente_metros);
                db.AddInParameter(SQL, "num_personas", DbType.Int32, Predio.num_personas);
                db.AddInParameter(SQL, "fecha_terreno", DbType.DateTime, Predio.fecha_terreno);
                db.AddInParameter(SQL, "tipo_operacion", DbType.Int32, Predio.tipo_operacion);
                db.AddInParameter(SQL, "terreno_sin_construir", DbType.Boolean, Predio.terreno_sin_construir);
                db.AddInParameter(SQL, "area_terreno", DbType.Decimal, Predio.area_terreno);
                db.AddInParameter(SQL, "area_construida", DbType.Decimal, Predio.area_construida);
                db.AddInParameter(SQL, "anios_antiguedad", DbType.Int32, Predio.anios_antiguedad);
                db.AddInParameter(SQL, "tipo_inmueble", DbType.Int32, Predio.tipo_inmueble);
                db.AddInParameter(SQL, "tipo_predio", DbType.Int32, Predio.tipo_predio);
                db.AddInParameter(SQL, "estado_predio", DbType.Int32, Predio.estado_predio);
                db.AddInParameter(SQL, "uso_predio", DbType.String, Predio.uso_predio);
                db.AddInParameter(SQL, "uso_codigo", DbType.String, Predio.uso_codigo);
                db.AddInParameter(SQL, "num_ficha", DbType.String, Predio.num_ficha);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, Predio.tipo_adquisicion);
                db.AddInParameter(SQL, "clase_edificacion", DbType.Int32, Predio.clase_edificacion);
                db.AddInParameter(SQL, "fecha_adquisicion", DbType.DateTime, Predio.fecha_adquisicion);
                db.AddInParameter(SQL, "exo_predial", DbType.Int32, Predio.exo_predial);
                db.AddInParameter(SQL, "exo_predial_porcentaje", DbType.Decimal, Predio.exo_predial_porcentaje);
                db.AddInParameter(SQL, "exo_anio", DbType.Int16, Predio.exo_anio);
                db.AddInParameter(SQL, "motivo_exoneracion", DbType.Int32, Predio.motivo_exoneracion);
                db.AddInParameter(SQL, "porcen_area_comun", DbType.Decimal, Predio.porcen_area_comun);
                //db.AddInParameter(SQL, "valor_referencial", DbType.Decimal, Predio.valor_referencial);
                //db.AddInParameter(SQL, "valor_terreno", DbType.Decimal, Predio.valor_terreno);
                //db.AddInParameter(SQL, "valor_construccion", DbType.Decimal, Predio.valor_construccion);
                //db.AddInParameter(SQL, "valor_otra_instalacion", DbType.Decimal, Predio.valor_otra_instalacion);
                //db.AddInParameter(SQL, "valor_area_comun", DbType.Decimal, Predio.valor_area_comun);
                //db.AddInParameter(SQL, "total_autovaluo", DbType.Decimal, Predio.total_autovaluo);
                //db.AddInParameter(SQL, "impuesto_predial", DbType.Decimal, Predio.impuesto_predial);
                //db.AddInParameter(SQL, "alcabala", DbType.Decimal, Predio.alcabala);
                db.AddInParameter(SQL, "anio_adquisicion", DbType.Int16, Predio.anio_adquisicion);
                //db.AddInParameter(SQL, "fecha_inscripcion", DbType.DateTime, Predio.fecha_inscripcion);
                //db.AddInParameter(SQL, "anio_inscripcion", DbType.Int16, Predio.anio_inscripcion);//no modificar PREGUNTAR
                db.AddInParameter(SQL, "hectareas", DbType.Decimal, Predio.hectareas);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Predio.estado);
                db.AddInParameter(SQL, "alquiler", DbType.Boolean, Predio.alquiler);
                db.AddInParameter(SQL, "expediente", DbType.String, Predio.expediente);
                db.AddInParameter(SQL, "lista_negra", DbType.Boolean, Predio.lista_negra);
                //db.AddInParameter(SQL, "nuevo_uso", DbType.String, Predio.nuevo_uso);
                db.AddInParameter(SQL, "sector", DbType.Int32, Predio.sector);
                //db.AddInParameter(SQL, "nuevo_frente_a", DbType.String, Predio.nuevo_frente_a);
                db.AddInParameter(SQL, "validado", DbType.Boolean, Predio.validado);
                db.AddInParameter(SQL, "registro_user", DbType.String, Predio.registro_user_add);
                //db.AddInParameter(SQL, "unidad_idep", DbType.String, Predio.unidad_idep);
                //db.AddInParameter(SQL, "num_uni_indep", DbType.String, Predio.num_uni_indep);
                db.AddInParameter(SQL, "arancel", DbType.Decimal, Predio.arancel);
                db.AddInParameter(SQL, "Fiscalizado", DbType.String, Predio.Fiscalizado);
                //db.AddInParameter(SQL, "id_alicuota", DbType.String, Predio.id_alicuota);
                db.AddInParameter(SQL, "norte", DbType.String, Predio.norte);
                db.AddInParameter(SQL, "sur", DbType.String, Predio.sur);
                db.AddInParameter(SQL, "este", DbType.String, Predio.este);
                db.AddInParameter(SQL, "oeste", DbType.String, Predio.oeste);
                db.AddInParameter(SQL, "Condicion_Rustico", DbType.Int16, Predio.Condicion_Rustico);
                db.AddInParameter(SQL, "Adquisicion_Rustico", DbType.Int16, Predio.Adquisicion_Rustico);
                db.AddInParameter(SQL, "GrupoTierra_Rustico", DbType.Int16, Predio.GrupoTierra_Rustico);
                db.AddInParameter(SQL, "mapa", DbType.String, Predio.mapa);
                db.AddInParameter(SQL, "casa", DbType.String, Predio.casa);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "lado", DbType.String, Predio.lado);
                db.AddInParameter(SQL, "condicionPropietario", DbType.String, Predio.condicionPropietario);
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

        public virtual string InsertPredioSUbdividido(Pred_Predio Predio, String idPadre)
        {
            //DbCommand SQL1 = db.GetStoredProcCommand(nombreprocedimiento);
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "nombre_predio", DbType.String, Predio.nombre_predio);
                db.AddInParameter(SQL, "num_ficha", DbType.String, Predio.num_ficha);
                db.AddInParameter(SQL, "fecha_adquisicion", DbType.DateTime, Predio.fecha_adquisicion);
                db.AddInParameter(SQL, "fecha_inscripcion", DbType.DateTime, Predio.fecha_inscripcion);
                db.AddInParameter(SQL, "num_personas", DbType.Int32, Predio.num_personas);
                db.AddInParameter(SQL, "num_via", DbType.String, Predio.num_via);
                db.AddInParameter(SQL, "kilometro", DbType.String, Predio.kilometro);
                db.AddInParameter(SQL, "mz", DbType.String, Predio.mz);
                db.AddInParameter(SQL, "lote", DbType.String, Predio.lote);
                db.AddInParameter(SQL, "edificio", DbType.String, Predio.edificio);
                db.AddInParameter(SQL, "dpto", DbType.String, Predio.dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, Predio.tienda);
                db.AddInParameter(SQL, "interior", DbType.String, Predio.interior);
                db.AddInParameter(SQL, "piso", DbType.String, Predio.piso);
                db.AddInParameter(SQL, "valor_referencial", DbType.Decimal, Predio.valor_referencial);//nuevo
                db.AddInParameter(SQL, "area_terreno", DbType.Decimal, Predio.area_terreno);
                db.AddInParameter(SQL, "expediente", DbType.String, Predio.expediente);
                db.AddInParameter(SQL, "area_construida", DbType.Decimal, Predio.area_construida);
                db.AddInParameter(SQL, "predio_ID", DbType.String, Predio.predio_ID);
                db.AddInParameter(SQL, "arancel", DbType.Decimal, Predio.arancel);
                db.AddInParameter(SQL, "idPadre", DbType.String, idPadre);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.String, Predio.tipo_adquisicion);
                db.AddInParameter(SQL, "condicionPropietario", DbType.String, Predio.condicionPropietario);
                db.AddInParameter(SQL, "uso_predio", DbType.String, Predio.uso_predio);
                db.AddInParameter(SQL, "registro_user", DbType.String, Predio.registro_user_add);
                db.AddInParameter(SQL, "DescripcionHistorial", DbType.String, Predio.DescripcionHistorial);
                db.AddInParameter(SQL, "tipo_operacion", DbType.Int32, Predio.tipo_operacion);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 15);
                SQL.CommandTimeout = 600;
                string huboexito = Convert.ToString(db.ExecuteScalar(SQL));
                //if (huboexito == 0)
                //{
                //    db.AddInParameter(SQL1, "predio_ID", DbType.String, Predio.predio_ID);
                //    db.AddInParameter(SQL1, "Tipoconsulta", DbType.String, 16);
                //    db.ExecuteNonQuery(SQL1);
                //}
                SQL.Dispose();
                //SQL1.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                //db.AddInParameter(SQL1, "predio_ID", DbType.String, Predio.predio_ID);
                //db.AddInParameter(SQL1, "Tipoconsulta", DbType.String, 16);
                //db.ExecuteNonQuery(SQL1);
                throw new Exception(ex.Message);
            }
        }
        public virtual void EliminarPredioSUbdividido(String id, int tipo)
        {//18 individula,19grupal
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_ID", DbType.String, id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, tipo);
                int huboexito = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public virtual bool DeleteByPrimaryKey(String predio_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
                SQL.CommandTimeout = 600;
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    return false;
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
        public virtual Int32 GetExisteDescripcionNuevo(String Nombre)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
                db.AddInParameter(SQL, "nombre_predio", DbType.String, Nombre);
                Int32 total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("TOTAL"));

                    }
                }
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Int32 GetExisteDescripcionModificar(String Nombre, String id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "nombre_predio", DbType.String, Nombre);
                db.AddInParameter(SQL, "predio_ID", DbType.String, id);
                Int32 total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("TOTAL"));

                    }
                }
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Int32 GetExisteId(String id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "predio_ID", DbType.String, id);
                Int32 total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total = lector.GetInt32(lector.GetOrdinal("TOTAL"));

                    }
                }
                SQL.Dispose();
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarerrores(Int32 periodo_id)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "periodo", DbType.Int32, periodo_id);
                SQL.CommandTimeout = 600;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {
                            norte = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"))
                        });
                    }
                }
                //SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void COpiarPredio_Piso_predContribuyente(int anioviejo, int anionuevo, string registro_user)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand("_Pred_CopiarPredios");
                db.AddInParameter(SQL, "anio", DbType.Int32, anioviejo);
                db.AddInParameter(SQL, "anioNuevo", DbType.Int32, anionuevo);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                SQL.CommandTimeout = 6000000;
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
        public virtual void GenerarPredioMasivo(int anioviejo, int anionuevo, string registro_user)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand("_Pred_CopiarPredios");
                db.AddInParameter(SQL, "anio", DbType.Int32, anioviejo);
                db.AddInParameter(SQL, "anioNuevo", DbType.Int32, anionuevo);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 2);
                SQL.CommandTimeout = 6000000;
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
        public List<Pred_Predio> listarPrediosxPersona(String per_id)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
                db.AddInParameter(SQL, "per_id", DbType.String, per_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {
                            predio_ID = lector.GetString(lector.GetOrdinal("Predio_id")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa"))



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
        public int existeDireccion(int junta_via_ID, String num_via, String interior, String mz, String lote, String edificio,
            String piso, String dpto, String tienda, String cuadra, String km)
        {
            try
            {
                int total = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 14);
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, junta_via_ID);
                db.AddInParameter(SQL, "num_via", DbType.String, num_via);
                db.AddInParameter(SQL, "interior", DbType.String, interior);
                db.AddInParameter(SQL, "mz", DbType.String, mz);
                db.AddInParameter(SQL, "lote", DbType.String, lote);
                db.AddInParameter(SQL, "edificio", DbType.String, edificio);
                db.AddInParameter(SQL, "piso", DbType.String, piso);
                db.AddInParameter(SQL, "dpto", DbType.String, dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, tienda);
                db.AddInParameter(SQL, "cuadra", DbType.String, cuadra);
                db.AddInParameter(SQL, "kilometro", DbType.String, km);
                total = Convert.ToInt32(db.ExecuteScalar(SQL));

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int existeDireccionModificar(String predio_id, int junta_via_ID, String num_via, String interior, String mz, String lote,
            String edificio, String piso, String dpto, String tienda, String cuadra, String km)
        {
            try
            {
                int total = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 22);
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, junta_via_ID);
                db.AddInParameter(SQL, "num_via", DbType.String, num_via);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_id);
                db.AddInParameter(SQL, "interior", DbType.String, interior);
                db.AddInParameter(SQL, "mz", DbType.String, mz);
                db.AddInParameter(SQL, "lote", DbType.String, lote);
                db.AddInParameter(SQL, "edificio", DbType.String, edificio);
                db.AddInParameter(SQL, "piso", DbType.String, piso);
                db.AddInParameter(SQL, "dpto", DbType.String, dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, tienda);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, cuadra);
                db.AddInParameter(SQL, "kilometro", DbType.String, km);
                total = Convert.ToInt32(db.ExecuteScalar(SQL));

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int existeDireccionSubdividido(String predio_id, String num_via, String interior, String mz, String lote, String edificio,
            String piso, String dpto, String tienda, string kilometro)
        {
            try
            {
                int total = 0;
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 23);
                db.AddInParameter(SQL, "num_via", DbType.String, num_via);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_id);
                db.AddInParameter(SQL, "interior", DbType.String, interior);
                db.AddInParameter(SQL, "mz", DbType.String, mz);
                db.AddInParameter(SQL, "lote", DbType.String, lote);
                db.AddInParameter(SQL, "edificio", DbType.String, edificio);
                db.AddInParameter(SQL, "piso", DbType.String, piso);
                db.AddInParameter(SQL, "dpto", DbType.String, dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, tienda);
                db.AddInParameter(SQL, "kilometro", DbType.String, kilometro);
                SQL.CommandTimeout = 600;
                total = Convert.ToInt32(db.ExecuteScalar(SQL));

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarPredioSubdividos(String predio_padre)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 17);
                db.AddInParameter(SQL, "idPadre", DbType.String, predio_padre);
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
                            lado = lector.IsDBNull(lector.GetOrdinal("lado")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("lado"))
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
        public virtual Decimal GetArancelSubdividido(String Predio_Global)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 20);
                db.AddInParameter(SQL, "predio_ID", DbType.String, Predio_Global);
                Decimal total = 0;
                total = Convert.ToDecimal(db.ExecuteScalar(SQL));
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int GenerarCalculoPredialIndividual(String ppersona_id, string registro_user)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand("_Pred_CopiarPredios");
                db.AddInParameter(SQL, "ppersona_id", DbType.String, ppersona_id);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void iniciarTransaccion()
        {
            tss = db.CreateConnection().BeginTransaction();
            connection.BeginTransaction();

        }
        public virtual void comitTransaccion()
        {
            tss.Commit();
        }
        public virtual void rollbackTransaccion()
        {
            tss.Rollback();
        }
        public virtual void disposeTransaccion()
        {
            tss.Dispose();
        }
        public List<Pred_Predio> listarPrediosxPerContribuyente(String persona_id)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 21);
                db.AddInParameter(SQL, "per_id", DbType.String, persona_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {

                            predio_ID = lector.GetString(lector.GetOrdinal("Predio_id")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("Ubicacion_Predio")) ? default(String) : lector.GetString(lector.GetOrdinal("Ubicacion_Predio")),
                            total_autovaluo = lector.IsDBNull(lector.GetOrdinal("total_autovaluo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            porcentajecondominio = lector.IsDBNull(lector.GetOrdinal("Porcentaje_Condomino")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("Porcentaje_Condomino")),
                            valorafecto = lector.IsDBNull(lector.GetOrdinal("valorafecto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("valorafecto")),
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
        public virtual int ContarPredioContribuyente(String predio_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 24);
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_ResumenDeuda> ListarResumenDeuda(String anioIni, String anioFin, String mesIni, String mesFin,
            String cad1, String cad2, String cad3, String cad4, int clase)
        {
            try
            {
                var coleccion = new List<Pred_ResumenDeuda>();
                DbCommand SQL = db.GetStoredProcCommand("_Pred_ResumenDeuda");
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, clase);
                db.AddInParameter(SQL, "anioini", DbType.String, anioIni);
                db.AddInParameter(SQL, "aniofin", DbType.String, anioFin);
                db.AddInParameter(SQL, "mesini", DbType.String, mesIni);
                db.AddInParameter(SQL, "mesfin", DbType.String, mesFin);
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_ResumenDeuda
                        {
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            direccion_completa = lector.GetString(lector.GetOrdinal("direccion_completa")),
                            NombreCompleto = lector.GetString(lector.GetOrdinal("NombreCompleto")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            OBSERVACIONES = lector.IsDBNull(lector.GetOrdinal("OBSERVACIONES")) ? default(String) : lector.GetString(lector.GetOrdinal("OBSERVACIONES")),
                            anio = lector.IsDBNull(lector.GetOrdinal("anio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.IsDBNull(lector.GetOrdinal("mes")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("mes")),
                            interes_cobrado = lector.IsDBNull(lector.GetOrdinal("interes_cobrado")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("interes_cobrado")),
                            fecha_vence = lector.IsDBNull(lector.GetOrdinal("fecha_vence")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_vence")),
                            DEUDA = lector.IsDBNull(lector.GetOrdinal("DEUDA")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("DEUDA")),
                            ABONO = lector.IsDBNull(lector.GetOrdinal("ABONO")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("ABONO")),
                            cargo = lector.IsDBNull(lector.GetOrdinal("cargo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("cargo"))
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
        public List<Pred_Predio> listarHistorialDeUnPRedio(String predio_ID, int periodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 25);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
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
                            vez = lector.IsDBNull(lector.GetOrdinal("vez")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("vez")),
                            DescripcionHistorial = lector.IsDBNull(lector.GetOrdinal("DescripcionHistorial")) ? default(String) : lector.GetString(lector.GetOrdinal("DescripcionHistorial"))
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
        public virtual string InsertVariosAños(Pred_Predio Predio, int periodo, int periodoFin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "clasificacion_rustico", DbType.Int16, Predio.clasificacion_rustico);
                db.AddInParameter(SQL, "categoria_rustico", DbType.Int16, Predio.categoria_rustico);
                db.AddInParameter(SQL, "tipo_rustico", DbType.Int16, Predio.tipo_rustico);
                db.AddInParameter(SQL, "uso_rustico", DbType.Int16, Predio.uso_rustico);
                db.AddInParameter(SQL, "predio_ID_Temporal", DbType.String, Predio.predio_ID);
                db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Predio.junta_via_ID);
                db.AddInParameter(SQL, "num_via", DbType.String, Predio.num_via);
                db.AddInParameter(SQL, "catastro", DbType.String, Predio.catastro);
                db.AddInParameter(SQL, "interior", DbType.String, Predio.interior);
                db.AddInParameter(SQL, "mz", DbType.String, Predio.mz);
                db.AddInParameter(SQL, "lote", DbType.String, Predio.lote);
                db.AddInParameter(SQL, "edificio", DbType.String, Predio.edificio);
                db.AddInParameter(SQL, "piso", DbType.String, Predio.piso);
                db.AddInParameter(SQL, "dpto", DbType.String, Predio.dpto);
                db.AddInParameter(SQL, "tienda", DbType.String, Predio.tienda);
                db.AddInParameter(SQL, "cuadra", DbType.Int32, Predio.cuadra);
                db.AddInParameter(SQL, "kilometro", DbType.String, Predio.kilometro);
                db.AddInParameter(SQL, "nombre_predio", DbType.String, Predio.nombre_predio);
                db.AddInParameter(SQL, "referencia", DbType.String, Predio.referencia);
                db.AddInParameter(SQL, "frente_a", DbType.Int32, Predio.frente_a);
                db.AddInParameter(SQL, "frente_metros", DbType.Decimal, Predio.frente_metros);
                db.AddInParameter(SQL, "num_personas", DbType.Int32, Predio.num_personas);
                db.AddInParameter(SQL, "fecha_terreno", DbType.DateTime, Predio.fecha_terreno);
                db.AddInParameter(SQL, "tipo_operacion", DbType.Int32, Predio.tipo_operacion);
                db.AddInParameter(SQL, "terreno_sin_construir", DbType.Boolean, Predio.terreno_sin_construir);
                db.AddInParameter(SQL, "area_terreno", DbType.Decimal, Predio.area_terreno);
                db.AddInParameter(SQL, "area_construida", DbType.Decimal, Predio.area_construida);
                db.AddInParameter(SQL, "anios_antiguedad", DbType.Int32, Predio.anios_antiguedad);
                db.AddInParameter(SQL, "tipo_inmueble", DbType.Int32, Predio.tipo_inmueble);
                db.AddInParameter(SQL, "tipo_predio", DbType.Int32, Predio.tipo_predio);
                db.AddInParameter(SQL, "estado_predio", DbType.Int32, Predio.estado_predio);
                db.AddInParameter(SQL, "uso_predio", DbType.String, Predio.uso_predio);
                db.AddInParameter(SQL, "uso_codigo", DbType.String, Predio.uso_codigo);
                db.AddInParameter(SQL, "num_ficha", DbType.String, Predio.num_ficha);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.Int32, Predio.tipo_adquisicion);
                db.AddInParameter(SQL, "clase_edificacion", DbType.Int32, Predio.clase_edificacion);
                db.AddInParameter(SQL, "fecha_adquisicion", DbType.DateTime, Predio.fecha_adquisicion);
                db.AddInParameter(SQL, "porcen_area_comun", DbType.Decimal, Predio.porcen_area_comun);
                db.AddInParameter(SQL, "condicionPropietario", DbType.Int32, Predio.condicionPropietario);
                db.AddInParameter(SQL, "anio_adquisicion", DbType.Int16, Predio.anio_adquisicion);
                db.AddInParameter(SQL, "hectareas", DbType.Decimal, Predio.hectareas);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Predio.estado);
                db.AddInParameter(SQL, "alquiler", DbType.Boolean, Predio.alquiler);
                db.AddInParameter(SQL, "expediente", DbType.String, Predio.expediente);
                db.AddInParameter(SQL, "lista_negra", DbType.Boolean, Predio.lista_negra);
                db.AddInParameter(SQL, "sector", DbType.Int32, Predio.sector);
                db.AddInParameter(SQL, "validado", DbType.Boolean, Predio.validado);
                db.AddInParameter(SQL, "registro_user", DbType.String, Predio.registro_user_add);
                //db.AddInParameter(SQL, "unidad_idep", DbType.String, Predio.unidad_idep);
                //db.AddInParameter(SQL, "num_uni_indep", DbType.String, Predio.num_uni_indep);
                db.AddInParameter(SQL, "arancel", DbType.Decimal, Predio.arancel);
                db.AddInParameter(SQL, "Fiscalizado", DbType.String, Predio.Fiscalizado);
                db.AddInParameter(SQL, "norte", DbType.String, Predio.norte);
                db.AddInParameter(SQL, "sur", DbType.String, Predio.sur);
                db.AddInParameter(SQL, "este", DbType.String, Predio.este);
                db.AddInParameter(SQL, "oeste", DbType.String, Predio.oeste);
                db.AddInParameter(SQL, "Condicion_Rustico", DbType.Int16, Predio.Condicion_Rustico);
                db.AddInParameter(SQL, "Adquisicion_Rustico", DbType.Int16, Predio.Adquisicion_Rustico);
                db.AddInParameter(SQL, "GrupoTierra_Rustico", DbType.Int16, Predio.GrupoTierra_Rustico);
                db.AddInParameter(SQL, "mapa", DbType.String, Predio.mapa);
                db.AddInParameter(SQL, "casa", DbType.String, Predio.casa);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "lado", DbType.String, Predio.lado);
                db.AddInParameter(SQL, "DescripcionHistorial", DbType.String, Predio.DescripcionHistorial);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 26);
                db.AddInParameter(SQL, "periodoFin", DbType.String, periodoFin);

                string huboexito = Convert.ToString(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void CancelTemporal(string predio_ID_Temporal)//delte el predio temporal
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_ID_Temporal", DbType.String, predio_ID_Temporal);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 27);
                int huboexito = db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Predio> listarParaCtaAdeudo(int tipo, string persona, string periodo)
        {
            try
            {
                var coleccion = new List<Pred_Predio>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, tipo);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "per_id", DbType.String, persona);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Predio
                        {
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_ID")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            nombre_predio = lector.IsDBNull(lector.GetOrdinal("nombre_predio")) ? default(String) : lector.GetString(lector.GetOrdinal("nombre_predio")),
                            total_autovaluo = lector.GetDecimal(lector.GetOrdinal("total_autovaluo")),
                            area_terreno = lector.GetDecimal(lector.GetOrdinal("area_terreno"))

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
