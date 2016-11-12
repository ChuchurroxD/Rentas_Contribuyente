<?php
     ob_start();
?>

<!--<page>
    <h1>JavaScript 3</h1><br>
    <br>
 </page>-->
<?php

    $content = ob_get_clean();
    // PDF script to execute
    $script = "
<script type='text/javascript'>
document.write('Hola')
</script>
";
//        $script1 = "
//var rep = app.response('parte de javascript ojo');
//app.alert('Vous vous appelez '+rep);
//";

    // convert to PDF
    require_once(dirname(__FILE__).'/html2pdf.class.php');
    try
    {
        $html2pdf = new HTML2PDF('P', 'A4', 'fr');
        $html2pdf->pdf->IncludeJS($script);
        //$html2pdf->pdf->IncludeJS($script);
        $html2pdf->writeHTML($content, isset($_GET['vuehtml']));
        $html2pdf->Output('js3.pdf');
    }
    catch(HTML2PDF_exception $e) {
        echo $e;
        exit;
    }
