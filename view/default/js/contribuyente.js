
var dia = document.getElementById('param_fechaInicio');
var date = new Date();
var añoActual = date.getFullYear();
//FUNCIONES
function alCargarDocumento(){
    dia.value=añoActual + "-01-01";  
}

//EVENTOS
window.addEventListener("load", alCargarDocumento);


window.onload = function()
{      
    $('#mensaje').html("Información del Predio en el Año Actual por defecto"); 
    mostrarMenu();
    mostrarPeriodo();
    $('#predios').show(); 
    $('#estadoDeudas').hide(); 
    $('#cuentaCorriente').hide();   
    $('#relaciones').hide(); 
    $('#fraccionamiento').hide();
    $('#liquidaciones').hide(); 
    $('#recibosCobranza').hide(); 
    $('#pagos').hide(); 
    $('#valores').hide(); 
    $('#pagosDetalle').hide();    
    mostrarContribuyente();    
    mostrarPrediosActual();
    mostrarTipoPago();  
    mostrarCajero(); 
    mostrarCaja();
};

$(function() {
    $('#verPredios').on('click', function(){ 
        event.preventDefault();
       $('#predios').show(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').hide(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').hide(); 
        $('#valores').hide();
        $('#pagosDetalle').hide();  
        mostrarPeriodo(); 
        mostrarPredios();    
    }); 

    $('#verDeudas').on('click', function(){
        event.preventDefault();
        $('#predios').hide(); 
        $('#estadoDeudas').show(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').hide(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').hide(); 
        $('#valores').hide(); 
        $('#pagosDetalle').hide();            
    }); 

    $('#verCuentaCorriente').on('click', function(){ 
        event.preventDefault();
        $('#predios').hide(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').show();
        $('#relaciones').hide(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').hide(); 
        $('#valores').hide();
        $('#pagosDetalle').hide();    
    });

    $('#verRelaciones').on('click', function(){ 
        event.preventDefault();
        $('#predios').hide(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').show(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').hide(); 
        $('#valores').hide();
        $('#pagosDetalle').hide();    
        mostrarRelaciones();
    });

    $('#verFraccionamiento').on('click', function(){ 
        event.preventDefault();
        $('#predios').hide(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').hide(); 
        $('#fraccionamiento').show(); 
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').hide(); 
        $('#valores').hide(); 
        $('#pagosDetalle').hide();   
    });

    $('#verLiquidaciones').on('click', function(){ 
        event.preventDefault();
        $('#predios').hide(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').hide(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').show(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').hide(); 
        $('#valores').hide();  
        $('#pagosDetalle').hide();  
    });

    $('#verRecibosCobranza').on('click', function(){ 
        event.preventDefault();
        $('#predios').hide(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').hide(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').show(); 
        $('#pagos').hide(); 
        $('#valores').hide();
        $('#pagosDetalle').hide();  
    });

    $('#verPagos').on('click', function(){ 
        event.preventDefault();
        $('#predios').hide(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').hide(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').show(); 
        $('#valores').hide(); 
        $('#pagosDetalle').hide();          
        mostrarPagos();
         
    });

    $('#verValores').on('click', function(){ 
        event.preventDefault();
        $('#mensajeValores').html("Información Valores de Cobranza en el Año Actual por defecto"); 
        $('#predios').hide(); 
        $('#estadoDeudas').hide(); 
        $('#cuentaCorriente').hide();
        $('#relaciones').hide(); 
        $('#fraccionamiento').hide();
        $('#liquidaciones').hide(); 
        $('#recibosCobranza').hide(); 
        $('#pagos').hide(); 
        $('#valores').show(); 
        $('#pagosDetalle').hide();         
        mostrarPeriodoValores();
        mostrarValoresActual();  
    });

    $('#busqueda').on('click', function(){ 
        event.preventDefault();
        mostrarPagosBusqueda();
        $('#mensajePagos').hide(); 
    });

    $('#volverPago').on('click', function(){ 
        event.preventDefault();
        $('#pagos').show(); 
        $('#pagosDetalle').hide();
        mostrarPagos();
    });
});


function mostrarMenu() {
    event.preventDefault();
    var grupo = document.getElementById('NombreGrupo').value;
    var tarea = document.getElementById('NombreTarea').value;    
    $.ajax({
        type:'POST',
        data: 'opcion=mostrarMenu&grupo='+grupo+'&tarea='+tarea,        
        url: "../../controller/controlusuario/usuario.php",
        success:function(data){                              
            $('#permisos').html(data);                
        }
    });
}

function mostrarContribuyente(){
    event.preventDefault();
    var param_opcion = 'datos_contribuyente'
    //alert(grupo);
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,
        dataType: 'json',
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){ 
            if(data.length > 0) {
               $.each(data, function (i, value) {
                    $("#nombres").html(value["paterno"]+' '+value["materno"]+' '+value["nombres"]);
                    $("#docIdentidad").html(value["tipoDocumentoDescripcion"]);
                    $("#codigo").html(value["persona_ID"]);
                    $("#direccion").html(value["direccCompleta"]);
                    $("#sector").html(value["sector"]);
                    $("#estadoCuenta").html(value["estado_contribuyente"]);
                    
                });
            }                                        
        }
    });
}

function mostrarPeriodo(){
    event.preventDefault();
    var param_opcion = 'mostrar_periodo'
    //alert(grupo);
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#periodo').html(data);                                            
        }
    });
}

