<?php
date_default_timezone_set ('Etc/GMT-5');
$date = date("y.m.d");
$time = date ("H:i:s");
$redirectURI = "http://318128-momomuze.tmweb.ru/web/shpion.php";
require_once 'connection.php';
require_once 'Parametrs.php';

    $link = mysqli_connect($host, $user, $password, $database) // подключаемся к серверу
    or die ("Ошибка cвязи с базой данных" . mysqli_error($link));

    $query ="SELECT `ID` FROM `Polz`";
    $result = mysqli_query($link,$query) or die("Ошибка" . mysqli_error($link));
    if($result)
    {
        $rows = mysqli_num_rows($result);
        for ($i = 0 ; $i < $rows ; ++$i)
        {
            $row = mysqli_fetch_row($result) or die("Ошибка" . mysqli_error($link));
            $clientId = $row[0];
            date_default_timezone_set ('Etc/GMT-5');
            echo $date," ", $time;
            echo "<br>";

            $request_params = array(
                    'user_id' => $clientId,
                    'fields' => 'online',
                    'v' => '5.101',
                    'access_token' => $token
                    );
            $get_params = http_build_query($request_params);
            $reqStr = json_decode(file_get_contents('https://api.vk.com/method/users.get?'. $get_params));
            echo ($reqStr -> response[0] -> first_name);
            echo " ";
            echo ($reqStr -> response[0] -> last_name);
            echo "<br>";
            echo ($reqStr -> response[0] -> id);
            $id = $reqStr -> response[0] -> id;
            echo "<br>";
            $first_name = mysqli_real_escape_string($link, $reqStr -> response[0] -> first_name);
            $last_name = mysqli_real_escape_string($link, $reqStr -> response[0] -> last_name);
            $status = mysqli_real_escape_string($link, $reqStr -> response[0] -> online);
            if($reqStr -> response[0] -> online )
            {
                echo "online";
            }else echo "offline";
            echo "<br>";

            $query = "SHOW TABLES LIKE '".$clientId."';";
            $stmt = mysqli_query($link,$query) or die
            ("Ошибка" . mysqli_error($link));
            $query ="INSERT INTO `polzovateli`.`".$id."` (name,status,date,time) VALUES('".$first_name."','".$status."','".$date."','".$time."')";
            $stmt = mysqli_query($link, $query) or die("Ошибка " . mysqli_error($link));
            if ($stmt)
            {
                echo "данные записаны";
                echo "<br>";
                echo "-----------------";
                echo "<br>";
            }
        }
    }
    mysqli_close($link);
?>
