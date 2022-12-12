/*
//Программа выводит все натуральные числа в промежутке от N до 1 (рекурсия)
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Натуральные числа в промежутке от {N} до 1: {PrintNumbers(N)}");

//******************************************************************МЕТОД**********************************************************************
string PrintNumbers(int number){
    if(number == 1) return number.ToString();
    return(number + " " + PrintNumbers(number - 1));
}


//*********************************************************************************************************************************************
//Программа находит сумму натуральных элементов в промежутке от M до N
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {SumNumbers(M,N,0)}");

//******************************************************************МЕТОД**********************************************************************
string SumNumbers(int M, int N, int sum){
    if(M > N) return sum.ToString();
    sum += M;
    M++;
    return(SumNumbers(M,N,sum));
}
*/

//*********************************************************************************************************************************************
//Программа вычисления функции Аккермана с помощью рекурсии
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

if(M < 0 || N < 0){
    Console.WriteLine("Ошибка. Числа должны положительными!");
}
else{
    Console.WriteLine($"A({M},{N}) = {AckermanFunction(M,N)}");
}

//******************************************************************МЕТОД**********************************************************************
int AckermanFunction(int M, int N)
{
    if (M == 0){
        return N + 1;
    }
    else if (M > 0 && N == 0){
        return AckermanFunction(M - 1, 1);
    }
    else{
        return (AckermanFunction(M - 1, AckermanFunction(M, N - 1)));
    }
}