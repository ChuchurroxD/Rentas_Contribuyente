using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class RepoValoresCobranzaRepository
    {
        private const String nombreprocedimiento = "_Repo_Valores";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Valo_ValoresCobranzaReporte> listarValores(int notificacion_ID)
        {
            try
            {
                var coleccion = new List<Valo_ValoresCobranzaReporte>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "notificacion_ID", DbType.Int32, notificacion_ID);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 9);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Valo_ValoresCobranzaReporte
                        {
                            valor_ID = lector.GetInt32(lector.GetOrdinal("valor_ID")),
                            tipo_valor =  lector.GetInt32(lector.GetOrdinal("tipo_valor")),
                            tipo_valor_desc=  lector.GetString(lector.GetOrdinal("descripcion")),
                            nroValor= lector.GetInt32(lector.GetOrdinal("numero")),
                            anioValor = lector.GetInt32(lector.GetOrdinal("anio_valor")),
                            anioCurso = lector.GetInt32(lector.GetOrdinal("anio_curso")),
                            mensaje= lector.GetString(lector.GetOrdinal("descripcion")),
                            baseLegal = lector.GetString(lector.GetOrdinal("baseLegal")),
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
        public List<RepoValoresCobranza> datosContribuyente(int notificacion_id)
        {
            try
            {
                var coleccion = new List<RepoValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "notificacion_id", DbType.Int32, notificacion_id);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 1);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoValoresCobranza
                        {
                            persona_id = lector.GetString(lector.GetOrdinal("CODIGO CONTRIBUYENTE")).Trim(),
                            año= lector.GetInt32(lector.GetOrdinal("anio")),
                            numero= lector.GetInt32(lector.GetOrdinal("nro")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("RAZON SOCIAL")) ? default(String) : lector.GetString(lector.GetOrdinal("RAZON SOCIAL")),
                            documento = lector.IsDBNull(lector.GetOrdinal("DOCUMENTO")) ? default(String) : lector.GetString(lector.GetOrdinal("DOCUMENTO")),
                            direcCompleta = lector.IsDBNull(lector.GetOrdinal("DIRECCIÓN")) ? default(String) : lector.GetString(lector.GetOrdinal("DIRECCIÓN")),
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

        public List<RepoValoresCobranza> todosPrediosDeclarados(String persona_id, Int32 idPeriodo)
        {
            try
            {
                var coleccion = new List<RepoValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "idPeriodo", DbType.Int32, idPeriodo);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))  
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoValoresCobranza
                        {
                            row = lector.GetInt32(lector.GetOrdinal("ROW")),
                            predio_id = lector.GetString(lector.GetOrdinal("CÓDIGO PREDIO")),
                            catastro = lector.IsDBNull(lector.GetOrdinal("CÓDIGO CATASTRAL")) ? default(String) : lector.GetString(lector.GetOrdinal("CÓDIGO CATASTRAL")),
                            pred_direcCompleta = lector.IsDBNull(lector.GetOrdinal("UBICACIÓN DEL PREDIO")) ? default(String) : lector.GetString(lector.GetOrdinal("UBICACIÓN DEL PREDIO")),
                            totalAutovaluo = lector.GetDecimal(lector.GetOrdinal("VALUO")),
                            exoneracion = lector.IsDBNull(lector.GetOrdinal("EXON")) ? default(String) : lector.GetString(lector.GetOrdinal("EXON")),
                            porcentajeCondominio = lector.GetDecimal(lector.GetOrdinal("PORCENTAJE")),
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

        public List<RepoValoresCobranza> predioDeclarado(String predio_id, Int32 idPeriodo)
        {
            try
            {
                var coleccion = new List<RepoValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, idPeriodo);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 3);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoValoresCobranza
                        {
                            row = lector.GetInt32(lector.GetOrdinal("ROW")),
                            predio_id = lector.GetString(lector.GetOrdinal("CÓDIGO PREDIO")),
                            catastro = lector.IsDBNull(lector.GetOrdinal("CÓDIGO CATASTRAL")) ? default(String) : lector.GetString(lector.GetOrdinal("CÓDIGO CATASTRAL")),
                            pred_direcCompleta = lector.IsDBNull(lector.GetOrdinal("UBICACIÓN DEL PREDIO")) ? default(String) : lector.GetString(lector.GetOrdinal("UBICACIÓN DEL PREDIO")),
                            tipoPredio = lector.IsDBNull(lector.GetOrdinal("TIPO DE PREDIO")) ? default(String) : lector.GetString(lector.GetOrdinal("TIPO DE PREDIO")),
                            condicionPredio = lector.IsDBNull(lector.GetOrdinal("CONDICIÓN DEL PREDIO")) ? default(String) : lector.GetString(lector.GetOrdinal("CONDICIÓN DEL PREDIO")),
                            estadoPredio = lector.IsDBNull(lector.GetOrdinal("ESTADO DEL PREDIO")) ? default(String) : lector.GetString(lector.GetOrdinal("ESTADO DEL PREDIO")),
                            tipoPropiedad = lector.IsDBNull(lector.GetOrdinal("TIPO PROPIEDAD")) ? default(String) : lector.GetString(lector.GetOrdinal("TIPO PROPIEDAD")),
                            usoPropiedad = lector.IsDBNull(lector.GetOrdinal("USO DEL PREDIO")) ? default(String) : lector.GetString(lector.GetOrdinal("USO DEL PREDIO")),
                            porcentajeCondominio = lector.GetDecimal(lector.GetOrdinal("PORCENTAJE")),
                            fechaAdquision = lector.IsDBNull(lector.GetOrdinal("FECHA ADQUISICIÓN")) ? default(String) : lector.GetString(lector.GetOrdinal("FECHA ADQUISICIÓN")),
                            areaTerreno = lector.GetDecimal(lector.GetOrdinal("AREA")),
                            arancel = lector.GetDecimal(lector.GetOrdinal("ARANCEL")),
                            areaConstruida = lector.GetDecimal(lector.GetOrdinal("TOTAL AREA CONSTRUIDA")),
                            valorContruccion = lector.GetDecimal(lector.GetOrdinal("VALOR TOTAL DE CONTRUCCIÓN")),
                            valorTerreno = lector.GetDecimal(lector.GetOrdinal("VALOR DEL TERRENO")),
                            valorOtraInstalacion = lector.GetDecimal(lector.GetOrdinal("VALOR OTRAS")),
                            totalAutovaluo = lector.GetDecimal(lector.GetOrdinal("VALOR TOTAL DE AUTOVALUO")),
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

        public List<RepoValoresCobranza> detallePisos(String predio_id, Int32 idPeriodo)
        {
            try
            {
                var coleccion = new List<RepoValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, idPeriodo);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoValoresCobranza
                        {
                            piso_ID = lector.GetInt32(lector.GetOrdinal("CLAVE PISO")),
                            numero = lector.GetInt32(lector.GetOrdinal("NUMERO")),
                            antiguedad = lector.IsDBNull(lector.GetOrdinal("ANTIGUEDAD")) ? default(String) : lector.GetString(lector.GetOrdinal("ANTIGUEDAD")),
                            fechaConstruccion = lector.IsDBNull(lector.GetOrdinal("FECHA CONSTRUCCIÓN")) ? default(String) : lector.GetString(lector.GetOrdinal("FECHA CONSTRUCCIÓN")),
                            muro = lector.GetString(lector.GetOrdinal("MURO")),
                            techo = lector.GetString(lector.GetOrdinal("TECHO")),
                            piso = lector.GetString(lector.GetOrdinal("PISOS")),
                            puerta = lector.GetString(lector.GetOrdinal("PUERTAS")),
                            revestimiento = lector.GetString(lector.GetOrdinal("REVESTIMIENTO")),
                            banio = lector.GetString(lector.GetOrdinal("BAÑOS")),
                            instalaciones = lector.GetString(lector.GetOrdinal("ELECTRICO")),
                            valor_unitario = lector.GetDecimal(lector.GetOrdinal("VALOR UNITARIO M2")),
                            incremento = lector.GetDecimal(lector.GetOrdinal("INCREMENTO")),
                            porcent_depreci = lector.GetDecimal(lector.GetOrdinal("DEPRECIACIÓN")),
                            valor_unit_depreciado = lector.GetDecimal(lector.GetOrdinal("VALOR UNITARIO DEPRECIADO")),
                            area_construida = lector.GetDecimal(lector.GetOrdinal("AREA CONSTRUIDA")),
                            valor_construido = lector.GetDecimal(lector.GetOrdinal("VALOR AREA CONSTRUIDA")),
                            valor_comun = lector.GetDecimal(lector.GetOrdinal("VALOR AREA COMUNES")),
                            valor_construido_total = lector.GetDecimal(lector.GetOrdinal("VALOR DE LA CONSTRUCCION")),
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

        public int numeroFolios(String persona_id, Int16 idPeriodo)
        {
            try
            {
                
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, idPeriodo);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 5);
                int folios = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        folios = lector.GetInt32(lector.GetOrdinal("FOLIOS"));
                    }
                }
                SQL.Dispose();
                return folios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RepoValoresCobranza> documentosNotificados(int notificacion_ID)
        {
            try
            {
                var coleccion = new List<RepoValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "notificacion_ID", DbType.Int32, notificacion_ID);//modificar de acuerdo a tipo de  consulta
                //db.AddInParameter(SQL, "aniohasta", DbType.Int16, anioHasta);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 6);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoValoresCobranza
                        {
                            row = lector.GetInt32(lector.GetOrdinal("ROW")),
                            naturaleza = lector.IsDBNull(lector.GetOrdinal("NATURALEZA")) ? default(String) : lector.GetString(lector.GetOrdinal("NATURALEZA")),
                            or_documento = lector.GetInt32(lector.GetOrdinal("DOCUMENTO")),
                            año = lector.GetInt32(lector.GetOrdinal("AÑO")),
                            folios = lector.GetInt32(lector.GetOrdinal("FOLIOS")),
                            tributo = lector.IsDBNull(lector.GetOrdinal("TRIBUTO")) ? default(String) : lector.GetString(lector.GetOrdinal("TRIBUTO")),
                            deuda = lector.GetDecimal(lector.GetOrdinal("DEUDA")),                            
                            acumulado= lector.GetDecimal(lector.GetOrdinal("PAGADO"))
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

        public List<RepoValoresCobranza> liquidacionTributo(String persona_id, Int32 idPeriodo)
        {
            try
            {
                var coleccion = new List<RepoValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, idPeriodo);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 7);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoValoresCobranza
                        {
                            tributo = lector.IsDBNull(lector.GetOrdinal("TRIBUTO")) ? default(String) : lector.GetString(lector.GetOrdinal("TRIBUTO")),
                            año = lector.GetInt32(lector.GetOrdinal("PERIODO")),
                            baseImponible = lector.GetDecimal(lector.GetOrdinal("BASE IMPONIBLE")),
                            montoInsoluto = lector.GetDecimal(lector.GetOrdinal("MONTO INSOLUTO")),
                            reajuste = lector.GetDecimal(lector.GetOrdinal("REAJUSTE")),
                            //folios = lector.GetInt32(lector.GetOrdinal("FOLIOS")),
                            interesMoratorio = lector.GetInt32(lector.GetOrdinal("INTERES MORATORIO")),
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

        public List<RepoValoresCobranza> detalleUIT(String persona_id, Int32 idPeriodo)
        {
            try
            {
                var coleccion = new List<RepoValoresCobranza>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);//modificar de acuerdo a tipo de  consulta
                db.AddInParameter(SQL, "idPeriodo", DbType.Int16, idPeriodo);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 8);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new RepoValoresCobranza
                        {
                            descrip_uit = lector.IsDBNull(lector.GetOrdinal("EN U.I.T.")) ? default(String) : lector.GetString(lector.GetOrdinal("EN U.I.T.")),
                            enSoles = lector.GetDecimal(lector.GetOrdinal("EN SOLES")),
                            alicuota = lector.IsDBNull(lector.GetOrdinal("ALICUOTA")) ? default(String) : lector.GetString(lector.GetOrdinal("ALICUOTA")),
                            porTramo = lector.GetDecimal(lector.GetOrdinal("POR TRAMO")),
                            acumulado = lector.GetDecimal(lector.GetOrdinal("ACUMULADO")),
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
