using System;
using System.Collections.Generic;
using System.Text;

namespace Abasse.Contracts.Handlers
{
    public interface IExceptionHandlers
    {
        T Run<T>(Func<T> func);
    }
}
