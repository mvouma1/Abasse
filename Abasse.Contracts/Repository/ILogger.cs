using System;

namespace Abasse.Contracts.Repository
{
    public interface ILogger
    {
        void Log(Exception ex);
    }
}
