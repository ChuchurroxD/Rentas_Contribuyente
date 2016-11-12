<?php 
$buscar=$_GET["buscar"];
if($buscar!="Buscar")
{

?>

<div class="pagination">


<?php 

if($mi==1 || $mi=="") {?>
<span class="disabled">&#9668;Ant</span>
<?php
}
else
{


?>

<a href="index2.php?modulo=<?php echo $modul; ?>&amp;pag=<?php echo $mi-1; ?>" class="next">&#9668;Ant</a>
<?php

}

if($mi!=1 && $mi!="")
{echo "<a href='index2.php?modulo=$modul&amp;pag=1'>1</a>";

}
if($mi==1 || $mi=="")
{
?>
<!--
Mostar el 1 o no Para Paginar
<span class="current">1</span>-->

<?php
}

if($paginas>=10)
{


if($mi<10)
{
for($i=2; $i<=7; $i++)
{

if($i!=$mi)
{?>
<a href="index2.php?modulo=<?php echo $modul; ?>&amp;pag=<?php echo $i?>"><?php echo $i; ?></a>
<?php 
}
else
{
?>
<span class="current"><?php echo $mi?></span>

<?php
}
}
echo "<a href='index2.php?modulo=$modul&amp;pag=10'>...</a>";
}

if($mi>=10)
{

$yu=$mi/5;
$yu=$yu-1;

$j=5*$yu;
$mk=$mi-1;
$mk1=$mi-2;
$mh=$mi+1;
$mh1=$mi+2;
$k=5*($yu+1);
$l=5*($yu+2);

echo "<a href='index2.php?modulo=$modul&amp;pag=$j'>...</a>";
echo "<a href='index2.php?modulo=$modul&amp;pag=$mk1'>$mk1</a>";
echo "<a href='index2.php?modulo=$modul&amp;pag=$mk'>$mk</a>";

echo "<span class='current'>$mi</span>";

if($l<$paginas)
{
echo "<a href='index2.php?modulo=$modul&amp;pag=$mh'>$mh</a>";
echo "<a href='index2.php?modulo=$modul&amp;pag=$mh1'>$mh1</a>";
echo "<a href='index2.php?modulo=$modul&amp;pag=$l'>...</a>";
}
else
{
 $mt=$l-$paginas;
 
for($ih=$mi+1; $ih<=$paginas; $ih++)
{

echo "<a href='index2.php?modulo=$modul&amp;pag=$ih'>$ih</a>";
}

}

}

}

else
{
for($i=2; $i<=$paginas; $i++)
{


if($i!=$mi)
{?>
<a href="index2.php?modulo=<?php echo $modul; ?>&amp;pag=<?php echo $i?>"><?php echo $i; ?></a>
<?php 
}
else
{
?>
<span class="current"><?php echo $mi?></span>

<?php
}
}

}



if($mi!=$paginas && $paginas>1)
{
?>
<a href="index2.php?modulo=<?php echo $modul; ?>&amp;pag=<?php echo $mi+1; ?>" class="next">Sig&#9658;</a>
<a href="index2.php?modulo=<?php echo $modul; ?>&amp;pag=<?php echo $paginas; ?>" class="next">||&#9658;</a>
<?php
}
else
{
?>
<span class="disabled">Sig&#9658;</span>
<?php
}
?>


</div>

	
	
	<?php
}
?>