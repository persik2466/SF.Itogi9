using System;
using System.IO;

namespace SF.Itogi9.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var exception = new Exception[]
            { new FileNotFoundException("Файл не существует."), 
              new DivideByZeroException("Деление на ноль."), 
              new MyException("Моё собственное исключение."), 
              new FormatException("Некорректное значение."), 
              new OverflowException("Переполнение.") };
            
            foreach (Exception exc in exception)
            {
                try
                {
                    throw exc;
                }
                catch (Exception ex) when (ex is FileNotFoundException)
                {
                    Console.WriteLine("Вызвано исключение: " + ex.Message);
                }
                catch (Exception ex) when (ex is DivideByZeroException)
                {
                    Console.WriteLine("Вызвано исключение: " + ex.Message);
                }
                catch (Exception ex) when (ex is MyException)
                {
                    Console.WriteLine("Вызвано исключение: " + ex.Message);
                }
                catch (Exception ex) when (ex is FormatException)
                {
                    Console.WriteLine("Вызвано исключение: " + ex.Message);
                }
                catch (Exception ex) when (ex is OverflowException)
                {
                    Console.WriteLine("Вызвано исключение: " + ex.Message);
                }

                finally 
                {
                    Console.WriteLine();
                }
                
            }

            Console.ReadKey();

        }
    }
}
