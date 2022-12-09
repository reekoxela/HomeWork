/*
//Программа упорядочит по убыванию элементы каждой строки двумерного массива
int[,] mass = GetArray(3, 4, 0, 10);
Console.WriteLine("Исходный массив: ");
PrintArray(mass);
SortRowsArray(mass);
Console.WriteLine("Массив упорядоченный по убыванию элементы каждой строки: ");
PrintArray(mass);
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

//Сортировка по убыванию элементов каждой строки
void SortRowsArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = j + 1; k < array.GetLength(1); k++){
                if(array[i,j] < array[i,k]){
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

//*************************************************************************************************************************
//Программа находит строку с наименьшей суммой элементов
int[,] mass = GetArray(4, 4, 0, 10);
PrintArray(mass);
Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {SumRows(mass)}");
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

//Поиск строки с наименьшей суммой элементов
int SumRows(int[,] array){
    int[] tempArray = new int[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
        }
        tempArray[i] = sum;
    }
    int min = tempArray[0], minIndex = 0;
    for(int i = 1; i < tempArray.Length; i++){
        if(min > tempArray[i]){
            min = tempArray[i];
            minIndex = i;
        }
    }
    return minIndex;
}


//*********************************************************************************************************************
//Программа находит произведение двух матриц
int[,] arrayA = GetArray(2, 2, 0, 10);
int[,] arrayB = GetArray(2, 2, 0, 10);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
int[,] arrayM = MultiplicationMatrix(arrayA, arrayB);
Console.WriteLine();
PrintArray(arrayM);
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

//Перемножение матриц
int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB){
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for(int i = 0; i < matrixA.GetLength(0); i++){   
        for(int j = 0; j < matrixB.GetLength(1); j++){
            result[i,j] = 0;
            for(int k = 0; k < matrixA.GetLength(1); k++){
                result[i,j] = result[i,j] + matrixA[i,k] * matrixB[k,j];
            }
        }
    }
    return result;
}


////*********************************************************************************************************************
//Программа выводит трёхмерный массив из неповторяющихся двузначных чисел 
int[,,] array = GetArray(2, 2, 2);
PrintArray(array);

//------------------------------------МЕТОДЫ-------------------------------------------
//Создания трёхмерного массива (заполнение неповторяющимися числами)
int[,,] GetArray(int x, int y, int z){
    int[,,] result = new int[x, y, z];
   
    int[] tempArray = new int[result.GetLength(0) * result.GetLength(1) * result.GetLength(2)];
    for(int i = 0; i < tempArray.Length; i++){
        int temp = new Random().Next(10, 100);
        bool flag = false;
        for(int j = 0; j < tempArray.Length; j++){
            if (temp == tempArray[j]) flag = true;
        }
        if(!flag){
            tempArray[i] = temp;
        }
        else{
            i--;
        }
    }
    
    int ii = 0;
    for(int i = 0; i < x; i++){
        for(int j = 0; j < y; j++){
            for(int k = 0; k < z; k++){
                 result[i,j,k] = tempArray[ii];
                 ii++;
            }
        }
    }
    return result;
}

// Вывод трёхмерного масссива
void PrintArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]} ({i},{j},{k})   ");
            }
           Console.WriteLine();
        }
    }
}
*/

//*********************************************************************************************************************