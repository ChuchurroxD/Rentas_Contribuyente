
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

public class Mant_PersonaRepository
{



    private const String nombreprocedimiento = "_Mant_Persona";
    private const String NombreTabla = "Persona";
    private Database db = DatabaseFactory.CreateDatabase();


    public List<Mant_Persona> listartodos()
    {
        try
        {
            var coleccion = new List<Mant_Persona>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Persona
                    {
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        tipo_persona =  lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        TipoPersonaDescripcion = lector.IsDBNull(lector.GetOrdinal("TipoPersonaDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoPersonaDescripcion")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        TipoDocDescripcion = lector.IsDBNull(lector.GetOrdinal("TipoDocDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoDocDescripcion")),
                        paterno = lector.IsDBNull(lector.GetOrdinal("paterno")) ? default(String) : lector.GetString(lector.GetOrdinal("paterno")),
                        materno = lector.IsDBNull(lector.GetOrdinal("materno")) ? default(String) : lector.GetString(lector.GetOrdinal("materno")),
                        nombres = lector.IsDBNull(lector.GetOrdinal("nombres")) ? default(String) : lector.GetString(lector.GetOrdinal("nombres")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        ESTADO = lector.GetBoolean(lector.GetOrdinal("ESTADO")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        dep = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        prov = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        OtraDireccion = lector.IsDBNull(lector.GetOrdinal("OtraDireccion")) ? default(String) : lector.GetString(lector.GetOrdinal("OtraDireccion")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        Declaracion = lector.IsDBNull(lector.GetOrdinal("Declaracion")) ? default(String) : lector.GetString(lector.GetOrdinal("Declaracion")),
                        sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        Ubi_codigo = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito"))
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
    public List<Mant_Persona> listarbuscados(String documento)
    {
        try
        {
            var coleccion = new List<Mant_Persona>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
            db.AddInParameter(SQL, "NombreCompleto", DbType.String, documento);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Persona
                    {
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        paterno = lector.IsDBNull(lector.GetOrdinal("paterno")) ? default(String) : lector.GetString(lector.GetOrdinal("paterno")),
                        materno = lector.IsDBNull(lector.GetOrdinal("materno")) ? default(String) : lector.GetString(lector.GetOrdinal("materno")),
                        nombres = lector.IsDBNull(lector.GetOrdinal("nombres")) ? default(String) : lector.GetString(lector.GetOrdinal("nombres")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        ESTADO = lector.GetBoolean(lector.GetOrdinal("ESTADO")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        dep = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        prov = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        OtraDireccion = lector.IsDBNull(lector.GetOrdinal("OtraDireccion")) ? default(String) : lector.GetString(lector.GetOrdinal("OtraDireccion")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        Declaracion = lector.IsDBNull(lector.GetOrdinal("Declaracion")) ? default(String) : lector.GetString(lector.GetOrdinal("Declaracion")),
                        sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        Ubi_codigo = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),


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
    public List<Mant_Persona> listarxidpersona(int idpersona)
    {
        try
        {
            var coleccion = new List<Mant_Persona>();
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 13);
            db.AddInParameter(SQL, "persona_ID", DbType.Int32 , idpersona);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Persona
                    {
                        persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                        tipo_persona = lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        tipo_documento = lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        TipoDocDescripcion = lector.IsDBNull(lector.GetOrdinal("TipoDocDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("TipoDocDescripcion")),
                        documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                        paterno = lector.IsDBNull(lector.GetOrdinal("paterno")) ? default(String) : lector.GetString(lector.GetOrdinal("paterno")),
                        materno = lector.IsDBNull(lector.GetOrdinal("materno")) ? default(String) : lector.GetString(lector.GetOrdinal("materno")),
                        nombres = lector.IsDBNull(lector.GetOrdinal("nombres")) ? default(String) : lector.GetString(lector.GetOrdinal("nombres")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        ESTADO = lector.GetBoolean(lector.GetOrdinal("ESTADO")),
                        junta_ID = lector.IsDBNull(lector.GetOrdinal("junta_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("junta_ID")),
                        via_ID = lector.IsDBNull(lector.GetOrdinal("via_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("via_ID")),
                        viaDescripcion = lector.IsDBNull(lector.GetOrdinal("viaDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("viaDescripcion")),
                        dep = lector.IsDBNull(lector.GetOrdinal("departamento")) ? default(String) : lector.GetString(lector.GetOrdinal("departamento")),
                        depDescripcion = lector.IsDBNull(lector.GetOrdinal("depDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("depDescripcion")),
                        prov = lector.IsDBNull(lector.GetOrdinal("provincia")) ? default(String) : lector.GetString(lector.GetOrdinal("provincia")),
                        provDescripcion = lector.IsDBNull(lector.GetOrdinal("provDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("provDescripcion")),
                        OtraDireccion = lector.IsDBNull(lector.GetOrdinal("OtraDireccion")) ? default(String) : lector.GetString(lector.GetOrdinal("OtraDireccion")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        Declaracion = lector.IsDBNull(lector.GetOrdinal("Declaracion")) ? default(String) : lector.GetString(lector.GetOrdinal("Declaracion")),
                        sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        fechaNacimiento = lector.GetDateTime(lector.GetOrdinal("fechaNacimiento")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        Ubi_codigo = lector.IsDBNull(lector.GetOrdinal("distrito")) ? default(String) : lector.GetString(lector.GetOrdinal("distrito")),
                        distritoDescripcion = lector.IsDBNull(lector.GetOrdinal("distritoDescripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("distritoDescripcion")),
                        Sector = lector.IsDBNull(lector.GetOrdinal("Sector")) ? default(String) : lector.GetString(lector.GetOrdinal("Sector")),

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
    public List<Mant_Persona> Getcoleccion(string wheresql, string orderbysql)
    {
        int totalRecordCount = -1;
        return Getcoleccion(wheresql, orderbysql, 0, int.MaxValue, totalRecordCount);
    }


    public virtual List<Mant_Persona> Getcoleccion(string wheresql, string orderbysql, int startIndex, int length, int totalRecordCount)
    {
        try
        {
            var coleccion = new List<Mant_Persona>();
            DbCommand SQL = db.GetSqlStringCommand(CreateGetCommand(wheresql, orderbysql));
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    coleccion.Add(new Mant_Persona
                    {
                        persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                        tipo_persona = lector.IsDBNull(lector.GetOrdinal("tipo_persona")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        tipo_documento = lector.IsDBNull(lector.GetOrdinal("tipo_documento")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        documento = lector.GetString(lector.GetOrdinal("documento")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        registro_fecha = lector.GetDateTime(lector.GetOrdinal("registro_fecha")),
                        registro_user = lector.GetString(lector.GetOrdinal("registro_user")),
                        per_edad = lector.IsDBNull(lector.GetOrdinal("per_edad")) ? default(String) : lector.GetString(lector.GetOrdinal("per_edad")),
                        ESTADO = lector.GetBoolean(lector.GetOrdinal("ESTADO")),
                        junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                        OtraDireccion = lector.IsDBNull(lector.GetOrdinal("OtraDireccion")) ? default(String) : lector.GetString(lector.GetOrdinal("OtraDireccion")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        Declaracion = lector.GetString(lector.GetOrdinal("Declaracion")),
                        Sector = lector.IsDBNull(lector.GetOrdinal("Sector")) ? default(String) : lector.GetString(lector.GetOrdinal("Sector")),
                        NombreCompleto = lector.IsDBNull(lector.GetOrdinal("NombreCompleto")) ? default(String) : lector.GetString(lector.GetOrdinal("NombreCompleto")),
                        sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        Ubi_codigo = lector.IsDBNull(lector.GetOrdinal("Ubi_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("Ubi_codigo"))

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


    public virtual Mant_Persona GetByPrimaryKey()
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
            var Persona = default(Mant_Persona);
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    Persona = new Mant_Persona
                    {
                        persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                        tipo_persona = lector.IsDBNull(lector.GetOrdinal("tipo_persona")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_persona")),
                        tipo_documento = lector.IsDBNull(lector.GetOrdinal("tipo_documento")) ? default(Int16) : lector.GetInt16(lector.GetOrdinal("tipo_documento")),
                        documento = lector.GetString(lector.GetOrdinal("documento")),
                        paterno = lector.GetString(lector.GetOrdinal("paterno")),
                        materno = lector.GetString(lector.GetOrdinal("materno")),
                        nombres = lector.GetString(lector.GetOrdinal("nombres")),
                        num_via = lector.IsDBNull(lector.GetOrdinal("num_via")) ? default(String) : lector.GetString(lector.GetOrdinal("num_via")),
                        interior = lector.IsDBNull(lector.GetOrdinal("interior")) ? default(String) : lector.GetString(lector.GetOrdinal("interior")),
                        Dpto = lector.IsDBNull(lector.GetOrdinal("Dpto")) ? default(String) : lector.GetString(lector.GetOrdinal("Dpto")),
                        mz = lector.IsDBNull(lector.GetOrdinal("mz")) ? default(String) : lector.GetString(lector.GetOrdinal("mz")),
                        Lote = lector.IsDBNull(lector.GetOrdinal("Lote")) ? default(String) : lector.GetString(lector.GetOrdinal("Lote")),
                        Observacion = lector.IsDBNull(lector.GetOrdinal("Observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("Observacion")),
                        Fono_Domicilio = lector.IsDBNull(lector.GetOrdinal("Fono_Domicilio")) ? default(String) : lector.GetString(lector.GetOrdinal("Fono_Domicilio")),
                        fono_oficina = lector.IsDBNull(lector.GetOrdinal("fono_oficina")) ? default(String) : lector.GetString(lector.GetOrdinal("fono_oficina")),
                        email = lector.IsDBNull(lector.GetOrdinal("email")) ? default(String) : lector.GetString(lector.GetOrdinal("email")),
                        registro_fecha = lector.GetDateTime(lector.GetOrdinal("registro_fecha")),
                        registro_user = lector.GetString(lector.GetOrdinal("registro_user")),
                        per_edad = lector.IsDBNull(lector.GetOrdinal("per_edad")) ? default(String) : lector.GetString(lector.GetOrdinal("per_edad")),
                        ESTADO = lector.GetBoolean(lector.GetOrdinal("ESTADO")),
                        junta_via_ID = lector.IsDBNull(lector.GetOrdinal("junta_via_ID")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("junta_via_ID")),
                        OtraDireccion = lector.IsDBNull(lector.GetOrdinal("OtraDireccion")) ? default(String) : lector.GetString(lector.GetOrdinal("OtraDireccion")),
                        expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                        Declaracion = lector.GetString(lector.GetOrdinal("Declaracion")),
                        Sector = lector.IsDBNull(lector.GetOrdinal("Sector")) ? default(String) : lector.GetString(lector.GetOrdinal("Sector")),
                        NombreCompleto = lector.IsDBNull(lector.GetOrdinal("NombreCompleto")) ? default(String) : lector.GetString(lector.GetOrdinal("NombreCompleto")),
                        sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(String) : lector.GetString(lector.GetOrdinal("sexo")),
                        edificio = lector.IsDBNull(lector.GetOrdinal("edificio")) ? default(String) : lector.GetString(lector.GetOrdinal("edificio")),
                        piso = lector.IsDBNull(lector.GetOrdinal("piso")) ? default(String) : lector.GetString(lector.GetOrdinal("piso")),
                        tienda = lector.IsDBNull(lector.GetOrdinal("tienda")) ? default(String) : lector.GetString(lector.GetOrdinal("tienda")),
                        celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? default(String) : lector.GetString(lector.GetOrdinal("celular")),
                        Ubi_codigo = lector.IsDBNull(lector.GetOrdinal("Ubi_codigo")) ? default(String) : lector.GetString(lector.GetOrdinal("Ubi_codigo"))

                    };
                }
            }
            SQL.Dispose();
            return Persona;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }



    protected virtual string CreateGetCommand(string whereSql, string orderBySql)
    {
        string sql = "SELECT * FROM [dbo].[Persona]";
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

    public virtual string Insert(Mant_Persona Persona)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "persona_ID", DbType.String, Persona.persona_ID);
            db.AddInParameter(SQL, "tipo_persona", DbType.Int16, Persona.tipo_persona);
            db.AddInParameter(SQL, "tipo_documento", DbType.Int16, Persona.tipo_documento);
            db.AddInParameter(SQL, "documento", DbType.String, Persona.documento);
            db.AddInParameter(SQL, "paterno", DbType.String, Persona.paterno);
            db.AddInParameter(SQL, "materno", DbType.String, Persona.materno);
            db.AddInParameter(SQL, "nombres", DbType.String, Persona.nombres);
            db.AddInParameter(SQL, "num_via", DbType.String, Persona.num_via);
            db.AddInParameter(SQL, "interior", DbType.String, Persona.interior);
            db.AddInParameter(SQL, "Dpto", DbType.String, Persona.Dpto);
            db.AddInParameter(SQL, "mz", DbType.String, Persona.mz);
            db.AddInParameter(SQL, "Lote", DbType.String, Persona.Lote);
            db.AddInParameter(SQL, "Observacion", DbType.String, Persona.Observacion);
            db.AddInParameter(SQL, "Fono_Domicilio", DbType.String, Persona.Fono_Domicilio);
            db.AddInParameter(SQL, "fono_oficina", DbType.String, Persona.fono_oficina);
            db.AddInParameter(SQL, "email", DbType.String, Persona.email);
            db.AddInParameter(SQL, "fechaNacimiento", DbType.DateTime, Persona.fechaNacimiento);
            db.AddInParameter(SQL, "registro_user", DbType.String, Persona.registro_user);
            db.AddInParameter(SQL, "per_edad", DbType.String, Persona.per_edad);
            db.AddInParameter(SQL, "ESTADO", DbType.Boolean, Persona.ESTADO);
            db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Persona.junta_via_ID);
            db.AddInParameter(SQL, "OtraDireccion", DbType.String, Persona.OtraDireccion);
            db.AddInParameter(SQL, "expediente", DbType.String, Persona.expediente);
            db.AddInParameter(SQL, "Declaracion", DbType.String, Persona.Declaracion);
            db.AddInParameter(SQL, "Sector", DbType.String, Persona.Sector);
            db.AddInParameter(SQL, "NombreCompleto", DbType.String, Persona.NombreCompleto);
            db.AddInParameter(SQL, "sexo", DbType.String, Persona.sexo);
            db.AddInParameter(SQL, "edificio", DbType.String, Persona.edificio);
            db.AddInParameter(SQL, "piso", DbType.String, Persona.piso);
            db.AddInParameter(SQL, "tienda", DbType.String, Persona.tienda);
            db.AddInParameter(SQL, "celular", DbType.String, Persona.celular);
            db.AddInParameter(SQL, "Ubi_codigo", DbType.String, Persona.Ubi_codigo);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
           string persona= Convert.ToString( db.ExecuteScalar(SQL));
           
            SQL.Dispose();
            return persona;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


    public virtual void Update(Mant_Persona Persona)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "persona_ID", DbType.String, Persona.persona_ID);
            db.AddInParameter(SQL, "tipo_persona", DbType.Int16, Persona.tipo_persona);
            db.AddInParameter(SQL, "tipo_documento", DbType.Int16, Persona.tipo_documento);
            db.AddInParameter(SQL, "documento", DbType.String, Persona.documento);
            db.AddInParameter(SQL, "paterno", DbType.String, Persona.paterno);
            db.AddInParameter(SQL, "materno", DbType.String, Persona.materno);
            db.AddInParameter(SQL, "nombres", DbType.String, Persona.nombres);
            db.AddInParameter(SQL, "num_via", DbType.String, Persona.num_via);
            db.AddInParameter(SQL, "interior", DbType.String, Persona.interior);
            db.AddInParameter(SQL, "Dpto", DbType.String, Persona.Dpto);
            db.AddInParameter(SQL, "mz", DbType.String, Persona.mz);
            db.AddInParameter(SQL, "Lote", DbType.String, Persona.Lote);
            db.AddInParameter(SQL, "Observacion", DbType.String, Persona.Observacion);
            db.AddInParameter(SQL, "Fono_Domicilio", DbType.String, Persona.Fono_Domicilio);
            db.AddInParameter(SQL, "fono_oficina", DbType.String, Persona.fono_oficina);
            db.AddInParameter(SQL, "email", DbType.String, Persona.email);
            db.AddInParameter(SQL, "fechaNacimiento", DbType.DateTime, Persona.fechaNacimiento);
            db.AddInParameter(SQL, "registro_user", DbType.String, Persona.registro_user);
            db.AddInParameter(SQL, "per_edad", DbType.String, Persona.per_edad);
            db.AddInParameter(SQL, "ESTADO", DbType.Boolean, Persona.ESTADO);
            db.AddInParameter(SQL, "junta_via_ID", DbType.Int32, Persona.junta_via_ID);
            db.AddInParameter(SQL, "OtraDireccion", DbType.String, Persona.OtraDireccion);
            db.AddInParameter(SQL, "expediente", DbType.String, Persona.expediente);
            db.AddInParameter(SQL, "Declaracion", DbType.String, Persona.Declaracion);
            db.AddInParameter(SQL, "Sector", DbType.String, Persona.Sector);
            db.AddInParameter(SQL, "NombreCompleto", DbType.String, Persona.NombreCompleto);
            db.AddInParameter(SQL, "sexo", DbType.String, Persona.sexo);
            db.AddInParameter(SQL, "edificio", DbType.String, Persona.edificio);
            db.AddInParameter(SQL, "piso", DbType.String, Persona.piso);
            db.AddInParameter(SQL, "tienda", DbType.String, Persona.tienda);
            db.AddInParameter(SQL, "celular", DbType.String, Persona.celular);
            db.AddInParameter(SQL, "Ubi_codigo", DbType.String, Persona.Ubi_codigo);
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

    public virtual Int32 GetIdPersonaMax()
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);
            Int32 total = 0;
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    total = lector.GetInt32(lector.GetOrdinal("idPersona"));

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
    public virtual Int32 GetExistePersona(String documento, Int16 tipodoc)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 9);
            db.AddInParameter(SQL, "tipo_documento", DbType.Int16, tipodoc);
            db.AddInParameter(SQL, "documento", DbType.String, documento);
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
    public virtual Int32 GetExisteCodigo(String cod)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
            db.AddInParameter(SQL, "persona_ID", DbType.String, cod);
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
    public virtual string GetPersonaExistente(String documento, Int16 tipodoc)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 10);
            db.AddInParameter(SQL, "tipo_documento", DbType.Int16, tipodoc);
            db.AddInParameter(SQL, "documento", DbType.String, documento);
            string total = "";
            using (var lector = db.ExecuteReader(SQL))
            {
                while (lector.Read())
                {
                    total = lector.GetString(lector.GetOrdinal("idPersona"));

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
    public virtual bool DeleteByPrimaryKey(String Per_id)
    {
        try
        {
            DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
            db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
            db.AddInParameter(SQL, "persona_ID", DbType.String, Per_id);
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
   



}


