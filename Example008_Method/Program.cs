// Находим максимальное число из 9 чисел.
int Max (int arg1, int arg2, int arg3) //arg-аргументы 
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 21;
int b1 = 47;
int c1 = 5;

int a2 = 11;
int b2 = 777;
int c2 = 1153;

int a3 = 11;
int b3 = 23;
int c3 = 8;

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max2,max3);

int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3)); // можно записать в одну строку

Console.Write($"The maximum number is {max}");




