<?php
$dbHost = "localhost";
$dbUser = "root";
$dbPass = "fe5jvsmz";
$dbName = "Vieru";

$dbLink = mysqli_connect($dbHost,$dbUser,$dbPass,$dbName)
or die("номер ошибки: ".mysqli_connect_errno().
    "(".mysqli_connect_error().")");
mysqli_query($dbLink,"SET CHARACTER SET 'utf8'");



require '../vendor/autoload.php';
$token = "680686163:AAHjtqUEIo8olxcsn1z5oVbYNIlcfnly-ME";
$url = "https://api.telegram.org/bot";
use Telegram\Bot\Api;
$telegram = new Api($token);
$response = json_decode($telegram -> getWebhookUpdates());

$keyboard = array(
    array('По категориям'),
    array('По белкам, жирам и улгеводам'));
$keyboard = json_encode(array('keyboard' => $keyboard));

$keyboard1 = array(
    array('Грибы','Колбасы','Крупы'),
    array('Молочное','Мучное','Мясное'),
    array('Овощи','Орехи','Рыба'),
    array('Фрукты'),
    array('Назад'));
$keyboard1 = json_encode(array('keyboard' => $keyboard1));

$keyboard2 = array(
    array('Белки','Жиры','Углеводы'),
    array('Назад'));
$keyboard2 = json_encode(array('keyboard' => $keyboard2));

$keyboard3 = array(
    array('Белки от 0 до 10'),
    array('Белки от 10 до 20'),
    array('Белки от 20 и более'),
    array('Обратно'));
$keyboard3 = json_encode(array('keyboard' => $keyboard3));
$keyboard4 = array(
    array('Жиры от 0 до 10'),
    array('Жиры от 10 до 20'),
    array('Жиры от 20 и более'),
    array('Обратно'));
$keyboard4 = json_encode(array('keyboard' => $keyboard4));
$keyboard5 = array(
    array('Углеводы от 0 до 10'),
    array('Углеводы от 10 до 20'),
    array('Углеводы от 20 и более'),
    array('Обратно'));
$keyboard5 = json_encode(array('keyboard' => $keyboard5));

if ($response->message->text == '/start') {
    $telegram->sendMessage(['chat_id' => $response->message->chat->id,
        'text' => "Добро пожаловать в \"Каллорийного бота\". \n Вы можете выбирать из 10 категорий продуктов, по 10 в каждом из них.\n А так же можете отсортировать продукты по диапазону белков, жиров или углеводов.",
        'reply_markup' => $keyboard
    ]);
}

if ($response->message->text == 'Грибы') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Грибы\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

         $telegram->sendMessage(['chat_id' => $response->message->chat->id,
             'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
        'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Колбасы') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Колбаса\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Крупы') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Крупы\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Молочное') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Молочные\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Мучное') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Мучное\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Мясное') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Мясное\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Овощи') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Овощи\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Орехи') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Орехи\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Рыба') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Рыба\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Фрукты') {
    $dbQuery = "SELECT * FROM `Products` WHERE `Category`= \"Фрукты\"";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard1
        ]);
    }
}
if ($response->message->text == 'Белки от 0 до 10') {
    $dbQuery = "SELECT * FROM `Products` WHERE Belok >= 0 AND Belok <=10";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard3
        ]);
    }
}
if ($response->message->text == 'Белки от 10 до 20') {
    $dbQuery = "SELECT * FROM `Products` WHERE Belok >= 10 AND Belok <=20";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard3
        ]);
    }
}
if ($response->message->text == 'Белки от 20 и более') {
    $dbQuery = "SELECT * FROM `Products` WHERE Belok >= 20";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard3
        ]);
    }
}
if ($response->message->text == 'Жиры от 0 до 10') {
    $dbQuery = "SELECT * FROM `Products` WHERE Jir >= 0 AND Jir <=10";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard4
        ]);
    }
}
if ($response->message->text == 'Жиры от 10 до 20') {
    $dbQuery = "SELECT * FROM `Products` WHERE Jir >= 10 AND Jir <=20";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard4
        ]);
    }
}
if ($response->message->text == 'Жиры от 20 и более') {
    $dbQuery = "SELECT * FROM `Products` WHERE Jir >= 20";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard4
        ]);
    }
}
if ($response->message->text == 'Углеводы от 0 до 10') {
    $dbQuery = "SELECT * FROM `Products` WHERE Uglevod >= 0 AND Uglevod <=10";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard5
        ]);
    }
}
if ($response->message->text == 'Углеводы от 10 до 20') {
    $dbQuery = "SELECT * FROM `Products` WHERE Uglevod >= 10 AND Uglevod <=20";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard5
        ]);
    }
}
if ($response->message->text == 'Углеводы от 20 и более') {
    $dbQuery = "SELECT * FROM `Products` WHERE Uglevod >= 20";
    $dbResult = mysqli_query($dbLink,$dbQuery);
    while ($row = mysqli_fetch_assoc($dbResult)) {
        $Category = $row['Category'];
        $Name = $row['Name'];
        $Kkal = $row['Kkal'];
        $Belok = $row['Belok'];
        $Jir = $row['Jir'];
        $Uglevod = $row ['Uglevod'];

        $telegram->sendMessage(['chat_id' => $response->message->chat->id,
            'text' => "Категория: ".$Category."\nНазвание: ".$Name."\nКкал: ".$Kkal."\nБелки: ".$Belok." Жиры: ".$Jir." Углеводы: ".$Uglevod,
            'reply_markup' => $keyboard5
        ]);
    }
}

switch ($response->message->text){
    case "По категориям":
        $telegram->sendMessage([
            'chat_id' => $response->message->chat->id,
            'text' => "Для продолжения выбери одну из десяти категорий",
            'reply_markup' => $keyboard1
        ]);break;
    case "По белкам, жирам и улгеводам":
        $telegram->sendMessage([
            'chat_id' => $response->message->chat->id,
            'text' => "Для продолжения выбери по какому из параметров ты хочешь сделать выборку",
            'reply_markup' => $keyboard2
        ]);break;
    case "Белки":
        $telegram->sendMessage([
            'chat_id' => $response->message->chat->id,
            'text' => "Выбери по какому диапазону требуется сделать выборку",
            'reply_markup' => $keyboard3
        ]);break;
    case "Жиры":
        $telegram->sendMessage([
            'chat_id' => $response->message->chat->id,
            'text' => "Выбери по какому диапазону требуется сделать выборку",
            'reply_markup' => $keyboard4
        ]);break;
    case "Углеводы":
        $telegram->sendMessage([
            'chat_id' => $response->message->chat->id,
            'text' => "Выбери по какому диапазону требуется сделать выборку",
            'reply_markup' => $keyboard5
        ]);break;
    case "Назад":
        $telegram->sendMessage([
            'chat_id' => $response->message->chat->id,
            'text' => "Возвращаемся назад",
            'reply_markup' => $keyboard
        ]);break;
    case "Обратно":
        $telegram->sendMessage([
            'chat_id' => $response->message->chat->id,
            'text' => "Возвращаемся назад",
            'reply_markup' => $keyboard2
        ]);break;
}
?>