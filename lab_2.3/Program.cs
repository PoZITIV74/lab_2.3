using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _2._3_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите длину строки массива");
            int dlina = Convert.ToInt32(Console.ReadLine());
            object[,] dliona_mas = new object[4, dlina];
            List<int> list = new List<int>();
            for (int i = 0; i < dlina; i++)
            {
                list.Add(i);                        // добавляет в лист
            }
            Console.WriteLine("_____________________________");
            Console.WriteLine();
            foreach (int obj in list)
            {
                Console.Write(" " + obj);    // выводит этот лист
                Console.WriteLine();
            }


            Stack<int> stack = new Stack<int>(list);
            LinkedList<int> link = new LinkedList<int>(list);
            Console.WriteLine("_____________________________");
            Console.WriteLine("Номер:");
            for (int i = 0; i < list.Count; i++)
            {
                dliona_mas[0, i] = i;     // оригинальный объект
                Console.Write(dliona_mas[0, i]);

            }
            Console.WriteLine();
            Console.WriteLine("Впереди стоящие:");

            foreach (int obj2 in list)
            {
                if (obj2 < stack.Count - 1)
                {
                    dliona_mas[1, obj2] = obj2 + 1;  // прибавляет на единицу имеющийся в придыдущей объект
                }
                Console.Write(dliona_mas[1, obj2]);

            }
            Console.WriteLine();
            Console.WriteLine("Позади стоящие:");
            foreach (int obj3 in list)
            {
                if (obj3 > 0 && obj3 != list.Count)
                {
                    dliona_mas[2, obj3] = obj3 - 1;  // уменьшает на единицу 
                }
                Console.Write(dliona_mas[2, obj3]);

            }
            Console.WriteLine();
            Console.WriteLine("Связи:");
            for (int i = 0; i < list.Count; i++)
            {
                int y = 0;

                if (i != list.Count)
                {
                    y = i + 1;       // прибавляет
                }

                if (y == dlina)
                {
                    break;
                }
                string vivod = $"Объект: {i} стоит перед: {y}, ";  // смотрит связи
                _ = (string)(dliona_mas[3, i] = vivod);
                Console.Write(dliona_mas[3, i]);

            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("Выберите нужный пункт");
                Console.WriteLine("1. Объекты с множественными связями");
                Console.WriteLine("2. Связь один ко дному");
                Console.WriteLine("3. Результат");
                string menu = Convert.ToString(Console.ReadLine());
                int main = Convert.ToInt32(menu);
                if (main == 1 || main == 2 || main == 3)
                {
                    if (main == 1)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            int y = 0;
                            int j = 0;

                            if (i != list.Count)
                            {
                                y = i + 1;            //прибавляет имеющийся символ на единицу
                            }
                            if (j != list.Count)
                            {
                                j = y + 1;              //прибавляет имеющийся символ на единицу из прошлого ещё на единицу

                            }
                            if (y == dlina)  // длина объекта
                            {
                                break;
                            }
                            if (j == dlina)
                            {
                                break;
                            }
                            string vivod = $"Объект: {i} стоит перед: {y}, после стоит {j}";            //выводит                 
                            Console.WriteLine(vivod);

                        }
                        Console.ReadLine();
                    }
                    else if (main == 2)
                    {
                        Console.WriteLine("Один к одному");
                        foreach (int i in link)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else if (main == 3)
                    {
                        Console.WriteLine("Cвязанные объекты");
                        foreach (int i in stack)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Объекты без свзяи");
                        foreach (int i in list)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Объекты с множествеными");
                        foreach (int i in link)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Отсутствует");
                    }
                }
                else
                {
                    Console.WriteLine("Не верно введен символ");
                }
            }
        }
    }
}
