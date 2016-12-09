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
    public class Pred_AnulacionRepository
    {
        private const String nombreprocedimiento = "_Pred_Anulacion";
        private const String NombreTabla = "Grupo";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Pred_Anulacion> listartodos(String tributos_ID, String persona_id, Int32 periodo)
        {
            try
            {
                var coleccion = new List<Pred_Anulacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, tributos_ID);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "periodo", DbType.Int32, periodo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Anulacion
                        {
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")).Trim(),
                            nombrePersona = lector.IsDBNull(lector.GetOrdinal("NombreCompleto")) ? default(String) : lector.GetString(lector.GetOrdinal("NombreCompleto")),
                            anulacion_id = lector.GetInt32(lector.GetOrdinal("anulacion_id")),
                            tributos_id = lector.GetString(lector.GetOrdinal("tributos_ID")).Trim(),
                            tributos_descrip = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            observacion = lector.IsDBNull(lector.GetOrdinal("observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("observacion")),
                            anioInicio = lector.GetInt16(lector.GetOrdinal("anioInicio")),
                            mesInicio = lector.GetInt16(lector.GetOrdinal("mesInicio")),
                            anioFin = lector.GetInt16(lector.GetOrdinal("anioFin")),
                            mesFin = lector.GetInt16(lector.GetOrdinal("mesFin")),
                            tipoAnulacion = lector.GetString(lector.GetOrdinal("tipoAnulacion")).Trim(),
                            tipoAnul_descrip = lector.GetString(lector.GetOrdinal("Tipo Anulacion")).Trim()
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

        public virtual int Insert(Pred_Anulacion pred_Anulacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tributos_ID", DbType.String, pred_Anulacion.tributos_id);
                db.AddInParameter(SQL, "observacion", DbType.String, pred_Anulacion.observacion);
                db.AddInParameter(SQL, "anioInicio", DbType.Int16, pred_Anulacion.anioInicio);
                db.AddInParameter(SQL, "mesInicio", DbType.Int16, pred_Anulacion.mesInicio);
                db.AddInParameter(SQL, "anioFin", DbType.Int16, pred_Anulacion.anioFin);
                db.AddInParameter(SQL, "mesFin", DbType.Int16, pred_Anulacion.mesFin);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, pred_Anulacion.registro_user_add);
                db.AddInParameter(SQL, "tipoAnulacion", DbType.String, pred_Anulacion.tipoAnulacion);
                db.AddInParameter(SQL, "persona_id", DbType.String, pred_Anulacion.persona_id);
                db.AddInParameter(SQL, "predio_id", DbType.String, pred_Anulacion.predio_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);//modificar tipo

                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Mes> listarxExoneracion(Int32 anulacion_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "anulacion_id", DbType.Int32, anulacion_id);
                var coleccion = new List<Mant_Mes>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Mes
                        {
                            Enero = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("1"))),
                            Febrero = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("2"))),
                            Marzo = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("3"))),
                            Abril = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("4"))),
                            Mayo = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("5"))),
                            Junio = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("6"))),
                            Julio = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("7"))),
                            Agosto = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("8"))),
                            Setiembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("9"))),
                            Octubre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("10"))),
                            Noviembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("11"))),
                            Anio = Convert.ToString(lector.GetInt16(lector.GetOrdinal("anio"))),
                            Total = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("total"))),
                            Diciembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("12")))
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
