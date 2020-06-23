using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineWebShop.DataAccess
{
      public class ApplicationGenDBContext<T> : ApplicationDBContext where T : class
      {
            public ApplicationGenDBContext(DbContextOptions contextOption)
                        : base(contextOption)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                  base.OnModelCreating(modelBuilder);

                  modelBuilder.ApplyConfiguration((IEntityTypeConfiguration<T>) Activator.CreateInstance(typeof(T)));
            }
      }
}
