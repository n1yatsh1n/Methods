using System;
using System.Collections;

namespace Queuee
{
    public class Class1
    {
        public static Queue Qu;

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
            Console.WriteLine("5) Удалить объект из начала очереди и вернуть его - Dequeue");
            Console.WriteLine("6) Вернуть объект, находящийся в начале очереди, но не удалять его - Peek");
            Console.WriteLine("7) Проверка содержания элемента - Contains");
            Console.WriteLine("8) Вернуть массив, который содержит копии элементов из вызывающей очереди - ToArray");
            Console.WriteLine("9) Вернуть точный тип текущего экземпляра в среде выполнения - GetType");
            Console.WriteLine("10) Xэш-код для текущего объекта - GetHashCode");
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
                    Console.Write(Qu.Count);
                    Console.ReadLine();
                    return true;
                case "4":
                    Qu.Clear();
                    Console.Write("Очищено");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.Clear();
                    Console.Write(Qu.Dequeue());
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.Clear();
                    Console.Write(Qu.Peek());
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.Clear();
                    Console.Write("Введите значение: ");
                    string constain = Console.ReadLine();
                    Console.Write(Qu.Contains(constain));
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    Array ar = Qu.ToArray();
                    foreach (var elem in ar)
                    {
                        Console.Write(elem + " ");
                    }
                    Console.Write(ar);
                    Console.ReadLine();
                    return true;
                
                case "9":
                    Console.Clear();
                    Console.Write(Qu.GetType());
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.Clear();
                    Console.WriteLine(Qu.GetHashCode());
                    Console.ReadLine();
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
                Qu.Enqueue(element);
                Console.Write("Хотите добавить элемент?\nда/нет");
                if (Console.ReadLine() == "да") check = true;
                else check = false;

            }
        }

        private static void PrintValues()
        {
            if (Qu != null)
            {
                foreach (object el in Qu)
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