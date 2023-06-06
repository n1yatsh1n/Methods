using System;
using System.Collections;
using System.Collections.Generic;

namespace dictionary
{
    public class Class1
    {
        public static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>() { { 1, "one" }, { 2, "two" }, { 3, "three" } };
            foreach (var e in dict)
            {
                Console.WriteLine($"Ключ: {e.Key}; Значение: {e.Value}.");
            }
            Console.WriteLine("Выберите действие:"); 
            Console.WriteLine("1. Добавить ключ-значение"); 
            Console.WriteLine("2. Очистить словарь");
            Console.WriteLine("3. Содержание ключа");
            Console.WriteLine("4. Содержание значения");
            Console.WriteLine("5. Удалние ключ-значение");
            ConsoleKeyInfo smth; 
            smth = Console.ReadKey(); 
            if (smth.Key == ConsoleKey.D1)
            {
                Console.Clear(); 
                Console.WriteLine("Введите ключ:");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение:");
                string val = Console.ReadLine(); 
                dict.Add(key, val); 
                Console.WriteLine("Получившийся словарь:"); 
                foreach (var slov in dict) 
                { 
                    Console.WriteLine($"Ключ: {slov.Key}; Значение: {slov.Value}."); 
                }
            }
            else if (smth.Key == ConsoleKey.D2)
            {
                Console.Clear();
                dict.Clear();
                Console.WriteLine("Очищенный словарь:");
                foreach (var slov in dict) 
                { 
                    Console.WriteLine($"Ключ: {slov.Key}; Значение: {slov.Value}."); 
                }
            }
            else if (smth.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("Введите ключ:");
                int key = Convert.ToInt32(Console.ReadLine());
                if (dict.ContainsKey(key) == true)
                {
                    Console.WriteLine("Да, содержится");
                }
                else
                {
                    Console.WriteLine("Нет, не содержится");
                }
            }
            else if (smth.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Console.WriteLine("Введите ключ:");
                string val = Console.ReadLine();
                if (dict.ContainsValue(val) == true)
                {
                    Console.WriteLine("Да, содержится");
                }
                else
                {
                    Console.WriteLine("Нет, не содержится");
                }
            }
            else if (smth.Key == ConsoleKey.D5)
            {
                Console.Clear();
                Console.WriteLine("Введите ключ:");
                int key = Convert.ToInt32(Console.ReadLine());
                dict.Remove(key);
                Console.WriteLine("Получившийся словарь:");
                foreach (var slov in dict)
                {
                    Console.WriteLine($"Ключ: {slov.Key}; Значение: {slov.Value}.");
                }
            }
        }
    }
}