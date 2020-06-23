using OnlineWEbShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoModels;

namespace VideoServiceContract
{
      public interface IVideoServiceContract
      {
            Task<List<VideoModel>> GetVideos();
            Task<bool> DeleteAsync(Guid videoModel);

            Task<bool> AddVideoAsync(VideoModel videoModel);

            Task<bool> UpdateVideoAsync(VideoModel videoModel);
      }
}
