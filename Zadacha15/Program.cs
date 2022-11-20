// 1-Понедельник, 2- Вторник, 3 - Среда, 4 - Четверг, 5- Пятница, 6 - Суббота, 7 - Воскресенье.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!) ;

if (number < 1 || number > 7) Console.WriteLine("Введено неверное число");
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5) Console.WriteLine("Нет");
if (number == 6 || number == 7) Console.WriteLine("Да");