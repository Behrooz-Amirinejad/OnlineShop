using OnlineWebShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VideoModels
{
      [Table("Video")]
      public class VideoModel : BaseEntity
      {
            
            public string Name { get; set; }
            public string AutherName { get; set; }
            public decimal Price { get; set; }

            public string Pic { get; set; }
      }
}
