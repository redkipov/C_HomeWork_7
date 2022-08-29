using System;
using System.Threading.Tasks;
using System.Threading;

//HomeWork 7 C#
//Developer kipov.m.h
//29.08.2022

namespace HomeWork2
{
    class Program
    {
        ////////////Глобальные переменные////////////////
        public const string VerDev = "V.0.2.1";
        //////Номер задания//////
        public const string NamberWork = "Home work 7";
        //////Название программ///////
        public const string ProgramName_1 = "Программа создает двумерный массив размером M на N, заполненный случайными вещественными числами. M = 3, N = 4";
        public const string ProgramName_2 = "Программа принимает на вход позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.";
        public const string ProgramName_3 = "Программа создает двумерный массив из целых чисел. Находит среднее арифметическое элементов в каждом столбце.";
        public const string ProgramName_4 = "Null";
        public const string ProgramName_5 = "Null";
        //////////////////////////////
        public static bool LoadScrin = true;
        ///////

        ///////////////////////////////////////// Промежуточное меню для выхода или продолжнеия программы //////////////////////////////
        static void Contin()
        {
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы начать.");

            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.\n");
            Console.ResetColor();
        }
        //////////////////////////////////// Выход из программы по нажатию кнопок //////////////////////////////////////////////////////
        static int textWrite(int Exit_Play, string NameProg)
        {
            Contin();
           
            while (true)
            {
                var Presskey = Convert.ToString(Console.ReadKey().Key);
                if (Presskey == "q0" || Presskey == "End" || Presskey == "Backspace" || Presskey == "Escape" || Presskey == "Q1" || Presskey == "Q" || Presskey == "q")
                {
                    return 0;
                }
                else if (Presskey == "Enter" || Presskey == "Spacebar")
                {
                    return 1;
                }
                else
                {
                    devWrite(NameProg);
                    Contin();
                }
            }
        }
        ///////////////////////////////// Очистка экрана и вывод redkipov. ////////////////////////////////////////////////////////////
        static void devWrite(string s)
        {
            Console.Clear();
            const String nameDev = "redkipov";
            Console.ForegroundColor = ConsoleColor.Cyan; // цвет 
            Console.Write("developer - ");
            Console.ForegroundColor = ConsoleColor.DarkRed; // цвет 
            Console.WriteLine(nameDev);
            Console.ForegroundColor = ConsoleColor.DarkGray; // цвет 
            Console.WriteLine(VerDev);
            Console.ForegroundColor = ConsoleColor.Yellow; // цвет 
            Console.WriteLine(s);
            Console.ResetColor();
        }
        /////////////////////////////////////////////////// Меню приветствия //////////////////////////////////////////////////////////
        //___________________________________________________________________________________________________________________________//
        static void WelcomeWrite(string NameProg)
        {
            devWrite(NameProg);
            Console.ForegroundColor = ConsoleColor.DarkCyan; //  цвет
            Console.WriteLine(NamberWork);
            Console.ForegroundColor = ConsoleColor.Green; //  цвет зеленый
            Console.Write("Введите соотвествующую цифру программы, которую вы хотите ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; //  цвет
            Console.WriteLine("запустить");
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[1] "); ////// Первая программа.
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_1);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[2] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_2); 
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[3] ");  
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_3); /*
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[4] "); 
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_4);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[5] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_5); */
            ///////////////////////////////////////////////////////////
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        //############################################### Программа 1 ###############################################################//
        //###########################################################################################################################//
        static void Program_1(int Exit_Play)
        {
            ///////////переменные
            double[,] array = new double[3,4] { { 0, 0, 0, 0 },
                                                { 0, 0, 0, 0 },
                                                { 0, 0, 0, 0 }};
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[1] {ProgramName_1}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                array = ShuffleVi(array,115);  
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.WriteLine("Размер массива: [3,4]");
                for (int n = 0; n < array.GetLength(0); n++) 
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        if (m < array.GetLength(1)-1) 
                        {
                            Console.Write(m+1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[n,m]:F2}. "));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else 
                        {
                            Console.Write(m+1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[n,m]:F2}.\n"));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 2 ###############################################################//
        //###########################################################################################################################//
        static void Program_2(int Exit_Play)
        {
            ///////////переменные
            int[,] array = new int[3,4] { { 0, 0, 0, 0 },
                                          { 0, 0, 0, 0 },
                                          { 0, 0, 0, 0 }};
            int result = 0;
            int count = 0;
            int UserNumbers = 0;
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[2] {ProgramName_2}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                array = Shuffle(array);
                count = 0;
                result = 0;
                UserNumbers = 0;
                devWrite(NameProg);
                Console.WriteLine("Сгенерированный массив чисел: ");
                
                for (int n = 0; n < array.GetLength(0); n++) 
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        if (m < array.GetLength(1)-1) 
                        {
                            Console.Write(m+1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[n,m]:F0}. "));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else 
                        {
                            Console.Write(m+1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[n,m]:F0}.\n"));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                Console.Write($"Введите число для поиска: ");
                Console.ForegroundColor = ConsoleColor.Red;
                var usStr = Console.ReadLine();
                ///////// Если нет ошибок.
                try 
                {
                    UserNumbers = Convert.ToInt32(usStr);
                    for (int n = 0; n < array.GetLength(0); n++) 
                    {
                        for (int m = 0; m < array.GetLength(1); m++)
                        {
                            if (UserNumbers == array[n,m]) 
                            {
                                result = array[n,m];
                                count++;
                            }
                        }
                    }
                    if (count>0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("                                       \r \r");
                        Console.WriteLine($"Найдено совпадений в массиве: {count}. ");
                        Console.Write("Совпавшее число: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{result}.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else 
                    {
                        Console.Write("                                       \r \r");
                        Console.WriteLine($"Найдено совпадений в массиве: {count}. ");
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Нет такого элемента в массиве.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                ///////// Если произошла ошибка.
                catch 
                {
                    UserNumbers = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы вводите не число!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 3 ###############################################################//
        //###########################################################################################################################//
       static void Program_3(int Exit_Play)
        {
            ///////////переменные
            int[,] array = new int[3,4] { { 0, 0, 0, 0 },
                                          { 0, 0, 0, 0 },
                                          { 0, 0, 0, 0 }};
            double[] result = new double[5] {0,0,0,0,0};
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[3] {ProgramName_3}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica ((((((((((((((((( 3 
                // сброс переменных на ноль.
                result = new double[]{0,0,0,0,0,0};
                array = new int[3,4] {  { 0, 0, 0, 0 },
                                        { 0, 0, 0, 0 },
                                        { 0, 0, 0, 0 }};
                array = Shuffle(array);
                devWrite(NameProg);
                Console.WriteLine("Сгенерированный массив чисел: ");
                //// Вывод массива на экран 3
                for (int n = 0; n < array.GetLength(0); n++) 
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        if (m < array.GetLength(1)-1) 
                        {
                            Console.Write(m+1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[n,m]:F0}. "));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else 
                        {
                            Console.Write(m+1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[n,m]:F0}.\n"));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                ///////// Если нет ошибок. 3
                try 
                {
                    // перебор массива, сложение и деление столбов.
                    for (int m = 0; m < array.GetLength(1); m++) 
                    {
                        for (int n = 0; n < array.GetLength(0); n++)
                        {
                            
                            result[m] = result[m] + array[n,m];
                            if (n == array.GetLength(0)-1)
                            {
                                result[m] = result[m]/3;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"Среднеe арифметическое каждого столбца");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{result[0]-0.00001:F1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", 2:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{result[1]-0.00001:F1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", 3:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{result[2]-0.00001:F1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", 4:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{result[3]-0.00001:F1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                ///////// Если произошла ошибка. 3
                catch 
                {
                    //UserNumbers = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка при расчетах!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                //))))))))))))))))) End Logica ((((((((((((((((( 3
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа 4 ###############################################################//
        //###########################################################################################################################//
 /*     static void Program_4(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[4] {ProgramName_4}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                //))))))))))))))))) Logica ((((((((((((((((( 
                int UserNumbers = 123;
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array, 0, 300);
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 9 && array[i] < 100)
                    {
                        result++;
                    }
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("123 сгенерерованных чисел в массиве: ");
                WriteArray(array, 1);
                Console.Write("\nКоличество элементов массива, которые лежат в отрезке от 10 до 99: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(result);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(".\n");
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа 5 ###############################################################//
        //###########################################################################################################################//
        static void Program_5(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[5] {ProgramName_5}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                //))))))))))))))))) Logica ((((((((((((((((( 
                Console.WriteLine("Введите размер массива (не больше 20-ти): ");
                int UserNumbers = Convert.ToInt32(Console.ReadLine());
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array, 1, 20);
                int[] resultArrey = new int[array.Length];
                int size = array.Length - 1;
                int trig = 0;
                if (array.Length % 2 == 0)
                {
                    for (int i = 0; i < size; i++)
                    {
                        resultArrey[i] = array[i] * array[size];
                        size--;
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        resultArrey[i] = array[i] * array[size];
                        size--;
                        trig = i + 1;
                    }
                    resultArrey[(array.Length - 1) - trig] = array[(array.Length - 1) - trig];
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("Числа в массиве: ");
                WriteArray(array, 1);
                Console.Write("Произведение пар чисел в массиве: ");
                Console.ForegroundColor = ConsoleColor.Green;
                WriteArray(resultArrey, 0);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
    */
        //############################################### Программа скрытая #########################################################//
        //###########################################################################################################################//
        static void Program_7(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = "Скрытое меню";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                devWrite(NameProg);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Генератор 20 случайных чисел");
                Console.ResetColor();
                ////////**************** Logica **************////////
                //int[,] array = CreaterArray(20);
                //WriteArray(array, 1);
                //array = Shuffle(array, 0, 100);
                //WriteArray(array, 1);
                ////////**************** End Logica **************////////
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        /////////////////// функции работы с массивами //////////////////
        static int WriteArray(int[] array, int zero)
        {
            int numbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                    else if (array[i] > 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                }
                else
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else if (array[i] > 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else
                    {
                        Console.Write(".......\n");
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            if (zero == 1) { return numbers = 0;}
            else { return numbers;}
        }
        ////////////////////////////////////////////////   
        static int WriteArrayVi(decimal[] array, int zero) //2
        {
            int numbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    if (zero == 1 || zero == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                    else if (array[i] > 0 && zero == 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                }
                else
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else if (array[i] > 0 && zero == 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else
                    {
                        Console.Write(".......\n");
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            if (zero == 1) {return numbers = 0;} else {return numbers;}
        }
        ///////////////////////////////
        static int[] CreaterArray(int number)
        {
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        ////////////////////////////////
        static decimal[] CreaterArrayVi(int number) //2
        {
            decimal[] array = new decimal[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        /////////////////////////////////
        static int[,] Shuffle(int[,] array)
        {
            int number = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                for (int f = 0; f < array.GetLength(1); f++) 
                {
                    Thread.Sleep(1);
                     //double j = new Random().Next(0, i + 1);
                     number = new Random().Next(0, i + 200);
                     array[i,f] = array[i,i];
                     array[i,f] = number;
                }
            }
            return array;
        }
        ////////////////////////////////
        static double[,] ShuffleVi(double[,] array, int amout1) //2
        {
            Random random = new Random();
            double number = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int f = 0; f < array.GetLength(1); f++) 
                {
                    Thread.Sleep(1);
                    //double j = new Random().Next(0, i + 1);
                     number = random.NextDouble()* 100 - amout1 + 100;
                     array[i,f] = array[i,i];
                     array[i,f] = number;
                }
            }
            return array;
        }

        //******************************************************** MAIN *********************************************************************//
        //###################################################################################################################################//

        static void Main(string[] args)
        {
            var PresskeyP = "Null";
            const String NameProg = "Главное меню";
            int Exit_Play = 1;
            WriteMenu(NameProg);
            while (true)
            {
                /////////////////////////////////////////// Ожидание нажатия кнопки //////////////////////////////////////////
                PresskeyP = Convert.ToString(Console.ReadKey().Key);

                //////////////////////////////////// Выбор пункта меню, нужной программы /////////////////////////////////////
                if (PresskeyP == "D1" || PresskeyP == "NumPad1")
                {
                    LoadScrin = false;
                    //Console.CursorVisible = true;
                    Program_1(Exit_Play); //запуск функции
                    LoadScrin = true;
                    WriteMenu(NameProg);
                }
                else if (PresskeyP == "D2" || PresskeyP == "NumPad2")
                {
                    LoadScrin = false;
                    Console.CursorVisible = true;
                    Program_2(Exit_Play); //запуск функции
                    LoadScrin = true;
                    WriteMenu(NameProg);
                }
                else if (PresskeyP == "D3" || PresskeyP == "NumPad3")
                {
                    LoadScrin = false;
                    //Console.CursorVisible = true;
                    Program_3(Exit_Play); //запуск функции
                    LoadScrin = true;
                    WriteMenu(NameProg);
                }
                else if (PresskeyP == "D4" || PresskeyP == "NumPad4")
                {
                    //Program_4(Exit_Play);
                }
                else if (PresskeyP == "D5" || PresskeyP == "NumPad5")
                {
                    //Program_5(Exit_Play);
                }
                else if (PresskeyP == "D6" || PresskeyP == "NumPad6")
                {
                    //Program_6(Exit_Play);
                }
                else if (PresskeyP == "D7" || PresskeyP == "NumPad7")
                {
                    LoadScrin = false;
                    Console.CursorVisible = true;
                    Program_7(Exit_Play); //запуск функции
                    LoadScrin = true;
                    WriteMenu(NameProg);
                }
                else if (PresskeyP == "q0" || PresskeyP == "End" || PresskeyP == "Backspace" || PresskeyP == "Escape" || PresskeyP == "Q1" || PresskeyP == "Q" || PresskeyP == "q")
                {
                    System.Environment.Exit(-1);
                    return;
                }

            }
        }


        static void WriteMenu(String NameProg)
        {
            WelcomeWrite(NameProg);
            Console.WriteLine(" ");
            Method();
        }

        ///// BETA
        static async void Method()
        {
            int k = 0;
            char[] LoadString = {'/' ,'/', '/', '/', '/', '/', '/', '/', '/', '/' };
            ///////////////////////////////////////////////// Task 1
            await Task.Run(() =>
            {
                //async
            });
            ///////////////////////////////////////////////// Task 2
            while (LoadScrin)
            {
                await Task.Delay(500);
                k++;
                if (LoadScrin)
                {
                    //await Task.Delay(950);
                    //Thread.Sleep(1000);
                    Console.Write($"                                                 \r");
                    Console.CursorVisible = false;
                    var Time = DateTime.Now;
                    Console.Write($"{Time}      ");
                }
                else if (!LoadScrin) {return;}
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < k; i++) { Console.Write(LoadString[i]); if (k==LoadString.Length+1) {k = 0;} }
                Console.ForegroundColor = ConsoleColor.White;
            }
            //await Task.Run(() => Program_7(1) );
        }
    }
        //######################################################## END ###############################################################//
}
//###########################################################################################################################//