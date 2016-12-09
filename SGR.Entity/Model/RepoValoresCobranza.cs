using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Entity.Model
{
    public class RepoValoresCobranza
    {
        public int row { get; set; }
        //Campos para orden
        public int ordenN { get; set; }
        public string naturaleza { get; set; }
        public int or_documento { get; set; }
        public int año { get; set; }
        public int folios { get; set; }
        public string tributo { get; set; }
        public Decimal deuda { get; set; }

        //Campos para liquidación.
        public Decimal baseImponible { get; set; }
        public Decimal montoInsoluto { get; set; }
        public Decimal reajuste { get; set; }
        public Decimal interesMoratorio { get; set; }
        public Decimal totalDeuda { get; set; }
        public string descrip_uit { get; set; }
        public Decimal enSoles { get; set; }
        public String alicuota { get; set; }
        public Decimal porTramo { get; set; }
        public Decimal acumulado { get; set; }

        //Campos para contribuyente
        public String persona_id { get; set; }
        public String razon_social { get; set; }
        public String documento { get; set; }
        public String direcCompleta { get; set; }

        //Campos para predios
        public String predio_id { get; set; }
        public String catastro { get; set; }
        public String pred_direcCompleta { get; set; }        
        public String exoneracion { get; set; }
        public Decimal porcentajeCondominio { get; set; }
        public String fechaAdquision { get; set; }
        public Decimal areaTerreno { get; set; }
        public Decimal arancel { get; set; }
        public Decimal areaConstruida { get; set; }
        public Decimal valorContruccion { get; set; }
        public Decimal valorTerreno { get; set; }
        public Decimal valorOtraInstalacion { get; set; }
        public Decimal totalAutovaluo { get; set; }

        //Campos para tipos
        public String tipoPredio { get; set; }
        public String condicionPredio { get; set; }
        public String estadoPredio { get; set; }
        public String tipoPropiedad { get; set; }
        public String usoPropiedad { get; set; }

        //Campos para pisos
        public Int32 piso_ID { get; set; }
        public Int32 numero { get; set; }
        public String antiguedad { get; set; }
        public String fechaConstruccion { get; set; }
        public String muro { get; set; }
        public String techo { get; set; }
        public String piso { get; set; }
        public String puerta { get; set; }
        public String revestimiento { get; set; }
        public String banio { get; set; }
        public String instalaciones { get; set; }
        public Decimal valor_unitario { get; set; }
        public Decimal incremento { get; set; }
        public Decimal porcent_depreci { get; set; }
        public Decimal valor_unit_depreciado { get; set; }
        public Decimal area_construida { get; set; }
        public Decimal valor_construido { get; set; }
        public Decimal valor_comun { get; set; }
        public Decimal valor_construido_total { get; set; }        
    }
}
