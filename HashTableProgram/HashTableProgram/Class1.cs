using System;
using System.Collections;

namespace HashTableProgram
{
    public class Class1
    {
        public static Hashtable hashtable = new Hashtable();

        
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
            Console.WriteLine("2) Вывести ключ: значение - Output");
            Console.WriteLine("3) Вывести длину - Count");
            Console.WriteLine("4) Удалить все значения - Clear");
            Console.WriteLine("5) Проверить, существует ли введённый ключ в таблице - ContainsKey");
            Console.WriteLine("6) Проверить, существует ли введённое значение в таблице - ContainsValue");
            Console.WriteLine("7) Вывести все значения таблицы - Keys");
            Console.WriteLine("8) Вывести все ключи таблицы - Values");
            Console.WriteLine("9) Вывести значение по ключу");
            Console.WriteLine("10) Вывести ключ по значению");
            Console.Write("\r\nВыберите метод: ");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Console.Clear();
                    Input();
                    return true;
                case "2":
                    Console.Clear();
                    PrintValues();
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    Console.Write(hashtable.Count);
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    hashtable.Clear();
                    Console.Write("Очищено");
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Введите ключ:");
                    string hashTableKey = Console.ReadLine();
                    if (hashtable.ContainsKey(hashTableKey))
                    {
                        Console.WriteLine("Существует");
                    }
                    else
                    {
                        Console.WriteLine("Не существует");
                    }
                    Console.ReadKey();
                    return true;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Введите значение:");
                    string hashTableValue = Console.ReadLine();
                    if (hashtable.ContainsValue(hashTableValue))
                    {
                        Console.WriteLine("Существует");
                    }
                    else
                    {
                        Console.WriteLine("Не существует");
                    }
                    Console.ReadKey();
                    return true;
                case "7":
                    Console.Clear();
                    foreach (string o in hashtable.Values)
                    {
                        Console.WriteLine(o);
                    }
                    Console.ReadKey();
                    return true;
                case "8":
                    Console.Clear();
                    foreach (string o in hashtable.Keys)
                    {
                        Console.WriteLine(o);
                    }
                    Console.ReadKey();
                    return true;
                case "9":
                    Console.Clear();
                    Console.WriteLine("Введите ключ:");
                    string key = Console.ReadLine();
                    foreach (string o in hashtable.Keys)
                    {
                        if (o == key) Console.WriteLine("Значение: " + hashtable[key]);
                    }
                    Console.ReadKey();
                    return true;
                case "10":
                    Console.Clear();
                    Console.WriteLine("Введите значение:");
                    string value = Console.ReadLine();
                    foreach (DictionaryEntry o in hashtable)
                    {
                        if (o.Value.ToString() == value)
                        {
                            Console.WriteLine("Ключ: " +  o.Key.ToString());
                        } 
                    }
                    Console.ReadKey();
                    return true;
                default:
                    return true;
            }
        }

        public static void PrintValues()
        {
            foreach (string hashtableKey in hashtable.Keys)
                Console.WriteLine($"{hashtableKey}: " + hashtable[hashtableKey]);
        }
        
        public static void Input()
        {
            Console.WriteLine("Введите название ключа:");
            string hashTableKey = Console.ReadLine();
            Console.WriteLine("Введите значение:");
            string hashTableValue = Console.ReadLine();
            hashtable.Add(hashTableKey, hashTableValue);
        }
    }
}