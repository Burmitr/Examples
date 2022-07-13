
// Задаем и выводим двумерный массив

// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);

// Задаем рекурскию

// double Factorial(int n)
// {
//     // 1!=1
//     // 0!=1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Решаем Фибоначи с помощью рекурсии

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}