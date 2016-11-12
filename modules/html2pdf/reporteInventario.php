<?php

ob_start();
include(dirname(__FILE__) . '/reporteInventariohtml.php');
$content = ob_get_clean();

// convert in PDF
require_once(dirname(__FILE__) . '/html2pdf.class.php');
try {
    $html2pdf = new HTML2PDF('P', 'A4', 'fr', true, 'UTF-8', 0);
    $html2pdf->pdf->SetDisplayMode('fullpage');
    $html2pdf->setDefaultFont('Arial');
    $html2pdf->writeHTML($content, isset($_GET['vuehtml']));
    $html2pdf->Output('ReporteItemsAmbientes.pdf');
} catch (HTML2PDF_exception $e) {
    echo $e;
    exit;
}
?>