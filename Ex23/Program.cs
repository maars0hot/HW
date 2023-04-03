// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string Sheet(int Num)
{
    string sheetResult = string.Empty;
    for (int i = 1; i < Num; i++)
    {
        sheetResult = sheetResult+$"{i,5} |  {i*i*i,5}|| \n";
    }
    sheetResult=sheetResult+"___________"+string.Empty;
    return sheetResult;
}

Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

string res = Sheet(N);
Console.Write(res);