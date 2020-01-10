using Microsoft.EntityFrameworkCore;
using Posts.API.Infrastructure;
using Posts.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts.API.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly PostsContext _context;

        public PostsRepository(PostsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _context.Posts
                .ToArrayAsync();
        }

        public async Task<IEnumerable<Post>> GetAll(bool status)
        {
            return await _context.Posts
                .Where(p => p.Status == status)
                .ToArrayAsync();
        }

        public async Task<IEnumerable<Post>> GetAll(Guid userId)
        {
            return await _context.Posts
                .Where(p => p.UserId == userId)
                .ToArrayAsync();
        }

        public async Task<Post[]> GetBy(Guid id)
        {
            return await _context.Posts
                .Where(p => p.Id == id || p.UserId == id)
                .ToArrayAsync();
        }

        public async Task Add(Post model)
        {
            _context.Posts
                .Add(model);

            await _context.SaveChangesAsync();
        }

        public async Task Update(Post model, Guid postId)
        {
            _context.Entry(await _context.Posts
                .FirstOrDefaultAsync(p => p.Id == postId))
                .CurrentValues
                .SetValues(model);
        }
    }
}
