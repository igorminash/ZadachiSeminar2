Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;

if (number.Length >= 6) Console.WriteLine("Нарушено условие задачи");

if (number.Length <= 2) Console.WriteLine("Нет третьего числа");

if (number.Length > 2 && number.Length < 6) Console.WriteLine(number[2]);
    
