/* 
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */


Ext.onReady(function() {
    Ext.QuickTips.init();

    var proxy = new Ext.data.HttpProxy({
        url: 'modules/mantenedores/Trabajador.php',
        method: 'post'
    });
   
    var formLogin = new Ext.form.FormPanel({
        method: 'POST',
        border: false,
        padding: '4px 4px 4px 4px',
        labelAlign: 'top',
        items: [{
                xtype: 'fieldset',
                paddings: '10 10 10 10',
                title: 'Datos de Usuario',
                layout: 'column',
                items: [new Ext.Panel({
                        border: false,
                        layout: 'form',
                        items: [                            
                            {
                                xtype: 'textfield',
                                fieldLabel: 'Usuario <span style="color:red;font-weight:bold">*</span>',
                                name: 'txtusuario',
                                id: 'txtusuario',
                                allowBlank: false,
                                width: 250
                            }, {
                                xtype: 'textfield',
                                inputType: 'password',
                                fieldLabel: 'Contraseña <span style="color:red;font-weight:bold">*</span>',
                                name: 'txtcontraseña',
                                id: 'txtcontraseña',
                                allowBlank: false,
                                width: 250
                            }]
                    }), new Ext.Panel({
                        padding: "0px 0px 0px 20px",                        
                        layout: 'fit',
                        border: false,
                        html: '<img style="width:128px; height: 113px;" src="images/user1.png">'
                    })]
            }],
        buttons: [{
                text: 'Entrar',
                iconCls: 'aceptar',
                handler: function()
                {
                    Ext.Ajax.request({
                        waitTitle: 'Ingresando',
                        waitMsg: 'Autentificando...',
                        url: 'login.php',
                        params: {
                            //hid: '19f2cb167caf8e499bb373c6a8cefc2c',
                            username: Ext.getCmp('txtusuario').getValue(),
                            password: Ext.getCmp('txtcontraseña').getValue()                            
                        },
                        success: function(response) {
                            var data = Ext.util.JSON.decode(response.responseText);
                            if (data.success == true) {
                                if (data.msj == "1")
                                {
                                    var expire = new Date(new Date().getTime() + 365 * 24 * 60 * 60 * 1000);                                    
                                    Ext.util.Cookies.set('username', Ext.getCmp('txtusuario').getValue(), expire);
                                    var redirect = 'principal.php';
                                    window.location = redirect;
                                }
                                else if (data.msj == "2")
                                {
                                    Ext.Msg.alert('Autenticaci\u00F3n Fallida!', 'Su cuenta ha expirado ');
                                }                                
                            }
                            else
                                Ext.Msg.alert('Autenticaci\u00F3n Fallida!', 'Su Usuario / Contrase\u00F1a es Incorrecta ');
                        }
                    });
                }
            }]
    });

    //Panel para el formulario
    var panelLogin = new Ext.Panel({
        labelAlign: 'top',
        border: false,
        items: formLogin
    });

    var windowPopup = new Ext.Window({
        title: 'Iniciar Sesión',
        closeAction: 'hide',
        layout: 'fit',
        closable: false,
        width: 450,
        height: 260,
        items: panelLogin
    });
    windowPopup.show();

    Ext.getCmp('txtusuario').focus();
    Ext.getCmp('txtusuario').setValue(Ext.util.Cookies.get('username'));

    Ext.getBody().on("keypress", function(evt) {
        if ((evt.getKey() == evt.ENTER))
        {
//       alert( Ext.util.MD5(Ext.getCmp('txtcontraseña').getValue()));
//         alert( Ext.util.MD5('101920315'));
            Ext.Ajax.request({
                waitTitle: 'Ingresando',
                waitMsg: 'Autentificando...',
                url: 'login.php',
                params: {
                    //hid: '19f2cb167caf8e499bb373c6a8cefc2c',
                    username: Ext.getCmp('txtusuario').getValue(),
                    password: Ext.getCmp('txtcontraseña').getValue()                  
                },
                success: function(response) {
                    var data = Ext.util.JSON.decode(response.responseText);
                    if (data.success == true) {
                        if (data.msj == "1")
                        {
                            var expire = new Date(new Date().getTime() + 365 * 24 * 60 * 60 * 1000);                            
                            Ext.util.Cookies.set('username', Ext.getCmp('txtusuario').getValue(), expire);
                            var redirect = 'principal.php';
                            window.location = redirect;
                        }
                        else if (data.msj == "2")
                        {
                            Ext.Msg.alert('Autenticaci\u00F3n Fallida!', 'Su cuenta ha expirado ');
                        }
                    }
                    else
                        Ext.Msg.alert('Autenticaci\u00F3n Fallida!', 'Su Usuario / Contrase\u00F1a es Incorrecta ');
                }
            });
        }
    });
});