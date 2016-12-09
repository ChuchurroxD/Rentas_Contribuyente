using System;
using System.Collections.Generic;
using System.Text;


namespace SGR.Entity

{ public class Mant_Persona
    {
        public String persona_ID { get; set; }
        public Int16 tipo_persona { get; set; }
        public String TipoPersonaDescripcion { get; set; }
        public Int16 tipo_documento { get; set; }
        public String TipoDocDescripcion { get; set; }
        public String documento { get; set; }
        public String paterno { get; set; }
        public String materno { get; set; }
        public String nombres { get; set; }
        public String num_via { get; set; }
        public String interior { get; set; }
        public String Dpto { get; set; }
        public String mz { get; set; }
        public String Lote { get; set; }
        public String Observacion { get; set; }
        public String Fono_Domicilio { get; set; }
        public String fono_oficina { get; set; }
        public String email { get; set; }
        public DateTime registro_fecha { get; set; }
        public string registro_user { get; set; }
        public String per_edad { get; set; }
        public Boolean ESTADO { get; set; }
        public Int32 junta_via_ID { get; set; }
        public String OtraDireccion { get; set; }
        public String expediente { get; set; }
        public String Declaracion { get; set; }
        public String Sector { get; set; }
        public String NombreCompleto { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String sexo { get; set; }
        public String edificio { get; set; }
        public String piso { get; set; }
        public String tienda { get; set; }
        public String celular { get; set; }
        public String Ubi_codigo { get; set; }
        public String distritoDescripcion { get; set; }
        public String junta_ID { get; set; }
        public String via_ID { get; set; }
        public String viaDescripcion { get; set; }
        public String dep { get; set; }
        public String depDescripcion { get; set; }
        public String prov { get; set; }
        public String provDescripcion { get; set; }
        public string registro_user_update { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_pc_add { get; set; }
        public String registro_pc_update { get; set; }
    }
}

