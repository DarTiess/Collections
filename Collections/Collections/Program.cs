using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


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
            Console.WriteLine("Элементы списка, значение которых больше среднего арифметического (" + listD.Average() + ")");
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Напечатать содержимое текстового файла t, выписывая литеры каждой его строки в обратном порядке.");
            Console.ForegroundColor = ConsoleColor.White;

            string text = @"E:\GitHub\Collections\t.txt";
            Stack<string> tq = new Stack<string>();

            using (StreamReader sr = new StreamReader(text))
            {
                string line;
              
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    for (int i = 0; i < line.Length; i++)
                    {
                        tq.Push(line[i].ToString());
                    }
                }
            }
            
            Console.WriteLine("------------------------");
           foreach(var i in tq)
            {
                Console.Write(i);
        }
          
            Console.WriteLine();
            #endregion
            // 5.Даны 2 строки s1 и s2. Из каждой можно читать по одному символу.
            //Выяснить, является ли строка s2 обратной s1.
            #region
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Даны 2 строки s1 и s2.");
            Console.ForegroundColor = ConsoleColor.White;

            Queue<string> s1q=new Queue<string>();
            Queue<string> s2q = new Queue<string>();
            string s1 = "JavaScripte";
            string s2 = "etpircSavaJ";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            for(int i = 0; i < s1.Length; i++)
            {
                s1q.Enqueue(s1[i].ToString());
            }
          
           for(int i = 0; i < s2.Length; i++)
            {
                s2q.Enqueue(s2[i].ToString());
            }
            if (s1.SequenceEqual(s2.Reverse()))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("строка s2 обратна s1");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Строки разные и не совпадают");
                Console.ForegroundColor = ConsoleColor.White;
            }

            #endregion

            //6.Дан текстовый файл. 
            //За один просмотр файла напечатать элементы файла в следующем порядке:
            //сначала все слова, начинающиеся на гласную букву,
            //потом все слова, начинающиеся на согласную букву, 
            //сохраняя исходный порядок в каждой группе слов.
           #region
            
            using (StreamReader sr = new StreamReader(text))
            {
                string line;
                string[] line2;
             
                while ((line = sr.ReadLine()) != null)
                {
                    line2 = line.Split(' ');
                    List<string> lin3 = new List<string>();
                    List<string> lin4 = new List<string>();
                    string alp = "aeyuio";
                    for (int i = 0; i < line2.Length; i++) {
                        lin4.Add(line2[i]);
                        for(int j = 0; j < alp.Length; j++) {
                            if ((line2[i].StartsWith((alp[j].ToString()).ToLower()))|| line2[i].StartsWith((alp[j].ToString()).ToUpper()))
                            {
                                lin4.Remove(line2[i]);
                                lin3.Add(line2[i]);
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("слова, начинающиеся на гласную букву");
                    Console.ForegroundColor = ConsoleColor.White;

                    foreach (var i in lin3)
                    {
                        Console.WriteLine(i);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("слова, начинающиеся на согласную букву");
                    Console.ForegroundColor = ConsoleColor.White;

                    foreach (var i in lin4)
                    {
                        Console.WriteLine(i);
                    }

                }
               }

            #endregion
 
//7.	Дан файл, содержащий числа. 
//За один просмотр файла напечатать элементы файла в следующем порядке: 
//сначала все положительные числа, 
//потом все отрицательные числа, 
//сохраняя исходный порядок в каждой группе чисел.

            #region
            string numbt= @"E:\GitHub\Collections\numbers.txt";
            Queue<int> numberst = new Queue<int>();
         
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                numberst.Enqueue(random.Next(-20, 20));
            }

            using (StreamWriter sw=new StreamWriter(numbt))
            {
                foreach (var i in numberst)
                {
                    sw.WriteLine(i);
                }
            }

            using (StreamReader sr = new StreamReader(numbt))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.Write(line+" ");
                }
            }
            Queue<int> numPol = new Queue<int>();
            Queue<int> numOtr = new Queue<int>();
            using (StreamReader sr = new StreamReader(numbt))
            {
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        numPol.Enqueue(line[i]);
                        if (line[i]<0)
                        {
                            numOtr.Enqueue(line[i]);
                            numPol.ToList().Remove(line[i]);
                        }
                       
                    }
                    
                    foreach(var i in numPol)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("-----------------");
                    foreach (var i in numOtr)
                    {
                        Console.Write(i + " ");
                    }

                }
            }

                    #endregion
                    Console.WriteLine();
                }
    }
}