using System.Collections.Generic;

namespace MessagingExampleApp.Interfaces
{
    public interface IRepository<T>
    {
        bool Create(T item);
        bool Update(T item);
        T Find(int id);
        ICollection<T> Get();
    }
}