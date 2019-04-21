using System;
using AppPruebaAspCore.API.Controllers.Data;
using AppPruebaAspCore.API.Models;

namespace AppPruebaAspCore.API.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext context;
        private IGenericRepository<Value> valuesRepository;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public IGenericRepository<Value> ValuesRepository
        {
            get
            {
                if (this.valuesRepository == null)
                {
                    this.valuesRepository = new GenericRepository<Value>(this.context);
                }

                return this.valuesRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}