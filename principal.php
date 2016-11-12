<?php 

session_name('dx/dy');
session_start();

if(!isset($_SESSION["login"]))
{
    header("Location:index.php");
    exit();
}

error_reporting(5);

if (!file_exists("config/config.php")) {
    header("Location: logout.php");
    exit();
}

require_once( "config/config.php" );
require_once( $_CONF["includes"] . "functions.php" );

$conexion = mysqli_connect($_DB_host,$_DB_user,$_DB_pass,$_DB_name);

$module = _GetParam($_REQUEST, "module", "");

if ($module == "logout") {    
    require "logout.php";
    exit();
}

?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html class=" ext-strict"><head>
        
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Bienvenido</title>
        <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />        
        <script src="js/prototype.js" type="text/javascript"></script>    
        <!--script  src="js/jscript.js" type="text/javascript"></script-->
        <!--script  src="js/jquery.js" type="text/javascript"></script--> 
        <script type="text/javascript" src="ext/adapter/ext/ext-base.js"></script>
        <script type="text/javascript" src="ext/ext-all.js"></script>    
        <script type="text/javascript" src="ext/src/locale/ext-lang-es.js"></script>
        <script src="ext/ux/ext.util.md5.js" type="text/javascript"></script> 
        
        <link rel="stylesheet" type="text/css" href="resources/css/calendar.css" />
    <script type="text/javascript" src="src/Ext.calendar.js"></script>
    <script type="text/javascript" src="src/templates/DayHeaderTemplate.js"></script>
    <script type="text/javascript" src="src/templates/DayBodyTemplate.js"></script>
    <script type="text/javascript" src="src/templates/DayViewTemplate.js"></script>
    <script type="text/javascript" src="src/templates/BoxLayoutTemplate.js"></script>
    <script type="text/javascript" src="src/templates/MonthViewTemplate.js"></script>
    <script type="text/javascript" src="src/dd/CalendarScrollManager.js"></script>
    <script type="text/javascript" src="src/dd/StatusProxy.js"></script>
    <script type="text/javascript" src="src/dd/CalendarDD.js"></script>
    <script type="text/javascript" src="src/dd/DayViewDD.js"></script>
    <script type="text/javascript" src="src/EventRecord.js"></script>
    <script type="text/javascript" src="src/views/MonthDayDetailView.js"></script>
    <script type="text/javascript" src="src/widgets/CalendarPicker.js"></script>
    <script type="text/javascript" src="src/WeekEventRenderer.js"></script>
    <script type="text/javascript" src="src/views/CalendarView.js"></script>
    <script type="text/javascript" src="src/views/MonthView.js"></script>
    <script type="text/javascript" src="src/views/DayHeaderView.js"></script>
    <script type="text/javascript" src="src/views/DayBodyView.js"></script>
    <script type="text/javascript" src="src/views/DayView.js"></script>
    <script type="text/javascript" src="src/views/WeekView.js"></script>
    <script type="text/javascript" src="src/widgets/DateRangeField.js"></script>
    <script type="text/javascript" src="src/widgets/ReminderField.js"></script>
    <script type="text/javascript" src="src/EventEditForm.js"></script>
    <script type="text/javascript" src="src/EventEditWindow.js"></script>
    <script type="text/javascript" src="src/CalendarPanel.js"></script>	
       
    <link rel="stylesheet" type="text/css" href="resources/css/examples.css" />
    
    <script src="ext/ux/fileuploadfield/FileUploadField.js" type="text/javascript"></script> 
        <link rel="stylesheet" type="text/css" href="ext/ux/fileuploadfield/css/fileuploadfield.css">
    
    <script src="ext/ux/Searchfield.js" type="text/javascript"></script>
            <script src="ext/ux/Spinner.js" type="text/javascript"></script>
            <script src="ext/ux/SpinnerField.js" type="text/javascript"></script>

<!--        <script src="ext/shared/code-display.js" type="text/javascript"></script> -->
            <script src="ext/ux/Ext-ButtonField.js" type="text/javascript"></script>
            <script type="text/javascript" src="js/jquery.min.js"></script>
