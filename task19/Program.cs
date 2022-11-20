//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизхначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999 || number < 10000)
{
    Console.WriteLine($"Число {number} не является пятизначным");
}
else
{
    int i = 0;
    int n = 4;
    int a = 0; // Счётчик считает сколько пар цифр (c i-ым и n-ым индексами) совпали в числе
    string str = number.ToString();
    while (i != n)
    {
        if (str[i] == str[n])
        {
            a++;
        }
        i++;
        n--;
    }
    if (a == 2)
    {
        Console.WriteLine($"Да, число {number} является палиндромом");
    }
    else 
    {
        Console.WriteLine($"Нет, число {number} не является палиндромом");
    }
}
        
      
