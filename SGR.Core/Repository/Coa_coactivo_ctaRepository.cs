
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
    public class Coa_coactivo_ctaRepository
    {
        private const String nombreprocedimiento = "_Coa_coactivo_cta";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Coa_coactivo_cta> listartodos(int anio, string cadena, string codigo)
        {
            try
            {
                var coleccion = new List<Coa_coactivo_cta>();
                if (codigo.Trim().Length == 0)
                    codigo = "%";
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "anio", DbType.String, anio);
                db.AddInParameter(SQL, "persona_ID", DbType.String, codigo);
                String cad1 = "%";
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                char[] array = cadena.ToCharArray();
                int j = 0;
                for (int i = 0; i < cadena.Length; i++)
                {

                    if (array[i] == ' ')
                    {
                        j++;
                    }
                    if (j == 0 && array[i] != ' ')
                    {
                        cad1 = cad1 + array[i];
                    }
                    if (j == 1 && array[i] != ' ')
                    {
                        cad2 = cad2 + array[i];
                    }
                    if (j == 2 && array[i] != ' ')
                    {
                        cad3 = cad3 + array[i];
                    }
                    if (j == 3 && array[i] != ' ')
                    {
                        cad4 = cad4 + array[i];
                    }
                }
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {//Coa_coactivo_cta
                        coleccion.Add(new Coa_coactivo_cta
                        {
                            coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("coactivo_cta_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            monto_tota = lector.GetDecimal(lector.GetOrdinal("monto_tota")),

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

        public List<Coa_coactivo_cta> listarTodosPorContribuyente(string persona_id)
        {
            try
            {
                var coleccion = new List<Coa_coactivo_cta>();               
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_id);                
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {//Coa_coactivo_cta
                        coleccion.Add(new Coa_coactivo_cta
                        {
                            coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("coactivo_cta_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            monto_tota = lector.GetDecimal(lector.GetOrdinal("monto_tota")),

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

        public List<Coa_coactivo_cta> listarPorContribuyenteAnio(string persona_id, Int16 anio)
        {
            try
            {
                var coleccion = new List<Coa_coactivo_cta>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_id);
                db.AddInParameter(SQL, "anio", DbType.Int16, anio);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {//Coa_coactivo_cta
                        coleccion.Add(new Coa_coactivo_cta
                        {
                            coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("coactivo_cta_ID")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            monto_tota = lector.GetDecimal(lector.GetOrdinal("monto_tota")),

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

        public List<Coa_coactivo_cta> ObtenerPorpersona_ID(String persona_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "persona_ID", DbType.String);
                var coleccion = new List<Coa_coactivo_cta>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Coa_coactivo_cta
                        {
                            //Coa_coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("Coa_coactivo_cta_ID")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            contri_coactivo_ID = lector.IsDBNull(lector.GetOrdinal("contri_coactivo_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("contri_coactivo_ID")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            grupo = lector.IsDBNull(lector.GetOrdinal("grupo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("grupo")),
                            anio_ini = lector.IsDBNull(lector.GetOrdinal("anio_ini")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio_ini")),
                            anio_fin = lector.IsDBNull(lector.GetOrdinal("anio_fin")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio_fin")),
                            //interes_mor = lector.IsDBNull(lector.GetOrdinal("interes_mor")) ? default(Single) : lector.GetDecimal(lector.GetOrdinal("interes_mor")),
                            //monto_tota = lector.IsDBNull(lector.GetOrdinal("monto_tota")) ? default(Single) : lector.GetDecimal(lector.GetOrdinal("monto_tota"))

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



        public List<Coa_coactivo_cta> ObtenerPorcontri_coactivo_ID(Int32 contri_coactivo_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "contri_coactivo_ID", DbType.Int32);
                var coleccion = new List<Coa_coactivo_cta>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Coa_coactivo_cta
                        {
                            //Coa_coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("Coa_coactivo_cta_ID")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            contri_coactivo_ID = lector.IsDBNull(lector.GetOrdinal("contri_coactivo_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("contri_coactivo_ID")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            grupo = lector.IsDBNull(lector.GetOrdinal("grupo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("grupo")),
                            anio_ini = lector.IsDBNull(lector.GetOrdinal("anio_ini")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio_ini")),
                            anio_fin = lector.IsDBNull(lector.GetOrdinal("anio_fin")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio_fin")),
                            //interes_mor = lector.IsDBNull(lector.GetOrdinal("interes_mor")) ? default(Single) : lector.GetDecimal(lector.GetOrdinal("interes_mor")),
                            //monto_tota = lector.IsDBNull(lector.GetOrdinal("monto_tota")) ? default(Single) : lector.GetDecimal(lector.GetOrdinal("monto_tota"))

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

        public virtual Coa_coactivo_cta GetByPrimaryKey(Int32 Coa_coactivo_cta_ID)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "Coa_coactivo_cta_ID", DbType.Int32, Coa_coactivo_cta_ID);
                var Coa_coactivo_cta = default(Coa_coactivo_cta);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Coa_coactivo_cta = new Coa_coactivo_cta
                        {
                            //Coa_coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("Coa_coactivo_cta_ID")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            fecha_emision = lector.GetDateTime(lector.GetOrdinal("fecha_emision")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            contri_coactivo_ID = lector.IsDBNull(lector.GetOrdinal("contri_coactivo_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("contri_coactivo_ID")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(Boolean) : lector.GetBoolean(lector.GetOrdinal("estado")),
                            grupo = lector.IsDBNull(lector.GetOrdinal("grupo")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("grupo")),
                            anio_ini = lector.IsDBNull(lector.GetOrdinal("anio_ini")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio_ini")),
                            anio_fin = lector.IsDBNull(lector.GetOrdinal("anio_fin")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anio_fin")),
                            //interes_mor = lector.IsDBNull(lector.GetOrdinal("interes_mor")) ? default(Single) : lector.GetDecimal(lector.GetOrdinal("interes_mor")),
                            //monto_tota = lector.IsDBNull(lector.GetOrdinal("monto_tota")) ? default(Single) : lector.GetDecimal(lector.GetOrdinal("monto_tota"))

                        };
                    }
                }
                SQL.Dispose();
                return Coa_coactivo_cta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public virtual int Insert(Coa_coactivo_cta Coa_coactivo_cta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "interes", DbType.Single, Coa_coactivo_cta.interes);
                db.AddInParameter(SQL, "fecha_emision", DbType.DateTime, Coa_coactivo_cta.fecha_emision);
                db.AddInParameter(SQL, "monto", DbType.Single, Coa_coactivo_cta.monto);
                db.AddInParameter(SQL, "persona_ID", DbType.String, Coa_coactivo_cta.persona_ID);
                db.AddInParameter(SQL, "contri_coactivo_ID", DbType.Int32, Coa_coactivo_cta.contri_coactivo_ID);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Coa_coactivo_cta.estado);
                db.AddInParameter(SQL, "grupo", DbType.Int16, Coa_coactivo_cta.grupo);
                db.AddInParameter(SQL, "anio_ini", DbType.Int32, Coa_coactivo_cta.anio_ini);
                db.AddInParameter(SQL, "anio_fin", DbType.Int32, Coa_coactivo_cta.anio_fin);
                db.AddInParameter(SQL, "interes_mor", DbType.Single, Coa_coactivo_cta.interes_mor);
                db.AddInParameter(SQL, "monto_tota", DbType.Single, Coa_coactivo_cta.monto_tota);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                var numerogenerado = (int)db.GetParameterValue(SQL, "Coa_coactivo_cta_ID");
                SQL.Dispose();
                return numerogenerado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Update(Coa_coactivo_cta Coa_coactivo_cta)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                //db.AddInParameter(SQL, "Coa_coactivo_cta_ID", DbType.Int32, Coa_coactivo_cta.Coa_coactivo_cta_ID);
                db.AddInParameter(SQL, "interes", DbType.Single, Coa_coactivo_cta.interes);
                db.AddInParameter(SQL, "fecha_emision", DbType.DateTime, Coa_coactivo_cta.fecha_emision);
                db.AddInParameter(SQL, "monto", DbType.Single, Coa_coactivo_cta.monto);
                db.AddInParameter(SQL, "persona_ID", DbType.String, Coa_coactivo_cta.persona_ID);
                db.AddInParameter(SQL, "contri_coactivo_ID", DbType.Int32, Coa_coactivo_cta.contri_coactivo_ID);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Coa_coactivo_cta.estado);
                db.AddInParameter(SQL, "grupo", DbType.Int16, Coa_coactivo_cta.grupo);
                db.AddInParameter(SQL, "anio_ini", DbType.Int32, Coa_coactivo_cta.anio_ini);
                db.AddInParameter(SQL, "anio_fin", DbType.Int32, Coa_coactivo_cta.anio_fin);
                db.AddInParameter(SQL, "interes_mor", DbType.Single, Coa_coactivo_cta.interes_mor);
                db.AddInParameter(SQL, "monto_tota", DbType.Single, Coa_coactivo_cta.monto_tota);
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

