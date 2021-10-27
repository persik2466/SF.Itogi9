using System;
using System.Collections.Generic;
using System.Text;

namespace SF.Itogi9.Task1
{   /// <summary>
    /// Собственный класс исключения
    /// </summary>
    public class MyException: Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }

}
