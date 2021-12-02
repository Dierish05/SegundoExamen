using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class BaseServices<T> : IServices<T>
    {
        private IModel<T> Model;
        protected BaseServices(IModel<T> model)
        {
            this.Model = model;
        }
        public void Create(T t)
        {
            Model.Create(t);
        }

        public void Delete(T t)
        {
            Model.Delete(t);
        }

        public int GetLastId()
        {
            return Model.GetLastId();
        }

        public ICollection<T> Read()
        {
            return Model.Read();
        }
    }
}
