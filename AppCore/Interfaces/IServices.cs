using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public interface IServices<T>
    {
        void Create(T t);
        void Delete(T t);
        ICollection<T> Read();
        int GetLastId();
    }
}
