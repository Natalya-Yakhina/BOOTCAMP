// int n = 5;
// int[] array = new int[n];
// for(int i = 0; i < 5; i++)
// {
//     array[i] = Convert.ToInt32(Console.Readline());
//     Console.WriteLine(string.Join(" ", array)); // join - красивый вывод
// }

// // [4 5 3 1 2]
// // 0(n)
// // [1 2 3 4 5] = 0(n * log n)
// // ((5 + 1) / 2) * 5 = 0(1)
// // n < n * log(n) + 1
// // сумма выдается 0(n), где n - количество элементов

// int summa = 0;
// for(int i = 0; i < n; i++)
// summa += array[i];

// один способ решения таблицы умножения
// int n = Convert.ToInt32(Console.Readline());
// for(int i = 1; i <= n; i++)
// {
//     for(int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j);
//         Console.Write("\t"); // "\t" табуляция форматированный вывод
//     }
//     Console.WriteLine();
// }

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
