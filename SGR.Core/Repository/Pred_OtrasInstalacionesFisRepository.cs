using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity;
using SGR.Core.Service;
public class Pred_OtrasInstalacionesFisRepository
{
    private const String nombreprocedimiento = "_Pred_Predios_InstalacionesFis";
    private Database db = DatabaseFactory.CreateDatabase();
    private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
    private int periodo;

    public List<Pred_OtrasInstalaciones> listarByPredioID(String PredioID, string periodo_id)
    {
        try
        {
            var coleccion = new List<Pred_OtrasInstalaciones>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            db.AddInParameter(SQL, "Predio_id", DbType.String, PredioID);
            db.AddInParameter(SQL, "periodo_id", DbType.String, periodo_id);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Pred_OtrasInstalaciones
                    {
                        PrediosOtras_id = lector.GetInt32(lector.GetOrdinal("PrediosOtras_id")),
                        Predio_id = lector.GetString(lector.GetOrdinal("Predio_id")),
                        OtrasValor_id = lector.GetInt32(lector.GetOrdinal("OtrasValor_id")),
                        Observacion = lector.GetString(lector.GetOrdinal("Observacion")),
                        ValorOtras = lector.GetDecimal(lector.GetOrdinal("ValorOtras")),
                        CantidadValor = lector.GetDecimal(lector.GetOrdinal("CantidadValor")),
                        Estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                        OtrasValor_descripcion = lector.IsDBNull(lector.GetOrdinal("OtrasValor_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("OtrasValor_descripcion")),
                        //registro_user_add = lector.IsDBNull(lector.GetOrdinal("registro_user_add")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                        //registro_fecha_add = lector.IsDBNull(lector.GetOrdinal("registro_fecha_add")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                        //registro_pc_add = lector.IsDBNull(lector.GetOrdinal("registro_pc_add")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_add")),
                        //registro_user_update = lector.IsDBNull(lector.GetOrdinal("registro_user_update")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("registro_user_update")),
                        //registro_fecha_update = lector.IsDBNull(lector.GetOrdinal("registro_fecha_update")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                        //registro_pc_update = lector.IsDBNull(lector.GetOrdinal("registro_pc_update")) ? default(String) : lector.GetString(lector.GetOrdinal("registro_pc_update"))

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


    public virtual int Insert(Pred_OtrasInstalaciones Pred_OtrasInstalaciones, int periodo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);

            db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_OtrasInstalaciones.Predio_id);
            db.AddInParameter(SQL, "OtrasValor_id", DbType.Int32, Pred_OtrasInstalaciones.OtrasValor_id);
            db.AddInParameter(SQL, "Observacion", DbType.String, Pred_OtrasInstalaciones.Observacion);
            db.AddInParameter(SQL, "ValorOtras", DbType.Decimal, Pred_OtrasInstalaciones.ValorOtras);
            db.AddInParameter(SQL, "CantidadValor", DbType.Decimal, Pred_OtrasInstalaciones.CantidadValor);
            db.AddInParameter(SQL, "registro_user", DbType.String, Pred_OtrasInstalaciones.registro_user_add);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_OtrasInstalaciones.Estado);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
            db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
            }
            //var numerogenerado = (int)db.GetParameterValue(SQL, "PrediosOtras_id");
            SQL.Dispose();
            return huboexito;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


    public virtual void Update(Pred_OtrasInstalaciones Pred_OtrasInstalaciones, int periodo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "PrediosOtras_id", DbType.Int32, Pred_OtrasInstalaciones.PrediosOtras_id);
            db.AddInParameter(SQL, "Predio_id", DbType.String, Pred_OtrasInstalaciones.Predio_id);
            db.AddInParameter(SQL, "OtrasValor_id", DbType.Int32, Pred_OtrasInstalaciones.OtrasValor_id);
            db.AddInParameter(SQL, "Observacion", DbType.String, Pred_OtrasInstalaciones.Observacion);
            db.AddInParameter(SQL, "ValorOtras", DbType.Decimal, Pred_OtrasInstalaciones.ValorOtras);
            db.AddInParameter(SQL, "CantidadValor", DbType.Decimal, Pred_OtrasInstalaciones.CantidadValor);
            db.AddInParameter(SQL, "registro_user", DbType.String, Pred_OtrasInstalaciones.registro_user_add);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_OtrasInstalaciones.Estado);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
            db.AddInParameter(SQL, "periodo_id", DbType.String, periodo);
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