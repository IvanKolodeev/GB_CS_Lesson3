// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void PrintArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     Console.Write(col[i] + "  ");
// }

void NumberToArray(int number, int[] array)
{
    while (number > 0)
    {
        int digit = number % 10;
        array[number.ToString().Length - 1] = digit;
        number /= 10;       
    }
}

Console.WriteLine("Enter number");
int a = int.Parse(Console.ReadLine()!);
int length = a.ToString().Length;

if (length != 5)  Console.WriteLine("Not 5-digit number");
else
{
    // Преобразование числа в массив
    int[] array = new int[length];
    NumberToArray(a, array);
    // PrintArray(array);

    // Второй массив - реверс первого
    int[] array2 = new int[length];
    for (int i = 0; i < length; i++)
    {
     array2[i] = array[length - 1 - i];
    }
    // Console.WriteLine();
    // PrintArray(array2);

    // сравнение двух массивов
    Boolean isArrayEqual = true;
    for (int i = 0; i < length; i++)
    if (array[i] != array2[i])
    isArrayEqual = false;

    // вывод результатов сравнения
    if (isArrayEqual == false)
    Console.WriteLine("Noooooo");
    else
    // Console.WriteLine();
    Console.WriteLine("Polindrom");
}