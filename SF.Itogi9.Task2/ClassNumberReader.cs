using System;
using System.Collections.Generic;
using System.Text;

namespace SF.Itogi9.Task2
{
/// <summary>
/// Класс ввода числа
/// </summary>
    public class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number, List<string> fiostr);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read(List<string> fiostr)
        {
            Console.WriteLine();
            Console.WriteLine("Для сортировки списка фамилий А-Я введите 1 \nдля сортировки в обратном порядке Я-А введите 2 \nвыход из сортировки 0");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) throw new MyClassException("Вы произвели выход из сортировки");
            if (number != 1 && number != 2) throw new FormatException();
            NumberEntered(number, fiostr);
        }
        /// <summary>
        /// Вызов события
        /// </summary>
        /// <param name="number"></param>
        /// <param name="fiostr"></param>
        protected virtual void NumberEntered(int number, List<string> fiostr)
        {
            NumberEnteredEvent?.Invoke(number, fiostr);
        }
    }

}

