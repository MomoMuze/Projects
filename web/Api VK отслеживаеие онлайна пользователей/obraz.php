<!DOCTYPE html>
<html>
<head>
	<title></title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf8">
    <link rel="stylesheet" type="text/css" href="verst.css">
</head>
<body>
<div class="parent" >
    <div class="lsidebar">
    </div>
    <div class="rsidebar">
    </div>
    <h1 class="zag1"> Список отслеживаемых пользователей </h1>
    <form class="text1">
        Нажмите на кнопку, если хотите добавить нового пользователя в список отслеживаемых пользователей. <input class="button" type="button" value="Добавить" onClick='location.href="http://318128-momomuze.tmweb.ru/web/dobav.php"'>
        <br>
        Чтобы посмотреть статистику пользователя о его онлайне выберите его из списка.
    </form>
    <?php
    header('Content-Type: text/html; charset=utf8');
    require_once 'connection.php';
    date_default_timezone_set ('Etc/GMT-5');
    $y = date("y");
    $m = date("m");
    $d = date("d");

    $link = mysqli_connect($host, $user, $password, $database) // подключаемся к серверу
    or die("Ошибка cвязи с базой данных" . mysqli_error($link));
    $link->set_charset("utf8");

    $query ="SELECT * FROM `Polz`";
    $result = mysqli_query($link,$query) or die("Ошибка" . mysqli_error($link));
    if($result) {
        ?>
        <table class="table">
        <tr class="text1">
            <td>
                Номер пользователя
            </td>
            <td>
                Имя пользователя
            </td>
        </tr>
        <?php
        $n = 1;
        $rows = mysqli_num_rows($result);
        for ($i = 0; $i < $rows; ++$i) {
            $row = mysqli_fetch_row($result) or die("Ошибка" . mysqli_error($link));
            ?>
            <tr class="textT">
                <td>
                    <?php
                    echo $n;
                    ?>
                </td>
                <td>
            <?php
            echo '<a class="text1" href="http://318128-momomuze.tmweb.ru/web/info.php?id='.$row[2].'&day='.$d.'&month='.$m.'&year='.$y.'">'.$row[0].' '.$row[1].'</a>';
            ?>
                </td>
            </tr>
            <?php
            $n = ++$n;
        }
        ?>
        </table>
        <?php

    }
    mysqli_close($link);
    ?>
</div>
</body>
</html>
