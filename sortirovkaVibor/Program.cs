﻿// СОРТИРОВКА МЕТОДОМ ВЫБОРА
/*
[6, 15, 2, 9, -3]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
2 > -3
MIN = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
[-3, 2, 6, 15, 9]
[6, 15, 9]
MIN = 6
6 < 15
6 < 9
[-3, 2, 6, 15, 9]
[15, 9]
MIN = 15
15 > 9
MIN = 9
[-3, 2, 6, 9, 15]
*/

// вывод элементов массива по возрастанию

Console.WriteLine("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив [" + string.Join(", ", array) + "]"); // Join - соединяет, красивый вывод
// Сортировка массива
for (int i = 0; i < n - 1; i++) // n - 1 - размер массива
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++) // чтобы сравнить числа, j - чтоб не одинаковые числа
    {
        if (array[j] < array[minIndex])
        minIndex = j; // запоминаем номер минимального элемента, чтобы потом поменять местами
    }
    int temp; // переменная для замены элементов
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив [" + string.Join(", ", array) + "]");


// сортировка по длинне массива

char[] array = new char[5]; // char - хранит один символ
for (int i = 0; i < 5; i++)
{
    array[i] = 'a'; //;
}
Console.Write("[" + + string.Join(", ", array) + "]");
/*
приВет // будет больше, позиция буквы имеет значение
прИвет
*/