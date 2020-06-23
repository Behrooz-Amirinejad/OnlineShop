using AutoMapper;
using OnlineWEbShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoModels;

namespace OnlineWebShop.BusinessService.Mapper
{
      public class MappingProfile : Profile
      {
            public MappingProfile()
            {
                  CreateMap<List<VideoViewModel>, List<VideoModel>>().ReverseMap();
            }
      }
}
