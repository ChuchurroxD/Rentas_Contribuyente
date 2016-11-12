<?php
function tr2($d1, $d2 ){
	echo "<tr>
		<td>$d1</td>
		<td>$d2</td>
	</tr>";
}

function tr3($d1, $d2, $d3="" ){
	echo "<tr>
		<td>$d1</td>
		<td>$d2</td>
		<td>$d3</td>
	</tr>";
}

function tr4($d1, $d2="", $d3="", $d4="" ){
	echo "<tr>
			<td>$d1</td>
			<td>$d2</td>
			<td>$d3</td>
			<td>$d4</td>
		</tr>";
}

function tr5($d1, $d2="", $d3="", $d4="", $d5="" ){
	echo "<tr>
			<td>$d1</td>
			<td>$d2</td>
			<td>$d3</td>
			<td>$d4</td>
			<td>$d5</td>
		</tr>";
}

function tr6($d1, $d2="", $d3="", $d4="", $d5="", $d6="" ){
	echo "<tr>
			<td>$d1</td>
			<td>$d2</td>
			<td>$d3</td>
			<td>$d4</td>
			<td>$d5</td>
			<td>$d6</td>
		</tr>";
}

function tr8($d1, $d2="", $d3="", $d4="", $d5="", $d6="", $d7="", $d8="" ){
	echo "<tr>
			<td>$d1</td>
			<td>$d2</td>
			<td>$d3</td>
			<td>$d4</td>
			<td>$d5</td>
			<td>$d6</td>
			<td>$d7</td>
			<td>$d8</td>
		</tr>";
}

function tr10($d1, $d2="", $d3="", $d4="", $d5="", $d6="", $d7="", $d8="", $d9="", $d10="" ){
	echo "<tr>
			<td>$d1</td>
			<td>$d2</td>
			<td>$d3</td>
			<td>$d4</td>
			<td>$d5</td>
			<td>$d6</td>
			<td>$d7</td>
			<td>$d8</td>
			<td>$d9</td>
			<td>$d10</td>
		</tr>";
}

function input_text($nombre, $valor="", $tamaño="", $espace="", $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"$nombre\" class=\"inputbox\" size=\"$tamaño\" maxlength=\"$espace\" onChange=\"javascript:this.value=this.value.toUpperCase();\">";
}

function input_text2($nombre, $valor="", $tamaño="", $espace="", $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"$nombre\" class=\"inputbox\" size=\"$tamaño\" onkeypress=\"return validarn(event)\" maxlength=\"$espace\">";
}

function input_textarea($nombre, $valor="", $columnas="", $filas=""){
	return "<textarea name=\"$nombre\" cols=\"$columnas\" rows=\"$filas\" wrap=\"virtual\" class=\"inputbox\"onChange=\"javascript:this.value=this.value.toUpperCase();\" >$valor</textarea> ";
}

function input_hidden($nombre, $valor=""){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"hidden\" value=\"$valor\" $ro name=\"$nombre\">";
}
function input_horatxt($nombre, $valor="", $tamaño="", $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" name=\"$nombre\" size=\"$tamaño\" onFocus=\"window.document.form_reloj.reloj.blur()\">";
}
function check_text($nombre, $val , $checked = false){
	$ck = ($checked) ? " checked " : "";
	return "<input type=\"checkbox\" class =\"inputbox\" name=\"$nombre\" border=\"0\" value=\"$val\"$ck/>";
}

function frm_password($nombre, $valor){
	return "<input type=\"password\" class =\"inputbox\" value=\"$valor\" name=\"$nombre\" style=\"background-color:#ffffdf; border: 1px solid #000000\"/>";
}

function frm_select($nombre, $arr, $default='', $extra_tag=''){
	$tmp = "<select name='$nombre', class='inputbox', $extra_tag >";
	$items = count($arr);
	if($items != count($arr)) return $tmp."<option>ERR! en el array de valores</select>";
	$tmp .= "<option value='0'> Seleccionar </option>";

	for($i = 0; $i < $items ; $i++ ){
		$sel = ' selected';
		$val = $arr[$i]->valor;
		if(is_array($default)){
			if(!in_array( strtolower($val), array_lower($default) )) $sel='';
		}else{
			if(!eregi($val,$default)) $sel='';
		}
		$tmp .= "<option value='$val', $sel>".$arr[$i]->texto."</option>";
	}	
	return $tmp.'</select>';
}

function fecha($nombre, $valor, $tamaño, $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" size=\"$tamaño\" name=\"$nombre\" value=\"$valor\" $ro  class=\"inputbox\" onblur=\"valFecha(this)\">";
}

function calendar($nombre, $valor, $size, $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"firstinput\" class=\"inputbox\" size=\"$size\"><small><a href=\"javascript:showCal('Calendar1')\"><img src=\"images/calendar.jpg\" border=\"0\"></a></small>";
}

function calendar2($nombre, $valor, $size, $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"secondinput\" class=\"inputbox\" size=\"$size\"><small><a href=\"javascript:showCal('Calendar2')\"><img src=\"images/calendar.jpg\" border=\"0\"></a></small>";
}

function calendar3($nombre, $valor, $size, $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"tercero\" class=\"inputbox\" size=\"$size\"><small><a href=\"javascript:showCal('Calendar3')\"><img src=\"images/calendar.jpg\" border=\"0\"></a></small>";
}

function calendar4($nombre, $valor, $size, $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"cuarto\" class=\"inputbox\" size=\"$size\"><small><a href=\"javascript:showCal('Calendar4')\"><img src=\"images/calendar.jpg\" border=\"0\"></a></small>";
}

function calendar5($nombre, $valor, $size, $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"quinto\" class=\"inputbox\" size=\"$size\"><small><a href=\"javascript:showCal('Calendar5')\"><img src=\"images/calendar.jpg\" border=\"0\"></a></small>";
}

function calendar6($nombre, $valor, $size, $readonly = false){
	$ro = ($readonly)?" READONLY ":"";
	return "<input type=\"text\" value=\"$valor\" $ro name=\"sexto\" class=\"inputbox\" size=\"$size\"><small><a href=\"javascript:showCal('Calendar6')\"><img src=\"images/calendar.jpg\" border=\"0\"></a></small>";
}

function hora_titulo($titulo){
?>
	<TABLE width="100%" border="0" style="color: #3140C1;">
		<TR><th><h2><?php echo $titulo?></h2></th></TR>
	</TABLE>
<?php
}
?>