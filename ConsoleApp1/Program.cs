using System;
using System.Text;
namespace laba
{
    class program
    {
        static void Main(string[] args)
        {
            bool test = true;
            byte test1 = 1;
            sbyte test2 = -120;
            short test3 = -2000;
            ushort test4 = 4523;
            int test5 = 10;
            uint test6 = 6555;
            long test7 = 5646525;
            ulong test8 = 0;
            double test9 = 3.14;
            float test10 = 11;
            char test11 = 'A';
            string test12 = "String";
            object test13 = "Object test";

            Console.WriteLine($"Bool: {test}");
            Console.WriteLine($"Byte: {test1}");
            Console.WriteLine($"Sbyte: {test2}");
            Console.WriteLine($"Short: {test3}");
            Console.WriteLine($"Ushort: {test4}");
            Console.WriteLine($"Int: {test5}");
            Console.WriteLine($"Uint: {test6}");
            Console.WriteLine($"Long: {test7}");
            Console.WriteLine($"Ulong: {test8}");
            Console.WriteLine($"Double: {test9}");
            Console.WriteLine($"Float: {test10}");
            Console.WriteLine($"Char: {test11}");
            Console.WriteLine($"String: {test12}");
            Console.WriteLine($"Object: {test13}");

            //неявное
            byte test14 = 1;
            short test15 = test14;
            int test16 = test14;
            long test17 = test14;
            uint test18 = test14;
            float test19 = test14;

            //явное
            short t20 = 10;
            byte t21 = (byte)t20;

            int t22 = 2;
            byte t23 = (byte)t22;

            long t24 = 44455;
            sbyte t25 = (sbyte)t24;

            ulong t26 = 0;
            ushort t27 = (ushort)t26;

            double t28 = 11;
            float t29 = (float)t28;

            //упаковка и распаковка
            int t30 = 1111;
            object pack = t30;//упаковка
            int unpack = (int)pack;//распаковка

            //неявно типизированная переменная
            var t31 = 3.14;
            var t32 = 1255550022;
            var t33 = -1;

            //nullable
            Nullable<int> t34 = null;//эквивалентно следующей строке
            int? t35 = null;
            int? t36 = t34 * t35;
            Console.WriteLine($"->{t35}<-");

            //строковые литералы
            Console.WriteLine("Строковый литерал");
            string t37 = "Строка 1";
            string t38 = "Строка 2";
            string t39 = "Строка 3";
            //Объединение строк
            string t40 = String.Concat(t37, t38);
            string t41 = String.Concat(t40, t39);
            //копирование строк
            string t42 = String.Copy(t37);
            //выделение подстроки
            string t43 = t38.Substring(2);
            //разделение строки
            string[] t44 = t39.Split(' ');
            //вставка строки
            string t45 = t37.Insert(7, t38);
            //удаление подстроки
            t39 = t39.Remove(5);
            Console.WriteLine(t39);
            t39 = t39.Remove(0, 2);
            Console.WriteLine(t39);
            string t46 = null;
            string t47 = " ";
            string t47t46 = t46 + t47;//слияние
            Console.WriteLine("Слияние: " + t47t46);
            string t48 = String.Concat(t46, t47);
            Console.WriteLine("Объединение: "+t48);
            //stringbuilder
            
            StringBuilder t49 = new StringBuilder("СтрингБилдер");
            Console.WriteLine(t49);
            //удаление символа
            t49.Remove(0,1);
            Console.WriteLine("Удаление символов " + t49);
            //вставка символов в начало и в конец
            t49.Insert(0, "В начало ");
            t49.AppendFormat(" В конец");
            Console.WriteLine(t49);
            //целый двумерный массив
            int[,] massiv = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = massiv.GetUpperBound(0) + 1;
            int columns = massiv.Length / rows;
            for(int i=0; i<rows; i++)
            {
                for (int j=0; j<columns; j++)
                {
                    Console.Write($"{massiv[i, j]} \t");
                }
                Console.WriteLine();
            }
            //массив строк
            string[] stroki = { "One", "Two", "Three" };
            for (int i = 0; i < stroki.Length; i++)
            {
                Console.WriteLine(stroki[i]);//вывод содержимого
            }
            Console.WriteLine(stroki.Length+" длина массива");//длина массива
            stroki[1] = "Два";
            for (int i = 0; i < stroki.Length; i++)
            {
                Console.WriteLine(stroki[i]);//вывод измененного содержимого
            }
            int[][] array = new int[3][];
            array[0] = new int[2];
            array[1] = new int[3];
            array[2] = new int[4];

            Console.WriteLine("Введите элементы массива: ");//ввод массива
            for(int i3=0; i3<array.Length; i3++)
            {
                for (int j3 = 0; j3 < array[i3].Length; j3++)
                {
                    array[i3][j3] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Вывод массива: ");//вывод массива
            for (int i4=0; i4<array.Length; i4++)
            {
                for (int j4=0; j4<array[i4].Length; j4++)
                {
                    Console.Write(array[i4][j4] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //неявно типизированные переменные
            var mass = new object[0];//массив
            var stroka = "";//строка
            (int Num1, string Str1, char Symb, string Str2, ulong Num2) kortez = (25, "строка", 't', "еще строка", 0);//создание кортежа с именованием
            Console.WriteLine(kortez);//вывод кортежа целиком
            Console.WriteLine(kortez.Num1 + " " + kortez.Str2);//вывод элемента по имени
            //деконструкция кортежа
            var kortez2 = ("Один", "Два");
            (string Raz, string Dva) = kortez2;
            var srav1 = (1, 2);
            var srav2 = (3, 4);
            Console.WriteLine(srav1 == srav2);
            Console.WriteLine(srav1 != srav2);
            //функции
            (int, int, int, char) LocalFunction(int[] arr, string str)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), str[0]);
            }
            int[] array1 = { 1, 6, -5, 6, 4, 85, -99, 63 };
            string txt = "Oleg";
            Console.WriteLine(LocalFunction(array1, txt));

            Console.ReadKey();
        }
    }
}