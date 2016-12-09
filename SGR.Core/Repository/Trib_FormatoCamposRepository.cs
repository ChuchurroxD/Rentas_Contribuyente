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
    public class Trib_FormatoCamposRepository
    {
        private const String nombreprocedimiento = "_trib_Formato_Campos";
        private const String NombreTabla = "FormatoCampos";
        private Database db = DatabaseFactory.CreateDatabase();

        public virtual int Update(Trib_FormatoCampos trib_FormatoCampos)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "formatoCampos_ID", DbType.Int32, trib_FormatoCampos.id);
                db.AddInParameter(SQL, "tipoFormato_ID", DbType.Int32, trib_FormatoCampos.tipo_formato_id);
                db.AddInParameter(SQL, "anio", DbType.Int32, trib_FormatoCampos.anio);
                db.AddInParameter(SQL, "columna1", DbType.String, trib_FormatoCampos.colum1);
                db.AddInParameter(SQL, "columna2", DbType.String, trib_FormatoCampos.colum2);
                db.AddInParameter(SQL, "columna3", DbType.String, trib_FormatoCampos.colum3);
                db.AddInParameter(SQL, "columna4", DbType.String, trib_FormatoCampos.colum4);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, trib_FormatoCampos.registro_user_update);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 1);//modificar tipo

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

        public virtual int Insert(Trib_FormatoCampos trib_FormatoCampos)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoFormato_ID", DbType.Int32, trib_FormatoCampos.tipo_formato_id);
                db.AddInParameter(SQL, "anio", DbType.Int32, trib_FormatoCampos.anio);
                db.AddInParameter(SQL, "columna1", DbType.String, trib_FormatoCampos.colum1);
                db.AddInParameter(SQL, "columna2", DbType.String, trib_FormatoCampos.colum2);
                db.AddInParameter(SQL, "columna3", DbType.String, trib_FormatoCampos.colum3);
                db.AddInParameter(SQL, "columna4", DbType.String, trib_FormatoCampos.colum4);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, trib_FormatoCampos.registro_user_add);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, trib_FormatoCampos.registro_user_update);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 2);//modificar tipo

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

        public virtual Trib_FormatoCampos mostrarCampos(String tipoFormato_ID, Int32 anio)
        {
            try
            {
                Trib_FormatoCampos trib_FormatoCampo = new Trib_FormatoCampos();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoFormato_ID", DbType.String, tipoFormato_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                Int32 total = 0;
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        total++;
                        trib_FormatoCampo.id = lector.GetInt32(lector.GetOrdinal("FormatoCampos_id"));
                        trib_FormatoCampo.tipo_formato_id = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoFormato_id"));
                        trib_FormatoCampo.tipo_formato_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion"));
                        trib_FormatoCampo.anio = lector.GetInt32(lector.GetOrdinal("anio"));
                        trib_FormatoCampo.colum1 = lector.IsDBNull(lector.GetOrdinal("columna1")) ? default(String) : lector.GetString(lector.GetOrdinal("columna1"));
                        trib_FormatoCampo.colum2 = lector.IsDBNull(lector.GetOrdinal("columna2")) ? default(String) : lector.GetString(lector.GetOrdinal("columna2"));
                        trib_FormatoCampo.colum3 = lector.IsDBNull(lector.GetOrdinal("columna3")) ? default(String) : lector.GetString(lector.GetOrdinal("columna3"));
                        trib_FormatoCampo.colum4 = lector.IsDBNull(lector.GetOrdinal("columna4")) ? default(String) : lector.GetString(lector.GetOrdinal("columna4"));
                    }
                }
                if (total == 0)
                {
                    trib_FormatoCampo = null;
                }
                SQL.Dispose();
                return trib_FormatoCampo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual List<Trib_TipoFormato> llenarComboTipoformato()
        {
            try
            {
                var coleccion = new List<Trib_TipoFormato>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_TipoFormato
                        {
                            valor = lector.GetString(lector.GetOrdinal("valor")).Trim(),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
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

        public virtual List<Trib_FormatoCampos> buscarByAnio(int anio)
        {
            try
            {
                var coleccion = new List<Trib_FormatoCampos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_FormatoCampos
                        {

                            id = lector.GetInt32(lector.GetOrdinal("FormatoCampos_id")),
                            tipo_formato_id = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoFormato_id")),
                            tipo_formato_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            colum1 = lector.IsDBNull(lector.GetOrdinal("columna1")) ? default(String) : lector.GetString(lector.GetOrdinal("columna1")),
                            colum2 = lector.IsDBNull(lector.GetOrdinal("columna2")) ? default(String) : lector.GetString(lector.GetOrdinal("columna2")),
                            colum3 = lector.IsDBNull(lector.GetOrdinal("columna3")) ? default(String) : lector.GetString(lector.GetOrdinal("columna3")),
                            colum4 = lector.IsDBNull(lector.GetOrdinal("columna4")) ? default(String) : lector.GetString(lector.GetOrdinal("columna4")),
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

        public virtual List<Trib_FormatoCampos> buscarByAnioByColumna(int anio, string busqueda)
        {
            try
            {
                var coleccion = new List<Trib_FormatoCampos>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "busqueda", DbType.String, busqueda);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Trib_FormatoCampos
                        {

                            id = lector.GetInt32(lector.GetOrdinal("FormatoCampos_id")),
                            tipo_formato_id = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipoFormato_id")),
                            tipo_formato_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            colum1 = lector.IsDBNull(lector.GetOrdinal("columna1")) ? default(String) : lector.GetString(lector.GetOrdinal("columna1")),
                            colum2 = lector.IsDBNull(lector.GetOrdinal("columna2")) ? default(String) : lector.GetString(lector.GetOrdinal("columna2")),
                            colum3 = lector.IsDBNull(lector.GetOrdinal("columna3")) ? default(String) : lector.GetString(lector.GetOrdinal("columna3")),
                            colum4 = lector.IsDBNull(lector.GetOrdinal("columna4")) ? default(String) : lector.GetString(lector.GetOrdinal("columna4")),
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

        public virtual Int32 GetExisteFormatoCampoNuevo(String tipoFormato_ID, Int32 anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipoFormato_ID", DbType.String, tipoFormato_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 7);//cambiar tipo
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

        public virtual Int32 GetExisteFormatoCampoModificar(Int32 formatoCampos_ID, String tipoFormato_ID, Int32 anio)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "formatoCampos_ID", DbType.Int32, formatoCampos_ID);
                db.AddInParameter(SQL, "tipoFormato_ID", DbType.String, tipoFormato_ID);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipoconsulta", DbType.Byte, 8);//cambiar tipo
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
    }
}