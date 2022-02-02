//
// Домашнее задание к занятию 9. Обработка исключений
//
// Задача 1. Смоделируйте работу простого калькулятора. 
// Программа должна запрашивать 2 числа, а затем – код операции 
// (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
// После этого на консоль выводится ответ. 
// Используйте обработку исключений для защиты от ввода некорректных данных.

Console.WriteLine("Вас приветсвует калькулятор!");
int x = 0;
int y = 0;
int z = 0;
try
{
    Console.Write("Введите целое число. Х=");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число. Y=");
    y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите код операции:\n 1 - сложение \n 2 - вычитание \n 3 - умножениее \n 4 - частное ");
    Console.WriteLine("Ваш выбор: ");
    z = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка ввода. "+ex.Message);
    Console.ReadKey();
    return;
}
switch (z)
{
    case 1:
        {
            Console.WriteLine("Результат равен = {0}", x + y);
            break;
        }
    case 2:
        {
            Console.WriteLine("Результат равен = {0}", x - y);
            break;
        }
    case 3:
        {
            Console.WriteLine("Результат равен = {0}", x * y);
            break;
        }
    case 4:
        {
            try
            {
                Console.WriteLine("Результат равен = {0}", x / y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Попытка деления на 0. " + ex.Message);
            }
            break;
        }
        default:
        {
            Console.WriteLine("Некорректный выбор");
            break;
        }
}
Console.ReadKey ();
