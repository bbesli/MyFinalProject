using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IResult'ın somut sınıfı
    //read only'ler(yani get;'ler) constructor da SET edilebilir.
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)//this(success) ile aşağıdaki tek parametreli class'ı da ekledik.
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
