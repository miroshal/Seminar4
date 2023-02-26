// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.Write("Введите число: ");
int Inputnumber = Convert.ToInt32(Console.ReadLine());

int GetSum(int num)
{
    int res = 0;
    while(num > 0)
    {
        res = res + (num % 10);
        num /= 10;
    }
    return res;
}
System.Console.WriteLine(GetSum(Inputnumber));