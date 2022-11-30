/*
//ввести с клавиатуры M чисел. Посчитать, сколько чисел строго больше 0 ввёл пользователь
Console.Write("Введите размер массива: ");
int M = int.Parse(Console.ReadLine()!);
int[] mass = InitArray(M);
Console.WriteLine($"Массив: [{String.Join(",",mass)}]");
Console.WriteLine($"Количество чисел больше 0: {Larger0(mass)}");
//-----------------------------------------------МЕТОДЫ--------------------------------------------------
//Заполнение массива
int[] InitArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

//Количество чисел больше 0
int Larger0(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0) count++;
    }
    return count;
}
*/

//программа принимает массив в промежутке от 0 до 100, на выходе выводит этот же массив отсортированный по возрастанию
Console.Write("Введите размер массива: ");
int M = int.Parse(Console.ReadLine()!);
int[] mass = InitArray(M,0,100);
Console.WriteLine($"Массив: [{String.Join(",",mass)}]");
SortArray(mass);
Console.WriteLine($"Отсортированный массив: [{String.Join(",",mass)}]");

//-----------------------------------------------МЕТОДЫ--------------------------------------------------
//Ввод массива
int[] InitArray(int size, int minValue, int maxValue){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

//Сортировка массива
void SortArray(int[] array){
    for(int i = 1; i < array.Length; i++){
        for(int j = 0; j < array.Length - i; j++) {
            if(array[j] > array[j + 1]){
                int tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp; 
            }
        }
    }
}