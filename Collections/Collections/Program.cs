using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

5.	Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. 
Выяснить, является ли строка s2 обратной s1.

6.	Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке:
сначала все слова, начинающиеся на гласную букву, 
потом все слова, начинающиеся на согласную букву, сохраняя исходный порядок в каждой группе слов.

7.	Дан файл, содержащий числа. За один просмотр файла напечатать элементы файла в следующем порядке: 
сначала все положительные числа, 
потом все отрицательные числа, сохраняя исходный порядок в каждой группе чисел.

*/

          

             //            1.Создать коллекцию List < int > .
             //Вывести на экран позицию и значение элемента,
             //являющегося вторым максимальным значением в коллекции.
  #region
             Random rnd = new Random();
             List<int> list = new List<int>();

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Коллекция List < int >");
             Console.ForegroundColor = ConsoleColor.White;
             for (int i = 0; i < 10; i++)
                list.Add(rnd.Next(0, 10));

            IEnumerator<int> etr = list.GetEnumerator();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");

             Console.WriteLine();

             int temp = 0;
             int index = 0;
             var max = list.Max();
             for (int i = 0; i < list.Count(); i++)
             {
                 if ((list[i] > temp) && (list[i] != max))
                 {
                     temp = list[i];
                     index = i;
                 }
             }
             var sum = 0;

             Console.WriteLine("Второй максимальный элемент =" + temp + ", позиция элемента = " + index);

             //Вывести на экран сумму элементов на четных позициях.
             for (int i = 0; i < list.Count(); i++)
             {
                 if (i % 2 == 0)
                 {
                     sum += list[i];
                 }
             }

             Console.WriteLine("Сумма элементов на четных позичиях = " + sum);
            #endregion


            //2.	Удалить все нечетные элементы списка List<int>
           // 8.Удалить все нечетные элементы списка List < int >
             #region
            for (int i = 0; i < list.Count(); i++)
             {
                 if (list[i] % 2 != 0)
                 {
                     list.Remove(list[i]);
                 }
             }
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Четные элементы списка List<int>");
             Console.ForegroundColor = ConsoleColor.White;
             for (int i = 0; i < list.Count(); i++)
             {
                 Console.Write(list[i] + " ");
             }
             Console.WriteLine();
            #endregion

            //3.	Дана коллекция типа List<double>. Вывести на экран элементы списка, 
            // значение которых больше среднего арифметического всех элементов коллекции.
//            9.Дана коллекция типа List<double>.Вывести на экран элементы списка, 
//значение которых больше среднего арифметического всех элементов коллекции.

            #region
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Коллекция типа List<double>");
            Console.ForegroundColor = ConsoleColor.White;
            Random rnd2 = new Random();
            List<double> listD = new List<double>();
            for (int i = 0; i < 10; i++)
                listD.Add(Math.Round((rnd2.NextDouble() * 10), 2));

            IEnumerator<double> etrD = listD.GetEnumerator();
            while (etrD.MoveNext())
                Console.Write(etrD.Current + " ");

            Console.WriteLine();
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Элементы списка, значение которых больше среднего арифметического ("+listD.Average()+")");
            Console.ForegroundColor = ConsoleColor.White;
           
            for (int i = 0; i < 10; i++)
            {
                if (listD[i] > listD.Average())
                {
                    Console.Write(listD[i] + " ");
                }

            }
            Console.WriteLine();
            #endregion
            //4.	Напечатать содержимое текстового файла t, 
            //выписывая литеры каждой его строки в обратном порядке.
            #region



            #endregion


        }
    }
}