// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число");
var x = Console.ReadLine();

/*
do
{
Console.WriteLine("Введите пятизначное число");
var x = Console.ReadLine();
}
while (x < 9999 && x > 99999);
*/

string s = Convert.ToString(x);
string r = new(x.ToCharArray().Reverse().ToArray());
if (s == r)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}