<!DOCTYPE html>
<html>
<head>
    <title></title>
    <link rel="stylesheet" type="text/css" href="verst.css">
    <meta http-equiv="Content-Type" content="text/html; charset=utf8">
</head>
<body>
<div class="parent" >
    <div class="lsidebar">
    </div>
    <div class="rsidebar">
    </div>
    <h1 class="zag1"> Инфомация о пользователях </h1>
    <div class="text1"> Вы на странице просмотра информации о ранее выбранном пользователе. Выберите дату, за которую хотите просмотреть информацию о пользователе.
        Дата начала отслеживания:
</body>
</html>
<?php
require_once 'connection.php';
$id = $_REQUEST['id'];
echo '<a class="text1" href="http://318128-momomuze.tmweb.ru/web/info.php?id='.$id.'&day=19&month=05&year=2020"> 19.05.2020</a>. </div>';
?>
<form>
    <select class="text1" name="day">
        <option selected value="Число месяца">Число месяца</option>
        <option value="01">01</option>
        <option value="02">02</option>
        <option value="03">03</option>
        <option value="04">04</option>
        <option value="05">05</option>
        <option value="06">06</option>
        <option value="07">07</option>
        <option value="08">08</option>
        <option value="09">09</option>
        <option value="10">10</option>
        <option value="11">11</option>
        <option value="12">12</option>
        <option value="13">13</option>
        <option value="14">14</option>
        <option value="15">15</option>
        <option value="16">16</option>
        <option value="17">17</option>
        <option value="18">18</option>
        <option value="19">19</option>
        <option value="20">20</option>
        <option value="21">21</option>
        <option value="22">22</option>
        <option value="23">23</option>
        <option value="24">24</option>
        <option value="25">25</option>
        <option value="26">26</option>
        <option value="27">27</option>
        <option value="28">28</option>
        <option value="29">29</option>
        <option value="30">30</option>
        <option value="31">31</option>
    </select>
    <select class="text1" name="month">
        <option selected value="Месяц">Месяц</option>
        <option value="01">Январь</option>
        <option value="02">Февраль</option>
        <option value="03">Март</option>
        <option value="04">Апрель</option>
        <option value="05">Май</option>
        <option value="06">Июнь</option>
        <option value="07">Июль</option>
        <option value="08">Август</option>
        <option value="09">Сентябрь</option>
        <option value="10">Октябрь</option>
        <option value="11">Ноябрь</option>
        <option value="12">Декабрь</option>
    </select>
    <select  class="text1" name="year">
        <option selected value="Год">Год</option>
        <option value="2020">2020</option>
    </select>
    <?php
    echo "<select class='text1' name='id'>";
    echo "<option value='$id'>$id</option>";
    echo "</select>";
    ?>
    <input class="button" type="submit" value="Посмотреть">
</form>
<form>
    <div class="text1">
        Для возврата к просмотру списка отслеживаемых пользователей нажмите конпку <input class="button" type="button" value="Вернуться" onClick='location.href="http://318128-momomuze.tmweb.ru/web/obraz.php"'>
    </div>
</form>
<?php
$link = mysqli_connect($host, $user, $password, $database) // подключаемся к серверу
or die("Ошибка cвязи с базой данных" . mysqli_error($link));
$link->set_charset("utf8");
if (isset($_REQUEST['id']) && isset($_REQUEST['year']) && isset($_REQUEST['month']) && isset($_REQUEST['day'])) {
    $query = "SELECT * FROM `".$id."` WHERE date = '".$_REQUEST['year'].$_REQUEST['month'].$_REQUEST['day']."'";
    echo "<br>";
    $result = mysqli_query($link, $query) or die("Некоректные данные");

    if($result) {
        $t= 0;
        ?>

        <table class="table">
            <tr class="text1">
                <td>
                    Имя пользователя
                </td>
                <td>
                    Статус (онлайн/оффлайн)
                </td>
                <td>
                    Время
                </td>
                <td>
                    Дата
                </td>
            </tr>
        <?php

        $rows = mysqli_num_rows($result);
        for ($i = 0; $i < $rows; ++$i) {
            $row = mysqli_fetch_row($result) or die("Ошибка" . mysqli_error($link));
            ?>
            <tr class="textT">
                <td>
            <?php
            echo $row[0];
            ?>
                </td>
                <td>
            <?php
            if ($row[1]> 0)
                {
                    echo "онлайн";
                    $t = ++$t;
                }
            else echo "оффлайн";
            ?>
                </td>
                <td>
            <?php
            echo $row[3];
            ?>
                </td>
                <td>
            <?php
            echo $row[2];
            ?>
                </td>
            </tr>
            <?php
//            echo "<tr>";
//            echo "<td>";
//            echo $row[0];
//            echo "</td>";
//            echo "<td>";
//            if ($row[1]> 0) echo "онлайн";
//            else echo "оффлайн";
//            echo "</td>";
//            echo "<td>";
//            echo $row[3];
//            echo "</td>";
//            echo "<td>";
//            echo $row[2];
//            echo "</td>";
//            echo "</tr>";
        }
        ?>
        </table>

        <?php
        $h = intdiv($t,60);
        $m = $t%60;
        echo "<div class='text1'> Пользователь $row[0] пробыл(а) в сети Вконтакте $h часов и $m минут </div>";

    }
    ?>
    </form>
    <form class="text1">
        Для возврата к просмотру списка отслеживаемых пользователей нажмите конпку <input class="button" type="button" value="Вернуться" onClick='location.href="http://318128-momomuze.tmweb.ru/web/obraz.php"'>
    </form>
    <?php
}
mysqli_close($link);
echo "</div>";
?>

