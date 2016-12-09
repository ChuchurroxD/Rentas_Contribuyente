using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using System.Data.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
namespace SGR.Core.Repository
{
    public class Pred_Segmentacion_ContribuyenteRepository
    {
        private const string nombreprocedimiento = "_Pred_Segmentacion_Contribuyente";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Pred_Segmentacion_Contribuyente> listartodos(string tipo,string periodo_id)
        {
            try
            {
                var coleccion = new List<Pred_Segmentacion_Contribuyente>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "tipo", DbType.String, tipo);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo_id);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Segmentacion_Contribuyente
                        {
                            segmentacion_contribuyente_id = lector.GetInt32(lector.GetOrdinal("segmentacion_contribuyente_id")),
                            segmentacion_id = lector.IsDBNull(lector.GetOrdinal("segmentacion_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("segmentacion_id")),
                            persona_id = lector.IsDBNull(lector.GetOrdinal("persona_id")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_id")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            nombrecompleto = lector.IsDBNull(lector.GetOrdinal("nombrecompleto")) ? default(String) : lector.GetString(lector.GetOrdinal("nombrecompleto")),
                            //seg_descripcion = lector.IsDBNull(lector.GetOrdinal("seg_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("seg_descripcion")),
                            periodo_id = lector.IsDBNull(lector.GetOrdinal("periodo_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("periodo_id")),
                            monto_inicio = lector.IsDBNull(lector.GetOrdinal("monto_inicio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_inicio")),
                            monto_fin = lector.IsDBNull(lector.GetOrdinal("monto_fin")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_fin")),
                            monto = lector.IsDBNull(lector.GetOrdinal("monto")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto"))
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
        
        public virtual int Insert(Pred_Segmentacion_Contribuyente Pred_Segmentacion_Contribuyente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "segmentacion_id", DbType.Int32, Pred_Segmentacion_Contribuyente.segmentacion_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, Pred_Segmentacion_Contribuyente.persona_id);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_Segmentacion_Contribuyente.registro_user_add);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_Segmentacion_Contribuyente.estado);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar el registro");
                }
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       public virtual void Update(Pred_Segmentacion_Contribuyente Pred_Segmentacion_Contribuyente)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "segmentacion_contribuyente_id", DbType.Int32, Pred_Segmentacion_Contribuyente.segmentacion_contribuyente_id);
                db.AddInParameter(SQL, "segmentacion_id", DbType.Int32, Pred_Segmentacion_Contribuyente.segmentacion_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, Pred_Segmentacion_Contribuyente.persona_id);
                db.AddInParameter(SQL, "registro_user", DbType.String, Pred_Segmentacion_Contribuyente.registro_user_update);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_Segmentacion_Contribuyente.estado);
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
        public virtual void Segmentar(String periodo_id, string tipo,string usuario)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "periodo_id", DbType.Int32, periodo_id);
                db.AddInParameter(SQL, "tipo", DbType.Int32, tipo);
                db.AddInParameter(SQL, "registro_user", DbType.String, usuario);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                //if (huboexito == 0)
                //{
                //    throw new Exception("Error");
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
