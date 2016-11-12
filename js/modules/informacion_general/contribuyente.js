Ext.onReady(function() {
    var Personas = 'Datos de Contribuyente';
    var c_escalafon_fechatculval = new Date();
var aa;
    Ext.QuickTips.init();
    //funciones de conversion
    function status(data, cell, record, rowIndex, columnIndex, store) {
        switch (data) {
            case true:
                cell.css = "stars1";
                return;
            case false:
                cell.css = "stars2";
                return;
        }
    }
    function iconos(val) {
        if (val == 1) {
            return '<center><img src="images/icons/dentro.png"/></center>';
        } else if (val == 0) {
            return '<center><img src="images/icons/delete.png"/></center>';
        }
        return val;
    }
    /*------------------------------------------------------------*/
    /* Listar los tributos en un grid
     /*------------------------------------------------------------*/
    Ext.apply(Ext.form.VTypes, {
        uppercase: function(val, field) {
            var texto = val;
            texto = Ext.util.Format.uppercase(texto);
            field.setRawValue(texto);
            return true;
        }});

    // configuracion del proxy para cargar los datos
    var Personas_proxy = new Ext.data.HttpProxy({
        url: 'modules/mantenedores/persona.php',
        method: 'post'
    });           
    
    
   var Personas_dstore = new Ext.data.JsonStore({
        url: 'modules/mantenedores/persona.php',
        proxy: Personas_proxy,
        fields: ['codigo', 'paterno', 'materno', 'nombres','dni', 'carnet', 'celular', 'email', 'direccion', 'estado'],
        totalProperty: 'total',
        root: 'datos'
    });
    
    var Personas_grid = new Ext.grid.GridPanel({
        store: Personas_dstore,
        columns: [
            {id: 'codigo', header: "C&oacute;digo", width: 65, sortable: true, dataIndex: 'codigo'},
            {id: 'paterno', header: "Apellido Paterno", width: 110, sortable: true, dataIndex: 'paterno'},
            {id: 'materno', header: "Apellido Materno", width: 110, sortable: true, dataIndex: 'materno'},
            {id: 'nombres', header: "Nombres", width: 130, sortable: true, dataIndex: 'nombres'},
            {id: 'dni', header: "Dni", width: 85, sortable: true, dataIndex: 'dni'},
            {id: 'carnet', header: "Carnet Extranjeria", width: 105, sortable: true, dataIndex: 'carnet'},                  
            {id: 'celular', header: "Celular", width: 90, sortable: true, dataIndex: 'celular'},
            {id: 'email', header: "Email", width: 175, sortable: true, dataIndex: 'email'},
            {id: 'direccion', header: "Dirección", width: 175, sortable: true, dataIndex: 'direccion'},
            {id: 'estado', header: "Estado", width: 65, sortable: true, dataIndex: 'estado', renderer: iconos}
        ],
        stripeRows: true,
        width: 1115,
        height: 350,
        title: 'Administraci&oacute;n de Personas',
        tbar: [
            {
                text: 'Agregar',
                tooltip: 'Agregar nuevo registro',
                iconCls: 'add',
                handler: Agregar_Personas
            }, '-',
            {
                text: 'Editar',
                tooltip: 'Modificar un registro',
                iconCls: 'edit-grid',
                handler: Editar_Personas
            }, '-',
            new Ext.app.SearchField({
                store: Personas_dstore,
                params: {task: 'load', start: 0, limit: 10},
                width: 120
            })

        ],
        bbar: new Ext.PagingToolbar({// para mostrar la paginacion
            pageSize: 10,
            store: Personas_dstore,
            displayMsg: 'Mostrando {0} - {1} de {2}',
            emptyMsg: 'No hay datos para mostrar',
            displayInfo: true
        }),
        selModel: new Ext.grid.RowSelectionModel({singleSelect: true}) //modo de seleccion 
    });
    
    Personas_dstore.load({params: {task: 'load', start: 0, limit: 10}});
    Personas_grid.getSelectionModel().on('selectionchange', function(sm) {
        Personas_grid.removeBtn.setDisabled(sm.getCount() < 1 || sm.getSelected().get('estado') == 0);
    });
    
    function Agregar_Personas() {
        var persona_new_Paterno = new Ext.form.TextField({
            fieldLabel: 'ApellidoPaterno',
            id: 'persona_new_Paterno',
            anchor: '90%',
            allowBlank: false,
            vtype: 'uppercase',
            maskRe: '[A-Z]'
        });
        var persona_new_Materno = new Ext.form.TextField({
            fieldLabel: 'ApellidoMaterno',
            id: 'persona_new_Materno',
            anchor: '100%',
            allowBlank: false,
            vtype: 'uppercase',
            maskRe: '[A-Z]'
        });
        var persona_new_Nombres = new Ext.form.TextField({
            fieldLabel: 'Nombres',
            id: 'persona_new_Nombres',
            anchor: '90%',
            allowBlank: false,
            vtype: 'uppercase',
            maskRe: '[A-Z]'
        });
        var persona_new_Sexo = new Ext.form.ComboBox({
                fieldLabel: '<span>Sexo</span><span style="color:red;font-weight:bold">*</span>',
                store: new Ext.data.SimpleStore({
                    fields: ['sexo', 'descripcion'],
                    data: [
                        ['1 ', 'Masculino'],
                        ['0 ', 'Femenino']                        
                    ]
                }),
                mode: 'local',
                displayField: 'descripcion',
                valueField: 'sexo',
                width: 200,                
                allowBlank:false,
                editable:false,
                triggerAction: 'all',
                emptyText: 'Seleccione'
            });
        var persona_new_Documento_Dni = new Ext.form.NumberField({
            fieldLabel: 'Dni',
            id: 'persona_new_Documento_Dni',
            anchor: '90%',
            allowBlank: false,
            vtype: 'uppercase',
            maxLength: '11',
            minLength: '8'
        });     
        var persona_new_Documento_Extranjeria = new Ext.form.NumberField({
            fieldLabel: 'C. Extranjeria',
            id: 'persona_new_Documento_Extranjeria',
            anchor: '100%',
            allowBlank: false,
            vtype: 'uppercase',
            maxLength: '11',
            minLength: '8'
        });
        var persona_new_Direccion = new Ext.form.TextField({
            fieldLabel: 'Direcci&oacute;n',
            id: 'persona_new_Direccion',
            anchor: '100%',
            allowBlank: false,
            vtype: 'uppercase'
        });        
        var persona_new_FechaNacimiento = new Ext.form.DateField({
            fieldLabel: 'Fecha Nac',
            width: 160,
            allowBlank: false,
            emptyText: 'dd/mm/aa',
            maxValue: new Date(c_escalafon_fechatculval.getFullYear() - 18, c_escalafon_fechatculval.getMonth(), c_escalafon_fechatculval.getDate()),
            minValue: new Date(c_escalafon_fechatculval.getFullYear() - 100, c_escalafon_fechatculval.getMonth(), c_escalafon_fechatculval.getDate())
        });
        var persona_new_email = new Ext.form.TextField({
            id: 'persona_new_email',
            fieldLabel: 'Email',
            maxLength: 50,
            anchor: '100%',
            vtype: 'email'
        });
        var persona_new_telefono = new Ext.form.NumberField({
            id: 'persona_new_telefono',
            fieldLabel: 'Celular',
            anchor: '90%',
            vtype: 'uppercase',
            maxLength: '9',
            minLength: '9'
        });
        var persona_new_Form = new Ext.FormPanel({
            bodyStyle: 'padding:7px;',
            width: 730,
            height: 300,
            items: [{
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [{
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_Paterno
                        }, {
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_Materno
                        }]},
                {
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [{
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_Nombres
                        },{
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_Sexo
                        }]},
                
                {
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [{
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_Documento_Dni
                        },{
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_Documento_Extranjeria
                        }]},
                
                {
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [{
                                width: 340,
                                bodyStyle: 'padding:0px;',
                                layout: 'form',
                                border: false,
                                items: persona_new_FechaNacimiento
                            },{
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_email
                        }]},
                {
                        layout: 'column',
                        border: false,
                        height: 25,
                        items: [{
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_new_telefono
                        },{
                                width: 350,
                                bodyStyle: 'padding:0px;',
                                layout: 'form',
                                border: false,
                                items: persona_new_Direccion
                            }]}],
            buttons: [
                {
                    text: 'Grabar',
                    handler: function() {
                        persona_add();
                    }
                }, {
                    text: 'Cancelar',
                    handler: function() {
                        persona_new_Form.getForm().reset();
                        persona_new_Window.close();
                    }
                }
            ]
        });
        // ventana donde mostramos el formulario
        persona_new_Window = new Ext.Window({
            id: 'persona_new_Window',
            title: 'Agregar Persona',
            closable: false,
            width: 750,
            height: 300,
            plain: true,
            layout: 'fit',
            modal: true,
            items: persona_new_Form
        });

        //persona_dstoreTipoDocumento.load();
        persona_new_Window.show();
        //funcion para guardar el nuevo tipo licencia
        function persona_add(){
            if (persona_new_Form.getForm().isValid()) {
                Ext.Ajax.request({
                    waitMsg: 'Guardando...',
                    url: 'modules/mantenedores/persona.php',
                    params: {
                        task: "add",                        
                        paterno: persona_new_Paterno.getValue(),
                        materno: persona_new_Materno.getValue(),
                        nombres: persona_new_Nombres.getValue(),
                        sexo: persona_new_Sexo.getValue(),
                        dni: persona_new_Documento_Dni.getValue(),
                        extranjeria: persona_new_Documento_Extranjeria.getValue(),
                        fechaNacimiento: persona_new_FechaNacimiento.getValue(),
                        email: persona_new_email.getValue(),
                        telefono: persona_new_telefono.getValue(),
                        direccion: persona_new_Direccion.getValue()
                    },
                    success: function(response) {
                        if (!verificarResponseJson(response.responseText, "")) {
                            return true;
                        }
                        var result = eval(response.responseText);
                        switch (result) {
                            case 1: //ok
                                Ext.MessageBox.alert('Confirmaci&oacute;n', 'El registro se realizó con &eacute;xito.');
                                persona_new_Window.close();
                                Personas_dstore.reload();
                                break;
                            case 2:
                                Ext.MessageBox.alert('Error', 'Parametro ya Existe!');
                                persona_new_Window.close();
                                break;
                            default:
                                Ext.MessageBox.alert('Error', 'Error al guardar el registro.');
                        }
                    },
                    failure: function(response) {
                        var result = response.responseText;
                        Ext.MessageBox.alert('Error', 'Error al guardar el registro.');
                    }
                });
            }
        }
    }
    
    function Editar_Personas() {
        var persona_edit_Codigo = new Ext.form.Hidden({
            fieldLabel: 'Codigo',
            name: 'codigo',
            anchor: '90%',
            disabled: true            
        });
        var persona_edit_Paterno = new Ext.form.TextField({
            fieldLabel: 'ApellidoPaterno',
            //id: 'persona_new_Paterno',
            name: 'paterno',
            anchor: '90%',
            allowBlank: false,
            vtype: 'uppercase',
            maskRe: '[A-Z]'
        });
        var persona_edit_Materno = new Ext.form.TextField({
            fieldLabel: 'ApellidoMaterno',
            //id: 'persona_new_Materno',
            name: 'materno',
            anchor: '100%',
            allowBlank: false,
            vtype: 'uppercase',
            maskRe: '[A-Z]'
        });
        var persona_edit_Nombres = new Ext.form.TextField({
            fieldLabel: 'Nombres',
            //id: 'persona_new_Nombres',
            name: 'nombres',
            anchor: '90%',
            allowBlank: false,
            vtype: 'uppercase',
            maskRe: '[A-Z]'
        });                
        var persona_edit_Sexo = new Ext.form.ComboBox({
                fieldLabel: 'Sexo',
                store: new Ext.data.SimpleStore({
                    fields: ['sexo', 'descripcion'],
                    data: [
                        ['1', 'Masculino'],
                        ['0', 'Femenino']                        
                    ]
                }),
                mode: 'local',
                displayField: 'descripcion',
                valueField: 'sexo',
                name: 'sexo',
                width: 200,                
                allowBlank:true,
                editable:false,
                triggerAction: 'all',
                emptyText: 'Seleccione'
            });
        var persona_edit_Documento_Dni = new Ext.form.NumberField({
            fieldLabel: 'Dni',
            //id: 'persona_new_Documento_Dni',
            name: 'dni',
            anchor: '90%',
            allowBlank: false,
            vtype: 'uppercase',
            maxLength: '11',
            minLength: '8'
        });     
        var persona_edit_Documento_Extranjeria = new Ext.form.NumberField({
            fieldLabel: 'C. Extranjeria',
            //id: 'persona_new_Documento_Extranjeria',
            name: 'carnet',
            anchor: '100%',
            allowBlank: false,
            vtype: 'uppercase',
            maxLength: '11',
            minLength: '8'
        });
        var persona_edit_Direccion = new Ext.form.TextField({
            fieldLabel: 'Direcci&oacute;n',
            //id: 'persona_new_Direccion',
            name: 'direccion',
            anchor: '100%',
            allowBlank: false,
            vtype: 'uppercase'
        });        
        var persona_edit_FechaNacimiento = new Ext.form.DateField({
            fieldLabel: 'Fecha Nac',
            name: 'nacimiento',
            width: 160,
            allowBlank: false,
            emptyText: 'dd/mm/aa',
            maxValue: new Date(c_escalafon_fechatculval.getFullYear() - 18, c_escalafon_fechatculval.getMonth(), c_escalafon_fechatculval.getDate()),
            minValue: new Date(c_escalafon_fechatculval.getFullYear() - 100, c_escalafon_fechatculval.getMonth(), c_escalafon_fechatculval.getDate())
        });
        var persona_edit_email = new Ext.form.TextField({
            //id: 'persona_new_email',
            name: 'email',
            fieldLabel: 'Email',
            maxLength: 50,
            anchor: '100%',
            vtype: 'email'
        });
        var persona_edit_telefono = new Ext.form.NumberField({
            //id: 'persona_new_telefono',
            name: 'celular',
            fieldLabel: 'Celular',
            anchor: '90%',
            vtype: 'uppercase',
            maxLength: '9',
            minLength: '9'
        });
        var persona_edit_Estado = new Ext.form.Checkbox({
            fieldLabel: 'Estado',
            name: 'estadoPersona'            
            });        
        var Personas_edit_Form = new Ext.FormPanel({
            url: 'modules/mantenedores/persona.php?task=update',
            method: 'post',
            bodyStyle: 'padding:7px;',
            width: 730,
            height: 300,
            reader: new Ext.data.JsonReader({
                root: 'datos',
                totalProperty: 'total',
                fields: ['codigo', 'paterno', 'materno', 'nombres', 'sexo', 'dni', 'carnet', 'direccion', 'nacimiento', 'email', 'celular', 'estadoPersona']
            }),           
            items: [{
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [persona_edit_Codigo,
                        {
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_Paterno
                        }, {
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_Materno
                        }]},
                {
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [{
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_Nombres
                        },{
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_Sexo
                        }]},
                
                {
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [{
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_Documento_Dni
                        },{
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_Documento_Extranjeria
                        }]},
                
                {
                    layout: 'column',
                    border: false,
                    height: 25,
                    items: [{
                                width: 340,
                                bodyStyle: 'padding:0px;',
                                layout: 'form',
                                border: false,
                                items: persona_edit_FechaNacimiento
                            },{
                            width: 350,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_email
                        }]},
                {
                        layout: 'column',
                        border: false,
                        height: 25,
                        items: [{
                            width: 340,
                            bodyStyle: 'padding:0px;',
                            layout: 'form',
                            border: false,
                            items: persona_edit_telefono
                        },{
                                width: 350,
                                bodyStyle: 'padding:0px;',
                                layout: 'form',
                                border: false,
                                items: persona_edit_Direccion
                            }]},persona_edit_Estado],
            buttons: [
                {
                    text: 'Guardar',
                    handler: updateRequisitos
                },
                {
                    text: 'Cancelar',
                    handler: function() {
                        Personas_edit_Form.getForm().reset();
                        Personas_edit_Window.close();
                    }
                }
            ]
        });
                               
    // ventana en la que mostramos el formulario de edicion
        var Personas_edit_Window = new Ext.Window({
            title: 'Modicaci&oacute;n de datos',            
            closable: false,
            width: 750,
            height: 340,
            plain: true,
            layout: 'fit',
            modal: true,
            items: Personas_edit_Form
        });

        //persona_dstoreTipoDocumento.load();            
        
        function updateRequisitos(){
            
            if (Personas_edit_Form.getForm().isValid()) {
                Ext.Ajax.request({
                    waitMsg: 'Guardando...',
                    url: 'modules/mantenedores/persona.php',
                    params: {
                        task: "update",  
                        idPersona: persona_edit_Codigo.getValue(),
                        paterno: persona_edit_Paterno.getValue(),
                        materno: persona_edit_Materno.getValue(),
                        nombres: persona_edit_Nombres.getValue(),
                        sexo: persona_edit_Sexo.getValue(),
                        dni: persona_edit_Documento_Dni.getValue(),
                        extranjeria: persona_edit_Documento_Extranjeria.getValue(),
                        fechaNacimiento: persona_edit_FechaNacimiento.getValue(),
                        email: persona_edit_email.getValue(),
                        telefono: persona_edit_telefono.getValue(),
                        direccion: persona_edit_Direccion.getValue(),
                        estado: persona_edit_Estado.getValue()
                    },
                    success: function(response) {
                        if (!verificarResponseJson(response.responseText, "")) {
                            return true;
                        }
                        var result = eval(response.responseText);
                        switch (result) {
                            case 1: //ok
                                Ext.MessageBox.alert('Confirmaci&oacute;n', 'El registro se realizo con &eacute;xito');
                                Personas_edit_Window.close();
                                Personas_dstore.reload();
                                break;
                            case 2: //ok
                                Ext.MessageBox.alert('Error', 'Par&aacute;metro Repetido');
                                Personas_edit_Window.close();
                                break;
                            case 0:
                            default:
                                Ext.MessageBox.alert('Error', 'Error al guardar el registro.');
                        }
                    },
                    failure: function(response) {
                        var result = response.responseText;
                        Ext.MessageBox.alert('Error', 'Error al guardar el registro.');
                    }
                });
            }
        }
        var m = Personas_grid.getSelectionModel().getSelections();
        if (m.length <= 0) {
            Ext.MessageBox.alert('Mensaje', 'Seleccione un registro');
        } else {
            Personas_edit_Form.getForm().load({
                url: 'modules/mantenedores/persona.php?task=show&idPersona=' + m[0].get('codigo'),
                waitMsg: 'Cargando......'
            });
            Personas_edit_Window.show();
        }
    }


    Ext.IframeWindow = Ext.extend(Ext.Window, {
        onRender: function() {
            this.bodyCfg = {
                tag: 'iframe',
                src: this.src,
                cls: this.bodyCls,
                style: {
                    border: '0px none'
                }
            };
            Ext.IframeWindow.superclass.onRender.apply(this, arguments);
        }
    });


    tabs = Ext.getCmp('TabPrincipal');
    function addTab() {
        var tab = tabs.findById(Personas);
        if (!tab) {
            tab = new Ext.Panel({
                id: Personas,
                autoHeight: true,
                layout: 'form',
                closable: true,
                title: LetraCapital(Personas),
                items: [new Ext.Panel({
                        autoScroll: true,
                        height: alturapanel - 30,
                        items: [Personas_grid]
                    })]
            });
            tabs.add(tab);
        }
        tabs.activate(tab);
    }
    addTab();
});

