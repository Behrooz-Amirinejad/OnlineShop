using AutoMapper;
using OnlineWebShop.DataAccessContract;
using OnlineWEbShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoModels;
using VideoServiceContract;

namespace VideoBusinesService
{
      public class VideoBusinessService : IVideoServiceContract
      {
            private readonly IRepository<VideoModel> _videoRepository;

            public IMapper _mapper { get; }

            public VideoBusinessService(IRepository<VideoModel> videoRepistory )
            {
                  _videoRepository = videoRepistory;
            }

            public Task<bool> AddVideoAsync(VideoModel videoModel)
            {
                  try
                  {

                        _videoRepository.add(videoModel);
                        _videoRepository.saveChanges();
                        return (Task.FromResult(true));
                  }
                  catch (Exception ex)
                  {

                        return (Task.FromResult(true));
                  }
            }

            public Task<bool> DeleteAsync(Guid videoModel)
            {

                return(  _videoRepository.delete(new VideoModel() { ID = videoModel }));
            }

            public Task<List<VideoModel>> GetVideos()
            {
                  var result = _videoRepository.GetAllAsync();
                  
                  return (result);
            }

            public Task<bool> UpdateVideoAsync(VideoModel videoModel)
            {
                  return (_videoRepository.update(videoModel));
            }
      }
}
