Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine()!;


if (number.Length !=3)
{
    Console.WriteLine("Введено неверное число");
}
else
{
     Console.WriteLine(number[1]);
}
