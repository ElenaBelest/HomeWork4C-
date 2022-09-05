// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив рандоными данными
// от минимального до максимального значение .И важное уточнениее , делать все в методе который возвращает массив
// 5, 1, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]


Console.Write("Enter Min number: ");
int MinNumber = int.Parse(Console.ReadLine());

Console.Write("Enter Max number: ");
int MaxNumber = int.Parse(Console.ReadLine());

Console.Write("Enter array size: ");
int index = Math.Abs(Convert.ToInt32(Console.ReadLine()));


int [] array = new int[index];

void Array (int [] array)
{

    Console.Write("[");
for (int i = 0; i <= index-1; i++)
{
    array[i] =  new Random().Next(MinNumber,MaxNumber+1);
    Console.Write(array[i] + " " );
}
Console.Write("]");
}

 void PrintArray (int [] array)
{
    Console.Write("[");
     for (int i = 0; i < index; i++)
     {
         Console.Write($"{array[i]} ");    
     }
     Console.Write("]");
     Console.WriteLine();

}
Array (array);
 void SelectionSort(int [] array)
{
     for (int i = 0; i < array.Length; i++)
     {
         int minPosition = i;
         for (int j = i+1; j< array.Length; j++)
         {
             if (array[j]< array[minPosition]) minPosition= j;
         }
         int temporary = array[i];
         array[i] = array [minPosition];
         array[minPosition] = temporary;
     }
 }
 
 SelectionSort(array);

Console.WriteLine();

 PrintArray(array);