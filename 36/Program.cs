// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19                     //[-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-100, 100);
}
int SummOddIndexPosition(int[] array)
{
   int summa = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if(i % 2 != 0)
         summa = summa + array[i];
   }

   return summa;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма чисел расположенных на нечетных позициях равна: {SummOddIndexPosition(array)}");