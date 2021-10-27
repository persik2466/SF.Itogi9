using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;

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
