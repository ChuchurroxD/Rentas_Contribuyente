<?php

if (isset($_REQUEST['task']))
    $task = $_REQUEST['task'];
else
    $task = "";
if ($task != "html") {
    include_once( "../../config/conexion.php");
    require_once( "../../includes/functions.php" );
}

switch ($task) {
    case "cargarReporte": _cargarReporte();
        break; //actualizar datos
    //default: _CargarReporte();
}

function _cargarReporte() {
    global $database; 
    $ambiente = _GetParam($_REQUEST, 'ambiente');
    $local= _GetParam($_REQUEST, 'local');
    $area = _GetParam($_REQUEST, 'area');
    
    
    $sql1 = "select descripcion from inventario.local where idlocal = ".$local;    
    //echo $sql1;
    $database->setQuery($sql1);
    $nombreLocal = $database->loadResult();        
    
    
    $sql2 = "select descripcion from inventario.area where idarea = ".$area;    
    $database->setQuery($sql2);
    $nombreArea = $database->loadResult();            
    
    if ($ambiente != '')                    
    {
        $sql3 = "select ia.idambiente as id, ia.descripcion as ambiente, sm.descripcion as nivel
                        from inventario.ambiente ia
                        inner join sistema.multitabla sm on sm.tabla_id = ia.idnivel
                        where ia.idambiente = ".$ambiente;                
    }   
    else
    {
        $sql3 = "select ia.idambiente as id, ia.descripcion as ambiente, sm.descripcion as nivel
                        from inventario.ambiente ia
                        inner join sistema.multitabla sm on sm.tabla_id = ia.idnivel
                        where ia.idlocal = ".$local;                
    }                                
    
    $database->setQuery($sql3);  
    
    $nombresAmbienteNivel = $database->loadObjectList();                        
    
    
    $time = time();
    
     echo '
<style type="text/css">
<!--
    table.page_header {width: 100%; border: none; padding: 2mm; position:fixed; margin-top: 20px; }
    table.page_footer {width: 100%; border: none; border-top: solid 0.8mm; padding: 2mm; position:fixed;}
-->
</style>
<page backtop="40mm" backbottom="14mm" backleft="10mm" backright="10mm" pagegroups="new" style="font-size: 12pt">
    <page_header>
        <table class="page_header">
            <tr style="width:100%">
                <td colspan="2" style="width:100%; text-align: left">
                   <img src="../../images/insignia_sanjo.gif" alt="loogo" style="width: 10mm; float:left; margin-left: 30px;"><p style="font-size: 15pt;"><b>SAN JOSÉ OBRERO MARIANISTAS</b></p>
                </td>                                                                
            </tr>            
            <tr>
                <td colspan="1">
                   <p style="font-size: 12pt; margin: 0px 0 0px 30px;" ><b>LOCAL:</b>  '.$nombreLocal.'</p>
                </td>                                                                
                <td colspan="1">
                   <p style="text-align: right; font-size: 12pt; margin-right: 30px;" ><b>AREA:</b>  '.$nombreArea.'</p>
                </td>                                                                
            </tr>';
     if ($ambiente == '')                       
     {
            echo '
            <tr style="width:100%">
                <td colspan="2" style="width:100%; text-align: left">
                   <p style="text-align: left; font-size: 12pt; margin-top:-5px; margin-left: 30px;" ><b>AMBIENTE:</b>  --TODOS--</p>
                </td>                                                                
            </tr>';        
     }        
     echo'
        </table>';     
    echo'                   
    </page_header>
    <page_footer>
        <table class="page_footer">
            <tr>
                <td style="width: 30%; text-align: left;">Sistema Activos e Inventarios</td>
                <td style="width: 40%; text-align: center">
                     PÁGINA [[page_cu]]/[[page_nb]] </td>
                <td style="width: 30%; text-align: right">Fecha: '.date("d-m-Y (H:i:s)", $time).'</td>
            </tr>                
        </table>
    </page_footer>';
    $numerotabla = 0;
    foreach ($nombresAmbienteNivel as $key => $v) {
        $idambiente = utf8_decode($v->id);
        $ambiente = utf8_decode($v->ambiente);
        $nivel = utf8_decode($v->nivel);        
        $numerotabla = $numerotabla + 1;
        if ($numerotabla == 1)
        {
            echo '<div style="margin-top:0px; position:fixed; " >';
        }
        else
        {
            echo '<div style="margin-top: 0px; position:fixed; ">';
        }
        echo '
            <p style="float: left; font-size: 12pt; margin: 0 0 0 50px;" >'.$ambiente.'</p>
            <p style="text-align: right; font-size: 12pt;margin-top:-17px; margin-right: 50px;" >'.$nivel.'</p>
            ';
        $bienesAmbiente = "select ib.idbien, ib.descripcion, ima.descripcion as marca, imo.descripcion as modelo, imul.descripcion as color, imu.descripcion as material , count(*) as cantidad
                                from inventario.itembien ii                                
                                inner join inventario.bien ib on ib.idbien = ii.idbien
                                inner join inventario.modelo imo on imo.idmodelo = ib.idmodelo
                                inner join inventario.marca ima on ima.idmarca = imo.idmarca
                                inner join sistema.multitabla imu on imu.tabla_id = ib.idmaterial
                                inner join sistema.multitabla imul on imul.tabla_id = ib.idcolor
                                where ii.idestado = 1 and ii.idambiente = ".$idambiente." and ii.idarea = ".$area."
                                group by ib.idbien, ima.descripcion, imo.descripcion, imul.descripcion, imu.descripcion	
                                order by ib.idbien;";                
        $database->setQuery($bienesAmbiente);
        $RowsDatos = $database->loadObjectList();
        foreach ($RowsDatos as $key => $v) {
            $codigo = utf8_decode($v->idbien);
            $bien = utf8_decode($v->descripcion);
            $marca = utf8_decode($v->marca);
            $modelo = utf8_decode($v->modelo);
            $color = utf8_decode($v->color);
            $material = utf8_decode($v->material);
            $cantidad = utf8_decode($v->cantidad);
                    echo ' 

            <table BORDER CELLSPACING=0 style="width: 100%; cursor: pointer; margin-top:-10px; padding:8px; font-size: 10pt;" align="center">
                <thead>
                    <tr>
                        <th style="width: 10%; height: 20px; text-align: left;
                            border-bottom: 1px solid; border-top: 1px solid;">idBien</th>
                        <th style="width: 20%; height: 20px; text-align: left;
                            border-bottom: 1px solid; border-top: 1px solid;">Descripción</th>                
                        <th style="width: 15%; height: 20px; text-align: left;
                            border-bottom: 1px solid; border-top: 1px solid;">Marca</th>
                        <th style="width: 15%; height: 20px; text-align: left;
                            border-bottom: 1px solid; border-top: 1px solid;">Modelo</th>
                        <th style="width: 15%; height: 20px; text-align: left;
                            border-bottom: 1px solid; border-top: 1px solid;">Color</th>
                        <th style="width: 15%; height: 20px; text-align: left;
                            border-bottom: 1px solid; border-top: 1px solid;">Material</th>
                        <th style="width: 10%; height: 20px; text-align: left;
                            border-bottom: 1px solid; border-top: 1px solid;">Cantidad</th>
                     </tr>
                </thead>
                <tbody>
                
                        <tr>
                            <td style="width: 10%; text-align: right;">'.$codigo.'
                                </td>
                            <td style="width: 20%; text-align: left;">'.$bien.'
                                </td>
                            <td style="width: 15%; text-align: left;">'.$marca.'
                                </td>                
                            <td style="width: 15%; text-align: left;">'.$modelo.'
                                </td>  
                            <td style="width: 15%; text-align: left;">'.$color.'
                                </td>
                            <td style="width: 15%; text-align: left;">'.$material.'
                                </td>                
                            <td style="width: 10%; text-align: right;">'.$cantidad.'
                                </td>  
                        </tr>';                                    
                    echo '
                </tbody>
            </table>    
            
            
            <table BORDER CELLSPACING=0 style="width: 95%; cursor: pointer; margin-top:0px; padding:8px; font-size: 10pt;" align="center">
                <thead>
                    <tr>
                        <th style="width: 10%; height: 20px; text-align: left;">Id Inv.</th>
                        <th style="width: 15%; height: 20px; text-align: left;">FechaCompra</th>                
                        <th style="width: 15%; height: 20px; text-align: left;">idSerie</th>
                        <th style="width: 15%; height: 20px; text-align: left;">Responsable</th>
                        <th style="width: 25%; height: 20px; text-align: left;">Ubicación (L./Am./Ar.)</th>
                        <th style="width: 10%; height: 20px; text-align: left;">Observ.</th>                        
                     </tr>
                </thead>
                <tbody>';
           $itemsAmbiente = "select (case when length(cast(ii.idinventario as text)) = 1 then concat('0',ii.idinventario) else ii.idinventario end) as inventario, ii.fechacompra as fecha, ii.serie as serie, sp.per_apellidos as responsable,
                                cast(concat(il.descripcion,'/',ia.descripcion,'/',iar.descripcion) as character varying) as ubicacion, cast('' as text) as observacion
                                    from inventario.itembien ii                                
                                    inner join inventario.ambiente ia on ia.idambiente = ii.idambiente
                                    inner join inventario.local il on il.idlocal = ii.idlocal
                                    inner join inventario.area iar on iar.idarea = ii.idarea
                                    inner join inventario.responsable ir on ii.idresponsable = ir.idresponsable
                                    inner join sistema.persona sp on sp.idpersona = ir.idpersona               
                                    where ii.idestado = 1 and ii.idambiente = ".$idambiente." and ii.idarea = ".$area." and ii.idbien = ".$codigo."
                                    order by 1;";                
        $database->setQuery($itemsAmbiente);
        $RowsDatos2 = $database->loadObjectList();
        foreach ($RowsDatos2 as $key2 => $v2) {
            $inventario = utf8_decode($v2->inventario);
            $fecha = utf8_decode($v2->fecha);
            $serie = utf8_decode($v2->serie);
            $responsable = utf8_decode($v2->responsable);
            $ubicacion = utf8_decode($v2->ubicacion);
            $observacion = utf8_decode($v2->observacion);            
                    echo ' 
                        <tr>
                            <td style="width: 10%; text-align: left;border-bottom: 1px solid #ddd;">'.$inventario.'
                                </td>
                            <td style="width: 15%; text-align: right;border-bottom: 1px solid #ddd;">'.$fecha.'
                                </td>
                            <td style="width: 15%; text-align: left;border-bottom: 1px solid #ddd;">'.$serie.'
                                </td>                
                            <td style="width: 15%; text-align: left;border-bottom: 1px solid #ddd;">'.$responsable.'
                                </td>  
                            <td style="width: 25%; text-align: left;border-bottom: 1px solid #ddd;">'.$ubicacion.'
                                </td>
                            <td style="width: 15%; text-align: left;border-bottom: 1px solid #ddd;">'.$observacion.'
                                </td>                                            
                        </tr>';                 
        }
                    echo '
                </tbody>
            </table>




            ';                    
        }
        echo'
        </div>';                    
    }
    echo'
    </page>';   
}
