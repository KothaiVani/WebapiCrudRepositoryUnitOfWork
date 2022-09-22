using Webapi.Services;

namespace Webapi.Configuration
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employee { get; }
        Task CompleteAsync();
        void Dispose();
    }
}