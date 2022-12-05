/*
//двумерный массив размером m×n, заполненный случайными вещественными числами
Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);

double[,] mass = GetArray(m,n,-50,50);
PrintArray(mass);
//------------------------------------МЕТОДЫ-------------------------------------------
//Создания двумерного массива
double[,] GetArray(int rows, int cols, int minValue, int maxValue){
    double[,] result = new double[rows, cols];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < cols; j++){
            result[i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        }
    }
    return result;
}

// Вывод двумерного масссива
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f1}     ");
        }
        Console.WriteLine();
    }
}

//***************************************************************************************************************************************
//программа принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
int[,] mass = GetArray(3, 4, 0, 50);
PrintArray(mass);

Console.Write("Введите номер строки массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца массива: ");
int col = int.Parse(Console.ReadLine()!);

if (row < 0 || col < 0){
    Console.Write("Номера строки и столбца должны быть положительными!");
}
else{
    FindElement(mass,row,col);
}

//------------------------------------МЕТОДЫ-------------------------------------------
//Создания двумерного массива
int[,] GetArray(int rows, int cols, int minValue, int maxValue){
    int[,] result = new int[rows, cols];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < cols; j++){
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Вывод двумерного масссива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array, int row, int col){
    if(row > array.GetLength(0) || col > array.GetLength(1)){
        Console.WriteLine($"Элемента с позицией [{row},{col}] в массиве нет!");
    }
    else{
        Console.WriteLine($"Элемент с позицией [{row},{col}] = {array[row,col]}");
    }
*/

//***************************************************************************************************************************************
//Найти среднее арифметическое элементов в каждом столбце двумерного массива
int[,] mass = GetArray(3, 4, 0, 10);
PrintArray(mass);
double[] avr = AverageCols(mass);
Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: [{string.Join("   ",avr)}]");
//------------------------------------МЕТОДЫ-------------------------------------------
//Создания двумерного массива
int[,] GetArray(int rows, int cols, int minValue, int maxValue){
    int[,] result = new int[rows, cols];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < cols; j++){
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Вывод двумерного масссива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}

//Cреднее арифметическое элементов в каждом столбце двумерного массива
double[] AverageCols(int[,] array){
    double[] avr = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++){
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++){
            sum += array[i,j];
        }
        avr[j] = Math.Round(sum / array.GetLength(0),2);
    }
    return avr;    
}