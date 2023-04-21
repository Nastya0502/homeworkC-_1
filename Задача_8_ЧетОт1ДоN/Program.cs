//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное число N, которое больше 1");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;
if (n>1)
{
    while (index<n-1)
    {
        if (index%2 == 0)
        {
            Console.Write(index);
            Console.Write(", ");
        }
        index ++;
        
    }
    if ((n-1)%2 == 0)
        {
            Console.Write(n-1);
        }
    if (n%2 == 0)
        {
            Console.Write(n);
        }
    
}
else
{
    Console.WriteLine("Введите число, больше 1!!");
}