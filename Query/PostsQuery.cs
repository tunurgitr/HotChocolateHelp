using HotChocolate;
using Posts.API.Models;
using Posts.API.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Posts.API.Query
{
    public class PostsQuery
    {
        public async Task<IEnumerable<Post>> GetPosts([Service]IPostsRepository repository) => await repository.GetAll();

        public async Task<IEnumerable<Post>> GetUserPosts([Service]IPostsRepository repository, Guid userId) => await repository.GetAll(userId);

        public async Task<IEnumerable<Post>> GetPostById([Service]IPostsRepository repository, Guid id) => await repository.GetBy(id);
    }
}
