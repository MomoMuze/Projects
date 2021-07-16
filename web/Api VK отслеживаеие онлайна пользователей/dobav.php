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
    <h1 class="zag1"> Добавление пользователей в список отслеживания </h1>
<?php
require_once 'connection.php';
require_once 'Parametrs.php';
$redirectURI = "http://318128-momomuze.tmweb.ru/web/dobav.php";
header('Content-Type: text/html; charset=utf8');
?>
    <form class="text1">
        Чтобы добавить пользователя для отслеживания введите ссылку на него
        <br>
        Ссылка: <input type="text" name="userid" placeholder="https://vk.com/momomuze   ">
        <input class="button" type="submit" value="Добавить">
        <br>
        Для возврата к просмотру информации о пользователях <input class="button" type="button" value="Вернуться" onClick='location.href="http://318128-momomuze.tmweb.ru/web/obraz.php"'>
    </form>
<?php



        $link = mysqli_connect($host, $user, $password, $database) // подключаемся к серверу
        or die("Ошибка cвязи с базой данных" . mysqli_error($link));
        $link->set_charset("utf8");
        if (isset($_REQUEST['userid']) && ($_REQUEST['userid'] !== ''))
                {
                    $id = explode('/id',$_REQUEST['userid'],2);
                    if (isset($id[1]))
                    {
                        $ids=$id[1];
                    } else
                    {
                        $id = explode('/',$_REQUEST['userid'],4);
                        $ids = $id[3];
                    }
                    $request_params = array(
                        'user_ids' => $ids,
                        'fields' => 'online',
                        'v' => '5.101',
                        'access_token' => $token
                    );
                    $get_params = http_build_query($request_params);
                    $reqStr = json_decode(file_get_contents('https://api.vk.com/method/users.get?'. $get_params));

                    $first_name = $reqStr -> response[0] -> first_name;
                    $last_name = $reqStr -> response[0] -> last_name;
                    $userid = $reqStr -> response[0] -> id;

                    $query ="CREATE TABLE `polzovateli`.`".$userid."`
                                (
                                    name VARCHAR(40) NOT NULL,
                                    status VARCHAR(10) NOT NULL,
                                    date DATE NOT NULL,
                                    time TIME NOT NULL
                                )";
                    $result = mysqli_query($link, $query) or die('<div class="text1"> Такой пользователь уже отслеживается. </div>');

                    $query ="INSERT INTO Polz(first_name,last_name,ID) VALUES('".$first_name."','".$last_name."','".$userid."')";
                    $result = mysqli_query($link, $query) or die('<div class="text1"> Такой пользователь уже отслеживается. </div>');
                    if($result) {
                        ?>
                        <div class="text1"> Данные добавлены. Пользователь начал отслеживаться.</div>
                        <?php
                    }

                }
        mysqli_close($link);
?>
</div>
</body>
</html>

