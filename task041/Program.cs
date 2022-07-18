/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3*/
int[] EnteringArrayConsole(int m)
{
    int i = 0;
    int[] array = new int[m];
    while (i < m)
    {
        Console.Write("Введите целое число : ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
        i++;
    }
    return array;
}
int PositiveNumbers(int[] array)
{
    int i = 0;
    int iNumPosi = 0;
    while (i < array.Length)
    {
        if (array[i] > 0) iNumPosi++;
        i++;
    }
    return iNumPosi;
}
void PrintArray(int[] array)
{
    int i = 0;
    int iArray = array.Length;
    while (i < iArray)
    {
        if (i == iArray - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
        i++;
    }
}

Console.Write("Сколько чисел вы будете вводить? Напишите количество : ");
int mNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[mNumber];
array = EnteringArrayConsole(mNumber);
PrintArray(array);
int numberPos =PositiveNumbers(array);
Console.Write($" -> {numberPos}");