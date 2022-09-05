// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write ("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {number} равна {SumNumber(number)} ");

int SumNumber (int number)
{
    int result = 0;

    while (number > 0)
    {
        result+= number % 10;
        number = number/10;
    }
    return result;
}


