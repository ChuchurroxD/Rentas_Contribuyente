function send(task){
	document.form1.accion.value = task ;
	document.form1.submit();
}

function validarn(e) {
    tecla = (document.all) ? e.keyCode : e.which;
    if (tecla==8) return true; //Tecla de retroceso (para poder borrar)
    // dejar la línea de patron que se necesite y borrar el resto
    //patron =/[A-Za-z]/; // Solo acepta letras
    patron = /\d/; // Solo acepta números
    //patron = /\w/; // Acepta números y letras
    //patron = /\D/; // No acepta números
    //
    te = String.fromCharCode(tecla);
    return patron.test(te); 
}  

function validarc(c) {
    tecla = (document.all) ? c.keyCode : c.which;
    if (tecla==8) return true; //Tecla de retroceso (para poder borrar)
    // dejar la línea de patron que se necesite y borrar el resto
    //patron =/[A-Za-z]/; // Solo acepta letras
    //patron = /\d/; // Solo acepta números
    patron = /\w/; // Acepta números y letras
    //patron = /\D/; // No acepta números
    //
    te = String.fromCharCode(tecla);
    return patron.test(te); 
}  

function report(_accion){ 
	winprops = "width=700,height=440,scrollbars=yes,toolbar=0,status=0,menubar=0,resizable";
  	
  	window.open("","wmain", winprops);
  	
	var f = document.adminForm;
	f.accion.value = _accion;
	f.action ="report.main.php";
	f.target = "wmain";
	f.submit();
	return true;
}

var m="a.m.";
function mueveReloj(){ 
    momentoActual = new Date();
    hora = momentoActual.getHours();
    minuto = momentoActual.getMinutes();
    segundo = momentoActual.getSeconds(); 

    if(hora==12) { m="p.m."; } 
	if(hora==13) { hora="0"+1; m="p.m."; } 
	if(hora==14) { hora="0"+2; m="p.m."; } 
	if(hora==15) { hora="0"+3; m="p.m."; } 
	if(hora==16) { hora="0"+4; m="p.m."; } 
	if(hora==17) { hora="0"+5; m="p.m."; } 
	if(hora==18) { hora="0"+6; m="p.m."; } 
	if(hora==19) { hora="0"+7; m="p.m."; } 
	if(hora==20) { hora="0"+8; m="p.m"; } 
	if(hora==21) { hora="0"+9; m="p.m."; } 
	if(hora==22) { hora=10; m="p.m."; } 
	if(hora==23) { hora=11; m="p.m."; } 
	if((hora==0)||(hora==24)) { hora=12; m="a.m."; } 
	
	str_segundo = new String (segundo) 
    if (str_segundo.length == 1) 
       segundo = "0" + segundo;

    str_minuto = new String (minuto) 
    if (str_minuto.length == 1) 
       minuto = "0" + minuto;

    str_hora = new String (hora) 
    if (str_hora.length == 1) 
       hora = "0" + hora;

    horaImprimible = hora + ":" + minuto + ":" + segundo + " " + m 
	;

   // document.form_reloj.reloj.value = horaImprimible 

    setTimeout("mueveReloj()",1000) 
} 


//FUNCION PARA VALIDAR LA FECHA

function esDigito(sChr){
	var sCod = sChr.charCodeAt(0);
	return ((sCod > 47) && (sCod < 58));
}

function valSep(oTxt){
	var bOk = false;
	bOk = bOk || ((oTxt.value.charAt(2) == "-") && (oTxt.value.charAt(5) == "-"));
	bOk = bOk || ((oTxt.value.charAt(2) == "/") && (oTxt.value.charAt(5) == "/"));
	return bOk;
}

function finMes(oTxt){
	var nMes = parseInt(oTxt.value.substr(3, 2), 10);
	var nRes = 0;
	switch (nMes){
		case 1: nRes = 31; break;
		case 2: nRes = 29; break;
		case 3: nRes = 31; break;
		case 4: nRes = 30; break;
		case 5: nRes = 31; break;
		case 6: nRes = 30; break;
		case 7: nRes = 31; break;
		case 8: nRes = 31; break;
		case 9: nRes = 30; break;
		case 10: nRes = 31; break;
		case 11: nRes = 30; break;
		case 12: nRes = 31; break;
	}
return nRes;
}

function valDia(oTxt){
	var bOk = false;
	var nDia = parseInt(oTxt.value.substr(0, 2), 10);
	bOk = bOk || ((nDia >= 1) && (nDia <= finMes(oTxt)));
	return bOk;
}

function valMes(oTxt){
	var bOk = false;
	var nMes = parseInt(oTxt.value.substr(3, 2), 10);
	bOk = bOk || ((nMes >= 1) && (nMes <= 12));
	return bOk;
}

function valAno(oTxt){
	var bOk = true;
	var nAno = oTxt.value.substr(6);
	bOk = bOk && ((nAno.length == 2) || (nAno.length == 4));
	if (bOk){
		for (var i = 0; i < nAno.length; i++){
		bOk = bOk && esDigito(nAno.charAt(i));
		}
	}
	return bOk;
}

