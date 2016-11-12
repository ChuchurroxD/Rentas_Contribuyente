<?php
session_name('dx/dy');
session_start();

//session_unregister("_id_");
//session_unregister("login");
//session_unregister("per_codigo");
//session_unregister("per_nombres");
//session_unregister("per_paterno");
//session_unregister("per_materno");
//session_unregister("_session");
//session_unregister("_longtime");
//session_unregister("are_descripcion");
//
//if (session_is_registered("_id_")) {
session_destroy();
//}
//if (session_is_registered("login")) {
//    session_destroy();
//}
//if (session_is_registered("per_codigo")) {
//    session_destroy();
//}
//if (session_is_registered("per_nombres")) {
//    session_destroy();
//}
//if (session_is_registered("per_paterno")) {
//    session_destroy();
//}
//if (session_is_registered("per_materno")) {
//    session_destroy();
//}
//if (session_is_registered("_session")) {
//    session_destroy();
//}
//if (session_is_registered("_logintime")) {
//    session_destroy();
//}
//
//if (session_is_registered("are_descripcion")) {
//    session_destroy();
//}

echo "<script>window.location.href='index.php';</script>\n";
?>