using System;

namespace SF.Itogi9.Task2
{
    /// <summary>
    /// Мой класс исключения
    /// </summary>
    class MyClassException : Exception
    {
        public MyClassException()
        { }

        public MyClassException(string message)
            : base(message)
        { }

    }
}
