using OnlineWebShop.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineWebShop.DataAccessContract
{
      public interface IRepository<T> where T : BaseEntity
      {
            Task<List<T>> GetAllAsync();
            void add(T entity);
            void saveChanges();

            Task<bool> delete(T entity);

            Task<bool> update(T entity);
      }
}
