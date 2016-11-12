<?php

error_reporting(5);
if (!file_exists("config/config.php")) {
    header("Location: logout.php");
    exit();
}

require_once( "config/config.php" );
require_once( "config/configs.php" );

require_once( $_CONF["includes"] . "database.php" );
require_once( $_CONF["includes"] . "functions.php" );

$database = new database($_DB_host, $_DB_user, $_DB_pass, $_DB_name, $_DB_table_prefix);

$user = $database->getEscaped(trim(_GetParam($_POST, "username")));
$pass = $database->getEscaped(trim(_GetParam($_POST, "password")));
//$hidd = $database->getEscaped(trim(_GetParam($_POST, "hid")));
//if(trim($sLinea)!=$hidd){ header( "Location: logout.php" ); exit();}

$sql = "exec sp_logeo @opcion=1,@Usuario='".$user."', @Password='".$pass."'";

//$sql = "select * from sistema.fun_logeo('".$user."')";
//echo $sql;
$database->setQuery($sql);
$my = null;
$database->loadObject($my);
//var_dump($my);
if ($my->per_codigo != "") {
    if (strcmp($my->per_pass, $pass)!=0) {
        echo "{success: false, errors: { reason: 'Autenticacion Fallida, Clave incorrecta.' }}";
        exit();
    }

    session_name("dx/dy");
    session_start();
    session_set_cookie_params(time() + 1200);

    $session = md5(uniqid(time()));
    $logintime = time();
    $session_id = md5($my->per_login . $my->nombre . $my->apellido. "031105" . $logintime . $session);

    $sql = "update sistema.usuario set per_session='" . $session . "' where per_login='" . $my->per_login . "'";
    $sql = "exec sp_logeo @opcion=2,@Usuario='".$my->per_login."', @Password='".$session."'";
    //echo $sql;
    $database->setQuery($sql);
    if (!$database->query()) {
        echo "<script>alert('Sesion invalida');</script>\n";
        require "logout.php";
        exit();
    }
    if($my->Permitido=='1')
    {        
        //print_r($my);
        $_SESSION["login"] = $my->per_login;
        $_SESSION["per_codigo"] = $my->per_codigo;
        $_SESSION["per_apellidos"] = $my->apellido;        
        $_SESSION["per_nombres"] = $my->nombre;        
        //$_SESSION["rol"] = $my->rol;                        
        $_SESSION["_id_"] = $session_id;
        //$_SESSION["url"] = "http://localhost:50/Dropbox/GestionNETv2/modules/html2pdf";
        $_SESSION["url"] = "http://localhost:50/Dropbox/GestionNETv2/modules/html2pdf";
        $_SESSION["_session"] = $session;
        $_SESSION["_logintime"] = $logintime;
        
        $_SESSION["flag_explorar"]=true;
        $_SESSION["flag_modificar"]=false;
        $_SESSION["flag_agregar"]=false;
        /*++++++++++++++++++++++++++++++++++++++++++++++++++*/                
        
        session_write_close();
        echo "{success: true,'msj':'1'}";
    }
    else
        
        echo "{success: true,'msj':'2'}";
    
} else {
    echo "{success: false, errors: { reason: 'Autenticacion Fallida, Usuario incorrecto.' }}";
    exit();
}

;
?>
