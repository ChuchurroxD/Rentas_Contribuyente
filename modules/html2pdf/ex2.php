<?php

require('rotacion.php');

class PDF extends PDF_Rotate {

    function Header() {
        //Put the watermark
        $this->SetFont('Arial', 'B', 45);
        $this->SetTextColor(200, 190, 200);
        $this->RotatedText(20, 250, 'M u n i c i p a l i d a d  d e  V i r u', 45);
    }

    function RotatedText($x, $y, $txt, $angle) {
        //Text rotated around its origin
        $this->Rotate($angle, $x, $y);
        $this->Text($x, $y, $txt);
        $this->Rotate(0);
    }

}

$pdf = new PDF();
$pdf->AddPage();
$pdf->SetFont('Arial', '', 12);
$pdf->Output();

?>



