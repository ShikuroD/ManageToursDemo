using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        IList<T> GetAllByStatus(STATUS status = STATUS.ALL);
        T GetBy(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Activate(T entity);

        void Disable(T entity);

        bool Exists(int id);
    }
}
