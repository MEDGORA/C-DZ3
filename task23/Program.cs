//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число (N): ");
int N = Convert.ToInt32(Console.ReadLine());
if (N<1)
{
    Console.WriteLine("Введите число от 1 или больше");
}
else
    {
    for (int i = 1; i < N+1; i++)
    {
        if (i<N)
        {
        Console.Write(Math.Pow(i,3)+",");
        }
        else
        {
            Console.Write(Math.Pow(i,3));
        }

    }
    }