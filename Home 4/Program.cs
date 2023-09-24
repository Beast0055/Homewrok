// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
void PrintMax(int arg1, int arg2, int arg3)
{
    int max;
    if(arg1 > arg2 && arg1 > arg3) {
        max = arg1;
    }else if(arg2 > arg1 && arg2 > arg3) {
        max = arg2;
    } else {
        max = arg3;
    }
    Console.WriteLine(max);
}

PrintMax(2, 3, 7);
PrintMax(44, 5, 78);
PrintMax(22, 3, 9);
