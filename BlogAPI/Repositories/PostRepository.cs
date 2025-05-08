using BlogAPI.Dto;
using BlogAPI.Infraestrutura;
using BlogAPI.Model;

namespace BlogAPI.Repositories
{
    public class PostRepository
    {
        private readonly ConnectionContext context = new ConnectionContext();
        public void Add(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
        }

        public List<Post> GetAll()
        {
            return context.Posts.ToList();
        }

        public Post? GetById(Guid id)
        {
            return context.Posts.Find(id);
        }

        public void Update(Post post)
        {
            context.Posts.Update(post);
            context.SaveChanges();
        }

        public void Delete(Post post)
        {
            context.Posts.Remove(post);
            context.SaveChanges();
        }
    }
}
