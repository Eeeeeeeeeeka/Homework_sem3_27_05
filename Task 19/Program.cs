// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 9999 || n > 100000)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
string number = n.ToString();
if (number[0] == number[4] && number[1] == number[3])
Console.Write($"Число {n} является палиндромом");
else
    Console.Write($"Число {n} не является палиндромом");