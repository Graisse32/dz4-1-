string slovaPogoda;
Console.WriteLine("Вас приветсвует русско-английский переводчик");
Console.WriteLine("Вы можете перевести следуйщие слова:прогноз погоды,дождь,природа,ветер,климат,холод,гидрометцентр,синоптик,осадки,облачность");
slovaPogoda = Console.ReadLine();
// weather forecast rain nature wind climate hydrometeorological center synoptic precipitation cloudiness
switch (slovaPogoda)
{
    case "прогноз погоды":
        {
            Console.WriteLine("Перевод слова прогноз погоды - weather forecast");
            break;
        }
    case "дождь":
        {
            Console.WriteLine("Перевод слова дождь - rain");
            break;
        }
    case "природа":
        {
            Console.WriteLine("Перевод слова природа - nature");
            break;
        }
    case "ветер":
        {
            Console.WriteLine("Перевод слова ветер - wind");
            break;
        }
    case "климат":
        {
            Console.WriteLine("Перевод слова климат - climate");
            break;
        }
    case "холод":
        {
            Console.WriteLine("Перевод слова холод - cold");
            break;
        }
    case "гидрометцентр":
        {
            Console.WriteLine("Перевод слова гидрометцентр - hydrometeorological center");
            break;
        }
    case "синоптик":
        {
            Console.WriteLine("Перевод слова синоптик - synoptic");
            break;
        }
    case "осадки":
        {
            Console.WriteLine("Перевод слова осадки - precipitation");
            break;
        }
    case "облачность":
        {
            Console.WriteLine("Перевод слова облачность - cloudiness");
            break;
        }
    default:
        {
            Console.WriteLine("Ошибка,такого слова нету");
            break;
        }

}

Console.ReadKey();
