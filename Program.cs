
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10000;
int numB = num/1000;
int num2 = numB%10;
int numD = num/10;
int num3 = numD%10;
int num4 = num%10;


if (num1 == num4 && num2 == num3)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
