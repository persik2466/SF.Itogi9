using System;
using System.Collections.Generic;
//using System.IO;
//using static SF.Itogi9.Task2.Program;

namespace SF.Itogi9.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstName = new List<string>();
            firstName.Add("Сидоров");
            firstName.Add("Петров");
            firstName.Add("Антонов");
            firstName.Add("Иванов");
            firstName.Add("Васечкин");

            Console.WriteLine("Список фамилий до сортировки");
            ShowFio(firstName);

            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += InputNumber;

            bool wl = true;
            while (wl)
            {
                try
                {
                    numberReader.Read(firstName);
                }

                catch (Exception ex) when (ex is MyClassException)
                {
                    wl = false;
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение, введите 1 или 2");
                }
            }

            Console.ReadLine();

        }
        /// <summary>
        /// Ввод числа
        /// </summary>
        /// <param name="number"></param>
        /// <param name="fiostr"></param>
        static void InputNumber(int number, List<string> fiostr)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Список фамилий после сортировки в порядке А-Я");
                    fiostr.Sort();
                    ShowFio(fiostr);
                    break;
                case 2:
                    Console.WriteLine("Список фамилий после сортировки в обратном порядке Я-А");
                    fiostr.Reverse();
                    ShowFio(fiostr);
                    break;
            }
        }
        /// <summary>
        /// Вывод списка на экран
        /// </summary>
        /// <param name="fiostr"></param>
        static void ShowFio(List<string> fiostr)
        {
            foreach (string str in fiostr)
                Console.WriteLine(str);
        }


    }
}
