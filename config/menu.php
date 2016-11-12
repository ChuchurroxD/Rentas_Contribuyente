<?php 
  require_once( "configs.php" );
  include_once('../includes/database.php');
  session_name( "dx/dy" );
  session_start();
  
  
  
  $database = new database( $_DB_host, $_DB_user, $_DB_pass, $_DB_name, $_DB_table_prefix );
  
  $sql="select distinct g.grupo_id, g.gru_nombre, g.gru_orden, g.gru_icono 
            from tarea t 
            inner join grupo g on t.grupo_id = g.grupo_id 
            inner join Rol_Tarea p on t.tarea_id = p.tarea_id 
            inner join roles r on p.rol_id =r.rol_id 
            inner join roles_usuario ru on r.rol_id = ru.rol_id 
            inner join usuario u on ru.per_codigo = u.per_codigo
            where u.per_login = '".$_SESSION['login']."' and u.per_codigo = '".$_SESSION['per_codigo']."'
            and tar_activo = '1' and gru_activo ='1' and ru.activo ='1' 
            order by g.gru_orden, g.gru_nombre";   
  
  $database->setQuery( $sql );
  $rows = $database->loadObjectList();
  
  $code = "[";
  if( is_array( $rows ) ){
    for( $i =0, $n = count($rows); $i < $n; $i++ ){
      $v = $rows[$i];
      $code .= "{\n\t";
      $code .= "text: '<span class=\"optsmenu\">".utf8_encode($v->gru_nombre)."</span>',\n";      
      $code .= "expanded: true, \n";
      if( $v->gru_icono !="" ) $code .= "iconCls: '".$v->gru_icono."', \n";      
      $code .= "children: [ \n";
        $sql="select distinct t.tarea_id, t.tar_nombre, t.tar_descripcion, t.tar_icono, t.tar_orden, t.tar_url 
			from tarea t 
			inner join grupo g on t.grupo_id = g.grupo_id 
			inner join Rol_Tarea p on t.tarea_id = p.tarea_id 
			inner join roles r on p.rol_id = r.rol_id
			inner join roles_usuario ru on r.rol_id = ru.rol_id 
			inner join usuario u on ru.per_codigo = u.per_codigo 
                        where u.per_login = '".$_SESSION['login']."' and u.per_codigo = '".$_SESSION['per_codigo']."' and ru.activo ='1' 
			and g.grupo_id ='".$v->grupo_id."' and tar_activo ='1' and gru_activo ='1' 
			order by t.tar_orden";
       
        //echo $sql;
        $database->setQuery($sql);
        $row = $database->loadObjectList();
        
        if( is_array( $row ) ){
          for( $j = 0, $m = count($row); $j < $m; $j++ ){
            $tar = $row[$j];
            $code .= "{\n";
            $code .= "text:'<span class=\"optsmenu\">".utf8_decode($tar->tar_nombre)."</span>',\n";
            $code .= "id:'".$tar->tar_url."',\n";
            $code .= "expanded: false, \n";              
            if( $tar->tar_icono !="" ) $code .= "iconCls: '".$tar->tar_icono."', \n";
            $code .= "leaf: true \n ";             
            $code .= "}\n";
            if( $j < ($m-1) ) $code .= ",\n";
          }
        }
      $code .= "]\n";
      $code .= "}\n";
      if( $i < ($n-1) ) $code .= ",\n";
    }
  }
  echo $code."]\n";
  
?>