function mostrarRelaciones(){
    event.preventDefault();
    var param_opcion = 'mostrar_relaciones'
    //alert(grupo);
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoRelaciones').html(data);   
        }
    });
}


function mostrarPeriodoValores(){
    event.preventDefault();
    var param_opcion = 'mostrar_periodo_valores'
    //alert(grupo);
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#periodoValores').html(data);   
        }
    });
}

function mostrarPrediosActual(){   
    event.preventDefault();
   //alert('Predios del año actual');
   var param_opcion = 'opcion_predios_actual'
   $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoPredios').html(data);                                
        }
    });
}

function mostrarValoresActual(){  
    event.preventDefault(); 
   //alert('Predios del año actual');
   var param_opcion = 'opcion_valores_actual'
   $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoValores').html(data);                                
        }
    });
}

function mostrarPrediosPorPeriodo(){
    event.preventDefault();
   var param_periodo = document.getElementById('param_periodo').value; 
   $('#mensaje').html("Información del Predio en el Año: "+param_periodo); 
   var param_opcion = 'opcion_predio_seleccionado'
   $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion+'&param_periodo='+param_periodo,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoPredios').html(data);                                
        }
    });
}

function mostrarValoresPorPeriodo(){
    event.preventDefault();
   var param_periodo = document.getElementById('param_periodo_valores').value; 
   $('#mensaje').html("Información Valores de Cobranza en el Año: "+param_periodo); 
   var param_opcion = 'opcion_valores_seleccionado'
   $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion+'&param_periodo='+param_periodo,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoValores').html(data);                                
        }
    });
}

function mostrarTipoPago(){
    event.preventDefault();
    var param_opcion = 'mostrar_combo_tipo_pago'    
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#tipoPago').html(data);                                            
        }
    });
}

function mostrarCajero(){
    event.preventDefault();
    var param_opcion = 'mostrar_combo_cajero'    
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cajero').html(data);                                            
        }
    });
}

function mostrarCaja(){
    event.preventDefault();
    var param_opcion = 'mostrar_combo_caja'    
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion,        
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#caja').html(data);                                            
        }
    });
}

function mostrarPagos(){  
    event.preventDefault();  
    var param_fechaInicio = document.getElementById('param_fechaInicio').value; 
    var param_fechaFin = document.getElementById('param_fechaFin').value; 
    var param_tipoPago = document.getElementById('param_tipoPago').value; 
    var param_cajero = document.getElementById('param_cajero').value; 
    var param_caja = document.getElementById('param_caja').value;     
    var param_opcion = 'mostrar_pagos';    
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion+'&param_fechaInicio='+param_fechaInicio+'&param_fechaFin='+param_fechaFin+'&param_tipoPago='+param_tipoPago+'&param_cajero='+param_cajero+'&param_caja='+param_caja,  
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoPagos').html(data); 
        }            
    });
}

function mostrarPagosBusqueda(){  
    event.preventDefault();  
    var param_fechaInicio = document.getElementById('param_fechaInicio').value; 
    var param_fechaFin = document.getElementById('param_fechaFin').value; 
    var param_tipoPago = document.getElementById('param_tipoPago').value; 
    var param_cajero = document.getElementById('param_cajero').value; 
    var param_caja = document.getElementById('param_caja').value;     
    var param_opcion = 'mostrar_pagos_busqueda';
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion+'&param_fechaInicio='+param_fechaInicio+'&param_fechaFin='+param_fechaFin+'&param_tipoPago='+param_tipoPago+'&param_cajero='+param_cajero+'&param_caja='+param_caja,  
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoPagos').html(data);                                            
        }
    });
}

function detallesPago(pagoID){ 
    event.preventDefault();      
    $('#pagos').hide(); 
    $('#pagosDetalle').show();
    var param_opcion = 'mostrar_pagos_detalle_cabecera';
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion+'&param_pagoID='+pagoID,  
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoPagosDetalleCabecera').html(data);    
            pago_detalle(pagoID);
        }
    });        
}

function pago_detalle(pagoID){ 
    event.preventDefault();     
    var param_opcion = 'mostrar_pagos_detalle';
    $.ajax({
        type:'POST',
        data:'param_opcion='+param_opcion+'&param_pagoID='+pagoID,  
        url: "../../controller/controlInformacion/contribuyente_controller.php",
        success:function(data){         
            $('#cuerpoPagosDetalle').html(data);                
        }
    });        
}

function imprimir_pago(pagoID){ 
    event.preventDefault();   
    alert(pagoID)  ;
       
}


