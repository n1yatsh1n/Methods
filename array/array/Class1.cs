using System;
using System.Collections;

namespace array
{
    public class Class1
    {
        public static Array Ar;

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
            Console.WriteLine("10) Присвоить значение элементу - SetValue");
            Console.WriteLine("11) Количество измерений - Rank");
            Console.Write("\r\nВыберите метод: ");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Input();
                    return true;
                case "2":
                    PrintValues();
                    return true;
                case "3":
                    Console.Write(Ar.Length);
                    Console.ReadLine();
                    return true;
                case "4":
                    Array.Clear(Ar, 0, Ar.Length);
                    Console.Write("Очищено");
                    Console.ReadLine();
                    return true;
                case "5":
                    Array.Reverse(Ar, 0 , Ar.Length);
                    PrintValues();
                    Array.Reverse(Ar, 0 , Ar.Length);
                    return true;
                case "6":
                    Console.Clear();
                    Console.Write("Введите искомый элемент: ");
                    string element = Console.ReadLine();
                    int search = Array.BinarySearch(Ar, element);
                    Console.WriteLine("находится на {0} позиции",search+1);
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.Clear();
                    Console.Write("Введите элемент: ");
                    string f = Console.ReadLine();
                    Console.Write(Array.IndexOf(Ar, f));
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    Console.Write("Введите элемент: ");
                    string last = Console.ReadLine();
                    Console.Write(Array.LastIndexOf(Ar, last));
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.Clear();
                    Array.Sort(Ar);
                    Console.Write(Ar);
                    return true;
                case "10":
                    Console.Clear();
                    Console.Write("Введите индекс элемента: ");
                    int ind = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите значение элемента: ");
                    string val = Console.ReadLine();
                    Ar.SetValue(val, ind);
                    return true;
                case "11":
                    Console.Clear();
                    Console.Write(Ar.Rank);
                    return true;
                default:
                    return true;
            }
        }
        
            
        
        private static void Input()
        {
            Console.Clear();
            if (Ar == null)
            {
                Console.Write("Создание массива.\nВведите длину: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Ar = Array.CreateInstance(typeof(string), n);
                
                for (int i = Ar.GetLowerBound(0); i <= Ar.GetUpperBound(0); i++)
                {
                    Console.Write("Введите элемент массива: ");
                    Ar.SetValue(Console.ReadLine(),i);
                } 
                    
            }
            else
            {
                Console.Write("Массив уже заполнен");
            }
        }

        private static void PrintValues()
        {
            if (Ar != null)
            {
                foreach (object el in Ar)
                {
                    Console.Write(el + " ");
                }

                Console.ReadLine();
            }
            else
            {
                Console.Write("Пусто");
                Console.ReadLine();
            }
        }
        

    }
}