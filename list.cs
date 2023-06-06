using System;
using System.Collections;
using System.Collections.Generic;

namespace list
{
    public class Class1
    {
        public static List<string> Ar = new List<string>();
        public static void Main()
        {
            bool menu_checker = true;
            while (menu_checker)
            {
                menu_checker = Menu();
            }
        }

        public static bool Menu()
        {
            
            Console.Clear();
            Console.WriteLine("--ГЛАВНОЕ МЕНЮ--");
            Console.WriteLine("1) Заполнить - Input");
            Console.WriteLine("2) Вывести значения - Output");
            Console.WriteLine("3) Вывести длину - Lenght");
            Console.WriteLine("4) Удалить все значения - Clear");
            Console.WriteLine("5) Перевернуть наоборот - Reverse");
            Console.WriteLine("6) Поиск индекса эелемента - BinarySearch");
            Console.WriteLine("7) Индекс первого вхождения элемента - IndexOf");
            Console.WriteLine("8) Индекс последнего вхождения элемента - LastIndexOf");
            Console.WriteLine("9) Отсортировать - Sort");
            Console.WriteLine("10) Удалить первое вхождение указанного объекта из коллекции - Remove");
            Console.Write("\r\nВыберите метод: ");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Input();
                    return true;
                case "2":
                    Output();
                    return true;
                case "3":
                    Console.Write(Ar.Count);
                    Console.ReadLine();
                    return true;
                case "4":
                    Ar.Clear();
                    Console.Write("Очищено");
                    Console.ReadLine();
                    return true;
                case "5":
                    Ar.Reverse();
                    Output();
                    Ar.Reverse();
                    return true;
                case "6":
                    Console.Clear();
                    Console.Write("Введите искомый элемент: ");
                    string element = Console.ReadLine();
                    int search = Ar.BinarySearch(element);
                    Console.WriteLine("находится на {0} позиции",search);
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.Clear();
                    Console.Write("Введите элемент: ");
                    string f = Console.ReadLine();
                    Console.Write(Ar.IndexOf(f));
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    Console.Write("Введите элемент: ");
                    string last = Console.ReadLine();
                    Console.Write(Ar.LastIndexOf(last));
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.Clear();
                    Ar.Sort();
                    Console.Write(Ar);
                    return true;
                case "10":
                    Console.Clear();
                    Console.Write("Введите значение элемента: ");
                    string val = Console.ReadLine();
                    Ar.Remove(val);
                    return true;
                default:
                    return true;
            }
        }

        private static void Input()
        {
            bool check = true;
            while (check)
            {
                Console.Write("Введите элемент массива");
                string element = Console.ReadLine();
                Ar.Add(element);
                Console.Write("Хотите добавить элемент?\nда/нет");
                if (Console.ReadLine() == "да") check = true;
                else check = false;

            }
        }

        private static void Output()
        {
            foreach (var elem in Ar)
            {
                Console.WriteLine(elem);
            }

            Console.ReadLine();
        }
    }
}