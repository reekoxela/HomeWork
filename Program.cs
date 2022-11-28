/*
//Заполнить массив случайными положительными трёхзначными числами. Программа показывает количество чётных чисел в массиве.
const int size = 10;
int[] mass = InitArray(size);
Console.WriteLine($"Массив: [{String.Join(",",mass)}]");
Console.WriteLine($"Количество чётных чисел в массиве: {EvenNumber(mass)}");

//-----------------------------------------------МЕТОДЫ--------------------------------------------------
//Заполнение массива
int[] InitArray(int size) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

//Подсчет четных чисел
int EvenNumber(int [] array) 
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

//---------------------------------------------------------------------------------------------------------------------------
//Найти сумму элементов, стоящих на нечётных позициях
const int size = 15;
int[] mass = InitArray(size);
Console.WriteLine($"Массив: [{String.Join(",",mass)}]");
Console.WriteLine($"Сумма элементов на нечётных позициях: {SumUneven(mass)}");
//-----------------------------------------------МЕТОДЫ--------------------------------------------------
//Заполнение массива
int[] InitArray(int size) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

//Сумма элементов на нечётных позициях
int SumUneven(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
//---------------------------------------------------------------------------------------------------------

//Найти произведение пар чисел в одномерном массиве. Результат запишите в новом массиве.
Console.Write($"Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] mass = InitArray(size);
Console.WriteLine($"Массив: [{String.Join(",",mass)}]");
Console.WriteLine($"Произведение пар чисел: [{String.Join(",",Multiplication(mass))}]");
//-----------------------------------------------МЕТОДЫ--------------------------------------------------
//Заполнение массива
int[] InitArray(int size) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

//Произведение пар чисел в массиве
int[] Multiplication(int[] array)
{
    int[] mult;
    if(array.Length % 2 == 0)
    {
        mult = new int[array.Length / 2];
    }
    else
    {
        mult = new int[array.Length / 2 + 1];
        mult[array.Length / 2]  = array[array.Length / 2];
    }
    for(int i = 0; i < array.Length / 2; i++)
    {
        mult[i] = array[i] * array[array.Length - i - 1];
    }
    return mult;
}
*/
//-------------------------------------------------------------------------------------------------------
//Найдите разницу между максимальным и минимальным элементов массива
Console.Write($"Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] mass = InitArray(size);
Console.WriteLine($"Массив: [{String.Join(",",mass)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {GetDifference(mass)}");
//-----------------------------------------------МЕТОДЫ--------------------------------------------------
//Заполнение массива
int[] InitArray(int size) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

//Разница между максимальным и минимальным элементами массива
int GetDifference(int[] array)
{
    int min = array[0]; 
    int max = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}