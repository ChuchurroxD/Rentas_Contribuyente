// JavaScript Document
function closeDiv() {
document.getElementById('floatLayer').style.left = "-1000";
return false;
}

window.onerror = null;
var topMargin = 150;
var slideTime = 2500;
var ns6 = (!document.all && document.getElementById);
var ie4 = (document.all);
var ns4 = (document.layers);

function layerObject(id,left) {
if (ns6) {
this.obj = document.getElementById(id).style;
this.obj.left = left;
return this.obj;
}
else if(ie4) {
this.obj = document.all[id].style;
this.obj.left = left;
return this.obj;
}
else if(ns4) {
this.obj = document.layers[id];
this.obj.left = left;
return this.obj;
}
}

function layerSetup() {
floatLyr = new layerObject('floatLayer', pageWidth * .5);
window.setInterval("main()", 10)
}

function floatObject() {
if (ns4 || ns6) {
findHt = window.innerHeight;
} else if(ie4) {
findHt = document.body.clientHeight;
}
}

function main() {
if (ns4) {
this.currentY = document.layers["floatLayer"].top;
this.scrollTop = window.pageYOffset;
mainTrigger();
}
else if(ns6) {
this.currentY = parseInt(document.getElementById('floatLayer').style.top);
this.scrollTop = scrollY;
mainTrigger();
} else if(ie4) {
this.currentY = floatLayer.style.pixelTop;
this.scrollTop = document.body.scrollTop;
mainTrigger();
}
}

function mainTrigger() {
var newTargetY = this.scrollTop + this.topMargin;
if ( this.currentY != newTargetY ) {
if ( newTargetY != this.targetY ) {
this.targetY = newTargetY;
floatStart();
}
animator();
}
}

function floatStart() {
var now = new Date();
this.A = this.targetY - this.currentY;
this.B = Math.PI / ( 2 * this.slideTime );
this.C = now.getTime();
if (Math.abs(this.A) > this.findHt) {
this.D = this.A > 0 ? this.targetY - this.findHt : this.targetY + this.findHt;
this.A = this.A > 0 ? this.findHt : -this.findHt;
}
else {
this.D = this.currentY;
}
}

function animator() {
var now = new Date();
var newY = this.A * Math.sin( this.B * ( now.getTime() - this.C ) ) + this.D;
newY = Math.round(newY);
if (( this.A > 0 && newY > this.currentY ) || ( this.A < 0 && newY < this.currentY )) {
if ( ie4 )document.all.floatLayer.style.pixelTop = newY;
if ( ns4 )document.layers["floatLayer"].top = newY;
if ( ns6 )document.getElementById('floatLayer').style.top = newY + "px";
}
}

function start() {
if(ns6||ns4) {
pageWidth = innerWidth;
pageHeight = innerHeight;
layerSetup();
floatObject();
}
else if(ie4) {
pageWidth = document.body.clientWidth;
pageHeight = document.body.clientHeight;
layerSetup();
floatObject();
}
}

document.write('<DIV id=floatLayer style="LEFT: -1000px; WIDTH: 245px; POSITION: absolute; TOP: 3px; HEIGHT: 77px; BACKGROUND-COLOR: #cccccc">');
document.write('<table border="1" cellspacing="0" cellpadding="0" bordercolor="#FFFFFF">');
document.write('<tr><td border="1" align="right" bgcolor="#ffffff" colspan="4"><font size="1" face="Verdana" color="#000000">Close</font><A onclick="return closeDiv()" href="http://www.google.com" target="_blank"><FONT size="1" face="Verdana" color="#000000">[X]</FONT></A></td></tr>');
document.write('<tr><td border="1" align="center" bgcolor="#ffffff" colspan="4"><a href="noticia.php" target="_blank"><img src=flash9.gif border="0"></a></td></tr>');
//document.write('<tr><td border="1" align="center" bgcolor="#ffffff" colspan="4"><a href="http://www.google.com" target="_blank"><img src=flash9.gif alt="Click Aqui" border="0"></a></td></tr>');
document.write('</table></DIV>');

start(); 