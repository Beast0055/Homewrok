// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

 void PrintMax(int arg1, int arg2)
 {
     int max;

     if (arg1 > arg2)
     {
     max = arg1;
     }
     else
     {
         max = arg2;
     }
     Console.WriteLine(max);
 }
 PrintMax(5,7);
 PrintMax(2,10);
 PrintMax(-9,-3);
