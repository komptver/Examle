void FillArray(int[] collection)  // метод, пишем имя
{
    int len = collection.Length; // длина массива 
    int index = 0;
    while (index < len)
    {
        collection[index] = new Random().Next(1, 10);  // положим новое число из диапазона от 1 до 10
        index = index +1; // или можно записать index++
            }   
}

void PrintArray(int[] col) //void - если метод ничего не возвращает, т.е. нет return
{
    int count = col.Length; // количество элементов
    int position = 0;
    while(position < count) // цикл
    {
        Console.WriteLine(col[position]); // будем выводить через консоль (col[position])
        position++;   
    }
}

int Index0(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
    
int [] array = new int[10];   // создал новый массив в котором 10 элементов
 
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0(array, 4);
Console.WriteLine(pos);