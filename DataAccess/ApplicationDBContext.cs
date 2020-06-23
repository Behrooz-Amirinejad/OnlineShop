using Microsoft.EntityFrameworkCore;
using OnlineWebShop.Data;
using System;
using System.Collections.Generic;
using System.Text;
using VideoModels;

namespace OnlineWebShop.DataAccess
{
      public class ApplicationDBContext : DbContext
      {
            public ApplicationDBContext(DbContextOptions contextOption)
                        : base(contextOption)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                  base.OnModelCreating(modelBuilder);
                  modelBuilder.ApplyConfiguration(new VideoMapper());
            }
      }
}
