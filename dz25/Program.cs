// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int BasisOfDigree, int DegreeIndicator)
{
    int res = 1;
    for (int i = 0; i < DegreeIndicator; i++)
    {
        res = res * BasisOfDigree;
    }
    return res;
}
System.Console.WriteLine(Exponentiation(num1, num2));