function valFecha(oTxt){
	var bOk = true;
	if (oTxt.value != ""){
		bOk = bOk && (valAno(oTxt));
		bOk = bOk && (valMes(oTxt));
		bOk = bOk && (valDia(oTxt));
		bOk = bOk && (valSep(oTxt));
		if (!bOk){
			alert("Fecha inválida");
			oTxt.value = "";
			oTxt.focus();
		}
	}
}

//FIN DE FUNCION PARA VALIDAR FECHA

//FUNCION PARA SELECCIONAR Y PINTAR FILAS DE PLANILLAS
window.onload = function(){
	var table = document.getElementById('myTable');
	if(window.attachEvent){ // if msie/win 4+
		table.attachEvent('onclick', function(){
			cell(event.srcElement);
			}
	);
	} else if(document.layers){ // if netscape
	// netscape event model;
	} else if(document.getElementById && addEventListener){ // if DOM compliant;
		table.addEventListener('click', function(e){
		cell(e.target);
	}, false);
	} else table.onclick = function(){alert('this browser doesnt support an advanced event model')};
	// event model level 0;
	}

function cell(node){
	if(node.tagName.toLowerCase() != 'td' || node.parentNode.parentNode.tagName.toLowerCase() != 'tbody')return 0;
	// aqui va la porcion de codigo que necesites para manejar cuando se haga click en una celda;
	// a continuacion un ejemplo;
	alert(node.innerHTML); // esta linea puede eliminarse;
} 
//FIN DE FUNCION PARA PINTAR FILAS DE PLANILLAS
//FUNCIONES PARA MOSTRAR DETALLE EN BUSQUEDAS CON PASAR MOUSE
var horizontal_offset="9px"
var vertical_offset="0"
var ie=document.all
var ns6=document.getElementById&&!document.all

function getposOffset(what, offsettype){
	var totaloffset=(offsettype=="left")? what.offsetLeft : what.offsetTop;
	var parentEl=what.offsetParent;
	while (parentEl!=null){
		totaloffset=(offsettype=="left")? totaloffset+parentEl.offsetLeft : totaloffset+parentEl.offsetTop;
		parentEl=parentEl.offsetParent;
	}
	return totaloffset;
}

function iecompattest(){
	return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body
}

function clearbrowseredge(obj, whichedge){
	var edgeoffset=(whichedge=="rightedge")? parseInt(horizontal_offset)*-1 : parseInt(vertical_offset)*-1
	if (whichedge=="rightedge"){
		var windowedge=ie && !window.opera? iecompattest().scrollLeft+iecompattest().clientWidth-30 : window.pageXOffset+window.innerWidth-40
		dropmenuobj.contentmeasure=dropmenuobj.offsetWidth
		if (windowedge-dropmenuobj.x < dropmenuobj.contentmeasure)
			edgeoffset=dropmenuobj.contentmeasure+obj.offsetWidth+parseInt(horizontal_offset)
		}else{
			var windowedge=ie && !window.opera? iecompattest().scrollTop+iecompattest().clientHeight-15 : window.pageYOffset+window.innerHeight-18
	dropmenuobj.contentmeasure=dropmenuobj.offsetHeight
		if (windowedge-dropmenuobj.y < dropmenuobj.contentmeasure)
			edgeoffset=dropmenuobj.contentmeasure-obj.offsetHeight
		}
	return edgeoffset
}

function showhint(menucontents, obj, e, tipwidth){
	if ((ie||ns6) && document.getElementById("hintbox")){
		dropmenuobj=document.getElementById("hintbox")
		dropmenuobj.innerHTML=menucontents
		dropmenuobj.style.left=dropmenuobj.style.top=-500
		if (tipwidth!=""){
			dropmenuobj.widthobj=dropmenuobj.style
			dropmenuobj.widthobj.width=tipwidth
		}
		dropmenuobj.x=getposOffset(obj, "left")
		dropmenuobj.y=getposOffset(obj, "top")
		dropmenuobj.style.left=dropmenuobj.x-clearbrowseredge(obj, "rightedge")+obj.offsetWidth+"px"
		dropmenuobj.style.top=dropmenuobj.y-clearbrowseredge(obj, "bottomedge")+"px"
		dropmenuobj.style.visibility="visible"
		obj.onmouseout=hidetip
	}
}

function hidetip(e){
	dropmenuobj.style.visibility="hidden"
	dropmenuobj.style.left="-500px"
}

function createhintbox(){
	var divblock=document.createElement("div")
	divblock.setAttribute("id", "hintbox")
	document.body.appendChild(divblock)
}

if (window.addEventListener)
	window.addEventListener("load", createhintbox, false)
else if (window.attachEvent)
	window.attachEvent("onload", createhintbox)
else if (document.getElementById)
	window.onload=createhintbox
//---------------------------------------------------------------------------------------------------------------------