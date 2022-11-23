/*
//программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно: {GetDegree(A,B)}");

//-----------------------------------------------МЕТОД---------------------------------------------------
int GetDegree(int number, int degree) {
    if(degree == 0) {
        return 1;
    }
    else {
        int result = number;
        for(int i = 1; i < degree; i++) {
            result *= number;
        }
        return result;
    }
}


//программу принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {number} равна {GetSum(number)} ");

//-----------------------------------------------МЕТОД---------------------------------------------------
int GetSum(int num) {
    int result = 0;
    while(num > 0) {
        result += num % 10;
        num /= 10;
     }
     return result;
}
*/

// программа задаёт массив из 8 элементов и выводит их на экран
const int size = 8;
int[] mass = InitArray(size);
Console.WriteLine($"Массив из {size} элементов: [{String.Join(",",mass)}]");
Console.Write($"Массив из {size} элементов: ");
PrintArray(mass);
//-----------------------------------------------МЕТОДЫ--------------------------------------------------
//Заполнение массива
int[] InitArray(int size) {
    int[] array = new int[size];
    for(int i = 0; i < size; i++) {
        array[i] = new Random().Next(0,151);
    }
    return array;
}
//Печать массива
void PrintArray(int[] array) {
    Console.Write("[");
    for(int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1) {
            Console.Write($"{array[i]}]");    
        }
        else {
            Console.Write($"{array[i]},");
        }
    }
}