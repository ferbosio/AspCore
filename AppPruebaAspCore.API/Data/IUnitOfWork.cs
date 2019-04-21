using AppPruebaAspCore.API.Controllers.Data;
using AppPruebaAspCore.API.Models;

namespace AppPruebaAspCore.API.Data
{
    public interface IUnitOfWork
    {
        IGenericRepository<Value> ValuesRepository { get; }
        void Save();        
    }
}