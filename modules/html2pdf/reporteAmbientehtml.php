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
<page backtop="20mm" backbottom="14mm" backleft="10mm" backright="10mm" pagegroups="new" style="font-size: 12pt">
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
            echo '<div style="margin-top: 100px;">';
        }
        else
        {
            echo '<div style="margin-top: 40px;">';
        }
        echo '
            <p style="float: left; font-size: 12pt; margin: 0 0 0 50px;" >'.$ambiente.'</p>
            <p style="text-align: right; font-size: 12pt;margin-top:-17px; margin-right: 50px;" >'.$nivel.'</p>
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
                <tbody>';        
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
            }
                    echo '
                </tbody>
            </table>    
        </div>';                    
    }
    echo'
    </page>';   
}
