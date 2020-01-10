using HotChocolate;
using Posts.API.Models;
using Posts.API.Repositories;
using System.Threading.Tasks;

namespace Posts.API.Mutation
{
    public class PostsMutation
    {
        public async Task CreatePost([Service]IPostsRepository repository, Post model)
        {
            await repository.Add(model);
        }
    }
}
