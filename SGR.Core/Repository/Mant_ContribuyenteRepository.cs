
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

public class Mant_ContribuyenteRepository
{



    private const String nombreprocedimiento = "_Mant_Contribuyente";
    private const String NombreTabla = "Contribuyente";
    private Database db = DatabaseFactory.CreateDatabase();

    public List<Mant_Per_Cont> listartodos()
    {
        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                        empresaCOnstrucora = lector.IsDBNull(lector.GetOrdinal("empresaCOnstrucora")) ? default(bool) : lector.GetBoolean(lector.GetOrdinal("empresaCOnstrucora")),

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



    public List<Mant_Contribuyente> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Mant_Contribuyente> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Mant_Contribuyente>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Contribuyente
                    {
                        persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                        razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                        ruc = lector.IsDBNull(lector.GetOrdinal("ruc")) ? default(String) : lector.GetString(lector.GetOrdinal("ruc")),
                        junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                        registro_fecha = lector.GetDateTime(lector.GetOrdinal("registro_fecha")),
                        fecha_registro = lector.IsDBNull(lector.GetOrdinal("fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_registro")),
                        //registro_user = lector.GetInt32(lector.GetOrdinal("registro_user")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        c_edificio = lector.IsDBNull(lector.GetOrdinal("c_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("c_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda"))

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


    public virtual Mant_Contribuyente GetByPrimaryKey(string codigo)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, codigo);
            var Contribuyente = default(Mant_Contribuyente);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Contribuyente = new Mant_Contribuyente
                    {
                        persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                        razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                        ruc = lector.IsDBNull(lector.GetOrdinal("ruc")) ? default(String) : lector.GetString(lector.GetOrdinal("ruc")),
                        junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                        registro_fecha = lector.GetDateTime(lector.GetOrdinal("registro_fecha")),
                        fecha_registro = lector.IsDBNull(lector.GetOrdinal("fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_registro")),
                        //registro_user = lector.GetInt32(lector.GetOrdinal("registro_user")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        c_edificio = lector.IsDBNull(lector.GetOrdinal("c_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("c_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda"))


                    };
                }
            }
            SQL.Dispose();
            return Contribuyente;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }



    protected virtual string CreateGetCommand(string whereSql, string orderBySql)
    {
        string sql = "SELECT * FROM [dbo].[Contribuyente]";
        if ((whereSql != null) && (whereSql.Trim().Length > 0))
        {
            sql += " WHERE " + whereSql;
        }
        if ((orderBySql != null) && (orderBySql.Trim().Length > 0))
        {
            sql += " ORDER BY " + orderBySql;
        }
        return sql;
    }

    public virtual int Insert(Mant_Contribuyente Contribuyente)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "persona_id", DbType.String, Contribuyente.persona_id);
            db.AddInParameter(SQL, "razon_social", DbType.String, Contribuyente.razon_social);
            db.AddInParameter(SQL, "ruc", DbType.String, Contribuyente.ruc);
            db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Contribuyente.junta_via_ID);
            db.AddInParameter(SQL, "c_num", DbType.String, Contribuyente.c_num);
            db.AddInParameter(SQL, "c_mz", DbType.String, Contribuyente.c_mz);
            db.AddInParameter(SQL, "c_lote", DbType.String, Contribuyente.c_lote);
            db.AddInParameter(SQL, "c_interior", DbType.String, Contribuyente.c_interior);
            db.AddInParameter(SQL, "c_dpto", DbType.String, Contribuyente.c_dpto);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Contribuyente.estado);
            //db.AddInParameter(SQL, "registro_fecha", DbType.DateTime, Contribuyente.registro_fecha);
            //db.AddInParameter(SQL, "fecha_registro", DbType.DateTime, Contribuyente.fecha_registro);
            db.AddInParameter(SQL, "registro_user", DbType.String, Contribuyente.registro_user);
            db.AddInParameter(SQL, "Contacto", DbType.String, Contribuyente.Contacto);
            db.AddInParameter(SQL, "dniRepresentante", DbType.String, Contribuyente.dniRepresentante);
            db.AddInParameter(SQL, "DireccRepresentante", DbType.String, Contribuyente.DireccRepresentante);
            //db.AddInParameter(SQL, "direccCompleta", DbType.String, Contribuyente.direccCompleta);
            db.AddInParameter(SQL, "referencia", DbType.String, Contribuyente.referencia);
            db.AddInParameter(SQL, "c_edificio", DbType.String, Contribuyente.c_edificio);
            db.AddInParameter(SQL, "c_piso", DbType.String, Contribuyente.c_piso);
            db.AddInParameter(SQL, "c_tienda", DbType.String, Contribuyente.c_tienda);
            db.AddInParameter(SQL, "Ubi_codigo", DbType.String, Contribuyente.Ubi_codigo);
            db.AddInParameter(SQL, "empresaCOnstrucora", DbType.String, Contribuyente.empresaCOnstrucora);
            db.AddInParameter(SQL, "jubilado", DbType.String, Contribuyente.jubilado);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);//
            int huboexito = db.ExecuteNonQuery(SQL);
            if (huboexito == 0)
            {
                throw new Exception("Error al agregar al");
            }
            //var numerogenerado = (int)db.GetParameterValue(SQL, "");
            SQL.Dispose();
            return huboexito;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


    public virtual void Update(Mant_Contribuyente Contribuyente)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "persona_id", DbType.String, Contribuyente.persona_id);
            db.AddInParameter(SQL, "razon_social", DbType.String, Contribuyente.razon_social);
            db.AddInParameter(SQL, "ruc", DbType.String, Contribuyente.ruc);
            db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Contribuyente.junta_via_ID);
            db.AddInParameter(SQL, "c_num", DbType.String, Contribuyente.c_num);
            db.AddInParameter(SQL, "c_mz", DbType.String, Contribuyente.c_mz);
            db.AddInParameter(SQL, "c_lote", DbType.String, Contribuyente.c_lote);
            db.AddInParameter(SQL, "c_interior", DbType.String, Contribuyente.c_interior);
            db.AddInParameter(SQL, "c_dpto", DbType.String, Contribuyente.c_dpto);
            db.AddInParameter(SQL, "estado", DbType.Boolean, Contribuyente.estado);
            //db.AddInParameter(SQL, "registro_fecha", DbType.DateTime, Contribuyente.registro_fecha);
            //db.AddInParameter(SQL, "fecha_registro", DbType.DateTime, Contribuyente.fecha_registro);
            db.AddInParameter(SQL, "registro_user", DbType.String, Contribuyente.registro_user);
            db.AddInParameter(SQL, "Contacto", DbType.String, Contribuyente.Contacto);
            db.AddInParameter(SQL, "dniRepresentante", DbType.String, Contribuyente.dniRepresentante);
            db.AddInParameter(SQL, "DireccRepresentante", DbType.String, Contribuyente.DireccRepresentante);
            //db.AddInParameter(SQL, "direccCompleta", DbType.String, Contribuyente.direccCompleta);
            db.AddInParameter(SQL, "referencia", DbType.String, Contribuyente.referencia);
            db.AddInParameter(SQL, "c_edificio", DbType.String, Contribuyente.c_edificio);
            db.AddInParameter(SQL, "c_piso", DbType.String, Contribuyente.c_piso);
            db.AddInParameter(SQL, "c_tienda", DbType.String, Contribuyente.c_tienda);
            db.AddInParameter(SQL, "Ubi_codigo", DbType.String, Contribuyente.Ubi_codigo);
            db.AddInParameter(SQL, "empresaCOnstrucora", DbType.String, Contribuyente.empresaCOnstrucora);
            db.AddInParameter(SQL, "jubilado", DbType.String, Contribuyente.jubilado);
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


    public virtual bool DeleteByPrimaryKey()
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
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
    public virtual Int32 GetExisteContribuyente(String persona_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 8);
            db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
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
    //
    public List<Mant_Per_Cont> listarBuscadoxExpediente(string busqueda, int tipo, string nombreCampo, int periodo)
    {

        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
            db.AddInParameter(SQL, nombreCampo, DbType.String, busqueda);
            db.AddInParameter(SQL, "periodo", DbType.String, periodo);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta"))
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
    public List<Mant_Per_Cont> listarBuscados(string busqueda, int tipo, string nombreCampo, int oficina)
    {

        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
            db.AddInParameter(SQL, "oficina", DbType.Int32, oficina);
            if (tipo == 11 || tipo == 19)
            { //busqueda solo x nombre
                String cadena = busqueda;
                String cad1 = "%" + busqueda;
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                //char[] array = cadena.ToCharArray();
                //int j = 0;
                //for (int i = 0; i < cadena.Length; i++)
                //{

                //    if (array[i] == ' ')
                //    {
                //        j++;
                //    }
                //    if (j == 0 && array[i] != ' ')
                //    {
                //        cad1 = cad1 + array[i];
                //    }
                //    if (j == 1 && array[i] != ' ')
                //    {
                //        cad2 = cad2 + array[i];
                //    }
                //    if (j == 2 && array[i] != ' ')
                //    {
                //        cad3 = cad3 + array[i];
                //    }
                //    if (j == 3 && array[i] != ' ')
                //    {
                //        cad4 = cad4 + array[i];
                //    }
                //}
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
            }
            else
            {
                db.AddInParameter(SQL, nombreCampo, DbType.String, busqueda);
            }
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                        jubilado = lector.GetBoolean(lector.GetOrdinal("jubilado"))
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

    public List<Mant_Per_Cont> listarBuscadosxDireccion(Mant_Contribuyente cont, int oficina)
    {

        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 15);
            db.AddInParameter(SQL, "c_num", DbType.String, cont.c_num);
            db.AddInParameter(SQL, "c_mz", DbType.String, cont.c_mz);
            db.AddInParameter(SQL, "c_lote", DbType.String, cont.c_lote);
            db.AddInParameter(SQL, "c_interior", DbType.String, cont.c_interior);
            db.AddInParameter(SQL, "c_dpto", DbType.String, cont.c_dpto);
            db.AddInParameter(SQL, "c_edificio", DbType.String, cont.c_edificio);
            db.AddInParameter(SQL, "c_piso", DbType.String, cont.c_piso);
            db.AddInParameter(SQL, "c_tienda", DbType.String, cont.c_tienda);
            db.AddInParameter(SQL, "oficina", DbType.String, oficina);
            db.AddInParameter(SQL, "ruc", DbType.String, cont.ruc);// if es tipo 15 , cmabiar via_junta_id if tipo =14
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta"))

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

    public List<Mant_Contribuyente> listarIdContribuyente(int persona_id)
    {
        try
        {
            var coleccion = new List<Mant_Contribuyente>();
            DbCommand SQL = db.GetStoredProcCommand("_Rep_HR");
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
            db.AddInParameter(SQL, "persona_id", DbType.Int32, persona_id);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Contribuyente
                    {
                        persona_id = lector.IsDBNull(lector.GetOrdinal("persona_id")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_id")),
                        razon_social = lector.GetString(lector.GetOrdinal("razon_social")),
                        TipoDocDescripcion = lector.GetString(lector.GetOrdinal("TipoDocDescripcion")),
                        ruc = lector.IsDBNull(lector.GetOrdinal("ruc")) ? default(String) : lector.GetString(lector.GetOrdinal("ruc")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta"))
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
    public List<Mant_Per_Cont> listarBuscadosxDireccionDePredio(Mant_Contribuyente cont, int oficina)
    {
        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 21);
            db.AddInParameter(SQL, "c_num", DbType.String, cont.c_num);
            db.AddInParameter(SQL, "c_mz", DbType.String, cont.c_mz);
            db.AddInParameter(SQL, "c_lote", DbType.String, cont.c_lote);
            db.AddInParameter(SQL, "c_interior", DbType.String, cont.c_interior);
            db.AddInParameter(SQL, "c_dpto", DbType.String, cont.c_dpto);
            db.AddInParameter(SQL, "c_edificio", DbType.String, cont.c_edificio);
            db.AddInParameter(SQL, "c_piso", DbType.String, cont.c_piso);
            db.AddInParameter(SQL, "c_tienda", DbType.String, cont.c_tienda);
            db.AddInParameter(SQL, "oficina", DbType.String, oficina);
            db.AddInParameter(SQL, "ruc", DbType.String, cont.ruc);// if es tipo 15 , cmabiar via_junta_id if tipo =14
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        //junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        //via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        //c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        //c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta"))

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
    public List<Mant_Per_Cont> listarBuscadosxDireccionDePredio2(Mant_Contribuyente cont, int oficina, int tipo)
    {
        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
            db.AddInParameter(SQL, "c_num", DbType.String, cont.c_num);
            db.AddInParameter(SQL, "c_mz", DbType.String, cont.c_mz);
            db.AddInParameter(SQL, "c_lote", DbType.String, cont.c_lote);
            db.AddInParameter(SQL, "c_interior", DbType.String, cont.c_interior);
            db.AddInParameter(SQL, "c_dpto", DbType.String, cont.c_dpto);
            db.AddInParameter(SQL, "c_edificio", DbType.String, cont.c_edificio);
            db.AddInParameter(SQL, "c_piso", DbType.String, cont.c_piso);
            db.AddInParameter(SQL, "c_tienda", DbType.String, cont.c_tienda);
            db.AddInParameter(SQL, "oficina", DbType.String, oficina);
            db.AddInParameter(SQL, "Contacto", DbType.String, cont.Contacto);
            db.AddInParameter(SQL, "DireccRepresentante", DbType.String, cont.DireccRepresentante);
            db.AddInParameter(SQL, "ruc", DbType.String, cont.ruc);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        //junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        //via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        //c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        //c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta"))

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
    public List<Mant_Per_Cont> listarBuscadosParaReajuste(string sector_id, int oficina, int tipo)
    {
        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);//tipo 37 sector:38 todos
            db.AddInParameter(SQL, "junta_ID", DbType.String, sector_id);
            db.AddInParameter(SQL, "oficina", DbType.String, oficina);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        //junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        //via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        //c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        //c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta"))

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
    public List<Mant_Cont> listarBuscados1(string busqueda, int tipo, string nombreCampo, int oficina)
    {

        try
        {
            var coleccion = new List<Mant_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
            db.AddInParameter(SQL, "oficina", DbType.Int32, oficina);
            if (tipo == 25)
            { //busqueda solo x nombre
                String cadena = busqueda;
                String cad1 = "%" + busqueda;
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                //char[] array = cadena.ToCharArray();
                //int j = 0;
                //for (int i = 0; i < cadena.Length; i++)
                //{
                //    if (array[i] == ' ')
                //    {
                //        j++;
                //    }
                //    if (j == 0 && array[i] != ' ')
                //    {
                //        cad1 = cad1 + array[i];
                //    }
                //    if (j == 1 && array[i] != ' ')
                //    {
                //        cad2 = cad2 + array[i];
                //    }
                //    if (j == 2 && array[i] != ' ')
                //    {
                //        cad3 = cad3 + array[i];
                //    }
                //    if (j == 3 && array[i] != ' ')
                //    {
                //        cad4 = cad4 + array[i];
                //    }
                //}
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
            }
            else
            {
                db.AddInParameter(SQL, nombreCampo, DbType.String, busqueda);
            }
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                        tipoDocumentoDescripcion = lector.GetString(lector.GetOrdinal("tipoDocumentoDescripcion")),
                        sector = lector.GetString(lector.GetOrdinal("sector")),
                        estado_contribuyente = lector.GetString(lector.GetOrdinal("estado_contribuyente"))
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
    public List<Mant_Cont> listarBuscadosxDireccion1(Mant_Contribuyente cont)
    {

        try
        {
            var coleccion = new List<Mant_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 15);
            db.AddInParameter(SQL, "c_num", DbType.String, cont.c_num);
            db.AddInParameter(SQL, "c_mz", DbType.String, cont.c_mz);
            db.AddInParameter(SQL, "c_lote", DbType.String, cont.c_lote);
            db.AddInParameter(SQL, "c_interior", DbType.String, cont.c_interior);
            db.AddInParameter(SQL, "c_dpto", DbType.String, cont.c_dpto);
            db.AddInParameter(SQL, "c_edificio", DbType.String, cont.c_edificio);
            db.AddInParameter(SQL, "c_piso", DbType.String, cont.c_piso);
            db.AddInParameter(SQL, "c_tienda", DbType.String, cont.c_tienda);
            db.AddInParameter(SQL, "ruc", DbType.String, cont.ruc);// if es tipo 15 , cmabiar via_junta_id if tipo =14
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                        tipoDocumentoDescripcion = lector.GetString(lector.GetOrdinal("tipoDocumentoDescripcion")),
                        sector = lector.GetString(lector.GetOrdinal("sector")),
                        estado_contribuyente = lector.GetString(lector.GetOrdinal("estado_contribuyente"))
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

    public List<Mant_Per_Cont> listarSoloCOntribuyente(String documento, string persona_ID, string cadena, int tipo)
    {
        try
        {
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
            //documento 27,persona 28, name 29
            var coleccion = new List<Mant_Per_Cont>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Int32, tipo);
            db.AddInParameter(SQL, "documento", DbType.String, documento);
            db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
            db.AddInParameter(SQL, "n1", DbType.String, cad1);
            db.AddInParameter(SQL, "n2", DbType.String, cad2);
            db.AddInParameter(SQL, "n3", DbType.String, cad3);
            db.AddInParameter(SQL, "n4", DbType.String, cad4);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Per_Cont
                    {
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento"))
                        //departamento = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        //provincia = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        //distrito = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        //junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        //via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        //num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        //mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        //interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        //Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        //edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        //piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        //Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        //tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        //fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        //Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        //email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        ////celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        ////c_junta = lector.IsDBNull(lector.GetOrdinal("c_junta")) ? default(String) : lector.GetString(lector.GetOrdinal("c_junta")),
                        ////c_via = lector.IsDBNull(lector.GetOrdinal("c_via")) ? default(String) : lector.GetString(lector.GetOrdinal("c_via")),
                        //c_num = lector.IsDBNull(lector.GetOrdinal("c_num")) ? default(String) : lector.GetString(lector.GetOrdinal("c_num")),
                        //c_mz = lector.IsDBNull(lector.GetOrdinal("c_mz")) ? default(String) : lector.GetString(lector.GetOrdinal("c_mz")),
                        //c_interior = lector.IsDBNull(lector.GetOrdinal("c_interior")) ? default(String) : lector.GetString(lector.GetOrdinal("c_interior")),
                        //c_lote = lector.IsDBNull(lector.GetOrdinal("c_lote")) ? default(String) : lector.GetString(lector.GetOrdinal("c_lote")),
                        //C_edificio = lector.IsDBNull(lector.GetOrdinal("C_edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("C_edificio")),
                        //c_piso = lector.IsDBNull(lector.GetOrdinal("c_piso")) ? default(String) : lector.GetString(lector.GetOrdinal("c_piso")),
                        //c_dpto = lector.IsDBNull(lector.GetOrdinal("c_dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("c_dpto")),
                        //c_tienda = lector.IsDBNull(lector.GetOrdinal("c_tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("c_tienda")),
                        //expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        //referencia = lector.IsDBNull(lector.GetOrdinal("referencia")) ? default(String) : lector.GetString(lector.GetOrdinal("referencia")),
                        //Contacto = lector.IsDBNull(lector.GetOrdinal("Contacto")) ? default(String) : lector.GetString(lector.GetOrdinal("Contacto")),
                        //dniRepresentante = lector.IsDBNull(lector.GetOrdinal("dniRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("dniRepresentante")),
                        //DireccRepresentante = lector.IsDBNull(lector.GetOrdinal("DireccRepresentante")) ? default(String) : lector.GetString(lector.GetOrdinal("DireccRepresentante")),
                        //Sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        //direccCompleta = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta"))

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
    public Mant_Per_Cont listarDatosPersonales(string PERSONA_ID, int tipo)
    {
        try
        {
            var coleccion = new List<Mant_Per_Cont>();
            var Per_Cont = default(Mant_Per_Cont);
            //tipo 31//datos personales,32 dato sde conyuge, 33 dato de apoderado
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
            db.AddInParameter(SQL, "persona_id", DbType.String, PERSONA_ID);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Per_Cont = new Mant_Per_Cont
                    {
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        departamento = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                        provincia = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                        distrito = lector.IsDBNull(lector.GetOrdinal("tipo_documento")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_documento"))
                    };
                }
            }
            SQL.Dispose();
            return Per_Cont;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}


