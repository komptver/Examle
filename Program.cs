// Пишем методы. 
void FillArray(int [] collection) // называем аргумент collection
{
    int length = collection.Length; // получаем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index = index +1;
    }
}

void PrintArray(int[] col) // массив, который будет печатать результат (void - если метод ничего не возвращает)
{
    int count = col.Length; 
    int position = 0;  // позиция элементов обозначаем count
    while (position < count)
   {
        Console.Write($"{col [position]},  ");
        position++;
   } 
}

int[] array = new int[5]; //ПЕРВЫМ ДЕЙСТВИЕМ создаем массив, который состоит из 10 элементов
                           // далее метод - задали длину массива от 1-10, а потом метод вывод на экран Print
FillArray(array);
PrintArray(array);