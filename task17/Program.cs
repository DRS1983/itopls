//
Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 || x == 0 ) 
{
Console.WriteLine ("x и/или y н= 0. Невозмозможно определить четверть");
}
else
{
if (x > 0 && y > 0) Console.WriteLine ("Точка находиться в первой четверти");
if (x < 0 && y > 0) Console.WriteLine ("Точка находиться во второй четверти");
if (x < 0 && y < 0) Console.WriteLine ("Точка находиться в третьей четверти");
if (x > 0 && y < 0) Console.WriteLine ("Точка находиться в четвёртой четверти");
}