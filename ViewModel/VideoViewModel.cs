using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineWEbShop.ViewModel
{
      public class VideoViewModel
      {
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string AutherName { get; set; }
            public decimal Price { get; set; }

            public string Pic { get; set; }
      }
}
