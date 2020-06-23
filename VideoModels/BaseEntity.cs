using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineWebShop.Model
{
      public class BaseEntity
      {
            [Key]
            public Guid ID { get; set; }
      }
}
