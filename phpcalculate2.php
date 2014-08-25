<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>
<?php
$number2=$_POST["number2"];
$number3=$_POST["number3"];
$number4=$_POST["number4"];
$number5=$_POST["number5"];
$number6=$_POST["number6"];
$number7=$_POST["number7"];
$number8=$_POST["number8"];
$number9=$_POST["number9"];
$number10=$_POST["number10"];
 $number11=$_POST["number11"];
 echo "<table bordercolor='#993300'>
 <tr bordercolor='#0066CC'><td>SN</td><td>Numbers you provided</td></tr>
 <tr bordercolor='#0066CC'><td>1)</td><td>$number2</td></tr>
 <tr bordercolor='#0066CC'><td>2)</td><td>$number3</td></tr>
 <tr bordercolor='#0066CC'><td>3)</td><td>$number4</td></tr>
 <tr bordercolor='#0066CC'><td>4)</td><td>$number5</td></tr>
 <tr bordercolor='#0066CC'><td>5)</td><td>$number6</td></tr>
 <tr bordercolor='#0066CC'><td>6)</td><td>$number7</td></tr>
 <tr bordercolor='#0066CC'><td>7)</td><td>$number8</td></tr>
 <tr bordercolor='#0066CC'><td>8)</td><td>$number9</td></tr>
 <tr bordercolor='#0066CC'><td>9)</td><td>$number10</td></tr>
 <tr bordercolor='#0066CC'><td>10)</td><td>$number11</td></tr>
 </table>
 ";
$arr = array($number2,$number3,$number4,$number5,$number6,$number7,$number8,$number9,$number10,$number11);
echo "<font color ='red'>Original Array</font><br>";
print_r(array_values($arr));
echo "<br><font color ='red'>Bubble sort</font><br>";
$sortedArr = bubbleSort($arr);
print_r(array_values($sortedArr));
 
function bubbleSort(array $arr) {
    $sorted = false;
    while (false === $sorted) {
        $sorted = true;
        for ($i = 0; $i < count($arr)-1; ++$i) {
            $current = $arr[$i];
            $next = $arr[$i+1];
            if ($next < $current) {
                $arr[$i] = $next;
                $arr[$i+1] = $current;
                $sorted = false;
            }
        }
    }
    return $arr;
}

echo "<br><font color ='red'>Insertion sort</font><br>";
$numbers = $arr;
$count = count($numbers);
 
for($i=1;$i<$count;$i++){
    $j=$i-1;
    $key = $numbers[$i];
    while($j>=0 && $numbers[$j] >  $key){
        $numbers[$j+1] = $numbers[$j];
        $numbers[$j]= $key;
        $j= $j-1;       
    }
}
print_r($numbers);

echo "<br><font color ='red'>Selection sort</font><br>";
$sortedArr = selectionSort($arr);
print_r($sortedArr);
 
function selectionSort(array $arr) {
    for ($i = 0; $i < count($arr); ++$i) {
        $min = null;
        $minKey = null;
        for($j = $i; $j < count($arr); ++$j) {
            if (null === $min || $arr[$j] < $min) {
                $minKey = $j;
                $min = $arr[$j];
            }
        }
        $arr[$minKey] = $arr[$i];
        $arr[$i] = $min;
    }
    return $arr;
}
echo "<br><font color ='red'>Quick sort</font><br>";
function quicksort($seq) {
    if(!count($seq)) return $seq;
    $pivot= $seq[0];
    $low = $high = array();
    $length = count($seq);
    for($i=1; $i < $length; $i++) {
        if($seq[$i] <= $pivot) {
            $low [] = $seq[$i];
        } else {
            $high[] = $seq[$i];
        }
    }
    return array_merge(quicksort($low), array($pivot), quicksort($high));
}

$myarr = $arr;
$final = quicksort($myarr);

print_r($final);
echo "<br><font color ='red'>Reversed array<br></font>";
$reversed = array_reverse($arr);
print_r($reversed);
echo "<br><font color ='red'>Maximum in the Array<br></font>";
echo max($arr);
echo "<br><font color ='red'>Minimum in the Array<br></font>";
echo min($arr); 

function average($arr)
{
   if (!is_array($arr)) return false;

   return array_sum($arr)/count($arr);
}
echo "<br><font color ='red'>Average of the Array<br></font>";
echo average($arr); 
?>
<body>
</body>
</html>