using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    public class Class1
    {
        public static HashSet<string> set1 = new HashSet<string>();
        public static HashSet<string> set2 = new HashSet<string>();
        public static HashSet<string> SET = new HashSet<string>();
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
            Console.WriteLine("3) Объединение множеств - UnionWith");
            Console.WriteLine("4) Пересечение множеств - IntersectWith");
            Console.WriteLine("5) Вычитание второго множества из первого - ExceptWith");
            Console.WriteLine("6) Симметрическая разница множеств - SymmetricExceptWith");
            Console.WriteLine("7) Определение, имеется ли хотя бы один общий элемент во множествах - Overlaps");
            Console.WriteLine("8) Определение, являются ли множества равными - SetEquals");
            Console.WriteLine("9) Определение, является ли множество 1 подмножеством 2 - IsSubsetOf");
            Console.WriteLine("10) Определение, является ли множество 1 надмножеством 2 - IsSupersetOf)");
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
                    Console.Clear();
                    SET = set1;
                    SET.UnionWith(set2);
                    foreach (string i in SET) Console.Write(i + " ");
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.Clear();
                    SET = set1;
                    SET.IntersectWith(set2);
                    foreach (string i in SET) Console.Write(i + " ");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.Clear();
                    SET = set1;
                    SET.ExceptWith(set2);
                    foreach (string i in SET) Console.Write(i + " ");
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.Clear();
                    SET = set1;
                    SET.SymmetricExceptWith(set2);
                    foreach (string i in SET) Console.Write(i + " ");
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.Clear();
                    Console.Write(set1.Overlaps(set2));
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    Console.Write(set1.SetEquals(set2));
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.Clear();
                    Console.Write(set1.IsSubsetOf(set2));
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.Clear();
                    Console.Write(set1.IsSupersetOf(set2));
                    Console.ReadLine();
                    return true;
                default:
                    return true;
            }
        }

        private static void Input()
        {
            Console.WriteLine("Введите элементы первого множества через пробел:");
            string[] a = Console.ReadLine().Split();
            for (int i = 0; i < a.Length; i++) set1.Add(a[i]);
            Console.WriteLine("Введите элементы второго множества через пробел:");
            a = Console.ReadLine().Split();
            for (int i = 0; i < a.Length; i++) set2.Add(a[i]);
            Console.Clear();
        }

        private static void Output()
        {
            Console.WriteLine("Множества:");
            foreach (string i in set1) Console.Write(i + " ");
            Console.WriteLine();
            foreach (string i in set2) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
    