using Microsoft.AspNetCore.Hosting;
using ParksService.Data.Abstract.Repositories;
using ParksService.Models;

namespace ParksService.Data.Concrete.Repositories
{
    public class ImageDataRepository : Repository<ImageData>, IImageDataRepository
    {
        public ImageDataRepository(IHostingEnvironment env) : base(env, "/parks.json")
        {
        }
    }
}