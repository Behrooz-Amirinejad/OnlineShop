using Microsoft.EntityFrameworkCore;
using OnlineWebShop.Data;
using OnlineWebShop.DataAccessContract;
using OnlineWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OnlineWebShop.DataAccess
{
      public class Repository<T> : IRepository<T> where T : BaseEntity
      {
            private readonly ApplicationDBContext _appContext;
            private DbSet<T> _dbEntity;

            public Repository(ApplicationDBContext appContext)
            {
                  _appContext = appContext;
                  _dbEntity = _appContext.Set<T>();
            }
            public void add(T entity) => _dbEntity.Add(entity);

            public Task<bool> delete(T entity)
            {
                  try
                  {
                        _appContext.Remove(entity);
                        this.saveChanges();
                        return (Task.FromResult(true));
                  }
                  catch (Exception)
                  {

                        return (Task.FromResult(false));
                  }
            }

            public Task<List<T>> GetAllAsync() => _dbEntity.ToListAsync();

            public Task<bool> update(T entity)
            {
                  var updatedEntity = _appContext.Set<T>()
                                                .FirstOrDefault(z => z.ID == entity.ID);
                                               
                  if(updatedEntity != null)
                  {
                        _appContext.Entry(updatedEntity).CurrentValues.SetValues(entity);//.State = EntityState.Modified;
                        saveChanges();
                        return (Task.FromResult(true));
                  }
                  else
                        return (Task.FromResult(false));
            }


            public void saveChanges()
            {
                  _appContext.SaveChanges();
            }
      }
}
