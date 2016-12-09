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
    public class Mant_SegmentacionRepository
    {
        private const String nombreprocedimiento = "_Mant_Segmentacion";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Mant_Segmentacion> listartodos(string periodo)
        {
            try
            {
                var coleccion = new List<Mant_Segmentacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Segmentacion
                        {
                            segmentacion_id = lector.GetInt32(lector.GetOrdinal("segmentacion_id")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_add")),
                            //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_user_update")),
                            //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            periodo_id = lector.IsDBNull(lector.GetOrdinal("periodo_id")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("periodo_id")),
                            monto_inicio = lector.IsDBNull(lector.GetOrdinal("monto_inicio")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_inicio")),
                            monto_fin = lector.IsDBNull(lector.GetOrdinal("monto_fin")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("monto_fin")),
                            tipo = lector.IsDBNull(lector.GetOrdinal("tipo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            tipo_descripcion = lector.IsDBNull(lector.GetOrdinal("tipo_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_descripcion"))

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
        public virtual int Insert(Mant_Segmentacion segmentacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "descripcion", DbType.String, segmentacion.descripcion);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, segmentacion.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, segmentacion.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, segmentacion.registro_fecha_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, segmentacion.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, segmentacion.registro_pc_update);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, segmentacion.registro_fecha_update);
                db.AddInParameter(SQL, "periodo_id", DbType.Int32, segmentacion.periodo_id);
                db.AddInParameter(SQL, "monto_inicio", DbType.Decimal, segmentacion.monto_inicio);
                db.AddInParameter(SQL, "monto_fin", DbType.Decimal, segmentacion.monto_fin);
                db.AddInParameter(SQL, "tipo", DbType.Int16, segmentacion.tipo);
                db.AddInParameter(SQL, "estado", DbType.Boolean, segmentacion.estado);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar ");
                }
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Update(Mant_Segmentacion segmentacion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "segmentacion_id", DbType.Int32, segmentacion.segmentacion_id);
                db.AddInParameter(SQL, "descripcion", DbType.String, segmentacion.descripcion);
                //db.AddInParameter(SQL, "registro_user_add", DbType.String, segmentacion.registro_user_add);
                //db.AddInParameter(SQL, "registro_pc_add", DbType.String, segmentacion.registro_pc_add);
                //db.AddInParameter(SQL, "registro_fecha_add", DbType.DateTime, segmentacion.registro_fecha_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, segmentacion.registro_user_update);
                //db.AddInParameter(SQL, "registro_pc_update", DbType.String, segmentacion.registro_pc_update);
                //db.AddInParameter(SQL, "registro_fecha_update", DbType.DateTime, segmentacion.registro_fecha_update);
                db.AddInParameter(SQL, "periodo_id", DbType.Int32, segmentacion.periodo_id);
                db.AddInParameter(SQL, "monto_inicio", DbType.Decimal, segmentacion.monto_inicio);
                db.AddInParameter(SQL, "monto_fin", DbType.Decimal, segmentacion.monto_fin);
                db.AddInParameter(SQL, "tipo", DbType.Int16, segmentacion.tipo);
                db.AddInParameter(SQL, "estado", DbType.Boolean, segmentacion.estado);
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
        public virtual bool DeleteByPrimaryKey(Int32 segmentacion_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "segmentacion_id", DbType.Int32, segmentacion_id);
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
        public virtual int ExisteElementosPeriodoAnterior(int tipoconsulta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, tipoconsulta);
                int CANTIDAD = Convert.ToInt32(db.ExecuteScalar(SQL));
                
                SQL.Dispose();
                return CANTIDAD;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void CopiarElementosPeriodoAnterior(string usser)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, usser);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
