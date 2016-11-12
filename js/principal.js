var incremento = 15;
var empresa = 0;
var unidad = 0;

function LetraCapital(string)
{
    return string.charAt(0).toUpperCase() + string.slice(1);
}

function RangoHorario()
{
    Ext.Ajax.request({
        url: 'modules/mantenedores/horario.php',
        params: {
            task: "rango"
        },
        success: function(response) {
            var result = eval(response.responseText);
            incremento = result;
        },
        failure: function(response) {
            Ext.MessageBox.alert('Error', 'Error');
        }
    });
}

//    RangoHorario();

function Empresa() {
    //alert("oooo");
    Ext.Ajax.request({
        url: 'modules/mantenedores/horario.php',
        params: {
            task: "empresa"
        },
        success: function(response) {
            var result = eval(response.responseText);
            empresa = result;
        },
        failure: function(response) {
            Ext.MessageBox.alert('Error', 'Error');
        }
    });
}

//Empresa();
function UnidadNegocio() {
    Ext.Ajax.request({
        url: 'modules/mantenedores/horario.php',
        params: {
            task: "un"
        },
        success: function(response) {
            var result = eval(response.responseText);
            unidad = result;
            //alert("dsfdfd"+unidad);
        },
        failure: function(response) {
            Ext.MessageBox.alert('Error', 'Error');
        }
    });
}

//UnidadNegocio();

function DevolverIncremento()
{
    return incremento;
}

function DevolverEmpresa()
{
//        alert("e"+empresa);
    return empresa;
}

function DevolverUnidadNegocio()
{
//        alert("dsfdfd"+unidad);
    return unidad;

}