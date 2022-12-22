/* Task1.Находим максимальное число из 9 чисел.
int Max (int arg1, int arg2, int arg3) //arg-аргументы 
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6   7   8
int [] array = {11, 21, 31, 248, 15, 98, 71, 23, 77};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));


Console.WriteLine($"The muximum number is {max}");
   
*/

// Task2. Имеется одномерный массив (array) из n элементов, требуется
// найти элемент массива, равный find.

int [] array = {1, 2, 31, 5, 87, 69, 27, 44, 31};

int n = array.Length;  // Length - сколько элементов содержится в массиве, столько и выводим
int find = 31;

int index = 0;  // устанавливаем счетчик в позиции ноль

while(index < n)   // если index < n, то переходим к array[index] = find
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;                       //если хотим, чтобы выводился толькпервый элемент
    }

    index = index + 1;
}
