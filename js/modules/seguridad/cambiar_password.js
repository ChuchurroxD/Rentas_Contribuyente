Ext.onReady(function() {
    var tarea = 'Modificar Datos de Acceso';
    Ext.QuickTips.init();
    function getUsuario() {                  
        var acceso_usuario = new Ext.form.TextField({
            name: 'acceso_usuario',
            fieldLabel: 'USUARIO',
            width: 350,
            emptyText: 'Ingrese nuevo usuario',
            disabled: false
        });                       
        var acceso_password = new Ext.form.TextField({
            fieldLabel: 'NUEVA CONTRASEÑA',
            name: 'acceso_password',
            inputType: 'password',
            width: 350,
            disabled: false,
            allowBlank: false
        });
        var acceso_repeat_password = new Ext.form.TextField({
            fieldLabel: 'REPETIR CONTRASEÑA',
            name: 'acceso_repeat_password',
            inputType: 'password',
            width: 350,
            disabled: false,
            allowBlank: false
        });        
        var btnlimpiar = new Ext.Button({
            text: '<b style="color:black; font-size:12px">Reset</b>',
            iconCls: 'clear',
            handler: function () {
                limpiar();
            }
        });        
        var btngrabar = new Ext.Button({
            text: '<b style="color:black; font-size:12px">Grabar</b>',
            iconCls: 'save',
            handler: function () {
                usuario_update();
            }
        });
        
        function limpiar() {
            formpersona.getForm().reset();        
        }
        
        // AQUI ME KEDE SEGUIR YA DA SUEÑOOOO Xd
        function usuario_update(){
            if (formpersona.getForm().isValid()) {
                Ext.Ajax.request({
                    waitMsg: 'Guardando...',
                    url: 'modules/seguridad/cambiar_password.php',
                    params: {
                        task: "update",                        
                        usuario: acceso_usuario.getValue(),
                        password: acceso_password.getValue(),
                        repeat_password: acceso_repeat_password.getValue()                        
                    },
                    success: function(response) {                        
                        var result = eval(response.responseText);
                        switch (result) {
                            case 1: //ok
                                Ext.MessageBox.alert('Confirmaci&oacute;n', 'Se modifico con &eacute;xito, ingrese sesión con los datos actualizados.');                                
                                formpersona.getForm().reset(); 
                                //var redirect = 'principal.php?module=logout';
                                header("Location: principal.php?module=logout");
                                //location = redirect;
                                break;
                            case 2:
                                Ext.MessageBox.alert('Error', 'Parametro ya Existe!');
                                //persona_new_Window.close();
                                break;
                            default:
                                Ext.MessageBox.alert('Error', 'Error al modificar datos de acceso.');
                        }
                    },
                    failure: function(response) {
                        var result = response.responseText;
                        Ext.MessageBox.alert('Error', 'Error al guardar el registro.');
                    }
                });
            }
        }
  
        var formpersona = new Ext.form.FormPanel({
            //labelAlign: 'top',
            frame: true,
            layout: 'form',
            autoHeight: true,
            bodyStyle: 'padding: 20px 10px 20px 250px;',
            style: 'margin-bottom:50px;',
            defaults: {
                style: 'margin-bottom:5px;'
            },
            
            items: [{
                    xtype: 'fieldset',
                    title: "Nuevos Datos de Acceso",                    
                    width: 550,
                    items: [{
                            columnWidth: .90,
                            labelWidth: 150,
                            bodyStyle: 'padding:0px;margin:0px;',
                            style: 'margin:0px;padding:0px;',
                            border: false,
                            items: [{
                                    xtype: 'panel',
                                    layout: 'form',
                                    bodyStyle: 'padding:0px;margin:0px;',
                                    style: 'margin:0px;padding:0px;',
                                    //height: 23,
                                    items: [acceso_usuario,acceso_password,
                                acceso_repeat_password]
                                },{
                                    layout: 'column',
                                    labelWidth: 150,
                                    bodyStyle: 'padding:10px 10px 0px 185px;margin:0px;',
                                    style: 'margin:0px;padding:0px;', items: [{
                                            layout: 'form',
                                            columnWidth: .25,
                                            bodyStyle: 'padding:0px;margin:0px;', 
                                            style: 'margin:0px;padding:0px;',
                                            border: false,
                                            items: [btngrabar]
                                        },
                                        {
                                            layout: 'form',
                                            columnWidth: .25,
                                            labelWidth: 100,
                                            bodyStyle: 'padding:0px;margin:0px;',
                                            style: 'margin:0px;padding:0px;',
                                            border: false,
                                            items: [btnlimpiar]
                                        }]
                                }]
                        }]

                }]
        });
        return [formpersona];
    }


    tabs = Ext.getCmp('TabPrincipal');
    function addTab() {
        var tab = tabs.findById(tarea);
        if (!tab) {
            tab = new Ext.Panel({
                id: tarea,
                autoHeight: true,
                layout: 'form',
                closable: true,
                title: LetraCapital(tarea),
                items: [new Ext.Panel({
                        autoScroll: true,
                        height: alturapanel - 30,
                        items: [getUsuario()]
                    })]
            });
            tabs.add(tab);
        }
        tabs.activate(tab);
    }
    addTab();
});