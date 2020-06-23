using System;
using System.Collections.Generic;
using System.Text;
using VideoModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineWebShop.Data
{
      public class VideoMapper : IEntityTypeConfiguration<VideoModel>
      {

            public void Configure(EntityTypeBuilder<VideoModel> builder)
            {
                  builder.HasKey(k => k.ID);
                  builder.Property(p => p.Name);
                  builder.Property(p => p.AutherName);
                  builder.Property(p => p.Price);
                  builder.Property(p => p.Pic);

            }
      }
}


