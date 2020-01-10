using Posts.API.Models;
using Posts.API.Repositories;
using System.Threading.Tasks;

namespace Posts.API.Mutation
{
    public class Mutation
    {
        private readonly IPostsRepository _repository;

        public Mutation(IPostsRepository repository)
        {
            _repository = repository;
        }

        public async Task CreatePost(Post model)
        {
            await _repository.Add(model);
        }
    }
}
