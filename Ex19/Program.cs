// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int Number = Convert.ToInt32(Console.ReadLine());
int result = Reverse(Number);
if (result !=0)
{
    Console.WriteLine($"Число {result} явл-ся палиндромом");
}
else 
{
    Console.WriteLine("Число не явл-ся палиндромом");
}

int Reverse(int n)
{
    int n1 = n % 10;
    int n2 = n / 10 % 10;
    int n3 = n / 100 % 10;
    int n4 = n / 1000 % 10;
    int n5 = n / 10000;
    int result = n1 * 10000 + n2 * 1000 + n3 * 100 + n4*10+n5;
    if (n1==n5 && n2==n4)
    {
        return result;
    }
    return result=0;
    
}