<!--            <script type="text/javascript" src="js/jquery-horario.js"></script>-->
            <script type="text/javascript" src="js/highcharts.js"></script>
            <script src="ext/ux/CheckColumn.js" type="text/javascript"></script>
            <script src="ext/ux/ColumnHeaderGroup.js" type="text/javascript"></script>
            <script  src="js/principal.js" type="text/javascript"></script>

            <script src="ext/ux/GroupSummary.js" type="text/javascript"></script>
            <script src="ext/ux/RowEditor.js" type="text/javascript"></script>
            <script src="ext/data/GroupingStore.js" type="text/javascript"></script>
            <script src="ext/ux/DataView-more.js" type="text/javascript"></script>
            <script src="ext/data/ArrayReader.js" type="text/javascript"></script>
            <link rel="stylesheet" type="text/css" href="css/RowEditor.css"></link>                                 

            <script src="ext/grid/PivotGrid.js" type="text/javascript"></script>
            <script src="ext/ux/CenterLayout.js" type="text/javascript"></script>
            <link rel="stylesheet" type="text/css" href="css/CenterLayout.css" />


            <link rel="stylesheet" type="text/css" href="ext/ux/treegrid/treegrid.css" rel="stylesheet" />
            <script type="text/javascript" src="ext/ux/treegrid/TreeGridSorter.js"></script>
            <script type="text/javascript" src="ext/ux/treegrid/TreeGridColumnResizer.js"></script>
            <script type="text/javascript" src="ext/ux/treegrid/TreeGridNodeUI.js"></script>
            <script type="text/javascript" src="ext/ux/treegrid/TreeGridLoader.js"></script>
            <script type="text/javascript" src="ext/ux/treegrid/TreeGridColumns.js"></script>
            <script type="text/javascript" src="ext/ux/treegrid/TreeGrid.js"></script>
            <script type="text/javascript" src="ext/ux/App.js"></script>
            
            <link rel="stylesheet" type="text/css" href="ext/resources/css/ext-all.css" />
            <link rel="stylesheet" type="text/css" href="css/styles.css" />
            <link rel="stylesheet" type="text/css" href="css/organizer.css" />
            <link rel="stylesheet" type="text/css" href="css/Spinner.css" />
            <link rel="stylesheet" type="text/css" href="css/icons.css" />           
            
            <style type="text/css">
                .fondoFila{ background-color: #10841b}
            </style>
            
            <script type="text/javascript">
                function LoadMyJs(scriptName) {
                    var docHeadObj = document.getElementsByTagName("head")[0];
                    var dynamicScript = document.createElement("script");
                    dynamicScript.type = "text/javascript";
                    dynamicScript.src = scriptName;
                    docHeadObj.appendChild(dynamicScript);
                }
                function gettime(){
                    var dt = new Date();
                    dt = dt.format('h:i:s');
                    return dt;
                }          
                
                var myGlobalHandlers = {
                    onCreate: function() {
                        Element.show('loading');
                    },
                    onComplete: function() {
                        if (Ajax.activeRequestCount == 0) {
                            Element.hide('loading');
                        }
                    }
                };
                Ajax.Responders.register(myGlobalHandlers);
                var task = Ext.TaskMgr.start({
                    interval: 1000
                            , run: function() {
                        if (document.getElementById('FechaReloj'))
                            document.getElementById('FechaReloj').innerHTML = gettime();
                    }
                });
            </script>
            
            
            
            
            
            <script type="text/javascript">
                Ext.onReady(function() {
                    Ext.state.Manager.setProvider(new Ext.state.CookieProvider());
                    var Tree = Ext.tree;
                    var tree = new Tree.TreePanel({
                        region: 'west',
                        rootVisible: false,
                        bodyStyle: 'padding: 5px;',
                        id: 'west-panel',
                        title: 'Menu Principal',
                        split: true,
                        width: 220,
                        minSize: 175,
                        maxSize: 400,
                        collapsible: true,
                        autoScroll: true,
                        animate: true,
                        enableDD: false,
                        containerScroll: true,
                        loader: new Tree.TreeLoader({
                            dataUrl: 'config/menu.php'
                        }),
                        root: new Tree.AsyncTreeNode({
                            text: 'Menu Principal',
                            draggable: false,
                            expanded: true,
                            id: '0'
                        })
                    });

                    idArea = '<?php echo $_SESSION["idArea"]; ?>';

                    // then
                    //alert(idArea);

                    tree.addListener('click', function(node, event) {
                        if (node.isLeaf())
                        {
                            cadena = node.attributes.id;
                            valores = cadena.split("&");
                            m = valores[0].split("=");
                            module = m[1];
                            m = valores[1].split("=");
                            option = m[1];
                            //if(option=="recepciona" && idArea==239)
                            //LoadMyJs('js/modules/' + module+ '/recepcionm.js');
                            //else
                            LoadMyJs('js/modules/' + module + '/' + option + '.js');

                        }
                    });

                    tree.addListener('dblclick', function(node, event) {
                        if (node.isLeaf())
                        {
                            cadena = node.attributes.id;
                            valores = cadena.split("&");
                            m = valores[0].split("=");
                            module = m[1];
                            m = valores[1].split("=");
                            option = m[1];
                            ///if(option=="recepciona" && idArea==239)
                            //LoadMyJs('js/modules/' + module+ '/recepcionm.js');
                            //else
                            LoadMyJs('js/modules/' + module + '/' + option + '.js');

                        }
                    });

                    tabs = new Ext.TabPanel({
                        border: false,
                        activeTab: 0,
                        id: 'TabPrincipal',
                        enableTabScroll: true
                    });

                    var viewport = new Ext.Viewport({
                        layout: 'border',
                        items: [
                            new Ext.BoxComponent({
                                region: 'north',
                                el: 'north',
                                cls: 'x-border-panel-principal',
                                height: 40
                            }),
                            new Ext.BoxComponent({
                                region: 'south',
                                cls: 'x-border-panel-principal',
                                el: 'south',
                                height: 32
                            }),
                            tree,
                            {
                                id: 'tabscenter',
                                region: 'center',
                                items: [tabs]
                            }
                        ]
                    });
                    //para ocultar el panel de la derecha
                    alturapanel = Ext.getCmp("tabscenter").getHeight();

                });</script>
            
    </head> 
    <body >
        
        <div id="overlay" style="display: none;background-color: #10841b"></div>
        <div id="overlayImage" style="display: none;background-color: #10841b"></div>
        <!--div id="loading"><img src="images/loader.gif" alt="" style="border:0px; height:16px; width:16px;"/> procesando, por favor espere...</div-->  
        <div id="north"  style="height:80px;" >    
            <div id="logo2">                
                <img src="images/escudo_moche.png" style="height:30px; width:30px;" />
                <div class="texto" >&nbsp;&nbsp;PLATAFORMA WEB - RENTAS</div>
            </div>
            <div id="headout4"  >
                <div><a href="principal.php?module=logout"><img src="images/icons/logout.png" alt="" /> Salir </a>
                <!--<div><a href="index.php"><img src="images/icons/logout.png" alt="" /> Salir </a>-->
                    <a href="principal.php"><img src="images/icons/home.png" alt="" /> Inicio </a>
                </div>
<!--                                    <div><a href="principal.php?module=logout"><img src="images/icons/logout.png" alt="" /> Salir </a></div>
                                    <div><a href="principal.php"><img src="images/icons/home.png" alt="" /> Inicio </a></div>-->
            </div>
        </div>
        
        
        <div id="south"  >
            <div id="footer"  >
                <img src="images/icons/user.png" style="height:16px; width:16px;" alt="" /> Usuario: <?php echo ucwords(strtolower(utf8_decode($_SESSION['per_apellidos']) . ", " . utf8_decode($_SESSION['per_nombres']))); ?>
            </div>
            <div id="headout2" >
                <div id="FechaReloj"  ></div>
            </div>	
            <div id="headout4"  >
                <img src="images/icons/date.png" alt="" height="13"/> <?php echo date("d M Y") . " ,"; ?>  <img src='images/icons/clock.png' alt='' height="13"/>
            </div>

        </div>
        
        
</body>
</html>

