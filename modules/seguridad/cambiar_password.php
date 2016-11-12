<?php
  if(isset($_REQUEST['task']))
    $task = $_REQUEST['task'];
  else
    $task = "";
  
  
  if( $task != "html"){
    include_once( "../../config/conexion.php");    
  }
  
  switch( $task ){    
    case "update": _Update(); break;
    case "html": _Html( $module, $option );    break;
    //default:     _Load();
  }
    
  function _Update(){
    global $database; 
    $usuario  = utf8_decode(_GetParam( $_REQUEST, 'usuario' ));
    $password = utf8_decode(_GetParam( $_REQUEST, 'password' ));
    //$repeat_password  = _GetParam( $_REQUEST, 'repeat_password' );
    
    $sql="exec sp_logeo @opcion='3',@Usuario='".$usuario."', @Password='".$password."', @Codigo='".$_SESSION["per_codigo"]."'";
    
    
    //echo $sql;
//    $sql = "{CALL dbo.sp_tarea( '', '".$grupo."', '".$nombre."', '".$descripcion."', '".$icono."', '".$orden."', '".$url.
//            "', '', '', '', '7','".$modulo."' )}";
    //echo $sql;
    $database->setQuery( $sql );
    if( $database->query($sql) ){
      echo "1";
    }else{  
      echo "0";
    }
    
  }

  
  function _Html( $module, $option ){        
    echo "<script type=\"text/javascript\" src=\"js/modules/".$module."/".$option.".js\"></script>\n";    
    echo "<div id=\"div_page\"></div>\n";
  }
  
?>