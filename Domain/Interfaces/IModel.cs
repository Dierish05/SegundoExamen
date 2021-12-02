using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        void Delete(T t);
        ICollection<T> Read();
        int GetLastId();
    }
}
