Console.WriteLine("Каловый калькулятор собственого производства предстовляет");
Console.WriteLine("Использовать можно только + - * /");
Console.WriteLine("Запрашиваю вас написать 2 числа 1 деление множение и тд.");
Console.WriteLine("Веди Число");
string Пупс = Console.ReadLine();
double число1;
Console.WriteLine("Поздровляю ты написал аж целае число");
double.TryParse(Пупс, out число1);
Console.WriteLine("Веди Число номер 2");
string Пупсик = Console.ReadLine();
double число2;
Console.WriteLine("Поздровляю ты написал аж целае второе Число");
double.TryParse(Пупсик, out число2);
string[] Переменка = { "+", "-", "*", "/" }; //нельзя юзать даблу запомни если ето не значение и точка, юзай стринги если ето не число, и не юзай [] такие скобки в масивах,юзай такие {} 
Console.WriteLine("Ты уже на финеше а мне еще писать строк 50 кода, Напиши свой оператор pls");
string Опера = Console.ReadLine();
Console.WriteLine("Поздровляю щас будет обед");
if (Опера == "+")
{
    double обед = число1 + число2;
    Console.WriteLine($"Обед = {обед}");
}
if (Опера == "-")
{
    double обед = число1 - число2;
    Console.WriteLine($"Обед = {обед}");
}
if (Опера == "*")
{
    double обед = число1 * число2;
    Console.WriteLine($"Обед = {обед}");
}
if (Опера == "/")
{
    double обед = число1 / число2;
    Console.WriteLine($"Обед = {обед}");
}