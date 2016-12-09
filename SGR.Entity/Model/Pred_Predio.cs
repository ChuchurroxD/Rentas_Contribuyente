using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity
{
    public class Pred_Predio
    {
        public String predio_ID { get; set; }
        public Int32 junta_via_ID { get; set; }
        public String num_via { get; set; }
        public String catastro { get; set; }
        public String interior { get; set; }
        public String mz { get; set; }
        public String lote { get; set; }
        public String edificio { get; set; }
        public String piso { get; set; }
        public String dpto { get; set; }
        public String tienda { get; set; }
        public Int32 cuadra { get; set; }
        public String direccion_completa { get; set; }
        public String kilometro { get; set; }
        public String nombre_predio { get; set; }
        public Int32 lado { get; set; }
        public String referencia { get; set; }
        public Int32 frente_a { get; set; }
        public Decimal frente_metros { get; set; }
        public Int32 num_personas { get; set; }
        public DateTime fecha_terreno { get; set; }
        public Int32 tipo_operacion { get; set; }
        public Decimal area_terreno { get; set; }
        public Decimal area_construida { get; set; }
        public Int32 anios_antiguedad { get; set; }
        public Int32 tipo_inmueble { get; set; }
        public Int32 tipo_predio { get; set; }
        public Int32 estado_predio { get; set; }
        public String uso_predio { get; set; }
        public String uso_codigo { get; set; }
        public String num_ficha { get; set; }
        public Int32 tipo_adquisicion { get; set; }
        public Int32 clase_edificacion { get; set; }
        public DateTime fecha_adquisicion { get; set; }
        public Int32 exo_predial { get; set; }
        public Decimal exo_predial_porcentaje { get; set; }
        public Int16 exo_anio { get; set; }
        public Int32 motivo_exoneracion { get; set; }
        public Decimal porcen_area_comun { get; set; }
        public Decimal valor_referencial { get; set; }
        public Decimal valor_terreno { get; set; }
        public Decimal valor_construccion { get; set; }
        public Decimal valor_otra_instalacion { get; set; }
        public Decimal valor_area_comun { get; set; }
        public Decimal total_autovaluo { get; set; }
        public Decimal impuesto_predial { get; set; }
        public Decimal alcabala { get; set; }
        public Int16 anio_adquisicion { get; set; }
        public DateTime fecha_inscripcion { get; set; }
        public Int16 anio_inscripcion { get; set; }
        public Int16 clasificacion_rustico { get; set; }
        public Int16 categoria_rustico { get; set; }
        public Int16 tipo_rustico { get; set; }
        public Int16 uso_rustico { get; set; }
        public Decimal hectareas { get; set; }
        public Boolean estado { get; set; }
        public String expediente { get; set; }
        public Boolean lista_negra { get; set; }
        public String nuevo_uso { get; set; }
        public Int32 sector { get; set; }
        public String nuevo_frente_a { get; set; }
        public Boolean validado { get; set; }

        public Decimal arancel { get; set; }
        public String Fiscalizado { get; set; }
        public String id_alicuota { get; set; }
        public String norte { get; set; }
        public String sur { get; set; }
        public String este { get; set; }
        public String oeste { get; set; }
        public Int16 Condicion_Rustico { get; set; }
        public Int16 Adquisicion_Rustico { get; set; }
        public Int16 GrupoTierra_Rustico { get; set; }
        public decimal porcentajecondominio { get; set; }
        public String mapa { get; set; }
        public String casa { get; set; }

        public DateTime registro_fecha_add { get; set; }
        public String registro_user_add { get; set; }
        public String registro_pc_add { get; set; }
        public DateTime registro_fecha_update { get; set; }
        public String registro_user_update { get; set; }
        public String registro_pc_update { get; set; }
        public String unidad_idep { get; set; }
        public String num_uni_indep { get; set; }
        public bool alquiler { get; set; }
        public bool terreno_sin_construir { get; set; }
        //NUEVOS
        public Int32 Junta_ID { get; set; }
        public Int32 Via_ID { get; set; }
        public decimal valorafecto { get; set; }

        public Int32 condicionPropietario { get; set; }
        public  String Observacion { get; set; }
        public String DescripcionHistorial { get; set; }
        public Int32 vez { get; set; }
    }
}
