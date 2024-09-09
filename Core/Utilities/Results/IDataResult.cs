using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {

        T Data { get; }
        bool Success { get; }
        string Message { get; } 
    }
}
