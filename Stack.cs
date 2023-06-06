using System;
using System.Collections;
using System.Collections.Generic;


namespace Stack1
{
    public class Class1
    {
        public static Stack St = new Stack();
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
            Console.WriteLine("3) Вывести длину - Count");
            Console.WriteLine("4) Удалить все значения - Clear");
            Console.WriteLine("5) Проверка содержания элемента - Contains");
            Console.WriteLine("6) Хэш-код для текущего объекта - GetHashCode");
            Console.WriteLine("7) Вернуть точный тип текущего экземпляра в среде выполнения - GetType");
            Console.WriteLine("8) Вернуть элемент, находящийся на вершине стека, без удаления - Peek");
            Console.WriteLine("9) Вернуть элемент, находящийся на вершине стека, при этом удалив его - Pop");
            Console.WriteLine("10) Вернуть синхронизированный вариант коллекции типа Stack - Synchronized");
            Console.WriteLine("11) Задача на скобки");
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
                    Console.Write(St.Count);
                    Console.ReadLine();
                    return true;
                case "4":
                    St.Clear();
                    Console.Write("Очищено");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.Clear();
                    string el = Console.ReadLine();
                    Console.WriteLine(St.Contains(el));
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.Clear();
                    Console.WriteLine(St.GetHashCode());
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.Clear();
                    Console.WriteLine(St.GetType());
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    Console.WriteLine(St.Peek());
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.Clear();
                    Console.WriteLine(St.Pop());
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.Clear();
                    Console.Write(Stack.Synchronized(St));
                    Console.ReadLine();
                    return true;
                case "11":
                    Console.Clear();
                    Console.Clear();
                    char[] OpenBrackets = { '(', '{', '[', '<' };
                    char[] CloseBrackets = { ')', '}', ']', '>' };
                    char e = ' ';
                    bool right = true;
                    foreach (char i in St)
                    {
                        if (Array.Exists(OpenBrackets, element => element == i))
                        {
                            St.Push(i);
                        }
                        else if (St.Count > 0 && Array.Exists(CloseBrackets, element => element == i))
                        {
                            e = (char)St.Pop();
                            if (CloseBrackets[Array.FindIndex(OpenBrackets, element => element == e)] != i)
                            {
                                right = false;
                            }
                        }
                    }

                    if (St.Count > 0)
                    {
                        right = false;
                    }
                    else
                    {
                        right = true;
                    }
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
                St.Push(element);
                Console.Write("Хотите добавить элемент?\nда/нет");
                if (Console.ReadLine() == "да") check = true;
                else check = false;

            }
        }

        private static void Output()
        {
            foreach (var elem in St)
            {
                Console.WriteLine(elem);
            }

            Console.ReadLine();
        }
        
    }
}