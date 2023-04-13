using System;
using System.Collections;

namespace SortedList1
{
    public class Class1
    {
        public static SortedList Sl = new SortedList();
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
            Console.WriteLine("5) Првоерка на содержание ключа - ContainsKey");
            Console.WriteLine("6) Првоерка на содержание значения - ContainsValue");
            Console.WriteLine("7) Значение, указываемое по индексу - GetBylndex");
            Console.WriteLine("8) Значение ключа указываемое по индексу - GetKey");
            Console.WriteLine("9) Все значения - GetValueList");
            Console.WriteLine("10) Удалить элемент с указанным ключом - Remove");
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
                    Console.Write(Sl.Count);
                    Console.ReadLine();
                    return true;
                case "4":
                    Sl.Clear();
                    Console.Write("Очищено");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.Clear();
                    string itemKey = Console.ReadLine();
                    Console.WriteLine(Sl.ContainsKey(itemKey));
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.Clear();
                    string itemValue = Console.ReadLine();
                    Console.WriteLine(Sl.ContainsValue(itemValue));
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.Clear();
                    int ind = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Sl.GetByIndex(ind));
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    int indKey = Convert.ToInt32(Console.ReadLine());
                    Console.Write(Sl.GetKey(indKey));
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.Clear();
                    foreach (var SlValue in Sl.GetValueList())
                    {
                        Console.WriteLine(SlValue);
                    }

                    Console.ReadLine();
                    return true;
                case "10":
                    Console.Clear();
                    Console.Write("Введите значение элемента: ");
                    string val = Console.ReadLine();
                    Sl.Remove(val);
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
                Console.Write("Введите элемент ключ ");
                string keyElement = Console.ReadLine();
                bool checkValue = true;
                Sl[keyElement] = Console.ReadLine();
                Console.WriteLine("Хотите добавить еще элемент в SortedList?\nда/нет ");
                string ansElement = Console.ReadLine();
                if (ansElement == "да") check = true;
                else if (ansElement == "нет") check = false;
            }
        }

        private static void Output()
        {
            for (int i = 0; i < Sl.Count; i++)
            {
                Console.WriteLine("Ключ" + Sl.GetKey(i));
                Console.WriteLine(Sl.GetByIndex(i));
            }

            Console.ReadLine();
        }
    }
}