using Posts.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Posts.API.Repositories
{
    public interface IPostsRepository
    {
        Task<IEnumerable<Post>> GetAll();
        Task<IEnumerable<Post>> GetAll(bool status);
        Task<IEnumerable<Post>> GetAll(Guid userId);
        Task<Post[]> GetBy(Guid id);
        Task Add(Post model);
        Task Update(Post model, Guid postId);
    }
}
