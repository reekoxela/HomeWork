/*
//программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//первый вариант
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;
 if (number.Length != 5) {
    Console.WriteLine("Ошибка! Это не пятизначное число!");
}
else {
    int length = number.Length;
    bool flag = true;
    for(int i = 0; i < length / 2; i++) {
        if (number[i] != number[length - i - 1])
        {
             flag = false;
             break;
        }
    }
    if (flag == true) {
        Console.WriteLine("Число является палиндромом");
    }
    else {
        Console.WriteLine("Число не является палиндромом");
    }

}    
//второй вариант
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 10000 || number > 99999) {
    Console.WriteLine("Ошибка! Это не пятизначное число!");
}
else {
    int number2 = 0, n1, n2 = number;
    while (n2 > 0) {
        n1 = n2 % 10;
        n2 = n2 / 10;
        number2 = number2 * 10 + n1;
    }
    if (number == number2)  {
        Console.WriteLine("Число является палиндромом");
    }
    else {
        Console.WriteLine("Число не является палиндромом");
    }
}

//программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("Введите Xa =  ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите Ya = ");
int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите Za = ");
int Za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("Введите Xb =  ");
int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите Yb = ");
int Yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите Zb = ");
int Zb = int.Parse(Console.ReadLine()!);

double result = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2);
Console.WriteLine($"Расстояние между точками: {Math.Sqrt(result):f2}");
*/

//программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.Write("Введите число =  ");
int N = int.Parse(Console.ReadLine()!);

Console.Write($"Таблица кубов чисел от 1 до {N}: ");
for(int i = 1; i <= N; i++) {
    Console.Write($"{Math.Pow(i,3)} ");
}